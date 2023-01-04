'-----------------------------------------------------------------------------------------------------------
' MainWindow_FormatMenuItem.vb File
'
' Description: Provides methods to set the layout and behavior of the 'Format' menu items.
'     
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------

Namespace TXTextControl.Words
    Partial Class MainWindow

        '-----------------------------------------------------------------------------------------------------------
        ' M E T H O D S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' SetFormatItemsTexts Method
        '
        ' Sets the texts of the 'Format' menu items.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetFormatItemsTexts()
            ' 'Format'
            SetItemText(m_tmiFormat)

            ' 'Character...'
            SetItemText(m_tmiFormat_Character)

            ' 'Paragraph...'
            SetItemText(m_tmiFormat_Paragraph)

            ' 'Styles...'
            SetItemText(m_tmiFormat_Styles)

            ' 'Paragraph Structure Levels'
            SetItemText(m_tmiFormat_ParagraphStructureLevels)
            SetItemText(m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_BodyText)
            SetItemText(m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle)

            ' Set texts of the 'Paragraph Style: [Current Paragraph Style]' item's 'Level' drop down items.
            Dim i As Integer
            For i = 1 To m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle.DropDownItems.Count - 1
                ' Get item.
                Dim tmiLevel As ToolStripItem = m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle.DropDownItems(i)
                ' Create accelerator string.
                Dim strLevel As String = If(i < 10, "&" & i, "1&0")
                ' Set text.
                SetItemText(tmiLevel, My.Resources.Item_Format_ParagraphStructureLevels_CurrentParagraphStyle_Level_Text, strLevel)
            Next

            SetItemText(m_tmiFormat_ParagraphStructureLevels_AddToParagraph)
            SetItemText(m_tmiFormat_ParagraphStructureLevels_AddToParagraph_BodyText)

            ' Set texts of the 'Add to Paragraph' item's 'Level' drop down items.
            For i = 1 To m_tmiFormat_ParagraphStructureLevels_AddToParagraph.DropDownItems.Count - 1
                ' Get item.
                Dim tmiLevel As ToolStripItem = m_tmiFormat_ParagraphStructureLevels_AddToParagraph.DropDownItems(i)
                ' Create accelerator string.
                Dim strLevel As String = If(i < 10, "&" & i, "1&0")
                ' Set text.
                SetItemText(tmiLevel, My.Resources.Item_Format_ParagraphStructureLevels_AddToParagraph_Level_Text, strLevel)
            Next

            ' 'Bullets and Numbering'
            SetItemText(m_tmiFormat_BulletsAndNumbering)
            SetItemText(m_tmiFormat_BulletsAndNumbering_ArabicNumbers)
            SetItemText(m_tmiFormat_BulletsAndNumbering_CapitalLetters)
            SetItemText(m_tmiFormat_BulletsAndNumbering_Letters)
            SetItemText(m_tmiFormat_BulletsAndNumbering_RomanNumbers)
            SetItemText(m_tmiFormat_BulletsAndNumbering_SmallRomanNumbers)
            SetItemText(m_tmiFormat_BulletsAndNumbering_AsStructuredList)
            SetItemText(m_tmiFormat_BulletsAndNumbering_Bullets)
            SetItemText(m_tmiFormat_BulletsAndNumbering_IncreaseLevel)
            SetItemText(m_tmiFormat_BulletsAndNumbering_DecreaseLevel)
            SetItemText(m_tmiFormat_BulletsAndNumbering_Properties)

            ' 'Image...'
            SetItemText(m_tmiFormat_Image)

            ' 'Text Frame...'
            SetItemText(m_tmiFormat_TextFrame)

            ' 'Shape...'
            SetItemText(m_tmiFormat_Shape)

            ' 'Barcode...'
            SetItemText(m_tmiFormat_Barcode)

            ' 'Headers and Footers...'
            SetItemText(m_tmiFormat_HeadersAndFooters)

            ' 'Page Number...'
            SetItemText(m_tmiFormat_PageNumberField)

            ' 'Form Fields'
            SetItemText(m_tmiFormat_FormFields)
            SetItemText(m_tmiFormat_FormFields_Edit)
            SetItemText(m_tmiFormat_FormFields_EnableFormValidation)
            SetItemText(m_tmiFormat_FormFields_ManageConditionalInstructions)

            ' 'Hyperlink...'
            SetItemText(m_tmiFormat_Hyperlink)

            ' 'Bookmark...'
            SetItemText(m_tmiFormat_Bookmark)

            ' 'Table of Contents...'
            SetItemText(m_tmiFormat_TableOfContents)

            ' 'Columns...'
            SetItemText(m_tmiFormat_Columns)

            ' 'Page Borders...'
            SetItemText(m_tmiFormat_PageBorders)

            ' 'Page Color...'
            SetItemText(m_tmiFormat_PageColor)

            ' 'Tabs...'
            SetItemText(m_tmiFormat_Tabs)

            ' 'Language...'
            SetItemText(m_tmiFormat_Language)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' SetFormatItemsImages Method
        '
        ' Sets the images of the 'Format' menu items.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetFormatItemsImages()
            ' 'Character...'
            SetItemImage(m_tmiFormat_Character, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_ChangeCase.ToString())

            ' 'Paragraph...'
            SetItemImage(m_tmiFormat_Paragraph, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_ControlChars.ToString())

            ' 'Styles...'
            SetItemImage(m_tmiFormat_Styles, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_StyleName.ToString())

            ' 'Paragraph Structure Levels'
            SetItemImage(m_tmiFormat_ParagraphStructureLevels, Windows.Forms.Ribbon.RibbonReferencesTab.RibbonItem.TXITEM_TOCMinimumStructureLevel.ToString())
            SetItemImage(m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_StyleName.ToString())
            SetItemImage(m_tmiFormat_ParagraphStructureLevels_AddToParagraph, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_ControlChars.ToString())

            ' 'Bullets and Numbering'
            SetItemImage(m_tmiFormat_BulletsAndNumbering, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_NumberedList.ToString())
            SetItemImage(m_tmiFormat_BulletsAndNumbering_AsStructuredList, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_StructuredList.ToString())
            SetItemImage(m_tmiFormat_BulletsAndNumbering_Bullets, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_BulletedList.ToString())
            SetItemImage(m_tmiFormat_BulletsAndNumbering_IncreaseLevel, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_IncreaseIndent.ToString())
            SetItemImage(m_tmiFormat_BulletsAndNumbering_DecreaseLevel, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_DecreaseIndent.ToString())
            SetItemImage(m_tmiFormat_BulletsAndNumbering_Properties, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_NumberedList.ToString())

            ' 'Image...'
            SetItemImage(m_tmiFormat_Image, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertImage.ToString())

            ' 'Text Frame...'
            SetItemImage(m_tmiFormat_TextFrame, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertTextFrame.ToString())

            ' 'Shape...'
            SetItemImage(m_tmiFormat_Shape, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertShape.ToString())

            ' 'Barcode...'
            SetItemImage(m_tmiFormat_Barcode, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertBarcode.ToString())

            ' 'Headers and Footers...'
            SetItemImage(m_tmiFormat_HeadersAndFooters, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertHeader.ToString())

            ' 'Page Number...'
            SetItemImage(m_tmiFormat_PageNumberField, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertPageNumber.ToString())

            ' 'Form Fields'
            SetItemImage(m_tmiFormat_FormFields, Windows.Forms.Ribbon.RibbonFormFieldsTab.RibbonItem.TXITEM_InsertComboBoxField.ToString())
            SetItemImage(m_tmiFormat_FormFields_Edit, Windows.Forms.Ribbon.RibbonFormFieldsTab.RibbonItem.TXITEM_InsertComboBoxField.ToString())
            SetItemImage(m_tmiFormat_FormFields_EnableFormValidation, Windows.Forms.Ribbon.RibbonFormFieldsTab.RibbonItem.TXITEM_EnableFormValidation.ToString())
            SetItemImage(m_tmiFormat_FormFields_ManageConditionalInstructions, Windows.Forms.Ribbon.RibbonFormFieldsTab.RibbonItem.TXITEM_ManageConditionalInstructions.ToString())

            ' 'Hyperlink...'
            SetItemImage(m_tmiFormat_Hyperlink, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertHyperlink.ToString())

            ' 'Bookmark...'
            SetItemImage(m_tmiFormat_Bookmark, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertBookmark.ToString())

            ' 'Table of Contents...'
            SetItemImage(m_tmiFormat_TableOfContents, Windows.Forms.Ribbon.RibbonReferencesTab.RibbonItem.TXITEM_ModifyTableOfContents.ToString())

            ' 'Columns...'
            SetItemImage(m_tmiFormat_Columns, Windows.Forms.Ribbon.RibbonPageLayoutTab.RibbonItem.TXITEM_Columns.ToString())

            ' 'Page Borders...'
            SetItemImage(m_tmiFormat_PageBorders, Windows.Forms.Ribbon.RibbonPageLayoutTab.RibbonItem.TXITEM_PageBorders.ToString())

            ' 'Page Color...'
            SetItemImage(m_tmiFormat_PageColor, Windows.Forms.Ribbon.RibbonPageLayoutTab.RibbonItem.TXITEM_PageColor.ToString())

            ' 'Tabs...'
            SetItemImage(m_tmiFormat_Tabs, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_EditTabs.ToString())

            ' 'Language...'
            SetItemImage(m_tmiFormat_Language, Windows.Forms.Ribbon.RibbonProofingTab.RibbonItem.TXITEM_SetLanguage.ToString())
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' ConnectFormatItemsHandlers Method
        '
        ' Connects the 'Format' menu items to Click and DropDownOpening handlers.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub ConnectFormatItemsHandlers()
            ' Click Handlers

            ' 'Character...'
            AddHandler m_tmiFormat_Character.Click, AddressOf Format_Character_Click

            ' 'Paragraph...'
            AddHandler m_tmiFormat_Paragraph.Click, AddressOf Format_Paragraph_Click

            ' 'Styles...'
            AddHandler m_tmiFormat_Styles.Click, AddressOf Format_Styles_Click

            ' 'Paragraph Structure Levels'
            For Each item As ToolStripMenuItem In m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle.DropDownItems
                AddHandler item.Click, AddressOf Format_ParagraphStructureLevels_CurrentParagraphStyle_Level_Click
            Next

            For Each item As ToolStripMenuItem In m_tmiFormat_ParagraphStructureLevels_AddToParagraph.DropDownItems
                AddHandler item.Click, AddressOf Format_ParagraphStructureLevels_AddToParagraph_Level_Click
            Next

            ' 'Bullets and Numbering'
            AddHandler m_tmiFormat_BulletsAndNumbering_ArabicNumbers.Click, AddressOf Format_BulletsAndNumbering_ArabicNumbers_Click
            AddHandler m_tmiFormat_BulletsAndNumbering_Letters.Click, AddressOf Format_BulletsAndNumbering_Letters_Click
            AddHandler m_tmiFormat_BulletsAndNumbering_CapitalLetters.Click, AddressOf Format_BulletsAndNumbering_CapitalLetters_Click
            AddHandler m_tmiFormat_BulletsAndNumbering_RomanNumbers.Click, AddressOf Format_BulletsAndNumbering_RomanNumbers_Click
            AddHandler m_tmiFormat_BulletsAndNumbering_SmallRomanNumbers.Click, AddressOf Format_BulletsAndNumbering_SmallRomanNumbers_Click
            AddHandler m_tmiFormat_BulletsAndNumbering_AsStructuredList.Click, AddressOf Format_BulletsAndNumbering_AsStructuredList_Click
            AddHandler m_tmiFormat_BulletsAndNumbering_Bullets.Click, AddressOf Format_BulletsAndNumbering_Bullets_Click
            AddHandler m_tmiFormat_BulletsAndNumbering_IncreaseLevel.Click, AddressOf Format_BulletsAndNumbering_IncreaseLevel_Click
            AddHandler m_tmiFormat_BulletsAndNumbering_DecreaseLevel.Click, AddressOf Format_BulletsAndNumbering_DecreaseLevel_Click
            AddHandler m_tmiFormat_BulletsAndNumbering_Properties.Click, AddressOf Format_BulletsAndNumbering_Properties_Click

            ' 'Image...'
            AddHandler m_tmiFormat_Image.Click, AddressOf Format_Image_Click

            ' 'Text Frame...'
            AddHandler m_tmiFormat_TextFrame.Click, AddressOf Format_TextFrame_Click

            ' 'Shape...'
            AddHandler m_tmiFormat_Shape.Click, AddressOf Format_Shape_Click

            ' 'Barcode...'
            AddHandler m_tmiFormat_Barcode.Click, AddressOf Frame_Barcode_Click

            ' 'Headers and Footers...'
            AddHandler m_tmiFormat_HeadersAndFooters.Click, AddressOf Frame_HeadersAndFooters_Click

            ' 'Page Number...'
            AddHandler m_tmiFormat_PageNumberField.Click, AddressOf Format_PageNumberField_Click

            ' 'Form Fields'
            AddHandler m_tmiFormat_FormFields_Edit.Click, AddressOf Format_FormFields_Edit_Click
            AddHandler m_tmiFormat_FormFields_EnableFormValidation.Click, AddressOf Format_FormFields_EnableFormValidation_Click
            AddHandler m_tmiFormat_FormFields_ManageConditionalInstructions.Click, AddressOf Format_FormFields_ManageConditionalInstructions_Click

            ' 'Hyperlink...'
            AddHandler m_tmiFormat_Hyperlink.Click, AddressOf Format_Hyperlink_Click

            ' 'Bookmark...'
            AddHandler m_tmiFormat_Bookmark.Click, AddressOf Format_Bookmark_Click

            ' 'Table of Contents...'
            AddHandler m_tmiFormat_TableOfContents.Click, AddressOf Format_TableOfContents_Click

            ' 'Columns...'
            AddHandler m_tmiFormat_Columns.Click, AddressOf Format_Columns_Click

            ' 'Page Borders...'
            AddHandler m_tmiFormat_PageBorders.Click, AddressOf Format_PageBorders_Click

            ' 'Page Color...'
            AddHandler m_tmiFormat_PageColor.Click, AddressOf Format_PageColor_Click

            ' 'Tabs...'
            AddHandler m_tmiFormat_Tabs.Click, AddressOf Format_Tabs_Click

            ' 'Language...'
            AddHandler m_tmiFormat_Language.Click, AddressOf Format_Language_Click


            ' DropDownOpening Handlers

            ' 'Format'
            AddHandler m_tmiFormat.DropDownOpening, AddressOf Format_DropDownOpening

            ' 'Paragraph Structure Levels'
            AddHandler m_tmiFormat_ParagraphStructureLevels.DropDownOpening, AddressOf Format_ParagraphStructureLevels_DropDownOpening
            AddHandler m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle.DropDownOpening, AddressOf Format_ParagraphStructureLevels_CurrentParagraphStyle_DropDownOpening
            AddHandler m_tmiFormat_ParagraphStructureLevels_AddToParagraph.DropDownOpening, AddressOf Format_ParagraphStructureLevels_AddToParagraph_DropDownOpening

            ' 'Bullets and Numbering'
            AddHandler m_tmiFormat_BulletsAndNumbering.DropDownOpening, AddressOf Format_BulletsAndNumbering_DropDownOpening

            ' 'Form Fields'
            AddHandler m_tmiFormat_FormFields.DropDownOpening, AddressOf Format_FormFields_DropDownOpening
        End Sub
    End Class
End Namespace
