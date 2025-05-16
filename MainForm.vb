Imports System.Windows.Forms

Public Class MainForm

    Private Sub CRUDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CRUDToolStripMenuItem.Click
        Dim formCRUD As New crud()
        formCRUD.Show()
        Me.Hide()
    End Sub

    Private Sub CashierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashierToolStripMenuItem.Click
        Dim formCashier As New Cashier()
        formCashier.Show()
        Me.Hide()
    End Sub


End Class
