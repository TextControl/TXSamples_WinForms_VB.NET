'-----------------------------------------------------------------------------------------------------------
' MainWindow_EditMenuItem.vb File
'
' Description: Provides methods to set the layout and behavior of the 'Edit' menu items.
'     
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Imports TXTextControl.Windows.Forms

Namespace TXTextControl.Words
    Partial Class MainWindow
        '-----------------------------------------------------------------------------------------------------------
        ' SetEditItemsTexts Method
        '
        ' Sets the texts of the 'Edit' menu items.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetEditItemsTexts()
            ' 'Edit'
            SetItemText(m_tmiEdit)

            ' 'Undo'
            SetItemText(m_tmiEdit_Undo)

            ' 'Redo'
            SetItemText(m_tmiEdit_Redo)

            ' 'Cut'
            SetItemText(m_tmiEdit_Cut)

            ' 'Copy'
            SetItemText(m_tmiEdit_Copy)

            ' 'Paste'
            SetItemText(m_tmiEdit_Paste)

            ' 'Select All'
            SetItemText(m_tmiEdit_SelectAll)

            ' 'Find...'
            SetItemText(m_tmiEdit_Find)

            ' 'Replace...'
            SetItemText(m_tmiEdit_Replace)

            ' 'Permissions'
            SetItemText(m_tmiEdit_Permissions)
            SetItemText(m_tmiEdit_Permissions_AllowFormatting)
            SetItemText(m_tmiEdit_Permissions_AllowFormattingStyles)
            SetItemText(m_tmiEdit_Permissions_AllowPrinting)
            SetItemText(m_tmiEdit_Permissions_AllowCopy)
            SetItemText(m_tmiEdit_Permissions_AllowEditingFormFields)
            SetItemText(m_tmiEdit_Permissions_ReadOnly)

            ' 'Editable Regions'
            SetItemText(m_tmiEdit_EditableRegions)
            SetItemText(m_tmiEdit_EditableRegions_Add)
            SetItemText(m_tmiEdit_EditableRegions_Add_ForCurrentUser, m_strUserName)
            SetItemText(m_tmiEdit_EditableRegions_Add_ForEveryone)
            SetItemText(m_tmiEdit_EditableRegions_Remove)
            SetItemText(m_tmiEdit_EditableRegions_Remove_ForCurrentUser, m_strUserName)
            SetItemText(m_tmiEdit_EditableRegions_Remove_ForEveryone)

            ' 'Protect Document'
            SetItemText(m_tmiEdit_ProtectDocument)

            ' 'Tracked Changes'
            SetItemText(m_tmiEdit_TrackedChanges)
            SetItemText(m_tmiEdit_TrackedChanges_TrackChanges)
            SetItemText(m_tmiEdit_TrackedChanges_ReviewTrackedChanges)

            ' 'Comments'
            SetItemText(m_tmiEdit_Comments)
            SetItemText(m_tmiEdit_Comments_AddComment)
            SetItemText(m_tmiEdit_Comments_ReviewComments)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' SetEditItemsImages Method
        '
        ' Sets the images of the 'Edit' menu items.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetEditItemsImages()
            ' 'Undo'
            SetItemImage(m_tmiEdit_Undo, ResourceProvider.GeneralItem.TXITEM_Undo.ToString())

            ' 'Redo'
            SetItemImage(m_tmiEdit_Redo, ResourceProvider.GeneralItem.TXITEM_Redo.ToString())

            ' 'Cut'
            SetItemImage(m_tmiEdit_Cut, Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_Cut.ToString())

            ' 'Copy'
            SetItemImage(m_tmiEdit_Copy, Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_Copy.ToString())

            ' 'Paste'
            SetItemImage(m_tmiEdit_Paste, Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_Paste.ToString())

            ' 'Select All'
            SetItemImage(m_tmiEdit_SelectAll, Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_SelectAll.ToString())

            ' 'Find...'
            SetItemImage(m_tmiEdit_Find, Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_Find.ToString())

            ' 'Replace...'
            SetItemImage(m_tmiEdit_Replace, Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_Replace.ToString())

            ' 'Permissions'
            SetItemImage(m_tmiEdit_Permissions, Ribbon.RibbonPermissionsTab.RibbonItem.TXITEM_ReadOnly.ToString())
            SetItemImage(m_tmiEdit_Permissions_AllowFormatting, Ribbon.RibbonPermissionsTab.RibbonItem.TXITEM_AllowFormatting.ToString())
            SetItemImage(m_tmiEdit_Permissions_AllowFormattingStyles, Ribbon.RibbonPermissionsTab.RibbonItem.TXITEM_AllowFormattingStyles.ToString())
            SetItemImage(m_tmiEdit_Permissions_AllowPrinting, Ribbon.RibbonPermissionsTab.RibbonItem.TXITEM_AllowPrinting.ToString())
            SetItemImage(m_tmiEdit_Permissions_AllowCopy, Ribbon.RibbonPermissionsTab.RibbonItem.TXITEM_AllowCopy.ToString())
            SetItemImage(m_tmiEdit_Permissions_AllowEditingFormFields, Ribbon.RibbonPermissionsTab.RibbonItem.TXITEM_FillInFormFields.ToString())
            SetItemImage(m_tmiEdit_Permissions_ReadOnly, Ribbon.RibbonPermissionsTab.RibbonItem.TXITEM_ReadOnly.ToString())

            ' 'Editable Regions'
            SetItemImage(m_tmiEdit_EditableRegions, Ribbon.RibbonPermissionsTab.RibbonItem.TXITEM_HighlightEditableRegions.ToString())

            ' 'Protect Document'
            SetItemImage(m_tmiEdit_ProtectDocument, Ribbon.RibbonPermissionsTab.RibbonItem.TXITEM_EnforceProtection.ToString())

            ' 'Tracked Changes'
            SetItemImage(m_tmiEdit_TrackedChanges, Ribbon.RibbonProofingTab.RibbonItem.TXITEM_TrackChanges.ToString())
            SetItemImage(m_tmiEdit_TrackedChanges_TrackChanges, Ribbon.RibbonProofingTab.RibbonItem.TXITEM_TrackChanges.ToString())
            SetItemImage(m_tmiEdit_TrackedChanges_ReviewTrackedChanges, Ribbon.RibbonProofingTab.RibbonItem.TXITEM_TrackedChanges.ToString())

            ' 'Comments'
            SetItemImage(m_tmiEdit_Comments, Ribbon.RibbonProofingTab.RibbonItem.TXITEM_EditComment.ToString())
            SetItemImage(m_tmiEdit_Comments_AddComment, Ribbon.RibbonProofingTab.RibbonItem.TXITEM_AddComment.ToString())
            SetItemImage(m_tmiEdit_Comments_ReviewComments, Ribbon.RibbonProofingTab.RibbonItem.TXITEM_Comments_Sidebars.ToString())
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' ConnectEditItemsHandlers Method
        '
        ' Connects the 'Edit' menu items to Click and DropDownOpening handlers.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub ConnectEditItemsHandlers()
            ' Click Handlers:

            ' 'Undo'
            AddHandler m_tmiEdit_Undo.Click, AddressOf Edit_Undo_Click

            ' 'Redo'
            AddHandler m_tmiEdit_Redo.Click, AddressOf Edit_Redo_Click

            ' 'Cut'
            AddHandler m_tmiEdit_Cut.Click, AddressOf Edit_Cut_Click

            ' 'Copy'
            AddHandler m_tmiEdit_Copy.Click, AddressOf Edit_Copy_Click

            ' 'Paste'
            AddHandler m_tmiEdit_Paste.Click, AddressOf Edit_Paste_Click

            ' 'Select All'
            AddHandler m_tmiEdit_SelectAll.Click, AddressOf Edit_SelectAll_Click

            ' 'Find...'
            AddHandler m_tmiEdit_Find.Click, AddressOf Edit_Find_Click

            ' 'Replace...'
            AddHandler m_tmiEdit_Replace.Click, AddressOf Edit_Replace_Click

            ' 'Permissions'
            AddHandler m_tmiEdit_Permissions_AllowFormatting.Click, AddressOf Edit_Permissions_AllowFormatting_Click
            AddHandler m_tmiEdit_Permissions_AllowFormattingStyles.Click, AddressOf Edit_Permissions_AllowFormattingStyles_Click
            AddHandler m_tmiEdit_Permissions_AllowPrinting.Click, AddressOf Edit_Permissions_AllowPrinting_Click
            AddHandler m_tmiEdit_Permissions_AllowCopy.Click, AddressOf Edit_Permissions_AllowCopy_Click
            AddHandler m_tmiEdit_Permissions_AllowEditingFormFields.Click, AddressOf Edit_Permissions_AllowEditingFormFields_Click
            AddHandler m_tmiEdit_Permissions_ReadOnly.Click, AddressOf Edit_Permissions_ReadOnly_Click

            ' 'Editable Regions'
            AddHandler m_tmiEdit_EditableRegions_Add_ForCurrentUser.Click, AddressOf Edit_EditableRegions_Add_ForCurrentUser_Click
            AddHandler m_tmiEdit_EditableRegions_Add_ForEveryone.Click, AddressOf Edit_EditableRegions_Add_ForEveryone_Click

            AddHandler m_tmiEdit_EditableRegions_Remove_ForCurrentUser.Click, AddressOf Edit_EditableRegions_Remove_ForCurrentUser_Click
            AddHandler m_tmiEdit_EditableRegions_Remove_ForEveryone.Click, AddressOf Edit_EditableRegions_Remove_ForEveryone_Click

            ' 'Protect Document'
            AddHandler m_tmiEdit_ProtectDocument.Click, AddressOf Edit_ProtectDocument_Click

            ' 'Tracked Changes'
            AddHandler m_tmiEdit_TrackedChanges_TrackChanges.Click, AddressOf Edit_TrackedChanges_TrackChanges_Click
            AddHandler m_tmiEdit_TrackedChanges_ReviewTrackedChanges.Click, AddressOf Edit_TrackedChanges_ReviewTrackedChanges_Click

            ' 'Comments'
            AddHandler m_tmiEdit_Comments_AddComment.Click, AddressOf Edit_Comments_AddComment_Click
            AddHandler m_tmiEdit_Comments_ReviewComments.Click, AddressOf Edit_Comments_ReviewComments_Click


            ' DropDownOpening Handlers

            ' 'Edit'
            AddHandler m_tmiEdit.DropDownOpening, AddressOf Edit_DropDownOpening

            ' 'Permissions'
            AddHandler m_tmiEdit_Permissions.DropDownOpening, AddressOf Edit_Permissions_DropDownOpening

            ' 'Editable Regions'
            AddHandler m_tmiEdit_EditableRegions_Add.DropDownOpening, AddressOf Edit_EditableRegions_Add_DropDownOpening
            AddHandler m_tmiEdit_EditableRegions_Remove.DropDownOpening, AddressOf Edit_EditableRegions_Remove_DropDownOpening
        End Sub
    End Class
End Namespace
