<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocumentTargetDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocumentTargetDialog))
        Me.m_tlpMainPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.m_lbxAllDocumentTargets = New System.Windows.Forms.ListBox()
        Me.m_btnOK = New System.Windows.Forms.Button()
        Me.m_btnCancel = New System.Windows.Forms.Button()
        Me.m_lblCurrentDocumentTargets = New System.Windows.Forms.Label()
        Me.m_lbxCurrentDocumentTargets = New System.Windows.Forms.ListBox()
        Me.m_lblAllDocumentTargets = New System.Windows.Forms.Label()
        Me.m_chbxCanBeDeleted = New System.Windows.Forms.CheckBox()
        Me.m_tlpNamePanel = New System.Windows.Forms.TableLayoutPanel()
        Me.m_lblName = New System.Windows.Forms.Label()
        Me.m_tbxTargetName = New System.Windows.Forms.TextBox()
        Me.m_btnChangeName = New System.Windows.Forms.Button()
        Me.m_tlpMainPanel.SuspendLayout()
        Me.m_tlpNamePanel.SuspendLayout()
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
        Me.m_tlpMainPanel.Controls.Add(Me.m_lbxAllDocumentTargets, 0, 4)
        Me.m_tlpMainPanel.Controls.Add(Me.m_btnOK, 1, 6)
        Me.m_tlpMainPanel.Controls.Add(Me.m_btnCancel, 2, 6)
        Me.m_tlpMainPanel.Controls.Add(Me.m_lblCurrentDocumentTargets, 0, 1)
        Me.m_tlpMainPanel.Controls.Add(Me.m_lbxCurrentDocumentTargets, 0, 2)
        Me.m_tlpMainPanel.Controls.Add(Me.m_lblAllDocumentTargets, 0, 3)
        Me.m_tlpMainPanel.Controls.Add(Me.m_chbxCanBeDeleted, 0, 5)
        Me.m_tlpMainPanel.Controls.Add(Me.m_tlpNamePanel, 0, 0)
        Me.m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_tlpMainPanel.Location = New System.Drawing.Point(8, 11)
        Me.m_tlpMainPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.m_tlpMainPanel.Name = "m_tlpMainPanel"
        Me.m_tlpMainPanel.RowCount = 7
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.m_tlpMainPanel.Size = New System.Drawing.Size(341, 325)
        Me.m_tlpMainPanel.TabIndex = 1
        '
        'm_lbxAllDocumentTargets
        '
        Me.m_tlpMainPanel.SetColumnSpan(Me.m_lbxAllDocumentTargets, 3)
        Me.m_lbxAllDocumentTargets.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_lbxAllDocumentTargets.FormattingEnabled = True
        Me.m_lbxAllDocumentTargets.Location = New System.Drawing.Point(3, 182)
        Me.m_lbxAllDocumentTargets.Margin = New System.Windows.Forms.Padding(3, 8, 0, 0)
        Me.m_lbxAllDocumentTargets.MinimumSize = New System.Drawing.Size(320, 100)
        Me.m_lbxAllDocumentTargets.Name = "m_lbxAllDocumentTargets"
        Me.m_lbxAllDocumentTargets.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.m_lbxAllDocumentTargets.Size = New System.Drawing.Size(338, 95)
        Me.m_lbxAllDocumentTargets.TabIndex = 7
        '
        'm_btnOK
        '
        Me.m_btnOK.AutoSize = True
        Me.m_btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.m_btnOK.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_btnOK.Location = New System.Drawing.Point(180, 313)
        Me.m_btnOK.Margin = New System.Windows.Forms.Padding(0)
        Me.m_btnOK.MinimumSize = New System.Drawing.Size(75, 23)
        Me.m_btnOK.Name = "m_btnOK"
        Me.m_btnOK.Size = New System.Drawing.Size(75, 23)
        Me.m_btnOK.TabIndex = 9
        Me.m_btnOK.Text = "OK"
        Me.m_btnOK.UseVisualStyleBackColor = True
        '
        'm_btnCancel
        '
        Me.m_btnCancel.AutoSize = True
        Me.m_btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.m_btnCancel.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_btnCancel.Location = New System.Drawing.Point(266, 313)
        Me.m_btnCancel.Margin = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.m_btnCancel.MinimumSize = New System.Drawing.Size(75, 23)
        Me.m_btnCancel.Name = "m_btnCancel"
        Me.m_btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.m_btnCancel.TabIndex = 10
        Me.m_btnCancel.Text = "Cancel"
        Me.m_btnCancel.UseVisualStyleBackColor = True
        '
        'm_lblCurrentDocumentTargets
        '
        Me.m_lblCurrentDocumentTargets.AutoSize = True
        Me.m_tlpMainPanel.SetColumnSpan(Me.m_lblCurrentDocumentTargets, 3)
        Me.m_lblCurrentDocumentTargets.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_lblCurrentDocumentTargets.Location = New System.Drawing.Point(0, 34)
        Me.m_lblCurrentDocumentTargets.Margin = New System.Windows.Forms.Padding(0, 11, 0, 0)
        Me.m_lblCurrentDocumentTargets.Name = "m_lblCurrentDocumentTargets"
        Me.m_lblCurrentDocumentTargets.Size = New System.Drawing.Size(341, 13)
        Me.m_lblCurrentDocumentTargets.TabIndex = 4
        Me.m_lblCurrentDocumentTargets.Text = "&Document targets at current input position:"
        '
        'm_lbxCurrentDocumentTargets
        '
        Me.m_tlpMainPanel.SetColumnSpan(Me.m_lbxCurrentDocumentTargets, 3)
        Me.m_lbxCurrentDocumentTargets.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_lbxCurrentDocumentTargets.FormattingEnabled = True
        Me.m_lbxCurrentDocumentTargets.Location = New System.Drawing.Point(3, 55)
        Me.m_lbxCurrentDocumentTargets.Margin = New System.Windows.Forms.Padding(3, 8, 0, 0)
        Me.m_lbxCurrentDocumentTargets.MinimumSize = New System.Drawing.Size(320, 100)
        Me.m_lbxCurrentDocumentTargets.Name = "m_lbxCurrentDocumentTargets"
        Me.m_lbxCurrentDocumentTargets.Size = New System.Drawing.Size(338, 95)
        Me.m_lbxCurrentDocumentTargets.TabIndex = 5
        '
        'm_lblAllDocumentTargets
        '
        Me.m_lblAllDocumentTargets.AutoSize = True
        Me.m_tlpMainPanel.SetColumnSpan(Me.m_lblAllDocumentTargets, 3)
        Me.m_lblAllDocumentTargets.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_lblAllDocumentTargets.Location = New System.Drawing.Point(0, 161)
        Me.m_lblAllDocumentTargets.Margin = New System.Windows.Forms.Padding(0, 11, 0, 0)
        Me.m_lblAllDocumentTargets.Name = "m_lblAllDocumentTargets"
        Me.m_lblAllDocumentTargets.Size = New System.Drawing.Size(341, 13)
        Me.m_lblAllDocumentTargets.TabIndex = 6
        Me.m_lblAllDocumentTargets.Text = "D&ocument targets in document:"
        '
        'm_chbxCanBeDeleted
        '
        Me.m_chbxCanBeDeleted.AutoSize = True
        Me.m_chbxCanBeDeleted.Checked = True
        Me.m_chbxCanBeDeleted.CheckState = System.Windows.Forms.CheckState.Checked
        Me.m_tlpMainPanel.SetColumnSpan(Me.m_chbxCanBeDeleted, 3)
        Me.m_chbxCanBeDeleted.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_chbxCanBeDeleted.Location = New System.Drawing.Point(3, 288)
        Me.m_chbxCanBeDeleted.Margin = New System.Windows.Forms.Padding(3, 11, 0, 8)
        Me.m_chbxCanBeDeleted.Name = "m_chbxCanBeDeleted"
        Me.m_chbxCanBeDeleted.Size = New System.Drawing.Size(338, 17)
        Me.m_chbxCanBeDeleted.TabIndex = 8
        Me.m_chbxCanBeDeleted.Text = "&Can be deleted during editing"
        Me.m_chbxCanBeDeleted.UseVisualStyleBackColor = True
        '
        'm_tlpNamePanel
        '
        Me.m_tlpNamePanel.AutoSize = True
        Me.m_tlpNamePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.m_tlpNamePanel.ColumnCount = 3
        Me.m_tlpMainPanel.SetColumnSpan(Me.m_tlpNamePanel, 3)
        Me.m_tlpNamePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.m_tlpNamePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.m_tlpNamePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.m_tlpNamePanel.Controls.Add(Me.m_lblName, 0, 0)
        Me.m_tlpNamePanel.Controls.Add(Me.m_tbxTargetName, 1, 0)
        Me.m_tlpNamePanel.Controls.Add(Me.m_btnChangeName, 2, 0)
        Me.m_tlpNamePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_tlpNamePanel.Location = New System.Drawing.Point(0, 0)
        Me.m_tlpNamePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.m_tlpNamePanel.Name = "m_tlpNamePanel"
        Me.m_tlpNamePanel.RowCount = 1
        Me.m_tlpNamePanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.m_tlpNamePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.m_tlpNamePanel.Size = New System.Drawing.Size(341, 23)
        Me.m_tlpNamePanel.TabIndex = 11
        '
        'm_lblName
        '
        Me.m_lblName.AutoSize = True
        Me.m_lblName.Dock = System.Windows.Forms.DockStyle.Left
        Me.m_lblName.Location = New System.Drawing.Point(0, 0)
        Me.m_lblName.Margin = New System.Windows.Forms.Padding(0)
        Me.m_lblName.Name = "m_lblName"
        Me.m_lblName.Size = New System.Drawing.Size(72, 23)
        Me.m_lblName.TabIndex = 1
        Me.m_lblName.Text = "&Target Name:"
        Me.m_lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'm_tbxTargetName
        '
        Me.m_tbxTargetName.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_tbxTargetName.Location = New System.Drawing.Point(83, 2)
        Me.m_tbxTargetName.Margin = New System.Windows.Forms.Padding(11, 2, 0, 0)
        Me.m_tbxTargetName.Name = "m_tbxTargetName"
        Me.m_tbxTargetName.Size = New System.Drawing.Size(207, 20)
        Me.m_tbxTargetName.TabIndex = 2
        '
        'm_btnChangeName
        '
        Me.m_btnChangeName.AutoSize = True
        Me.m_btnChangeName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.m_btnChangeName.Dock = System.Windows.Forms.DockStyle.Right
        Me.m_btnChangeName.Location = New System.Drawing.Point(301, 0)
        Me.m_btnChangeName.Margin = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.m_btnChangeName.MinimumSize = New System.Drawing.Size(40, 23)
        Me.m_btnChangeName.Name = "m_btnChangeName"
        Me.m_btnChangeName.Size = New System.Drawing.Size(40, 23)
        Me.m_btnChangeName.TabIndex = 3
        Me.m_btnChangeName.Text = "✔"
        Me.m_btnChangeName.UseVisualStyleBackColor = True
        '
        'DocumentTargetDialog
        '
        Me.AcceptButton = Me.m_btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.m_btnCancel
        Me.ClientSize = New System.Drawing.Size(360, 347)
        Me.Controls.Add(Me.m_tlpMainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DocumentTargetDialog"
        Me.Padding = New System.Windows.Forms.Padding(8, 11, 11, 11)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.m_tlpMainPanel.ResumeLayout(False)
        Me.m_tlpMainPanel.PerformLayout()
        Me.m_tlpNamePanel.ResumeLayout(False)
        Me.m_tlpNamePanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents m_tlpMainPanel As TableLayoutPanel
    Private WithEvents m_lbxAllDocumentTargets As ListBox
    Private WithEvents m_btnOK As Button
    Private WithEvents m_btnCancel As Button
    Private WithEvents m_lblCurrentDocumentTargets As Label
    Private WithEvents m_lbxCurrentDocumentTargets As ListBox
    Private WithEvents m_lblAllDocumentTargets As Label
    Private WithEvents m_chbxCanBeDeleted As CheckBox
    Private WithEvents m_tlpNamePanel As TableLayoutPanel
    Private WithEvents m_lblName As Label
    Private WithEvents m_tbxTargetName As TextBox
    Private WithEvents m_btnChangeName As Button
End Class
