<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomHyperlinkDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomHyperlinkDialog))
        Me.m_tlpMainPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.m_tbxLink = New System.Windows.Forms.TextBox()
        Me.m_lblLink = New System.Windows.Forms.Label()
        Me.m_btnCancel = New System.Windows.Forms.Button()
        Me.m_lblHyperlinkText = New System.Windows.Forms.Label()
        Me.m_tbxHyperlinkText = New System.Windows.Forms.TextBox()
        Me.m_btnOK = New System.Windows.Forms.Button()
        Me.m_tlpMainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'm_tlpMainPanel
        '
        Me.m_tlpMainPanel.AutoSize = True
        Me.m_tlpMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.m_tlpMainPanel.ColumnCount = 3
        Me.m_tlpMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.m_tlpMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.m_tlpMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.m_tlpMainPanel.Controls.Add(Me.m_tbxLink, 0, 3)
        Me.m_tlpMainPanel.Controls.Add(Me.m_lblLink, 0, 2)
        Me.m_tlpMainPanel.Controls.Add(Me.m_btnCancel, 2, 4)
        Me.m_tlpMainPanel.Controls.Add(Me.m_lblHyperlinkText, 0, 0)
        Me.m_tlpMainPanel.Controls.Add(Me.m_tbxHyperlinkText, 0, 1)
        Me.m_tlpMainPanel.Controls.Add(Me.m_btnOK, 1, 4)
        Me.m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_tlpMainPanel.Location = New System.Drawing.Point(8, 11)
        Me.m_tlpMainPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.m_tlpMainPanel.Name = "m_tlpMainPanel"
        Me.m_tlpMainPanel.RowCount = 5
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.Size = New System.Drawing.Size(241, 123)
        Me.m_tlpMainPanel.TabIndex = 1
        '
        'm_tbxLink
        '
        Me.m_tlpMainPanel.SetColumnSpan(Me.m_tbxLink, 3)
        Me.m_tbxLink.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_tbxLink.Location = New System.Drawing.Point(3, 73)
        Me.m_tbxLink.Margin = New System.Windows.Forms.Padding(3, 0, 0, 15)
        Me.m_tbxLink.MinimumSize = New System.Drawing.Size(250, 4)
        Me.m_tbxLink.Name = "m_tbxLink"
        Me.m_tbxLink.Size = New System.Drawing.Size(250, 20)
        Me.m_tbxLink.TabIndex = 4
        '
        'm_lblLink
        '
        Me.m_lblLink.AutoSize = True
        Me.m_tlpMainPanel.SetColumnSpan(Me.m_lblLink, 3)
        Me.m_lblLink.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_lblLink.Location = New System.Drawing.Point(0, 52)
        Me.m_lblLink.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.m_lblLink.Name = "m_lblLink"
        Me.m_lblLink.Size = New System.Drawing.Size(241, 13)
        Me.m_lblLink.TabIndex = 3
        Me.m_lblLink.Text = "&Link:"
        '
        'm_btnCancel
        '
        Me.m_btnCancel.AutoSize = True
        Me.m_btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.m_btnCancel.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_btnCancel.Location = New System.Drawing.Point(166, 108)
        Me.m_btnCancel.Margin = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.m_btnCancel.MinimumSize = New System.Drawing.Size(75, 23)
        Me.m_btnCancel.Name = "m_btnCancel"
        Me.m_btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.m_btnCancel.TabIndex = 6
        Me.m_btnCancel.Text = "Cancel"
        Me.m_btnCancel.UseVisualStyleBackColor = True
        '
        'm_lblHyperlinkText
        '
        Me.m_lblHyperlinkText.AutoSize = True
        Me.m_tlpMainPanel.SetColumnSpan(Me.m_lblHyperlinkText, 3)
        Me.m_lblHyperlinkText.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_lblHyperlinkText.Location = New System.Drawing.Point(0, 0)
        Me.m_lblHyperlinkText.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.m_lblHyperlinkText.Name = "m_lblHyperlinkText"
        Me.m_lblHyperlinkText.Size = New System.Drawing.Size(241, 13)
        Me.m_lblHyperlinkText.TabIndex = 1
        Me.m_lblHyperlinkText.Text = "&Hyperlink Text:"
        '
        'm_tbxHyperlinkText
        '
        Me.m_tlpMainPanel.SetColumnSpan(Me.m_tbxHyperlinkText, 3)
        Me.m_tbxHyperlinkText.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_tbxHyperlinkText.Location = New System.Drawing.Point(3, 21)
        Me.m_tbxHyperlinkText.Margin = New System.Windows.Forms.Padding(3, 0, 0, 11)
        Me.m_tbxHyperlinkText.MinimumSize = New System.Drawing.Size(250, 4)
        Me.m_tbxHyperlinkText.Name = "m_tbxHyperlinkText"
        Me.m_tbxHyperlinkText.Size = New System.Drawing.Size(250, 20)
        Me.m_tbxHyperlinkText.TabIndex = 2
        '
        'm_btnOK
        '
        Me.m_btnOK.AutoSize = True
        Me.m_btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.m_btnOK.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_btnOK.Enabled = False
        Me.m_btnOK.Location = New System.Drawing.Point(80, 108)
        Me.m_btnOK.Margin = New System.Windows.Forms.Padding(0)
        Me.m_btnOK.MinimumSize = New System.Drawing.Size(75, 23)
        Me.m_btnOK.Name = "m_btnOK"
        Me.m_btnOK.Size = New System.Drawing.Size(75, 23)
        Me.m_btnOK.TabIndex = 5
        Me.m_btnOK.Text = "OK"
        Me.m_btnOK.UseVisualStyleBackColor = True
        '
        'CustomHyperlinkDialog
        '
        Me.AcceptButton = Me.m_btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.m_btnCancel
        Me.ClientSize = New System.Drawing.Size(260, 145)
        Me.Controls.Add(Me.m_tlpMainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomHyperlinkDialog"
        Me.Padding = New System.Windows.Forms.Padding(8, 11, 11, 11)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.m_tlpMainPanel.ResumeLayout(False)
        Me.m_tlpMainPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents m_tlpMainPanel As TableLayoutPanel
    Private WithEvents m_tbxLink As TextBox
    Private WithEvents m_lblLink As Label
    Private WithEvents m_btnCancel As Button
    Private WithEvents m_lblHyperlinkText As Label
    Private WithEvents m_tbxHyperlinkText As TextBox
    Private WithEvents m_btnOK As Button
End Class
