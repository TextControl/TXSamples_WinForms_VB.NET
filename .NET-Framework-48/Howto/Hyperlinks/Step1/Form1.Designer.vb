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
        Me.m_tlpMainPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.m_btnInsertHyperlink = New System.Windows.Forms.Button()
        Me.m_btnSaveAs = New System.Windows.Forms.Button()
        Me.m_txTextControl = New TXTextControl.TextControl()
        Me.m_tlpMainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'm_tlpMainPanel
        '
        Me.m_tlpMainPanel.ColumnCount = 3
        Me.m_tlpMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.m_tlpMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.m_tlpMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.m_tlpMainPanel.Controls.Add(Me.m_btnInsertHyperlink, 0, 1)
        Me.m_tlpMainPanel.Controls.Add(Me.m_btnSaveAs, 1, 1)
        Me.m_tlpMainPanel.Controls.Add(Me.m_txTextControl, 0, 0)
        Me.m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_tlpMainPanel.Location = New System.Drawing.Point(11, 11)
        Me.m_tlpMainPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.m_tlpMainPanel.Name = "m_tlpMainPanel"
        Me.m_tlpMainPanel.RowCount = 2
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.m_tlpMainPanel.Size = New System.Drawing.Size(778, 428)
        Me.m_tlpMainPanel.TabIndex = 1
        '
        'm_btnInsertHyperlink
        '
        Me.m_btnInsertHyperlink.AutoSize = True
        Me.m_btnInsertHyperlink.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.m_btnInsertHyperlink.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_btnInsertHyperlink.Location = New System.Drawing.Point(0, 405)
        Me.m_btnInsertHyperlink.Margin = New System.Windows.Forms.Padding(0)
        Me.m_btnInsertHyperlink.MinimumSize = New System.Drawing.Size(75, 23)
        Me.m_btnInsertHyperlink.Name = "m_btnInsertHyperlink"
        Me.m_btnInsertHyperlink.Size = New System.Drawing.Size(114, 23)
        Me.m_btnInsertHyperlink.TabIndex = 0
        Me.m_btnInsertHyperlink.Text = "Insert &Hypertext Link"
        Me.m_btnInsertHyperlink.UseVisualStyleBackColor = True
        '
        'm_btnSaveAs
        '
        Me.m_btnSaveAs.AutoSize = True
        Me.m_btnSaveAs.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_btnSaveAs.Location = New System.Drawing.Point(125, 405)
        Me.m_btnSaveAs.Margin = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.m_btnSaveAs.MinimumSize = New System.Drawing.Size(75, 23)
        Me.m_btnSaveAs.Name = "m_btnSaveAs"
        Me.m_btnSaveAs.Size = New System.Drawing.Size(108, 23)
        Me.m_btnSaveAs.TabIndex = 1
        Me.m_btnSaveAs.Text = "&Save as HTML File"
        Me.m_btnSaveAs.UseVisualStyleBackColor = True
        '
        'm_txTextControl
        '
        Me.m_tlpMainPanel.SetColumnSpan(Me.m_txTextControl, 3)
        Me.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_txTextControl.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.m_txTextControl.FormattingPrinter = "Standard"
        Me.m_txTextControl.Location = New System.Drawing.Point(0, 0)
        Me.m_txTextControl.Margin = New System.Windows.Forms.Padding(0, 0, 0, 15)
        Me.m_txTextControl.Name = "m_txTextControl"
        Me.m_txTextControl.Size = New System.Drawing.Size(778, 390)
        Me.m_txTextControl.TabIndex = 2
        Me.m_txTextControl.UserNames = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.m_tlpMainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(11)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Howto: Use Hypertext Links - Step 1: Inserting a Hypertext Link"
        Me.m_tlpMainPanel.ResumeLayout(False)
        Me.m_tlpMainPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents m_tlpMainPanel As TableLayoutPanel
    Private WithEvents m_btnInsertHyperlink As Button
    Private WithEvents m_btnSaveAs As Button
    Friend WithEvents m_txTextControl As TXTextControl.TextControl
End Class
