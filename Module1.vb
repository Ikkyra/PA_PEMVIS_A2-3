Imports MySql.Data.MySqlClient

Module Database
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public dt As DataTable
    Public da As MySqlDataAdapter

    Public Sub Connect()
        conn = New MySqlConnection("server=localhost;userid=root;password=;database=musicstore")
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
        Catch ex As Exception
            MessageBox.Show("Koneksi gagal: " & ex.Message)
        End Try
    End Sub
End Module
