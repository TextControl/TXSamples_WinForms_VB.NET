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
        Me.TextControl1 = New TXTextControl.TextControl()
        Me.Ribbon1 = New TXTextControl.Windows.Forms.Ribbon.Ribbon()
        Me.RibbonFormattingTab1 = New TXTextControl.Windows.Forms.Ribbon.RibbonFormattingTab()
        Me.RibbonInsertTab1 = New TXTextControl.Windows.Forms.Ribbon.RibbonInsertTab()
        Me.RibbonPageLayoutTab1 = New TXTextControl.Windows.Forms.Ribbon.RibbonPageLayoutTab()
        Me.RibbonViewTab1 = New TXTextControl.Windows.Forms.Ribbon.RibbonViewTab()
        Me.RibbonProofingTab1 = New TXTextControl.Windows.Forms.Ribbon.RibbonProofingTab()
        Me.RulerBar2 = New TXTextControl.RulerBar()
        Me.StatusBar1 = New TXTextControl.StatusBar()
        Me.RulerBar1 = New TXTextControl.RulerBar()
        Me.Ribbon1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextControl1
        '
        Me.TextControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextControl1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TextControl1.FormattingPrinter = "Standard"
        Me.TextControl1.Location = New System.Drawing.Point(25, 143)
        Me.TextControl1.Name = "TextControl1"
        Me.TextControl1.Ribbon = Me.Ribbon1
        Me.TextControl1.RulerBar = Me.RulerBar2
        Me.TextControl1.Size = New System.Drawing.Size(775, 285)
        Me.TextControl1.StatusBar = Me.StatusBar1
        Me.TextControl1.TabIndex = 0
        Me.TextControl1.Text = "TextControl1"
        Me.TextControl1.UserNames = Nothing
        Me.TextControl1.VerticalRulerBar = Me.RulerBar1
        '
        'Ribbon1
        '
        Me.Ribbon1.Controls.Add(Me.RibbonFormattingTab1)
        Me.Ribbon1.Controls.Add(Me.RibbonInsertTab1)
        Me.Ribbon1.Controls.Add(Me.RibbonPageLayoutTab1)
        Me.Ribbon1.Controls.Add(Me.RibbonViewTab1)
        Me.Ribbon1.Controls.Add(Me.RibbonProofingTab1)
        Me.Ribbon1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Ribbon1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Ribbon1.HotTrack = True
        Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.Name = "Ribbon1"
        Me.Ribbon1.SelectedIndex = 1
        Me.Ribbon1.Size = New System.Drawing.Size(800, 118)
        Me.Ribbon1.TabIndex = 1
        Me.Ribbon1.Text = "Ribbon1"
        '
        'RibbonFormattingTab1
        '
        Me.RibbonFormattingTab1.Location = New System.Drawing.Point(4, 24)
        Me.RibbonFormattingTab1.Name = "RibbonFormattingTab1"
        Me.RibbonFormattingTab1.Size = New System.Drawing.Size(792, 90)
        Me.RibbonFormattingTab1.TabIndex = 1
        '
        'RibbonInsertTab1
        '
        Me.RibbonInsertTab1.Location = New System.Drawing.Point(4, 24)
        Me.RibbonInsertTab1.Name = "RibbonInsertTab1"
        Me.RibbonInsertTab1.Size = New System.Drawing.Size(792, 90)
        Me.RibbonInsertTab1.TabIndex = 2
        '
        'RibbonPageLayoutTab1
        '
        Me.RibbonPageLayoutTab1.Location = New System.Drawing.Point(4, 24)
        Me.RibbonPageLayoutTab1.Name = "RibbonPageLayoutTab1"
        Me.RibbonPageLayoutTab1.Size = New System.Drawing.Size(792, 90)
        Me.RibbonPageLayoutTab1.TabIndex = 3
        '
        'RibbonViewTab1
        '
        Me.RibbonViewTab1.Location = New System.Drawing.Point(4, 24)
        Me.RibbonViewTab1.Name = "RibbonViewTab1"
        Me.RibbonViewTab1.Size = New System.Drawing.Size(792, 90)
        Me.RibbonViewTab1.TabIndex = 4
        '
        'RibbonProofingTab1
        '
        Me.RibbonProofingTab1.Location = New System.Drawing.Point(4, 24)
        Me.RibbonProofingTab1.Name = "RibbonProofingTab1"
        Me.RibbonProofingTab1.Size = New System.Drawing.Size(792, 90)
        Me.RibbonProofingTab1.TabIndex = 5
        '
        'RulerBar2
        '
        Me.RulerBar2.Dock = System.Windows.Forms.DockStyle.Top
        Me.RulerBar2.Location = New System.Drawing.Point(0, 118)
        Me.RulerBar2.Name = "RulerBar2"
        Me.RulerBar2.Size = New System.Drawing.Size(800, 25)
        Me.RulerBar2.TabIndex = 4
        Me.RulerBar2.Text = "RulerBar2"
        '
        'StatusBar1
        '
        Me.StatusBar1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusBar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StatusBar1.Location = New System.Drawing.Point(0, 428)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(800, 22)
        Me.StatusBar1.TabIndex = 2
        '
        'RulerBar1
        '
        Me.RulerBar1.Alignment = TXTextControl.RulerBarAlignment.Left
        Me.RulerBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.RulerBar1.Location = New System.Drawing.Point(0, 143)
        Me.RulerBar1.Name = "RulerBar1"
        Me.RulerBar1.Size = New System.Drawing.Size(25, 285)
        Me.RulerBar1.TabIndex = 3
        Me.RulerBar1.Text = "RulerBar1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextControl1)
        Me.Controls.Add(Me.RulerBar1)
        Me.Controls.Add(Me.RulerBar2)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.Ribbon1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tutorial: Getting Started with Windows Forms (.NET Framework)"
        Me.Ribbon1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextControl1 As TXTextControl.TextControl
    Friend WithEvents Ribbon1 As TXTextControl.Windows.Forms.Ribbon.Ribbon
    Friend WithEvents RibbonFormattingTab1 As TXTextControl.Windows.Forms.Ribbon.RibbonFormattingTab
    Friend WithEvents RibbonInsertTab1 As TXTextControl.Windows.Forms.Ribbon.RibbonInsertTab
    Friend WithEvents RibbonPageLayoutTab1 As TXTextControl.Windows.Forms.Ribbon.RibbonPageLayoutTab
    Friend WithEvents RibbonViewTab1 As TXTextControl.Windows.Forms.Ribbon.RibbonViewTab
    Friend WithEvents RibbonProofingTab1 As TXTextControl.Windows.Forms.Ribbon.RibbonProofingTab
    Friend WithEvents RulerBar2 As TXTextControl.RulerBar
    Friend WithEvents StatusBar1 As TXTextControl.StatusBar
    Friend WithEvents RulerBar1 As TXTextControl.RulerBar
End Class
