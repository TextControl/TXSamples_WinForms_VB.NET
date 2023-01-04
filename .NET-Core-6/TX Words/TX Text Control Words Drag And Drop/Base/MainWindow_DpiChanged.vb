'-----------------------------------------------------------------------------------------------------------
' MainWindow_DpiChanged.vb File
'
' Description:
'     Handles custom image updating when the application resolution changed.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Imports TXTextControl.Windows.Forms
Imports TXTextControl.Windows.Forms.Ribbon

Namespace TXTextControl.Words
    Partial Class MainWindow

        '-----------------------------------------------------------------------------------------------------------
        ' M E M B E R   V A R I A B L E S
        '-----------------------------------------------------------------------------------------------------------

        Private ReadOnly m_lstCustomRibbonButtons As List(Of RibbonButton) = New List(Of RibbonButton)()
        Private m_fDPI As Single = 0


        '-----------------------------------------------------------------------------------------------------------
        ' O V E R R I D D E N   M E T H O D S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' WndProc Method (overridden)
        ' Overridden to get the DPI value when the window is created and to update the icons of the custom 
        ' ribbon buttons and groups when the dpi value changed.
        '
        ' Parameters:
        '      WndProc:   The Windows Message to process.
        '-----------------------------------------------------------------------------------------------------------
        Protected Overrides Sub WndProc(ByRef m As Message)
            Select Case m.Msg
                Case &H1 ' WM_CREATE
                    ' Get the DPI value from the created handle.
                    Using g = Graphics.FromHwnd(Handle)
                        m_fDPI = g.DpiX
                    End Using
                Case &H2E0 ' WM_DPICHANGED
                    ' Get the new DPI value when the dpi value changed.
                    Dim iNewDPI = CInt(m.WParam) And &HFFFF
                    If m_fDPI <> CSharpImpl.Assign(m_fDPI, iNewDPI) Then
                        ' Step through those custom ribbon buttons that show an image that is provided
                        ' by the TXTextControl.ResourceProvider
                        For Each customButton In m_lstCustomRibbonButtons
                            customButton.SmallIcon = ResourceProvider.GetSmallIcon(customButton.Name, m_fDPI)
                            customButton.LargeIcon = ResourceProvider.GetLargeIcon(customButton.Name, m_fDPI)
                        Next
                    End If
            End Select
            MyBase.WndProc(m)
        End Sub
    End Class
End Namespace
