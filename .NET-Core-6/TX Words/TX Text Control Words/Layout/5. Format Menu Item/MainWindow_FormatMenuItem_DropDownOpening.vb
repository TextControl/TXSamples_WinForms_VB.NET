'-----------------------------------------------------------------------------------------------------------
' MainWindow_FormatMenuItem_DropDownOpening.vb File
'
' Description: Provides all DropDownOpening handlers associated with 'Format' menu items.
'     
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------

Namespace TXTextControl.Words
    Partial Class MainWindow
        '-----------------------------------------------------------------------------------------------------------
        ' Format_DropDownOpening Handler
        '
        ' Updates the enabled state of 'Format' drop down menu items.
        ' 
        ' Item: 'Format'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Format_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs)
            Dim bCanEdit As Boolean = m_txTextControl.CanEdit
            Dim fbFrame As FrameBase = If(bCanEdit, m_txTextControl.Frames.GetItem(), Nothing)

            ' 'Character...', 
            m_tmiFormat_Character.Enabled = m_txTextControl.CanCharacterFormat

            ' 'Paragraph...'
            m_tmiFormat_Paragraph.Enabled = m_txTextControl.CanParagraphFormat

            ' 'Styles...'
            m_tmiFormat_Styles.Enabled = m_txTextControl.CanStyleFormat

            ' 'Image...'
            m_tmiFormat_Image.Enabled = TypeOf fbFrame Is Image

            ' 'Text Frame...'
            m_tmiFormat_TextFrame.Enabled = TypeOf fbFrame Is TextFrame

            If m_plTXLicense >= VersionInfo.ProductLevel.Professional Then
                ' 'Shape...'
                m_tmiFormat_Shape.Enabled = EnableShapeItem(fbFrame)
            End If

            ' 'Barcode...'
            m_tmiFormat_Barcode.Enabled = TypeOf fbFrame Is DataVisualization.BarcodeFrame

            ' 'Headers and Footers...'
            m_tmiFormat_HeadersAndFooters.Enabled = bCanEdit

            If m_plTXLicense >= VersionInfo.ProductLevel.Professional Then
                ' 'Page Number...'
                Dim hfHeaderFooter As HeaderFooter = TryCast(m_txTextControl.TextParts.GetItem(), HeaderFooter)
                m_tmiFormat_PageNumberField.Enabled = bCanEdit AndAlso hfHeaderFooter IsNot Nothing AndAlso hfHeaderFooter.PageNumberFields.GetItem() IsNot Nothing
            End If

            If m_plTXLicense >= VersionInfo.ProductLevel.Professional Then
                ' 'Hyperlink...'
                Dim colHyperTextLinks As HypertextLinkCollection = m_txTextControl.HypertextLinks
                m_tmiFormat_Hyperlink.Enabled = bCanEdit AndAlso (colHyperTextLinks.GetItem() IsNot Nothing OrElse m_txTextControl.DocumentLinks.GetItem() IsNot Nothing)

                ' 'Bookmark...'
                Dim colDocumentTargets As DocumentTargetCollection = m_txTextControl.DocumentTargets
                m_tmiFormat_Bookmark.Enabled = bCanEdit AndAlso colDocumentTargets.GetItem() IsNot Nothing
            End If

            If m_plTXLicense >= VersionInfo.ProductLevel.Enterprise Then
                ' 'Table of Contents...'
                Dim bInsideTOC As Boolean = m_txTextControl.TablesOfContents.GetItem() IsNot Nothing
                m_tmiFormat_TableOfContents.Enabled = bCanEdit AndAlso bInsideTOC
            End If

            ' 'Columns...'
            m_tmiFormat_Columns.Enabled = bCanEdit

            ' 'Page Borders...'
            m_tmiFormat_PageBorders.Enabled = bCanEdit

            ' 'Page Color...'
            m_tmiFormat_PageColor.Enabled = bCanEdit

            ' 'Tabs...'
            m_tmiFormat_Tabs.Enabled = bCanEdit

            ' 'Language...'
            m_tmiFormat_Language.Enabled = bCanEdit
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Format_ParagraphStructureLevels_DropDownOpening Handler
        '
        ' Updates the text of the '[Current Paragraph Style]' item.
        ' 
        ' Item: 'Paragraph Structure Levels'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Format_ParagraphStructureLevels_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs)
            If m_plTXLicense >= VersionInfo.ProductLevel.Enterprise Then
                ' Get the current style name
                Dim strStyleName As String = m_txTextControl.InputFormat.StyleName

                ' Determine current paragraph style
                Dim psCurrentStyle As ParagraphStyle = m_txTextControl.ParagraphStyles.GetItem(strStyleName)

                ' If no paragraph style could be determined, use the default "[Normal]" style.
                If psCurrentStyle Is Nothing Then
                    strStyleName = "[Normal]"
                    psCurrentStyle = m_txTextControl.ParagraphStyles.GetItem(strStyleName)
                End If

                ' Provide the paragraph style by using the item's Tag property.
                m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle.Tag = psCurrentStyle

                ' Display the paragraph style name as item text.
                m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle.Text = String.Format(My.Resources.Item_Format_ParagraphStructureLevels_CurrentParagraphStyle_Text, strStyleName)
            End If
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Format_ParagraphStructureLevels_CurrentParagraphStyle_DropDownOpening Handler
        '
        ' Updates the checked and enabled state of the '[Current Paragraph Style]' drop down menu items.
        ' 
        ' Item: '[Current Paragraph Style]' of the 'Paragraph Structure Levels' drop down menu
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Format_ParagraphStructureLevels_CurrentParagraphStyle_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs)
            ' Get the corresponding paragraph style.
            Dim psParagraphStyle As ParagraphStyle = TryCast(m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle.Tag, ParagraphStyle)
            If psParagraphStyle IsNot Nothing Then
                ' Get name and structure level of that style.
                Dim strStyleName As String = psParagraphStyle.Name
                Dim iStructureLevel As Integer = psParagraphStyle.ParagraphFormat.StructureLevel

                ' The strucure levels of the table of contents styles ("TOC_Title" and "TOC_Level") cannot be edited.
                Dim bCanEdit As Boolean = m_txTextControl.CanEdit AndAlso Not (Equals(strStyleName, "TOC_Title") OrElse strStyleName.StartsWith("TOC_Level"))

                ' Step through all structure level drop down items and handle their Enabled and Check properties.
                For Each item As ToolStripMenuItem In m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle.DropDownItems
                    item.Enabled = bCanEdit
                    item.Checked = Integer.Parse(item.Tag.ToString()) = iStructureLevel
                Next
            End If
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Format_ParagraphStructureLevels_AddToParagraph_DropDownOpening Handler
        '
        ' Updates the checked and enabled state of the 'Add to Paragaph' drop down menu items.
        ' 
        ' Item: 'Add to Paragaph' of the 'Paragraph Structure Levels' drop down menu
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Format_ParagraphStructureLevels_AddToParagraph_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs)
            ' Check whether the items should be enabled.
            Dim bCanEdit As Boolean = m_txTextControl.CanEdit

            ' Get the current paragraph's structure level.
            Dim iStructureLevel As Integer? = m_txTextControl.InputFormat.StructureLevel
            iStructureLevel = If(iStructureLevel.HasValue, iStructureLevel.Value, -1)

            ' Step through all structure level drop down items and handle their Enabled and Check properties.
            For Each item As ToolStripMenuItem In m_tmiFormat_ParagraphStructureLevels_AddToParagraph.DropDownItems
                item.Enabled = bCanEdit
                item.Checked = CBool(Integer.Parse(item.Tag.ToString()) = iStructureLevel)
            Next
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Format_BulletsAndNumbering_DropDownOpening Handler
        '
        ' Updates the enabled and checked state of 'Bullets and Numbering' drop down menu items.
        ' 
        ' Item: 'Bullets and Numbering'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Format_BulletsAndNumbering_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs)
            ' Get list format
            Dim lfListFormat As ListFormat
            lfListFormat = m_txTextControl.Selection.ListFormat

            ' Check list format type
            Dim bIsList As Boolean
            bIsList = lfListFormat.Type <> ListType.None
            Dim bIsBulleted As Boolean
            bIsBulleted = lfListFormat.Type = ListType.Bulleted
            Dim bIsStructured As Boolean
            bIsStructured = lfListFormat.Type = ListType.Structured

            ' Get number format
            Dim fnNumberFormat As NumberFormat
            fnNumberFormat = lfListFormat.NumberFormat
            Dim bCanCharacterFormat As Boolean
            bCanCharacterFormat = m_txTextControl.CanCharacterFormat

            ' Set items Enabled states
            m_tmiFormat_BulletsAndNumbering_ArabicNumbers.Enabled = CSharpImpl.Assign(m_tmiFormat_BulletsAndNumbering_CapitalLetters.Enabled, CSharpImpl.Assign(m_tmiFormat_BulletsAndNumbering_Letters.Enabled, CSharpImpl.Assign(m_tmiFormat_BulletsAndNumbering_RomanNumbers.Enabled, CSharpImpl.Assign(m_tmiFormat_BulletsAndNumbering_SmallRomanNumbers.Enabled, CSharpImpl.Assign(m_tmiFormat_BulletsAndNumbering_AsStructuredList.Enabled, CSharpImpl.Assign(m_tmiFormat_BulletsAndNumbering_Bullets.Enabled, bCanCharacterFormat))))))                     ' '1, 2, 3'		
            ' 'A, B, C'
            ' 'a, b, c'
            ' 'I, II, III, IV'
            ' 'i, ii, iii, iv'
            ' 'As structured List'
            ' 'Bullets'

            ' 'Increase Level'
            m_tmiFormat_BulletsAndNumbering_IncreaseLevel.Enabled = bIsList AndAlso bCanCharacterFormat

            ' 'Decrease Level'
            m_tmiFormat_BulletsAndNumbering_DecreaseLevel.Enabled = bIsList AndAlso bCanCharacterFormat AndAlso m_txTextControl.Selection.ListFormat.Level >= 2

            ' 'Properties...'
            m_tmiFormat_BulletsAndNumbering_Properties.Enabled = bCanCharacterFormat

            ' Set items Checked states
            m_tmiFormat_BulletsAndNumbering_ArabicNumbers.Checked = bIsList AndAlso Not bIsBulleted AndAlso fnNumberFormat = NumberFormat.ArabicNumbers            ' '1, 2, 3'
            m_tmiFormat_BulletsAndNumbering_CapitalLetters.Checked = bIsList AndAlso Not bIsBulleted AndAlso fnNumberFormat = NumberFormat.CapitalLetters          ' 'A, B, C'
            m_tmiFormat_BulletsAndNumbering_Letters.Checked = bIsList AndAlso Not bIsBulleted AndAlso fnNumberFormat = NumberFormat.Letters                        ' 'a, b, c'
            m_tmiFormat_BulletsAndNumbering_RomanNumbers.Checked = bIsList AndAlso Not bIsBulleted AndAlso fnNumberFormat = NumberFormat.RomanNumbers              ' 'I, II, III, IV'
            m_tmiFormat_BulletsAndNumbering_SmallRomanNumbers.Checked = bIsList AndAlso Not bIsBulleted AndAlso fnNumberFormat = NumberFormat.SmallRomanNumbers    ' 'i, ii, iii, iv'
            m_tmiFormat_BulletsAndNumbering_AsStructuredList.Checked = bIsStructured   ' 'As structured List'
            m_tmiFormat_BulletsAndNumbering_Bullets.Checked = bIsBulleted              ' 'Bullets'
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Format_FormFields_DropDownOpening Handler
        '
        ' Updates the enabled and checked state of 'Form Fields' drop down menu items.
        ' 
        ' Item: 'Form Fields'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Format_FormFields_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs)
            If m_plTXLicense >= VersionInfo.ProductLevel.Enterprise Then
                Dim bCanEdit As Boolean = m_txTextControl.CanEdit
                ' 'Form Fields...'
                Dim colFormFields As FormFieldCollection = m_txTextControl.FormFields
                m_tmiFormat_FormFields_Edit.Enabled = bCanEdit AndAlso colFormFields.GetItem() IsNot Nothing

                ' 'Form Validation'
                m_tmiFormat_FormFields_EnableFormValidation.Enabled = bCanEdit AndAlso colFormFields.Count > 0
                m_tmiFormat_FormFields_EnableFormValidation.Checked = CSharpImpl.Assign(m_tmiFormat_FormFields_ManageConditionalInstructions.Enabled, m_txTextControl.IsFormFieldValidationEnabled)
            End If
        End Sub
    End Class
End Namespace
