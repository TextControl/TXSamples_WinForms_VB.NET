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
        Me.m_msMenu = New System.Windows.Forms.MenuStrip()
        Me.m_tmiHyperlinks = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiInsertHyperlink = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiEditHyperlink = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiShowHyperlinks = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_txTextControl = New TXTextControl.TextControl()
        Me.m_msMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'm_msMenu
        '
        Me.m_msMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.m_msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiHyperlinks})
        Me.m_msMenu.Location = New System.Drawing.Point(0, 0)
        Me.m_msMenu.Name = "m_msMenu"
        Me.m_msMenu.Size = New System.Drawing.Size(800, 24)
        Me.m_msMenu.TabIndex = 1
        Me.m_msMenu.Text = "menuStrip1"
        '
        'm_tmiHyperlinks
        '
        Me.m_tmiHyperlinks.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiInsertHyperlink, Me.m_tmiEditHyperlink, Me.m_tmiShowHyperlinks})
        Me.m_tmiHyperlinks.Name = "m_tmiHyperlinks"
        Me.m_tmiHyperlinks.Size = New System.Drawing.Size(75, 20)
        Me.m_tmiHyperlinks.Text = "&Hyperlinks"
        '
        'm_tmiInsertHyperlink
        '
        Me.m_tmiInsertHyperlink.Name = "m_tmiInsertHyperlink"
        Me.m_tmiInsertHyperlink.Size = New System.Drawing.Size(112, 22)
        Me.m_tmiInsertHyperlink.Text = "&Insert..."
        '
        'm_tmiEditHyperlink
        '
        Me.m_tmiEditHyperlink.Name = "m_tmiEditHyperlink"
        Me.m_tmiEditHyperlink.Size = New System.Drawing.Size(112, 22)
        Me.m_tmiEditHyperlink.Text = "&Edit..."
        '
        'm_tmiShowHyperlinks
        '
        Me.m_tmiShowHyperlinks.Checked = True
        Me.m_tmiShowHyperlinks.CheckOnClick = True
        Me.m_tmiShowHyperlinks.CheckState = System.Windows.Forms.CheckState.Checked
        Me.m_tmiShowHyperlinks.Name = "m_tmiShowHyperlinks"
        Me.m_tmiShowHyperlinks.Size = New System.Drawing.Size(112, 22)
        Me.m_tmiShowHyperlinks.Text = "&Show"
        '
        'm_txTextControl
        '
        Me.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_txTextControl.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.m_txTextControl.FormattingPrinter = "Standard"
        Me.m_txTextControl.Location = New System.Drawing.Point(0, 24)
        Me.m_txTextControl.Name = "m_txTextControl"
        Me.m_txTextControl.Size = New System.Drawing.Size(800, 426)
        Me.m_txTextControl.TabIndex = 2
        Me.m_txTextControl.UserNames = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.m_txTextControl)
        Me.Controls.Add(Me.m_msMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.m_msMenu
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Howto: Use Hypertext Links - Step 2: Adding a Dialog Box for Inserting Hypertext " &
    "Links"
        Me.m_msMenu.ResumeLayout(False)
        Me.m_msMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents m_msMenu As MenuStrip
    Private WithEvents m_tmiHyperlinks As ToolStripMenuItem
    Private WithEvents m_tmiInsertHyperlink As ToolStripMenuItem
    Private WithEvents m_tmiEditHyperlink As ToolStripMenuItem
    Private WithEvents m_tmiShowHyperlinks As ToolStripMenuItem
    Friend WithEvents m_txTextControl As TXTextControl.TextControl
End Class
