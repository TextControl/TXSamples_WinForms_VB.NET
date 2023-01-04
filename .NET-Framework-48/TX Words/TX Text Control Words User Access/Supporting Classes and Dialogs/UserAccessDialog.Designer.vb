
Namespace TXTextControl.Words
    Partial Class UserAccessDialog
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
            m_lblNewPassword = New System.Windows.Forms.Label()
            m_tbxNewPassword = New System.Windows.Forms.TextBox()
            m_tbxConfirmPassword = New System.Windows.Forms.TextBox()
            m_lblConfirmPassword = New System.Windows.Forms.Label()
            m_lblUser = New System.Windows.Forms.Label()
            m_lblUserName = New System.Windows.Forms.Label()
            m_lblPassword = New System.Windows.Forms.Label()
            m_tbxPassword = New System.Windows.Forms.TextBox()
            m_tlpButtonsPanel = New System.Windows.Forms.TableLayoutPanel()
            m_btnDelete = New System.Windows.Forms.Button()
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
            m_tlpMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            m_tlpMainPanel.Controls.Add(m_lblNewPassword, 0, 2)
            m_tlpMainPanel.Controls.Add(m_tbxNewPassword, 0, 2)
            m_tlpMainPanel.Controls.Add(m_tbxConfirmPassword, 1, 3)
            m_tlpMainPanel.Controls.Add(m_lblConfirmPassword, 0, 3)
            m_tlpMainPanel.Controls.Add(m_lblUser, 0, 0)
            m_tlpMainPanel.Controls.Add(m_lblUserName, 1, 0)
            m_tlpMainPanel.Controls.Add(m_lblPassword, 0, 1)
            m_tlpMainPanel.Controls.Add(m_tbxPassword, 1, 1)
            m_tlpMainPanel.Controls.Add(m_tlpButtonsPanel, 0, 4)
            m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            m_tlpMainPanel.Location = New System.Drawing.Point(9, 13)
            m_tlpMainPanel.Margin = New System.Windows.Forms.Padding(0)
            m_tlpMainPanel.Name = "m_tlpMainPanel"
            m_tlpMainPanel.RowCount = 6
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0F))
            m_tlpMainPanel.Size = New System.Drawing.Size(334, 145)
            m_tlpMainPanel.TabIndex = 0
            ' 
            ' m_lblNewPassword
            ' 
            m_lblNewPassword.AutoSize = True
            m_lblNewPassword.Dock = System.Windows.Forms.DockStyle.Left
            m_lblNewPassword.Location = New System.Drawing.Point(0, 56)
            m_lblNewPassword.Margin = New System.Windows.Forms.Padding(0, 0, 9, 9)
            m_lblNewPassword.Name = "m_lblNewPassword"
            m_lblNewPassword.Size = New System.Drawing.Size(87, 23)
            m_lblNewPassword.TabIndex = 5
            m_lblNewPassword.Text = "New Password:"
            m_lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_tbxNewPassword
            ' 
            m_tbxNewPassword.Dock = System.Windows.Forms.DockStyle.Top
            m_tbxNewPassword.Location = New System.Drawing.Point(119, 56)
            m_tbxNewPassword.Margin = New System.Windows.Forms.Padding(3, 0, 0, 9)
            m_tbxNewPassword.MinimumSize = New System.Drawing.Size(233, 4)
            m_tbxNewPassword.Name = "m_tbxNewPassword"
            m_tbxNewPassword.Size = New System.Drawing.Size(233, 23)
            m_tbxNewPassword.TabIndex = 6
            m_tbxNewPassword.UseSystemPasswordChar = True
            AddHandler m_tbxNewPassword.TextChanged, New EventHandler(AddressOf Password_TextChanged)
            ' 
            ' m_tbxConfirmPassword
            ' 
            m_tbxConfirmPassword.Dock = System.Windows.Forms.DockStyle.Top
            m_tbxConfirmPassword.Enabled = False
            m_tbxConfirmPassword.Location = New System.Drawing.Point(119, 88)
            m_tbxConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 0, 0, 9)
            m_tbxConfirmPassword.MinimumSize = New System.Drawing.Size(233, 4)
            m_tbxConfirmPassword.Name = "m_tbxConfirmPassword"
            m_tbxConfirmPassword.PasswordChar = "*"c
            m_tbxConfirmPassword.Size = New System.Drawing.Size(233, 23)
            m_tbxConfirmPassword.TabIndex = 8
            m_tbxConfirmPassword.UseSystemPasswordChar = True
            AddHandler m_tbxConfirmPassword.TextChanged, New EventHandler(AddressOf Password_TextChanged)
            ' 
            ' m_lblConfirmPassword
            ' 
            m_lblConfirmPassword.AutoSize = True
            m_lblConfirmPassword.Dock = System.Windows.Forms.DockStyle.Left
            m_lblConfirmPassword.Location = New System.Drawing.Point(0, 88)
            m_lblConfirmPassword.Margin = New System.Windows.Forms.Padding(0, 0, 9, 9)
            m_lblConfirmPassword.Name = "m_lblConfirmPassword"
            m_lblConfirmPassword.Size = New System.Drawing.Size(107, 23)
            m_lblConfirmPassword.TabIndex = 7
            m_lblConfirmPassword.Text = "Confirm Password:"
            m_lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_lblUser
            ' 
            m_lblUser.AutoSize = True
            m_lblUser.Dock = System.Windows.Forms.DockStyle.Left
            m_lblUser.Location = New System.Drawing.Point(0, 0)
            m_lblUser.Margin = New System.Windows.Forms.Padding(0, 0, 13, 9)
            m_lblUser.Name = "m_lblUser"
            m_lblUser.Size = New System.Drawing.Size(33, 15)
            m_lblUser.TabIndex = 1
            m_lblUser.Text = "User:"
            m_lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_lblUserName
            ' 
            m_lblUserName.AutoSize = True
            m_lblUserName.Dock = System.Windows.Forms.DockStyle.Left
            m_lblUserName.Location = New System.Drawing.Point(116, 0)
            m_lblUserName.Margin = New System.Windows.Forms.Padding(0, 0, 0, 9)
            m_lblUserName.Name = "m_lblUserName"
            m_lblUserName.Size = New System.Drawing.Size(81, 15)
            m_lblUserName.TabIndex = 2
            m_lblUserName.Text = "[Current User]"
            m_lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_lblPassword
            ' 
            m_lblPassword.AutoSize = True
            m_lblPassword.Dock = System.Windows.Forms.DockStyle.Left
            m_lblPassword.Location = New System.Drawing.Point(0, 24)
            m_lblPassword.Margin = New System.Windows.Forms.Padding(0, 0, 9, 9)
            m_lblPassword.Name = "m_lblPassword"
            m_lblPassword.Size = New System.Drawing.Size(60, 23)
            m_lblPassword.TabIndex = 3
            m_lblPassword.Text = "Password:"
            m_lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_tbxPassword
            ' 
            m_tbxPassword.Dock = System.Windows.Forms.DockStyle.Top
            m_tbxPassword.Location = New System.Drawing.Point(119, 24)
            m_tbxPassword.Margin = New System.Windows.Forms.Padding(3, 0, 0, 9)
            m_tbxPassword.MinimumSize = New System.Drawing.Size(233, 4)
            m_tbxPassword.Name = "m_tbxPassword"
            m_tbxPassword.Size = New System.Drawing.Size(233, 23)
            m_tbxPassword.TabIndex = 4
            m_tbxPassword.UseSystemPasswordChar = True
            AddHandler m_tbxPassword.TextChanged, New EventHandler(AddressOf Password_TextChanged)
            ' 
            ' m_tlpButtonsPanel
            ' 
            m_tlpButtonsPanel.AutoSize = True
            m_tlpButtonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_tlpButtonsPanel.ColumnCount = 4
            m_tlpMainPanel.SetColumnSpan(m_tlpButtonsPanel, 2)
            m_tlpButtonsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            m_tlpButtonsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            m_tlpButtonsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            m_tlpButtonsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            m_tlpButtonsPanel.Controls.Add(m_btnDelete, 0, 0)
            m_tlpButtonsPanel.Controls.Add(m_btnOK, 2, 0)
            m_tlpButtonsPanel.Controls.Add(m_btnCancel, 3, 0)
            m_tlpButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top
            m_tlpButtonsPanel.Location = New System.Drawing.Point(0, 128)
            m_tlpButtonsPanel.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
            m_tlpButtonsPanel.Name = "m_tlpButtonsPanel"
            m_tlpButtonsPanel.RowCount = 1
            m_tlpButtonsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            m_tlpButtonsPanel.Size = New System.Drawing.Size(334, 27)
            m_tlpButtonsPanel.TabIndex = 9
            ' 
            ' m_btnDelete
            ' 
            m_btnDelete.AutoSize = True
            m_btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_btnDelete.Dock = System.Windows.Forms.DockStyle.Top
            m_btnDelete.Enabled = False
            m_btnDelete.Location = New System.Drawing.Point(0, 0)
            m_btnDelete.Margin = New System.Windows.Forms.Padding(0, 0, 13, 0)
            m_btnDelete.MinimumSize = New System.Drawing.Size(87, 27)
            m_btnDelete.Name = "m_btnDelete"
            m_btnDelete.Size = New System.Drawing.Size(87, 27)
            m_btnDelete.TabIndex = 10
            m_btnDelete.Text = "Delete"
            m_btnDelete.UseVisualStyleBackColor = True
            m_btnDelete.Visible = False
            AddHandler m_btnDelete.Click, New EventHandler(AddressOf Delete_Click)
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
            m_btnOK.TabIndex = 11
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
            m_btnCancel.TabIndex = 12
            m_btnCancel.Text = "Cancel"
            m_btnCancel.UseVisualStyleBackColor = True
            ' 
            ' UserAccessDialog
            ' 
            AcceptButton = m_btnOK
            AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            AutoSize = True
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            CancelButton = m_btnCancel
            ClientSize = New System.Drawing.Size(356, 171)
            Controls.Add(m_tlpMainPanel)
            Font = New System.Drawing.Font("Segoe UI", 9.0F)
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            MaximizeBox = False
            MinimizeBox = False
            Name = "UserAccessDialog"
            Padding = New System.Windows.Forms.Padding(9, 13, 13, 13)
            ShowIcon = False
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Text = "Account Settings"
            m_tlpMainPanel.ResumeLayout(False)
            m_tlpMainPanel.PerformLayout()
            m_tlpButtonsPanel.ResumeLayout(False)
            m_tlpButtonsPanel.PerformLayout()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private m_tlpMainPanel As System.Windows.Forms.TableLayoutPanel
        Private m_tbxConfirmPassword As System.Windows.Forms.TextBox
        Private m_lblConfirmPassword As System.Windows.Forms.Label
        Private m_lblUser As System.Windows.Forms.Label
        Private m_lblUserName As System.Windows.Forms.Label
        Private m_lblPassword As System.Windows.Forms.Label
        Private m_tbxPassword As System.Windows.Forms.TextBox
        Private m_tlpButtonsPanel As System.Windows.Forms.TableLayoutPanel
        Private m_btnOK As System.Windows.Forms.Button
        Private m_btnCancel As System.Windows.Forms.Button
        Private m_lblNewPassword As System.Windows.Forms.Label
        Private m_tbxNewPassword As System.Windows.Forms.TextBox
        Private m_btnDelete As System.Windows.Forms.Button
    End Class
End Namespace
