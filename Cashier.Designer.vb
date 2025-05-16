<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cashier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        btnRemove = New Button()
        btnClear = New Button()
        DataGridView2 = New DataGridView()
        lblTotal = New Label()
        btnCheckout = New Button()
        Label6 = New Label()
        Panel4 = New Panel()
        rbRecorder = New RadioButton()
        PictureBox9 = New PictureBox()
        rbCello = New RadioButton()
        PictureBox8 = New PictureBox()
        rbTrumpet = New RadioButton()
        PictureBox7 = New PictureBox()
        rbDrum = New RadioButton()
        PictureBox6 = New PictureBox()
        rbPiano = New RadioButton()
        PictureBox5 = New PictureBox()
        rbGuitar = New RadioButton()
        PictureBox4 = New PictureBox()
        rbViolin = New RadioButton()
        PictureBox3 = New PictureBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        txtSearch = New TextBox()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        Fmenu = New MenuStrip()
        CRUDToolStripMenuItem = New ToolStripMenuItem()
        CashierToolStripMenuItem = New ToolStripMenuItem()
        Label4 = New Label()
        Label5 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Fmenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(90), CByte(92), CByte(114))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(-2, 27)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1583, 80)
        Panel1.TabIndex = 0
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
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.Orange
        btnRemove.Cursor = Cursors.Hand
        btnRemove.Location = New Point(994, 10)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(173, 40)
        btnRemove.TabIndex = 5
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Orange
        btnClear.Cursor = Cursors.Hand
        btnClear.Location = New Point(994, 56)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(173, 40)
        btnClear.TabIndex = 4
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(899, 221)
        DataGridView2.Margin = New Padding(2)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 62
        DataGridView2.Size = New Size(648, 525)
        DataGridView2.TabIndex = 7
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.ForeColor = SystemColors.Control
        lblTotal.Location = New Point(1412, 10)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(36, 20)
        lblTotal.TabIndex = 4
        lblTotal.Text = "0.00"
        ' 
        ' btnCheckout
        ' 
        btnCheckout.BackColor = Color.Orange
        btnCheckout.Cursor = Cursors.Hand
        btnCheckout.Location = New Point(1188, 51)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(347, 40)
        btnCheckout.TabIndex = 3
        btnCheckout.Text = "Checkout"
        btnCheckout.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(1188, 10)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 20)
        Label6.TabIndex = 2
        Label6.Text = "Total"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(74), CByte(80), CByte(96))
        Panel4.Controls.Add(btnRemove)
        Panel4.Controls.Add(lblTotal)
        Panel4.Controls.Add(btnClear)
        Panel4.Controls.Add(rbRecorder)
        Panel4.Controls.Add(btnCheckout)
        Panel4.Controls.Add(PictureBox9)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(rbCello)
        Panel4.Controls.Add(PictureBox8)
        Panel4.Controls.Add(rbTrumpet)
        Panel4.Controls.Add(PictureBox7)
        Panel4.Controls.Add(rbDrum)
        Panel4.Controls.Add(PictureBox6)
        Panel4.Controls.Add(rbPiano)
        Panel4.Controls.Add(PictureBox5)
        Panel4.Controls.Add(rbGuitar)
        Panel4.Controls.Add(PictureBox4)
        Panel4.Controls.Add(rbViolin)
        Panel4.Controls.Add(PictureBox3)
        Panel4.Location = New Point(12, 751)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1542, 102)
        Panel4.TabIndex = 3
        ' 
        ' rbRecorder
        ' 
        rbRecorder.AutoSize = True
        rbRecorder.Cursor = Cursors.Hand
        rbRecorder.ForeColor = SystemColors.Control
        rbRecorder.Location = New Point(898, 42)
        rbRecorder.Name = "rbRecorder"
        rbRecorder.Size = New Size(90, 24)
        rbRecorder.TabIndex = 15
        rbRecorder.TabStop = True
        rbRecorder.Text = "Recorder"
        rbRecorder.UseVisualStyleBackColor = True
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackgroundImage = My.Resources.Resources.icons8_recorder_48__1_
        PictureBox9.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox9.Location = New Point(841, 26)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(51, 49)
        PictureBox9.TabIndex = 14
        PictureBox9.TabStop = False
        ' 
        ' rbCello
        ' 
        rbCello.AutoSize = True
        rbCello.Cursor = Cursors.Hand
        rbCello.ForeColor = SystemColors.Control
        rbCello.Location = New Point(769, 42)
        rbCello.Name = "rbCello"
        rbCello.Size = New Size(64, 24)
        rbCello.TabIndex = 13
        rbCello.TabStop = True
        rbCello.Text = "Cello"
        rbCello.UseVisualStyleBackColor = True
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackgroundImage = My.Resources.Resources.icons8_cello_50
        PictureBox8.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox8.Location = New Point(712, 26)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(51, 49)
        PictureBox8.TabIndex = 12
        PictureBox8.TabStop = False
        ' 
        ' rbTrumpet
        ' 
        rbTrumpet.AutoSize = True
        rbTrumpet.Cursor = Cursors.Hand
        rbTrumpet.ForeColor = SystemColors.Control
        rbTrumpet.Location = New Point(621, 42)
        rbTrumpet.Name = "rbTrumpet"
        rbTrumpet.Size = New Size(85, 24)
        rbTrumpet.TabIndex = 11
        rbTrumpet.TabStop = True
        rbTrumpet.Text = "Trumpet"
        rbTrumpet.UseVisualStyleBackColor = True
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackgroundImage = My.Resources.Resources.icons8_trumpet_50
        PictureBox7.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox7.Location = New Point(564, 26)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(51, 49)
        PictureBox7.TabIndex = 10
        PictureBox7.TabStop = False
        ' 
        ' rbDrum
        ' 
        rbDrum.AutoSize = True
        rbDrum.Cursor = Cursors.Hand
        rbDrum.ForeColor = SystemColors.Control
        rbDrum.Location = New Point(464, 41)
        rbDrum.Name = "rbDrum"
        rbDrum.Size = New Size(89, 24)
        rbDrum.TabIndex = 9
        rbDrum.TabStop = True
        rbDrum.Text = "Drum Kit"
        rbDrum.UseVisualStyleBackColor = True
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImage = My.Resources.Resources.icons8_drum_64__1_
        PictureBox6.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox6.Location = New Point(407, 25)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(51, 49)
        PictureBox6.TabIndex = 8
        PictureBox6.TabStop = False
        ' 
        ' rbPiano
        ' 
        rbPiano.AutoSize = True
        rbPiano.Cursor = Cursors.Hand
        rbPiano.ForeColor = SystemColors.Control
        rbPiano.Location = New Point(332, 42)
        rbPiano.Name = "rbPiano"
        rbPiano.Size = New Size(67, 24)
        rbPiano.TabIndex = 7
        rbPiano.TabStop = True
        rbPiano.Text = "Piano"
        rbPiano.UseVisualStyleBackColor = True
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = My.Resources.Resources.icons8_piano_48__1_
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox5.Location = New Point(275, 26)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(51, 49)
        PictureBox5.TabIndex = 6
        PictureBox5.TabStop = False
        ' 
        ' rbGuitar
        ' 
        rbGuitar.AutoSize = True
        rbGuitar.Cursor = Cursors.Hand
        rbGuitar.ForeColor = SystemColors.Control
        rbGuitar.Location = New Point(200, 42)
        rbGuitar.Name = "rbGuitar"
        rbGuitar.Size = New Size(70, 24)
        rbGuitar.TabIndex = 5
        rbGuitar.TabStop = True
        rbGuitar.Text = "Guitar"
        rbGuitar.UseVisualStyleBackColor = True
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = My.Resources.Resources.icons8_guitar_50
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Location = New Point(143, 26)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(51, 49)
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' rbViolin
        ' 
        rbViolin.AutoSize = True
        rbViolin.Cursor = Cursors.Hand
        rbViolin.ForeColor = SystemColors.Control
        rbViolin.Location = New Point(71, 42)
        rbViolin.Name = "rbViolin"
        rbViolin.Size = New Size(68, 24)
        rbViolin.TabIndex = 3
        rbViolin.TabStop = True
        rbViolin.Text = "Violin"
        rbViolin.UseVisualStyleBackColor = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = My.Resources.Resources.icons8_violin_100__1_
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(14, 26)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(51, 49)
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column8, Column5, Column6, Column7})
        DataGridView1.Location = New Point(12, 220)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(822, 525)
        DataGridView1.TabIndex = 4
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "#"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 47
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "ID"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 53
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Name"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 78
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Brand"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 77
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column8.HeaderText = "Type"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.Width = 69
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column5.HeaderText = "Description"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Price"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 70
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "Quantity"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Width = 94
        ' 
        ' txtSearch
        ' 
        txtSearch.Cursor = Cursors.IBeam
        txtSearch.Location = New Point(71, 118)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(1471, 27)
        txtSearch.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 20)
        Label3.TabIndex = 7
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.BackgroundImage = My.Resources.Resources.icons8_search_50
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(27, 113)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(40, 38)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' Fmenu
        ' 
        Fmenu.BackColor = Color.Orange
        Fmenu.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fmenu.ImageScalingSize = New Size(20, 20)
        Fmenu.Items.AddRange(New ToolStripItem() {CRUDToolStripMenuItem, CashierToolStripMenuItem})
        Fmenu.Location = New Point(0, 0)
        Fmenu.Name = "Fmenu"
        Fmenu.Size = New Size(1554, 28)
        Fmenu.TabIndex = 9
        Fmenu.Text = "MenuStrip1"
        ' 
        ' CRUDToolStripMenuItem
        ' 
        CRUDToolStripMenuItem.Name = "CRUDToolStripMenuItem"
        CRUDToolStripMenuItem.Size = New Size(77, 24)
        CRUDToolStripMenuItem.Text = "Manage"
        ' 
        ' CashierToolStripMenuItem
        ' 
        CashierToolStripMenuItem.Name = "CashierToolStripMenuItem"
        CashierToolStripMenuItem.Size = New Size(71, 24)
        CashierToolStripMenuItem.Text = "Cashier"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(26, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(160, 41)
        Label4.TabIndex = 10
        Label4.Text = "PRODUCT"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(910, 164)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 41)
        Label5.TabIndex = 10
        Label5.Text = "CART"
        ' 
        ' Cashier
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1554, 853)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(DataGridView2)
        Controls.Add(Fmenu)
        Controls.Add(PictureBox2)
        Controls.Add(Label3)
        Controls.Add(txtSearch)
        Controls.Add(DataGridView1)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Cashier"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Fmenu.ResumeLayout(False)
        Fmenu.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents rbViolin As RadioButton
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents rbRecorder As RadioButton
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents rbCello As RadioButton
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents rbTrumpet As RadioButton
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents rbDrum As RadioButton
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents rbPiano As RadioButton
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents rbGuitar As RadioButton
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Fmenu As MenuStrip
    Friend WithEvents CRUDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CashierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
