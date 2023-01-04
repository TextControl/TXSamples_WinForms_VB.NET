'-----------------------------------------------------------------------------------------------------------
' MainWindow_RibbonFormFieldsTab_Preview.vb File
'
' Description:
'     Adds and manages a conditional instructions preview button.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Imports TXTextControl.Windows.Forms.Ribbon

Namespace TXTextControl.Words
    Partial Class MainWindow
        '-----------------------------------------------------------------------------------------------------------
        ' M E M B E R   V A R I A B L E S
        '-----------------------------------------------------------------------------------------------------------

        Private m_rtbtnPreviewConditionalInstructions As RibbonToggleButton = Nothing
        Private m_rbtnEnableFormValidation As RibbonToggleButton = Nothing
        Private m_bIsPreviewActivated As Boolean = False
        Private m_rbtTextControlContent As Byte() = Nothing
        Private m_bAllowEditinFormFieldsTemp As Boolean = False
        Private m_bReadOnlyTemp As Boolean = False


        '-----------------------------------------------------------------------------------------------------------
        ' H A N D L E R S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' PreviewConditionalInstructions_CheckedChanged Handler
        ' Activates or deactivates the conditional instructions preview.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub PreviewConditionalInstructions_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If m_rtbtnPreviewConditionalInstructions.Checked Then
                ActivateCIPreview()
            Else
                DeactivateCIPreview(True)
            End If
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' TXITEM_EnableFormValidation_CheckedChanged Handler
        ' Handles the enabled state of the preview button  if the preview is not activated and the TextControl can be 
        ' edited.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub TXITEM_EnableFormValidation_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' Only handle the enabled state of the preview button if the preview is not activated
            ' and the TextControl can be edited.
            If Not m_bIsPreviewActivated AndAlso m_txTextControl.EditMode = EditMode.Edit Then
                m_rtbtnPreviewConditionalInstructions.Enabled = m_rbtnEnableFormValidation.Checked
            End If
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' FormFields_TextControl_ContentChanged Handler
        ' Deactivates the conditional instructions preview when a new document is loaded or the TextControl content
        ' is reset by the TextControl.ResetContents method.
        ' In case the preview is not activated, the handler updates the enabled state of the preview button.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub FormFields_TextControl_ContentChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not m_bIsPreviewActivated Then
                m_rtbtnPreviewConditionalInstructions.Enabled = m_txTextControl.EditMode = EditMode.Edit AndAlso m_txTextControl.IsFormFieldValidationEnabled
            Else
                DeactivateCIPreview(False)
            End If
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' EnforceProtection_Click Handler
        ' Deactivates the conditional instructions preview when the PermissionsTab's 'Enforce Protection' button was
        ' clicked and TextControl.EditMode property value was changed to EditMode.Edit.
        ' In case the preview is not activated, the handler updates the enabled state of the preview button.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub EnforceProtection_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim bCanEdit = m_txTextControl.EditMode = EditMode.Edit
            If Not m_bIsPreviewActivated Then
                m_rtbtnPreviewConditionalInstructions.Enabled = bCanEdit AndAlso m_txTextControl.IsFormFieldValidationEnabled
            Else
                If bCanEdit Then
                    DeactivateCIPreview(True)
                End If
            End If
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' M E T H O D S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' AddPreviewCondtionalInstructionButton Method
        ' Adds a "Preview Conditional Instructions" button to the TXITEM_FormValidationGroup ribbon group.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub AddPreviewCondtionalInstructionsButton()
            ' Get the icons.
            Dim bmpSmallIcon = GetSmallIcon("PreviewFormFields_Small.svg")
            Dim bmpLargeIcon = GetLargeIcon("PreviewFormFields_Large.svg")

            ' Create the ribbon button
            m_rtbtnPreviewConditionalInstructions = New RibbonToggleButton() With {
                .Text = My.Resources.RibbonFormFieldsTab_PreviewConditionalInstructions,
                .SmallIcon = bmpSmallIcon,
                .LargeIcon = bmpLargeIcon,
                .KeyTip = My.Resources.RibbonFormFieldsTab_PreviewConditionalInstructions_KeyTip,
                .Enabled = m_txTextControl.IsFormFieldValidationEnabled
            }

            ' Add tool tips
            m_rtbtnPreviewConditionalInstructions.ToolTip.Title = My.Resources.RibbonFormFieldsTab_PreviewConditionalInstructions_ToolTip_Title
            m_rtbtnPreviewConditionalInstructions.ToolTip.Description = My.Resources.RibbonFormFieldsTab_PreviewConditionalInstructions_ToolTip_Description

            ' Add the handler that activates or deactivates the conditional instructions preview. 
            AddHandler m_rtbtnPreviewConditionalInstructions.Click, AddressOf PreviewConditionalInstructions_CheckedChanged

            ' Add the ribbon button to the TXITEM_FormValidationGroup ribbon group.
            Dim rgFormValidationGroup As RibbonGroup = TryCast(m_rtRibbonFormFieldsTab.FindItem(RibbonFormFieldsTab.RibbonItem.TXITEM_FormValidationGroup), RibbonGroup)
            rgFormValidationGroup.RibbonItems.Add(m_rtbtnPreviewConditionalInstructions)

            ' Add CheckedChanged event handler to the TXITEM_EnableFormValidation ribbon toggle button
            ' that handles the enabled state of the preview button when checked or unchecked.
            m_rbtnEnableFormValidation = TryCast(m_rtRibbonFormFieldsTab.FindItem(RibbonFormFieldsTab.RibbonItem.TXITEM_EnableFormValidation), RibbonToggleButton)
            AddHandler m_rbtnEnableFormValidation.CheckedChanged, AddressOf TXITEM_EnableFormValidation_CheckedChanged

            ' Add a TextControl PropertyChanged handler to update the TextControl and ribbon when the TextControl edit mode changed.
            AddHandler m_txTextControl.ContentsReset, AddressOf FormFields_TextControl_ContentChanged
            AddHandler m_txTextControl.DocumentLoaded, AddressOf FormFields_TextControl_ContentChanged
            Dim rtbtnEnforceProtection As RibbonToggleButton = TryCast(m_rtRibbonPermissionsTab.FindItem(RibbonPermissionsTab.RibbonItem.TXITEM_EnforceProtection), RibbonToggleButton)
            AddHandler rtbtnEnforceProtection.Click, AddressOf EnforceProtection_Click
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' ActivateCIPreview Method
        ' Activate the conditional instructions pzreview.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub ActivateCIPreview()
            ' Store the current TextControl content.
            m_txTextControl.Save(m_rbtTextControlContent, BinaryStreamType.InternalUnicodeFormat)

            ' Store the current DocumentPermissions.AllowEditingFormFields and .ReadOnly property values.
            m_bAllowEditinFormFieldsTemp = m_txTextControl.DocumentPermissions.AllowEditingFormFields
            m_bReadOnlyTemp = m_txTextControl.DocumentPermissions.ReadOnly

            ' Set those document permissions that are necessary to show a preview.
            m_txTextControl.DocumentPermissions.AllowEditingFormFields = True
            m_txTextControl.DocumentPermissions.ReadOnly = True

            ' Hide all ribbon groups behind the TXITEM_FormValidationGroup group
            For i = 3 To m_rtRibbonFormFieldsTab.RibbonGroups.Count - 1
                m_rtRibbonFormFieldsTab.RibbonGroups(i).Visible = False
            Next

            ' Activate the preview by setting the TextControl.EditMode property value to
            ' EditMode.ReadAndSelect.
            m_bIsPreviewActivated = True
            m_txTextControl.EditMode = EditMode.ReadAndSelect

            ' Disable the TXITEM_EnableFormValidation ribbon toggle button
            m_rbtnEnableFormValidation.Enabled = False
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' DeactivateCIPreview Method
        ' Deactivates the conditional instructions preview.
        '
        ' Parameters:
        '      reloadContent:		Indicates whether or not the stored TextControl content should be reloaded.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub DeactivateCIPreview(ByVal reloadContent As Boolean)
            ' Reset the preview button checked state
            m_rtbtnPreviewConditionalInstructions.Checked = False
            m_bIsPreviewActivated = False

            '  Enable the "Enable Form Validation" button.
            m_rbtnEnableFormValidation.Enabled = True

            ' Reset the Textcontrol content and permissions.
            If reloadContent Then
                ' Reload the Textcontrol content.
                m_txTextControl.Load(m_rbtTextControlContent, BinaryStreamType.InternalUnicodeFormat)
                m_rbtTextControlContent = Nothing

                ' Reset the DocumentPermissions.AllowEditingFormFields and .ReadOnly property values.
                m_txTextControl.DocumentPermissions.AllowEditingFormFields = m_bAllowEditinFormFieldsTemp
                m_txTextControl.DocumentPermissions.ReadOnly = m_bReadOnlyTemp
            End If
        End Sub
    End Class
End Namespace
