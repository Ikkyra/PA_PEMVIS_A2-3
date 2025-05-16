Imports MySql.Data.MySqlClient

Public Class Cashier

    Private subtotal As Decimal = 0
    Private total As Decimal = 0

    Private lastCheckedRadio As RadioButton = Nothing
    Private clickedRadio As RadioButton = Nothing

    Public clfrom As Boolean = False
    Private Sub Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupCart()
        LoadProducts()
        AddRadioToggleSupport()
    End Sub

    Public Sub CheckClearForm()
        If clfrom Then
            ClearFormCH()
            clfrom = False
        End If
    End Sub

    Private Sub SetupCart()
        DataGridView2.Columns.Clear()
        DataGridView2.Columns.Add("ProductID", "ID")
        DataGridView2.Columns.Add("ProductName", "Name")
        DataGridView2.Columns.Add("Price", "Price")
        DataGridView2.Columns.Add("Quantity", "Qty")
        DataGridView2.Columns.Add("Total", "Total")
    End Sub

    Private Sub AddRadioToggleSupport()
        AddHandler rbViolin.MouseDown, AddressOf Radio_MouseDown
        AddHandler rbGuitar.MouseDown, AddressOf Radio_MouseDown
        AddHandler rbPiano.MouseDown, AddressOf Radio_MouseDown
        AddHandler rbDrum.MouseDown, AddressOf Radio_MouseDown
        AddHandler rbTrumpet.MouseDown, AddressOf Radio_MouseDown
        AddHandler rbCello.MouseDown, AddressOf Radio_MouseDown
        AddHandler rbRecorder.MouseDown, AddressOf Radio_MouseDown
    End Sub

    Private Sub Radio_MouseDown(sender As Object, e As MouseEventArgs)
        clickedRadio = DirectCast(sender, RadioButton)
    End Sub

    Private Function GetSelectedInstrumentType() As String
        If rbViolin.Checked Then Return "Violin"
        If rbGuitar.Checked Then Return "Guitar"
        If rbPiano.Checked Then Return "Piano"
        If rbDrum.Checked Then Return "Drum Kit"
        If rbTrumpet.Checked Then Return "Trumpet"
        If rbCello.Checked Then Return "Cello"
        If rbRecorder.Checked Then Return "Recorder"
        Return ""
    End Function

    Public Sub ClearFormCH()
        DataGridView2.Rows.Clear()

        subtotal = 0
        total = 0
        UpdateSummary()

        txtSearch.Text = ""

        rbViolin.Checked = False
        rbGuitar.Checked = False
        rbPiano.Checked = False
        rbDrum.Checked = False
        rbTrumpet.Checked = False
        rbCello.Checked = False
        rbRecorder.Checked = False

        lastCheckedRadio = Nothing
        clickedRadio = Nothing

        LoadProducts()
    End Sub


    Private Sub LoadProducts(Optional ByVal keyword As String = "", Optional ByVal instrumentType As String = "")
        Connect()

        Dim sql As String = "SELECT * FROM Products WHERE 1=1"

        If keyword <> "" Then
            sql &= " AND name LIKE @keyword"
        End If

        If instrumentType <> "" Then
            sql &= " AND type = @type"
        End If

        cmd = New MySqlCommand(sql, conn)

        If keyword <> "" Then
            cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
        End If
        If instrumentType <> "" Then
            cmd.Parameters.AddWithValue("@type", instrumentType)
        End If

        dr = cmd.ExecuteReader()

        DataGridView1.Rows.Clear()
        If DataGridView1.Columns.Count = 0 Then
            DataGridView1.Columns.Clear()
            DataGridView1.Columns.Add("ID", "ID")
            DataGridView1.Columns.Add("Name", "Name")
            DataGridView1.Columns.Add("Brand", "Brand")
            DataGridView1.Columns.Add("Type", "Type")
            DataGridView1.Columns.Add("Description", "Description")
            DataGridView1.Columns.Add("Price", "Price")
            DataGridView1.Columns.Add("Stock", "Stock")
        End If

        Dim i As Integer = 0
        While dr.Read()
            i += 1
            DataGridView1.Rows.Add(i, dr("product_id"), dr("name"), dr("brand"), dr("type"), dr("description"), dr("price"), dr("quantity"))
        End While

        dr.Close()
        conn.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim typeFilter = GetSelectedInstrumentType()
        LoadProducts(txtSearch.Text.Trim(), typeFilter)
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbViolin.CheckedChanged, rbGuitar.CheckedChanged, rbPiano.CheckedChanged, rbDrum.CheckedChanged, rbTrumpet.CheckedChanged, rbCello.CheckedChanged, rbRecorder.CheckedChanged
        Dim radio As RadioButton = CType(sender, RadioButton)
        If radio.Checked Then
            If radio Is lastCheckedRadio AndAlso clickedRadio Is radio Then
                radio.Checked = False
                lastCheckedRadio = Nothing
                clickedRadio = Nothing
                LoadProducts(txtSearch.Text.Trim(), "")
                Return
            End If
            lastCheckedRadio = radio
        End If

        Dim typeFilter = GetSelectedInstrumentType()
        LoadProducts(txtSearch.Text.Trim(), typeFilter)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim id = row.Cells("Column2").Value.ToString()
            Dim name = row.Cells("Column3").Value.ToString()
            Dim price = Convert.ToDecimal(row.Cells("Column6").Value)
            Dim stock = Convert.ToInt32(row.Cells("Column7").Value)

            Dim foundRow As DataGridViewRow = DataGridView2.Rows.Cast(Of DataGridViewRow)().
            FirstOrDefault(Function(r) r.Cells("ProductID").Value IsNot Nothing AndAlso
                               r.Cells("ProductID").Value.ToString() = id)

            If foundRow IsNot Nothing Then
                Dim currentQty = Convert.ToInt32(foundRow.Cells("Quantity").Value)
                If currentQty + 1 > stock Then
                    MessageBox.Show("Stok tidak mencukupi!")
                    Return
                End If

                foundRow.Cells("Quantity").Value = currentQty + 1
                Dim newTotal = (currentQty + 1) * price
                foundRow.Cells("Total").Value = newTotal.ToString("F2")

                subtotal += price
            Else
                If stock < 1 Then
                    MessageBox.Show("Stok tidak mencukupi!")
                    Return
                End If

                Dim qty = 1
                Dim totalPrice = price * qty
                DataGridView2.Rows.Add(id, name, price.ToString("F2"), qty, totalPrice.ToString("F2"))
                subtotal += totalPrice
            End If

            UpdateSummary()
        End If
    End Sub


    Private Sub UpdateSummary()
        total = subtotal
        lblTotal.Text = total.ToString("F2")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        DataGridView2.Rows.Clear()
        subtotal = 0
        total = 0
        UpdateSummary()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If DataGridView2.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In DataGridView2.SelectedRows
                Dim rowTotal = Convert.ToDecimal(row.Cells("Total").Value)
                subtotal -= rowTotal
                DataGridView2.Rows.Remove(row)
            Next
            UpdateSummary()
        Else
            MessageBox.Show("Pilih baris produk yang akan dihapus dari keranjang.")
        End If
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        If DataGridView2.Rows.Count = 0 Then
            MessageBox.Show("Keranjang kosong! Tambahkan produk sebelum checkout.")
            Return
        End If


        Dim frmCheckout As New Checkout()
        frmCheckout.TotalHarga = total

        Dim items As New List(Of Tuple(Of Integer, String, Decimal, Integer))

        For Each row As DataGridViewRow In DataGridView2.Rows

            If row.IsNewRow Then Continue For

            Dim productId As Integer = 0
            Dim name As String = ""
            Dim price As Decimal = 0D
            Dim quantity As Integer = 0

            If row.Cells("ProductID").Value IsNot Nothing AndAlso Integer.TryParse(row.Cells("ProductID").Value.ToString(), productId) Then
            Else
                Continue For
            End If

            name = If(row.Cells("ProductName").Value IsNot Nothing, row.Cells("ProductName").Value.ToString(), String.Empty)
            If String.IsNullOrEmpty(name) Then Continue For

            If row.Cells("Price").Value IsNot Nothing AndAlso Decimal.TryParse(row.Cells("Price").Value.ToString(), price) Then
            Else
                Continue For
            End If

            If row.Cells("Quantity").Value IsNot Nothing AndAlso Integer.TryParse(row.Cells("Quantity").Value.ToString(), quantity) Then
            Else
                Continue For
            End If

            If quantity > 0 And price > 0 Then
                items.Add(Tuple.Create(productId, name, price, quantity))
            End If
        Next
        If items.Count = 0 Then
            MessageBox.Show("Keranjang kosong atau data item tidak valid!")
            Return
        End If
        Me.Hide()
        frmCheckout.invoiceItems = items
        frmCheckout.Show()
    End Sub


    Private Sub CRUDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CRUDToolStripMenuItem.Click
        Dim formCRUD As New crud()
        formCRUD.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        MainForm.Show()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        CheckClearForm()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class
