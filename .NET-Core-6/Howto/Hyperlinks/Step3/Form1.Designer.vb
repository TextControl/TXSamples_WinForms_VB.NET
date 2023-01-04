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
        Me.m_tmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiLinks = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiInsertLink = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiEditLink = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiShowHyperlinks = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiShowDocumentLinks = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiDocumentTargets = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiInsertDocumentTarget = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiEditDocumentTarget = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiDeleteAndGoTo = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiShowDocumentTargets = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_txTextControl = New TXTextControl.TextControl()
        Me.m_msMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'm_msMenu
        '
        Me.m_msMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.m_msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiFile, Me.m_tmiLinks, Me.m_tmiDocumentTargets})
        Me.m_msMenu.Location = New System.Drawing.Point(0, 0)
        Me.m_msMenu.Name = "m_msMenu"
        Me.m_msMenu.Size = New System.Drawing.Size(800, 24)
        Me.m_msMenu.TabIndex = 1
        Me.m_msMenu.Text = "menuStrip1"
        '
        'm_tmiFile
        '
        Me.m_tmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiNew, Me.m_tmiOpen, Me.m_tmiSaveAs})
        Me.m_tmiFile.Name = "m_tmiFile"
        Me.m_tmiFile.Size = New System.Drawing.Size(37, 20)
        Me.m_tmiFile.Text = "&File"
        '
        'm_tmiNew
        '
        Me.m_tmiNew.Name = "m_tmiNew"
        Me.m_tmiNew.Size = New System.Drawing.Size(123, 22)
        Me.m_tmiNew.Text = "New"
        '
        'm_tmiOpen
        '
        Me.m_tmiOpen.Name = "m_tmiOpen"
        Me.m_tmiOpen.Size = New System.Drawing.Size(123, 22)
        Me.m_tmiOpen.Text = "&Open..."
        '
        'm_tmiSaveAs
        '
        Me.m_tmiSaveAs.Name = "m_tmiSaveAs"
        Me.m_tmiSaveAs.Size = New System.Drawing.Size(123, 22)
        Me.m_tmiSaveAs.Text = "Save As..."
        '
        'm_tmiLinks
        '
        Me.m_tmiLinks.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiInsertLink, Me.m_tmiEditLink, Me.m_tmiShowHyperlinks, Me.m_tmiShowDocumentLinks})
        Me.m_tmiLinks.Name = "m_tmiLinks"
        Me.m_tmiLinks.Size = New System.Drawing.Size(46, 20)
        Me.m_tmiLinks.Text = "Links"
        '
        'm_tmiInsertLink
        '
        Me.m_tmiInsertLink.Name = "m_tmiInsertLink"
        Me.m_tmiInsertLink.Size = New System.Drawing.Size(192, 22)
        Me.m_tmiInsertLink.Text = "Insert..."
        '
        'm_tmiEditLink
        '
        Me.m_tmiEditLink.Name = "m_tmiEditLink"
        Me.m_tmiEditLink.Size = New System.Drawing.Size(192, 22)
        Me.m_tmiEditLink.Text = "Edit..."
        '
        'm_tmiShowHyperlinks
        '
        Me.m_tmiShowHyperlinks.Checked = True
        Me.m_tmiShowHyperlinks.CheckOnClick = True
        Me.m_tmiShowHyperlinks.CheckState = System.Windows.Forms.CheckState.Checked
        Me.m_tmiShowHyperlinks.Name = "m_tmiShowHyperlinks"
        Me.m_tmiShowHyperlinks.Size = New System.Drawing.Size(192, 22)
        Me.m_tmiShowHyperlinks.Text = "Show Hyperlinks"
        '
        'm_tmiShowDocumentLinks
        '
        Me.m_tmiShowDocumentLinks.Checked = True
        Me.m_tmiShowDocumentLinks.CheckOnClick = True
        Me.m_tmiShowDocumentLinks.CheckState = System.Windows.Forms.CheckState.Checked
        Me.m_tmiShowDocumentLinks.Name = "m_tmiShowDocumentLinks"
        Me.m_tmiShowDocumentLinks.Size = New System.Drawing.Size(192, 22)
        Me.m_tmiShowDocumentLinks.Text = "Show Document Links"
        '
        'm_tmiDocumentTargets
        '
        Me.m_tmiDocumentTargets.Checked = True
        Me.m_tmiDocumentTargets.CheckOnClick = True
        Me.m_tmiDocumentTargets.CheckState = System.Windows.Forms.CheckState.Checked
        Me.m_tmiDocumentTargets.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiInsertDocumentTarget, Me.m_tmiEditDocumentTarget, Me.m_tmiDeleteAndGoTo, Me.m_tmiShowDocumentTargets})
        Me.m_tmiDocumentTargets.Name = "m_tmiDocumentTargets"
        Me.m_tmiDocumentTargets.Size = New System.Drawing.Size(115, 20)
        Me.m_tmiDocumentTargets.Text = "Document Targets"
        '
        'm_tmiInsertDocumentTarget
        '
        Me.m_tmiInsertDocumentTarget.Name = "m_tmiInsertDocumentTarget"
        Me.m_tmiInsertDocumentTarget.Size = New System.Drawing.Size(172, 22)
        Me.m_tmiInsertDocumentTarget.Text = "Insert.."
        '
        'm_tmiEditDocumentTarget
        '
        Me.m_tmiEditDocumentTarget.Name = "m_tmiEditDocumentTarget"
        Me.m_tmiEditDocumentTarget.Size = New System.Drawing.Size(172, 22)
        Me.m_tmiEditDocumentTarget.Text = "Edit..."
        '
        'm_tmiDeleteAndGoTo
        '
        Me.m_tmiDeleteAndGoTo.Name = "m_tmiDeleteAndGoTo"
        Me.m_tmiDeleteAndGoTo.Size = New System.Drawing.Size(172, 22)
        Me.m_tmiDeleteAndGoTo.Text = "Delete and Go To..."
        '
        'm_tmiShowDocumentTargets
        '
        Me.m_tmiShowDocumentTargets.CheckOnClick = True
        Me.m_tmiShowDocumentTargets.Name = "m_tmiShowDocumentTargets"
        Me.m_tmiShowDocumentTargets.Size = New System.Drawing.Size(172, 22)
        Me.m_tmiShowDocumentTargets.Text = "Show"
        '
        'm_txTextControl
        '
        Me.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_txTextControl.DocumentTargetMarkers = True
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
        Me.Text = "Howto: Use Hypertext Links - Step 3: Adding Document Targets"
        Me.m_msMenu.ResumeLayout(False)
        Me.m_msMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents m_msMenu As MenuStrip
    Private WithEvents m_tmiFile As ToolStripMenuItem
    Private WithEvents m_tmiNew As ToolStripMenuItem
    Private WithEvents m_tmiOpen As ToolStripMenuItem
    Private WithEvents m_tmiSaveAs As ToolStripMenuItem
    Private WithEvents m_tmiLinks As ToolStripMenuItem
    Private WithEvents m_tmiInsertLink As ToolStripMenuItem
    Private WithEvents m_tmiEditLink As ToolStripMenuItem
    Private WithEvents m_tmiShowHyperlinks As ToolStripMenuItem
    Private WithEvents m_tmiShowDocumentLinks As ToolStripMenuItem
    Private WithEvents m_tmiDocumentTargets As ToolStripMenuItem
    Private WithEvents m_tmiInsertDocumentTarget As ToolStripMenuItem
    Private WithEvents m_tmiEditDocumentTarget As ToolStripMenuItem
    Private WithEvents m_tmiDeleteAndGoTo As ToolStripMenuItem
    Private WithEvents m_tmiShowDocumentTargets As ToolStripMenuItem
    Friend WithEvents m_txTextControl As TXTextControl.TextControl
End Class
