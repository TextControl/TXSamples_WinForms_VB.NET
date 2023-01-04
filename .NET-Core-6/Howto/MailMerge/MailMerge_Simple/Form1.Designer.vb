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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.m_msMenu = New System.Windows.Forms.MenuStrip()
        Me.m_tmiApplicationFields = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiProperties = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiMailMerge = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiMerge = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_txTextControl = New TXTextControl.TextControl()
        Me.m_bbButtonBar = New TXTextControl.ButtonBar()
        Me.m_rbHorizontalRuler = New TXTextControl.RulerBar()
        Me.m_sbStatusBar = New TXTextControl.StatusBar()
        Me.m_rbVerticalRuler = New TXTextControl.RulerBar()
        Me.m_mmMailMerge = New TXTextControl.DocumentServer.MailMerge(Me.components)
        Me.m_msMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'm_msMenu
        '
        Me.m_msMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.m_msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiApplicationFields, Me.m_tmiMailMerge})
        Me.m_msMenu.Location = New System.Drawing.Point(0, 0)
        Me.m_msMenu.Name = "m_msMenu"
        Me.m_msMenu.Size = New System.Drawing.Size(800, 24)
        Me.m_msMenu.TabIndex = 7
        Me.m_msMenu.Text = "menuStrip1"
        '
        'm_tmiApplicationFields
        '
        Me.m_tmiApplicationFields.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiAdd, Me.m_tmiProperties})
        Me.m_tmiApplicationFields.Name = "m_tmiApplicationFields"
        Me.m_tmiApplicationFields.Size = New System.Drawing.Size(113, 20)
        Me.m_tmiApplicationFields.Text = "&Application Fields"
        '
        'm_tmiAdd
        '
        Me.m_tmiAdd.Name = "m_tmiAdd"
        Me.m_tmiAdd.Size = New System.Drawing.Size(136, 22)
        Me.m_tmiAdd.Text = "&Add"
        '
        'm_tmiProperties
        '
        Me.m_tmiProperties.Name = "m_tmiProperties"
        Me.m_tmiProperties.Size = New System.Drawing.Size(136, 22)
        Me.m_tmiProperties.Text = "&Properties..."
        '
        'm_tmiMailMerge
        '
        Me.m_tmiMailMerge.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiMerge})
        Me.m_tmiMailMerge.Name = "m_tmiMailMerge"
        Me.m_tmiMailMerge.Size = New System.Drawing.Size(79, 20)
        Me.m_tmiMailMerge.Text = "&Mail Merge"
        '
        'm_tmiMerge
        '
        Me.m_tmiMerge.Name = "m_tmiMerge"
        Me.m_tmiMerge.Size = New System.Drawing.Size(108, 22)
        Me.m_tmiMerge.Text = "&Merge"
        '
        'm_txTextControl
        '
        Me.m_txTextControl.ButtonBar = Me.m_bbButtonBar
        Me.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_txTextControl.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.m_txTextControl.FormattingPrinter = "Standard"
        Me.m_txTextControl.Location = New System.Drawing.Point(25, 78)
        Me.m_txTextControl.Name = "m_txTextControl"
        Me.m_txTextControl.RulerBar = Me.m_rbHorizontalRuler
        Me.m_txTextControl.Size = New System.Drawing.Size(775, 350)
        Me.m_txTextControl.StatusBar = Me.m_sbStatusBar
        Me.m_txTextControl.TabIndex = 8
        Me.m_txTextControl.UserNames = Nothing
        Me.m_txTextControl.VerticalRulerBar = Me.m_rbVerticalRuler
        '
        'm_bbButtonBar
        '
        Me.m_bbButtonBar.BackColor = System.Drawing.SystemColors.Control
        Me.m_bbButtonBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_bbButtonBar.Location = New System.Drawing.Point(0, 24)
        Me.m_bbButtonBar.Name = "m_bbButtonBar"
        Me.m_bbButtonBar.Size = New System.Drawing.Size(800, 29)
        Me.m_bbButtonBar.TabIndex = 9
        Me.m_bbButtonBar.Text = "ButtonBar1"
        '
        'm_rbHorizontalRuler
        '
        Me.m_rbHorizontalRuler.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_rbHorizontalRuler.Location = New System.Drawing.Point(0, 53)
        Me.m_rbHorizontalRuler.Name = "m_rbHorizontalRuler"
        Me.m_rbHorizontalRuler.Size = New System.Drawing.Size(800, 25)
        Me.m_rbHorizontalRuler.TabIndex = 12
        Me.m_rbHorizontalRuler.Text = "RulerBar2"
        '
        'm_sbStatusBar
        '
        Me.m_sbStatusBar.BackColor = System.Drawing.SystemColors.Control
        Me.m_sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.m_sbStatusBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.m_sbStatusBar.Location = New System.Drawing.Point(0, 428)
        Me.m_sbStatusBar.Name = "m_sbStatusBar"
        Me.m_sbStatusBar.Size = New System.Drawing.Size(800, 22)
        Me.m_sbStatusBar.TabIndex = 10
        '
        'm_rbVerticalRuler
        '
        Me.m_rbVerticalRuler.Alignment = TXTextControl.RulerBarAlignment.Left
        Me.m_rbVerticalRuler.Dock = System.Windows.Forms.DockStyle.Left
        Me.m_rbVerticalRuler.Location = New System.Drawing.Point(0, 78)
        Me.m_rbVerticalRuler.Name = "m_rbVerticalRuler"
        Me.m_rbVerticalRuler.Size = New System.Drawing.Size(25, 350)
        Me.m_rbVerticalRuler.TabIndex = 11
        Me.m_rbVerticalRuler.Text = "RulerBar1"
        '
        'm_mmMailMerge
        '
        Me.m_mmMailMerge.DataSourceCulture = New System.Globalization.CultureInfo("de-DE")
        Me.m_mmMailMerge.DateFieldUtcOffset = Nothing
        Me.m_mmMailMerge.MergeCulture = New System.Globalization.CultureInfo("de-DE")
        Me.m_mmMailMerge.TextComponent = Me.m_txTextControl
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.m_txTextControl)
        Me.Controls.Add(Me.m_rbVerticalRuler)
        Me.Controls.Add(Me.m_rbHorizontalRuler)
        Me.Controls.Add(Me.m_bbButtonBar)
        Me.Controls.Add(Me.m_sbStatusBar)
        Me.Controls.Add(Me.m_msMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Howto: Mail Merge - Sample: Simple Mail Merge"
        Me.m_msMenu.ResumeLayout(False)
        Me.m_msMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents m_msMenu As MenuStrip
    Private WithEvents m_tmiApplicationFields As ToolStripMenuItem
    Private WithEvents m_tmiAdd As ToolStripMenuItem
    Private WithEvents m_tmiProperties As ToolStripMenuItem
    Private WithEvents m_tmiMailMerge As ToolStripMenuItem
    Private WithEvents m_tmiMerge As ToolStripMenuItem
    Friend WithEvents m_txTextControl As TXTextControl.TextControl
    Friend WithEvents m_bbButtonBar As TXTextControl.ButtonBar
    Friend WithEvents m_rbHorizontalRuler As TXTextControl.RulerBar
    Friend WithEvents m_sbStatusBar As TXTextControl.StatusBar
    Friend WithEvents m_rbVerticalRuler As TXTextControl.RulerBar
    Friend WithEvents m_mmMailMerge As TXTextControl.DocumentServer.MailMerge
End Class
