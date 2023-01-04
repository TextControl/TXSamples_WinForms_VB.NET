﻿'-----------------------------------------------------------------------------------------------------------
' MainWindow_ViewMenuItem_Methods.vb File
'
' Description: Provides supporting methods to implement the desired behavior of some 'View' menu items.
'     
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------

Namespace TXTextControl.Words
    Partial Class MainWindow
        '-----------------------------------------------------------------------------------------------------------
        ' 'Tracked Changes' Item
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' HighlightTrackedChanges Method
        ' Steps through all tracked changes to set the specified highlight mode.
        '
        ' Parameters:
        '      highlightMode:  The highlight mode to set.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetTrackedChangesHighlightMode(ByVal highlightMode As HighlightMode)
            ' Get tracked changes.
            Dim colTrackedChanges As TrackedChangeCollection = m_txTextControl.TrackedChanges
            Dim iCount As Integer = colTrackedChanges.Count
            If iCount > 0 Then
                ' The highlight setting iteration must be handled as one undo action.
                m_txTextControl.BeginUndoAction(If(highlightMode = HighlightMode.Always, My.Resources.Method_SetTrackedChangesHighlightMode_HighlightTrackedChanges, My.Resources.Method_SetTrackedChangesHighlightMode_HideTrackedChanges))
                ' Step through all tracked changes and set the specified highlight mode.
                Dim i As Integer
                For i = 1 To iCount
                    colTrackedChanges(i).HighlightMode = highlightMode
                Next
                ' End undo action.
                m_txTextControl.EndUndoAction()
            End If
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' 'Right to Left Layout' Item
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' LoadRightToLeftSettings Method
        ' Gets the RightToLeft value from the application settings and sets that value as right to left layout.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub LoadRightToLeftSettings()
            RightToLeftLayout = CSharpImpl.Assign(RightToLeft, My.Settings.Default.RightToLeft) = RightToLeft.Yes
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' ReverseAppTextAppearance Method
        ' Restarts the application with a program's view that has a reversed text appearance. Furthermore
        ' the user can save the current document before closing the application if the document is dirty.
        '
        ' Parameters:
        '      isRightToLeft:  A value that indicates whether the application should be restarted with a
        '                      right to left appearance. 
        '-----------------------------------------------------------------------------------------------------------
        Private Sub ReverseAppTextAppearance(ByVal isRightToLeft As Boolean)
            If SaveDirtyDocumentBeforeReset(isRightToLeft) Then
                My.Settings.Default.RightToLeft = If(isRightToLeft, RightToLeft.No, RightToLeft.Yes)
                SaveRecentFiles()
                Call Application.Restart()
            End If
        End Sub

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
            Dim strText1 As String = If(isRightToLeft, My.Resources.MessageBox_SaveDirtyDocumentBeforeRestart_Left, My.Resources.MessageBox_SaveDirtyDocumentBeforeRestart_Right)
            Dim strText2 As String = If(isRightToLeft, My.Resources.MessageBox_SaveDirtyDocumentBeforeRestart_Right, My.Resources.MessageBox_SaveDirtyDocumentBeforeRestart_Left)

            ' Get the message box text.
            Dim strMessageBoxText As String = If(m_bIsDirtyDocument, If(m_bIsUnknownDocument, String.Format(My.Resources.MessageBox_SaveDirtyDocumentBeforeRestart_Untitled, strText1, strText2), String.Format(My.Resources.MessageBox_SaveDirtyDocumentBeforeRestart_ToFile, strText1, strText2, m_strActiveDocumentPath)), String.Format(My.Resources.MessageBox_ChangeFormLayout_Text, strText1, strText2))

            ' Show message box.
            Dim bKeepGoing As Boolean = True
            Dim drSaveFile As DialogResult = MessageBox.Show(Me, strMessageBoxText, My.Resources.MessageBox_ChangeFormLayout_Caption, If(m_bIsDirtyDocument, MessageBoxButtons.YesNoCancel, MessageBoxButtons.OKCancel), MessageBoxIcon.Warning)
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
