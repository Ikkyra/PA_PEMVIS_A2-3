Imports MySql.Data.MySqlClient

Public Class crud

    Private Sub crud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            Connect()
            Dim query As String = "SELECT * FROM Products"
            cmd = New MySqlCommand(query, conn)
            dr = cmd.ExecuteReader()
            DataGridView1.Rows.Clear()
            While dr.Read()
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr("product_id"), dr("name"), dr("brand"), dr("type"), dr("description"), dr("price"), dr("quantity"))
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
           String.IsNullOrWhiteSpace(txtBrand.Text) OrElse
           String.IsNullOrWhiteSpace(CBType.Text) OrElse
           String.IsNullOrWhiteSpace(txtPrice.Text) OrElse Convert.ToDecimal(txtPrice.Text) <= 0 Then
            MessageBox.Show("Semua kolom wajib diisi dan harga harus lebih dari 0.")
            Exit Sub
        End If

        Try
            Connect()
            Dim query As String = "INSERT INTO Products (name, brand, type, description, price, quantity) VALUES (@name, @brand, @type, @description, @price, @quantity)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@name", txtName.Text)
            cmd.Parameters.AddWithValue("@brand", txtBrand.Text)
            cmd.Parameters.AddWithValue("@type", CBType.Text)
            cmd.Parameters.AddWithValue("@description", txtDesc.Text)
            cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text))
            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtQuantity.Text))
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil ditambahkan.")
            LoadData()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If DataGridView1.CurrentRow IsNot Nothing AndAlso DataGridView1.CurrentRow.Index >= 0 Then
            If String.IsNullOrWhiteSpace(txtName.Text) OrElse
               String.IsNullOrWhiteSpace(txtBrand.Text) OrElse
               String.IsNullOrWhiteSpace(CBType.Text) OrElse
               String.IsNullOrWhiteSpace(txtPrice.Text) OrElse Convert.ToDecimal(txtPrice.Text) <= 0 Then
                MessageBox.Show("Semua kolom wajib diisi dan harga harus lebih dari 0.")
                Exit Sub
            End If

            Try
                Connect()
                Dim selectedRow As DataGridViewRow = DataGridView1.CurrentRow
                Dim productId As Integer = Convert.ToInt32(selectedRow.Cells("Column2").Value)
                Dim query As String = "UPDATE Products SET name=@name, brand=@brand, type=@type, description=@description, price=@price, quantity=@quantity WHERE product_id=@id"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", txtName.Text)
                cmd.Parameters.AddWithValue("@brand", txtBrand.Text)
                cmd.Parameters.AddWithValue("@type", CBType.Text)
                cmd.Parameters.AddWithValue("@description", txtDesc.Text)
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text))
                cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtQuantity.Text))
                cmd.Parameters.AddWithValue("@id", productId)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil diperbarui.")
                LoadData()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Pilih baris yang ingin diperbarui.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView1.CurrentRow IsNot Nothing AndAlso DataGridView1.CurrentRow.Index >= 0 Then
            Try
                Connect()
                Dim selectedRow As DataGridViewRow = DataGridView1.CurrentRow
                Dim productId As Integer = Convert.ToInt32(selectedRow.Cells("Column2").Value)
                Dim query As String = "DELETE FROM Products WHERE product_id=@id"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", productId)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil dihapus.")
                LoadData()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Pilih baris yang ingin dihapus.")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtName.Clear()
        txtBrand.Clear()
        CBType.SelectedIndex = -1
        txtDesc.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtName.Text = selectedRow.Cells("Column3").Value.ToString()
            txtBrand.Text = selectedRow.Cells("Column4").Value.ToString()
            CBType.Text = selectedRow.Cells("Column8").Value.ToString()
            txtDesc.Text = selectedRow.Cells("Column5").Value.ToString()
            txtPrice.Text = selectedRow.Cells("Column6").Value.ToString()
            txtQuantity.Text = selectedRow.Cells("Column7").Value.ToString()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Connect()
            Dim query = "SELECT * FROM Products WHERE name LIKE @search"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text & "%")
            dr = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr("product_id"), dr("name"), dr("brand"), dr("type"), dr("description"), dr("price"), dr("quantity"))
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        txtSearch_TextChanged(sender, e)
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CashierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashierToolStripMenuItem.Click
        Dim formCashier As New Cashier()
        formCashier.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        MainForm.Show()
    End Sub
    Private Sub CBType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBType.KeyPress
        e.Handled = True
    End Sub
End Class
