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
        Me.m_tmiOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiSample = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_txTextControl = New TXTextControl.TextControl()
        Me.ButtonBar1 = New TXTextControl.ButtonBar()
        Me.m_msMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'm_msMenu
        '
        Me.m_msMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.m_msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiFile})
        Me.m_msMenu.Location = New System.Drawing.Point(0, 0)
        Me.m_msMenu.Name = "m_msMenu"
        Me.m_msMenu.Size = New System.Drawing.Size(800, 24)
        Me.m_msMenu.TabIndex = 1
        Me.m_msMenu.Text = "menuStrip1"
        '
        'm_tmiFile
        '
        Me.m_tmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiOpen, Me.m_tmiSample})
        Me.m_tmiFile.Name = "m_tmiFile"
        Me.m_tmiFile.Size = New System.Drawing.Size(37, 20)
        Me.m_tmiFile.Text = "&File"
        '
        'm_tmiOpen
        '
        Me.m_tmiOpen.Name = "m_tmiOpen"
        Me.m_tmiOpen.Size = New System.Drawing.Size(192, 22)
        Me.m_tmiOpen.Text = "&Open..."
        '
        'm_tmiSample
        '
        Me.m_tmiSample.Name = "m_tmiSample"
        Me.m_tmiSample.Size = New System.Drawing.Size(192, 22)
        Me.m_tmiSample.Text = "&Load 'address_list.xml'"
        '
        'm_txTextControl
        '
        Me.m_txTextControl.ButtonBar = Me.ButtonBar1
        Me.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_txTextControl.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.m_txTextControl.FormattingPrinter = "Standard"
        Me.m_txTextControl.Location = New System.Drawing.Point(0, 53)
        Me.m_txTextControl.Name = "m_txTextControl"
        Me.m_txTextControl.Size = New System.Drawing.Size(800, 397)
        Me.m_txTextControl.TabIndex = 2
        Me.m_txTextControl.UserNames = Nothing
        '
        'ButtonBar1
        '
        Me.ButtonBar1.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonBar1.ButtonOffsets = New Integer() {10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Me.ButtonBar1.ButtonPositions = New TXTextControl.Button() {TXTextControl.Button.StyleComboBox, TXTextControl.Button.XMLAddElementComboBox, TXTextControl.Button.XMLRemoveElementComboBox, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None}
        Me.ButtonBar1.ButtonSeparators = New Boolean() {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False}
        Me.ButtonBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonBar1.Location = New System.Drawing.Point(0, 24)
        Me.ButtonBar1.Name = "ButtonBar1"
        Me.ButtonBar1.Size = New System.Drawing.Size(800, 29)
        Me.ButtonBar1.TabIndex = 3
        Me.ButtonBar1.Text = "ButtonBar1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.m_txTextControl)
        Me.Controls.Add(Me.ButtonBar1)
        Me.Controls.Add(Me.m_msMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Howto: Use XML Files -  XMLEditing"
        Me.m_msMenu.ResumeLayout(False)
        Me.m_msMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents m_msMenu As MenuStrip
    Private WithEvents m_tmiFile As ToolStripMenuItem
    Private WithEvents m_tmiOpen As ToolStripMenuItem
    Private WithEvents m_tmiSample As ToolStripMenuItem
    Friend WithEvents m_txTextControl As TXTextControl.TextControl
    Friend WithEvents ButtonBar1 As TXTextControl.ButtonBar
End Class
