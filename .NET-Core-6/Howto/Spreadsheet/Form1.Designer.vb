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
        Me.m_tsFormula = New System.Windows.Forms.ToolStrip()
        Me.m_cmbxFunctions = New System.Windows.Forms.ToolStripComboBox()
        Me.m_btnAddFunction = New System.Windows.Forms.ToolStripButton()
        Me.m_tbxFormula = New System.Windows.Forms.ToolStripTextBox()
        Me.m_btnAccept = New System.Windows.Forms.ToolStripButton()
        Me.m_btnRemove = New System.Windows.Forms.ToolStripButton()
        Me.m_sepSeparator02 = New System.Windows.Forms.ToolStripSeparator()
        Me.m_lblCellTextType = New System.Windows.Forms.ToolStripLabel()
        Me.m_btnTextFormat = New System.Windows.Forms.ToolStripButton()
        Me.m_btnNumberFormat = New System.Windows.Forms.ToolStripButton()
        Me.m_lblNumberFormat = New System.Windows.Forms.ToolStripLabel()
        Me.m_cmbxFormats = New System.Windows.Forms.ToolStripComboBox()
        Me.m_btnApplyNumberFormat = New System.Windows.Forms.ToolStripButton()
        Me.m_btnEnableCalculation = New System.Windows.Forms.ToolStripButton()
        Me.m_tsFormulaSettings = New System.Windows.Forms.ToolStrip()
        Me.m_lblReferenceStyle = New System.Windows.Forms.ToolStripLabel()
        Me.m_btnR1C1 = New System.Windows.Forms.ToolStripButton()
        Me.m_btnA1 = New System.Windows.Forms.ToolStripButton()
        Me.m_sepSeparator01 = New System.Windows.Forms.ToolStripSeparator()
        Me.m_ttInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.m_txTextControl = New TXTextControl.TextControl()
        Me.m_rbHorizontalRuler = New TXTextControl.RulerBar()
        Me.m_sbStatusBar = New TXTextControl.StatusBar()
        Me.m_rbVerticalRuler = New TXTextControl.RulerBar()
        Me.m_tsFormula.SuspendLayout()
        Me.m_tsFormulaSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'm_tsFormula
        '
        Me.m_tsFormula.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.m_tsFormula.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_cmbxFunctions, Me.m_btnAddFunction, Me.m_tbxFormula, Me.m_btnAccept, Me.m_btnRemove, Me.m_sepSeparator02, Me.m_lblCellTextType, Me.m_btnTextFormat, Me.m_btnNumberFormat, Me.m_lblNumberFormat, Me.m_cmbxFormats, Me.m_btnApplyNumberFormat})
        Me.m_tsFormula.Location = New System.Drawing.Point(0, 25)
        Me.m_tsFormula.Name = "m_tsFormula"
        Me.m_tsFormula.Size = New System.Drawing.Size(1034, 25)
        Me.m_tsFormula.TabIndex = 9
        Me.m_tsFormula.Text = "toolStrip1"
        '
        'm_cmbxFunctions
        '
        Me.m_cmbxFunctions.Name = "m_cmbxFunctions"
        Me.m_cmbxFunctions.Size = New System.Drawing.Size(121, 25)
        '
        'm_btnAddFunction
        '
        Me.m_btnAddFunction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.m_btnAddFunction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.m_btnAddFunction.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_btnAddFunction.Name = "m_btnAddFunction"
        Me.m_btnAddFunction.Size = New System.Drawing.Size(23, 22)
        Me.m_btnAddFunction.ToolTipText = "Add Function"
        '
        'm_tbxFormula
        '
        Me.m_tbxFormula.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.m_tbxFormula.Name = "m_tbxFormula"
        Me.m_tbxFormula.Size = New System.Drawing.Size(300, 25)
        '
        'm_btnAccept
        '
        Me.m_btnAccept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.m_btnAccept.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.m_btnAccept.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_btnAccept.Name = "m_btnAccept"
        Me.m_btnAccept.Size = New System.Drawing.Size(23, 22)
        Me.m_btnAccept.ToolTipText = "Accept Formula"
        '
        'm_btnRemove
        '
        Me.m_btnRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.m_btnRemove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.m_btnRemove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_btnRemove.Name = "m_btnRemove"
        Me.m_btnRemove.Size = New System.Drawing.Size(23, 22)
        Me.m_btnRemove.ToolTipText = "Remove Formula"
        '
        'm_sepSeparator02
        '
        Me.m_sepSeparator02.Name = "m_sepSeparator02"
        Me.m_sepSeparator02.Size = New System.Drawing.Size(6, 25)
        '
        'm_lblCellTextType
        '
        Me.m_lblCellTextType.Name = "m_lblCellTextType"
        Me.m_lblCellTextType.Size = New System.Drawing.Size(81, 22)
        Me.m_lblCellTextType.Text = "Cell Text Type:"
        '
        'm_btnTextFormat
        '
        Me.m_btnTextFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.m_btnTextFormat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.m_btnTextFormat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_btnTextFormat.Name = "m_btnTextFormat"
        Me.m_btnTextFormat.Size = New System.Drawing.Size(23, 22)
        Me.m_btnTextFormat.ToolTipText = "Text Format"
        '
        'm_btnNumberFormat
        '
        Me.m_btnNumberFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.m_btnNumberFormat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.m_btnNumberFormat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_btnNumberFormat.Name = "m_btnNumberFormat"
        Me.m_btnNumberFormat.Size = New System.Drawing.Size(23, 22)
        Me.m_btnNumberFormat.ToolTipText = "Number Format"
        '
        'm_lblNumberFormat
        '
        Me.m_lblNumberFormat.Name = "m_lblNumberFormat"
        Me.m_lblNumberFormat.Size = New System.Drawing.Size(95, 22)
        Me.m_lblNumberFormat.Text = "Number Format:"
        '
        'm_cmbxFormats
        '
        Me.m_cmbxFormats.Name = "m_cmbxFormats"
        Me.m_cmbxFormats.Size = New System.Drawing.Size(121, 25)
        '
        'm_btnApplyNumberFormat
        '
        Me.m_btnApplyNumberFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.m_btnApplyNumberFormat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.m_btnApplyNumberFormat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_btnApplyNumberFormat.Name = "m_btnApplyNumberFormat"
        Me.m_btnApplyNumberFormat.Size = New System.Drawing.Size(23, 22)
        Me.m_btnApplyNumberFormat.ToolTipText = "Apply Number Format"
        '
        'm_btnEnableCalculation
        '
        Me.m_btnEnableCalculation.CheckOnClick = True
        Me.m_btnEnableCalculation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.m_btnEnableCalculation.Name = "m_btnEnableCalculation"
        Me.m_btnEnableCalculation.Size = New System.Drawing.Size(109, 22)
        Me.m_btnEnableCalculation.Text = "Enable Calculation"
        '
        'm_tsFormulaSettings
        '
        Me.m_tsFormulaSettings.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.m_tsFormulaSettings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_lblReferenceStyle, Me.m_btnR1C1, Me.m_btnA1, Me.m_sepSeparator01, Me.m_btnEnableCalculation})
        Me.m_tsFormulaSettings.Location = New System.Drawing.Point(0, 0)
        Me.m_tsFormulaSettings.Name = "m_tsFormulaSettings"
        Me.m_tsFormulaSettings.Size = New System.Drawing.Size(1034, 25)
        Me.m_tsFormulaSettings.TabIndex = 10
        Me.m_tsFormulaSettings.Text = "toolStrip1"
        '
        'm_lblReferenceStyle
        '
        Me.m_lblReferenceStyle.Name = "m_lblReferenceStyle"
        Me.m_lblReferenceStyle.Size = New System.Drawing.Size(90, 22)
        Me.m_lblReferenceStyle.Text = "Reference Style:"
        '
        'm_btnR1C1
        '
        Me.m_btnR1C1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.m_btnR1C1.Name = "m_btnR1C1"
        Me.m_btnR1C1.Size = New System.Drawing.Size(38, 22)
        Me.m_btnR1C1.Text = "R1C1"
        '
        'm_btnA1
        '
        Me.m_btnA1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.m_btnA1.Name = "m_btnA1"
        Me.m_btnA1.Size = New System.Drawing.Size(25, 22)
        Me.m_btnA1.Text = "A1"
        '
        'm_sepSeparator01
        '
        Me.m_sepSeparator01.Name = "m_sepSeparator01"
        Me.m_sepSeparator01.Size = New System.Drawing.Size(6, 25)
        '
        'm_ttInfo
        '
        Me.m_ttInfo.IsBalloon = True
        Me.m_ttInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.m_ttInfo.ToolTipTitle = "Next Step"
        '
        'm_txTextControl
        '
        Me.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_txTextControl.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.m_txTextControl.FormattingPrinter = "Standard"
        Me.m_txTextControl.Location = New System.Drawing.Point(25, 50)
        Me.m_txTextControl.Name = "m_txTextControl"
        Me.m_txTextControl.RulerBar = Me.m_rbHorizontalRuler
        Me.m_txTextControl.Size = New System.Drawing.Size(1009, 439)
        Me.m_txTextControl.StatusBar = Me.m_sbStatusBar
        Me.m_txTextControl.TabIndex = 11
        Me.m_txTextControl.UserNames = Nothing
        Me.m_txTextControl.VerticalRulerBar = Me.m_rbVerticalRuler
        '
        'm_rbHorizontalRuler
        '
        Me.m_rbHorizontalRuler.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_rbHorizontalRuler.FormulaMode = TXTextControl.RulerBarFormulaMode.[Auto]
        Me.m_rbHorizontalRuler.Location = New System.Drawing.Point(25, 50)
        Me.m_rbHorizontalRuler.Name = "m_rbHorizontalRuler"
        Me.m_rbHorizontalRuler.Size = New System.Drawing.Size(1009, 25)
        Me.m_rbHorizontalRuler.TabIndex = 13
        Me.m_rbHorizontalRuler.Text = "RulerBar2"
        '
        'm_sbStatusBar
        '
        Me.m_sbStatusBar.BackColor = System.Drawing.SystemColors.Control
        Me.m_sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.m_sbStatusBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.m_sbStatusBar.Location = New System.Drawing.Point(0, 489)
        Me.m_sbStatusBar.Name = "m_sbStatusBar"
        Me.m_sbStatusBar.Size = New System.Drawing.Size(1034, 22)
        Me.m_sbStatusBar.TabIndex = 14
        '
        'm_rbVerticalRuler
        '
        Me.m_rbVerticalRuler.Alignment = TXTextControl.RulerBarAlignment.Left
        Me.m_rbVerticalRuler.Dock = System.Windows.Forms.DockStyle.Left
        Me.m_rbVerticalRuler.FormulaMode = TXTextControl.RulerBarFormulaMode.[Auto]
        Me.m_rbVerticalRuler.Location = New System.Drawing.Point(0, 50)
        Me.m_rbVerticalRuler.Name = "m_rbVerticalRuler"
        Me.m_rbVerticalRuler.Size = New System.Drawing.Size(25, 439)
        Me.m_rbVerticalRuler.TabIndex = 12
        Me.m_rbVerticalRuler.Text = "RulerBar1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 511)
        Me.Controls.Add(Me.m_rbHorizontalRuler)
        Me.Controls.Add(Me.m_txTextControl)
        Me.Controls.Add(Me.m_rbVerticalRuler)
        Me.Controls.Add(Me.m_tsFormula)
        Me.Controls.Add(Me.m_tsFormulaSettings)
        Me.Controls.Add(Me.m_sbStatusBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Howto: Use Spreadsheet Formulas in Tables"
        Me.m_tsFormula.ResumeLayout(False)
        Me.m_tsFormula.PerformLayout()
        Me.m_tsFormulaSettings.ResumeLayout(False)
        Me.m_tsFormulaSettings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents m_tsFormula As ToolStrip
    Private WithEvents m_cmbxFunctions As ToolStripComboBox
    Private WithEvents m_btnAddFunction As ToolStripButton
    Private WithEvents m_tbxFormula As ToolStripTextBox
    Private WithEvents m_btnAccept As ToolStripButton
    Private WithEvents m_btnRemove As ToolStripButton
    Private WithEvents m_sepSeparator02 As ToolStripSeparator
    Private WithEvents m_lblCellTextType As ToolStripLabel
    Private WithEvents m_btnTextFormat As ToolStripButton
    Private WithEvents m_btnNumberFormat As ToolStripButton
    Private WithEvents m_lblNumberFormat As ToolStripLabel
    Private WithEvents m_cmbxFormats As ToolStripComboBox
    Private WithEvents m_btnApplyNumberFormat As ToolStripButton
    Private WithEvents m_btnEnableCalculation As ToolStripButton
    Private WithEvents m_tsFormulaSettings As ToolStrip
    Private WithEvents m_lblReferenceStyle As ToolStripLabel
    Private WithEvents m_btnR1C1 As ToolStripButton
    Private WithEvents m_btnA1 As ToolStripButton
    Private WithEvents m_sepSeparator01 As ToolStripSeparator
    Private WithEvents m_ttInfo As ToolTip
    Friend WithEvents m_txTextControl As TXTextControl.TextControl
    Friend WithEvents m_rbHorizontalRuler As TXTextControl.RulerBar
    Friend WithEvents m_sbStatusBar As TXTextControl.StatusBar
    Friend WithEvents m_rbVerticalRuler As TXTextControl.RulerBar
End Class
