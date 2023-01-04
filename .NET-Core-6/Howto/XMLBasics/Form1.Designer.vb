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
        Me.m_tmiLoadAddressXML = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiLoadAddressListXML = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_tmiLoadAddressInvalidXML = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_txTextControl = New TXTextControl.TextControl()
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
        Me.m_msMenu.TabIndex = 2
        Me.m_msMenu.Text = "menuStrip1"
        '
        'm_tmiFile
        '
        Me.m_tmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiOpen, Me.m_tmiLoadAddressXML, Me.m_tmiLoadAddressListXML, Me.m_tmiLoadAddressInvalidXML})
        Me.m_tmiFile.Name = "m_tmiFile"
        Me.m_tmiFile.Size = New System.Drawing.Size(37, 20)
        Me.m_tmiFile.Text = "&File"
        '
        'm_tmiOpen
        '
        Me.m_tmiOpen.Name = "m_tmiOpen"
        Me.m_tmiOpen.Size = New System.Drawing.Size(212, 22)
        Me.m_tmiOpen.Text = "&Open..."
        '
        'm_tmiLoadAddressXML
        '
        Me.m_tmiLoadAddressXML.Name = "m_tmiLoadAddressXML"
        Me.m_tmiLoadAddressXML.Size = New System.Drawing.Size(212, 22)
        Me.m_tmiLoadAddressXML.Text = "Load '&address.xml'"
        '
        'm_tmiLoadAddressListXML
        '
        Me.m_tmiLoadAddressListXML.Name = "m_tmiLoadAddressListXML"
        Me.m_tmiLoadAddressListXML.Size = New System.Drawing.Size(212, 22)
        Me.m_tmiLoadAddressListXML.Text = "&Load 'address_list.xml'"
        '
        'm_tmiLoadAddressInvalidXML
        '
        Me.m_tmiLoadAddressInvalidXML.Name = "m_tmiLoadAddressInvalidXML"
        Me.m_tmiLoadAddressInvalidXML.Size = New System.Drawing.Size(212, 22)
        Me.m_tmiLoadAddressInvalidXML.Text = "Load 'address_in&valid.xml'"
        '
        'm_txTextControl
        '
        Me.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_txTextControl.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.m_txTextControl.FormattingPrinter = "Standard"
        Me.m_txTextControl.Location = New System.Drawing.Point(0, 24)
        Me.m_txTextControl.Name = "m_txTextControl"
        Me.m_txTextControl.Size = New System.Drawing.Size(800, 426)
        Me.m_txTextControl.TabIndex = 3
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
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Howto: Use XML Files - The Sample Program"
        Me.m_msMenu.ResumeLayout(False)
        Me.m_msMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents m_msMenu As MenuStrip
    Private WithEvents m_tmiFile As ToolStripMenuItem
    Private WithEvents m_tmiOpen As ToolStripMenuItem
    Private WithEvents m_tmiLoadAddressXML As ToolStripMenuItem
    Private WithEvents m_tmiLoadAddressListXML As ToolStripMenuItem
    Private WithEvents m_tmiLoadAddressInvalidXML As ToolStripMenuItem
    Friend WithEvents m_txTextControl As TXTextControl.TextControl
End Class
