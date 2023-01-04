'-----------------------------------------------------------------------------------------------------------
' MainWindow_InsertMenuItem_Methods.vb File
'
' Description: Provides supporting methods to implement the desired behavior of some 'Insert' menu items.
'     
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Imports TXTextControl.DataVisualization
Imports TXTextControl.Windows.Forms

Namespace TXTextControl.Words
    Partial Class MainWindow
        '-----------------------------------------------------------------------------------------------------------
        ' 'Shape' Item
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' AddShape method
        ' Inserts a shape as a DrawingFrame into the TextControl or, if a drawing frame is activated, into it. If the
        ' shape is inserted as a DrawingFrame, it is anchored to a paragraph and moves with the text. The text flows 
        ' around the drawing frame and empty areas at the left and right side are filled.
        '
        ' Parameters:
        '      shapeType:  The type of the shape to add.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub AddShape(ByVal shapeType As Drawing.ShapeType)
            Dim dfDrawingFrame As DrawingFrame = m_txTextControl.Drawings.GetActivatedItem()
            If dfDrawingFrame Is Nothing Then
                ' Create a New System.Drawing canvas/TXDrawingControl.
                Dim txdDrawingControl As Drawing.TXDrawingControl = New Drawing.TXDrawingControl(7000, 4000)

                ' Add a shape with the specified shape type into the drawing canvas.
                Dim shape As Drawing.Shape = New Drawing.Shape(shapeType) With {
                    .AutoSize = True,
                    .Movable = False,
                    .Sizable = False
                }
                txdDrawingControl.Shapes.Add(shape, Drawing.ShapeCollection.AddStyle.Fill)

                ' Finally the new created drawing canvas/TXDrawingControl is added to the TextControl
                dfDrawingFrame = New DrawingFrame(txdDrawingControl)
                m_txTextControl.Drawings.Add(dfDrawingFrame, FrameInsertionMode.DisplaceText Or FrameInsertionMode.MoveWithText)
            Else
                ' Add a new Shape into the drawing canvas
                Dim drawing As Drawing.TXDrawingControl = TryCast(dfDrawingFrame.Drawing, Drawing.TXDrawingControl)
                If drawing IsNot Nothing AndAlso drawing.IsCanvasVisible Then
                    drawing.Shapes.Add(New Drawing.Shape(shapeType), TXTextControl.Drawing.ShapeCollection.AddStyle.MouseCreation)
                End If
            End If
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' AddShapeItem method
        ' Creates a new MenuItem that represents a specific shape type and adds it to the specified items collection. 
        '
        ' Parameters:
        '      items:			The items collection where to add the created item.
        '		shapeType:		The shape type that is represented by the created item.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub AddShapeItem(ByVal items As ToolStripItemCollection, ByVal shapeType As Drawing.ShapeType)
            ' Get text and icon by using the ResourceProvider
            Dim strResourceID As String = "TXITEM_SHAPE_" & shapeType
            Dim strText As String = ResourceProvider.GetToolTipDescription(strResourceID)
            Dim bmpImage As Bitmap = ResourceProvider.GetSmallIcon(strResourceID, Me)

            ' Create a ToolStripMenuItem with the corresponding text and icon. Additionally the shape type is stored
            ' as Tag value.
            Dim tmiShapeItem As ToolStripMenuItem = New ToolStripMenuItem(strText, bmpImage) With {
                .Tag = shapeType
            }
            ' Add the Click handler to the item.
            AddHandler tmiShapeItem.Click, AddressOf Insert_Shape_ShapeCategory_MenuItem_Click
            ' Add the item to the specified items collection.
            items.Add(tmiShapeItem)
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' 'Barcode' Item
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' AddBarcodeItem method
        ' Creates a new MenuItem that represents a specific barcode type and adds it to the specified items 
        ' collection. 
        '
        ' Parameters:
        '      items:			The items collection where to add the created item.
        '		barcodeType:	The barcode type that is represented by the created item.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub AddBarcodeItem(ByVal items As ToolStripItemCollection, ByVal barcodeType As Barcode.BarcodeType)
            ' Get text and icon by using the ResourceProvider
            Dim strResourceID As String = "TXITEM_BARCODE_" & barcodeType
            Dim strText As String = ResourceProvider.GetToolTipTitle(strResourceID)
            Dim bmpImage As Bitmap = ResourceProvider.GetSmallIcon(strResourceID, Me)

            ' Create a ToolStripMenuItem with the corresponding text and icon. Additionally the barcode type is stored
            ' as Tag value.
            Dim tmiBarcodeItem As ToolStripMenuItem = New ToolStripMenuItem(strText, bmpImage) With {
                .Tag = barcodeType
            }
            ' Add the Click handler to the item.
            AddHandler tmiBarcodeItem.Click, AddressOf Insert_Barcode_MenuItem_Click
            ' Add the item to the specified items collection.
            items.Add(tmiBarcodeItem)
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' 'Header' and 'Footer' Item
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' InsertHeaderFooter method
        ' Insert a header or footer to the TextControl (or activates the header/footer if it already exists).
        '
        ' Parameters:
        '      type:			The header/footer type to insert/activate.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub InsertHeaderFooter(ByVal type As HeaderFooterType)

            ' Get the HeaderFooter of the current page if it already exists.
            Dim pgPage As Page = m_txTextControl.GetPages().GetItem()
            Dim hfHeaderFooter As HeaderFooter = If(type = HeaderFooterType.Header, pgPage.Header, pgPage.Footer)

            ' If there is no header or footer, insert it:
            If hfHeaderFooter Is Nothing Then
                Dim section As Section = m_txTextControl.Sections(pgPage.Section)
                If section IsNot Nothing Then
                    Dim colHeaderFooters As HeaderFooterCollection = section.HeadersAndFooters
                    If colHeaderFooters IsNot Nothing Then
                        colHeaderFooters.Add(type)
                        hfHeaderFooter = If(type = HeaderFooterType.Header, pgPage.Header, pgPage.Footer)
                    End If
                End If
            End If

            ' Finally activate the header or footer:
            If hfHeaderFooter IsNot Nothing Then
                hfHeaderFooter.Activate()
            End If
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' RemoveHeaderFooter method
        ' Removes the header/footer from the TextControl.
        '
        ' Parameters:
        '      headerFooter:		The header/footer to remove.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub RemoveHeaderFooter(ByVal headerFooter As HeaderFooter)
            Dim secSection As Section = m_txTextControl.Sections(headerFooter.Section)
            If secSection IsNot Nothing Then
                Dim colHeaderFooters As HeaderFooterCollection = secSection.HeadersAndFooters
                If colHeaderFooters IsNot Nothing Then colHeaderFooters.Remove(headerFooter.Type)
            End If
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' 'Form Fields' Item
        '-----------------------------------------------------------------------------------------------------------

        '----------------------------------------------------------------------------------------------
        ' GetWidthFromEnvironment Method
        ' Calculates and returns the width to set for a TextFormField or a SelectionFormField that
        ' will be created and inserted into the TextControl. The width depends on whether the FormField
        ' is inserted inside a table cell or a text frame. In this case, the corresponding width is
        ' returned. Otherwise the default empty width is returnd.
        '
        ' Return value:        The calculated width to set.
        '----------------------------------------------------------------------------------------------
        Private Function GetWidthFromEnvironment() As Integer

            Dim iHorizontalPadding As Integer = 114 ' ~2mm horizontal padding
            Dim tblTable As Table = m_txTextControl.Tables.GetItem()
            If tblTable IsNot Nothing Then
                Dim tcCell As TableCell = tblTable.Cells.GetItem()
                If tcCell IsNot Nothing Then
                    Return tcCell.Width - iHorizontalPadding
                End If
            Else
                Dim tfTextFrame As TextFrame = TryCast(m_txTextControl.TextParts.GetItem(), TextFrame)
                If tfTextFrame IsNot Nothing Then
                    Return Math.Min(m_iDefaultEmptyWidth, tfTextFrame.Size.Width - iHorizontalPadding)
                End If
            End If
            Return 0
        End Function


        '-----------------------------------------------------------------------------------------------------------
        ' 'Columns' Item
        '-----------------------------------------------------------------------------------------------------------

        '----------------------------------------------------------------------------------------------
        ' SetColumnCount
        ' Set a specific number of columns for the current section.
        '
        ' Parameters:
        '      columns:		The number of columns to set.
        '----------------------------------------------------------------------------------------------
        Private Sub SetColumnCount(ByVal columns As Integer)
            m_txTextControl.Select(m_txTextControl.Selection.Start, 0)
            Dim secCurrentSection As Section = m_txTextControl.Sections.GetItem()

            If secCurrentSection IsNot Nothing Then
                secCurrentSection.Format.EqualColumnWidth = True
                secCurrentSection.Format.Columns = columns
            End If

        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' 'Page Breaks' and 'Section Breaks' Items
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------
        ' ScrollToTextPosition
        ' Scrolls to a specific text position. Based on:
        ' https://docs.textcontrol.com/textcontrol/windows-forms/article.techarticle.howtosscrolltotextposition.htm
        '
        ' Parameters:
        '      textPosition:		The specified text position where to scroll.
        '-----------------------------------------------------------------------------------------------------
        Private Sub ScrollToTextPosition(ByVal textPosition As Integer)
            Dim pntNewScrollLocation As Point
            If textPosition + 1 <= m_txTextControl.TextChars.Count Then
                pntNewScrollLocation = New Point(0, m_txTextControl.TextChars(textPosition + 1).Bounds.Y)
            Else
                pntNewScrollLocation = New Point(0, m_txTextControl.Lines(m_txTextControl.Lines.Count).TextBounds.Y)
            End If
            m_txTextControl.ScrollLocation = pntNewScrollLocation
        End Sub
    End Class
End Namespace
