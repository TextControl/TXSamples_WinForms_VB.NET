'-----------------------------------------------------------------------------------------------------------
' MainWindow_InsertMenuItem_DropDownOpening.vb File
'
' Description: Provides all DropDownOpening handlers associated with 'Insert' menu items.
'     
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------

Namespace TXTextControl.Words
    Partial Class MainWindow
        '-----------------------------------------------------------------------------------------------------------
        ' Insert_DropDownOpening Handler
        '
        ' Updates the enabled state of 'Insert' drop down menu items.
        ' 
        ' Item: 'Insert'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Insert_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs)
            Dim bCanEdit As Boolean
            bCanEdit = m_txTextControl.CanEdit
            ' 'File...'
            m_tmiInsert_File.Enabled = bCanEdit

            ' 'Image...'
            m_tmiInsert_Image.Enabled = bCanEdit

            ' 'Text Frame'
            m_tmiInsert_TextFrame.Enabled = bCanEdit

            ' 'Shape'	
            m_tmiInsert_Shape.Enabled = bCanEdit

            ' 'Barcode'
            m_tmiInsert_Barcode.Enabled = bCanEdit

            If m_plTXLicense >= VersionInfo.ProductLevel.Professional Then
                Dim colPages As PageCollection = m_txTextControl.GetPages()
                Dim hfHeaderFooter As HeaderFooter = TryCast(m_txTextControl.TextParts.GetItem(), HeaderFooter)
                Dim pgPage As Page = If(colPages IsNot Nothing, colPages.GetItem(), Nothing)

                ' 'Header'
                m_tmiInsert_Header_Insert.Enabled = colPages IsNot Nothing
                m_tmiInsert_Header_Remove.Enabled = bCanEdit AndAlso pgPage IsNot Nothing AndAlso pgPage.Header IsNot Nothing

                ' 'Footer'
                m_tmiInsert_Footer_Insert.Enabled = colPages IsNot Nothing
                m_tmiInsert_Footer_Remove.Enabled = bCanEdit AndAlso pgPage IsNot Nothing AndAlso pgPage.Footer IsNot Nothing

                ' 'Page Number'
                m_tmiInsert_PageNumber.Enabled = bCanEdit AndAlso hfHeaderFooter IsNot Nothing

                If hfHeaderFooter IsNot Nothing Then
                    Dim pnfPageNumberField As PageNumberField = hfHeaderFooter.PageNumberFields.GetItem()
                    m_tmiInsert_PageNumber_Insert.Enabled = pnfPageNumberField Is Nothing
                    m_tmiInsert_PageNumber_Delete.Enabled = pnfPageNumberField IsNot Nothing
                End If
            End If

            If m_plTXLicense >= VersionInfo.ProductLevel.Enterprise Then
                ' 'Form Fields'
                m_tmiInsert_FormField_TextFormField.Enabled = CSharpImpl.Assign(m_tmiInsert_FormField_CheckBox.Enabled, CSharpImpl.Assign(m_tmiInsert_FormField_ComboBox.Enabled, CSharpImpl.Assign(m_tmiInsert_FormField_DropDownList.Enabled, CSharpImpl.Assign(m_tmiInsert_FormField_DateFormField.Enabled, bCanEdit AndAlso m_txTextControl.FormFields.CanAdd))))
                m_tmiInsert_FormField_Delete.Enabled = bCanEdit AndAlso m_txTextControl.FormFields.GetItem() IsNot Nothing
            End If

            ' 'Symbol'
            m_tmiInsert_Symbol.Enabled = bCanEdit

            If m_plTXLicense >= VersionInfo.ProductLevel.Professional Then
                ' 'Hyperlink...'
                m_tmiInsert_Hyperlink.Enabled = bCanEdit AndAlso (m_txTextControl.HypertextLinks.CanAdd OrElse m_txTextControl.DocumentLinks.CanAdd)

                ' 'Bookmark...'
                Dim colDocumentTargets As DocumentTargetCollection = m_txTextControl.DocumentTargets
                m_tmiInsert_Bookmark_Insert.Enabled = bCanEdit AndAlso colDocumentTargets.CanAdd
                m_tmiInsert_Bookmark_Delete.Enabled = bCanEdit AndAlso colDocumentTargets.Count <> 0
                m_tmiInsert_Bookmark.Enabled = m_tmiInsert_Bookmark_Insert.Enabled OrElse m_tmiInsert_Bookmark_Delete.Enabled
            End If

            If m_plTXLicense >= VersionInfo.ProductLevel.Enterprise Then
                ' 'Table of Contents'
                Dim bInsideTOC As Boolean = m_txTextControl.TablesOfContents.GetItem() IsNot Nothing
                m_tmiInsert_TableOfContents_Insert.Enabled = bCanEdit AndAlso Not bInsideTOC
                m_tmiInsert_TableOfContents_Delete.Enabled = CSharpImpl.Assign(m_tmiInsert_TableOfContents_Update.Enabled, bCanEdit AndAlso bInsideTOC)
                m_tmiInsert_TableOfContents.Enabled = bCanEdit
            End If

            ' 'Columns'
            m_tmiInsert_Columns_One.Enabled = CSharpImpl.Assign(m_tmiInsert_Columns_Two.Enabled, CSharpImpl.Assign(m_tmiInsert_Columns_MoreColumns.Enabled, bCanEdit))

            ' 'Page Breaks'
            m_tmiInsert_PageBreaks.Enabled = bCanEdit

            ' 'Section Breaks'
            m_tmiInsert_SectionBreaks.Enabled = bCanEdit
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Insert_Columns_DropDownOpening Handler
        '
        ' Updates the checked state of 'Columns' drop down menu items.
        ' 
        ' Item: 'Columns'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Insert_Columns_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs)
            If m_plTXLicense >= VersionInfo.ProductLevel.Professional Then
                ' Get the number of columns
                Dim secCurrentSection As Section = m_txTextControl.Sections.GetItem()
                Dim iColumns As Integer = If(secCurrentSection IsNot Nothing, secCurrentSection.Format.Columns, -1)
                ' Check the items.
                m_tmiInsert_Columns_One.Checked = iColumns = 1
                m_tmiInsert_Columns_Two.Checked = iColumns = 2
                m_tmiInsert_Columns_MoreColumns.Checked = iColumns > 2
            End If
        End Sub
    End Class
End Namespace
