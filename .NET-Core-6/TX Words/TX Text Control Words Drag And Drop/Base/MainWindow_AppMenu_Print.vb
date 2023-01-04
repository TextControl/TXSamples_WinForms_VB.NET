'-----------------------------------------------------------------------------------------------------------
' MainWindow_AppMenu_Print.vb File
'
' Description:
'     Manages printing a document
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Imports System.ComponentModel
Imports System.Drawing.Printing

Namespace TXTextControl.Words
    Partial Class MainWindow

        '-----------------------------------------------------------------------------------------------------------
        ' H A N D L E R S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' Print_Click Handler
        ' Invokes the TextControl Print method to open the TextControl print dialog.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Print_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Use the active document name to open the print dialog.
            m_txTextControl.Print(m_strActiveDocumentName)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' PrintQuick_Click Handler
        ' Prints the current document without opening the dialog before.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub PrintQuick_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.Print(New PrintDocument() With {
                .PrinterSettings = New PrinterSettings() With {
                    .FromPage = 1,
                    .ToPage = m_txTextControl.Pages,
                    .Copies = 1,
                    .Collate = True,
                    .PrintFileName = m_strActiveDocumentName
                }
            })
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' PrintPreview_Click Handler
        ' Opens a print preview.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub PrintPreview_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.PrintPreview(m_strActiveDocumentName)
        End Sub

        '------------------------------------------------------------------------------------------------------------
        ' TextControl_PropertyChanged_Print Handler
        ' Update the print button's enabled states.
        '------------------------------------------------------------------------------------------------------------
        Private Sub TextControl_PropertyChanged_Print(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
            Select Case e.PropertyName
                Case "CanPrint"
                    m_rsbtnPrint.Enabled = CSharpImpl.Assign(m_rbtnPrint.Enabled, CSharpImpl.Assign(m_rbtnPrintQuick.Enabled, CSharpImpl.Assign(m_rbtnPrintPreview.Enabled, m_txTextControl.CanPrint)))
            End Select
        End Sub
    End Class
End Namespace
