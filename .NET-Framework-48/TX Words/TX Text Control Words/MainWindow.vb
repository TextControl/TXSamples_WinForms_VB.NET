'-----------------------------------------------------------------------------------------------------------
' MainWindow.vb File
'
' Description:
'     Implements TX Text Control Words.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Imports System.Reflection
Imports System.Resources
Imports TXTextControl.Windows.Forms

Namespace TXTextControl.Words
    Partial Public Class MainWindow
        Inherits Form
        '-----------------------------------------------------------------------------------------------------------
        ' M E M B E R   V A R I A B L E S
        '-----------------------------------------------------------------------------------------------------------
        Private m_plTXLicense As VersionInfo.ProductLevel
        Private ReadOnly m_rmResources As ResourceManager = Nothing

        ' File Info
        ' Values that are updated when opening, creating or saving a document
        Private m_strActiveDocumentName As String = My.Resources.MainWindow_Caption_Untitled ' The document's name is '[Untitled]' on default.
        Private m_stLastLoadedType As StreamType = StreamType.RichTextFormat ' The StreamType that was last used to load a document. If no document has been loaded so far, RichtTextFormat is used. 
        Private m_stLastSavedType As StreamType = StreamType.RichTextFormat ' The StreamType that was last used to save a document. If no document has been saved so far, RichtTextFormat is used. 
        Private m_stActiveDocumentType As StreamType = StreamType.RichTextFormat ' The StreamType that was last used To load Or save the current document.
        Private m_strActiveDocumentPath As String = Nothing ' The path of the active document.
        Private m_strUserPasswordPDF As String = String.Empty ' Tthe password for the user when the document is reopened.
        Private m_strCssFileName As String = Nothing 'The path and filename of a CSS file belonging to a HTML document.
        Private m_svCssSaveMode As CssSaveMode = CssSaveMode.None ' Specifies how to save stylesheet data with a HTML document.
        Private m_bIsUnknownDocument As Boolean = True ' A flag that indicates whether or not the active document is loaded/saved or created (unknown).

        ' A flag that indicates whether or not the document is 'dirty'
        Private m_bIsDirtyDocument As Boolean = False

        '-----------------------------------------------------------------------------------------------------------
        ' C O N S T R U C T O R S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' MainWindow Constructor
        '-----------------------------------------------------------------------------------------------------------
        Public Sub New()
            ' Add an unhandled exception handler
            Dim currentDomain As AppDomain = AppDomain.CurrentDomain
            AddHandler currentDomain.UnhandledException, AddressOf CurrentDomain_UnhandledException

            InitializeComponent()
            ' Create the ResourceManager instance.
            Dim tpMainWindow As Type = [GetType]()
            m_rmResources = New ResourceManager("Resources", tpMainWindow.Assembly)

            ' Get and set saved application settings.
            LoadRightToLeftSettings()
            LoadKnownUserSettings()
            LoadRecentFiles()

            ' Add handlers.
            AddHandler FormClosing, AddressOf MainWindow_FormClosing ' Checks whether the current document is dirty before the application is closed
            AddHandler m_txTextControl.Changed, AddressOf TextControl_Changed ' Updates the internal 'is dirty document' flag
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' O V E R R I D D E N   M E T H O D S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------
        ' OnLoad Method (overridden)
        ' Sets the requested layout and behavior for all added controls.
        '-----------------------------------------------------------------------------------------------------
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            ' Gets the TextControl license level.
            m_plTXLicense = m_txTextControl.GetVersionInfo().Level

            ' Items
            SetItemsDesign()
            SetItemsHandlers()
            CreateShapeAndBarcodeItems()

            ' Main Window
            UpdateMainWindowCaption() ' Set caption

            ' Drag & Drop
            SetDragAndDropBehavior()

            ' Open Hyperlink
            SetOpenHyperlinkBehavior()

            ' Shortcuts
            SetShortcutBehavior()

            ' Tool Bars
            SetRulerBarsDesign()
            SetStatusBarDesign()

            ActiveControl = m_txTextControl
            MyBase.OnLoad(e)
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' M E T H O D S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' UpdateMainWindowCaption Method
        ' Updates the application caption with the name of the active document and the product name.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub UpdateMainWindowCaption()
            Text = m_strActiveDocumentName & If(m_bIsDirtyDocument, "*", "") & " - " & My.Resources.MainWindow_Caption_Product
            Refresh()
        End Sub


        '-----------------------------------------------------------------------------------------------------
        ' SetItemsDesign Method
        ' Sets the texts and images of all menu items.
        '-----------------------------------------------------------------------------------------------------
        Private Sub SetItemsDesign()
            ' 'File'
            SetFileItemsTexts()
            SetFileItemsImages()

            ' 'Edit'
            SetEditItemsTexts()
            SetEditItemsImages()

            ' 'View'
            SetViewItemsTexts()
            SetViewItemsImages()

            ' 'Insert'
            SetInsertItemsTexts()
            SetInsertItemsImages()

            ' 'Format'
            SetFormatItemsTexts()
            SetFormatItemsImages()

            ' 'Table'
            SetTableItemsTexts()
            SetTableItemsImages()
        End Sub

        '-----------------------------------------------------------------------------------------------------
        ' SetItemsHandlers Method
        ' Connects the menu items to Click and DropDownOpening handlers.
        '-----------------------------------------------------------------------------------------------------
        Private Sub SetItemsHandlers()
            ' 'File'
            ConnectFileItemsHandlers()

            ' 'Edit'
            ConnectEditItemsHandlers()

            ' 'View'
            ConnectViewItemsHandlers()

            ' 'Insert'
            ConnectInsertItemsHandlers()

            ' 'Format'
            ConnectFormatItemsHandlers()

            ' 'Table'
            ConnectTableItemsHandlers()
        End Sub

        '-----------------------------------------------------------------------------------------------------
        ' SetItemText Method
        ' Sets the text of the specified item.
        '
        ' Parameters:
        '      item:		The item where to set the text.
        '		args:		Optional: If no string is set, only the resource text that corresponds to the item's
        '					name is set. If one string is set, the resource text is formatted with that string.
        '					If two strings are set, the first string is the text to set and the second string
        '					is the format value.
        '-----------------------------------------------------------------------------------------------------
        Private Sub SetItemText(ByVal item As ToolStripItem, ParamArray args As String())
            Dim strText As String
            Dim strFormat As String
            Select Case args.Length
                Case 0 ' Only the resource text that corresponds to the item's name is set.
                    strText = m_rmResources.GetString("Item_" & item.Name.Substring(5) & "_Text")
                    strFormat = ""
                Case 1 ' The resource text is formatted.
                    strText = m_rmResources.GetString("Item_" & item.Name.Substring(5) & "_Text")
                    strFormat = args(0)
                Case 2 ' Two strings are set: the first string is the text to set and the second string is the format value.
                    strText = args(0)
                    strFormat = args(1)
                Case Else
                    Return

            End Select

            ' Set the text.
            item.Text = String.Format(strText, strFormat)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' SetItemImage Method
        ' Creates an image that correspond to the referenced image id. That image is set as the item's icon.
        '
        ' Parameters:
        '      item:		The item where to set the created image.
        '		iamgeID:	The id of the image to create.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetItemImage(ByVal item As ToolStripMenuItem, ByVal imageID As String)
            item.Image = ResourceProvider.GetSmallIcon(imageID, m_fDPI)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' GetSmallIcon Method
        ' Creates a small bitmap icon from an embedded SVG resource.
        '
        ' Parameters:
        '      path:   The path to the embedded SVG resource.
        '
        ' Returns:     The created small bitmap.
        '-----------------------------------------------------------------------------------------------------------
        Private Function GetSmallIcon(ByVal path As String) As Bitmap
            Dim asm As Assembly = Assembly.GetExecutingAssembly()
            Dim bmp As Bitmap = Nothing

            Using sStream As IO.Stream = asm.GetManifestResourceStream(path)
                bmp = ResourceProvider.GetSmallIcon(sStream, Me)
            End Using
            Return bmp
        End Function


        '-----------------------------------------------------------------------------------------------------------
        ' H A N D L E R S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------
        ' CurrentDomain_UnhandledException Handler
        ' Handles an exception by showing a message box that explains the reason for the exception.
        '-----------------------------------------------------------------------------------------------------
        Friend Shared Sub CurrentDomain_UnhandledException(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs)
            Dim strProductName As String = CType(Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), GetType(AssemblyProductAttribute)), AssemblyProductAttribute).Product
            Dim ex As Exception = CType(e.ExceptionObject, Exception)

            ' TX Text Control Feature is not available
            If TypeOf ex Is LicenseLevelException Then
                MessageBox.Show(String.Format(My.Resources.MessageBox_Application_ThreadException_Text, ex.Message), strProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' All other exceptions
            MessageBox.Show(String.Format(My.Resources.MessageBox_Application_ThreadException_Text, ex.Message), strProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' TextControl_Changed Handler
        '
        ' Updates the 'Is Dirty Document' flag to true if the document changed.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub TextControl_Changed(ByVal sender As Object, ByVal e As EventArgs)
            If m_bIsDirtyDocument <> CSharpImpl.Assign(m_bIsDirtyDocument, True) Then
                ' Update caption and save items enabled state.
                UpdateMainWindowCaption()
            End If
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' MainWindow_FormClosing Handler
        ' Invokes the SaveDirtyDocumentOnExit method to handle dirty documents. If the method returns false, the 
        ' closing of the application will be canceled. If the form closing is not canceled, the recent files
        ' are saved to the My.Settings.Default.RecentFiles property.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub MainWindow_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            If Not (CSharpImpl.Assign(e.Cancel, Not SaveDirtyDocumentOnExit())) Then
                ' Save the recent files to the My.Settings.Default.RecentFiles property
                SaveRecentFiles()
                ' Save the know users to the My.Settings.Default.KnownUsers property
                SaveKnownUserSettings()
            End If
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' C L A S S E S
        '-----------------------------------------------------------------------------------------------------------
        Private Class CSharpImpl
            Shared Function Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
