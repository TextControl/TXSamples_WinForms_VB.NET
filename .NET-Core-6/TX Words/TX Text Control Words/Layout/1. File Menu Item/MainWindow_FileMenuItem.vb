'-----------------------------------------------------------------------------------------------------------
' MainWindow_FileMenuItem.vb File
'
' Description: Provides methods to set the layout and behavior of the 'File' menu items.
'     
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Imports System.Collections.Specialized
Imports TXTextControl.Windows.Forms

Namespace TXTextControl.Words
    Partial Class MainWindow
        '-----------------------------------------------------------------------------------------------------------
        ' M E M B E R   V A R I A B L E S
        '-----------------------------------------------------------------------------------------------------------

        ' 'Open...' item
        Private ReadOnly m_isPDFImportSettings As PDFImportSettings = PDFImportSettings.GenerateTextFrames Or PDFImportSettings.LoadEmbeddedFiles

        ' 'Recent Files' item
        Private Const m_iMaxRecentFiles As Integer = 10
        Private m_colRecentFiles As StringCollection

        ' 'Sign In...' and '[Current user]' items
        Private m_uiCurrentUser As UserInfo = Nothing ' Info about the current user.
        Private m_strUserName As String = "" ' Environment.UserName


        '-----------------------------------------------------------------------------------------------------------
        ' M E T H O D S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' SetFileItemsTexts Method
        '
        ' Sets the texts of the 'File' menu items.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetFileItemsTexts()
            SetItemText(m_tmiFile)

            ' 'New'
            SetItemText(m_tmiFile_New)

            ' 'Open...'
            SetItemText(m_tmiFile_Open)

            ' 'Recent Files'
            SetItemText(m_tmiFile_RecentFiles)

            ' 'Save'
            SetItemText(m_tmiFile_Save)

            ' 'Save As...'
            SetItemText(m_tmiFile_SaveAs)

            ' 'Page Setup...'
            SetItemText(m_tmiFile_PageSetup)

            ' 'Print Preview...'
            SetItemText(m_tmiFile_PrintPreview)

            ' 'Print...'
            SetItemText(m_tmiFile_Print)

            ' 'Print Quick'
            SetItemText(m_tmiFile_PrintQuick)

            ' 'Sign In...'
            SetItemText(m_tmiFile_SignIn)

            ' '[Current User]'
            SetItemText(m_tmiFile_CurrentUser, m_strUserName)
            SetItemText(m_tmiFile_CurrentUser_AccountSettings)
            SetItemText(m_tmiFile_CurrentUser_SignOut)

            ' 'Exit'
            SetItemText(m_tmiFile_Exit)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' SetFileItemsImages Method
        '
        ' Sets the images of the 'File' menu items.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetFileItemsImages()
            ' 'New'
            SetItemImage(m_tmiFile_New, ResourceProvider.FileMenuItem.TXITEM_New.ToString())

            ' 'Open...'
            SetItemImage(m_tmiFile_Open, ResourceProvider.FileMenuItem.TXITEM_Open.ToString())

            ' 'Save'
            SetItemImage(m_tmiFile_Save, ResourceProvider.FileMenuItem.TXITEM_Save.ToString())

            ' 'Save As...'
            SetItemImage(m_tmiFile_SaveAs, ResourceProvider.FileMenuItem.TXITEM_SaveAs.ToString())

            ' 'Page Setup...'
            SetItemImage(m_tmiFile_PageSetup, Ribbon.RibbonPageLayoutTab.RibbonItem.TXITEM_PageMargins.ToString())

            ' 'Print Preview...'
            SetItemImage(m_tmiFile_PrintPreview, ResourceProvider.FileMenuItem.TXITEM_PrintPreview.ToString())

            ' 'Print...'
            SetItemImage(m_tmiFile_Print, ResourceProvider.FileMenuItem.TXITEM_Print.ToString())

            ' 'Print Quick'
            SetItemImage(m_tmiFile_PrintQuick, ResourceProvider.FileMenuItem.TXITEM_PrintQuick.ToString())

            ' 'Sign In...'
            SetItemImage(m_tmiFile_SignIn, ResourceProvider.FileMenuItem.TXITEM_SignIn.ToString())

            ' '[Current User]'
            SetItemImage(m_tmiFile_CurrentUser, ResourceProvider.FileMenuItem.TXITEM_CurrentUser.ToString())
            SetItemImage(m_tmiFile_CurrentUser_AccountSettings, ResourceProvider.FileMenuItem.TXITEM_AccountSettings.ToString())
            SetItemImage(m_tmiFile_CurrentUser_SignOut, ResourceProvider.FileMenuItem.TXITEM_SignOut.ToString())

            ' 'Exit'
            SetItemImage(m_tmiFile_Exit, ResourceProvider.FileMenuItem.TXITEM_Exit.ToString())
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' ConnectFileItemsHandlers Method
        '
        ' Connects the 'File' menu items to Click and DropDownOpening handlers.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub ConnectFileItemsHandlers()
            ' Click Handlers:

            ' 'New'
            AddHandler m_tmiFile_New.Click, AddressOf File_New_Click

            ' 'Open...'
            AddHandler m_tmiFile_Open.Click, AddressOf File_Open_Click

            ' 'Save'
            AddHandler m_tmiFile_Save.Click, AddressOf File_Save_Click

            ' 'Save As...'
            AddHandler m_tmiFile_SaveAs.Click, AddressOf File_SaveAs_Click

            ' 'Page Setup...'
            AddHandler m_tmiFile_PageSetup.Click, AddressOf File_PageSetup_Click

            ' 'Print Preview...'
            AddHandler m_tmiFile_PrintPreview.Click, AddressOf File_PrintPreview_Click

            ' 'Print...'
            AddHandler m_tmiFile_Print.Click, AddressOf File_Print_Click

            ' 'Print Quick'
            AddHandler m_tmiFile_PrintQuick.Click, AddressOf File_PrintQuick_Click

            ' 'Sign In...'
            AddHandler m_tmiFile_SignIn.Click, AddressOf File_SignIn_Click

            ' '[Current User]'
            AddHandler m_tmiFile_CurrentUser_AccountSettings.Click, AddressOf File_CurrentUser_AccountSettings_Click
            AddHandler m_tmiFile_CurrentUser_SignOut.Click, AddressOf File_CurrentUser_SignOut_Click

            ' 'Exit'
            AddHandler m_tmiFile_Exit.Click, AddressOf File_Exit_Click


            ' DropDownOpening Handlers

            ' 'File'
            AddHandler m_tmiFile.DropDownOpening, AddressOf File_DropDownOpening
        End Sub
    End Class
End Namespace
