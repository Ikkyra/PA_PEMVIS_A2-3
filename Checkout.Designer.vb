<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Checkout))
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        lblTotal = New Label()
        Label4 = New Label()
        txtBayar = New TextBox()
        Panel2 = New Panel()
        btnBackSpace = New Button()
        btn0 = New Button()
        btn9 = New Button()
        btn8 = New Button()
        btn7 = New Button()
        btn6 = New Button()
        btn5 = New Button()
        btn4 = New Button()
        btn3 = New Button()
        btn2 = New Button()
        btn1 = New Button()
        lblKembalian = New Label()
        Panel3 = New Panel()
        rbNonCash = New RadioButton()
        btnClear = New Button()
        rbCash = New RadioButton()
        Label9 = New Label()
        Label8 = New Label()
        Label10 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        txtPhone = New TextBox()
        txtLastname = New TextBox()
        txtFirstname = New TextBox()
        Panel4 = New Panel()
        btnBack = New Button()
        btnPrint = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(90), CByte(92), CByte(114))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1583, 80)
        Panel1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(73, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 25)
        Label2.TabIndex = 2
        Label2.Text = "Backlund Galleyria"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(73, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(185, 25)
        Label1.TabIndex = 1
        Label1.Text = "Point Of Sale Design"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.icons8_cashier_60
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(28, 20)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(39, 39)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(236, 146)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(242, 41)
        lblTotal.TabIndex = 2
        lblTotal.Text = "Rp 4.000.000,00"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(236, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 31)
        Label4.TabIndex = 3
        Label4.Text = "Rp "
        ' 
        ' txtBayar
        ' 
        txtBayar.Cursor = Cursors.IBeam
        txtBayar.Location = New Point(289, 214)
        txtBayar.Name = "txtBayar"
        txtBayar.Size = New Size(189, 27)
        txtBayar.TabIndex = 4
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(90), CByte(92), CByte(114))
        Panel2.Controls.Add(btnBackSpace)
        Panel2.Controls.Add(btn0)
        Panel2.Controls.Add(btn9)
        Panel2.Controls.Add(btn8)
        Panel2.Controls.Add(btn7)
        Panel2.Controls.Add(btn6)
        Panel2.Controls.Add(btn5)
        Panel2.Controls.Add(btn4)
        Panel2.Controls.Add(btn3)
        Panel2.Controls.Add(btn2)
        Panel2.Controls.Add(btn1)
        Panel2.Controls.Add(lblKembalian)
        Panel2.Location = New Point(38, 266)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(705, 239)
        Panel2.TabIndex = 5
        ' 
        ' btnBackSpace
        ' 
        btnBackSpace.BackColor = Color.Orange
        btnBackSpace.Cursor = Cursors.Hand
        btnBackSpace.Location = New Point(534, 113)
        btnBackSpace.Name = "btnBackSpace"
        btnBackSpace.Size = New Size(159, 53)
        btnBackSpace.TabIndex = 17
        btnBackSpace.Text = "BackSpace"
        btnBackSpace.UseVisualStyleBackColor = False
        ' 
        ' btn0
        ' 
        btn0.Cursor = Cursors.Hand
        btn0.Location = New Point(534, 170)
        btn0.Name = "btn0"
        btn0.Size = New Size(159, 53)
        btn0.TabIndex = 16
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Cursor = Cursors.Hand
        btn9.Location = New Point(369, 170)
        btn9.Name = "btn9"
        btn9.Size = New Size(159, 53)
        btn9.TabIndex = 16
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Cursor = Cursors.Hand
        btn8.Location = New Point(204, 170)
        btn8.Name = "btn8"
        btn8.Size = New Size(159, 53)
        btn8.TabIndex = 15
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Cursor = Cursors.Hand
        btn7.Location = New Point(39, 170)
        btn7.Name = "btn7"
        btn7.Size = New Size(159, 53)
        btn7.TabIndex = 14
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Cursor = Cursors.Hand
        btn6.Location = New Point(369, 113)
        btn6.Name = "btn6"
        btn6.Size = New Size(159, 53)
        btn6.TabIndex = 13
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Cursor = Cursors.Hand
        btn5.Location = New Point(204, 113)
        btn5.Name = "btn5"
        btn5.Size = New Size(159, 53)
        btn5.TabIndex = 12
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Cursor = Cursors.Hand
        btn4.Location = New Point(39, 113)
        btn4.Name = "btn4"
        btn4.Size = New Size(159, 53)
        btn4.TabIndex = 11
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Cursor = Cursors.Hand
        btn3.Location = New Point(369, 56)
        btn3.Name = "btn3"
        btn3.Size = New Size(159, 53)
        btn3.TabIndex = 10
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Cursor = Cursors.Hand
        btn2.Location = New Point(204, 56)
        btn2.Name = "btn2"
        btn2.Size = New Size(159, 53)
        btn2.TabIndex = 9
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Cursor = Cursors.Hand
        btn1.Location = New Point(39, 56)
        btn1.Name = "btn1"
        btn1.Size = New Size(159, 53)
        btn1.TabIndex = 8
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' lblKembalian
        ' 
        lblKembalian.AutoSize = True
        lblKembalian.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKembalian.ForeColor = Color.Chartreuse
        lblKembalian.Location = New Point(251, 12)
        lblKembalian.Name = "lblKembalian"
        lblKembalian.Size = New Size(186, 31)
        lblKembalian.TabIndex = 7
        lblKembalian.Text = "Change: Rp 0.00"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(rbNonCash)
        Panel3.Controls.Add(btnClear)
        Panel3.Controls.Add(rbCash)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(txtPhone)
        Panel3.Controls.Add(txtLastname)
        Panel3.Controls.Add(txtFirstname)
        Panel3.Location = New Point(778, 86)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(410, 419)
        Panel3.TabIndex = 6
        ' 
        ' rbNonCash
        ' 
        rbNonCash.AutoSize = True
        rbNonCash.Cursor = Cursors.Hand
        rbNonCash.Location = New Point(326, 292)
        rbNonCash.Name = "rbNonCash"
        rbNonCash.Size = New Size(61, 24)
        rbNonCash.TabIndex = 12
        rbNonCash.TabStop = True
        rbNonCash.Text = "Card"
        rbNonCash.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Orange
        btnClear.Cursor = Cursors.Hand
        btnClear.Location = New Point(253, 333)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(134, 52)
        btnClear.TabIndex = 0
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' rbCash
        ' 
        rbCash.AutoSize = True
        rbCash.Cursor = Cursors.Hand
        rbCash.Location = New Point(175, 292)
        rbCash.Name = "rbCash"
        rbCash.Size = New Size(61, 24)
        rbCash.TabIndex = 11
        rbCash.TabStop = True
        rbCash.Text = "Cash"
        rbCash.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(3, 292)
        Label9.Name = "Label9"
        Label9.Size = New Size(141, 23)
        Label9.TabIndex = 10
        Label9.Text = "Payment Method"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(3, 225)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 23)
        Label8.TabIndex = 10
        Label8.Text = "Phone"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(93, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(234, 82)
        Label10.TabIndex = 2
        Label10.Text = "   CUSTOMER " & vbCrLf & "INFORMATION"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(3, 160)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 23)
        Label7.TabIndex = 9
        Label7.Text = "Last Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(3, 98)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 23)
        Label6.TabIndex = 8
        Label6.Text = "First Name"
        ' 
        ' txtPhone
        ' 
        txtPhone.Cursor = Cursors.IBeam
        txtPhone.Location = New Point(126, 224)
        txtPhone.MaxLength = 15
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(261, 27)
        txtPhone.TabIndex = 2
        ' 
        ' txtLastname
        ' 
        txtLastname.Cursor = Cursors.IBeam
        txtLastname.Location = New Point(126, 159)
        txtLastname.MaxLength = 50
        txtLastname.Name = "txtLastname"
        txtLastname.Size = New Size(261, 27)
        txtLastname.TabIndex = 1
        ' 
        ' txtFirstname
        ' 
        txtFirstname.Cursor = Cursors.IBeam
        txtFirstname.Location = New Point(126, 97)
        txtFirstname.MaxLength = 50
        txtFirstname.Name = "txtFirstname"
        txtFirstname.Size = New Size(261, 27)
        txtFirstname.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(90), CByte(92), CByte(114))
        Panel4.Controls.Add(btnBack)
        Panel4.Controls.Add(btnPrint)
        Panel4.Location = New Point(0, 521)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1199, 79)
        Panel4.TabIndex = 7
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Orange
        btnBack.Cursor = Cursors.Hand
        btnBack.Location = New Point(28, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(134, 52)
        btnBack.TabIndex = 1
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.Orange
        btnPrint.Cursor = Cursors.Hand
        btnPrint.Location = New Point(1033, 12)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(134, 52)
        btnPrint.TabIndex = 0
        btnPrint.Text = "Print Receipt"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Checkout
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1200, 600)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(txtBayar)
        Controls.Add(Label4)
        Controls.Add(lblTotal)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Checkout"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Checkout"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblKembalian As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnPrint As Button
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents rbNonCash As RadioButton
    Friend WithEvents rbCash As RadioButton
    Friend WithEvents btnBack As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btnBackSpace As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn0 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
