﻿'-----------------------------------------------------------------------------------------------------------
' Form1.vb File
'
' Description:
'      Sample project that is related to the 'Howto: Use Hypertext Links -> Step 1: Inserting a Hypertext 
'	   Link' article inside the 'Windows Forms User's Guide'.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Public Class Form1
    '-----------------------------------------------------------------------------------------------------------
    ' H A N D L E R S
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' InsertHyperlink_Click Handler
    ' Creates an object of type HypertextLink that references to the Text Control Web Site and inserts that
    ' link into the current input position of the TextControl.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub InsertHyperlink_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_btnInsertHyperlink.Click
        Dim hlLink As TXTextControl.HypertextLink = New TXTextControl.HypertextLink("Text Control Web Site", "http://www.textcontrol.com")
        m_txTextControl.HypertextLinks.Add(hlLink)
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' SaveAs_Click Handler
    ' Opens the built-in save dialog to save the document as an HTML file.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub SaveAs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_btnSaveAs.Click
        m_txTextControl.Save(TXTextControl.StreamType.HTMLFormat)
    End Sub
End Class