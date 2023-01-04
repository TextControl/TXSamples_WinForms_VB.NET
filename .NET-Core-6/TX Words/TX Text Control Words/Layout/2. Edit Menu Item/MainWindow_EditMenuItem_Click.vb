'-----------------------------------------------------------------------------------------------------------
' MainWindow_EditMenuItem_Click.vb File
'
' Description: Provides all Click handlers associated with 'Edit' menu items.
'     
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------

Namespace TXTextControl.Words
    Partial Class MainWindow
        '-----------------------------------------------------------------------------------------------------------
        ' Edit_Undo_Click Handler
        '
        ' Undoes the last edit operation in the TextControl.
        ' 
        ' Item: 'Undo'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_Undo_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.Undo()
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_Redo_Click Handler
        '
        ' Redoes the last TextControl operation.
        ' 
        ' Item: 'Redo'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_Redo_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.Redo()
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_Cut_Click Handler
        '
        ' Moves the current selection in the TextControl to the Clipboard.
        ' 
        ' Item: 'Cut'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_Cut_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.Cut()
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_Copy_Click Handler
        '
        ' Copies the current selection in the TextControl to the Clipboard.
        ' 
        ' Item: 'Copy'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_Copy_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.Copy()
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_Paste_Click Handler
        '
        ' Replaces the current selection in the TextControl with the contents of the Clipboard.
        ' 
        ' Item: 'Paste'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_Paste_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.Paste()
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_SelectAll_Click Handler
        '
        ' Selects all text in the TextControl.
        ' 
        ' Item: 'Select All'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_SelectAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.SelectAll()
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_Find_Click Handler
        '
        ' Opens the built-in Find dialog box.
        ' 
        ' Item: 'Find...'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_Find_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.Find()
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_Replace_Click Handler
        '
        ' Opens the built-in Replace dialog box.
        ' 
        ' Item: 'Replace...'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_Replace_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.Replace()
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_Permissions_AllowFormatting_Click Handler
        '
        ' Sets a value specifying whether the document can be formatted. 
        ' 
        ' Item: 'Allow Formatting' of the 'Permissions' drop down menu
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_Permissions_AllowFormatting_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.DocumentPermissions.AllowFormatting = m_tmiEdit_Permissions_AllowFormatting.Checked
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_Permissions_AllowFormattingStyles_Click Handler
        '
        ' Sets a value specifying whether formatting styles can be used to format the document. 
        ' 
        ' Item: 'Allow Formatting Styles' of the 'Permissions' drop down menu
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_Permissions_AllowFormattingStyles_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.DocumentPermissions.AllowFormattingStyles = m_tmiEdit_Permissions_AllowFormattingStyles.Checked
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_Permissions_AllowPrinting_Click Handler
        '
        ' Sets a value specifying whether the document can be printed.
        ' 
        ' Item: 'Allow Printing' of the 'Permissions' drop down menu
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_Permissions_AllowPrinting_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.DocumentPermissions.AllowPrinting = m_tmiEdit_Permissions_AllowPrinting.Checked
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_Permissions_AllowCopy_Click Handler
        '
        ' Sets a value specifying whether document content can be copied to the clipboard.
        ' 
        ' Item: 'Allow Copy' of the 'Permissions' drop down menu
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_Permissions_AllowCopy_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.DocumentPermissions.AllowCopy = m_tmiEdit_Permissions_AllowCopy.Checked
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_Permissions_AllowEditingFormFields_Click Handler
        '
        ' Sets a value specifying whether form fields can be edited. 
        ' 
        ' Item: 'Allow Editing Form Fields' of the 'Permissions' drop down menu
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_Permissions_AllowEditingFormFields_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.DocumentPermissions.AllowEditingFormFields = m_tmiEdit_Permissions_AllowEditingFormFields.Checked
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_Permissions_ReadOnly_Click Handler
        '
        ' Opens the built-in Replace dialog box.
        ' 
        ' Item: 'Read Only' of the 'Permissions' drop down menu
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_Permissions_ReadOnly_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.DocumentPermissions.ReadOnly = m_tmiEdit_Permissions_ReadOnly.Checked
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_EditableRegions_Add_ForCurrentUser_Click Handler
        '
        ' Adds an editable region for the current signed in user to the document.
        ' 
        ' Item: 'For [Current User]' of the 'Add' drop down menu ('Add' is an item of the 'Editable Regions'  
        '		 drop down menu)
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_EditableRegions_Add_ForCurrentUser_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim arAddResult As EditableRegionCollection.AddResult = m_txTextControl.EditableRegions.Add(New EditableRegion(m_strUserName, 0))
            HandleAddEditableRegionFailure(arAddResult)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_EditableRegions_Add_ForEveryone_Click Handler
        '
        ' Adds an editable region for every user to the document.
        ' 
        ' Item: 'For Everyone' of the 'Add' drop down menu ('Add' is an item of the 'Editable Regions'  
        '		 drop down menu)
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_EditableRegions_Add_ForEveryone_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim arAddResult As EditableRegionCollection.AddResult = m_txTextControl.EditableRegions.Add(New EditableRegion("", 0))
            HandleAddEditableRegionFailure(arAddResult)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_EditableRegions_Remove_ForCurrentUser_Click Handler
        '
        ' Removes the editable region for the current signed in user from the document.
        ' 
        ' Item: 'For [Current User]' of the 'Remove' drop down menu ('Remove' is an item of the 'Editable Regions'  
        '		 drop down menu)
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_EditableRegions_Remove_ForCurrentUser_Click(ByVal sender As Object, ByVal e As EventArgs)
            RemoveUser(m_strUserName)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_EditableRegions_Remove_ForEveryone_Click Handler
        '
        ' Removes the editable region for every user from the document.
        ' 
        ' Item: 'For Everyone' of the 'Remove' drop down menu ('Remove' is an item of the 'Editable Regions'  
        '		 drop down menu)
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_EditableRegions_Remove_ForEveryone_Click(ByVal sender As Object, ByVal e As EventArgs)
            RemoveUser("")
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_ProtectDocument_Click Handler
        '
        ' Sets a value indicating whether the document's text is protected, or can be freely edited and formatted.
        ' 
        ' Item: 'Protect Document'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_ProtectDocument_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.EditMode = If(m_tmiEdit_ProtectDocument.Checked, EditMode.ReadAndSelect Or EditMode.UsePassword, EditMode.Edit)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_TrackedChanges_TrackChanges_Click Handler
        '
        ' Sets a value indicating whether track changes is active or not. When this property is true, new changes 
        ' made to the document are marked up. 
        ' 
        ' Item: 'Track Changes' of the 'Tracked Changes' drop down menu
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_TrackedChanges_TrackChanges_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.IsTrackChangesEnabled = m_tmiEdit_TrackedChanges_TrackChanges.Checked
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_TrackedChanges_ReviewTrackedChanges_Click Handler
        '
        ' Opens a modeless dialog that reviews the tracked changes of the document.
        ' 
        ' Item: 'Review Tracked Changes...' of the 'Tracked Changes' drop down menu
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_TrackedChanges_ReviewTrackedChanges_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgTrackedChanges As TrackedChangesDialog = New TrackedChangesDialog(m_txTextControl) With {
                .Owner = Me
            }
            dlgTrackedChanges.Show()
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_Comments_AddComment_Click Handler
        '
        ' Opens the comment input control to add a new comment to the document.
        ' 
        ' Item: 'Add Comment...' of the 'Comments' drop down menu
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_Comments_AddComment_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim arAddResult As CommentCollection.AddResult = m_txTextControl.Comments.Add()
            HandleAddCommentFailure(arAddResult)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_Comments_ReviewComments_Click Handler
        '
        ' Opens a modeless dialog that reviews the comments of the document.
        ' 
        ' Item: 'Review Comments...' of the 'Comments' drop down menu
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_Comments_ReviewComments_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgComments As CommentsDialog = New CommentsDialog(m_txTextControl) With {
                .Owner = Me
            }
            dlgComments.Show()
        End Sub
    End Class
End Namespace
