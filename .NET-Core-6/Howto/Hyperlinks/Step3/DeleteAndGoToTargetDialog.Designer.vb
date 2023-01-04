<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteAndGoToTargetDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteAndGoToTargetDialog))
        Me.m_tlpMainPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.m_btnCancel = New System.Windows.Forms.Button()
        Me.m_btnOK = New System.Windows.Forms.Button()
        Me.m_lblCurrentDocumentTargets = New System.Windows.Forms.Label()
        Me.m_tlpContentPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.m_lbxDocumentTargets = New System.Windows.Forms.ListBox()
        Me.m_btnGoTo = New System.Windows.Forms.Button()
        Me.m_btnDelete = New System.Windows.Forms.Button()
        Me.m_tlpMainPanel.SuspendLayout()
        Me.m_tlpContentPanel.SuspendLayout()
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
        Me.m_tlpMainPanel.Controls.Add(Me.m_btnCancel, 2, 2)
        Me.m_tlpMainPanel.Controls.Add(Me.m_btnOK, 1, 2)
        Me.m_tlpMainPanel.Controls.Add(Me.m_lblCurrentDocumentTargets, 0, 0)
        Me.m_tlpMainPanel.Controls.Add(Me.m_tlpContentPanel, 0, 1)
        Me.m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_tlpMainPanel.Location = New System.Drawing.Point(8, 11)
        Me.m_tlpMainPanel.Name = "m_tlpMainPanel"
        Me.m_tlpMainPanel.RowCount = 3
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.m_tlpMainPanel.Size = New System.Drawing.Size(284, 175)
        Me.m_tlpMainPanel.TabIndex = 1
        '
        'm_btnCancel
        '
        Me.m_btnCancel.AutoSize = True
        Me.m_btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.m_btnCancel.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_btnCancel.Location = New System.Drawing.Point(209, 152)
        Me.m_btnCancel.Margin = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.m_btnCancel.MinimumSize = New System.Drawing.Size(75, 23)
        Me.m_btnCancel.Name = "m_btnCancel"
        Me.m_btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.m_btnCancel.TabIndex = 7
        Me.m_btnCancel.Text = "Cancel"
        Me.m_btnCancel.UseVisualStyleBackColor = True
        '
        'm_btnOK
        '
        Me.m_btnOK.AutoSize = True
        Me.m_btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.m_btnOK.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_btnOK.Location = New System.Drawing.Point(123, 152)
        Me.m_btnOK.Margin = New System.Windows.Forms.Padding(0)
        Me.m_btnOK.MinimumSize = New System.Drawing.Size(75, 23)
        Me.m_btnOK.Name = "m_btnOK"
        Me.m_btnOK.Size = New System.Drawing.Size(75, 23)
        Me.m_btnOK.TabIndex = 6
        Me.m_btnOK.Text = "OK"
        Me.m_btnOK.UseVisualStyleBackColor = True
        '
        'm_lblCurrentDocumentTargets
        '
        Me.m_lblCurrentDocumentTargets.AutoSize = True
        Me.m_tlpMainPanel.SetColumnSpan(Me.m_lblCurrentDocumentTargets, 3)
        Me.m_lblCurrentDocumentTargets.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_lblCurrentDocumentTargets.Location = New System.Drawing.Point(0, 0)
        Me.m_lblCurrentDocumentTargets.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.m_lblCurrentDocumentTargets.Name = "m_lblCurrentDocumentTargets"
        Me.m_lblCurrentDocumentTargets.Size = New System.Drawing.Size(284, 13)
        Me.m_lblCurrentDocumentTargets.TabIndex = 1
        Me.m_lblCurrentDocumentTargets.Text = "Document &Targets:"
        '
        'm_tlpContentPanel
        '
        Me.m_tlpContentPanel.AutoSize = True
        Me.m_tlpContentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.m_tlpContentPanel.ColumnCount = 2
        Me.m_tlpMainPanel.SetColumnSpan(Me.m_tlpContentPanel, 3)
        Me.m_tlpContentPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.m_tlpContentPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.m_tlpContentPanel.Controls.Add(Me.m_lbxDocumentTargets, 0, 0)
        Me.m_tlpContentPanel.Controls.Add(Me.m_btnGoTo, 1, 1)
        Me.m_tlpContentPanel.Controls.Add(Me.m_btnDelete, 1, 0)
        Me.m_tlpContentPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_tlpContentPanel.Location = New System.Drawing.Point(0, 21)
        Me.m_tlpContentPanel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 15)
        Me.m_tlpContentPanel.Name = "m_tlpContentPanel"
        Me.m_tlpContentPanel.RowCount = 3
        Me.m_tlpContentPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpContentPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpContentPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.m_tlpContentPanel.Size = New System.Drawing.Size(284, 116)
        Me.m_tlpContentPanel.TabIndex = 2
        '
        'm_lbxDocumentTargets
        '
        Me.m_lbxDocumentTargets.FormattingEnabled = True
        Me.m_lbxDocumentTargets.Location = New System.Drawing.Point(3, 0)
        Me.m_lbxDocumentTargets.Margin = New System.Windows.Forms.Padding(3, 0, 11, 0)
        Me.m_lbxDocumentTargets.MinimumSize = New System.Drawing.Size(220, 150)
        Me.m_lbxDocumentTargets.Name = "m_lbxDocumentTargets"
        Me.m_tlpContentPanel.SetRowSpan(Me.m_lbxDocumentTargets, 3)
        Me.m_lbxDocumentTargets.Size = New System.Drawing.Size(220, 147)
        Me.m_lbxDocumentTargets.TabIndex = 3
        '
        'm_btnGoTo
        '
        Me.m_btnGoTo.AutoSize = True
        Me.m_btnGoTo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.m_btnGoTo.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_btnGoTo.Enabled = False
        Me.m_btnGoTo.Location = New System.Drawing.Point(209, 31)
        Me.m_btnGoTo.Margin = New System.Windows.Forms.Padding(0)
        Me.m_btnGoTo.MinimumSize = New System.Drawing.Size(75, 23)
        Me.m_btnGoTo.Name = "m_btnGoTo"
        Me.m_btnGoTo.Size = New System.Drawing.Size(75, 23)
        Me.m_btnGoTo.TabIndex = 5
        Me.m_btnGoTo.Text = "&Go To"
        Me.m_btnGoTo.UseVisualStyleBackColor = True
        '
        'm_btnDelete
        '
        Me.m_btnDelete.AutoSize = True
        Me.m_btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.m_btnDelete.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_btnDelete.Enabled = False
        Me.m_btnDelete.Location = New System.Drawing.Point(209, 0)
        Me.m_btnDelete.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.m_btnDelete.MinimumSize = New System.Drawing.Size(75, 23)
        Me.m_btnDelete.Name = "m_btnDelete"
        Me.m_btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.m_btnDelete.TabIndex = 4
        Me.m_btnDelete.Text = "&Delete"
        Me.m_btnDelete.UseVisualStyleBackColor = True
        '
        'DeleteAndGoToTargetDialog
        '
        Me.AcceptButton = Me.m_btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.m_btnCancel
        Me.ClientSize = New System.Drawing.Size(303, 197)
        Me.Controls.Add(Me.m_tlpMainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeleteAndGoToTargetDialog"
        Me.Padding = New System.Windows.Forms.Padding(8, 11, 11, 11)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete and Go To Document Target"
        Me.m_tlpMainPanel.ResumeLayout(False)
        Me.m_tlpMainPanel.PerformLayout()
        Me.m_tlpContentPanel.ResumeLayout(False)
        Me.m_tlpContentPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents m_tlpMainPanel As TableLayoutPanel
    Private WithEvents m_btnCancel As Button
    Private WithEvents m_btnOK As Button
    Private WithEvents m_lblCurrentDocumentTargets As Label
    Private WithEvents m_tlpContentPanel As TableLayoutPanel
    Private WithEvents m_lbxDocumentTargets As ListBox
    Private WithEvents m_btnGoTo As Button
    Private WithEvents m_btnDelete As Button
End Class
