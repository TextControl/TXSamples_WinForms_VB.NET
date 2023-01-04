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
        Me.m_txTextControl = New TXTextControl.TextControl()
        Me.SuspendLayout()
        '
        'm_txTextControl
        '
        Me.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_txTextControl.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.m_txTextControl.FormattingPrinter = "Standard"
        Me.m_txTextControl.Location = New System.Drawing.Point(0, 0)
        Me.m_txTextControl.Name = "m_txTextControl"
        Me.m_txTextControl.ShowMiniToolbar = CType((TXTextControl.MiniToolbarButton.LeftButton Or TXTextControl.MiniToolbarButton.RightButton), TXTextControl.MiniToolbarButton)
        Me.m_txTextControl.Size = New System.Drawing.Size(800, 450)
        Me.m_txTextControl.TabIndex = 0
        Me.m_txTextControl.UserNames = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.m_txTextControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Howto: Manipulate the MiniToolbar"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents m_txTextControl As TXTextControl.TextControl
End Class
