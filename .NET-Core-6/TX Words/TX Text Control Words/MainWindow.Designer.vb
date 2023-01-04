
Namespace TXTextControl.Words
    Partial Class MainWindow
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
            Me.m_msMenu = New System.Windows.Forms.MenuStrip()
            Me.m_tmiFile = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFile_New = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFile_Open = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFile_RecentFiles = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspFile_Separator01 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiFile_Save = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFile_SaveAs = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspFile_Separator02 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiFile_PageSetup = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFile_PrintPreview = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFile_Print = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFile_PrintQuick = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspFile_Separator03 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiFile_SignIn = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFile_CurrentUser = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFile_CurrentUser_AccountSettings = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFile_CurrentUser_SignOut = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFile_Exit = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_Undo = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_Redo = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspEdit_Separator01 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiEdit_Cut = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_Copy = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_Paste = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspEdit_Separator02 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiEdit_SelectAll = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspEdit_Separator03 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiEdit_Find = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_Replace = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspEdit_Separator04 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiEdit_Permissions = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_Permissions_AllowFormatting = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_Permissions_AllowFormattingStyles = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_Permissions_AllowPrinting = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_Permissions_AllowCopy = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_Permissions_AllowEditingFormFields = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_Permissions_ReadOnly = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_EditableRegions = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_EditableRegions_Add = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_EditableRegions_Add_ForCurrentUser = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_EditableRegions_Add_ForEveryone = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_EditableRegions_Remove = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_EditableRegions_Remove_ForCurrentUser = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_EditableRegions_Remove_ForEveryone = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_ProtectDocument = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspEdit_Separator05 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiEdit_TrackedChanges = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_TrackedChanges_TrackChanges = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_TrackedChanges_ReviewTrackedChanges = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_Comments = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_Comments_AddComment = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiEdit_Comments_ReviewComments = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_PageLayout = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_Draft = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspView_Separator01 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiView_ButtonBar = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_StatusBar = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_HorizontalRuler = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_VerticalRuler = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspView_Separator02 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiView_TableGridlines = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_BookmarkMarkers = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_TextFrameMarkerLines = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_DrawingMarkerLines = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_ControlChars = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspView_Separator03 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiView_EditableRegions = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_EditableRegions_Always = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_EditableRegions_Current = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_EditableRegions_Never = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_TrackedChanges = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_Comments = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_Comments_Always = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_Comments_Current = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_Comments_Never = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspView_Separator04 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiView_Zoom = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_Zoom_50 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_Zoom_75 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_Zoom_100 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_Zoom_150 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_Zoom_200 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_Zoom_300 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiView_Zoom_400 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspView_Separator05 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiView_RightToLeftLayout = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_File = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspInsert_Separator01 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiInsert_Image = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_TextFrame = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_Shape = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_Shape_Lines = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_Shape_Rectangles = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_Shape_BasicShapes = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_Shape_BlockArrows = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_Shape_EquationShapes = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_Shape_Flowchart = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_Shape_StarsAndBanners = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_Shape_Callouts = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspInsert_Shape_Separator01 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiInsert_Shape_DrawingCanvas = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_Barcode = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspInsert_Separator02 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiInsert_Header = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_Header_Insert = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_Header_Remove = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_Footer = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_Footer_Insert = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_Footer_Remove = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_PageNumber = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_PageNumber_Insert = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_PageNumber_Delete = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspInsert_Separator03 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiInsert_FormField = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_FormField_TextFormField = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_FormField_CheckBox = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_FormField_ComboBox = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_FormField_DropDownList = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_FormField_DateFormField = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspInsert_FormField_Separator01 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiInsert_FormField_Delete = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspInsert_Separator04 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiInsert_Symbol = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspInsert_Separator05 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiInsert_Hyperlink = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_Bookmark = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_Bookmark_Insert = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_Bookmark_Delete = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_TableOfContents = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_TableOfContents_Insert = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_TableOfContents_Delete = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_TableOfContents_Update = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspInsert_Separator06 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiInsert_Columns = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_Columns_One = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_Columns_Two = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspInsert_Columns_Separator01 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiInsert_Columns_MoreColumns = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_PageBreaks = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_PageBreaks_Page = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_PageBreaks_Column = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_PageBreaks_TextWrapping = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_SectionBreaks = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_SectionBreaks_NextPage = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiInsert_SectionBreaks_Continuous = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_Character = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_Paragraph = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_Styles = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_BodyText = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level01 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level02 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level03 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level04 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level05 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level06 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level07 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level08 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level09 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level10 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_BodyText = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level01 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level02 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level03 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level04 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level05 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level06 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level07 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level08 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level09 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level10 = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_BulletsAndNumbering = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_BulletsAndNumbering_ArabicNumbers = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_BulletsAndNumbering_CapitalLetters = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_BulletsAndNumbering_Letters = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_BulletsAndNumbering_RomanNumbers = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_BulletsAndNumbering_SmallRomanNumbers = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_BulletsAndNumbering_AsStructuredList = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspFormat_BulletsAndNumbering_Separator01 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiFormat_BulletsAndNumbering_Bullets = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspFormat_BulletsAndNumbering_Separator02 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiFormat_BulletsAndNumbering_IncreaseLevel = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_BulletsAndNumbering_DecreaseLevel = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspFormat_BulletsAndNumbering_Separator03 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiFormat_BulletsAndNumbering_Properties = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspFormat_Separator01 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiFormat_Image = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_TextFrame = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_Shape = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_Barcode = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspFormat_Separator02 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiFormat_HeadersAndFooters = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_PageNumberField = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspFormat_Separator03 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiFormat_FormFields = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_FormFields_Edit = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspFormat_FormFields_Separator01 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiFormat_FormFields_EnableFormValidation = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_FormFields_ManageConditionalInstructions = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspFormat_Separator04 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiFormat_Hyperlink = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_Bookmark = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_TableOfContents = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspFormat_Separator05 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiFormat_Columns = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_PageBorders = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_PageColor = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiFormat_Tabs = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspFormat_Separator06 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiFormat_Language = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable_Insert = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable_Insert_Table = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspTable_Insert_Separator01 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiTable_Insert_ColumnToTheLeft = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable_Insert_ColumnToTheRight = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspTable_Insert_Separator02 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiTable_Insert_RowAbove = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable_Insert_RowBelow = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable_Delete = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable_Delete_Cells = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable_Delete_Columns = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable_Delete_Rows = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable_Delete_Table = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable_Select = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable_Select_Cell = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable_Select_Column = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable_Select_Row = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable_Select_Table = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspTable_Separator01 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiTable_MergeCells = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable_SplitCells = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable_SplitTable = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable_SplitTable_Above = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable_SplitTable_Below = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspTable_Separator02 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiTable_Formulas = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable_Formulas_A1ReferenceStyle = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tmiTable_Formulas_R1C1ReferenceStyle = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspTable_Formulas_Separator01 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiTable_Formulas_EditFormula = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspTable_Formulas_Separator02 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiTable_Formulas_AutomaticCalculation = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_tspTable_Separator03 = New System.Windows.Forms.ToolStripSeparator()
            Me.m_tmiTable_Properties = New System.Windows.Forms.ToolStripMenuItem()
            Me.m_bbButtonBar = New TXTextControl.ButtonBar()
            Me.m_sbStatusBar = New TXTextControl.StatusBar()
            Me.m_txTextControl = New TXTextControl.TextControl()
            Me.m_rbHorizontalRulerBar = New TXTextControl.RulerBar()
            Me.m_rbVerticalRulerBar = New TXTextControl.RulerBar()
            Me.m_msMenu.SuspendLayout()
            Me.SuspendLayout()
            '
            'm_msMenu
            '
            Me.m_msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiFile, Me.m_tmiEdit, Me.m_tmiView, Me.m_tmiInsert, Me.m_tmiFormat, Me.m_tmiTable})
            Me.m_msMenu.Location = New System.Drawing.Point(0, 0)
            Me.m_msMenu.Name = "m_msMenu"
            Me.m_msMenu.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.m_msMenu.Size = New System.Drawing.Size(1034, 24)
            Me.m_msMenu.TabIndex = 0
            Me.m_msMenu.Text = "m_msMenuStrip"
            '
            'm_tmiFile
            '
            Me.m_tmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiFile_New, Me.m_tmiFile_Open, Me.m_tmiFile_RecentFiles, Me.m_tspFile_Separator01, Me.m_tmiFile_Save, Me.m_tmiFile_SaveAs, Me.m_tspFile_Separator02, Me.m_tmiFile_PageSetup, Me.m_tmiFile_PrintPreview, Me.m_tmiFile_Print, Me.m_tmiFile_PrintQuick, Me.m_tspFile_Separator03, Me.m_tmiFile_SignIn, Me.m_tmiFile_CurrentUser, Me.m_tmiFile_Exit})
            Me.m_tmiFile.Name = "m_tmiFile"
            Me.m_tmiFile.Size = New System.Drawing.Size(37, 20)
            Me.m_tmiFile.Text = "&File"
            '
            'm_tmiFile_New
            '
            Me.m_tmiFile_New.Name = "m_tmiFile_New"
            Me.m_tmiFile_New.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
            Me.m_tmiFile_New.Size = New System.Drawing.Size(155, 22)
            Me.m_tmiFile_New.Text = "&New"
            '
            'm_tmiFile_Open
            '
            Me.m_tmiFile_Open.Name = "m_tmiFile_Open"
            Me.m_tmiFile_Open.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
            Me.m_tmiFile_Open.Size = New System.Drawing.Size(155, 22)
            Me.m_tmiFile_Open.Text = "&Open…"
            '
            'm_tmiFile_RecentFiles
            '
            Me.m_tmiFile_RecentFiles.Name = "m_tmiFile_RecentFiles"
            Me.m_tmiFile_RecentFiles.Size = New System.Drawing.Size(155, 22)
            Me.m_tmiFile_RecentFiles.Text = "&Recent Files"
            '
            'm_tspFile_Separator01
            '
            Me.m_tspFile_Separator01.Name = "m_tspFile_Separator01"
            Me.m_tspFile_Separator01.Size = New System.Drawing.Size(152, 6)
            '
            'm_tmiFile_Save
            '
            Me.m_tmiFile_Save.Enabled = False
            Me.m_tmiFile_Save.Name = "m_tmiFile_Save"
            Me.m_tmiFile_Save.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
            Me.m_tmiFile_Save.Size = New System.Drawing.Size(155, 22)
            Me.m_tmiFile_Save.Text = "&Save"
            '
            'm_tmiFile_SaveAs
            '
            Me.m_tmiFile_SaveAs.Name = "m_tmiFile_SaveAs"
            Me.m_tmiFile_SaveAs.Size = New System.Drawing.Size(155, 22)
            Me.m_tmiFile_SaveAs.Text = "Save &As…"
            '
            'm_tspFile_Separator02
            '
            Me.m_tspFile_Separator02.Name = "m_tspFile_Separator02"
            Me.m_tspFile_Separator02.Size = New System.Drawing.Size(152, 6)
            '
            'm_tmiFile_PageSetup
            '
            Me.m_tmiFile_PageSetup.Name = "m_tmiFile_PageSetup"
            Me.m_tmiFile_PageSetup.Size = New System.Drawing.Size(155, 22)
            Me.m_tmiFile_PageSetup.Text = "Page Se&tup…"
            '
            'm_tmiFile_PrintPreview
            '
            Me.m_tmiFile_PrintPreview.Name = "m_tmiFile_PrintPreview"
            Me.m_tmiFile_PrintPreview.Size = New System.Drawing.Size(155, 22)
            Me.m_tmiFile_PrintPreview.Text = "Print Pre&view..."
            '
            'm_tmiFile_Print
            '
            Me.m_tmiFile_Print.Name = "m_tmiFile_Print"
            Me.m_tmiFile_Print.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
            Me.m_tmiFile_Print.Size = New System.Drawing.Size(155, 22)
            Me.m_tmiFile_Print.Text = "&Print..."
            '
            'm_tmiFile_PrintQuick
            '
            Me.m_tmiFile_PrintQuick.Name = "m_tmiFile_PrintQuick"
            Me.m_tmiFile_PrintQuick.Size = New System.Drawing.Size(155, 22)
            Me.m_tmiFile_PrintQuick.Text = "Print &Quick"
            '
            'm_tspFile_Separator03
            '
            Me.m_tspFile_Separator03.Name = "m_tspFile_Separator03"
            Me.m_tspFile_Separator03.Size = New System.Drawing.Size(152, 6)
            '
            'm_tmiFile_SignIn
            '
            Me.m_tmiFile_SignIn.Name = "m_tmiFile_SignIn"
            Me.m_tmiFile_SignIn.Size = New System.Drawing.Size(155, 22)
            Me.m_tmiFile_SignIn.Text = "Sign &In..."
            '
            'm_tmiFile_CurrentUser
            '
            Me.m_tmiFile_CurrentUser.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiFile_CurrentUser_AccountSettings, Me.m_tmiFile_CurrentUser_SignOut})
            Me.m_tmiFile_CurrentUser.Name = "m_tmiFile_CurrentUser"
            Me.m_tmiFile_CurrentUser.Size = New System.Drawing.Size(155, 22)
            Me.m_tmiFile_CurrentUser.Text = "[Current User]"
            Me.m_tmiFile_CurrentUser.Visible = False
            '
            'm_tmiFile_CurrentUser_AccountSettings
            '
            Me.m_tmiFile_CurrentUser_AccountSettings.Name = "m_tmiFile_CurrentUser_AccountSettings"
            Me.m_tmiFile_CurrentUser_AccountSettings.Size = New System.Drawing.Size(173, 22)
            Me.m_tmiFile_CurrentUser_AccountSettings.Text = "&Account Settings..."
            '
            'm_tmiFile_CurrentUser_SignOut
            '
            Me.m_tmiFile_CurrentUser_SignOut.Name = "m_tmiFile_CurrentUser_SignOut"
            Me.m_tmiFile_CurrentUser_SignOut.Size = New System.Drawing.Size(173, 22)
            Me.m_tmiFile_CurrentUser_SignOut.Text = "Sign &Out"
            '
            'm_tmiFile_Exit
            '
            Me.m_tmiFile_Exit.Name = "m_tmiFile_Exit"
            Me.m_tmiFile_Exit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
            Me.m_tmiFile_Exit.Size = New System.Drawing.Size(155, 22)
            Me.m_tmiFile_Exit.Text = "E&xit"
            '
            'm_tmiEdit
            '
            Me.m_tmiEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiEdit_Undo, Me.m_tmiEdit_Redo, Me.m_tspEdit_Separator01, Me.m_tmiEdit_Cut, Me.m_tmiEdit_Copy, Me.m_tmiEdit_Paste, Me.m_tspEdit_Separator02, Me.m_tmiEdit_SelectAll, Me.m_tspEdit_Separator03, Me.m_tmiEdit_Find, Me.m_tmiEdit_Replace, Me.m_tspEdit_Separator04, Me.m_tmiEdit_Permissions, Me.m_tmiEdit_EditableRegions, Me.m_tmiEdit_ProtectDocument, Me.m_tspEdit_Separator05, Me.m_tmiEdit_TrackedChanges, Me.m_tmiEdit_Comments})
            Me.m_tmiEdit.Name = "m_tmiEdit"
            Me.m_tmiEdit.Size = New System.Drawing.Size(39, 20)
            Me.m_tmiEdit.Text = "&Edit"
            '
            'm_tmiEdit_Undo
            '
            Me.m_tmiEdit_Undo.Enabled = False
            Me.m_tmiEdit_Undo.Name = "m_tmiEdit_Undo"
            Me.m_tmiEdit_Undo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
            Me.m_tmiEdit_Undo.Size = New System.Drawing.Size(171, 22)
            Me.m_tmiEdit_Undo.Text = "&Undo"
            '
            'm_tmiEdit_Redo
            '
            Me.m_tmiEdit_Redo.Enabled = False
            Me.m_tmiEdit_Redo.Name = "m_tmiEdit_Redo"
            Me.m_tmiEdit_Redo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
            Me.m_tmiEdit_Redo.Size = New System.Drawing.Size(171, 22)
            Me.m_tmiEdit_Redo.Text = "&Redo"
            '
            'm_tspEdit_Separator01
            '
            Me.m_tspEdit_Separator01.Name = "m_tspEdit_Separator01"
            Me.m_tspEdit_Separator01.Size = New System.Drawing.Size(168, 6)
            '
            'm_tmiEdit_Cut
            '
            Me.m_tmiEdit_Cut.Name = "m_tmiEdit_Cut"
            Me.m_tmiEdit_Cut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
            Me.m_tmiEdit_Cut.Size = New System.Drawing.Size(171, 22)
            Me.m_tmiEdit_Cut.Text = "Cu&t"
            '
            'm_tmiEdit_Copy
            '
            Me.m_tmiEdit_Copy.Name = "m_tmiEdit_Copy"
            Me.m_tmiEdit_Copy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
            Me.m_tmiEdit_Copy.Size = New System.Drawing.Size(171, 22)
            Me.m_tmiEdit_Copy.Text = "&Copy"
            '
            'm_tmiEdit_Paste
            '
            Me.m_tmiEdit_Paste.Name = "m_tmiEdit_Paste"
            Me.m_tmiEdit_Paste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
            Me.m_tmiEdit_Paste.Size = New System.Drawing.Size(171, 22)
            Me.m_tmiEdit_Paste.Text = "&Paste"
            '
            'm_tspEdit_Separator02
            '
            Me.m_tspEdit_Separator02.Name = "m_tspEdit_Separator02"
            Me.m_tspEdit_Separator02.Size = New System.Drawing.Size(168, 6)
            '
            'm_tmiEdit_SelectAll
            '
            Me.m_tmiEdit_SelectAll.Name = "m_tmiEdit_SelectAll"
            Me.m_tmiEdit_SelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
            Me.m_tmiEdit_SelectAll.Size = New System.Drawing.Size(171, 22)
            Me.m_tmiEdit_SelectAll.Text = "Select &All"
            '
            'm_tspEdit_Separator03
            '
            Me.m_tspEdit_Separator03.Name = "m_tspEdit_Separator03"
            Me.m_tspEdit_Separator03.Size = New System.Drawing.Size(168, 6)
            '
            'm_tmiEdit_Find
            '
            Me.m_tmiEdit_Find.Name = "m_tmiEdit_Find"
            Me.m_tmiEdit_Find.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
            Me.m_tmiEdit_Find.Size = New System.Drawing.Size(171, 22)
            Me.m_tmiEdit_Find.Text = "&Find..."
            '
            'm_tmiEdit_Replace
            '
            Me.m_tmiEdit_Replace.Name = "m_tmiEdit_Replace"
            Me.m_tmiEdit_Replace.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
            Me.m_tmiEdit_Replace.Size = New System.Drawing.Size(171, 22)
            Me.m_tmiEdit_Replace.Text = "Rep&lace..."
            '
            'm_tspEdit_Separator04
            '
            Me.m_tspEdit_Separator04.Name = "m_tspEdit_Separator04"
            Me.m_tspEdit_Separator04.Size = New System.Drawing.Size(168, 6)
            '
            'm_tmiEdit_Permissions
            '
            Me.m_tmiEdit_Permissions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiEdit_Permissions_AllowFormatting, Me.m_tmiEdit_Permissions_AllowFormattingStyles, Me.m_tmiEdit_Permissions_AllowPrinting, Me.m_tmiEdit_Permissions_AllowCopy, Me.m_tmiEdit_Permissions_AllowEditingFormFields, Me.m_tmiEdit_Permissions_ReadOnly})
            Me.m_tmiEdit_Permissions.Name = "m_tmiEdit_Permissions"
            Me.m_tmiEdit_Permissions.Size = New System.Drawing.Size(171, 22)
            Me.m_tmiEdit_Permissions.Text = "Permi&ssions"
            '
            'm_tmiEdit_Permissions_AllowFormatting
            '
            Me.m_tmiEdit_Permissions_AllowFormatting.CheckOnClick = True
            Me.m_tmiEdit_Permissions_AllowFormatting.Name = "m_tmiEdit_Permissions_AllowFormatting"
            Me.m_tmiEdit_Permissions_AllowFormatting.Size = New System.Drawing.Size(208, 22)
            Me.m_tmiEdit_Permissions_AllowFormatting.Text = "Allow &Formatting"
            '
            'm_tmiEdit_Permissions_AllowFormattingStyles
            '
            Me.m_tmiEdit_Permissions_AllowFormattingStyles.CheckOnClick = True
            Me.m_tmiEdit_Permissions_AllowFormattingStyles.Name = "m_tmiEdit_Permissions_AllowFormattingStyles"
            Me.m_tmiEdit_Permissions_AllowFormattingStyles.Size = New System.Drawing.Size(208, 22)
            Me.m_tmiEdit_Permissions_AllowFormattingStyles.Text = "Allow Formatting &Styles"
            '
            'm_tmiEdit_Permissions_AllowPrinting
            '
            Me.m_tmiEdit_Permissions_AllowPrinting.CheckOnClick = True
            Me.m_tmiEdit_Permissions_AllowPrinting.Name = "m_tmiEdit_Permissions_AllowPrinting"
            Me.m_tmiEdit_Permissions_AllowPrinting.Size = New System.Drawing.Size(208, 22)
            Me.m_tmiEdit_Permissions_AllowPrinting.Text = "Allow &Printing"
            '
            'm_tmiEdit_Permissions_AllowCopy
            '
            Me.m_tmiEdit_Permissions_AllowCopy.CheckOnClick = True
            Me.m_tmiEdit_Permissions_AllowCopy.Name = "m_tmiEdit_Permissions_AllowCopy"
            Me.m_tmiEdit_Permissions_AllowCopy.Size = New System.Drawing.Size(208, 22)
            Me.m_tmiEdit_Permissions_AllowCopy.Text = "Allow &Copy"
            '
            'm_tmiEdit_Permissions_AllowEditingFormFields
            '
            Me.m_tmiEdit_Permissions_AllowEditingFormFields.CheckOnClick = True
            Me.m_tmiEdit_Permissions_AllowEditingFormFields.Name = "m_tmiEdit_Permissions_AllowEditingFormFields"
            Me.m_tmiEdit_Permissions_AllowEditingFormFields.Size = New System.Drawing.Size(208, 22)
            Me.m_tmiEdit_Permissions_AllowEditingFormFields.Text = "Allow &Editing Form Fields"
            '
            'm_tmiEdit_Permissions_ReadOnly
            '
            Me.m_tmiEdit_Permissions_ReadOnly.CheckOnClick = True
            Me.m_tmiEdit_Permissions_ReadOnly.Name = "m_tmiEdit_Permissions_ReadOnly"
            Me.m_tmiEdit_Permissions_ReadOnly.Size = New System.Drawing.Size(208, 22)
            Me.m_tmiEdit_Permissions_ReadOnly.Text = "&Read Only"
            '
            'm_tmiEdit_EditableRegions
            '
            Me.m_tmiEdit_EditableRegions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiEdit_EditableRegions_Add, Me.m_tmiEdit_EditableRegions_Remove})
            Me.m_tmiEdit_EditableRegions.Name = "m_tmiEdit_EditableRegions"
            Me.m_tmiEdit_EditableRegions.Size = New System.Drawing.Size(171, 22)
            Me.m_tmiEdit_EditableRegions.Text = "&Editable Regions"
            '
            'm_tmiEdit_EditableRegions_Add
            '
            Me.m_tmiEdit_EditableRegions_Add.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiEdit_EditableRegions_Add_ForCurrentUser, Me.m_tmiEdit_EditableRegions_Add_ForEveryone})
            Me.m_tmiEdit_EditableRegions_Add.Name = "m_tmiEdit_EditableRegions_Add"
            Me.m_tmiEdit_EditableRegions_Add.Size = New System.Drawing.Size(117, 22)
            Me.m_tmiEdit_EditableRegions_Add.Text = "&Add"
            '
            'm_tmiEdit_EditableRegions_Add_ForCurrentUser
            '
            Me.m_tmiEdit_EditableRegions_Add_ForCurrentUser.Name = "m_tmiEdit_EditableRegions_Add_ForCurrentUser"
            Me.m_tmiEdit_EditableRegions_Add_ForCurrentUser.Size = New System.Drawing.Size(168, 22)
            Me.m_tmiEdit_EditableRegions_Add_ForCurrentUser.Text = "For [Current User]"
            '
            'm_tmiEdit_EditableRegions_Add_ForEveryone
            '
            Me.m_tmiEdit_EditableRegions_Add_ForEveryone.Name = "m_tmiEdit_EditableRegions_Add_ForEveryone"
            Me.m_tmiEdit_EditableRegions_Add_ForEveryone.Size = New System.Drawing.Size(168, 22)
            Me.m_tmiEdit_EditableRegions_Add_ForEveryone.Text = "For Everyone"
            '
            'm_tmiEdit_EditableRegions_Remove
            '
            Me.m_tmiEdit_EditableRegions_Remove.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiEdit_EditableRegions_Remove_ForCurrentUser, Me.m_tmiEdit_EditableRegions_Remove_ForEveryone})
            Me.m_tmiEdit_EditableRegions_Remove.Name = "m_tmiEdit_EditableRegions_Remove"
            Me.m_tmiEdit_EditableRegions_Remove.Size = New System.Drawing.Size(117, 22)
            Me.m_tmiEdit_EditableRegions_Remove.Text = "&Remove"
            '
            'm_tmiEdit_EditableRegions_Remove_ForCurrentUser
            '
            Me.m_tmiEdit_EditableRegions_Remove_ForCurrentUser.Name = "m_tmiEdit_EditableRegions_Remove_ForCurrentUser"
            Me.m_tmiEdit_EditableRegions_Remove_ForCurrentUser.Size = New System.Drawing.Size(168, 22)
            Me.m_tmiEdit_EditableRegions_Remove_ForCurrentUser.Text = "For [Current User]"
            '
            'm_tmiEdit_EditableRegions_Remove_ForEveryone
            '
            Me.m_tmiEdit_EditableRegions_Remove_ForEveryone.Name = "m_tmiEdit_EditableRegions_Remove_ForEveryone"
            Me.m_tmiEdit_EditableRegions_Remove_ForEveryone.Size = New System.Drawing.Size(168, 22)
            Me.m_tmiEdit_EditableRegions_Remove_ForEveryone.Text = "For Everyone"
            '
            'm_tmiEdit_ProtectDocument
            '
            Me.m_tmiEdit_ProtectDocument.CheckOnClick = True
            Me.m_tmiEdit_ProtectDocument.Name = "m_tmiEdit_ProtectDocument"
            Me.m_tmiEdit_ProtectDocument.Size = New System.Drawing.Size(171, 22)
            Me.m_tmiEdit_ProtectDocument.Text = "Pr&otect Document"
            '
            'm_tspEdit_Separator05
            '
            Me.m_tspEdit_Separator05.Name = "m_tspEdit_Separator05"
            Me.m_tspEdit_Separator05.Size = New System.Drawing.Size(168, 6)
            '
            'm_tmiEdit_TrackedChanges
            '
            Me.m_tmiEdit_TrackedChanges.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiEdit_TrackedChanges_TrackChanges, Me.m_tmiEdit_TrackedChanges_ReviewTrackedChanges})
            Me.m_tmiEdit_TrackedChanges.Name = "m_tmiEdit_TrackedChanges"
            Me.m_tmiEdit_TrackedChanges.Size = New System.Drawing.Size(171, 22)
            Me.m_tmiEdit_TrackedChanges.Text = "Trac&ked Changes"
            '
            'm_tmiEdit_TrackedChanges_TrackChanges
            '
            Me.m_tmiEdit_TrackedChanges_TrackChanges.CheckOnClick = True
            Me.m_tmiEdit_TrackedChanges_TrackChanges.Name = "m_tmiEdit_TrackedChanges_TrackChanges"
            Me.m_tmiEdit_TrackedChanges_TrackChanges.Size = New System.Drawing.Size(212, 22)
            Me.m_tmiEdit_TrackedChanges_TrackChanges.Text = "&Track Changes"
            '
            'm_tmiEdit_TrackedChanges_ReviewTrackedChanges
            '
            Me.m_tmiEdit_TrackedChanges_ReviewTrackedChanges.Name = "m_tmiEdit_TrackedChanges_ReviewTrackedChanges"
            Me.m_tmiEdit_TrackedChanges_ReviewTrackedChanges.Size = New System.Drawing.Size(212, 22)
            Me.m_tmiEdit_TrackedChanges_ReviewTrackedChanges.Text = "&Review Tracked Changes..."
            '
            'm_tmiEdit_Comments
            '
            Me.m_tmiEdit_Comments.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiEdit_Comments_AddComment, Me.m_tmiEdit_Comments_ReviewComments})
            Me.m_tmiEdit_Comments.Name = "m_tmiEdit_Comments"
            Me.m_tmiEdit_Comments.Size = New System.Drawing.Size(171, 22)
            Me.m_tmiEdit_Comments.Text = "Co&mments"
            '
            'm_tmiEdit_Comments_AddComment
            '
            Me.m_tmiEdit_Comments_AddComment.Name = "m_tmiEdit_Comments_AddComment"
            Me.m_tmiEdit_Comments_AddComment.Size = New System.Drawing.Size(182, 22)
            Me.m_tmiEdit_Comments_AddComment.Text = "&Add Comment..."
            '
            'm_tmiEdit_Comments_ReviewComments
            '
            Me.m_tmiEdit_Comments_ReviewComments.Name = "m_tmiEdit_Comments_ReviewComments"
            Me.m_tmiEdit_Comments_ReviewComments.Size = New System.Drawing.Size(182, 22)
            Me.m_tmiEdit_Comments_ReviewComments.Text = "&Review Comments..."
            '
            'm_tmiView
            '
            Me.m_tmiView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiView_PageLayout, Me.m_tmiView_Draft, Me.m_tspView_Separator01, Me.m_tmiView_ButtonBar, Me.m_tmiView_StatusBar, Me.m_tmiView_HorizontalRuler, Me.m_tmiView_VerticalRuler, Me.m_tspView_Separator02, Me.m_tmiView_TableGridlines, Me.m_tmiView_BookmarkMarkers, Me.m_tmiView_TextFrameMarkerLines, Me.m_tmiView_DrawingMarkerLines, Me.m_tmiView_ControlChars, Me.m_tspView_Separator03, Me.m_tmiView_EditableRegions, Me.m_tmiView_TrackedChanges, Me.m_tmiView_Comments, Me.m_tspView_Separator04, Me.m_tmiView_Zoom, Me.m_tspView_Separator05, Me.m_tmiView_RightToLeftLayout})
            Me.m_tmiView.Name = "m_tmiView"
            Me.m_tmiView.Size = New System.Drawing.Size(44, 20)
            Me.m_tmiView.Text = "&View"
            '
            'm_tmiView_PageLayout
            '
            Me.m_tmiView_PageLayout.CheckOnClick = True
            Me.m_tmiView_PageLayout.Name = "m_tmiView_PageLayout"
            Me.m_tmiView_PageLayout.Size = New System.Drawing.Size(201, 22)
            Me.m_tmiView_PageLayout.Text = "&Page Layout"
            '
            'm_tmiView_Draft
            '
            Me.m_tmiView_Draft.CheckOnClick = True
            Me.m_tmiView_Draft.Name = "m_tmiView_Draft"
            Me.m_tmiView_Draft.Size = New System.Drawing.Size(201, 22)
            Me.m_tmiView_Draft.Text = "&Draft"
            '
            'm_tspView_Separator01
            '
            Me.m_tspView_Separator01.Name = "m_tspView_Separator01"
            Me.m_tspView_Separator01.Size = New System.Drawing.Size(198, 6)
            '
            'm_tmiView_ButtonBar
            '
            Me.m_tmiView_ButtonBar.CheckOnClick = True
            Me.m_tmiView_ButtonBar.Name = "m_tmiView_ButtonBar"
            Me.m_tmiView_ButtonBar.Size = New System.Drawing.Size(201, 22)
            Me.m_tmiView_ButtonBar.Text = "&Button Bar"
            '
            'm_tmiView_StatusBar
            '
            Me.m_tmiView_StatusBar.CheckOnClick = True
            Me.m_tmiView_StatusBar.Name = "m_tmiView_StatusBar"
            Me.m_tmiView_StatusBar.Size = New System.Drawing.Size(201, 22)
            Me.m_tmiView_StatusBar.Text = "&Status Bar"
            '
            'm_tmiView_HorizontalRuler
            '
            Me.m_tmiView_HorizontalRuler.CheckOnClick = True
            Me.m_tmiView_HorizontalRuler.Name = "m_tmiView_HorizontalRuler"
            Me.m_tmiView_HorizontalRuler.Size = New System.Drawing.Size(201, 22)
            Me.m_tmiView_HorizontalRuler.Text = "&Horizontal Ruler"
            '
            'm_tmiView_VerticalRuler
            '
            Me.m_tmiView_VerticalRuler.CheckOnClick = True
            Me.m_tmiView_VerticalRuler.Name = "m_tmiView_VerticalRuler"
            Me.m_tmiView_VerticalRuler.Size = New System.Drawing.Size(201, 22)
            Me.m_tmiView_VerticalRuler.Text = "&Vertical Ruler"
            '
            'm_tspView_Separator02
            '
            Me.m_tspView_Separator02.Name = "m_tspView_Separator02"
            Me.m_tspView_Separator02.Size = New System.Drawing.Size(198, 6)
            '
            'm_tmiView_TableGridlines
            '
            Me.m_tmiView_TableGridlines.CheckOnClick = True
            Me.m_tmiView_TableGridlines.Name = "m_tmiView_TableGridlines"
            Me.m_tmiView_TableGridlines.Size = New System.Drawing.Size(201, 22)
            Me.m_tmiView_TableGridlines.Text = "&Table Gridlines"
            '
            'm_tmiView_BookmarkMarkers
            '
            Me.m_tmiView_BookmarkMarkers.CheckOnClick = True
            Me.m_tmiView_BookmarkMarkers.Name = "m_tmiView_BookmarkMarkers"
            Me.m_tmiView_BookmarkMarkers.Size = New System.Drawing.Size(201, 22)
            Me.m_tmiView_BookmarkMarkers.Text = "B&ookmark Markers"
            '
            'm_tmiView_TextFrameMarkerLines
            '
            Me.m_tmiView_TextFrameMarkerLines.CheckOnClick = True
            Me.m_tmiView_TextFrameMarkerLines.Name = "m_tmiView_TextFrameMarkerLines"
            Me.m_tmiView_TextFrameMarkerLines.Size = New System.Drawing.Size(201, 22)
            Me.m_tmiView_TextFrameMarkerLines.Text = "Text &Frame Marker Lines"
            '
            'm_tmiView_DrawingMarkerLines
            '
            Me.m_tmiView_DrawingMarkerLines.CheckOnClick = True
            Me.m_tmiView_DrawingMarkerLines.Name = "m_tmiView_DrawingMarkerLines"
            Me.m_tmiView_DrawingMarkerLines.Size = New System.Drawing.Size(201, 22)
            Me.m_tmiView_DrawingMarkerLines.Text = "Dra&wing Marker Lines"
            '
            'm_tmiView_ControlChars
            '
            Me.m_tmiView_ControlChars.CheckOnClick = True
            Me.m_tmiView_ControlChars.Name = "m_tmiView_ControlChars"
            Me.m_tmiView_ControlChars.Size = New System.Drawing.Size(201, 22)
            Me.m_tmiView_ControlChars.Text = "&Control Chars"
            '
            'm_tspView_Separator03
            '
            Me.m_tspView_Separator03.Name = "m_tspView_Separator03"
            Me.m_tspView_Separator03.Size = New System.Drawing.Size(198, 6)
            '
            'm_tmiView_EditableRegions
            '
            Me.m_tmiView_EditableRegions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiView_EditableRegions_Always, Me.m_tmiView_EditableRegions_Current, Me.m_tmiView_EditableRegions_Never})
            Me.m_tmiView_EditableRegions.Name = "m_tmiView_EditableRegions"
            Me.m_tmiView_EditableRegions.Size = New System.Drawing.Size(201, 22)
            Me.m_tmiView_EditableRegions.Text = "&Editiable Regions"
            '
            'm_tmiView_EditableRegions_Always
            '
            Me.m_tmiView_EditableRegions_Always.CheckOnClick = True
            Me.m_tmiView_EditableRegions_Always.Name = "m_tmiView_EditableRegions_Always"
            Me.m_tmiView_EditableRegions_Always.Size = New System.Drawing.Size(114, 22)
            Me.m_tmiView_EditableRegions_Always.Text = "&Always"
            '
            'm_tmiView_EditableRegions_Current
            '
            Me.m_tmiView_EditableRegions_Current.CheckOnClick = True
            Me.m_tmiView_EditableRegions_Current.Name = "m_tmiView_EditableRegions_Current"
            Me.m_tmiView_EditableRegions_Current.Size = New System.Drawing.Size(114, 22)
            Me.m_tmiView_EditableRegions_Current.Text = "&Current"
            '
            'm_tmiView_EditableRegions_Never
            '
            Me.m_tmiView_EditableRegions_Never.CheckOnClick = True
            Me.m_tmiView_EditableRegions_Never.Name = "m_tmiView_EditableRegions_Never"
            Me.m_tmiView_EditableRegions_Never.Size = New System.Drawing.Size(114, 22)
            Me.m_tmiView_EditableRegions_Never.Text = "&Never"
            '
            'm_tmiView_TrackedChanges
            '
            Me.m_tmiView_TrackedChanges.CheckOnClick = True
            Me.m_tmiView_TrackedChanges.Name = "m_tmiView_TrackedChanges"
            Me.m_tmiView_TrackedChanges.Size = New System.Drawing.Size(201, 22)
            Me.m_tmiView_TrackedChanges.Text = "Tr&acked Changes"
            '
            'm_tmiView_Comments
            '
            Me.m_tmiView_Comments.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiView_Comments_Always, Me.m_tmiView_Comments_Current, Me.m_tmiView_Comments_Never})
            Me.m_tmiView_Comments.Name = "m_tmiView_Comments"
            Me.m_tmiView_Comments.Size = New System.Drawing.Size(201, 22)
            Me.m_tmiView_Comments.Text = "Co&mments"
            '
            'm_tmiView_Comments_Always
            '
            Me.m_tmiView_Comments_Always.CheckOnClick = True
            Me.m_tmiView_Comments_Always.Name = "m_tmiView_Comments_Always"
            Me.m_tmiView_Comments_Always.Size = New System.Drawing.Size(114, 22)
            Me.m_tmiView_Comments_Always.Text = "&Always"
            '
            'm_tmiView_Comments_Current
            '
            Me.m_tmiView_Comments_Current.CheckOnClick = True
            Me.m_tmiView_Comments_Current.Name = "m_tmiView_Comments_Current"
            Me.m_tmiView_Comments_Current.Size = New System.Drawing.Size(114, 22)
            Me.m_tmiView_Comments_Current.Text = "&Current"
            '
            'm_tmiView_Comments_Never
            '
            Me.m_tmiView_Comments_Never.CheckOnClick = True
            Me.m_tmiView_Comments_Never.Name = "m_tmiView_Comments_Never"
            Me.m_tmiView_Comments_Never.Size = New System.Drawing.Size(114, 22)
            Me.m_tmiView_Comments_Never.Text = "&Never"
            '
            'm_tspView_Separator04
            '
            Me.m_tspView_Separator04.Name = "m_tspView_Separator04"
            Me.m_tspView_Separator04.Size = New System.Drawing.Size(198, 6)
            '
            'm_tmiView_Zoom
            '
            Me.m_tmiView_Zoom.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiView_Zoom_50, Me.m_tmiView_Zoom_75, Me.m_tmiView_Zoom_100, Me.m_tmiView_Zoom_150, Me.m_tmiView_Zoom_200, Me.m_tmiView_Zoom_300, Me.m_tmiView_Zoom_400})
            Me.m_tmiView_Zoom.Name = "m_tmiView_Zoom"
            Me.m_tmiView_Zoom.Size = New System.Drawing.Size(201, 22)
            Me.m_tmiView_Zoom.Text = "&Zoom"
            '
            'm_tmiView_Zoom_50
            '
            Me.m_tmiView_Zoom_50.CheckOnClick = True
            Me.m_tmiView_Zoom_50.Name = "m_tmiView_Zoom_50"
            Me.m_tmiView_Zoom_50.Size = New System.Drawing.Size(102, 22)
            Me.m_tmiView_Zoom_50.Tag = "50"
            Me.m_tmiView_Zoom_50.Text = "&50%"
            '
            'm_tmiView_Zoom_75
            '
            Me.m_tmiView_Zoom_75.CheckOnClick = True
            Me.m_tmiView_Zoom_75.Name = "m_tmiView_Zoom_75"
            Me.m_tmiView_Zoom_75.Size = New System.Drawing.Size(102, 22)
            Me.m_tmiView_Zoom_75.Tag = "75"
            Me.m_tmiView_Zoom_75.Text = "&75%"
            '
            'm_tmiView_Zoom_100
            '
            Me.m_tmiView_Zoom_100.CheckOnClick = True
            Me.m_tmiView_Zoom_100.Name = "m_tmiView_Zoom_100"
            Me.m_tmiView_Zoom_100.Size = New System.Drawing.Size(102, 22)
            Me.m_tmiView_Zoom_100.Tag = "100"
            Me.m_tmiView_Zoom_100.Text = "&100%"
            '
            'm_tmiView_Zoom_150
            '
            Me.m_tmiView_Zoom_150.CheckOnClick = True
            Me.m_tmiView_Zoom_150.Name = "m_tmiView_Zoom_150"
            Me.m_tmiView_Zoom_150.Size = New System.Drawing.Size(102, 22)
            Me.m_tmiView_Zoom_150.Tag = "150"
            Me.m_tmiView_Zoom_150.Text = "15&0%"
            '
            'm_tmiView_Zoom_200
            '
            Me.m_tmiView_Zoom_200.CheckOnClick = True
            Me.m_tmiView_Zoom_200.Name = "m_tmiView_Zoom_200"
            Me.m_tmiView_Zoom_200.Size = New System.Drawing.Size(102, 22)
            Me.m_tmiView_Zoom_200.Tag = "200"
            Me.m_tmiView_Zoom_200.Text = "&200%"
            '
            'm_tmiView_Zoom_300
            '
            Me.m_tmiView_Zoom_300.CheckOnClick = True
            Me.m_tmiView_Zoom_300.Name = "m_tmiView_Zoom_300"
            Me.m_tmiView_Zoom_300.Size = New System.Drawing.Size(102, 22)
            Me.m_tmiView_Zoom_300.Tag = "300"
            Me.m_tmiView_Zoom_300.Text = "&300%"
            '
            'm_tmiView_Zoom_400
            '
            Me.m_tmiView_Zoom_400.CheckOnClick = True
            Me.m_tmiView_Zoom_400.Name = "m_tmiView_Zoom_400"
            Me.m_tmiView_Zoom_400.Size = New System.Drawing.Size(102, 22)
            Me.m_tmiView_Zoom_400.Tag = "400"
            Me.m_tmiView_Zoom_400.Text = "&400%"
            '
            'm_tspView_Separator05
            '
            Me.m_tspView_Separator05.Name = "m_tspView_Separator05"
            Me.m_tspView_Separator05.Size = New System.Drawing.Size(198, 6)
            '
            'm_tmiView_RightToLeftLayout
            '
            Me.m_tmiView_RightToLeftLayout.Name = "m_tmiView_RightToLeftLayout"
            Me.m_tmiView_RightToLeftLayout.Size = New System.Drawing.Size(201, 22)
            Me.m_tmiView_RightToLeftLayout.Text = "&Right to Left Layout"
            '
            'm_tmiInsert
            '
            Me.m_tmiInsert.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiInsert_File, Me.m_tspInsert_Separator01, Me.m_tmiInsert_Image, Me.m_tmiInsert_TextFrame, Me.m_tmiInsert_Shape, Me.m_tmiInsert_Barcode, Me.m_tspInsert_Separator02, Me.m_tmiInsert_Header, Me.m_tmiInsert_Footer, Me.m_tmiInsert_PageNumber, Me.m_tspInsert_Separator03, Me.m_tmiInsert_FormField, Me.m_tspInsert_Separator04, Me.m_tmiInsert_Symbol, Me.m_tspInsert_Separator05, Me.m_tmiInsert_Hyperlink, Me.m_tmiInsert_Bookmark, Me.m_tmiInsert_TableOfContents, Me.m_tspInsert_Separator06, Me.m_tmiInsert_Columns, Me.m_tmiInsert_PageBreaks, Me.m_tmiInsert_SectionBreaks})
            Me.m_tmiInsert.Name = "m_tmiInsert"
            Me.m_tmiInsert.Size = New System.Drawing.Size(48, 20)
            Me.m_tmiInsert.Text = "&Insert"
            '
            'm_tmiInsert_File
            '
            Me.m_tmiInsert_File.Name = "m_tmiInsert_File"
            Me.m_tmiInsert_File.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiInsert_File.Text = "&File..."
            '
            'm_tspInsert_Separator01
            '
            Me.m_tspInsert_Separator01.Name = "m_tspInsert_Separator01"
            Me.m_tspInsert_Separator01.Size = New System.Drawing.Size(163, 6)
            '
            'm_tmiInsert_Image
            '
            Me.m_tmiInsert_Image.Name = "m_tmiInsert_Image"
            Me.m_tmiInsert_Image.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiInsert_Image.Text = "&Image..."
            '
            'm_tmiInsert_TextFrame
            '
            Me.m_tmiInsert_TextFrame.Name = "m_tmiInsert_TextFrame"
            Me.m_tmiInsert_TextFrame.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiInsert_TextFrame.Text = "&Text Frame"
            '
            'm_tmiInsert_Shape
            '
            Me.m_tmiInsert_Shape.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiInsert_Shape_Lines, Me.m_tmiInsert_Shape_Rectangles, Me.m_tmiInsert_Shape_BasicShapes, Me.m_tmiInsert_Shape_BlockArrows, Me.m_tmiInsert_Shape_EquationShapes, Me.m_tmiInsert_Shape_Flowchart, Me.m_tmiInsert_Shape_StarsAndBanners, Me.m_tmiInsert_Shape_Callouts, Me.m_tspInsert_Shape_Separator01, Me.m_tmiInsert_Shape_DrawingCanvas})
            Me.m_tmiInsert_Shape.Name = "m_tmiInsert_Shape"
            Me.m_tmiInsert_Shape.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiInsert_Shape.Text = "&Shape"
            '
            'm_tmiInsert_Shape_Lines
            '
            Me.m_tmiInsert_Shape_Lines.Name = "m_tmiInsert_Shape_Lines"
            Me.m_tmiInsert_Shape_Lines.Size = New System.Drawing.Size(167, 22)
            Me.m_tmiInsert_Shape_Lines.Text = "&Lines"
            '
            'm_tmiInsert_Shape_Rectangles
            '
            Me.m_tmiInsert_Shape_Rectangles.Name = "m_tmiInsert_Shape_Rectangles"
            Me.m_tmiInsert_Shape_Rectangles.Size = New System.Drawing.Size(167, 22)
            Me.m_tmiInsert_Shape_Rectangles.Text = "&Rectangles"
            '
            'm_tmiInsert_Shape_BasicShapes
            '
            Me.m_tmiInsert_Shape_BasicShapes.Name = "m_tmiInsert_Shape_BasicShapes"
            Me.m_tmiInsert_Shape_BasicShapes.Size = New System.Drawing.Size(167, 22)
            Me.m_tmiInsert_Shape_BasicShapes.Text = "&Basic Shapes"
            '
            'm_tmiInsert_Shape_BlockArrows
            '
            Me.m_tmiInsert_Shape_BlockArrows.Name = "m_tmiInsert_Shape_BlockArrows"
            Me.m_tmiInsert_Shape_BlockArrows.Size = New System.Drawing.Size(167, 22)
            Me.m_tmiInsert_Shape_BlockArrows.Text = "Block &Arrows"
            '
            'm_tmiInsert_Shape_EquationShapes
            '
            Me.m_tmiInsert_Shape_EquationShapes.Name = "m_tmiInsert_Shape_EquationShapes"
            Me.m_tmiInsert_Shape_EquationShapes.Size = New System.Drawing.Size(167, 22)
            Me.m_tmiInsert_Shape_EquationShapes.Text = "&Equation Shapes"
            '
            'm_tmiInsert_Shape_Flowchart
            '
            Me.m_tmiInsert_Shape_Flowchart.Name = "m_tmiInsert_Shape_Flowchart"
            Me.m_tmiInsert_Shape_Flowchart.Size = New System.Drawing.Size(167, 22)
            Me.m_tmiInsert_Shape_Flowchart.Text = "&Flowchart"
            '
            'm_tmiInsert_Shape_StarsAndBanners
            '
            Me.m_tmiInsert_Shape_StarsAndBanners.Name = "m_tmiInsert_Shape_StarsAndBanners"
            Me.m_tmiInsert_Shape_StarsAndBanners.Size = New System.Drawing.Size(167, 22)
            Me.m_tmiInsert_Shape_StarsAndBanners.Text = "&Stars and Banners"
            '
            'm_tmiInsert_Shape_Callouts
            '
            Me.m_tmiInsert_Shape_Callouts.Name = "m_tmiInsert_Shape_Callouts"
            Me.m_tmiInsert_Shape_Callouts.Size = New System.Drawing.Size(167, 22)
            Me.m_tmiInsert_Shape_Callouts.Text = "&Callouts"
            '
            'm_tspInsert_Shape_Separator01
            '
            Me.m_tspInsert_Shape_Separator01.Name = "m_tspInsert_Shape_Separator01"
            Me.m_tspInsert_Shape_Separator01.Size = New System.Drawing.Size(164, 6)
            '
            'm_tmiInsert_Shape_DrawingCanvas
            '
            Me.m_tmiInsert_Shape_DrawingCanvas.Name = "m_tmiInsert_Shape_DrawingCanvas"
            Me.m_tmiInsert_Shape_DrawingCanvas.Size = New System.Drawing.Size(167, 22)
            Me.m_tmiInsert_Shape_DrawingCanvas.Text = "&Drawing Canvas"
            '
            'm_tmiInsert_Barcode
            '
            Me.m_tmiInsert_Barcode.Name = "m_tmiInsert_Barcode"
            Me.m_tmiInsert_Barcode.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiInsert_Barcode.Text = "&Barcode"
            '
            'm_tspInsert_Separator02
            '
            Me.m_tspInsert_Separator02.Name = "m_tspInsert_Separator02"
            Me.m_tspInsert_Separator02.Size = New System.Drawing.Size(163, 6)
            '
            'm_tmiInsert_Header
            '
            Me.m_tmiInsert_Header.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiInsert_Header_Insert, Me.m_tmiInsert_Header_Remove})
            Me.m_tmiInsert_Header.Name = "m_tmiInsert_Header"
            Me.m_tmiInsert_Header.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiInsert_Header.Text = "&Header"
            '
            'm_tmiInsert_Header_Insert
            '
            Me.m_tmiInsert_Header_Insert.Name = "m_tmiInsert_Header_Insert"
            Me.m_tmiInsert_Header_Insert.Size = New System.Drawing.Size(117, 22)
            Me.m_tmiInsert_Header_Insert.Text = "&Insert"
            '
            'm_tmiInsert_Header_Remove
            '
            Me.m_tmiInsert_Header_Remove.Name = "m_tmiInsert_Header_Remove"
            Me.m_tmiInsert_Header_Remove.Size = New System.Drawing.Size(117, 22)
            Me.m_tmiInsert_Header_Remove.Text = "&Remove"
            '
            'm_tmiInsert_Footer
            '
            Me.m_tmiInsert_Footer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiInsert_Footer_Insert, Me.m_tmiInsert_Footer_Remove})
            Me.m_tmiInsert_Footer.Name = "m_tmiInsert_Footer"
            Me.m_tmiInsert_Footer.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiInsert_Footer.Text = "F&ooter"
            '
            'm_tmiInsert_Footer_Insert
            '
            Me.m_tmiInsert_Footer_Insert.Name = "m_tmiInsert_Footer_Insert"
            Me.m_tmiInsert_Footer_Insert.Size = New System.Drawing.Size(117, 22)
            Me.m_tmiInsert_Footer_Insert.Text = "&Insert"
            '
            'm_tmiInsert_Footer_Remove
            '
            Me.m_tmiInsert_Footer_Remove.Name = "m_tmiInsert_Footer_Remove"
            Me.m_tmiInsert_Footer_Remove.Size = New System.Drawing.Size(117, 22)
            Me.m_tmiInsert_Footer_Remove.Text = "&Remove"
            '
            'm_tmiInsert_PageNumber
            '
            Me.m_tmiInsert_PageNumber.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiInsert_PageNumber_Insert, Me.m_tmiInsert_PageNumber_Delete})
            Me.m_tmiInsert_PageNumber.Name = "m_tmiInsert_PageNumber"
            Me.m_tmiInsert_PageNumber.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiInsert_PageNumber.Text = "&Page Number"
            '
            'm_tmiInsert_PageNumber_Insert
            '
            Me.m_tmiInsert_PageNumber_Insert.Name = "m_tmiInsert_PageNumber_Insert"
            Me.m_tmiInsert_PageNumber_Insert.Size = New System.Drawing.Size(107, 22)
            Me.m_tmiInsert_PageNumber_Insert.Text = "&Insert"
            '
            'm_tmiInsert_PageNumber_Delete
            '
            Me.m_tmiInsert_PageNumber_Delete.Name = "m_tmiInsert_PageNumber_Delete"
            Me.m_tmiInsert_PageNumber_Delete.Size = New System.Drawing.Size(107, 22)
            Me.m_tmiInsert_PageNumber_Delete.Text = "&Delete"
            '
            'm_tspInsert_Separator03
            '
            Me.m_tspInsert_Separator03.Name = "m_tspInsert_Separator03"
            Me.m_tspInsert_Separator03.Size = New System.Drawing.Size(163, 6)
            '
            'm_tmiInsert_FormField
            '
            Me.m_tmiInsert_FormField.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiInsert_FormField_TextFormField, Me.m_tmiInsert_FormField_CheckBox, Me.m_tmiInsert_FormField_ComboBox, Me.m_tmiInsert_FormField_DropDownList, Me.m_tmiInsert_FormField_DateFormField, Me.m_tspInsert_FormField_Separator01, Me.m_tmiInsert_FormField_Delete})
            Me.m_tmiInsert_FormField.Name = "m_tmiInsert_FormField"
            Me.m_tmiInsert_FormField.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiInsert_FormField.Text = "Fo&rm Field"
            '
            'm_tmiInsert_FormField_TextFormField
            '
            Me.m_tmiInsert_FormField_TextFormField.Name = "m_tmiInsert_FormField_TextFormField"
            Me.m_tmiInsert_FormField_TextFormField.Size = New System.Drawing.Size(157, 22)
            Me.m_tmiInsert_FormField_TextFormField.Text = "&Text Form Field"
            '
            'm_tmiInsert_FormField_CheckBox
            '
            Me.m_tmiInsert_FormField_CheckBox.Name = "m_tmiInsert_FormField_CheckBox"
            Me.m_tmiInsert_FormField_CheckBox.Size = New System.Drawing.Size(157, 22)
            Me.m_tmiInsert_FormField_CheckBox.Text = "&Check Box"
            '
            'm_tmiInsert_FormField_ComboBox
            '
            Me.m_tmiInsert_FormField_ComboBox.Name = "m_tmiInsert_FormField_ComboBox"
            Me.m_tmiInsert_FormField_ComboBox.Size = New System.Drawing.Size(157, 22)
            Me.m_tmiInsert_FormField_ComboBox.Text = "C&ombo Box"
            '
            'm_tmiInsert_FormField_DropDownList
            '
            Me.m_tmiInsert_FormField_DropDownList.Name = "m_tmiInsert_FormField_DropDownList"
            Me.m_tmiInsert_FormField_DropDownList.Size = New System.Drawing.Size(157, 22)
            Me.m_tmiInsert_FormField_DropDownList.Text = "&Drop-Down List"
            '
            'm_tmiInsert_FormField_DateFormField
            '
            Me.m_tmiInsert_FormField_DateFormField.Name = "m_tmiInsert_FormField_DateFormField"
            Me.m_tmiInsert_FormField_DateFormField.Size = New System.Drawing.Size(157, 22)
            Me.m_tmiInsert_FormField_DateFormField.Text = "D&ate Form Field"
            '
            'm_tspInsert_FormField_Separator01
            '
            Me.m_tspInsert_FormField_Separator01.Name = "m_tspInsert_FormField_Separator01"
            Me.m_tspInsert_FormField_Separator01.Size = New System.Drawing.Size(154, 6)
            '
            'm_tmiInsert_FormField_Delete
            '
            Me.m_tmiInsert_FormField_Delete.Name = "m_tmiInsert_FormField_Delete"
            Me.m_tmiInsert_FormField_Delete.Size = New System.Drawing.Size(157, 22)
            Me.m_tmiInsert_FormField_Delete.Text = "D&elete"
            '
            'm_tspInsert_Separator04
            '
            Me.m_tspInsert_Separator04.Name = "m_tspInsert_Separator04"
            Me.m_tspInsert_Separator04.Size = New System.Drawing.Size(163, 6)
            '
            'm_tmiInsert_Symbol
            '
            Me.m_tmiInsert_Symbol.Name = "m_tmiInsert_Symbol"
            Me.m_tmiInsert_Symbol.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiInsert_Symbol.Text = "Sy&mbol..."
            '
            'm_tspInsert_Separator05
            '
            Me.m_tspInsert_Separator05.Name = "m_tspInsert_Separator05"
            Me.m_tspInsert_Separator05.Size = New System.Drawing.Size(163, 6)
            '
            'm_tmiInsert_Hyperlink
            '
            Me.m_tmiInsert_Hyperlink.Name = "m_tmiInsert_Hyperlink"
            Me.m_tmiInsert_Hyperlink.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiInsert_Hyperlink.Text = "Hyp&erlink..."
            '
            'm_tmiInsert_Bookmark
            '
            Me.m_tmiInsert_Bookmark.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiInsert_Bookmark_Insert, Me.m_tmiInsert_Bookmark_Delete})
            Me.m_tmiInsert_Bookmark.Name = "m_tmiInsert_Bookmark"
            Me.m_tmiInsert_Bookmark.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiInsert_Bookmark.Text = "Boo&kmark"
            '
            'm_tmiInsert_Bookmark_Insert
            '
            Me.m_tmiInsert_Bookmark_Insert.Name = "m_tmiInsert_Bookmark_Insert"
            Me.m_tmiInsert_Bookmark_Insert.Size = New System.Drawing.Size(116, 22)
            Me.m_tmiInsert_Bookmark_Insert.Text = "&Insert..."
            '
            'm_tmiInsert_Bookmark_Delete
            '
            Me.m_tmiInsert_Bookmark_Delete.Name = "m_tmiInsert_Bookmark_Delete"
            Me.m_tmiInsert_Bookmark_Delete.Size = New System.Drawing.Size(116, 22)
            Me.m_tmiInsert_Bookmark_Delete.Text = "&Delete..."
            '
            'm_tmiInsert_TableOfContents
            '
            Me.m_tmiInsert_TableOfContents.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiInsert_TableOfContents_Insert, Me.m_tmiInsert_TableOfContents_Delete, Me.m_tmiInsert_TableOfContents_Update})
            Me.m_tmiInsert_TableOfContents.Name = "m_tmiInsert_TableOfContents"
            Me.m_tmiInsert_TableOfContents.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiInsert_TableOfContents.Text = "Tab&le of Contents"
            '
            'm_tmiInsert_TableOfContents_Insert
            '
            Me.m_tmiInsert_TableOfContents_Insert.Name = "m_tmiInsert_TableOfContents_Insert"
            Me.m_tmiInsert_TableOfContents_Insert.Size = New System.Drawing.Size(112, 22)
            Me.m_tmiInsert_TableOfContents_Insert.Text = "Insert..."
            '
            'm_tmiInsert_TableOfContents_Delete
            '
            Me.m_tmiInsert_TableOfContents_Delete.Name = "m_tmiInsert_TableOfContents_Delete"
            Me.m_tmiInsert_TableOfContents_Delete.Size = New System.Drawing.Size(112, 22)
            Me.m_tmiInsert_TableOfContents_Delete.Text = "Delete"
            '
            'm_tmiInsert_TableOfContents_Update
            '
            Me.m_tmiInsert_TableOfContents_Update.Name = "m_tmiInsert_TableOfContents_Update"
            Me.m_tmiInsert_TableOfContents_Update.Size = New System.Drawing.Size(112, 22)
            Me.m_tmiInsert_TableOfContents_Update.Text = "Update"
            '
            'm_tspInsert_Separator06
            '
            Me.m_tspInsert_Separator06.Name = "m_tspInsert_Separator06"
            Me.m_tspInsert_Separator06.Size = New System.Drawing.Size(163, 6)
            '
            'm_tmiInsert_Columns
            '
            Me.m_tmiInsert_Columns.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiInsert_Columns_One, Me.m_tmiInsert_Columns_Two, Me.m_tspInsert_Columns_Separator01, Me.m_tmiInsert_Columns_MoreColumns})
            Me.m_tmiInsert_Columns.Name = "m_tmiInsert_Columns"
            Me.m_tmiInsert_Columns.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiInsert_Columns.Text = "&Columns"
            '
            'm_tmiInsert_Columns_One
            '
            Me.m_tmiInsert_Columns_One.CheckOnClick = True
            Me.m_tmiInsert_Columns_One.Name = "m_tmiInsert_Columns_One"
            Me.m_tmiInsert_Columns_One.Size = New System.Drawing.Size(162, 22)
            Me.m_tmiInsert_Columns_One.Text = "&One"
            '
            'm_tmiInsert_Columns_Two
            '
            Me.m_tmiInsert_Columns_Two.CheckOnClick = True
            Me.m_tmiInsert_Columns_Two.Name = "m_tmiInsert_Columns_Two"
            Me.m_tmiInsert_Columns_Two.Size = New System.Drawing.Size(162, 22)
            Me.m_tmiInsert_Columns_Two.Text = "&Two"
            '
            'm_tspInsert_Columns_Separator01
            '
            Me.m_tspInsert_Columns_Separator01.Name = "m_tspInsert_Columns_Separator01"
            Me.m_tspInsert_Columns_Separator01.Size = New System.Drawing.Size(159, 6)
            '
            'm_tmiInsert_Columns_MoreColumns
            '
            Me.m_tmiInsert_Columns_MoreColumns.Name = "m_tmiInsert_Columns_MoreColumns"
            Me.m_tmiInsert_Columns_MoreColumns.Size = New System.Drawing.Size(162, 22)
            Me.m_tmiInsert_Columns_MoreColumns.Text = "&More Columns..."
            '
            'm_tmiInsert_PageBreaks
            '
            Me.m_tmiInsert_PageBreaks.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiInsert_PageBreaks_Page, Me.m_tmiInsert_PageBreaks_Column, Me.m_tmiInsert_PageBreaks_TextWrapping})
            Me.m_tmiInsert_PageBreaks.Name = "m_tmiInsert_PageBreaks"
            Me.m_tmiInsert_PageBreaks.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiInsert_PageBreaks.Text = "P&age Break"
            '
            'm_tmiInsert_PageBreaks_Page
            '
            Me.m_tmiInsert_PageBreaks_Page.Name = "m_tmiInsert_PageBreaks_Page"
            Me.m_tmiInsert_PageBreaks_Page.Size = New System.Drawing.Size(150, 22)
            Me.m_tmiInsert_PageBreaks_Page.Text = "&Page"
            '
            'm_tmiInsert_PageBreaks_Column
            '
            Me.m_tmiInsert_PageBreaks_Column.Name = "m_tmiInsert_PageBreaks_Column"
            Me.m_tmiInsert_PageBreaks_Column.Size = New System.Drawing.Size(150, 22)
            Me.m_tmiInsert_PageBreaks_Column.Text = "&Column"
            '
            'm_tmiInsert_PageBreaks_TextWrapping
            '
            Me.m_tmiInsert_PageBreaks_TextWrapping.Name = "m_tmiInsert_PageBreaks_TextWrapping"
            Me.m_tmiInsert_PageBreaks_TextWrapping.Size = New System.Drawing.Size(150, 22)
            Me.m_tmiInsert_PageBreaks_TextWrapping.Text = "&Text Wrapping"
            '
            'm_tmiInsert_SectionBreaks
            '
            Me.m_tmiInsert_SectionBreaks.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiInsert_SectionBreaks_NextPage, Me.m_tmiInsert_SectionBreaks_Continuous})
            Me.m_tmiInsert_SectionBreaks.Name = "m_tmiInsert_SectionBreaks"
            Me.m_tmiInsert_SectionBreaks.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiInsert_SectionBreaks.Text = "Sectio&n Break"
            '
            'm_tmiInsert_SectionBreaks_NextPage
            '
            Me.m_tmiInsert_SectionBreaks_NextPage.Name = "m_tmiInsert_SectionBreaks_NextPage"
            Me.m_tmiInsert_SectionBreaks_NextPage.Size = New System.Drawing.Size(136, 22)
            Me.m_tmiInsert_SectionBreaks_NextPage.Text = "&Next Page"
            '
            'm_tmiInsert_SectionBreaks_Continuous
            '
            Me.m_tmiInsert_SectionBreaks_Continuous.Name = "m_tmiInsert_SectionBreaks_Continuous"
            Me.m_tmiInsert_SectionBreaks_Continuous.Size = New System.Drawing.Size(136, 22)
            Me.m_tmiInsert_SectionBreaks_Continuous.Text = "&Continuous"
            '
            'm_tmiFormat
            '
            Me.m_tmiFormat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiFormat_Character, Me.m_tmiFormat_Paragraph, Me.m_tmiFormat_Styles, Me.m_tmiFormat_ParagraphStructureLevels, Me.m_tmiFormat_BulletsAndNumbering, Me.m_tspFormat_Separator01, Me.m_tmiFormat_Image, Me.m_tmiFormat_TextFrame, Me.m_tmiFormat_Shape, Me.m_tmiFormat_Barcode, Me.m_tspFormat_Separator02, Me.m_tmiFormat_HeadersAndFooters, Me.m_tmiFormat_PageNumberField, Me.m_tspFormat_Separator03, Me.m_tmiFormat_FormFields, Me.m_tspFormat_Separator04, Me.m_tmiFormat_Hyperlink, Me.m_tmiFormat_Bookmark, Me.m_tmiFormat_TableOfContents, Me.m_tspFormat_Separator05, Me.m_tmiFormat_Columns, Me.m_tmiFormat_PageBorders, Me.m_tmiFormat_PageColor, Me.m_tmiFormat_Tabs, Me.m_tspFormat_Separator06, Me.m_tmiFormat_Language})
            Me.m_tmiFormat.Name = "m_tmiFormat"
            Me.m_tmiFormat.Size = New System.Drawing.Size(57, 20)
            Me.m_tmiFormat.Text = "F&ormat"
            '
            'm_tmiFormat_Character
            '
            Me.m_tmiFormat_Character.Name = "m_tmiFormat_Character"
            Me.m_tmiFormat_Character.Size = New System.Drawing.Size(214, 22)
            Me.m_tmiFormat_Character.Text = "&Character..."
            '
            'm_tmiFormat_Paragraph
            '
            Me.m_tmiFormat_Paragraph.Name = "m_tmiFormat_Paragraph"
            Me.m_tmiFormat_Paragraph.Size = New System.Drawing.Size(214, 22)
            Me.m_tmiFormat_Paragraph.Text = "&Paragraph..."
            '
            'm_tmiFormat_Styles
            '
            Me.m_tmiFormat_Styles.Name = "m_tmiFormat_Styles"
            Me.m_tmiFormat_Styles.Size = New System.Drawing.Size(214, 22)
            Me.m_tmiFormat_Styles.Text = "&Styles..."
            '
            'm_tmiFormat_ParagraphStructureLevels
            '
            Me.m_tmiFormat_ParagraphStructureLevels.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle, Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph})
            Me.m_tmiFormat_ParagraphStructureLevels.Name = "m_tmiFormat_ParagraphStructureLevels"
            Me.m_tmiFormat_ParagraphStructureLevels.Size = New System.Drawing.Size(214, 22)
            Me.m_tmiFormat_ParagraphStructureLevels.Text = "Paragraph Structure Le&vels"
            '
            'm_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle
            '
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_BodyText, Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level01, Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level02, Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level03, Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level04, Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level05, Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level06, Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level07, Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level08, Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level09, Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level10})
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle.Name = "m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle.Size = New System.Drawing.Size(298, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle.Text = "Paragraph Style: [Current Paragraph Style] "
            '
            'm_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_BodyText
            '
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_BodyText.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_BodyText.Name = "m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_BodyText"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_BodyText.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_BodyText.Tag = "0"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_BodyText.Text = "&Body Text"
            '
            'm_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level01
            '
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level01.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level01.Name = "m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level01"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level01.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level01.Tag = "1"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level01.Text = "Level &1"
            '
            'm_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level02
            '
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level02.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level02.Name = "m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level02"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level02.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level02.Tag = "2"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level02.Text = "Level &2"
            '
            'm_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level03
            '
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level03.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level03.Name = "m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level03"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level03.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level03.Tag = "3"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level03.Text = "Level &3"
            '
            'm_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level04
            '
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level04.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level04.Name = "m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level04"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level04.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level04.Tag = "4"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level04.Text = "Level &4"
            '
            'm_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level05
            '
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level05.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level05.Name = "m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level05"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level05.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level05.Tag = "5"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level05.Text = "Level &5"
            '
            'm_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level06
            '
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level06.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level06.Name = "m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level06"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level06.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level06.Tag = "6"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level06.Text = "Level &6"
            '
            'm_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level07
            '
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level07.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level07.Name = "m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level07"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level07.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level07.Tag = "7"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level07.Text = "Level &7"
            '
            'm_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level08
            '
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level08.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level08.Name = "m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level08"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level08.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level08.Tag = "8"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level08.Text = "Level &8"
            '
            'm_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level09
            '
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level09.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level09.Name = "m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level09"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level09.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level09.Tag = "9"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level09.Text = "Level &9"
            '
            'm_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level10
            '
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level10.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level10.Name = "m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level10"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level10.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level10.Tag = "10"
            Me.m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level10.Text = "Level 1&0"
            '
            'm_tmiFormat_ParagraphStructureLevels_AddToParagraph
            '
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_BodyText, Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level01, Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level02, Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level03, Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level04, Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level05, Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level06, Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level07, Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level08, Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level09, Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level10})
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph.Name = "m_tmiFormat_ParagraphStructureLevels_AddToParagraph"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph.Size = New System.Drawing.Size(298, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph.Text = "&Add to Paragraph"
            '
            'm_tmiFormat_ParagraphStructureLevels_AddToParagraph_BodyText
            '
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_BodyText.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_BodyText.Name = "m_tmiFormat_ParagraphStructureLevels_AddToParagraph_BodyText"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_BodyText.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_BodyText.Tag = "0"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_BodyText.Text = "&Body Text"
            '
            'm_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level01
            '
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level01.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level01.Name = "m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level01"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level01.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level01.Tag = "1"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level01.Text = "Level &1"
            '
            'm_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level02
            '
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level02.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level02.Name = "m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level02"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level02.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level02.Tag = "2"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level02.Text = "Level &2"
            '
            'm_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level03
            '
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level03.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level03.Name = "m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level03"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level03.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level03.Tag = "3"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level03.Text = "Level &3"
            '
            'm_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level04
            '
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level04.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level04.Name = "m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level04"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level04.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level04.Tag = "4"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level04.Text = "Level &4"
            '
            'm_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level05
            '
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level05.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level05.Name = "m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level05"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level05.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level05.Tag = "5"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level05.Text = "Level &5"
            '
            'm_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level06
            '
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level06.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level06.Name = "m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level06"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level06.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level06.Tag = "6"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level06.Text = "Level &6"
            '
            'm_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level07
            '
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level07.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level07.Name = "m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level07"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level07.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level07.Tag = "7"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level07.Text = "Level &7"
            '
            'm_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level08
            '
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level08.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level08.Name = "m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level08"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level08.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level08.Tag = "8"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level08.Text = "Level &8"
            '
            'm_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level09
            '
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level09.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level09.Name = "m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level09"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level09.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level09.Tag = "9"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level09.Text = "Level &9"
            '
            'm_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level10
            '
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level10.CheckOnClick = True
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level10.Name = "m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level10"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level10.Size = New System.Drawing.Size(125, 22)
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level10.Tag = "10"
            Me.m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level10.Text = "Level 1&0"
            '
            'm_tmiFormat_BulletsAndNumbering
            '
            Me.m_tmiFormat_BulletsAndNumbering.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiFormat_BulletsAndNumbering_ArabicNumbers, Me.m_tmiFormat_BulletsAndNumbering_CapitalLetters, Me.m_tmiFormat_BulletsAndNumbering_Letters, Me.m_tmiFormat_BulletsAndNumbering_RomanNumbers, Me.m_tmiFormat_BulletsAndNumbering_SmallRomanNumbers, Me.m_tmiFormat_BulletsAndNumbering_AsStructuredList, Me.m_tspFormat_BulletsAndNumbering_Separator01, Me.m_tmiFormat_BulletsAndNumbering_Bullets, Me.m_tspFormat_BulletsAndNumbering_Separator02, Me.m_tmiFormat_BulletsAndNumbering_IncreaseLevel, Me.m_tmiFormat_BulletsAndNumbering_DecreaseLevel, Me.m_tspFormat_BulletsAndNumbering_Separator03, Me.m_tmiFormat_BulletsAndNumbering_Properties})
            Me.m_tmiFormat_BulletsAndNumbering.Name = "m_tmiFormat_BulletsAndNumbering"
            Me.m_tmiFormat_BulletsAndNumbering.Size = New System.Drawing.Size(214, 22)
            Me.m_tmiFormat_BulletsAndNumbering.Text = "Bullets and &Numbering"
            '
            'm_tmiFormat_BulletsAndNumbering_ArabicNumbers
            '
            Me.m_tmiFormat_BulletsAndNumbering_ArabicNumbers.CheckOnClick = True
            Me.m_tmiFormat_BulletsAndNumbering_ArabicNumbers.Name = "m_tmiFormat_BulletsAndNumbering_ArabicNumbers"
            Me.m_tmiFormat_BulletsAndNumbering_ArabicNumbers.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiFormat_BulletsAndNumbering_ArabicNumbers.Text = "&1, 2, 3"
            '
            'm_tmiFormat_BulletsAndNumbering_CapitalLetters
            '
            Me.m_tmiFormat_BulletsAndNumbering_CapitalLetters.CheckOnClick = True
            Me.m_tmiFormat_BulletsAndNumbering_CapitalLetters.Name = "m_tmiFormat_BulletsAndNumbering_CapitalLetters"
            Me.m_tmiFormat_BulletsAndNumbering_CapitalLetters.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiFormat_BulletsAndNumbering_CapitalLetters.Text = "&A, B, C"
            '
            'm_tmiFormat_BulletsAndNumbering_Letters
            '
            Me.m_tmiFormat_BulletsAndNumbering_Letters.CheckOnClick = True
            Me.m_tmiFormat_BulletsAndNumbering_Letters.Name = "m_tmiFormat_BulletsAndNumbering_Letters"
            Me.m_tmiFormat_BulletsAndNumbering_Letters.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiFormat_BulletsAndNumbering_Letters.Text = "a, &b, c"
            '
            'm_tmiFormat_BulletsAndNumbering_RomanNumbers
            '
            Me.m_tmiFormat_BulletsAndNumbering_RomanNumbers.CheckOnClick = True
            Me.m_tmiFormat_BulletsAndNumbering_RomanNumbers.Name = "m_tmiFormat_BulletsAndNumbering_RomanNumbers"
            Me.m_tmiFormat_BulletsAndNumbering_RomanNumbers.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiFormat_BulletsAndNumbering_RomanNumbers.Text = "&I, II, III, IV"
            '
            'm_tmiFormat_BulletsAndNumbering_SmallRomanNumbers
            '
            Me.m_tmiFormat_BulletsAndNumbering_SmallRomanNumbers.CheckOnClick = True
            Me.m_tmiFormat_BulletsAndNumbering_SmallRomanNumbers.Name = "m_tmiFormat_BulletsAndNumbering_SmallRomanNumbers"
            Me.m_tmiFormat_BulletsAndNumbering_SmallRomanNumbers.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiFormat_BulletsAndNumbering_SmallRomanNumbers.Text = "i, ii, iii, i&v"
            '
            'm_tmiFormat_BulletsAndNumbering_AsStructuredList
            '
            Me.m_tmiFormat_BulletsAndNumbering_AsStructuredList.Name = "m_tmiFormat_BulletsAndNumbering_AsStructuredList"
            Me.m_tmiFormat_BulletsAndNumbering_AsStructuredList.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiFormat_BulletsAndNumbering_AsStructuredList.Text = "As Structured &List"
            '
            'm_tspFormat_BulletsAndNumbering_Separator01
            '
            Me.m_tspFormat_BulletsAndNumbering_Separator01.Name = "m_tspFormat_BulletsAndNumbering_Separator01"
            Me.m_tspFormat_BulletsAndNumbering_Separator01.Size = New System.Drawing.Size(163, 6)
            '
            'm_tmiFormat_BulletsAndNumbering_Bullets
            '
            Me.m_tmiFormat_BulletsAndNumbering_Bullets.CheckOnClick = True
            Me.m_tmiFormat_BulletsAndNumbering_Bullets.Name = "m_tmiFormat_BulletsAndNumbering_Bullets"
            Me.m_tmiFormat_BulletsAndNumbering_Bullets.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiFormat_BulletsAndNumbering_Bullets.Text = "B&ullets"
            '
            'm_tspFormat_BulletsAndNumbering_Separator02
            '
            Me.m_tspFormat_BulletsAndNumbering_Separator02.Name = "m_tspFormat_BulletsAndNumbering_Separator02"
            Me.m_tspFormat_BulletsAndNumbering_Separator02.Size = New System.Drawing.Size(163, 6)
            '
            'm_tmiFormat_BulletsAndNumbering_IncreaseLevel
            '
            Me.m_tmiFormat_BulletsAndNumbering_IncreaseLevel.Name = "m_tmiFormat_BulletsAndNumbering_IncreaseLevel"
            Me.m_tmiFormat_BulletsAndNumbering_IncreaseLevel.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiFormat_BulletsAndNumbering_IncreaseLevel.Text = "I&ncrease Level"
            '
            'm_tmiFormat_BulletsAndNumbering_DecreaseLevel
            '
            Me.m_tmiFormat_BulletsAndNumbering_DecreaseLevel.Name = "m_tmiFormat_BulletsAndNumbering_DecreaseLevel"
            Me.m_tmiFormat_BulletsAndNumbering_DecreaseLevel.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiFormat_BulletsAndNumbering_DecreaseLevel.Text = "&Decrease Level"
            '
            'm_tspFormat_BulletsAndNumbering_Separator03
            '
            Me.m_tspFormat_BulletsAndNumbering_Separator03.Name = "m_tspFormat_BulletsAndNumbering_Separator03"
            Me.m_tspFormat_BulletsAndNumbering_Separator03.Size = New System.Drawing.Size(163, 6)
            '
            'm_tmiFormat_BulletsAndNumbering_Properties
            '
            Me.m_tmiFormat_BulletsAndNumbering_Properties.Name = "m_tmiFormat_BulletsAndNumbering_Properties"
            Me.m_tmiFormat_BulletsAndNumbering_Properties.Size = New System.Drawing.Size(166, 22)
            Me.m_tmiFormat_BulletsAndNumbering_Properties.Text = "&Properties..."
            '
            'm_tspFormat_Separator01
            '
            Me.m_tspFormat_Separator01.Name = "m_tspFormat_Separator01"
            Me.m_tspFormat_Separator01.Size = New System.Drawing.Size(211, 6)
            '
            'm_tmiFormat_Image
            '
            Me.m_tmiFormat_Image.Name = "m_tmiFormat_Image"
            Me.m_tmiFormat_Image.Size = New System.Drawing.Size(214, 22)
            Me.m_tmiFormat_Image.Text = "&Image..."
            '
            'm_tmiFormat_TextFrame
            '
            Me.m_tmiFormat_TextFrame.Name = "m_tmiFormat_TextFrame"
            Me.m_tmiFormat_TextFrame.Size = New System.Drawing.Size(214, 22)
            Me.m_tmiFormat_TextFrame.Text = "Te&xt Frame..."
            '
            'm_tmiFormat_Shape
            '
            Me.m_tmiFormat_Shape.Name = "m_tmiFormat_Shape"
            Me.m_tmiFormat_Shape.Size = New System.Drawing.Size(214, 22)
            Me.m_tmiFormat_Shape.Text = "Sh&ape..."
            '
            'm_tmiFormat_Barcode
            '
            Me.m_tmiFormat_Barcode.Name = "m_tmiFormat_Barcode"
            Me.m_tmiFormat_Barcode.Size = New System.Drawing.Size(214, 22)
            Me.m_tmiFormat_Barcode.Text = "&Barcode..."
            '
            'm_tspFormat_Separator02
            '
            Me.m_tspFormat_Separator02.Name = "m_tspFormat_Separator02"
            Me.m_tspFormat_Separator02.Size = New System.Drawing.Size(211, 6)
            '
            'm_tmiFormat_HeadersAndFooters
            '
            Me.m_tmiFormat_HeadersAndFooters.Name = "m_tmiFormat_HeadersAndFooters"
            Me.m_tmiFormat_HeadersAndFooters.Size = New System.Drawing.Size(214, 22)
            Me.m_tmiFormat_HeadersAndFooters.Text = "&Headers and Footers..."
            '
            'm_tmiFormat_PageNumberField
            '
            Me.m_tmiFormat_PageNumberField.Name = "m_tmiFormat_PageNumberField"
            Me.m_tmiFormat_PageNumberField.Size = New System.Drawing.Size(214, 22)
            Me.m_tmiFormat_PageNumberField.Text = "Page N&umber..."
            '
            'm_tspFormat_Separator03
            '
            Me.m_tspFormat_Separator03.Name = "m_tspFormat_Separator03"
            Me.m_tspFormat_Separator03.Size = New System.Drawing.Size(211, 6)
            '
            'm_tmiFormat_FormFields
            '
            Me.m_tmiFormat_FormFields.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiFormat_FormFields_Edit, Me.m_tspFormat_FormFields_Separator01, Me.m_tmiFormat_FormFields_EnableFormValidation, Me.m_tmiFormat_FormFields_ManageConditionalInstructions})
            Me.m_tmiFormat_FormFields.Name = "m_tmiFormat_FormFields"
            Me.m_tmiFormat_FormFields.Size = New System.Drawing.Size(214, 22)
            Me.m_tmiFormat_FormFields.Text = "&Form Fields"
            '
            'm_tmiFormat_FormFields_Edit
            '
            Me.m_tmiFormat_FormFields_Edit.Name = "m_tmiFormat_FormFields_Edit"
            Me.m_tmiFormat_FormFields_Edit.Size = New System.Drawing.Size(256, 22)
            Me.m_tmiFormat_FormFields_Edit.Text = "&Edit..."
            '
            'm_tspFormat_FormFields_Separator01
            '
            Me.m_tspFormat_FormFields_Separator01.Name = "m_tspFormat_FormFields_Separator01"
            Me.m_tspFormat_FormFields_Separator01.Size = New System.Drawing.Size(253, 6)
            '
            'm_tmiFormat_FormFields_EnableFormValidation
            '
            Me.m_tmiFormat_FormFields_EnableFormValidation.CheckOnClick = True
            Me.m_tmiFormat_FormFields_EnableFormValidation.Name = "m_tmiFormat_FormFields_EnableFormValidation"
            Me.m_tmiFormat_FormFields_EnableFormValidation.Size = New System.Drawing.Size(256, 22)
            Me.m_tmiFormat_FormFields_EnableFormValidation.Text = "Enable Form &Validation"
            '
            'm_tmiFormat_FormFields_ManageConditionalInstructions
            '
            Me.m_tmiFormat_FormFields_ManageConditionalInstructions.Name = "m_tmiFormat_FormFields_ManageConditionalInstructions"
            Me.m_tmiFormat_FormFields_ManageConditionalInstructions.Size = New System.Drawing.Size(256, 22)
            Me.m_tmiFormat_FormFields_ManageConditionalInstructions.Text = "&Manage Conditional Instructions..."
            '
            'm_tspFormat_Separator04
            '
            Me.m_tspFormat_Separator04.Name = "m_tspFormat_Separator04"
            Me.m_tspFormat_Separator04.Size = New System.Drawing.Size(211, 6)
            '
            'm_tmiFormat_Hyperlink
            '
            Me.m_tmiFormat_Hyperlink.Name = "m_tmiFormat_Hyperlink"
            Me.m_tmiFormat_Hyperlink.Size = New System.Drawing.Size(214, 22)
            Me.m_tmiFormat_Hyperlink.Text = "Hype&rlink..."
            '
            'm_tmiFormat_Bookmark
            '
            Me.m_tmiFormat_Bookmark.Name = "m_tmiFormat_Bookmark"
            Me.m_tmiFormat_Bookmark.Size = New System.Drawing.Size(214, 22)
            Me.m_tmiFormat_Bookmark.Text = "Boo&kmark..."
            '
            'm_tmiFormat_TableOfContents
            '
            Me.m_tmiFormat_TableOfContents.Name = "m_tmiFormat_TableOfContents"
            Me.m_tmiFormat_TableOfContents.Size = New System.Drawing.Size(214, 22)
            Me.m_tmiFormat_TableOfContents.Text = "Tabl&e of Contents..."
            '
            'm_tspFormat_Separator05
            '
            Me.m_tspFormat_Separator05.Name = "m_tspFormat_Separator05"
            Me.m_tspFormat_Separator05.Size = New System.Drawing.Size(211, 6)
            '
            'm_tmiFormat_Columns
            '
            Me.m_tmiFormat_Columns.Name = "m_tmiFormat_Columns"
            Me.m_tmiFormat_Columns.Size = New System.Drawing.Size(214, 22)
            Me.m_tmiFormat_Columns.Text = "Colu&mns..."
            '
            'm_tmiFormat_PageBorders
            '
            Me.m_tmiFormat_PageBorders.Name = "m_tmiFormat_PageBorders"
            Me.m_tmiFormat_PageBorders.Size = New System.Drawing.Size(214, 22)
            Me.m_tmiFormat_PageBorders.Text = "Page Bor&ders..."
            '
            'm_tmiFormat_PageColor
            '
            Me.m_tmiFormat_PageColor.Name = "m_tmiFormat_PageColor"
            Me.m_tmiFormat_PageColor.Size = New System.Drawing.Size(214, 22)
            Me.m_tmiFormat_PageColor.Text = "Page C&olor..."
            '
            'm_tmiFormat_Tabs
            '
            Me.m_tmiFormat_Tabs.Name = "m_tmiFormat_Tabs"
            Me.m_tmiFormat_Tabs.Size = New System.Drawing.Size(214, 22)
            Me.m_tmiFormat_Tabs.Text = "&Tabs..."
            '
            'm_tspFormat_Separator06
            '
            Me.m_tspFormat_Separator06.Name = "m_tspFormat_Separator06"
            Me.m_tspFormat_Separator06.Size = New System.Drawing.Size(211, 6)
            '
            'm_tmiFormat_Language
            '
            Me.m_tmiFormat_Language.Name = "m_tmiFormat_Language"
            Me.m_tmiFormat_Language.Size = New System.Drawing.Size(214, 22)
            Me.m_tmiFormat_Language.Text = "&Language..."
            '
            'm_tmiTable
            '
            Me.m_tmiTable.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiTable_Insert, Me.m_tmiTable_Delete, Me.m_tmiTable_Select, Me.m_tspTable_Separator01, Me.m_tmiTable_MergeCells, Me.m_tmiTable_SplitCells, Me.m_tmiTable_SplitTable, Me.m_tspTable_Separator02, Me.m_tmiTable_Formulas, Me.m_tspTable_Separator03, Me.m_tmiTable_Properties})
            Me.m_tmiTable.Name = "m_tmiTable"
            Me.m_tmiTable.Size = New System.Drawing.Size(46, 20)
            Me.m_tmiTable.Text = "&Table"
            '
            'm_tmiTable_Insert
            '
            Me.m_tmiTable_Insert.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiTable_Insert_Table, Me.m_tspTable_Insert_Separator01, Me.m_tmiTable_Insert_ColumnToTheLeft, Me.m_tmiTable_Insert_ColumnToTheRight, Me.m_tspTable_Insert_Separator02, Me.m_tmiTable_Insert_RowAbove, Me.m_tmiTable_Insert_RowBelow})
            Me.m_tmiTable_Insert.Name = "m_tmiTable_Insert"
            Me.m_tmiTable_Insert.Size = New System.Drawing.Size(136, 22)
            Me.m_tmiTable_Insert.Text = "&Insert"
            '
            'm_tmiTable_Insert_Table
            '
            Me.m_tmiTable_Insert_Table.Name = "m_tmiTable_Insert_Table"
            Me.m_tmiTable_Insert_Table.Size = New System.Drawing.Size(182, 22)
            Me.m_tmiTable_Insert_Table.Text = "Table"
            '
            'm_tspTable_Insert_Separator01
            '
            Me.m_tspTable_Insert_Separator01.Name = "m_tspTable_Insert_Separator01"
            Me.m_tspTable_Insert_Separator01.Size = New System.Drawing.Size(179, 6)
            '
            'm_tmiTable_Insert_ColumnToTheLeft
            '
            Me.m_tmiTable_Insert_ColumnToTheLeft.Name = "m_tmiTable_Insert_ColumnToTheLeft"
            Me.m_tmiTable_Insert_ColumnToTheLeft.Size = New System.Drawing.Size(182, 22)
            Me.m_tmiTable_Insert_ColumnToTheLeft.Text = "Column to the Left"
            '
            'm_tmiTable_Insert_ColumnToTheRight
            '
            Me.m_tmiTable_Insert_ColumnToTheRight.Name = "m_tmiTable_Insert_ColumnToTheRight"
            Me.m_tmiTable_Insert_ColumnToTheRight.Size = New System.Drawing.Size(182, 22)
            Me.m_tmiTable_Insert_ColumnToTheRight.Text = "Column to the Right"
            '
            'm_tspTable_Insert_Separator02
            '
            Me.m_tspTable_Insert_Separator02.Name = "m_tspTable_Insert_Separator02"
            Me.m_tspTable_Insert_Separator02.Size = New System.Drawing.Size(179, 6)
            '
            'm_tmiTable_Insert_RowAbove
            '
            Me.m_tmiTable_Insert_RowAbove.Name = "m_tmiTable_Insert_RowAbove"
            Me.m_tmiTable_Insert_RowAbove.Size = New System.Drawing.Size(182, 22)
            Me.m_tmiTable_Insert_RowAbove.Text = "Row Above"
            '
            'm_tmiTable_Insert_RowBelow
            '
            Me.m_tmiTable_Insert_RowBelow.Name = "m_tmiTable_Insert_RowBelow"
            Me.m_tmiTable_Insert_RowBelow.Size = New System.Drawing.Size(182, 22)
            Me.m_tmiTable_Insert_RowBelow.Text = "Row Below"
            '
            'm_tmiTable_Delete
            '
            Me.m_tmiTable_Delete.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiTable_Delete_Cells, Me.m_tmiTable_Delete_Columns, Me.m_tmiTable_Delete_Rows, Me.m_tmiTable_Delete_Table})
            Me.m_tmiTable_Delete.Name = "m_tmiTable_Delete"
            Me.m_tmiTable_Delete.Size = New System.Drawing.Size(136, 22)
            Me.m_tmiTable_Delete.Text = "&Delete"
            '
            'm_tmiTable_Delete_Cells
            '
            Me.m_tmiTable_Delete_Cells.Name = "m_tmiTable_Delete_Cells"
            Me.m_tmiTable_Delete_Cells.Size = New System.Drawing.Size(122, 22)
            Me.m_tmiTable_Delete_Cells.Text = "Cells"
            '
            'm_tmiTable_Delete_Columns
            '
            Me.m_tmiTable_Delete_Columns.Name = "m_tmiTable_Delete_Columns"
            Me.m_tmiTable_Delete_Columns.Size = New System.Drawing.Size(122, 22)
            Me.m_tmiTable_Delete_Columns.Text = "Columns"
            '
            'm_tmiTable_Delete_Rows
            '
            Me.m_tmiTable_Delete_Rows.Name = "m_tmiTable_Delete_Rows"
            Me.m_tmiTable_Delete_Rows.Size = New System.Drawing.Size(122, 22)
            Me.m_tmiTable_Delete_Rows.Text = "Rows"
            '
            'm_tmiTable_Delete_Table
            '
            Me.m_tmiTable_Delete_Table.Name = "m_tmiTable_Delete_Table"
            Me.m_tmiTable_Delete_Table.Size = New System.Drawing.Size(122, 22)
            Me.m_tmiTable_Delete_Table.Text = "Table"
            '
            'm_tmiTable_Select
            '
            Me.m_tmiTable_Select.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiTable_Select_Cell, Me.m_tmiTable_Select_Column, Me.m_tmiTable_Select_Row, Me.m_tmiTable_Select_Table})
            Me.m_tmiTable_Select.Name = "m_tmiTable_Select"
            Me.m_tmiTable_Select.Size = New System.Drawing.Size(136, 22)
            Me.m_tmiTable_Select.Text = "&Select"
            '
            'm_tmiTable_Select_Cell
            '
            Me.m_tmiTable_Select_Cell.Name = "m_tmiTable_Select_Cell"
            Me.m_tmiTable_Select_Cell.Size = New System.Drawing.Size(117, 22)
            Me.m_tmiTable_Select_Cell.Text = "Cell"
            '
            'm_tmiTable_Select_Column
            '
            Me.m_tmiTable_Select_Column.Name = "m_tmiTable_Select_Column"
            Me.m_tmiTable_Select_Column.Size = New System.Drawing.Size(117, 22)
            Me.m_tmiTable_Select_Column.Text = "Column"
            '
            'm_tmiTable_Select_Row
            '
            Me.m_tmiTable_Select_Row.Name = "m_tmiTable_Select_Row"
            Me.m_tmiTable_Select_Row.Size = New System.Drawing.Size(117, 22)
            Me.m_tmiTable_Select_Row.Text = "Row"
            '
            'm_tmiTable_Select_Table
            '
            Me.m_tmiTable_Select_Table.Name = "m_tmiTable_Select_Table"
            Me.m_tmiTable_Select_Table.Size = New System.Drawing.Size(117, 22)
            Me.m_tmiTable_Select_Table.Text = "Table"
            '
            'm_tspTable_Separator01
            '
            Me.m_tspTable_Separator01.Name = "m_tspTable_Separator01"
            Me.m_tspTable_Separator01.Size = New System.Drawing.Size(133, 6)
            '
            'm_tmiTable_MergeCells
            '
            Me.m_tmiTable_MergeCells.Name = "m_tmiTable_MergeCells"
            Me.m_tmiTable_MergeCells.Size = New System.Drawing.Size(136, 22)
            Me.m_tmiTable_MergeCells.Text = "&Merge Cells"
            '
            'm_tmiTable_SplitCells
            '
            Me.m_tmiTable_SplitCells.Name = "m_tmiTable_SplitCells"
            Me.m_tmiTable_SplitCells.Size = New System.Drawing.Size(136, 22)
            Me.m_tmiTable_SplitCells.Text = "Split &Cells"
            '
            'm_tmiTable_SplitTable
            '
            Me.m_tmiTable_SplitTable.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiTable_SplitTable_Above, Me.m_tmiTable_SplitTable_Below})
            Me.m_tmiTable_SplitTable.Name = "m_tmiTable_SplitTable"
            Me.m_tmiTable_SplitTable.Size = New System.Drawing.Size(136, 22)
            Me.m_tmiTable_SplitTable.Text = "Split &Table"
            '
            'm_tmiTable_SplitTable_Above
            '
            Me.m_tmiTable_SplitTable_Above.Name = "m_tmiTable_SplitTable_Above"
            Me.m_tmiTable_SplitTable_Above.Size = New System.Drawing.Size(108, 22)
            Me.m_tmiTable_SplitTable_Above.Text = "Above"
            '
            'm_tmiTable_SplitTable_Below
            '
            Me.m_tmiTable_SplitTable_Below.Name = "m_tmiTable_SplitTable_Below"
            Me.m_tmiTable_SplitTable_Below.Size = New System.Drawing.Size(108, 22)
            Me.m_tmiTable_SplitTable_Below.Text = "Below"
            '
            'm_tspTable_Separator02
            '
            Me.m_tspTable_Separator02.Name = "m_tspTable_Separator02"
            Me.m_tspTable_Separator02.Size = New System.Drawing.Size(133, 6)
            '
            'm_tmiTable_Formulas
            '
            Me.m_tmiTable_Formulas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_tmiTable_Formulas_A1ReferenceStyle, Me.m_tmiTable_Formulas_R1C1ReferenceStyle, Me.m_tspTable_Formulas_Separator01, Me.m_tmiTable_Formulas_EditFormula, Me.m_tspTable_Formulas_Separator02, Me.m_tmiTable_Formulas_AutomaticCalculation})
            Me.m_tmiTable_Formulas.Name = "m_tmiTable_Formulas"
            Me.m_tmiTable_Formulas.Size = New System.Drawing.Size(136, 22)
            Me.m_tmiTable_Formulas.Text = "&Formulas"
            '
            'm_tmiTable_Formulas_A1ReferenceStyle
            '
            Me.m_tmiTable_Formulas_A1ReferenceStyle.Name = "m_tmiTable_Formulas_A1ReferenceStyle"
            Me.m_tmiTable_Formulas_A1ReferenceStyle.Size = New System.Drawing.Size(193, 22)
            Me.m_tmiTable_Formulas_A1ReferenceStyle.Text = "A1 Reference Style"
            '
            'm_tmiTable_Formulas_R1C1ReferenceStyle
            '
            Me.m_tmiTable_Formulas_R1C1ReferenceStyle.Name = "m_tmiTable_Formulas_R1C1ReferenceStyle"
            Me.m_tmiTable_Formulas_R1C1ReferenceStyle.Size = New System.Drawing.Size(193, 22)
            Me.m_tmiTable_Formulas_R1C1ReferenceStyle.Text = "R1C1 Reference Style"
            '
            'm_tspTable_Formulas_Separator01
            '
            Me.m_tspTable_Formulas_Separator01.Name = "m_tspTable_Formulas_Separator01"
            Me.m_tspTable_Formulas_Separator01.Size = New System.Drawing.Size(190, 6)
            '
            'm_tmiTable_Formulas_EditFormula
            '
            Me.m_tmiTable_Formulas_EditFormula.Name = "m_tmiTable_Formulas_EditFormula"
            Me.m_tmiTable_Formulas_EditFormula.Size = New System.Drawing.Size(193, 22)
            Me.m_tmiTable_Formulas_EditFormula.Text = "Edit Formula..."
            '
            'm_tspTable_Formulas_Separator02
            '
            Me.m_tspTable_Formulas_Separator02.Name = "m_tspTable_Formulas_Separator02"
            Me.m_tspTable_Formulas_Separator02.Size = New System.Drawing.Size(190, 6)
            '
            'm_tmiTable_Formulas_AutomaticCalculation
            '
            Me.m_tmiTable_Formulas_AutomaticCalculation.CheckOnClick = True
            Me.m_tmiTable_Formulas_AutomaticCalculation.Name = "m_tmiTable_Formulas_AutomaticCalculation"
            Me.m_tmiTable_Formulas_AutomaticCalculation.Size = New System.Drawing.Size(193, 22)
            Me.m_tmiTable_Formulas_AutomaticCalculation.Text = "Automatic Calculation"
            '
            'm_tspTable_Separator03
            '
            Me.m_tspTable_Separator03.Name = "m_tspTable_Separator03"
            Me.m_tspTable_Separator03.Size = New System.Drawing.Size(133, 6)
            '
            'm_tmiTable_Properties
            '
            Me.m_tmiTable_Properties.Name = "m_tmiTable_Properties"
            Me.m_tmiTable_Properties.Size = New System.Drawing.Size(136, 22)
            Me.m_tmiTable_Properties.Text = "&Properties..."
            '
            'm_bbButtonBar
            '
            Me.m_bbButtonBar.BackColor = System.Drawing.SystemColors.Control
            Me.m_bbButtonBar.Dock = System.Windows.Forms.DockStyle.Top
            Me.m_bbButtonBar.Location = New System.Drawing.Point(0, 24)
            Me.m_bbButtonBar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.m_bbButtonBar.Name = "m_bbButtonBar"
            Me.m_bbButtonBar.Size = New System.Drawing.Size(1034, 29)
            Me.m_bbButtonBar.TabIndex = 1
            Me.m_bbButtonBar.Text = "buttonBar1"
            '
            'm_sbStatusBar
            '
            Me.m_sbStatusBar.BackColor = System.Drawing.SystemColors.Control
            Me.m_sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.m_sbStatusBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.m_sbStatusBar.Location = New System.Drawing.Point(0, 789)
            Me.m_sbStatusBar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.m_sbStatusBar.Name = "m_sbStatusBar"
            Me.m_sbStatusBar.Size = New System.Drawing.Size(1034, 22)
            Me.m_sbStatusBar.TabIndex = 2
            '
            'm_txTextControl
            '
            Me.m_txTextControl.AllowDrag = True
            Me.m_txTextControl.AllowDrop = True
            Me.m_txTextControl.ButtonBar = Me.m_bbButtonBar
            Me.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.m_txTextControl.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.m_txTextControl.FormattingPrinter = "Standard"
            Me.m_txTextControl.HideSelection = False
            Me.m_txTextControl.Location = New System.Drawing.Point(25, 78)
            Me.m_txTextControl.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.m_txTextControl.Name = "m_txTextControl"
            Me.m_txTextControl.PageMargins.Bottom = 78.75R
            Me.m_txTextControl.PageMargins.Left = 78.75R
            Me.m_txTextControl.PageMargins.Right = 78.75R
            Me.m_txTextControl.PageMargins.Top = 78.75R
            Me.m_txTextControl.PageSize.Height = 1169.31R
            Me.m_txTextControl.PageSize.Width = 826.81R
            Me.m_txTextControl.RulerBar = Me.m_rbHorizontalRulerBar
            Me.m_txTextControl.Size = New System.Drawing.Size(1009, 711)
            Me.m_txTextControl.StatusBar = Me.m_sbStatusBar
            Me.m_txTextControl.TabIndex = 3
            Me.m_txTextControl.UserNames = Nothing
            Me.m_txTextControl.VerticalRulerBar = Me.m_rbVerticalRulerBar
            '
            'm_rbHorizontalRulerBar
            '
            Me.m_rbHorizontalRulerBar.Dock = System.Windows.Forms.DockStyle.Top
            Me.m_rbHorizontalRulerBar.Location = New System.Drawing.Point(0, 53)
            Me.m_rbHorizontalRulerBar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.m_rbHorizontalRulerBar.Name = "m_rbHorizontalRulerBar"
            Me.m_rbHorizontalRulerBar.Size = New System.Drawing.Size(1034, 25)
            Me.m_rbHorizontalRulerBar.TabIndex = 5
            Me.m_rbHorizontalRulerBar.Text = "rulerBar2"
            '
            'm_rbVerticalRulerBar
            '
            Me.m_rbVerticalRulerBar.Alignment = TXTextControl.RulerBarAlignment.Left
            Me.m_rbVerticalRulerBar.Dock = System.Windows.Forms.DockStyle.Left
            Me.m_rbVerticalRulerBar.Location = New System.Drawing.Point(0, 78)
            Me.m_rbVerticalRulerBar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.m_rbVerticalRulerBar.Name = "m_rbVerticalRulerBar"
            Me.m_rbVerticalRulerBar.Size = New System.Drawing.Size(25, 711)
            Me.m_rbVerticalRulerBar.TabIndex = 4
            Me.m_rbVerticalRulerBar.Text = "rulerBar1"
            '
            'MainWindow
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(1034, 811)
            Me.Controls.Add(Me.m_txTextControl)
            Me.Controls.Add(Me.m_rbVerticalRulerBar)
            Me.Controls.Add(Me.m_rbHorizontalRulerBar)
            Me.Controls.Add(Me.m_bbButtonBar)
            Me.Controls.Add(Me.m_sbStatusBar)
            Me.Controls.Add(Me.m_msMenu)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MainMenuStrip = Me.m_msMenu
            Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.Name = "MainWindow"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "TX Text Control Words"
            Me.m_msMenu.ResumeLayout(False)
            Me.m_msMenu.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private m_msMenu As System.Windows.Forms.MenuStrip
        Private m_tmiFile As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFile_New As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFile_Open As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFile_RecentFiles As System.Windows.Forms.ToolStripMenuItem
        Private m_tspFile_Separator01 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiFile_Save As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFile_SaveAs As System.Windows.Forms.ToolStripMenuItem
        Private m_tspFile_Separator02 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiFile_PageSetup As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFile_PrintPreview As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFile_Print As System.Windows.Forms.ToolStripMenuItem
        Private m_tspFile_Separator03 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiFile_SignIn As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFile_CurrentUser As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFile_Exit As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFile_CurrentUser_AccountSettings As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFile_CurrentUser_SignOut As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_Undo As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_Redo As System.Windows.Forms.ToolStripMenuItem
        Private m_tspEdit_Separator01 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiEdit_Cut As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_Copy As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_Paste As System.Windows.Forms.ToolStripMenuItem
        Private m_tspEdit_Separator02 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiEdit_SelectAll As System.Windows.Forms.ToolStripMenuItem
        Private m_tspEdit_Separator03 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiEdit_Find As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_Replace As System.Windows.Forms.ToolStripMenuItem
        Private m_tspEdit_Separator04 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiInsert_TableOfContents_Update As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_TableOfContents_Delete As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_Permissions As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_Permissions_ReadOnly As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_Permissions_AllowCopy As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_Permissions_AllowFormatting As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_Permissions_AllowFormattingStyles As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_Permissions_AllowEditingFormFields As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_Permissions_AllowPrinting As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_ProtectDocument As System.Windows.Forms.ToolStripMenuItem
        Private m_tspEdit_Separator05 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiEdit_TrackedChanges As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_TrackedChanges_TrackChanges As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_TrackedChanges_ReviewTrackedChanges As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_Comments As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_PageLayout As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_Draft As System.Windows.Forms.ToolStripMenuItem
        Private m_tspView_Separator01 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiView_ButtonBar As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_StatusBar As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_HorizontalRuler As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_VerticalRuler As System.Windows.Forms.ToolStripMenuItem
        Private m_tspView_Separator02 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiView_TextFrameMarkerLines As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_DrawingMarkerLines As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_BookmarkMarkers As System.Windows.Forms.ToolStripMenuItem
        Private m_tspView_Separator03 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiView_EditableRegions As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_Comments As System.Windows.Forms.ToolStripMenuItem
        Private m_tspView_Separator04 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiView_Zoom As System.Windows.Forms.ToolStripMenuItem
        Private m_tspView_Separator05 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiView_RightToLeftLayout As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_EditableRegions_Always As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_EditableRegions_Current As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_EditableRegions_Never As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_Comments_Always As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_Comments_Current As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_Comments_Never As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_Zoom_50 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_Zoom_75 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_Zoom_100 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_Zoom_150 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_Zoom_200 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_Zoom_300 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_Zoom_400 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_File As System.Windows.Forms.ToolStripMenuItem
        Private m_tspInsert_Separator01 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiInsert_Image As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Shape As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_TextFrame As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_PageNumber As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_TableOfContents As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Shape_Lines As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Shape_Rectangles As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Shape_BasicShapes As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Shape_BlockArrows As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Shape_EquationShapes As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Shape_Flowchart As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Shape_StarsAndBanners As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Shape_Callouts As System.Windows.Forms.ToolStripMenuItem
        Private m_tspInsert_Shape_Separator01 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiInsert_Shape_DrawingCanvas As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_PageNumber_Insert As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_PageNumber_Delete As System.Windows.Forms.ToolStripMenuItem
        Private m_tspInsert_Separator02 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiInsert_FormField As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_FormField_TextFormField As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_FormField_CheckBox As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_FormField_ComboBox As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_FormField_DropDownList As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_FormField_DateFormField As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Symbol As System.Windows.Forms.ToolStripMenuItem
        Private m_tspInsert_Separator03 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiInsert_Hyperlink As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Bookmark As System.Windows.Forms.ToolStripMenuItem
        Private m_tspInsert_Separator04 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiFormat As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_Character As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_Paragraph As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_BulletsAndNumbering As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_BulletsAndNumbering_Properties As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_BulletsAndNumbering_IncreaseLevel As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_BulletsAndNumbering_DecreaseLevel As System.Windows.Forms.ToolStripMenuItem
        Private m_tspFormat_BulletsAndNumbering_Separator02 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiFormat_BulletsAndNumbering_ArabicNumbers As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_BulletsAndNumbering_CapitalLetters As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_BulletsAndNumbering_Letters As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_BulletsAndNumbering_RomanNumbers As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_BulletsAndNumbering_SmallRomanNumbers As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_BulletsAndNumbering_Bullets As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_Styles As System.Windows.Forms.ToolStripMenuItem
        Private m_tspFormat_Separator01 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiFormat_HeadersAndFooters As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_Columns As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_PageBorders As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_Tabs As System.Windows.Forms.ToolStripMenuItem
        Private m_tspFormat_Separator02 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiFormat_Image As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_TextFrame As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_Shape As System.Windows.Forms.ToolStripMenuItem
        Private m_tspFormat_Separator03 As System.Windows.Forms.ToolStripSeparator
        Private m_tspFormat_Separator04 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiFormat_Language As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable_Insert As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable_Insert_Table As System.Windows.Forms.ToolStripMenuItem
        Private m_tspTable_Insert_Separator01 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiTable_Insert_ColumnToTheLeft As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable_Insert_ColumnToTheRight As System.Windows.Forms.ToolStripMenuItem
        Private m_tspTable_Insert_Separator02 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiTable_Insert_RowAbove As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable_Insert_RowBelow As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable_Delete As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable_Delete_Cells As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable_Delete_Table As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable_Delete_Columns As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable_Delete_Rows As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable_Select As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable_Select_Cell As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable_Select_Column As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable_Select_Row As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable_Select_Table As System.Windows.Forms.ToolStripMenuItem
        Private m_tspTable_Separator01 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiTable_MergeCells As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable_SplitCells As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable_SplitTable As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable_SplitTable_Above As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable_SplitTable_Below As System.Windows.Forms.ToolStripMenuItem
        Private m_tspTable_Separator02 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiTable_Formulas As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable_Formulas_A1ReferenceStyle As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiTable_Formulas_R1C1ReferenceStyle As System.Windows.Forms.ToolStripMenuItem
        Private m_tspTable_Formulas_Separator01 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiTable_Formulas_EditFormula As System.Windows.Forms.ToolStripMenuItem
        Private m_tspTable_Formulas_Separator02 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiTable_Formulas_AutomaticCalculation As System.Windows.Forms.ToolStripMenuItem
        Private m_tspTable_Separator03 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiTable_Properties As System.Windows.Forms.ToolStripMenuItem
        Private m_bbButtonBar As ButtonBar
        Private m_sbStatusBar As StatusBar
        Private m_txTextControl As TextControl
        Private m_rbHorizontalRulerBar As RulerBar
        Private m_rbVerticalRulerBar As RulerBar
        Private m_tmiFile_PrintQuick As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Bookmark_Insert As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Bookmark_Delete As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_TableOfContents_Insert As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_Comments_AddComment As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_Comments_ReviewComments As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_EditableRegions As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_EditableRegions_Add As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_EditableRegions_Add_ForCurrentUser As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_EditableRegions_Add_ForEveryone As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_EditableRegions_Remove As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_EditableRegions_Remove_ForCurrentUser As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiEdit_EditableRegions_Remove_ForEveryone As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_TableGridlines As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_ControlChars As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiView_TrackedChanges As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Barcode As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Header As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Footer As System.Windows.Forms.ToolStripMenuItem
        Private m_tspInsert_Separator05 As System.Windows.Forms.ToolStripSeparator
        Private m_tspInsert_Separator06 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiInsert_Header_Insert As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Header_Remove As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Footer_Insert As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Footer_Remove As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_PageNumberField As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_PageColor As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_Barcode As System.Windows.Forms.ToolStripMenuItem
        Private m_tspFormat_Separator06 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiInsert_Columns As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_PageBreaks As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_SectionBreaks As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_SectionBreaks_NextPage As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_SectionBreaks_Continuous As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_PageBreaks_Page As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_PageBreaks_Column As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_PageBreaks_TextWrapping As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Columns_One As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiInsert_Columns_Two As System.Windows.Forms.ToolStripMenuItem
        Private m_tspInsert_Columns_Separator01 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiInsert_Columns_MoreColumns As System.Windows.Forms.ToolStripMenuItem
        Private m_tspFormat_BulletsAndNumbering_Separator03 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiFormat_BulletsAndNumbering_AsStructuredList As System.Windows.Forms.ToolStripMenuItem
        Private m_tspFormat_BulletsAndNumbering_Separator01 As System.Windows.Forms.ToolStripSeparator
        Private m_tspInsert_FormField_Separator01 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiInsert_FormField_Delete As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_FormFields As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_FormFields_EnableFormValidation As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_FormFields_ManageConditionalInstructions As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_Hyperlink As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_Bookmark As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_TableOfContents As System.Windows.Forms.ToolStripMenuItem
        Private m_tspFormat_Separator05 As System.Windows.Forms.ToolStripSeparator
        Private m_tmiFormat_ParagraphStructureLevels As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_AddToParagraph As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_BodyText As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level01 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level02 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level03 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level04 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level05 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level06 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level07 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level08 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level09 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_Level10 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_AddToParagraph_BodyText As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level01 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level02 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level03 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level04 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level05 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level06 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level07 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level08 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level09 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_ParagraphStructureLevels_AddToParagraph_Level10 As System.Windows.Forms.ToolStripMenuItem
        Private m_tmiFormat_FormFields_Edit As System.Windows.Forms.ToolStripMenuItem
        Private m_tspFormat_FormFields_Separator01 As System.Windows.Forms.ToolStripSeparator
    End Class
End Namespace
