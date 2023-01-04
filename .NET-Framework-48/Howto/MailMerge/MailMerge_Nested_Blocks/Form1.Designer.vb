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
        Me.m_pbProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.m_lblProgress = New System.Windows.Forms.ToolStripLabel()
        Me.m_tsReporting = New System.Windows.Forms.ToolStrip()
        Me.m_tmiDatasource = New System.Windows.Forms.ToolStripDropDownButton()
        Me.m_tmiLoadSampleDatasource = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiLoadXML = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_lblLoadedDatabaseFile = New System.Windows.Forms.ToolStripLabel()
        Me.m_tbxLoadedDatabaseFile = New System.Windows.Forms.ToolStripTextBox()
        Me.m_sepSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.m_tmiCreateReport = New System.Windows.Forms.ToolStripButton()
        Me.m_sepSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.m_txTextControl = New TXTextControl.TextControl()
        Me.m_bbButtonBar = New TXTextControl.ButtonBar()
        Me.m_rbHorizontalRuler = New TXTextControl.RulerBar()
        Me.m_sbStatusBar = New TXTextControl.StatusBar()
        Me.m_rbVerticalRuler = New TXTextControl.RulerBar()
        Me.m_mmMailMerge = New TXTextControl.DocumentServer.MailMerge(Me.components)
        Me.m_tsReporting.SuspendLayout()
        Me.SuspendLayout()
        '
        'm_pbProgress
        '
        Me.m_pbProgress.Margin = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.m_pbProgress.Name = "m_pbProgress"
        Me.m_pbProgress.Size = New System.Drawing.Size(100, 23)
        Me.m_pbProgress.Step = 1
        '
        'm_lblProgress
        '
        Me.m_lblProgress.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.m_lblProgress.Name = "m_lblProgress"
        Me.m_lblProgress.Size = New System.Drawing.Size(55, 23)
        Me.m_lblProgress.Text = "Progress:"
        '
        'm_tsReporting
        '
        Me.m_tsReporting.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.m_tsReporting.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiDatasource, Me.m_lblLoadedDatabaseFile, Me.m_tbxLoadedDatabaseFile, Me.m_sepSeparator1, Me.m_tmiCreateReport, Me.m_sepSeparator2, Me.m_lblProgress, Me.m_pbProgress})
        Me.m_tsReporting.Location = New System.Drawing.Point(0, 0)
        Me.m_tsReporting.Name = "m_tsReporting"
        Me.m_tsReporting.Padding = New System.Windows.Forms.Padding(0, 3, 1, 3)
        Me.m_tsReporting.Size = New System.Drawing.Size(800, 29)
        Me.m_tsReporting.TabIndex = 9
        Me.m_tsReporting.Text = "toolStrip1"
        '
        'm_tmiDatasource
        '
        Me.m_tmiDatasource.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.m_tmiDatasource.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiLoadSampleDatasource, Me.m_tmiLoadXML})
        Me.m_tmiDatasource.Margin = New System.Windows.Forms.Padding(0)
        Me.m_tmiDatasource.Name = "m_tmiDatasource"
        Me.m_tmiDatasource.Size = New System.Drawing.Size(79, 23)
        Me.m_tmiDatasource.Text = "&Datasource"
        '
        'm_tmiLoadSampleDatasource
        '
        Me.m_tmiLoadSampleDatasource.Name = "m_tmiLoadSampleDatasource"
        Me.m_tmiLoadSampleDatasource.Size = New System.Drawing.Size(204, 22)
        Me.m_tmiLoadSampleDatasource.Text = "Load &Sample Datasource"
        '
        'm_tmiLoadXML
        '
        Me.m_tmiLoadXML.Name = "m_tmiLoadXML"
        Me.m_tmiLoadXML.Size = New System.Drawing.Size(204, 22)
        Me.m_tmiLoadXML.Text = "&Load XML..."
        '
        'm_lblLoadedDatabaseFile
        '
        Me.m_lblLoadedDatabaseFile.Margin = New System.Windows.Forms.Padding(11, 1, 0, 0)
        Me.m_lblLoadedDatabaseFile.Name = "m_lblLoadedDatabaseFile"
        Me.m_lblLoadedDatabaseFile.Size = New System.Drawing.Size(118, 22)
        Me.m_lblLoadedDatabaseFile.Text = "Loaded database file:"
        '
        'm_tbxLoadedDatabaseFile
        '
        Me.m_tbxLoadedDatabaseFile.AutoSize = False
        Me.m_tbxLoadedDatabaseFile.Enabled = False
        Me.m_tbxLoadedDatabaseFile.Margin = New System.Windows.Forms.Padding(11, 0, 5, 0)
        Me.m_tbxLoadedDatabaseFile.Name = "m_tbxLoadedDatabaseFile"
        Me.m_tbxLoadedDatabaseFile.Size = New System.Drawing.Size(150, 23)
        '
        'm_sepSeparator1
        '
        Me.m_sepSeparator1.Name = "m_sepSeparator1"
        Me.m_sepSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'm_tmiCreateReport
        '
        Me.m_tmiCreateReport.Enabled = False
        Me.m_tmiCreateReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.m_tmiCreateReport.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.m_tmiCreateReport.Name = "m_tmiCreateReport"
        Me.m_tmiCreateReport.Size = New System.Drawing.Size(83, 23)
        Me.m_tmiCreateReport.Text = "&Create Report"
        '
        'm_sepSeparator2
        '
        Me.m_sepSeparator2.Name = "m_sepSeparator2"
        Me.m_sepSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'm_txTextControl
        '
        Me.m_txTextControl.ButtonBar = Me.m_bbButtonBar
        Me.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_txTextControl.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.m_txTextControl.FormattingPrinter = "Standard"
        Me.m_txTextControl.Location = New System.Drawing.Point(25, 83)
        Me.m_txTextControl.Name = "m_txTextControl"
        Me.m_txTextControl.RulerBar = Me.m_rbHorizontalRuler
        Me.m_txTextControl.Size = New System.Drawing.Size(775, 345)
        Me.m_txTextControl.StatusBar = Me.m_sbStatusBar
        Me.m_txTextControl.TabIndex = 10
        Me.m_txTextControl.UserNames = Nothing
        Me.m_txTextControl.VerticalRulerBar = Me.m_rbVerticalRuler
        '
        'm_bbButtonBar
        '
        Me.m_bbButtonBar.BackColor = System.Drawing.SystemColors.Control
        Me.m_bbButtonBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_bbButtonBar.Location = New System.Drawing.Point(0, 29)
        Me.m_bbButtonBar.Name = "m_bbButtonBar"
        Me.m_bbButtonBar.Size = New System.Drawing.Size(800, 29)
        Me.m_bbButtonBar.TabIndex = 11
        Me.m_bbButtonBar.Text = "ButtonBar1"
        '
        'm_rbHorizontalRuler
        '
        Me.m_rbHorizontalRuler.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_rbHorizontalRuler.Location = New System.Drawing.Point(0, 58)
        Me.m_rbHorizontalRuler.Name = "m_rbHorizontalRuler"
        Me.m_rbHorizontalRuler.Size = New System.Drawing.Size(800, 25)
        Me.m_rbHorizontalRuler.TabIndex = 14
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
        Me.m_sbStatusBar.TabIndex = 12
        '
        'm_rbVerticalRuler
        '
        Me.m_rbVerticalRuler.Alignment = TXTextControl.RulerBarAlignment.Left
        Me.m_rbVerticalRuler.Dock = System.Windows.Forms.DockStyle.Left
        Me.m_rbVerticalRuler.Location = New System.Drawing.Point(0, 83)
        Me.m_rbVerticalRuler.Name = "m_rbVerticalRuler"
        Me.m_rbVerticalRuler.Size = New System.Drawing.Size(25, 345)
        Me.m_rbVerticalRuler.TabIndex = 13
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
        Me.Controls.Add(Me.m_tsReporting)
        Me.Controls.Add(Me.m_sbStatusBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Howto: Mail Merge - Sample: Mail Merge with Nested Repeating Blocks"
        Me.m_tsReporting.ResumeLayout(False)
        Me.m_tsReporting.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents m_pbProgress As ToolStripProgressBar
    Private WithEvents m_lblProgress As ToolStripLabel
    Private WithEvents m_tsReporting As ToolStrip
    Private WithEvents m_tmiDatasource As ToolStripDropDownButton
    Private WithEvents m_tmiLoadSampleDatasource As ToolStripMenuItem
    Private WithEvents m_tmiLoadXML As ToolStripMenuItem
    Private WithEvents m_lblLoadedDatabaseFile As ToolStripLabel
    Private WithEvents m_tbxLoadedDatabaseFile As ToolStripTextBox
    Private WithEvents m_sepSeparator1 As ToolStripSeparator
    Private WithEvents m_tmiCreateReport As ToolStripButton
    Private WithEvents m_sepSeparator2 As ToolStripSeparator
    Friend WithEvents m_txTextControl As TXTextControl.TextControl
    Friend WithEvents m_bbButtonBar As TXTextControl.ButtonBar
    Friend WithEvents m_rbHorizontalRuler As TXTextControl.RulerBar
    Friend WithEvents m_sbStatusBar As TXTextControl.StatusBar
    Friend WithEvents m_rbVerticalRuler As TXTextControl.RulerBar
    Friend WithEvents m_mmMailMerge As TXTextControl.DocumentServer.MailMerge
End Class
