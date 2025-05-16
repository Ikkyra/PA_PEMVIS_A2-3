<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crud
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
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        txtSearch = New TextBox()
        Panel2 = New Panel()
        CBType = New ComboBox()
        txtQuantity = New TextBox()
        txtPrice = New TextBox()
        txtDesc = New TextBox()
        txtBrand = New TextBox()
        txtName = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Panel3 = New Panel()
        btnUpdate = New Button()
        btnClear = New Button()
        btnDelete = New Button()
        btnAdd = New Button()
        Fmenu = New MenuStrip()
        CRUDToolStripMenuItem = New ToolStripMenuItem()
        CashierToolStripMenuItem = New ToolStripMenuItem()
        btnSearch = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Fmenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column8, Column5, Column6, Column7})
        DataGridView1.Location = New Point(12, 173)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1153, 657)
        DataGridView1.TabIndex = 5
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
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(90), CByte(92), CByte(114))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 28)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1554, 80)
        Panel1.TabIndex = 6
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
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.BackgroundImage = My.Resources.Resources.icons8_search_50
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(26, 114)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(46, 35)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Cursor = Cursors.IBeam
        txtSearch.Location = New Point(73, 117)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(993, 27)
        txtSearch.TabIndex = 10
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(CBType)
        Panel2.Controls.Add(txtQuantity)
        Panel2.Controls.Add(txtPrice)
        Panel2.Controls.Add(txtDesc)
        Panel2.Controls.Add(txtBrand)
        Panel2.Controls.Add(txtName)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(1204, 173)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(338, 440)
        Panel2.TabIndex = 12
        ' 
        ' CBType
        ' 
        CBType.Cursor = Cursors.IBeam
        CBType.FormattingEnabled = True
        CBType.Items.AddRange(New Object() {"Violin", "Piano", "Drum", "Trumpet", "Cello", "Recorder"})
        CBType.Location = New Point(166, 165)
        CBType.Name = "CBType"
        CBType.Size = New Size(167, 28)
        CBType.TabIndex = 2
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Cursor = Cursors.IBeam
        txtQuantity.Location = New Point(165, 374)
        txtQuantity.MaxLength = 4
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(166, 27)
        txtQuantity.TabIndex = 1
        ' 
        ' txtPrice
        ' 
        txtPrice.Cursor = Cursors.IBeam
        txtPrice.Location = New Point(166, 307)
        txtPrice.MaxLength = 8
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(166, 27)
        txtPrice.TabIndex = 1
        ' 
        ' txtDesc
        ' 
        txtDesc.Cursor = Cursors.IBeam
        txtDesc.Location = New Point(166, 233)
        txtDesc.MaxLength = 100
        txtDesc.Name = "txtDesc"
        txtDesc.Size = New Size(166, 27)
        txtDesc.TabIndex = 1
        ' 
        ' txtBrand
        ' 
        txtBrand.Cursor = Cursors.IBeam
        txtBrand.Location = New Point(167, 94)
        txtBrand.MaxLength = 100
        txtBrand.Name = "txtBrand"
        txtBrand.Size = New Size(166, 27)
        txtBrand.TabIndex = 1
        ' 
        ' txtName
        ' 
        txtName.Cursor = Cursors.IBeam
        txtName.Location = New Point(166, 22)
        txtName.MaxLength = 100
        txtName.Name = "txtName"
        txtName.Size = New Size(166, 27)
        txtName.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label8.Location = New Point(11, 168)
        Label8.Name = "Label8"
        Label8.Size = New Size(53, 25)
        Label8.TabIndex = 0
        Label8.Text = "Type"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label7.Location = New Point(10, 373)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 25)
        Label7.TabIndex = 0
        Label7.Text = "Quantity"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label6.Location = New Point(10, 309)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 25)
        Label6.TabIndex = 0
        Label6.Text = "Price"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label5.Location = New Point(10, 235)
        Label5.Name = "Label5"
        Label5.Size = New Size(109, 25)
        Label5.TabIndex = 0
        Label5.Text = "Description"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label4.Location = New Point(10, 93)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 25)
        Label4.TabIndex = 0
        Label4.Text = "Brand"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label3.Location = New Point(11, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 25)
        Label3.TabIndex = 0
        Label3.Text = "Name"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(90), CByte(92), CByte(114))
        Panel3.Controls.Add(btnUpdate)
        Panel3.Controls.Add(btnClear)
        Panel3.Controls.Add(btnDelete)
        Panel3.Controls.Add(btnAdd)
        Panel3.Location = New Point(1204, 647)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(338, 183)
        Panel3.TabIndex = 13
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Orange
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.Location = New Point(31, 106)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(123, 56)
        btnUpdate.TabIndex = 0
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Orange
        btnClear.Cursor = Cursors.Hand
        btnClear.Location = New Point(200, 106)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(116, 56)
        btnClear.TabIndex = 0
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Orange
        btnDelete.Cursor = Cursors.Hand
        btnDelete.Location = New Point(200, 15)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(116, 55)
        btnDelete.TabIndex = 0
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Orange
        btnAdd.Cursor = Cursors.Hand
        btnAdd.Location = New Point(31, 15)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(123, 55)
        btnAdd.TabIndex = 0
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
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
        Fmenu.TabIndex = 14
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
        ' btnSearch
        ' 
        btnSearch.Location = New Point(1072, 117)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(93, 29)
        btnSearch.TabIndex = 15
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' crud
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1554, 853)
        Controls.Add(btnSearch)
        Controls.Add(Fmenu)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(PictureBox2)
        Controls.Add(txtSearch)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "crud"
        StartPosition = FormStartPosition.CenterScreen
        Text = "crud"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Fmenu.ResumeLayout(False)
        Fmenu.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CBType As ComboBox
    Friend WithEvents Fmenu As MenuStrip
    Friend WithEvents CRUDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CashierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSearch As Button
End Class
