'-----------------------------------------------------------------------------------------------------------
' MainWindow_EditMenuItem_DropDownOpening.vb File
'
' Description: Provides all DropDownOpening handlers associated with 'Edit' menu items.
'     
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------

Namespace TXTextControl.Words
    Partial Class MainWindow
        '-----------------------------------------------------------------------------------------------------------
        ' Edit_DropDownOpening Handler
        '
        ' Updates the enabled state and texts of 'Edit' drop down menu items.
        ' 
        ' Item: 'Edit'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs)
            ' Get some current TextControl states
            Dim bCanCopy As Boolean = m_txTextControl.CanCopy
            Dim bCanEdit As Boolean = m_txTextControl.CanEdit
            Dim emEditMode As EditMode = m_txTextControl.EditMode

            ' 'Undo'
            UpdateUndoText()
            m_tmiEdit_Undo.Enabled = m_txTextControl.CanUndo

            ' 'Redo'
            UpdateRedoText()
            m_tmiEdit_Redo.Enabled = m_txTextControl.CanRedo

            ' 'Cut'
            m_tmiEdit_Cut.Enabled = bCanCopy AndAlso bCanEdit

            ' 'Copy'
            m_tmiEdit_Copy.Enabled = bCanCopy

            ' 'Paste'
            m_tmiEdit_Paste.Enabled = m_txTextControl.CanPaste

            ' 'Select All'
            m_tmiEdit_SelectAll.Enabled = bCanEdit OrElse emEditMode = EditMode.ReadAndSelect

            ' 'Replace...'
            m_tmiEdit_Replace.Enabled = bCanEdit

            ' 'Protect Document'
            m_tmiEdit_ProtectDocument.Checked = emEditMode = EditMode.ReadAndSelect OrElse emEditMode = EditMode.ReadOnly

            ' 'Tracked Changes'
            m_tmiEdit_TrackedChanges.Enabled = bCanEdit

            ' 'Comments'
            m_tmiEdit_Comments.Enabled = bCanEdit
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_Permissions_DropDownOpening Handler
        '
        ' Updates the enabled and checked state of 'Permissions' drop down menu items.
        ' 
        ' Item: 'Permissions'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_Permissions_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs)
            ' Get current document permissions
            Dim dpDocumentPermissions As TXTextControl.DocumentPermissions
            dpDocumentPermissions = m_txTextControl.DocumentPermissions

            ' Check the 'Permissions' drop down items

            ' Because formatting is not allowed in a read only document even if the corresponding document
            ' permissions are set, the corresponding items are unchecked when the DocumentPermissions.ReadOnly
            ' is set to true.
            Dim bIsReadOnly As Boolean
            bIsReadOnly = dpDocumentPermissions.ReadOnly
            m_tmiEdit_Permissions_AllowFormatting.Checked = Not bIsReadOnly AndAlso dpDocumentPermissions.AllowFormatting
            m_tmiEdit_Permissions_AllowFormattingStyles.Checked = Not bIsReadOnly AndAlso dpDocumentPermissions.AllowFormattingStyles
            m_tmiEdit_Permissions_AllowPrinting.Checked = dpDocumentPermissions.AllowPrinting
            m_tmiEdit_Permissions_AllowCopy.Checked = dpDocumentPermissions.AllowCopy
            m_tmiEdit_Permissions_AllowEditingFormFields.Checked = dpDocumentPermissions.AllowEditingFormFields
            m_tmiEdit_Permissions_ReadOnly.Checked = bIsReadOnly

            ' Set the enable states of the 'Permissions' drop down items
            Dim bIsProtectedDocument As Boolean
            bIsProtectedDocument = m_tmiEdit_ProtectDocument.Checked
            m_tmiEdit_Permissions_AllowFormatting.Enabled = CSharpImpl.Assign(m_tmiEdit_Permissions_AllowFormattingStyles.Enabled, Not bIsReadOnly AndAlso Not bIsProtectedDocument)
            m_tmiEdit_Permissions_AllowPrinting.Enabled = CSharpImpl.Assign(m_tmiEdit_Permissions_AllowCopy.Enabled, CSharpImpl.Assign(m_tmiEdit_Permissions_AllowEditingFormFields.Enabled, CSharpImpl.Assign(m_tmiEdit_Permissions_ReadOnly.Enabled, Not bIsProtectedDocument)))
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_EditableRegions_Add_DropDownOpening Handler
        '
        ' Updates the enabled state of 'Add' drop down menu items.
        ' 
        ' Item: 'Add' of the 'Editable Regions' drop down menu
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_EditableRegions_Add_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs)
            If m_plTXLicense >= VersionInfo.ProductLevel.Professional Then
                ' Set the enabled states of the 'Add' drop down items
                Dim colEditableRegions As EditableRegionCollection = m_txTextControl.EditableRegions
                Dim rerCurrentEditableRegions As EditableRegion() = colEditableRegions.GetItems()
                ' The 'For [Current User]' item is enabled if the current user is signed in and 
                ' no editable region was defined for the current user at the input position.
                m_tmiEdit_EditableRegions_Add_ForCurrentUser.Enabled = m_uiCurrentUser IsNot Nothing AndAlso m_uiCurrentUser.IsSignedIn AndAlso (rerCurrentEditableRegions Is Nothing OrElse GetEditableRegion(m_strUserName, rerCurrentEditableRegions) Is Nothing)
                ' The 'For Everyone' item is enabled if no corresponding editable region was
                ' at the current input position.
                m_tmiEdit_EditableRegions_Add_ForEveryone.Enabled = rerCurrentEditableRegions Is Nothing OrElse GetEditableRegion("", rerCurrentEditableRegions) Is Nothing
            End If
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Edit_EditableRegions_Remove_DropDownOpening Handler
        '
        ' Updates the enabled state of 'Remove' drop down menu items.
        ' 
        ' Item: 'Remove' of the 'Editable Regions' drop down menu
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Edit_EditableRegions_Remove_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs)
            If m_plTXLicense >= VersionInfo.ProductLevel.Professional Then
                ' Set the enabled states of the 'Remove' drop down items
                Dim colEditableRegions As EditableRegionCollection = m_txTextControl.EditableRegions
                Dim rerCurrentEditableRegions As EditableRegion() = colEditableRegions.GetItems()
                ' The 'For [Current User]' item is enabled if the current user is signed in and 
                ' an editable region was defined for the current user at the input position.
                m_tmiEdit_EditableRegions_Remove_ForCurrentUser.Enabled = m_uiCurrentUser IsNot Nothing AndAlso m_uiCurrentUser.IsSignedIn AndAlso rerCurrentEditableRegions IsNot Nothing AndAlso GetEditableRegion(m_strUserName, rerCurrentEditableRegions) IsNot Nothing
                ' The 'For Everyone' item is enabled if a corresponding editable region was
                ' at the current input position.
                m_tmiEdit_EditableRegions_Remove_ForEveryone.Enabled = rerCurrentEditableRegions IsNot Nothing AndAlso GetEditableRegion("", rerCurrentEditableRegions) IsNot Nothing
            End If
        End Sub
    End Class
End Namespace
