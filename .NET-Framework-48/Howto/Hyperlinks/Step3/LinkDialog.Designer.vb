<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinkDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LinkDialog))
        Me.m_tlpMainPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.m_tbxHyperlink = New System.Windows.Forms.TextBox()
        Me.m_lblLink = New System.Windows.Forms.Label()
        Me.m_btnCancel = New System.Windows.Forms.Button()
        Me.m_lblDisplayedText = New System.Windows.Forms.Label()
        Me.m_tbxDisplayedText = New System.Windows.Forms.TextBox()
        Me.m_btnOK = New System.Windows.Forms.Button()
        Me.m_tlpLinkType = New System.Windows.Forms.TableLayoutPanel()
        Me.m_rbtnTypeDocumentLink = New System.Windows.Forms.RadioButton()
        Me.m_lblLinkType = New System.Windows.Forms.Label()
        Me.m_rbtnTypeHyperlink = New System.Windows.Forms.RadioButton()
        Me.m_cmbxDocumentTargets = New System.Windows.Forms.ComboBox()
        Me.m_tlpMainPanel.SuspendLayout()
        Me.m_tlpLinkType.SuspendLayout()
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
        Me.m_tlpMainPanel.Controls.Add(Me.m_tbxHyperlink, 0, 4)
        Me.m_tlpMainPanel.Controls.Add(Me.m_lblLink, 0, 3)
        Me.m_tlpMainPanel.Controls.Add(Me.m_btnCancel, 2, 6)
        Me.m_tlpMainPanel.Controls.Add(Me.m_lblDisplayedText, 0, 1)
        Me.m_tlpMainPanel.Controls.Add(Me.m_tbxDisplayedText, 0, 2)
        Me.m_tlpMainPanel.Controls.Add(Me.m_btnOK, 1, 6)
        Me.m_tlpMainPanel.Controls.Add(Me.m_tlpLinkType, 0, 0)
        Me.m_tlpMainPanel.Controls.Add(Me.m_cmbxDocumentTargets, 0, 4)
        Me.m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_tlpMainPanel.Location = New System.Drawing.Point(8, 11)
        Me.m_tlpMainPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.m_tlpMainPanel.Name = "m_tlpMainPanel"
        Me.m_tlpMainPanel.RowCount = 7
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.Size = New System.Drawing.Size(312, 160)
        Me.m_tlpMainPanel.TabIndex = 2
        '
        'm_tbxHyperlink
        '
        Me.m_tlpMainPanel.SetColumnSpan(Me.m_tbxHyperlink, 3)
        Me.m_tbxHyperlink.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_tbxHyperlink.Location = New System.Drawing.Point(3, 137)
        Me.m_tbxHyperlink.Margin = New System.Windows.Forms.Padding(3, 0, 0, 15)
        Me.m_tbxHyperlink.MinimumSize = New System.Drawing.Size(250, 21)
        Me.m_tbxHyperlink.Name = "m_tbxHyperlink"
        Me.m_tbxHyperlink.Size = New System.Drawing.Size(309, 20)
        Me.m_tbxHyperlink.TabIndex = 7
        '
        'm_lblLink
        '
        Me.m_lblLink.AutoSize = True
        Me.m_lblLink.Dock = System.Windows.Forms.DockStyle.Left
        Me.m_lblLink.Location = New System.Drawing.Point(0, 80)
        Me.m_lblLink.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.m_lblLink.Name = "m_lblLink"
        Me.m_lblLink.Size = New System.Drawing.Size(30, 13)
        Me.m_lblLink.TabIndex = 6
        Me.m_lblLink.Text = "&Link:"
        Me.m_lblLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'm_btnCancel
        '
        Me.m_btnCancel.AutoSize = True
        Me.m_btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.m_btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.m_btnCancel.Location = New System.Drawing.Point(237, 172)
        Me.m_btnCancel.Margin = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.m_btnCancel.MinimumSize = New System.Drawing.Size(75, 23)
        Me.m_btnCancel.Name = "m_btnCancel"
        Me.m_btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.m_btnCancel.TabIndex = 10
        Me.m_btnCancel.Text = "Cancel"
        Me.m_btnCancel.UseVisualStyleBackColor = True
        '
        'm_lblDisplayedText
        '
        Me.m_lblDisplayedText.AutoSize = True
        Me.m_tlpMainPanel.SetColumnSpan(Me.m_lblDisplayedText, 3)
        Me.m_lblDisplayedText.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_lblDisplayedText.Location = New System.Drawing.Point(0, 28)
        Me.m_lblDisplayedText.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.m_lblDisplayedText.Name = "m_lblDisplayedText"
        Me.m_lblDisplayedText.Size = New System.Drawing.Size(312, 13)
        Me.m_lblDisplayedText.TabIndex = 4
        Me.m_lblDisplayedText.Text = "&Displayed Text:"
        '
        'm_tbxDisplayedText
        '
        Me.m_tlpMainPanel.SetColumnSpan(Me.m_tbxDisplayedText, 3)
        Me.m_tbxDisplayedText.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_tbxDisplayedText.Location = New System.Drawing.Point(3, 49)
        Me.m_tbxDisplayedText.Margin = New System.Windows.Forms.Padding(3, 0, 0, 11)
        Me.m_tbxDisplayedText.MinimumSize = New System.Drawing.Size(250, 4)
        Me.m_tbxDisplayedText.Name = "m_tbxDisplayedText"
        Me.m_tbxDisplayedText.Size = New System.Drawing.Size(309, 20)
        Me.m_tbxDisplayedText.TabIndex = 5
        '
        'm_btnOK
        '
        Me.m_btnOK.AutoSize = True
        Me.m_btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.m_btnOK.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.m_btnOK.Enabled = False
        Me.m_btnOK.Location = New System.Drawing.Point(151, 172)
        Me.m_btnOK.Margin = New System.Windows.Forms.Padding(0)
        Me.m_btnOK.MinimumSize = New System.Drawing.Size(75, 23)
        Me.m_btnOK.Name = "m_btnOK"
        Me.m_btnOK.Size = New System.Drawing.Size(75, 23)
        Me.m_btnOK.TabIndex = 9
        Me.m_btnOK.Text = "OK"
        Me.m_btnOK.UseVisualStyleBackColor = True
        '
        'm_tlpLinkType
        '
        Me.m_tlpLinkType.AutoSize = True
        Me.m_tlpLinkType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.m_tlpLinkType.ColumnCount = 3
        Me.m_tlpMainPanel.SetColumnSpan(Me.m_tlpLinkType, 3)
        Me.m_tlpLinkType.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.m_tlpLinkType.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.m_tlpLinkType.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.m_tlpLinkType.Controls.Add(Me.m_rbtnTypeDocumentLink, 2, 0)
        Me.m_tlpLinkType.Controls.Add(Me.m_lblLinkType, 0, 0)
        Me.m_tlpLinkType.Controls.Add(Me.m_rbtnTypeHyperlink, 1, 0)
        Me.m_tlpLinkType.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_tlpLinkType.Location = New System.Drawing.Point(0, 0)
        Me.m_tlpLinkType.Margin = New System.Windows.Forms.Padding(0, 0, 0, 11)
        Me.m_tlpLinkType.Name = "m_tlpLinkType"
        Me.m_tlpLinkType.RowCount = 1
        Me.m_tlpLinkType.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.m_tlpLinkType.Size = New System.Drawing.Size(312, 17)
        Me.m_tlpLinkType.TabIndex = 1
        '
        'm_rbtnTypeDocumentLink
        '
        Me.m_rbtnTypeDocumentLink.AutoSize = True
        Me.m_rbtnTypeDocumentLink.Location = New System.Drawing.Point(148, 0)
        Me.m_rbtnTypeDocumentLink.Margin = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.m_rbtnTypeDocumentLink.Name = "m_rbtnTypeDocumentLink"
        Me.m_rbtnTypeDocumentLink.Size = New System.Drawing.Size(97, 17)
        Me.m_rbtnTypeDocumentLink.TabIndex = 4
        Me.m_rbtnTypeDocumentLink.Text = "Document Link"
        Me.m_rbtnTypeDocumentLink.UseVisualStyleBackColor = True
        '
        'm_lblLinkType
        '
        Me.m_lblLinkType.AutoSize = True
        Me.m_lblLinkType.Dock = System.Windows.Forms.DockStyle.Left
        Me.m_lblLinkType.Location = New System.Drawing.Point(0, 0)
        Me.m_lblLinkType.Margin = New System.Windows.Forms.Padding(0)
        Me.m_lblLinkType.Name = "m_lblLinkType"
        Me.m_lblLinkType.Size = New System.Drawing.Size(57, 17)
        Me.m_lblLinkType.TabIndex = 2
        Me.m_lblLinkType.Text = "Link Type:"
        Me.m_lblLinkType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'm_rbtnTypeHyperlink
        '
        Me.m_rbtnTypeHyperlink.AutoSize = True
        Me.m_rbtnTypeHyperlink.Checked = True
        Me.m_rbtnTypeHyperlink.Location = New System.Drawing.Point(68, 0)
        Me.m_rbtnTypeHyperlink.Margin = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.m_rbtnTypeHyperlink.Name = "m_rbtnTypeHyperlink"
        Me.m_rbtnTypeHyperlink.Size = New System.Drawing.Size(69, 17)
        Me.m_rbtnTypeHyperlink.TabIndex = 3
        Me.m_rbtnTypeHyperlink.TabStop = True
        Me.m_rbtnTypeHyperlink.Text = "Hyperlink"
        Me.m_rbtnTypeHyperlink.UseVisualStyleBackColor = True
        '
        'm_cmbxDocumentTargets
        '
        Me.m_tlpMainPanel.SetColumnSpan(Me.m_cmbxDocumentTargets, 3)
        Me.m_cmbxDocumentTargets.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_cmbxDocumentTargets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.m_cmbxDocumentTargets.FormattingEnabled = True
        Me.m_cmbxDocumentTargets.Location = New System.Drawing.Point(3, 101)
        Me.m_cmbxDocumentTargets.Margin = New System.Windows.Forms.Padding(3, 0, 0, 15)
        Me.m_cmbxDocumentTargets.MinimumSize = New System.Drawing.Size(250, 0)
        Me.m_cmbxDocumentTargets.Name = "m_cmbxDocumentTargets"
        Me.m_cmbxDocumentTargets.Size = New System.Drawing.Size(309, 21)
        Me.m_cmbxDocumentTargets.TabIndex = 8
        Me.m_cmbxDocumentTargets.Visible = False
        '
        'LinkDialog
        '
        Me.AcceptButton = Me.m_btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.m_btnCancel
        Me.ClientSize = New System.Drawing.Size(331, 182)
        Me.Controls.Add(Me.m_tlpMainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LinkDialog"
        Me.Padding = New System.Windows.Forms.Padding(8, 11, 11, 11)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.m_tlpMainPanel.ResumeLayout(False)
        Me.m_tlpMainPanel.PerformLayout()
        Me.m_tlpLinkType.ResumeLayout(False)
        Me.m_tlpLinkType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents m_tlpMainPanel As TableLayoutPanel
    Private WithEvents m_tbxHyperlink As TextBox
    Private WithEvents m_lblLink As Label
    Private WithEvents m_btnCancel As Button
    Private WithEvents m_lblDisplayedText As Label
    Private WithEvents m_tbxDisplayedText As TextBox
    Private WithEvents m_btnOK As Button
    Private WithEvents m_tlpLinkType As TableLayoutPanel
    Private WithEvents m_rbtnTypeDocumentLink As RadioButton
    Private WithEvents m_lblLinkType As Label
    Private WithEvents m_rbtnTypeHyperlink As RadioButton
    Private WithEvents m_cmbxDocumentTargets As ComboBox
End Class
