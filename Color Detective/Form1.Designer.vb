<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadColorDetectiveHistoryFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveHistoryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.HistoryMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ColorTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BgTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.HistoryMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(458, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadColorDetectiveHistoryFileToolStripMenuItem, Me.SaveHistoryToolStripMenuItem1, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoadColorDetectiveHistoryFileToolStripMenuItem
        '
        Me.LoadColorDetectiveHistoryFileToolStripMenuItem.Name = "LoadColorDetectiveHistoryFileToolStripMenuItem"
        Me.LoadColorDetectiveHistoryFileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.LoadColorDetectiveHistoryFileToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.LoadColorDetectiveHistoryFileToolStripMenuItem.Text = "Load History..."
        '
        'SaveHistoryToolStripMenuItem1
        '
        Me.SaveHistoryToolStripMenuItem1.Name = "SaveHistoryToolStripMenuItem1"
        Me.SaveHistoryToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveHistoryToolStripMenuItem1.Size = New System.Drawing.Size(193, 22)
        Me.SaveHistoryToolStripMenuItem1.Text = "Save History..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(190, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'ListBox1
        '
        Me.ListBox1.ContextMenuStrip = Me.HistoryMenu
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(254, 59)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(191, 274)
        Me.ListBox1.TabIndex = 1
        '
        'HistoryMenu
        '
        Me.HistoryMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveHistoryToolStripMenuItem, Me.LoadHistoryToolStripMenuItem, Me.ToolStripSeparator2, Me.DeleteItemToolStripMenuItem})
        Me.HistoryMenu.Name = "HistoryMenu"
        Me.HistoryMenu.Size = New System.Drawing.Size(168, 76)
        '
        'SaveHistoryToolStripMenuItem
        '
        Me.SaveHistoryToolStripMenuItem.Name = "SaveHistoryToolStripMenuItem"
        Me.SaveHistoryToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.SaveHistoryToolStripMenuItem.Text = "Save History..."
        '
        'LoadHistoryToolStripMenuItem
        '
        Me.LoadHistoryToolStripMenuItem.Name = "LoadHistoryToolStripMenuItem"
        Me.LoadHistoryToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.LoadHistoryToolStripMenuItem.Text = "Load History..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(164, 6)
        '
        'DeleteItemToolStripMenuItem
        '
        Me.DeleteItemToolStripMenuItem.Enabled = False
        Me.DeleteItemToolStripMenuItem.Name = "DeleteItemToolStripMenuItem"
        Me.DeleteItemToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteItemToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.DeleteItemToolStripMenuItem.Text = "Delete Item..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(251, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selection History"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Current Color"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(345, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "(highlight to copy)"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 23)
        Me.TextBox1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 30)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Press the ENTER key to save the color to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the selection history."
        '
        'ColorTimer
        '
        Me.ColorTimer.Interval = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(12, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(223, 79)
        Me.Panel1.TabIndex = 9
        Me.Panel1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 46)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Click to resume detection..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "cdb"
        Me.SaveFileDialog1.Filter = "Color Detective History File (*.cdb)|*.cdb"
        Me.SaveFileDialog1.Title = "Save Selection History..."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "cdb"
        Me.OpenFileDialog1.Filter = "Color Detective History Files (*.cdb)|*.cdb"
        Me.OpenFileDialog1.Title = "Open Color History..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(15, 132)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 201)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'BgTimer
        '
        Me.BgTimer.Interval = 1
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 350)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainWindow"
        Me.Text = "Color Detective"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.HistoryMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ColorTimer As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents HistoryMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SaveHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LoadColorDetectiveHistoryFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveHistoryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BgTimer As System.Windows.Forms.Timer

End Class
