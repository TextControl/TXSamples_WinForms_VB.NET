'-----------------------------------------------------------------------------------------------------------
' MainWindow_RibbonViewTab_RightToLeft.vb File
'
' Description:
'     Mangages the alignment/orientation of the application.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Imports System.Globalization
Imports TXTextControl.Windows.Forms.Ribbon

Namespace TXTextControl.Words
    Partial Class MainWindow

        '-----------------------------------------------------------------------------------------------------------
        ' M E M B E R   V A R I A B L E S
        '-----------------------------------------------------------------------------------------------------------

        Private m_rgAppViewGroup As RibbonGroup = Nothing
        Private m_rbtnRightToLeft As RibbonButton = Nothing

        '-----------------------------------------------------------------------------------------------------------
        ' H A N D L E R S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' RightToLeftFormLayout_Click Handler
        ' Restarts the application with a program's view that has a reversed text appearance. Furthermore
        ' the user can save the current document before closing the application if the document is dirty.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub RightToLeftFormLayout_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim bIsRightToLeft As Boolean = CBool(TryCast(sender, RibbonButton).Tag)
            If SaveDirtyDocumentBeforeReset(bIsRightToLeft) Then
                My.Settings.Default.RightToLeft = If(bIsRightToLeft, RightToLeft.No, RightToLeft.Yes)
                SaveRecentFiles()
                Call Application.Restart()
            End If
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' M E T H O D S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' LoadRightToLeftSettings Method
        ' Gets the RightToLeft value from the application settings and sets that value as right to left layout.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub LoadRightToLeftSettings()
            RightToLeftLayout = CSharpImpl.Assign(m_rbnRibbon.RightToLeftLayout, CSharpImpl.Assign(RightToLeft, My.Settings.Default.RightToLeft) = RightToLeft.Yes)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' AddAppViewGroup Method
        ' Creates a ribbon group with a ribbon button that restarts the application with a program's view that
        ' has a reversed text appearance. That ribbon group is added to the specified ribbon tab. 
        '
        ' Parameters:
        '      ribbonTab:   The ribbon tab where to add the created ribbon group.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub AddAppViewGroup(ByVal ribbonTab As RibbonViewTab)
            ' Create the icon for the ribbon group and ribbon button.
            Dim bmpSmallIcon = GetSmallIcon("RightToLeft_Small.svg")
            Dim bmpLargeIcon = GetLargeIcon("RightToLeft_Large.svg")

            ' Create the ribbon group
            m_rgAppViewGroup = New RibbonGroup() With {
                .Text = My.Resources.RibbonViewTab_ApplicationView,
                .SmallIcon = bmpSmallIcon,
                .LargeIcon = bmpSmallIcon,
                .KeyTip = My.Resources.RibbonViewTab_ApplicationView_KeyTip,
                .HorizontalContentAlignment = HorizontalAlignment.Center
            }
            m_rgAppViewGroup.DialogBoxLauncher.Visible = False

            ' Add a ribbon button that restarts the application with a program's
            ' view that has a reversed text appearance.
            AddRightToLeftButton(m_rgAppViewGroup, bmpSmallIcon, bmpLargeIcon)

            ' Add the ribbon group to the ribbon tab
            ribbonTab.RibbonGroups.Add(m_rgAppViewGroup)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' AddRightToLeftButton Method
        ' Creates a ribbon button that restarts the application with a program's view that
        ' has a reversed text appearance. That ribbon button is added to the specified ribbon group. 
        '
        ' Parameters:
        '      ribbonGroup:    The ribbon group where to add the created ribbon button.
        '      smallIcon:      The bitmap that is used as the ribbon button's small icon.
        '      largeIcon:      The bitmap that is used as the ribbon button's large icon.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub AddRightToLeftButton(ByVal ribbonGroup As RibbonGroup, ByVal smallIcon As Bitmap, ByVal largeIcon As Bitmap)
            ' Get the current text appearance.
            Dim bIsRightToLeft As Boolean = IsFormLayoutRightToLeft()

            ' Create the ribbon button
            m_rbtnRightToLeft = New RibbonButton() With {
                .Text = If(bIsRightToLeft, My.Resources.RibbonViewTab_LeftToRight, My.Resources.RibbonViewTab_RightToLeft),
                .SmallIcon = smallIcon,
                .LargeIcon = largeIcon,
                .KeyTip = My.Resources.RibbonViewTab_LeftToRight_KeyTip,
                .Tag = bIsRightToLeft
            }

            ' Add tool tips
            m_rbtnRightToLeft.ToolTip.Title = If(bIsRightToLeft, My.Resources.RibbonViewTab_LeftToRight_ToolTip_Title, My.Resources.RibbonViewTab_RightToLeft_ToolTip_Title)
            m_rbtnRightToLeft.ToolTip.Description = If(bIsRightToLeft, My.Resources.RibbonViewTab_LeftToRight_ToolTip_Description, My.Resources.RibbonViewTab_RightToLeft_ToolTip_Description)

            ' Add the handler that restarts the application with a reversed text appearance. 
            AddHandler m_rbtnRightToLeft.Click, AddressOf RightToLeftFormLayout_Click

            ' Add the ribbon button to the ribbon group
            ribbonGroup.RibbonItems.Add(m_rbtnRightToLeft)
        End Sub



        '-----------------------------------------------------------------------------------------------------------
        ' IsFormLayoutRigthToLeft Method
        ' Calculates whether the text appearance is set to 'right to left'.
        '
        ' Return value:    True if the text appearance is set to 'right to left'. Otherwise false.
        '-----------------------------------------------------------------------------------------------------------
        Private Function IsFormLayoutRightToLeft() As Boolean
            Select Case RightToLeft
                Case RightToLeft.Yes
                    Return True
                Case RightToLeft.No
                    Return False
                Case Else
                    ' Inherit: Check system's settings
                    Return CultureInfo.CurrentUICulture.TextInfo.IsRightToLeft
            End Select
        End Function

        '-----------------------------------------------------------------------------------------------------------
        ' SaveDirtyDocumentBeforeReset Method
        ' Open a Message Box that asks the user to confirm the restart of the application
        ' with a reversed text appearance. Furthermore, if the document is dirty, the user
        ' can decide how to handle it.
        '
        ' Parameters:
        '      isRightToLeft:  A value indicating the current text appearance
        '
        ' Return value:        If restarting the application with a reversed text appearance should be  
        '                      canceled, the method returns false. Otherwise true.
        '-----------------------------------------------------------------------------------------------------------
        Private Function SaveDirtyDocumentBeforeReset(ByVal isRightToLeft As Boolean) As Boolean
            ' Some parts of the text to display depend on the current text appearance
            Dim strText1 = If(isRightToLeft, My.Resources.MessageBox_SaveDirtyDocumentBeforeRestart_Left, My.Resources.MessageBox_SaveDirtyDocumentBeforeRestart_Right)
            Dim strText2 = If(isRightToLeft, My.Resources.MessageBox_SaveDirtyDocumentBeforeRestart_Right, My.Resources.MessageBox_SaveDirtyDocumentBeforeRestart_Left)

            ' Get the message box text.
            Dim strMessageBoxText = If(m_bIsDirtyDocument, If(m_bIsUnknownDocument, String.Format(My.Resources.MessageBox_SaveDirtyDocumentBeforeRestart_Untitled, strText1, strText2), String.Format(My.Resources.MessageBox_SaveDirtyDocumentBeforeRestart_ToFile, strText1, strText2, m_strActiveDocumentPath)), String.Format(My.Resources.MessageBox_ChangeFormLayout_Text, strText1, strText2))

            ' Show message box.
            Dim bKeepGoing = True
            Dim drSaveFile = MessageBox.Show(Me, strMessageBoxText, My.Resources.MessageBox_ChangeFormLayout_Caption, If(m_bIsDirtyDocument, MessageBoxButtons.YesNoCancel, MessageBoxButtons.OKCancel), MessageBoxIcon.Warning)
            Select Case drSaveFile
                Case DialogResult.Yes
                    ' The dirty document should be saved
                    bKeepGoing = Save(m_strActiveDocumentPath) ' If it was not saved, the appliation won't be restarted with a reversed text appearance.
                Case DialogResult.Cancel
                    ' Cancel restarting the application with a reversed text appearance.
                    bKeepGoing = False
                Case DialogResult.No, DialogResult.OK ' Do not save the dirty document before restarting the application with a reversed text appearance.
                    ' Restarting the application with a reversed text appearance.
            End Select
            Return bKeepGoing
        End Function
    End Class
End Namespace
