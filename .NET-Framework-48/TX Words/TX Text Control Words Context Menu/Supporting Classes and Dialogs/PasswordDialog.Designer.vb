
Namespace TXTextControl.Words
    Partial Class PasswordDialog
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            m_tlpMainPanel = New System.Windows.Forms.TableLayoutPanel()
            m_lblEnterPassword = New System.Windows.Forms.Label()
            m_lbProtectedDocument = New System.Windows.Forms.Label()
            m_lblPassword = New System.Windows.Forms.Label()
            m_tbxPassword = New System.Windows.Forms.TextBox()
            m_tlpButtonsPanel = New System.Windows.Forms.TableLayoutPanel()
            m_btnOK = New System.Windows.Forms.Button()
            m_btnCancel = New System.Windows.Forms.Button()
            m_tlpMainPanel.SuspendLayout()
            m_tlpButtonsPanel.SuspendLayout()
            SuspendLayout()
            ' 
            ' m_tlpMainPanel
            ' 
            m_tlpMainPanel.AutoSize = True
            m_tlpMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_tlpMainPanel.ColumnCount = 2
            m_tlpMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            m_tlpMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
            m_tlpMainPanel.Controls.Add(m_lblEnterPassword, 0, 1)
            m_tlpMainPanel.Controls.Add(m_lbProtectedDocument, 0, 0)
            m_tlpMainPanel.Controls.Add(m_lblPassword, 0, 2)
            m_tlpMainPanel.Controls.Add(m_tbxPassword, 1, 2)
            m_tlpMainPanel.Controls.Add(m_tlpButtonsPanel, 0, 3)
            m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            m_tlpMainPanel.Location = New System.Drawing.Point(9, 13)
            m_tlpMainPanel.Margin = New System.Windows.Forms.Padding(0)
            m_tlpMainPanel.Name = "m_tlpMainPanel"
            m_tlpMainPanel.RowCount = 5
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
            m_tlpMainPanel.Size = New System.Drawing.Size(334, 105)
            m_tlpMainPanel.TabIndex = 0
            ' 
            ' m_lblEnterPassword
            ' 
            m_lblEnterPassword.AutoSize = True
            m_tlpMainPanel.SetColumnSpan(m_lblEnterPassword, 2)
            m_lblEnterPassword.Dock = System.Windows.Forms.DockStyle.Top
            m_lblEnterPassword.Location = New System.Drawing.Point(0, 23)
            m_lblEnterPassword.Margin = New System.Windows.Forms.Padding(0, 0, 0, 11)
            m_lblEnterPassword.Name = "m_lblEnterPassword"
            m_lblEnterPassword.Size = New System.Drawing.Size(334, 15)
            m_lblEnterPassword.TabIndex = 2
            m_lblEnterPassword.Text = "Enter a password to open the document."
            m_lblEnterPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_lbProtectedDocument
            ' 
            m_lbProtectedDocument.AutoSize = True
            m_tlpMainPanel.SetColumnSpan(m_lbProtectedDocument, 2)
            m_lbProtectedDocument.Dock = System.Windows.Forms.DockStyle.Top
            m_lbProtectedDocument.Location = New System.Drawing.Point(0, 0)
            m_lbProtectedDocument.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
            m_lbProtectedDocument.Name = "m_lbProtectedDocument"
            m_lbProtectedDocument.Size = New System.Drawing.Size(334, 15)
            m_lbProtectedDocument.TabIndex = 1
            m_lbProtectedDocument.Text = "'{0}' is protected."
            m_lbProtectedDocument.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_lblPassword
            ' 
            m_lblPassword.AutoSize = True
            m_lblPassword.Dock = System.Windows.Forms.DockStyle.Left
            m_lblPassword.Location = New System.Drawing.Point(0, 49)
            m_lblPassword.Margin = New System.Windows.Forms.Padding(0)
            m_lblPassword.Name = "m_lblPassword"
            m_lblPassword.Size = New System.Drawing.Size(60, 23)
            m_lblPassword.TabIndex = 3
            m_lblPassword.Text = "Password:"
            m_lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_tbxPassword
            ' 
            m_tbxPassword.Dock = System.Windows.Forms.DockStyle.Top
            m_tbxPassword.Location = New System.Drawing.Point(71, 49)
            m_tbxPassword.Margin = New System.Windows.Forms.Padding(11, 0, 0, 0)
            m_tbxPassword.MinimumSize = New System.Drawing.Size(233, 4)
            m_tbxPassword.Name = "m_tbxPassword"
            m_tbxPassword.Size = New System.Drawing.Size(263, 23)
            m_tbxPassword.TabIndex = 4
            m_tbxPassword.UseSystemPasswordChar = True
            AddHandler m_tbxPassword.TextChanged, New EventHandler(AddressOf Password_TextChanged)
            ' 
            ' m_tlpButtonsPanel
            ' 
            m_tlpButtonsPanel.AutoSize = True
            m_tlpButtonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_tlpButtonsPanel.ColumnCount = 3
            m_tlpMainPanel.SetColumnSpan(m_tlpButtonsPanel, 2)
            m_tlpButtonsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
            m_tlpButtonsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            m_tlpButtonsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            m_tlpButtonsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F))
            m_tlpButtonsPanel.Controls.Add(m_btnOK, 1, 0)
            m_tlpButtonsPanel.Controls.Add(m_btnCancel, 2, 0)
            m_tlpButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top
            m_tlpButtonsPanel.Location = New System.Drawing.Point(0, 87)
            m_tlpButtonsPanel.Margin = New System.Windows.Forms.Padding(0, 15, 0, 0)
            m_tlpButtonsPanel.Name = "m_tlpButtonsPanel"
            m_tlpButtonsPanel.RowCount = 1
            m_tlpButtonsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
            m_tlpButtonsPanel.Size = New System.Drawing.Size(334, 27)
            m_tlpButtonsPanel.TabIndex = 5
            ' 
            ' m_btnOK
            ' 
            m_btnOK.AutoSize = True
            m_btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_btnOK.Dock = System.Windows.Forms.DockStyle.Top
            m_btnOK.Enabled = False
            m_btnOK.Location = New System.Drawing.Point(147, 0)
            m_btnOK.Margin = New System.Windows.Forms.Padding(0)
            m_btnOK.MinimumSize = New System.Drawing.Size(87, 27)
            m_btnOK.Name = "m_btnOK"
            m_btnOK.Size = New System.Drawing.Size(87, 27)
            m_btnOK.TabIndex = 6
            m_btnOK.Text = "OK"
            m_btnOK.UseVisualStyleBackColor = True
            AddHandler m_btnOK.Click, New EventHandler(AddressOf OK_Click)
            ' 
            ' m_btnCancel
            ' 
            m_btnCancel.AutoSize = True
            m_btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            m_btnCancel.Dock = System.Windows.Forms.DockStyle.Top
            m_btnCancel.Location = New System.Drawing.Point(247, 0)
            m_btnCancel.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
            m_btnCancel.MinimumSize = New System.Drawing.Size(87, 27)
            m_btnCancel.Name = "m_btnCancel"
            m_btnCancel.Size = New System.Drawing.Size(87, 27)
            m_btnCancel.TabIndex = 7
            m_btnCancel.Text = "Cancel"
            m_btnCancel.UseVisualStyleBackColor = True
            ' 
            ' PasswordDialog
            ' 
            AcceptButton = m_btnOK
            AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            AutoSize = True
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            CancelButton = m_btnCancel
            ClientSize = New System.Drawing.Size(356, 131)
            Controls.Add(m_tlpMainPanel)
            Font = New System.Drawing.Font("Segoe UI", 9.0F)
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            MaximizeBox = False
            MinimizeBox = False
            Name = "PasswordDialog"
            Padding = New System.Windows.Forms.Padding(9, 13, 13, 13)
            ShowIcon = False
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Text = "PasswordDialog"
            m_tlpMainPanel.ResumeLayout(False)
            m_tlpMainPanel.PerformLayout()
            m_tlpButtonsPanel.ResumeLayout(False)
            m_tlpButtonsPanel.PerformLayout()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private m_tlpMainPanel As System.Windows.Forms.TableLayoutPanel
        Private m_lbProtectedDocument As System.Windows.Forms.Label
        Private m_lblPassword As System.Windows.Forms.Label
        Private m_tbxPassword As System.Windows.Forms.TextBox
        Private m_tlpButtonsPanel As System.Windows.Forms.TableLayoutPanel
        Private m_btnOK As System.Windows.Forms.Button
        Private m_btnCancel As System.Windows.Forms.Button
        Private m_lblEnterPassword As System.Windows.Forms.Label
    End Class
End Namespace
