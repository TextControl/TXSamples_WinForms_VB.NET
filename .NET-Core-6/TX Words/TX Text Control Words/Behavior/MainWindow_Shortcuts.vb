'-----------------------------------------------------------------------------------------------------------
' MainWindow_Shortcuts.vb File
'
' Description:
'     Handles shortcuts.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------

Namespace TXTextControl.Words
    Partial Class MainWindow

        '-----------------------------------------------------------------------------------------------------------
        ' H A N D L E R S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' TextControl_KeyDown Handler
        ' Implement Shortcuts for the TextControl.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub TextControl_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            Select Case e.KeyCode
                Case Keys.Insert   ' Toggle insertion mode					
                    If e.Control OrElse e.Alt OrElse e.Shift Then
                        Exit Select
                    End If
                    ToggleInsertionMode()

                Case Keys.A        ' Ctrl + A: Select all
                    If Not e.Control OrElse e.Alt OrElse e.Shift Then
                        Exit Select
                    End If
                    m_txTextControl.SelectAll()

                Case Keys.S        ' Ctrl + S: Save
                    If Not e.Control OrElse e.Alt OrElse e.Shift Then
                        Exit Select
                    End If
                    Save(m_strActiveDocumentPath)

                Case Keys.O        ' Ctrl + O: Open
                    If Not e.Control OrElse e.Alt OrElse e.Shift Then
                        Exit Select
                    End If
                    Open()

                Case Keys.F        ' Ctrl + F: Search
                    If Not e.Control OrElse e.Alt OrElse e.Shift Then
                        Exit Select
                    End If
                    m_txTextControl.Find()

                Case Keys.P        ' Ctrl + P: Print
                    If Not e.Control OrElse e.Alt OrElse e.Shift Then
                        Exit Select
                    End If
                    If m_txTextControl.CanPrint Then
                        m_txTextControl.Print(m_strActiveDocumentName)
                    End If
            End Select
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' M E T H O D S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' SetShortcutBehavior Method
        ' Adds all necessary handlers to implement shortcut behavior.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetShortcutBehavior()
            AddHandler m_txTextControl.KeyDown, AddressOf TextControl_KeyDown ' Handles shortcuts
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' ToggleInsertionMode Method
        ' Switch the TextControl's insertion mode between overwrite and insert.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub ToggleInsertionMode()
            m_txTextControl.InsertionMode = If(m_txTextControl.InsertionMode = InsertionMode.Insert, InsertionMode.Overwrite, InsertionMode.Insert)
        End Sub
    End Class
End Namespace
