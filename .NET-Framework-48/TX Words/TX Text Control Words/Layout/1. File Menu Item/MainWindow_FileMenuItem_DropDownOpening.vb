'-----------------------------------------------------------------------------------------------------------
' MainWindow_FileMenuItem_DropDownOpening.vb File
'
' Description: Provides all DropDownOpening handlers associated with 'File' menu items.
'     
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------

Namespace TXTextControl.Words
    Partial Class MainWindow
        '-----------------------------------------------------------------------------------------------------------
        ' File_DropDownOpening Handler
        '
        ' Updates the enabled state of 'File' drop down menu items.
        ' 
        ' Item: 'File'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub File_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs)
            ' 'Recent Files'
            m_tmiFile_RecentFiles.Enabled = m_colRecentFiles.Count > 0

            ' 'Save'
            m_tmiFile_Save.Enabled = m_bIsDirtyDocument AndAlso Not m_bIsUnknownDocument

            ' 'Print'
            m_tmiFile_Print.Enabled = CSharpImpl.Assign(m_tmiFile_PrintPreview.Enabled, m_txTextControl.CanPrint)
        End Sub
    End Class
End Namespace
