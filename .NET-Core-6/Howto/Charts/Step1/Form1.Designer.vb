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
        Me.m_lblChartName = New System.Windows.Forms.Label()
        Me.m_tbxChartName = New System.Windows.Forms.TextBox()
        Me.m_pgChartProperties = New System.Windows.Forms.PropertyGrid()
        Me.m_tlpChartPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.m_btnApplyChartName = New System.Windows.Forms.Button()
        Me.m_pnlTextControlPanel = New System.Windows.Forms.Panel()
        Me.m_txTextControl = New TXTextControl.TextControl()
        Me.m_bbButtonBar = New TXTextControl.ButtonBar()
        Me.m_rbHorizontalRuler = New TXTextControl.RulerBar()
        Me.StatusBar1 = New TXTextControl.StatusBar()
        Me.m_rbVerticalRuler = New TXTextControl.RulerBar()
        Me.m_tmiChart = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_msMenu = New System.Windows.Forms.MenuStrip()
        Me.m_tmiInsert = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tlpMainPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.m_tlpChartPanel.SuspendLayout()
        Me.m_pnlTextControlPanel.SuspendLayout()
        Me.m_msMenu.SuspendLayout()
        Me.m_tlpMainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'm_lblChartName
        '
        Me.m_lblChartName.AutoSize = True
        Me.m_lblChartName.Dock = System.Windows.Forms.DockStyle.Left
        Me.m_lblChartName.Location = New System.Drawing.Point(0, 0)
        Me.m_lblChartName.Margin = New System.Windows.Forms.Padding(0)
        Me.m_lblChartName.Name = "m_lblChartName"
        Me.m_lblChartName.Size = New System.Drawing.Size(66, 23)
        Me.m_lblChartName.TabIndex = 0
        Me.m_lblChartName.Text = "Chart &Name:"
        Me.m_lblChartName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'm_tbxChartName
        '
        Me.m_tbxChartName.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_tbxChartName.Location = New System.Drawing.Point(77, 2)
        Me.m_tbxChartName.Margin = New System.Windows.Forms.Padding(11, 2, 0, 0)
        Me.m_tbxChartName.MinimumSize = New System.Drawing.Size(100, 4)
        Me.m_tbxChartName.Name = "m_tbxChartName"
        Me.m_tbxChartName.Size = New System.Drawing.Size(219, 20)
        Me.m_tbxChartName.TabIndex = 1
        '
        'm_pgChartProperties
        '
        Me.m_tlpChartPanel.SetColumnSpan(Me.m_pgChartProperties, 3)
        Me.m_pgChartProperties.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_pgChartProperties.Location = New System.Drawing.Point(0, 31)
        Me.m_pgChartProperties.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.m_pgChartProperties.Name = "m_pgChartProperties"
        Me.m_pgChartProperties.Size = New System.Drawing.Size(347, 414)
        Me.m_pgChartProperties.TabIndex = 3
        '
        'm_tlpChartPanel
        '
        Me.m_tlpChartPanel.AutoSize = True
        Me.m_tlpChartPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.m_tlpChartPanel.ColumnCount = 3
        Me.m_tlpChartPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.m_tlpChartPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.m_tlpChartPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.m_tlpChartPanel.Controls.Add(Me.m_lblChartName, 0, 0)
        Me.m_tlpChartPanel.Controls.Add(Me.m_tbxChartName, 1, 0)
        Me.m_tlpChartPanel.Controls.Add(Me.m_btnApplyChartName, 2, 0)
        Me.m_tlpChartPanel.Controls.Add(Me.m_pgChartProperties, 0, 2)
        Me.m_tlpChartPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_tlpChartPanel.Enabled = False
        Me.m_tlpChartPanel.Location = New System.Drawing.Point(685, 24)
        Me.m_tlpChartPanel.Margin = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.m_tlpChartPanel.Name = "m_tlpChartPanel"
        Me.m_tlpChartPanel.RowCount = 3
        Me.m_tlpChartPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpChartPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpChartPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.m_tlpChartPanel.Size = New System.Drawing.Size(347, 445)
        Me.m_tlpChartPanel.TabIndex = 2
        '
        'm_btnApplyChartName
        '
        Me.m_btnApplyChartName.AutoSize = True
        Me.m_btnApplyChartName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.m_btnApplyChartName.Enabled = False
        Me.m_btnApplyChartName.Location = New System.Drawing.Point(307, 0)
        Me.m_btnApplyChartName.Margin = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.m_btnApplyChartName.MinimumSize = New System.Drawing.Size(40, 23)
        Me.m_btnApplyChartName.Name = "m_btnApplyChartName"
        Me.m_btnApplyChartName.Size = New System.Drawing.Size(40, 23)
        Me.m_btnApplyChartName.TabIndex = 2
        Me.m_btnApplyChartName.Text = "✔"
        Me.m_btnApplyChartName.UseVisualStyleBackColor = True
        '
        'm_pnlTextControlPanel
        '
        Me.m_pnlTextControlPanel.Controls.Add(Me.m_txTextControl)
        Me.m_pnlTextControlPanel.Controls.Add(Me.m_rbVerticalRuler)
        Me.m_pnlTextControlPanel.Controls.Add(Me.m_rbHorizontalRuler)
        Me.m_pnlTextControlPanel.Controls.Add(Me.m_bbButtonBar)
        Me.m_pnlTextControlPanel.Controls.Add(Me.StatusBar1)
        Me.m_pnlTextControlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_pnlTextControlPanel.Location = New System.Drawing.Point(0, 24)
        Me.m_pnlTextControlPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.m_pnlTextControlPanel.Name = "m_pnlTextControlPanel"
        Me.m_pnlTextControlPanel.Size = New System.Drawing.Size(674, 445)
        Me.m_pnlTextControlPanel.TabIndex = 1
        '
        'm_txTextControl
        '
        Me.m_txTextControl.ButtonBar = Me.m_bbButtonBar
        Me.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_txTextControl.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.m_txTextControl.FormattingPrinter = "Standard"
        Me.m_txTextControl.Location = New System.Drawing.Point(25, 54)
        Me.m_txTextControl.Name = "m_txTextControl"
        Me.m_txTextControl.RulerBar = Me.m_rbHorizontalRuler
        Me.m_txTextControl.Size = New System.Drawing.Size(649, 369)
        Me.m_txTextControl.StatusBar = Me.StatusBar1
        Me.m_txTextControl.TabIndex = 0
        Me.m_txTextControl.UserNames = Nothing
        Me.m_txTextControl.VerticalRulerBar = Me.m_rbVerticalRuler
        '
        'm_bbButtonBar
        '
        Me.m_bbButtonBar.BackColor = System.Drawing.SystemColors.Control
        Me.m_bbButtonBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_bbButtonBar.Location = New System.Drawing.Point(0, 0)
        Me.m_bbButtonBar.Name = "m_bbButtonBar"
        Me.m_bbButtonBar.Size = New System.Drawing.Size(674, 29)
        Me.m_bbButtonBar.TabIndex = 1
        Me.m_bbButtonBar.Text = "ButtonBar1"
        '
        'm_rbHorizontalRuler
        '
        Me.m_rbHorizontalRuler.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_rbHorizontalRuler.Location = New System.Drawing.Point(0, 29)
        Me.m_rbHorizontalRuler.Name = "m_rbHorizontalRuler"
        Me.m_rbHorizontalRuler.Size = New System.Drawing.Size(674, 25)
        Me.m_rbHorizontalRuler.TabIndex = 4
        Me.m_rbHorizontalRuler.Text = "RulerBar2"
        '
        'StatusBar1
        '
        Me.StatusBar1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusBar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StatusBar1.Location = New System.Drawing.Point(0, 423)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(674, 22)
        Me.StatusBar1.TabIndex = 2
        '
        'm_rbVerticalRuler
        '
        Me.m_rbVerticalRuler.Alignment = TXTextControl.RulerBarAlignment.Left
        Me.m_rbVerticalRuler.Dock = System.Windows.Forms.DockStyle.Left
        Me.m_rbVerticalRuler.Location = New System.Drawing.Point(0, 54)
        Me.m_rbVerticalRuler.Name = "m_rbVerticalRuler"
        Me.m_rbVerticalRuler.Size = New System.Drawing.Size(25, 369)
        Me.m_rbVerticalRuler.TabIndex = 3
        Me.m_rbVerticalRuler.Text = "RulerBar1"
        '
        'm_tmiChart
        '
        Me.m_tmiChart.Name = "m_tmiChart"
        Me.m_tmiChart.Size = New System.Drawing.Size(103, 22)
        Me.m_tmiChart.Text = "&Chart"
        '
        'm_tmiSaveAs
        '
        Me.m_tmiSaveAs.Name = "m_tmiSaveAs"
        Me.m_tmiSaveAs.Size = New System.Drawing.Size(123, 22)
        Me.m_tmiSaveAs.Text = "&Save As..."
        '
        'm_tmiOpen
        '
        Me.m_tmiOpen.Name = "m_tmiOpen"
        Me.m_tmiOpen.Size = New System.Drawing.Size(123, 22)
        Me.m_tmiOpen.Text = "&Open..."
        '
        'm_tmiNew
        '
        Me.m_tmiNew.Name = "m_tmiNew"
        Me.m_tmiNew.Size = New System.Drawing.Size(123, 22)
        Me.m_tmiNew.Text = "&New"
        '
        'm_tmiFile
        '
        Me.m_tmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiNew, Me.m_tmiOpen, Me.m_tmiSaveAs})
        Me.m_tmiFile.Name = "m_tmiFile"
        Me.m_tmiFile.Size = New System.Drawing.Size(37, 20)
        Me.m_tmiFile.Text = "&File"
        '
        'm_msMenu
        '
        Me.m_tlpMainPanel.SetColumnSpan(Me.m_msMenu, 2)
        Me.m_msMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.m_msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiFile, Me.m_tmiInsert})
        Me.m_msMenu.Location = New System.Drawing.Point(0, 0)
        Me.m_msMenu.Name = "m_msMenu"
        Me.m_msMenu.Size = New System.Drawing.Size(1032, 24)
        Me.m_msMenu.TabIndex = 0
        Me.m_msMenu.Text = "menuStrip1"
        '
        'm_tmiInsert
        '
        Me.m_tmiInsert.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiChart})
        Me.m_tmiInsert.Name = "m_tmiInsert"
        Me.m_tmiInsert.Size = New System.Drawing.Size(48, 20)
        Me.m_tmiInsert.Text = "&Insert"
        '
        'm_tlpMainPanel
        '
        Me.m_tlpMainPanel.ColumnCount = 2
        Me.m_tlpMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.m_tlpMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.m_tlpMainPanel.Controls.Add(Me.m_msMenu, 0, 0)
        Me.m_tlpMainPanel.Controls.Add(Me.m_pnlTextControlPanel, 0, 1)
        Me.m_tlpMainPanel.Controls.Add(Me.m_tlpChartPanel, 1, 1)
        Me.m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_tlpMainPanel.Location = New System.Drawing.Point(0, 0)
        Me.m_tlpMainPanel.Name = "m_tlpMainPanel"
        Me.m_tlpMainPanel.RowCount = 2
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.m_tlpMainPanel.Size = New System.Drawing.Size(1032, 469)
        Me.m_tlpMainPanel.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 469)
        Me.Controls.Add(Me.m_tlpMainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Howto: Add charting support to your applications - Creating a template that conta" &
    "ins chart objects"
        Me.m_tlpChartPanel.ResumeLayout(False)
        Me.m_tlpChartPanel.PerformLayout()
        Me.m_pnlTextControlPanel.ResumeLayout(False)
        Me.m_msMenu.ResumeLayout(False)
        Me.m_msMenu.PerformLayout()
        Me.m_tlpMainPanel.ResumeLayout(False)
        Me.m_tlpMainPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents m_lblChartName As Label
    Private WithEvents m_tbxChartName As TextBox
    Private WithEvents m_pgChartProperties As PropertyGrid
    Private WithEvents m_tlpChartPanel As TableLayoutPanel
    Private WithEvents m_btnApplyChartName As Button
    Private WithEvents m_pnlTextControlPanel As Panel
    Private WithEvents m_tmiChart As ToolStripMenuItem
    Private WithEvents m_tmiSaveAs As ToolStripMenuItem
    Private WithEvents m_tmiOpen As ToolStripMenuItem
    Private WithEvents m_tmiNew As ToolStripMenuItem
    Private WithEvents m_tmiFile As ToolStripMenuItem
    Private WithEvents m_msMenu As MenuStrip
    Private WithEvents m_tlpMainPanel As TableLayoutPanel
    Private WithEvents m_tmiInsert As ToolStripMenuItem
    Friend WithEvents m_txTextControl As TXTextControl.TextControl
    Friend WithEvents m_bbButtonBar As TXTextControl.ButtonBar
    Friend WithEvents m_rbHorizontalRuler As TXTextControl.RulerBar
    Friend WithEvents StatusBar1 As TXTextControl.StatusBar
    Friend WithEvents m_rbVerticalRuler As TXTextControl.RulerBar
End Class
