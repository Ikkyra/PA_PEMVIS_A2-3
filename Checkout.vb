Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class Checkout
    Dim WithEvents pd As New PrintDocument
    Public Property invoiceItems As List(Of Tuple(Of Integer, String, Decimal, Integer))

    Dim SubTotal As Decimal = 0
    Dim Total As Decimal = 0
    Dim PaymentMethod As String = ""

    Public Property TotalHarga As Decimal
    Public Property CashierForm As Cashier


    Private Sub Checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotal.Text = "Rp " & TotalHarga.ToString("N2")
        lblKembalian.Text = "Change: Rp 0.00"
    End Sub

    Private Sub BtnAngka_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click,
        btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click

        Dim btn As Button = CType(sender, Button)
        txtBayar.Text &= btn.Text
        HitungKembalian()
    End Sub

    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackSpace.Click
        If txtBayar.Text.Length > 0 Then
            txtBayar.Text = txtBayar.Text.Substring(0, txtBayar.Text.Length - 1)
        End If
        HitungKembalian()
    End Sub

    Private Sub ClearForm()
        txtFirstname.Clear()
        txtLastname.Clear()
        txtPhone.Clear()
        txtBayar.Clear()
        rbCash.Checked = False
        rbNonCash.Checked = False
        lblKembalian.Text = "Change: Rp 0.00"
    End Sub

    Private Sub HitungKembalian()
        Dim dibayar As Decimal
        If Decimal.TryParse(txtBayar.Text, dibayar) Then
            Dim kembali = dibayar - TotalHarga
            lblKembalian.Text = "Change: Rp " & kembali.ToString("N2")
            lblKembalian.ForeColor = If(kembali >= 0, Color.Lime, Color.Red)
        Else
            lblKembalian.Text = "Change: Rp 0.00"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Cashier.Show()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If String.IsNullOrWhiteSpace(txtFirstname.Text) OrElse
       String.IsNullOrWhiteSpace(txtLastname.Text) OrElse
       String.IsNullOrWhiteSpace(txtPhone.Text) Then
            MessageBox.Show("Mohon lengkapi data pelanggan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If invoiceItems Is Nothing OrElse invoiceItems.Count = 0 Then
            MessageBox.Show("Tidak ada item untuk disimpan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not rbCash.Checked AndAlso Not rbNonCash.Checked Then
            MessageBox.Show("Pilih metode pembayaran (Cash/Card).", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim dibayar As Decimal
        If String.IsNullOrWhiteSpace(txtBayar.Text) OrElse Not Decimal.TryParse(txtBayar.Text, dibayar) Then
            MessageBox.Show("Mohon isi jumlah pembayaran yang valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If rbCash.Checked AndAlso lblKembalian.ForeColor = Color.Red Then
            MessageBox.Show("Jumlah pembayaran kurang. Tidak dapat mencetak struk.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Total = TotalHarga
        PaymentMethod = If(rbCash.Checked, "Cash", "Card")

        Try
            SimpanTransaksi()
            PrintPreviewDialog1.Document = pd
            PrintPreviewDialog1.ShowDialog()
            Cashier.clfrom = True
            Cashier.CheckClearForm()
            ClearForm()
            Me.Close()
            Cashier.Show()
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pd_PrintPage(sender As Object, e As PrintPageEventArgs) Handles pd.PrintPage
        Dim g As Graphics = e.Graphics
        Dim fontTitle As New Font("Arial", 14, FontStyle.Bold)
        Dim fontHeader As New Font("Arial", 10, FontStyle.Bold)
        Dim fontBody As New Font("Arial", 10)
        Dim y As Integer = 20

        g.DrawString("Backlund Galleyrya", fontTitle, Brushes.Black, 100, y) : y += 25
        g.DrawString("Kalimantan Timur, Samarinda", fontBody, Brushes.Black, 100, y) : y += 20
        g.DrawString("Jl. Kuaro, Gn. Kelua", fontBody, Brushes.Black, 100, y) : y += 30

        g.DrawString("No Ref: 01921", fontBody, Brushes.Black, 10, y)
        g.DrawString(txtFirstname.Text & " " & txtLastname.Text, fontBody, Brushes.Black, 300, y) : y += 20
        g.DrawString(txtPhone.Text, fontBody, Brushes.Black, 300, y) : y += 20

        g.DrawLine(Pens.DarkBlue, 10, y, 500, y) : y += 10

        For Each item In invoiceItems
            Dim lineItem = $"{item.Item2} x{item.Item4}"
            Dim priceTotal = item.Item3 * item.Item4
            g.DrawString(lineItem, fontBody, Brushes.Black, 10, y)
            g.DrawString("Rp " & priceTotal.ToString("N2"), fontBody, Brushes.Black, 350, y)
            y += 20
        Next

        g.DrawLine(Pens.DarkBlue, 10, y, 500, y) : y += 10


        g.DrawString("Total", fontHeader, Brushes.Black, 10, y)
        g.DrawString("Rp " & Total.ToString("N2"), fontHeader, Brushes.Black, 350, y) : y += 20

        g.DrawString("Payment", fontBody, Brushes.Black, 10, y)
        g.DrawString(PaymentMethod, fontBody, Brushes.Black, 350, y) : y += 30

        g.DrawLine(Pens.DarkBlue, 10, y, 500, y) : y += 20
        g.DrawString("THANK YOU", fontHeader, Brushes.Black, 180, y)
    End Sub


    Private Sub SimpanTransaksi()
        Database.Connect()

        Dim transaction As MySqlTransaction = Nothing
        Try
            transaction = Database.conn.BeginTransaction()

            Dim sqlTransaksi As String = "INSERT INTO transactions (firstname, lastname, phone, subtotal, total, payment_method) " &
                                        "VALUES (@firstname, @lastname, @phone, @subtotal, @total, @payment_method); SELECT LAST_INSERT_ID();"

            Database.cmd = New MySqlCommand(sqlTransaksi, Database.conn, transaction)
            Database.cmd.Parameters.Clear()
            Database.cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text)
            Database.cmd.Parameters.AddWithValue("@lastname", txtLastname.Text)
            Database.cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
            Database.cmd.Parameters.AddWithValue("@subtotal", SubTotal)
            Database.cmd.Parameters.AddWithValue("@total", Total)
            Database.cmd.Parameters.AddWithValue("@payment_method", PaymentMethod)

            Dim transactionId As Integer = Convert.ToInt32(Database.cmd.ExecuteScalar())

            Dim sqlItem As String = "INSERT INTO transactionitems (transaction_id, product_name, price) VALUES (@transaction_id, @product_name, @price)"
            Dim sqlUpdateStock As String = "UPDATE products SET quantity = quantity - @qty WHERE product_id = @product_id"

            For Each item In invoiceItems
                Database.cmd = New MySqlCommand(sqlItem, Database.conn, transaction)
                Database.cmd.Parameters.Clear()
                Database.cmd.Parameters.AddWithValue("@transaction_id", transactionId)
                Database.cmd.Parameters.AddWithValue("@product_name", item.Item2)
                Database.cmd.Parameters.AddWithValue("@price", item.Item3)
                Database.cmd.Parameters.AddWithValue("@quantity", item.Item4)
                Database.cmd.ExecuteNonQuery()

                Database.cmd = New MySqlCommand(sqlUpdateStock, Database.conn, transaction)
                Database.cmd.Parameters.Clear()
                Database.cmd.Parameters.AddWithValue("@qty", item.Item4)
                Database.cmd.Parameters.AddWithValue("@product_id", item.Item1)
                Database.cmd.ExecuteNonQuery()
            Next

            transaction.Commit()
            MessageBox.Show("Transaksi berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            If transaction IsNot Nothing Then transaction.Rollback()
            Throw
        End Try
    End Sub

    Private Sub txtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBayar.KeyPress
        e.Handled = True
    End Sub
    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class
