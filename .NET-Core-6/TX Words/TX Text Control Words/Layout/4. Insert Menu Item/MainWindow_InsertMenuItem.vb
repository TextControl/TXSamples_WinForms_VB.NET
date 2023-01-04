'-----------------------------------------------------------------------------------------------------------
' MainWindow_InsertMenuItem.vb File
'
' Description: Provides methods to set the layout and behavior of the 'Insert' menu items.
'     
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Namespace TXTextControl.Words
    Partial Class MainWindow
        '-----------------------------------------------------------------------------------------------------------
        ' M E M B E R   V A R I A B L E S
        '-----------------------------------------------------------------------------------------------------------
        Private Const m_iDefaultEmptyWidth As Integer = 2000  ' The actual default empty width of a form field is 2000 twips when setting the default width integer flag '0'


        '-----------------------------------------------------------------------------------------------------------
        ' Shape Types
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' 'Lines' Item
        '-----------------------------------------------------------------------------------------------------------
        Private ReadOnly m_rstShape_Lines As Drawing.ShapeType() = New Drawing.ShapeType() {Drawing.ShapeType.Line, Drawing.ShapeType.BentConnector3, Drawing.ShapeType.CurvedConnector3}

        '-----------------------------------------------------------------------------------------------------------
        ' 'Rectangles' Items
        '-----------------------------------------------------------------------------------------------------------
        Private ReadOnly m_rstShape_Rectangles As Drawing.ShapeType() = New Drawing.ShapeType() {Drawing.ShapeType.Rectangle, Drawing.ShapeType.RoundRectangle, Drawing.ShapeType.Snip1Rectangle, Drawing.ShapeType.Snip2SameRectangle, Drawing.ShapeType.Snip2DiagonalRectangle, Drawing.ShapeType.SnipRoundRectangle, Drawing.ShapeType.Round1Rectangle, Drawing.ShapeType.Round2SameRectangle, Drawing.ShapeType.Round2DiagonalRectangle}

        '-----------------------------------------------------------------------------------------------------------
        ' 'Basic Shapes' Items
        '-----------------------------------------------------------------------------------------------------------

        Private ReadOnly m_rstShape_BasicShapes As Drawing.ShapeType() = New Drawing.ShapeType() {Drawing.ShapeType.Ellipse, Drawing.ShapeType.Triangle, Drawing.ShapeType.RightTriangle, Drawing.ShapeType.Parallelogram, Drawing.ShapeType.NonIsoscelesTrapezoid, Drawing.ShapeType.Diamond, Drawing.ShapeType.Pentagon, Drawing.ShapeType.Hexagon, Drawing.ShapeType.Heptagon, Drawing.ShapeType.Octagon, Drawing.ShapeType.Decagon, Drawing.ShapeType.Dodecagon, Drawing.ShapeType.Pie, Drawing.ShapeType.Chord, Drawing.ShapeType.Teardrop, Drawing.ShapeType.Frame, Drawing.ShapeType.HalfFrame, Drawing.ShapeType.Corner, Drawing.ShapeType.DiagonalStripe, Drawing.ShapeType.Plus, Drawing.ShapeType.Plaque, Drawing.ShapeType.Can, Drawing.ShapeType.Cube, Drawing.ShapeType.Bevel, Drawing.ShapeType.Donut, Drawing.ShapeType.NoSmoking, Drawing.ShapeType.BlockArc, Drawing.ShapeType.FoldedCorner, Drawing.ShapeType.SmileyFace, Drawing.ShapeType.Heart, Drawing.ShapeType.LightningBolt, Drawing.ShapeType.Sun, Drawing.ShapeType.Moon, Drawing.ShapeType.Cloud, Drawing.ShapeType.Arc, Drawing.ShapeType.BracketPair, Drawing.ShapeType.BracePair, Drawing.ShapeType.LeftBracket, Drawing.ShapeType.RightBracket, Drawing.ShapeType.LeftBrace, Drawing.ShapeType.RightBrace}

        '-----------------------------------------------------------------------------------------------------------
        ' 'Block Arrows' Items
        '-----------------------------------------------------------------------------------------------------------
        Private ReadOnly m_rstShape_BlockArrows As Drawing.ShapeType() = New Drawing.ShapeType() {Drawing.ShapeType.RightArrow, Drawing.ShapeType.LeftArrow, Drawing.ShapeType.UpArrow, Drawing.ShapeType.DownArrow, Drawing.ShapeType.LeftRightArrow, Drawing.ShapeType.UpDownArrow, Drawing.ShapeType.QuadArrow, Drawing.ShapeType.LeftRightUpArrow, Drawing.ShapeType.BentArrow, Drawing.ShapeType.UTurnArrow, Drawing.ShapeType.LeftUpArrow, Drawing.ShapeType.BentUpArrow, Drawing.ShapeType.CurvedRightArrow, Drawing.ShapeType.CurvedLeftArrow, Drawing.ShapeType.CurvedUpArrow, Drawing.ShapeType.CurvedDownArrow, Drawing.ShapeType.StripedRightArrow, Drawing.ShapeType.NotchedRightArrow, Drawing.ShapeType.NotchedRightArrow, Drawing.ShapeType.Chevron, Drawing.ShapeType.RightArrowCallout, Drawing.ShapeType.DownArrowCallout, Drawing.ShapeType.LeftArrowCallout, Drawing.ShapeType.UpArrowCallout, Drawing.ShapeType.LeftRightArrowCallout, Drawing.ShapeType.QuadArrowCallout, Drawing.ShapeType.CircularArrow}


        '-----------------------------------------------------------------------------------------------------------
        ' 'Equation Shapes' Items
        '-----------------------------------------------------------------------------------------------------------
        Private ReadOnly m_rstShape_EquationShapes As Drawing.ShapeType() = New Drawing.ShapeType() {Drawing.ShapeType.MathPlus, Drawing.ShapeType.MathMinus, Drawing.ShapeType.MathMultiply, Drawing.ShapeType.MathDivide, Drawing.ShapeType.MathEqual, Drawing.ShapeType.MathNotEqual}

        '-----------------------------------------------------------------------------------------------------------
        ' 'Flowchart' Items
        '-----------------------------------------------------------------------------------------------------------
        Private ReadOnly m_rstShape_Flowchart As Drawing.ShapeType() = New Drawing.ShapeType() {Drawing.ShapeType.FlowChartProcess, Drawing.ShapeType.FlowChartAlternateProcess, Drawing.ShapeType.FlowChartDecision, Drawing.ShapeType.FlowChartInputOutput, Drawing.ShapeType.FlowChartPredefinedProcess, Drawing.ShapeType.FlowChartInternalStorage, Drawing.ShapeType.FlowChartDocument, Drawing.ShapeType.FlowChartMultidocument, Drawing.ShapeType.FlowChartTerminator, Drawing.ShapeType.FlowChartPreparation, Drawing.ShapeType.FlowChartManualInput, Drawing.ShapeType.FlowChartManualOperation, Drawing.ShapeType.FlowChartConnector, Drawing.ShapeType.FlowChartOffpageConnector, Drawing.ShapeType.FlowChartPunchedCard, Drawing.ShapeType.FlowChartPunchedTape, Drawing.ShapeType.FlowChartSummingJunction, Drawing.ShapeType.FlowChartOr, Drawing.ShapeType.FlowChartCollate, Drawing.ShapeType.FlowChartSort, Drawing.ShapeType.FlowChartExtract, Drawing.ShapeType.FlowChartMerge, Drawing.ShapeType.FlowChartOnlineStorage, Drawing.ShapeType.FlowChartDelay, Drawing.ShapeType.FlowChartMagneticTape, Drawing.ShapeType.FlowChartMagneticDisk, Drawing.ShapeType.FlowChartMagneticDrum, Drawing.ShapeType.FlowChartDisplay}

        '-----------------------------------------------------------------------------------------------------------
        ' 'Stars and Banners' Items
        '-----------------------------------------------------------------------------------------------------------
        Private ReadOnly m_rstShape_StarsAndBanners As Drawing.ShapeType() = New Drawing.ShapeType() {Drawing.ShapeType.IrregularSeal1, Drawing.ShapeType.IrregularSeal2, Drawing.ShapeType.Star4, Drawing.ShapeType.Star5, Drawing.ShapeType.Star6, Drawing.ShapeType.Star7, Drawing.ShapeType.Star8, Drawing.ShapeType.Star10, Drawing.ShapeType.Star12, Drawing.ShapeType.Star16, Drawing.ShapeType.Star24, Drawing.ShapeType.Star32, Drawing.ShapeType.Ribbon2, Drawing.ShapeType.Ribbon, Drawing.ShapeType.EllipseRibbon2, Drawing.ShapeType.EllipseRibbon, Drawing.ShapeType.VerticalScroll, Drawing.ShapeType.HorizontalScroll, Drawing.ShapeType.Wave, Drawing.ShapeType.DoubleWave}

        '-----------------------------------------------------------------------------------------------------------
        ' 'Callouts' Items
        '-----------------------------------------------------------------------------------------------------------
        Private ReadOnly m_rstShape_Callouts As Drawing.ShapeType() = New Drawing.ShapeType() {Drawing.ShapeType.WedgeRectangleCallout, Drawing.ShapeType.WedgeRoundRectangleCallout, Drawing.ShapeType.WedgeEllipseCallout, Drawing.ShapeType.CloudCallout, Drawing.ShapeType.BorderCallout1, Drawing.ShapeType.BorderCallout2, Drawing.ShapeType.BorderCallout3, Drawing.ShapeType.AccentCallout1, Drawing.ShapeType.AccentCallout2, Drawing.ShapeType.AccentCallout3, Drawing.ShapeType.Callout1, Drawing.ShapeType.Callout2, Drawing.ShapeType.Callout3, Drawing.ShapeType.AccentBorderCallout1, Drawing.ShapeType.AccentBorderCallout2, Drawing.ShapeType.AccentBorderCallout3}


        '-----------------------------------------------------------------------------------------------------------
        ' Barcode Types
        '-----------------------------------------------------------------------------------------------------------
        Private ReadOnly m_rbtBarcodeTypes As Barcode.BarcodeType() = New Barcode.BarcodeType() {Barcode.BarcodeType.QRCode, Barcode.BarcodeType.Code128, Barcode.BarcodeType.EAN13, Barcode.BarcodeType.UPCA, Barcode.BarcodeType.EAN8, Barcode.BarcodeType.Interleaved2of5, Barcode.BarcodeType.Postnet, Barcode.BarcodeType.Code39, Barcode.BarcodeType.AztecCode, Barcode.BarcodeType.IntelligentMail, Barcode.BarcodeType.Datamatrix, Barcode.BarcodeType.PDF417, Barcode.BarcodeType.MicroPDF, Barcode.BarcodeType.Codabar, Barcode.BarcodeType.FourState, Barcode.BarcodeType.Code11, Barcode.BarcodeType.Code93, Barcode.BarcodeType.PLANET, Barcode.BarcodeType.RoyalMail, Barcode.BarcodeType.Maxicode}



        '-----------------------------------------------------------------------------------------------------------
        ' M E T H O D S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' SetInsertItemsTexts Method
        '
        ' Sets the texts of the 'Insert' menu items.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetInsertItemsTexts()
            ' 'Insert'
            SetItemText(m_tmiInsert)

            ' 'File...'
            SetItemText(m_tmiInsert_File)

            ' 'Image...'
            SetItemText(m_tmiInsert_Image)

            ' 'Text Frame'
            SetItemText(m_tmiInsert_TextFrame)

            ' 'Shape'	
            SetItemText(m_tmiInsert_Shape)
            SetItemText(m_tmiInsert_Shape_Lines)
            SetItemText(m_tmiInsert_Shape_Rectangles)
            SetItemText(m_tmiInsert_Shape_BasicShapes)
            SetItemText(m_tmiInsert_Shape_BlockArrows)
            SetItemText(m_tmiInsert_Shape_EquationShapes)
            SetItemText(m_tmiInsert_Shape_Flowchart)
            SetItemText(m_tmiInsert_Shape_StarsAndBanners)
            SetItemText(m_tmiInsert_Shape_Callouts)
            SetItemText(m_tmiInsert_Shape_DrawingCanvas)

            ' 'Barcode'
            SetItemText(m_tmiInsert_Barcode)

            ' 'Header'
            SetItemText(m_tmiInsert_Header)
            SetItemText(m_tmiInsert_Header_Insert)
            SetItemText(m_tmiInsert_Header_Remove)

            ' 'Footer'
            SetItemText(m_tmiInsert_Footer)
            SetItemText(m_tmiInsert_Footer_Insert)
            SetItemText(m_tmiInsert_Footer_Remove)

            ' 'Page Number'
            SetItemText(m_tmiInsert_PageNumber)
            SetItemText(m_tmiInsert_PageNumber_Insert)
            SetItemText(m_tmiInsert_PageNumber_Delete)

            ' 'Form Fields'
            SetItemText(m_tmiInsert_FormField)
            SetItemText(m_tmiInsert_FormField_TextFormField)
            SetItemText(m_tmiInsert_FormField_CheckBox)
            SetItemText(m_tmiInsert_FormField_ComboBox)
            SetItemText(m_tmiInsert_FormField_DropDownList)
            SetItemText(m_tmiInsert_FormField_DateFormField)
            SetItemText(m_tmiInsert_FormField_Delete)

            ' 'Symbol'
            SetItemText(m_tmiInsert_Symbol)

            ' 'Hyperlink...'
            SetItemText(m_tmiInsert_Hyperlink)

            ' 'Bookmark...'
            SetItemText(m_tmiInsert_Bookmark)
            SetItemText(m_tmiInsert_Bookmark_Insert)
            SetItemText(m_tmiInsert_Bookmark_Delete)

            ' 'Table of Contents'
            SetItemText(m_tmiInsert_TableOfContents)
            SetItemText(m_tmiInsert_TableOfContents_Insert)
            SetItemText(m_tmiInsert_TableOfContents_Delete)
            SetItemText(m_tmiInsert_TableOfContents_Update)

            ' 'Columns'
            SetItemText(m_tmiInsert_Columns)
            SetItemText(m_tmiInsert_Columns_One)
            SetItemText(m_tmiInsert_Columns_Two)
            SetItemText(m_tmiInsert_Columns_MoreColumns)

            ' 'Page Breaks'
            SetItemText(m_tmiInsert_PageBreaks)
            SetItemText(m_tmiInsert_PageBreaks_Page)
            SetItemText(m_tmiInsert_PageBreaks_Column)
            SetItemText(m_tmiInsert_PageBreaks_TextWrapping)

            ' 'Section Breaks'
            SetItemText(m_tmiInsert_SectionBreaks)
            SetItemText(m_tmiInsert_SectionBreaks_NextPage)
            SetItemText(m_tmiInsert_SectionBreaks_Continuous)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' SetInsertItemsImages Method
        '
        ' Sets the images of the 'Insert' menu items.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetInsertItemsImages()
            ' 'File...'
            SetItemImage(m_tmiInsert_File, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertFile.ToString())

            ' 'Image...'
            SetItemImage(m_tmiInsert_Image, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertImage.ToString())

            ' 'Text Frame'
            SetItemImage(m_tmiInsert_TextFrame, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertTextFrame.ToString())

            ' 'Shape'	
            SetItemImage(m_tmiInsert_Shape, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertShape.ToString())
            SetItemImage(m_tmiInsert_Shape_Lines, Windows.Forms.ResourceProvider.ShapeItem.TXITEM_SHAPE_Line.ToString())
            SetItemImage(m_tmiInsert_Shape_Rectangles, Windows.Forms.ResourceProvider.ShapeItem.TXITEM_SHAPE_Rectangle.ToString())
            SetItemImage(m_tmiInsert_Shape_BasicShapes, Windows.Forms.ResourceProvider.ShapeItem.TXITEM_SHAPE_RightTriangle.ToString())
            SetItemImage(m_tmiInsert_Shape_BlockArrows, Windows.Forms.ResourceProvider.ShapeItem.TXITEM_SHAPE_RightArrow.ToString())
            SetItemImage(m_tmiInsert_Shape_EquationShapes, Windows.Forms.ResourceProvider.ShapeItem.TXITEM_SHAPE_Plus.ToString())
            SetItemImage(m_tmiInsert_Shape_Flowchart, Windows.Forms.ResourceProvider.ShapeItem.TXITEM_SHAPE_FlowChartMultidocument.ToString())
            SetItemImage(m_tmiInsert_Shape_StarsAndBanners, Windows.Forms.ResourceProvider.ShapeItem.TXITEM_SHAPE_Star7.ToString())
            SetItemImage(m_tmiInsert_Shape_Callouts, Windows.Forms.ResourceProvider.ShapeItem.TXITEM_SHAPE_WedgeRoundRectangleCallout.ToString())
            SetItemImage(m_tmiInsert_Shape_DrawingCanvas, Windows.Forms.Ribbon.RibbonInsertTab.RibbonDropDownItem.TXITEM_InsertDrawingCanvas.ToString())

            ' 'Barcode'	
            SetItemImage(m_tmiInsert_Barcode, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertBarcode.ToString())

            ' 'Header'
            SetItemImage(m_tmiInsert_Header, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertHeader.ToString())
            SetItemImage(m_tmiInsert_Header_Insert, Windows.Forms.Ribbon.RibbonInsertTab.RibbonDropDownItem.TXITEM_EditHeader.ToString())
            SetItemImage(m_tmiInsert_Header_Remove, Windows.Forms.Ribbon.RibbonInsertTab.RibbonDropDownItem.TXITEM_RemoveHeader.ToString())

            ' 'Footer'
            SetItemImage(m_tmiInsert_Footer, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertFooter.ToString())
            SetItemImage(m_tmiInsert_Footer_Insert, Windows.Forms.Ribbon.RibbonInsertTab.RibbonDropDownItem.TXITEM_EditFooter.ToString())
            SetItemImage(m_tmiInsert_Footer_Remove, Windows.Forms.Ribbon.RibbonInsertTab.RibbonDropDownItem.TXITEM_RemoveFooter.ToString())

            ' 'Page Number'
            SetItemImage(m_tmiInsert_PageNumber, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertPage.ToString())
            SetItemImage(m_tmiInsert_PageNumber_Insert, Windows.Forms.Ribbon.RibbonInsertTab.RibbonDropDownItem.TXITEM_InsertStandardPageNumber.ToString())
            SetItemImage(m_tmiInsert_PageNumber_Delete, Windows.Forms.Ribbon.RibbonInsertTab.RibbonDropDownItem.TXITEM_RemovePageNumber.ToString())

            ' 'Form Fields'
            SetItemImage(m_tmiInsert_FormField, Windows.Forms.Ribbon.RibbonFormFieldsTab.RibbonItem.TXITEM_InsertComboBoxField.ToString())
            SetItemImage(m_tmiInsert_FormField_TextFormField, Windows.Forms.Ribbon.RibbonFormFieldsTab.RibbonItem.TXITEM_InsertTextFormField.ToString())
            SetItemImage(m_tmiInsert_FormField_CheckBox, Windows.Forms.Ribbon.RibbonFormFieldsTab.RibbonItem.TXITEM_InsertCheckBoxField.ToString())
            SetItemImage(m_tmiInsert_FormField_ComboBox, Windows.Forms.Ribbon.RibbonFormFieldsTab.RibbonItem.TXITEM_InsertComboBoxField.ToString())
            SetItemImage(m_tmiInsert_FormField_DropDownList, Windows.Forms.Ribbon.RibbonFormFieldsTab.RibbonItem.TXITEM_InsertDropDownListField.ToString())
            SetItemImage(m_tmiInsert_FormField_DateFormField, Windows.Forms.Ribbon.RibbonFormFieldsTab.RibbonItem.TXITEM_InsertDateFormField.ToString())
            SetItemImage(m_tmiInsert_FormField_Delete, Windows.Forms.Ribbon.RibbonFormFieldsTab.RibbonItem.TXITEM_DeleteFormField.ToString())

            ' 'Symbol'
            SetItemImage(m_tmiInsert_Symbol, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertSymbol.ToString())

            ' 'Hyperlink...'
            SetItemImage(m_tmiInsert_Hyperlink, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertHyperlink.ToString())

            ' 'Bookmark...'
            SetItemImage(m_tmiInsert_Bookmark, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertBookmark.ToString())
            SetItemImage(m_tmiInsert_Bookmark_Insert, Windows.Forms.Ribbon.RibbonInsertTab.RibbonDropDownItem.TXITEM_EditBookmark.ToString())
            SetItemImage(m_tmiInsert_Bookmark_Delete, Windows.Forms.Ribbon.RibbonInsertTab.RibbonDropDownItem.TXITEM_DeleteBookmark.ToString())

            ' 'Table of Contents'
            SetItemImage(m_tmiInsert_TableOfContents, Windows.Forms.Ribbon.RibbonReferencesTab.RibbonItem.TXITEM_InsertTableOfContents.ToString())
            SetItemImage(m_tmiInsert_TableOfContents_Insert, Windows.Forms.Ribbon.RibbonReferencesTab.RibbonItem.TXITEM_InsertTableOfContents.ToString())
            SetItemImage(m_tmiInsert_TableOfContents_Delete, Windows.Forms.Ribbon.RibbonReferencesTab.RibbonItem.TXITEM_DeleteTableOfContents.ToString())
            SetItemImage(m_tmiInsert_TableOfContents_Update, Windows.Forms.Ribbon.RibbonReferencesTab.RibbonItem.TXITEM_UpdateTableOfContents.ToString())

            ' 'Columns'
            SetItemImage(m_tmiInsert_Columns, Windows.Forms.Ribbon.RibbonPageLayoutTab.RibbonItem.TXITEM_Columns.ToString())
            SetItemImage(m_tmiInsert_Columns_One, Windows.Forms.Ribbon.RibbonPageLayoutTab.RibbonDropDownItem.TXITEM_Columns_One.ToString())
            SetItemImage(m_tmiInsert_Columns_Two, Windows.Forms.Ribbon.RibbonPageLayoutTab.RibbonDropDownItem.TXITEM_Columns_Two.ToString())
            SetItemImage(m_tmiInsert_Columns_MoreColumns, Windows.Forms.Ribbon.RibbonPageLayoutTab.RibbonDropDownItem.TXITEM_Columns_MoreColumns.ToString())

            ' 'Page Breaks'
            SetItemImage(m_tmiInsert_PageBreaks, Windows.Forms.Ribbon.RibbonPageLayoutTab.RibbonItem.TXITEM_Breaks.ToString())
            SetItemImage(m_tmiInsert_PageBreaks_Page, Windows.Forms.Ribbon.RibbonPageLayoutTab.RibbonItem.TXITEM_Breaks.ToString())
            SetItemImage(m_tmiInsert_PageBreaks_Column, Windows.Forms.Ribbon.RibbonPageLayoutTab.RibbonDropDownItem.TXITEM_Breaks_Column.ToString())
            SetItemImage(m_tmiInsert_PageBreaks_TextWrapping, Windows.Forms.Ribbon.RibbonPageLayoutTab.RibbonDropDownItem.TXITEM_Breaks_TextWrapping.ToString())

            ' 'Section Breaks'
            SetItemImage(m_tmiInsert_SectionBreaks, Windows.Forms.Ribbon.RibbonPageLayoutTab.RibbonDropDownItem.TXITEM_Breaks_NextPage.ToString())
            SetItemImage(m_tmiInsert_SectionBreaks_NextPage, Windows.Forms.Ribbon.RibbonPageLayoutTab.RibbonDropDownItem.TXITEM_Breaks_NextPage.ToString())
            SetItemImage(m_tmiInsert_SectionBreaks_Continuous, Windows.Forms.Ribbon.RibbonPageLayoutTab.RibbonDropDownItem.TXITEM_Breaks_Continuous.ToString())
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' ConnectInsertItemsHandlers Method
        '
        ' Connects the 'Insert' menu items to Click and DropDownOpening handlers.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub ConnectInsertItemsHandlers()
            ' Click Handlers:

            ' 'File...'
            AddHandler m_tmiInsert_File.Click, AddressOf Insert_File_Click

            ' 'Image...'
            AddHandler m_tmiInsert_Image.Click, AddressOf Insert_Image_Click

            ' 'Text Frame'
            AddHandler m_tmiInsert_TextFrame.Click, AddressOf Insert_TextFrame_Click

            ' 'Shape'	
            AddHandler m_tmiInsert_Shape_DrawingCanvas.Click, AddressOf Insert_Shape_DrawingCanvas_Click

            ' 'Header'
            AddHandler m_tmiInsert_Header_Insert.Click, AddressOf Insert_Header_Insert_Click
            AddHandler m_tmiInsert_Header_Remove.Click, AddressOf Insert_Header_Remove_Click

            ' 'Footer'
            AddHandler m_tmiInsert_Footer_Insert.Click, AddressOf Insert_Footer_Insert_Click
            AddHandler m_tmiInsert_Footer_Remove.Click, AddressOf Insert_Footer_Remove_Click

            ' 'Page Number'
            AddHandler m_tmiInsert_PageNumber_Insert.Click, AddressOf Insert_PageNumber_Insert_Click
            AddHandler m_tmiInsert_PageNumber_Delete.Click, AddressOf Insert_PageNumber_Remove_Click

            ' 'Form Fields'
            AddHandler m_tmiInsert_FormField_TextFormField.Click, AddressOf Insert_FormFields_TextFormField_Click
            AddHandler m_tmiInsert_FormField_CheckBox.Click, AddressOf Insert_FormFields_CheckBox_Click
            AddHandler m_tmiInsert_FormField_ComboBox.Click, AddressOf Insert_FormFields_ComboBox_Click
            AddHandler m_tmiInsert_FormField_DropDownList.Click, AddressOf Insert_FormFields_DropDownList_Click
            AddHandler m_tmiInsert_FormField_DateFormField.Click, AddressOf Insert_FormFields_DateFormField_Click
            AddHandler m_tmiInsert_FormField_Delete.Click, AddressOf Insert_FormFields_Delete_Click

            ' 'Symbol'
            AddHandler m_tmiInsert_Symbol.Click, AddressOf Insert_Symbol_Click

            ' 'Hyperlink...'
            AddHandler m_tmiInsert_Hyperlink.Click, AddressOf Insert_Hyperlink_Click

            ' 'Bookmark...'
            AddHandler m_tmiInsert_Bookmark_Insert.Click, AddressOf Insert_Bookmark_Insert_Click
            AddHandler m_tmiInsert_Bookmark_Delete.Click, AddressOf Insert_Bookmark_Delete_Click

            ' 'Table of Contents'
            AddHandler m_tmiInsert_TableOfContents_Insert.Click, AddressOf Insert_TableOfContents_Insert_Click
            AddHandler m_tmiInsert_TableOfContents_Delete.Click, AddressOf Insert_TableOfContents_Delete_Click
            AddHandler m_tmiInsert_TableOfContents_Update.Click, AddressOf Insert_TableOfContents_Update_Click

            ' 'Columns'
            AddHandler m_tmiInsert_Columns_One.Click, AddressOf Insert_Columns_One_Click
            AddHandler m_tmiInsert_Columns_Two.Click, AddressOf Insert_Columns_Two_Click
            AddHandler m_tmiInsert_Columns_MoreColumns.Click, AddressOf Insert_Columns_MoreColumns_Click

            ' 'Page Breaks'
            AddHandler m_tmiInsert_PageBreaks_Page.Click, AddressOf Insert_PageBreaks_Page_Click
            AddHandler m_tmiInsert_PageBreaks_Column.Click, AddressOf Insert_PageBreaks_Column_Click
            AddHandler m_tmiInsert_PageBreaks_TextWrapping.Click, AddressOf Insert_PageBreaks_TextWrapping_Click

            ' 'Section Breaks'
            AddHandler m_tmiInsert_SectionBreaks_NextPage.Click, AddressOf Insert_SectionBreaks_NextPage_Click
            AddHandler m_tmiInsert_SectionBreaks_Continuous.Click, AddressOf Insert_SectionBreaks_Continuous_Click


            ' DropDownOpening Handlers

            ' 'Insert'
            AddHandler m_tmiInsert.DropDownOpening, AddressOf Insert_DropDownOpening

            ' 'Columns'
            AddHandler m_tmiInsert_Columns.DropDownOpening, AddressOf Insert_Columns_DropDownOpening
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' CreateShapeAndBarcodeItems Method
        '
        ' Creates Shape and Barcode items.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub CreateShapeAndBarcodeItems()
            ' 'Shape'	
            Dim shapeType As Drawing.ShapeType
            For Each shapeType In m_rstShape_Lines             ' 'Lines'
                AddShapeItem(m_tmiInsert_Shape_Lines.DropDownItems, shapeType)
            Next

            For Each shapeType In m_rstShape_Rectangles        ' 'Rectangles'
                AddShapeItem(m_tmiInsert_Shape_Rectangles.DropDownItems, shapeType)
            Next

            For Each shapeType In m_rstShape_BasicShapes       ' 'Basic Shapes'
                AddShapeItem(m_tmiInsert_Shape_BasicShapes.DropDownItems, shapeType)
            Next

            For Each shapeType In m_rstShape_BlockArrows       ' 'Block Arrows'
                AddShapeItem(m_tmiInsert_Shape_BlockArrows.DropDownItems, shapeType)
            Next

            For Each shapeType In m_rstShape_EquationShapes    ' 'Equation Shapes'
                AddShapeItem(m_tmiInsert_Shape_EquationShapes.DropDownItems, shapeType)
            Next

            For Each shapeType In m_rstShape_Flowchart         ' 'Flowchart'
                AddShapeItem(m_tmiInsert_Shape_Flowchart.DropDownItems, shapeType)
            Next

            For Each shapeType In m_rstShape_StarsAndBanners   ' 'Stars and Banners'
                AddShapeItem(m_tmiInsert_Shape_StarsAndBanners.DropDownItems, shapeType)
            Next

            For Each shapeType In m_rstShape_Callouts          ' 'Callouts'
                AddShapeItem(m_tmiInsert_Shape_Callouts.DropDownItems, shapeType)
            Next

            ' 'Barcode'	
            Dim barcodeType As Barcode.BarcodeType
            For Each barcodeType In m_rbtBarcodeTypes
                AddBarcodeItem(m_tmiInsert_Barcode.DropDownItems, barcodeType)
            Next
        End Sub
    End Class
End Namespace
