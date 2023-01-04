'-----------------------------------------------------------------------------------------------------------
' MainWindow_AppMenu_DocumentSettings.vb File
'
' Description:
'     Manages showing/hiding the document settings sidebar.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Imports TXTextControl.Windows.Forms
Imports TXTextControl.Windows.Forms.Ribbon

Namespace TXTextControl.Words
    Partial Class MainWindow

        '-----------------------------------------------------------------------------------------------------------
        ' H A N D L E R S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' DocumentSettings_Handler Handler
        ' Shows and hides the Document Settings sidebar when the checked state of the corresponding button
        ' changed.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub DocumentSettings_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If TryCast(sender, RibbonToggleButton).Checked Then
                ' Set the content layout of the sidebar to DocumentSettings when the button is checked.
                m_sbSidebarLeft.ContentLayout = Sidebar.SidebarContentLayout.DocumentSettings
            End If
            ' Show/hide the sidebar.
            m_sbSidebarLeft.IsShown = TryCast(sender, RibbonToggleButton).Checked
        End Sub
    End Class
End Namespace
