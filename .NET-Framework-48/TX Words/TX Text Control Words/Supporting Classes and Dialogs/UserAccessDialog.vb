'-----------------------------------------------------------------------------------------------------------
' UserAccessDialog.vb File
'
' Description:
'     Provides a dialog to create a new user account, sign in a user or edit a user account.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------

Namespace TXTextControl.Words
    '-----------------------------------------------------------------------------------------------------------
    ' UserAccessDialog Class
    ' A dialog to create a new user account, sign in a user or edit a user account.
    '-----------------------------------------------------------------------------------------------------------
    Partial Friend Class UserAccessDialog
        Inherits Form

        '-----------------------------------------------------------------------------------------------------------
        ' E N U M S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' DialogBehaviors Enum
        ' Represents three kinds of behavior how the dialog might act.
        '-----------------------------------------------------------------------------------------------------------
        Friend Enum DialogBehaviors
            CreateAccount      ' The dialog is opened to create a new user account.
            SignIn             ' The dialog is opened to sign in a user.
            AccountSettings     ' The dialog is opened to edit the signed in user's account.
        End Enum


        '-----------------------------------------------------------------------------------------------------------
        ' M E M B E R   V A R I A B L E S
        '-----------------------------------------------------------------------------------------------------------

        Private ReadOnly m_uiUserInfo As UserInfo = Nothing
        Private ReadOnly m_strUserName As String = Nothing
        Private ReadOnly m_dbDialogBehavior As DialogBehaviors = DialogBehaviors.CreateAccount


        '-----------------------------------------------------------------------------------------------------------
        ' C O N S T R U C T O R S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' UserAccessDialog Constructor
        ' Opens the dialog to sign in a user or to edit the signed in user's account settings.
        '
        ' Parameters:
        '      userInfo:   The UserInfo instance of the user to be handled.
        '-----------------------------------------------------------------------------------------------------------
        Friend Sub New(ByVal userInfo As UserInfo)
            InitializeComponent()
            m_uiUserInfo = userInfo

            ' Set the user name
            m_lblUserName.Text = CSharpImpl.Assign(m_strUserName, m_uiUserInfo.Name)

            ' Check whether to sign in the user or edit its account settings.
            If m_uiUserInfo.IsSignedIn Then
                ' Edit user account settings.
                m_dbDialogBehavior = DialogBehaviors.AccountSettings

                ' Update controls texts
                Text = My.Resources.UserAccessDialog_AccountSettings_Caption

                m_lblPassword.Text = My.Resources.UserAccessDialog_AccountSettings_OldPassword
                m_lblNewPassword.Text = My.Resources.UserAccessDialog_AccountSettings_NewPassword
                m_lblConfirmPassword.Text = My.Resources.UserAccessDialog_AccountSettings_ConfirmPassword

                ' Buttons
                m_btnDelete.Visible = True
                m_btnDelete.Text = My.Resources.UserAccessDialog_AccountSettings_Delete
            Else
                ' Otherwise the user is known but not signed in.
                m_dbDialogBehavior = DialogBehaviors.SignIn

                ' Hide 'New password' and 'Confirm password' controls
                m_lblNewPassword.Visible = CSharpImpl.Assign(m_tbxNewPassword.Visible, CSharpImpl.Assign(m_lblConfirmPassword.Visible, CSharpImpl.Assign(m_tbxConfirmPassword.Visible, False)))

                ' Update controls texts
                Text = My.Resources.UserAccessDialog_SignIn_Caption
                m_lblPassword.Text = My.Resources.UserAccessDialog_SignIn_Password
            End If
            m_btnOK.Text = My.Resources.UserAccessDialog_OK
            m_btnCancel.Text = My.Resources.UserAccessDialog_Cancel
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' UserAccessDialog Constructor
        ' Opens the dialog to create a user account.
        '
        ' Parameters:
        '      userName:   The name of the user to create an account for.
        '-----------------------------------------------------------------------------------------------------------
        Public Sub New(ByVal userName As String)
            InitializeComponent()

            ' Set the user name
            m_lblUserName.Text = CSharpImpl.Assign(m_strUserName, userName)

            ' A new account should be created.
            m_dbDialogBehavior = DialogBehaviors.CreateAccount

            ' Hide password controls
            m_lblPassword.Visible = CSharpImpl.Assign(m_tbxPassword.Visible, False)

            ' Update control texts
            Text = My.Resources.UserAccessDialog_CreateAccount_Caption
            m_lblNewPassword.Text = My.Resources.UserAccessDialog_CreateAccount_NewPassword
            m_lblConfirmPassword.Text = My.Resources.UserAccessDialog_CreateAccount_ConfirmPassword

            ' Buttons
            m_btnOK.Text = My.Resources.UserAccessDialog_OK
            m_btnCancel.Text = My.Resources.UserAccessDialog_Cancel
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' P R O P E R T I E S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' UserInfo Property
        ' Returns an instance of a UserInfo class that represents the signed in user.
        '-----------------------------------------------------------------------------------------------------------
        Friend ReadOnly Property UserInfo As UserInfo
            Get
                Select Case m_dbDialogBehavior
                    Case DialogBehaviors.SignIn
                        m_uiUserInfo.IsSignedIn = True
                        Return m_uiUserInfo
                    Case Else
                        Return New UserInfo(m_strUserName, m_tbxConfirmPassword.Text)
                End Select
            End Get
        End Property


        '-----------------------------------------------------------------------------------------------------------
        ' H A N D L E R S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' Password_TextChanged Handler
        ' Updates the enabled states of the dialog controls when the text of a text box changed.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Password_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            EnableControls()
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Delete_Click Handler
        ' Asks the user whether his user account should be deleted. In that case and if the 
        ' password is correct, the dialog is closed.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Delete_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Ask the user whether the current user account should be deleted.
            If MessageBox.Show(Me, My.Resources.MessageBox_UserAccessDialogDeleteAccount_Text, Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                ' Validate the password of the current signed in user.
                If Not m_uiUserInfo.ValidatePassword(m_tbxPassword.Text) Then
                    MessageBox.Show(Me, My.Resources.MessageBox_UserAccessDialogIncorrectPassword_Text, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
                ' Close the dialog
                DialogResult = DialogResult.Abort
                Close()
            End If
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' OK_Click Handler
        ' Validates the password when the OK button is clicked.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub OK_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Validate the password of the current signed in user or the user to sign in.
            If m_uiUserInfo IsNot Nothing AndAlso Not m_uiUserInfo.ValidatePassword(m_tbxPassword.Text) Then
                ' The password is not correct.
                MessageBox.Show(Me, My.Resources.MessageBox_UserAccessDialogIncorrectPassword_Text, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            DialogResult = DialogResult.OK
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' M E T H O D S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' EnableControls Method
        ' Updates the enabled states of the dialog controls when the text of a text box changed.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub EnableControls()
            Select Case m_dbDialogBehavior
                Case DialogBehaviors.CreateAccount
                    ' Enable/Disable the confirm password text 
                    If Not CSharpImpl.Assign(m_tbxConfirmPassword.Enabled, m_tbxNewPassword.Text.Length > 0) Then
                        m_tbxConfirmPassword.Text = "" ' Reset the confirm password text box if it is disabled.
                    End If
                    ' Enable/Disable the OK button.
                    m_btnOK.Enabled = m_tbxConfirmPassword.Enabled AndAlso Equals(m_tbxNewPassword.Text, m_tbxConfirmPassword.Text)
                Case DialogBehaviors.SignIn
                    ' Enable/Disable the OK button.
                    m_btnOK.Enabled = m_tbxPassword.Text.Length > 0
                Case DialogBehaviors.AccountSettings
                    ' Enable/Disable the confirm password text 
                    If Not CSharpImpl.Assign(m_tbxConfirmPassword.Enabled, m_tbxNewPassword.Text.Length > 0) Then
                        m_tbxConfirmPassword.Text = ""  ' Reset the confirm password text box if it is disabled.
                    End If
                    ' Enable/Disable the OK and Delete button.
                    m_btnOK.Enabled = CSharpImpl.Assign(m_btnDelete.Enabled, m_tbxPassword.Text.Length > 0) AndAlso m_tbxConfirmPassword.Enabled AndAlso Equals(m_tbxNewPassword.Text, m_tbxConfirmPassword.Text)
            End Select
        End Sub

        Private Class CSharpImpl
            Shared Function Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
