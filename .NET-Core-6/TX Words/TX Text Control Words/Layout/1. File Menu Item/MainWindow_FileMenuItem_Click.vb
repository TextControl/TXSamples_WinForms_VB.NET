'-----------------------------------------------------------------------------------------------------------
' MainWindow_FileMenuItem_Click.vb File
'
' Description: Provides all Click handlers associated with 'File' menu items.
'     
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Imports System.Drawing.Printing
Imports System.IO

Namespace TXTextControl.Words
    Partial Class MainWindow
        '-----------------------------------------------------------------------------------------------------------
        ' File_New_Click Handler
        '
        ' Invokes the TextControl.ResetContents method to create a new document.
        ' 
        ' Item: 'New'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub File_New_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Check whether the document is dirty. In this case, the user is suggested to save that document. 
            If SaveDirtyDocumentOnNew() Then
                ' Create a new document.
                m_txTextControl.ResetContents()

                ' A new document is created. Now:
                UpdateCurrentDocumentInfo() ' Reset the current document information.
                UpdateMainWindowCaption() ' Update the caption of the application's main window.
            End If
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' File_Open_Click Handler
        '
        ' Invokes the Open method to load a document by using the internal TextControl 'Open' dialog.
        ' 
        ' Item: 'Open...'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub File_Open_Click(ByVal sender As Object, ByVal e As EventArgs)
            Open()
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' File_RecentFiles_Item_Click Handler
        '
        ' Opens the file that is represented by the clicked item.
        ' 
        ' Item: Each item of the 'Recent Files' drop down menu
        '-----------------------------------------------------------------------------------------------------------
        Private Sub File_RecentFiles_Item_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Get the file that is represented by the clicked item.
            Dim strFile As String = TryCast(TryCast(sender, ToolStripMenuItem).Tag, String)

            ' Check whether the file still exists.
            If Not File.Exists(strFile) Then
                ' If not, open a Message box that asks the user whether the not
                ' existing file should be removed from the recent file list.
                If MessageBox.Show(Me, My.Resources.MessageBox_OpenRecentFile_FileDoesNotExist_Text, My.Resources.MessageBox_OpenRecentFile_FileDoesNotExist_Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                    ' Remove the file from the list and update the items collection.
                    m_colRecentFiles.Remove(strFile)
                    UpdateRecentFileList()
                End If
            Else
                ' Open the file.
                Open(strFile)
            End If
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' File_Save_Click Handler
        '
        ' Invokes the Save method to save a document by saving it at the same location where it was loaded 
        ' before.
        ' 
        ' Item: 'Save'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub File_Save_Click(ByVal sender As Object, ByVal e As EventArgs)
            Save(m_strActiveDocumentPath)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' File_SaveAs_Click Handler
        '
        ' Invokes the Save method to save a document by using the internal TextControl 'Save' dialog.
        ' 
        ' Item: 'Save As...'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub File_SaveAs_Click(ByVal sender As Object, ByVal e As EventArgs)
            Save(Nothing)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' File_PageSetup_Click Handler
        '
        ' Invokes the built-in dialog for setting section attributes.
        ' 
        ' Item: 'Page Setup...'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub File_PageSetup_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.SectionFormatDialog()
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' File_PrintPreview_Click Handler
        '
        ' Opens a print preview.
        ' 
        ' Item: 'Print Preview...'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub File_PrintPreview_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.PrintPreview(m_strActiveDocumentName)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' File_Print_Click Handler
        '
        ' Invokes the TextControl Print method to open the TextControl print dialog.
        ' 
        ' Item: 'Print...'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub File_Print_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Use the active document name to open the print dialog.
            m_txTextControl.Print(m_strActiveDocumentName)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' File_PrintQuick_Click Handler
        '
        ' Prints the current document without opening the dialog before.
        ' 
        ' Item: 'Print Quick'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub File_PrintQuick_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.Print(New PrintDocument() With {
                .PrinterSettings = New PrinterSettings() With {
                    .FromPage = 1,
                    .ToPage = m_txTextControl.Pages,
                    .Copies = 1,
                    .Collate = True,
                    .PrintFileName = m_strActiveDocumentName
                }
            })
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' File_SignIn_Click Handler
        '
        ' Opens a dialog to sign in to the TextControl a user by its account. If no such account is known,
        ' a new account is created. 
        ' 
        ' Item: 'Sign In...'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub File_SignIn_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Open the password dialog to sign in or create a user account.
            Dim dlgUserAccessDialog As UserAccessDialog = If(m_uiCurrentUser Is Nothing, New UserAccessDialog(m_strUserName), New UserAccessDialog(m_uiCurrentUser))

            If dlgUserAccessDialog.ShowDialog(Me) = DialogResult.OK Then
                ' Get the UserInfo instance that represents the current signed in user.
                m_uiCurrentUser = dlgUserAccessDialog.UserInfo

                ' Give the user access to the TextControl.
                m_txTextControl.UserNames = New String() {m_uiCurrentUser.Name}

                ' Hide the Sign In item.
                m_tmiFile_SignIn.Enabled = CSharpImpl.Assign(m_tmiFile_SignIn.Visible, False)

                ' Show the [Current User] item.
                m_tmiFile_CurrentUser.Enabled = CSharpImpl.Assign(m_tmiFile_CurrentUser.Visible, True)
            End If
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' File_CurrentUser_AccountSettings_Click Handler
        '
        ' Opens a dialog to edit the account settings of the current signed in user.
        ' 
        ' Item: 'Account Settings...' of the '[Current User]' drop down menu
        '-----------------------------------------------------------------------------------------------------------
        Private Sub File_CurrentUser_AccountSettings_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlg As UserAccessDialog = New UserAccessDialog(m_uiCurrentUser)
            Select Case dlg.ShowDialog()
                Case DialogResult.OK
                    ' Replace the user info object of the current user
                    ' with a new instance.
                    m_uiCurrentUser = dlg.UserInfo
                    m_tmiFile_CurrentUser.Visible = True
                Case DialogResult.Abort
                    ' The UserAccessDialog's Delete Account item was clicked. 
                    ' Set current user to null...
                    m_uiCurrentUser = Nothing
                    ' ... and sign out.
                    SignOut()
            End Select
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' File_CurrentUser_SignOut_Click Handler
        '
        ' Signs out the current signed in user.
        ' 
        ' Item: 'Sign Out' of the '[Current User]' drop down menu
        '-----------------------------------------------------------------------------------------------------------
        Private Sub File_CurrentUser_SignOut_Click(ByVal sender As Object, ByVal e As EventArgs)
            SignOut()
            MessageBox.Show(Me, String.Format(My.Resources.MessageBox_UserAccess_SignOut_Text, m_strUserName), My.Resources.MessageBox_UserAccess_SignOut_Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' File_Exit_Click Handler
        '
        ' Closes the application when clicked.
        ' 
        ' Item: 'Exit'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub File_Exit_Click(ByVal sender As Object, ByVal e As EventArgs)
            Close()
        End Sub
    End Class
End Namespace
