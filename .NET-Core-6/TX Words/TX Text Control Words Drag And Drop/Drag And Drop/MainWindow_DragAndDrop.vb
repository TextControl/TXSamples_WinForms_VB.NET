'-----------------------------------------------------------------------------------------------------------
' MainWindow_DragAndDrop.vb File
'
' Description:
'     Handles the drag and drop behavior.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Imports System.IO

Namespace TXTextControl.Words
    Partial Class MainWindow

        '-----------------------------------------------------------------------------------------------------------
        ' E N U M S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' FileType Enum
        ' Two different file types can be handled by TX Text Control: documents and images
        '-----------------------------------------------------------------------------------------------------------
        Friend Enum FileType
            Document
            Image
        End Enum


        '-----------------------------------------------------------------------------------------------------------
        ' S U B C L A S S E S 
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' DraggedFileInfo Class
        ' Stores and provides information about the dragged file.
        '-----------------------------------------------------------------------------------------------------------
        Friend Class DraggedFileInfo
            ' Member variables
            Private ReadOnly m_strFilePath As String
            Private ReadOnly m_ftFileType As FileType
            Private ReadOnly m_stStreamType As StreamType

            ' Constructors
            Friend Sub New(ByVal filePath As String)
                m_strFilePath = filePath
                ' If no StreamType is set as parameter, the dragged file is an image.
                m_ftFileType = FileType.Image
            End Sub

            Friend Sub New(ByVal filePath As String, ByVal streamType As StreamType)
                m_strFilePath = filePath
                m_stStreamType = streamType
                ' The specified StreamType indicates that the dragged file is a document.
                m_ftFileType = FileType.Document
            End Sub

            ' Properties

            '-----------------------------------------------------------------------------------------------------
            ' FilePath Property
            ' Returns the file path of the dragged file.
            '-----------------------------------------------------------------------------------------------------
            Friend ReadOnly Property FilePath As String
                Get
                    Return m_strFilePath
                End Get
            End Property

            '-----------------------------------------------------------------------------------------------------
            ' FileType Property
            ' Returns the type of the dragged file.
            '-----------------------------------------------------------------------------------------------------
            Friend ReadOnly Property FileType As FileType
                Get
                    Return m_ftFileType
                End Get
            End Property

            '-----------------------------------------------------------------------------------------------------
            ' StreamType Property
            ' If the dragged file is a document, this property returns the corresponding StreamType.
            '-----------------------------------------------------------------------------------------------------
            Friend ReadOnly Property StreamType As StreamType
                Get
                    Return m_stStreamType
                End Get
            End Property
        End Class


        '-----------------------------------------------------------------------------------------------------------
        ' M E M B E R   V A R I A B L E S
        '-----------------------------------------------------------------------------------------------------------

        Private m_dfiFileInfo As DraggedFileInfo = Nothing


        '-----------------------------------------------------------------------------------------------------------
        ' H A N D L E R S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' TextControl_DragEnter Handler
        ' Gets information about the dragged file.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub TextControl_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
            m_dfiFileInfo = CheckDraggedFiles(CType(e.Data.GetData(DataFormats.FileDrop), String()))
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' TextControl_DragOver Handler
        ' Specifies the target drop effect for the drag & drop operation.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub TextControl_DragOver(ByVal sender As Object, ByVal e As DragEventArgs)
            If (e.AllowedEffect And DragDropEffects.Copy) = DragDropEffects.Copy Then
                e.Effect = DragDropEffects.Copy
            ElseIf (e.AllowedEffect And DragDropEffects.Move) = DragDropEffects.Move Then
                e.Effect = DragDropEffects.Move
            Else
                e.Effect = DragDropEffects.None
            End If
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' TextControl_DragDrop Handler
        ' Inserts the dragged document or image into the TextControl.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub TextControl_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
            ' Check whether the dragged file is valid (supported by TX Text Control).
            If m_dfiFileInfo IsNot Nothing Then
                ' Insert the file as document or image.
                Select Case m_dfiFileInfo.FileType
                    Case FileType.Document
                        Open(m_dfiFileInfo.FilePath, m_dfiFileInfo.StreamType)
                    Case FileType.Image
                        InsertDroppedImage(m_dfiFileInfo.FilePath)
                End Select
                m_dfiFileInfo = Nothing
            End If
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' M E T H O D S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' SetDragAndDropBehavior Method
        ' Adds all necessary handlers to implement a drag and drop behavior.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetDragAndDropBehavior()
            AddHandler m_txTextControl.DragEnter, AddressOf TextControl_DragEnter ' Gets information about the dragged file.
            AddHandler m_txTextControl.DragOver, AddressOf TextControl_DragOver ' Specifies the target drop effect for the drag & drop operation.
            AddHandler m_txTextControl.DragDrop, AddressOf TextControl_DragDrop ' Inserts the dragged document or image into the TextControl.
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' InsertDroppedImage Method
        ' Inserts the dropped image into the TextControl
        '
        ' Parameters:
        '      filePath: The file path of the image to insert.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub InsertDroppedImage(ByVal filePath As String)
            ' Get pixel position of mouse cursor inside the TextControl
            Dim pntCursorPosition As Point = m_txTextControl.PointToClient(Cursor.Position)

            ' Get bounding rectangle of the first character of the paragraph
            ' the image was dropped over
            Dim parCurrentParagraph As Paragraph = m_txTextControl.Paragraphs.GetItem(pntCursorPosition)
            Dim tcParagraphStartChar As TextChar = m_txTextControl.TextChars(parCurrentParagraph.Start)
            Dim pntParagraphLocation As Point = If(tcParagraphStartChar IsNot Nothing, tcParagraphStartChar.Bounds.Location, Point.Empty)

            ' Get bounding rectangle of the character the image was dropped over
            Dim tcCursorPositionChar As TextChar = m_txTextControl.TextChars.GetItem(pntCursorPosition, True)
            Dim recCursorPositionChar As Rectangle = If(tcCursorPositionChar IsNot Nothing, tcCursorPositionChar.Bounds, Rectangle.Empty)

            ' Calculate image position relative to paragraph position
            Dim pntImagePosition As Point = New Point(recCursorPositionChar.Right - pntParagraphLocation.X, recCursorPositionChar.Top - pntParagraphLocation.Y)

            ' Insert image anchored to paragraph
            Dim imgImage As Image = New Image() With {
                .FileName = filePath
            }
            m_txTextControl.Images.Add(imgImage, pntImagePosition, parCurrentParagraph.Start, ImageInsertionMode.DisplaceText)
        End Sub

        '----------------------------------------------------------------------------------------------------------
        ' CheckDraggedFiles Method
        ' Determines the file type, stream type (for document files) and file path of the dragged file.
        '
        ' Parameters:
        '      fileList:   The file list where the dragged file is stored.
        '
        ' Return value:    An object of type DraggedFileInfo that stores information about the dragged 
        '                  file. If the file format is not supported by TX Text Control, the method returns
        '                  null.
        '----------------------------------------------------------------------------------------------------------
        Friend Function CheckDraggedFiles(ByVal fileList As String()) As DraggedFileInfo
            If fileList IsNot Nothing Then
                ' Get first parameter from the list and check if it is a supported file type
                Dim strFilePath As String = fileList(0)

                Select Case Path.GetExtension(strFilePath).ToLower()
                    ' Documents
                    Case ".rtf"
                        Return New DraggedFileInfo(strFilePath, StreamType.RichTextFormat)
                    Case ".htm", ".html"
                        Return New DraggedFileInfo(strFilePath, StreamType.HTMLFormat)
                    Case ".doc"
                        Return New DraggedFileInfo(strFilePath, StreamType.MSWord)
                    Case ".docx"
                        Return New DraggedFileInfo(strFilePath, StreamType.WordprocessingML)
                    Case ".pdf"
                        Return New DraggedFileInfo(strFilePath, StreamType.AdobePDF)
                    Case ".xml"
                        Return New DraggedFileInfo(strFilePath, StreamType.XMLFormat)
                    Case ".txt"
                        Return New DraggedFileInfo(strFilePath, StreamType.PlainText)
                    Case ".tx"
                        Return New DraggedFileInfo(strFilePath, StreamType.InternalUnicodeFormat)
                    Case ".xlsx"
                        Return New DraggedFileInfo(strFilePath, StreamType.SpreadsheetML)
                    ' Images
                    Case ".jpeg", ".jpg", ".tif", ".tiff", ".bmp", ".gif", ".png", ".wmf", ".emf", ".svg"
                        Return If(m_txTextControl.CanEdit, New DraggedFileInfo(strFilePath), Nothing)
                    Case Else
                        Return Nothing
                End Select
            End If
            Return Nothing
        End Function
    End Class
End Namespace
