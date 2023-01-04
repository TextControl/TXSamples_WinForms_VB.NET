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
Imports TXTextControl.Windows.Forms.Ribbon

Namespace TXTextControl.Words
    Partial Public Class MainWindow
        Inherits RibbonForm
        '-----------------------------------------------------------------------------------------------------------
        ' M E M B E R   V A R I A B L E S
        '-----------------------------------------------------------------------------------------------------------
        Private ReadOnly m_rmResources As ResourceManager = Nothing
        Private ReadOnly m_strFilesDirectory As String = "Files\"

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
            LoadRecentFiles()
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' O V E R R I D D E N   M E T H O D S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------
        ' OnLoad Method (overridden)
        ' Sets the requested behavior for all added controls.
        '-----------------------------------------------------------------------------------------------------
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            ' Select the 'Reporting' tab
            m_rbnRibbon.SelectedIndex = 3

            ' Main Window:
            UpdateMainWindowCaption() ' Set caption

            ' Application Menu items:
            SetAppMenuDesign()
            SetAppMenuBehavior()

            ' QAT:
            SetQATItemsDesign()
            SetUndoRedoButtonsBehavior()

            ' Sidebars:
            SetSidebarBehavior()

            ' Mini Toolbar
            m_txTextControl.ShowMiniToolbar = MiniToolbarButton.LeftButton Or MiniToolbarButton.RightButton

            ' Contextual Tabs:
            SetContextualTabsBehavior()

            ' Toolbars:
            SetRulerBarsDesign()
            SetStatusBarDesign()

            ' Reporting Preview:
            AddSampleDatabaseButton()
            AddMergeGroup(m_rtRibbonReportingTab)
            SetMergeResultsTabDesign()
            SetResultTabBehavior()

            ' About:
            UpdateAboutSidebar()

            ' Set the TextControl as active control when shown.
            ActiveControl = m_txTextControl
            MyBase.OnLoad(e)
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' M E T H O D S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------
        ' SetAppMenuDesign Method
        ' Updates the design of the menu items.
        '-----------------------------------------------------------------------------------------------------
        Private Sub SetAppMenuDesign()
            SetRibbonButtonDesign(ResourceProvider.FileMenuItem.TXITEM_New.ToString(), m_rbtnNew)
            SetRibbonButtonDesign(ResourceProvider.FileMenuItem.TXITEM_Open.ToString(), m_rbtnOpen)
            SetOpenSampleTemplateButtonDesign()
            SetRibbonButtonDesign(ResourceProvider.FileMenuItem.TXITEM_Save.ToString(), m_rbtnSave)
            SetRibbonButtonDesign(ResourceProvider.FileMenuItem.TXITEM_SaveAs.ToString(), m_rbtnSaveAs)
            SetRibbonButtonDesign(ResourceProvider.FileMenuItem.TXITEM_Print.ToString(), m_rsbtnPrint)
            SetRibbonButtonDesign(ResourceProvider.FileMenuItem.TXITEM_Print.ToString(), m_rbtnPrint)
            SetRibbonButtonDesign(ResourceProvider.FileMenuItem.TXITEM_PrintQuick.ToString(), m_rbtnPrintQuick)
            SetRibbonButtonDesign(ResourceProvider.FileMenuItem.TXITEM_PrintPreview.ToString(), m_rbtnPrintPreview)
            SetRibbonButtonDesign(ResourceProvider.FileMenuItem.TXITEM_About.ToString(), m_rtbtnAbout, My.Resources.AboutButton_ToolTip_Description)

            ' Set Recent Files overview label text
            m_rlblRecentFiles.Text = My.Resources.ApplicationMenu_ResentFiles
        End Sub

        '-----------------------------------------------------------------------------------------------------
        ' SetAppMenuBehavior Method
        ' Connects all necessary handlers to the application menu items.
        '-----------------------------------------------------------------------------------------------------
        Private Sub SetAppMenuBehavior()
            ' Common
            AddHandler m_txTextControl.Changed, AddressOf TextControl_Changed ' Updates the internal 'is dirty document' flag
            AddHandler FormClosing, AddressOf MainWindow_FormClosing ' Saves the recent files before the application is closed

            ' New:
            AddHandler m_rbtnNew.Click, AddressOf New_Click

            ' Open:
            AddHandler m_rbtnOpen.Click, AddressOf Open_Click

            ' Save:
            AddHandler m_rbtnSave.Click, AddressOf Save_Click

            ' Save As:
            AddHandler m_rbtnSaveAs.Click, AddressOf SaveAs_Click

            ' Print:
            AddHandler m_rsbtnPrint.ButtonClick, AddressOf Print_Click ' Print(Split Button)
            AddHandler m_rbtnPrint.Click, AddressOf Print_Click ' Print (Drop Down Button)
            AddHandler m_rbtnPrintQuick.Click, AddressOf PrintQuick_Click ' Print Quick (Drop Down Button)
            AddHandler m_rbtnPrintPreview.Click, AddressOf PrintPreview_Click ' Print Preview (Drop Down Button)         
            AddHandler m_txTextControl.PropertyChanged, AddressOf TextControl_PropertyChanged_Print ' Add handler for the print buttons Enable state handling

            ' About:
            AddHandler m_rtbtnAbout.CheckedChanged, AddressOf About_CheckedChanged
        End Sub

        '-----------------------------------------------------------------------------------------------------
        ' SetRibbonButtonDesign Method
        ' Sets the icons, text, key tip and tool tip for a specific RibbonButton.
        '
        ' Parameters:
        '      resourceID:     The id that is used to identify the corresponding texts and icons.
        '      ribbonButton:   The ribbon button to update.
        '      args:           Optional strings that are used to format the displayed texts.
        '-----------------------------------------------------------------------------------------------------
        Private Sub SetRibbonButtonDesign(ByVal resourceID As String, ByVal ribbonButton As RibbonButton, ParamArray args As String())
            ribbonButton.Name = resourceID
            ribbonButton.SmallIcon = ResourceProvider.GetSmallIcon(resourceID, Me)
            ribbonButton.LargeIcon = ResourceProvider.GetLargeIcon(resourceID, Me)
            ribbonButton.KeyTip = ResourceProvider.GetKeyTip(resourceID)

            If args.Length > 0 Then
                ribbonButton.Text = String.Format(ResourceProvider.GetText(resourceID), args)
                ribbonButton.ToolTip.Title = String.Format(ResourceProvider.GetToolTipTitle(resourceID), args)
                ribbonButton.ToolTip.Description = String.Format(ResourceProvider.GetToolTipDescription(resourceID), args)
            Else
                ribbonButton.Text = ResourceProvider.GetText(resourceID)
                ribbonButton.ToolTip.Title = ResourceProvider.GetToolTipTitle(resourceID)
                ribbonButton.ToolTip.Description = ResourceProvider.GetToolTipDescription(resourceID)
            End If
            m_lstCustomRibbonButtons.Add(ribbonButton)
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

            Using sStream = asm.GetManifestResourceStream(path)
                bmp = ResourceProvider.GetSmallIcon(sStream, m_fDPI)
            End Using
            Return bmp
        End Function

        '-----------------------------------------------------------------------------------------------------------
        ' GetLargeIcon Method
        ' Creates a large bitmap icon from an embedded SVG resource.
        '
        ' Parameters:
        '      path:   The path to the embedded SVG resource.
        '
        ' Returns:     The created large bitmap.
        '-----------------------------------------------------------------------------------------------------------
        Private Function GetLargeIcon(ByVal path As String) As Bitmap
            Dim asm As Assembly = Assembly.GetExecutingAssembly()
            Dim bmp As Bitmap = Nothing

            Using sStream = asm.GetManifestResourceStream(path)
                bmp = ResourceProvider.GetLargeIcon(sStream, m_fDPI)
            End Using
            Return bmp
        End Function

        '-----------------------------------------------------------------------------------------------------------
        ' H A N D L E R S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' MainWindow_FormClosing Handler
        ' Saves the recent files to the My.Settings.Default.RecentFiles property.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub MainWindow_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            ' Save the recent files to the My.Settings.Default.RecentFiles property
            SaveRecentFiles()
        End Sub

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
