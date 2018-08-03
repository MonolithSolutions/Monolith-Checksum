<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BT_CHECK = New System.Windows.Forms.Button()
        Me.BT_CLEAR = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_DIR = New System.Windows.Forms.TextBox()
        Me.BT_OPEN = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_MD5 = New System.Windows.Forms.TextBox()
        Me.TB_MD5CALC = New System.Windows.Forms.TextBox()
        Me.TB_SHA1CALC = New System.Windows.Forms.TextBox()
        Me.TB_SHA1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_SHA256CALC = New System.Windows.Forms.TextBox()
        Me.TB_SHA256 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BT_EXIT = New System.Windows.Forms.Button()
        Me.PIC_MD5 = New System.Windows.Forms.PictureBox()
        Me.PIC_SHA1 = New System.Windows.Forms.PictureBox()
        Me.PIC_SHA256 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PIC_MD5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_SHA1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_SHA256, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BT_CHECK
        '
        Me.BT_CHECK.Location = New System.Drawing.Point(26, 340)
        Me.BT_CHECK.Name = "BT_CHECK"
        Me.BT_CHECK.Size = New System.Drawing.Size(75, 23)
        Me.BT_CHECK.TabIndex = 0
        Me.BT_CHECK.Text = "Check"
        Me.BT_CHECK.UseVisualStyleBackColor = True
        '
        'BT_CLEAR
        '
        Me.BT_CLEAR.Location = New System.Drawing.Point(107, 340)
        Me.BT_CLEAR.Name = "BT_CLEAR"
        Me.BT_CLEAR.Size = New System.Drawing.Size(75, 23)
        Me.BT_CLEAR.TabIndex = 1
        Me.BT_CLEAR.Text = "Clear"
        Me.BT_CLEAR.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(545, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileToolStripMenuItem, Me.OpenFolderToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.OpenFileToolStripMenuItem.Text = "Open File"
        '
        'OpenFolderToolStripMenuItem
        '
        Me.OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem"
        Me.OpenFolderToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.OpenFolderToolStripMenuItem.Text = "Open Folder"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'TB_DIR
        '
        Me.TB_DIR.Location = New System.Drawing.Point(26, 44)
        Me.TB_DIR.Name = "TB_DIR"
        Me.TB_DIR.Size = New System.Drawing.Size(417, 20)
        Me.TB_DIR.TabIndex = 4
        '
        'BT_OPEN
        '
        Me.BT_OPEN.Location = New System.Drawing.Point(449, 44)
        Me.BT_OPEN.Name = "BT_OPEN"
        Me.BT_OPEN.Size = New System.Drawing.Size(75, 23)
        Me.BT_OPEN.TabIndex = 5
        Me.BT_OPEN.Text = "Open"
        Me.BT_OPEN.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Paste MD5 Checksum To Compare"
        '
        'TB_MD5
        '
        Me.TB_MD5.Location = New System.Drawing.Point(26, 97)
        Me.TB_MD5.Name = "TB_MD5"
        Me.TB_MD5.Size = New System.Drawing.Size(417, 20)
        Me.TB_MD5.TabIndex = 7
        '
        'TB_MD5CALC
        '
        Me.TB_MD5CALC.Location = New System.Drawing.Point(26, 123)
        Me.TB_MD5CALC.Name = "TB_MD5CALC"
        Me.TB_MD5CALC.ReadOnly = True
        Me.TB_MD5CALC.Size = New System.Drawing.Size(417, 20)
        Me.TB_MD5CALC.TabIndex = 8
        '
        'TB_SHA1CALC
        '
        Me.TB_SHA1CALC.Location = New System.Drawing.Point(26, 210)
        Me.TB_SHA1CALC.Name = "TB_SHA1CALC"
        Me.TB_SHA1CALC.ReadOnly = True
        Me.TB_SHA1CALC.Size = New System.Drawing.Size(417, 20)
        Me.TB_SHA1CALC.TabIndex = 11
        '
        'TB_SHA1
        '
        Me.TB_SHA1.Location = New System.Drawing.Point(26, 184)
        Me.TB_SHA1.Name = "TB_SHA1"
        Me.TB_SHA1.Size = New System.Drawing.Size(417, 20)
        Me.TB_SHA1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Paste SHA1 Checksum To Compare"
        '
        'TB_SHA256CALC
        '
        Me.TB_SHA256CALC.Location = New System.Drawing.Point(26, 302)
        Me.TB_SHA256CALC.Name = "TB_SHA256CALC"
        Me.TB_SHA256CALC.ReadOnly = True
        Me.TB_SHA256CALC.Size = New System.Drawing.Size(417, 20)
        Me.TB_SHA256CALC.TabIndex = 15
        '
        'TB_SHA256
        '
        Me.TB_SHA256.Location = New System.Drawing.Point(26, 276)
        Me.TB_SHA256.Name = "TB_SHA256"
        Me.TB_SHA256.Size = New System.Drawing.Size(417, 20)
        Me.TB_SHA256.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Paste SHA256 Checksum To Compare"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(126, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 12
        '
        'BT_EXIT
        '
        Me.BT_EXIT.Location = New System.Drawing.Point(188, 340)
        Me.BT_EXIT.Name = "BT_EXIT"
        Me.BT_EXIT.Size = New System.Drawing.Size(75, 23)
        Me.BT_EXIT.TabIndex = 16
        Me.BT_EXIT.Text = "Exit"
        Me.BT_EXIT.UseVisualStyleBackColor = True
        '
        'PIC_MD5
        '
        Me.PIC_MD5.Location = New System.Drawing.Point(449, 93)
        Me.PIC_MD5.Name = "PIC_MD5"
        Me.PIC_MD5.Size = New System.Drawing.Size(50, 50)
        Me.PIC_MD5.TabIndex = 17
        Me.PIC_MD5.TabStop = False
        '
        'PIC_SHA1
        '
        Me.PIC_SHA1.Location = New System.Drawing.Point(449, 180)
        Me.PIC_SHA1.Name = "PIC_SHA1"
        Me.PIC_SHA1.Size = New System.Drawing.Size(50, 50)
        Me.PIC_SHA1.TabIndex = 18
        Me.PIC_SHA1.TabStop = False
        '
        'PIC_SHA256
        '
        Me.PIC_SHA256.Location = New System.Drawing.Point(449, 272)
        Me.PIC_SHA256.Name = "PIC_SHA256"
        Me.PIC_SHA256.Size = New System.Drawing.Size(50, 50)
        Me.PIC_SHA256.TabIndex = 19
        Me.PIC_SHA256.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(33, 376)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(221, 13)
        Me.LinkLabel1.TabIndex = 21
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://www.monolithsolutions.ca/downloads"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 410)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PIC_SHA256)
        Me.Controls.Add(Me.PIC_SHA1)
        Me.Controls.Add(Me.PIC_MD5)
        Me.Controls.Add(Me.BT_EXIT)
        Me.Controls.Add(Me.TB_SHA256CALC)
        Me.Controls.Add(Me.TB_SHA256)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_SHA1CALC)
        Me.Controls.Add(Me.TB_SHA1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_MD5CALC)
        Me.Controls.Add(Me.TB_MD5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BT_OPEN)
        Me.Controls.Add(Me.TB_DIR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BT_CLEAR)
        Me.Controls.Add(Me.BT_CHECK)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Monolith Checksum"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PIC_MD5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_SHA1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_SHA256, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_CHECK As Button
    Friend WithEvents BT_CLEAR As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_DIR As TextBox
    Friend WithEvents BT_OPEN As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_MD5 As TextBox
    Friend WithEvents TB_MD5CALC As TextBox
    Friend WithEvents TB_SHA1CALC As TextBox
    Friend WithEvents TB_SHA1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_SHA256CALC As TextBox
    Friend WithEvents TB_SHA256 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BT_EXIT As Button
    Friend WithEvents PIC_MD5 As PictureBox
    Friend WithEvents PIC_SHA1 As PictureBox
    Friend WithEvents PIC_SHA256 As PictureBox
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents OpenFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
