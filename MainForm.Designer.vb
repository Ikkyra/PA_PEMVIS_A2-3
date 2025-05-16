<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Fmenu = New MenuStrip()
        CRUDToolStripMenuItem = New ToolStripMenuItem()
        CashierToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Fmenu.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Fmenu
        ' 
        Fmenu.BackColor = Color.Orange
        Fmenu.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fmenu.ImageScalingSize = New Size(20, 20)
        Fmenu.Items.AddRange(New ToolStripItem() {CRUDToolStripMenuItem, CashierToolStripMenuItem})
        Fmenu.Location = New Point(0, 0)
        Fmenu.Name = "Fmenu"
        Fmenu.Size = New Size(1554, 28)
        Fmenu.TabIndex = 0
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
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.lucas_mendes_0GSVQYXj_64_unsplash_removebg_preview
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(1150, 29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(511, 822)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 48.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(125, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(829, 106)
        Label1.TabIndex = 2
        Label1.Text = "VINTAGE AND RARE:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Yellow
        Panel1.Location = New Point(0, 28)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(24, 825)
        Panel1.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkOrange
        Panel2.Location = New Point(24, 28)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(24, 825)
        Panel2.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.OrangeRed
        Panel3.Location = New Point(48, 28)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(24, 825)
        Panel3.TabIndex = 3
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.DarkOrchid
        Panel4.Location = New Point(72, 28)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(24, 825)
        Panel4.TabIndex = 3
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Blue
        Panel5.Location = New Point(95, 28)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(24, 825)
        Panel5.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 48.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(125, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(1067, 212)
        Label2.TabIndex = 2
        Label2.Text = "YOUR PLACE TO" & vbCrLf & "BUY MUSIC INSTRUMENTS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(125, 715)
        Label3.Name = "Label3"
        Label3.Size = New Size(529, 62)
        Label3.TabIndex = 2
        Label3.Text = "Cash Register Program"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(125, 653)
        Label4.Name = "Label4"
        Label4.Size = New Size(433, 62)
        Label4.TabIndex = 2
        Label4.Text = "Backlund Galleyria"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Wheat
        ClientSize = New Size(1554, 853)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Fmenu)
        ForeColor = SystemColors.Control
        FormBorderStyle = FormBorderStyle.None
        MainMenuStrip = Fmenu
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainForm"
        Fmenu.ResumeLayout(False)
        Fmenu.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Fmenu As MenuStrip
    Friend WithEvents CRUDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CashierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
