'-----------------------------------------------------------------------------------------------------------
' CustomHyperlinkDialog.vb File
'
' Description:
'      A custom dialog to create or edit a hyperlink.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Public Class CustomHyperlinkDialog
    '-----------------------------------------------------------------------------------------------------------
    ' M E M B E R   V A R I A B L E S
    '-----------------------------------------------------------------------------------------------------------
    Private m_hlLink As TXTextControl.HypertextLink
    Private m_txTextControl As TXTextControl.TextControl


    '-----------------------------------------------------------------------------------------------------------
    ' C O N S T R U C T O R
    '-----------------------------------------------------------------------------------------------------------
    Public Sub New(ByVal link As TXTextControl.HypertextLink, ByVal textControl As TXTextControl.TextControl)
        m_hlLink = link
        m_txTextControl = textControl
        InitializeComponent()

    End Sub


    '-----------------------------------------------------------------------------------------------------------
    ' H A N D L E R S
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' CustomHyperlinkDialog_Load Handler
    ' Updates the dialog layout according to the handled hyperlink.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub CustomHyperlinkDialog_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Set the caption of the dialog.
        Text = If(m_hlLink Is Nothing, "Insert Hyperlink", "Edit Hyperlink")

        ' Update the text boxes.
        If m_hlLink IsNot Nothing Then
            ' The dialog is opened to edit a hyperlink:
            ' Insert the text of the hyperlink text and target into the 
            ' corresponding text boxes.
            m_tbxHyperlinkText.Text = m_hlLink.Text
            m_tbxLink.Text = m_hlLink.Target
        Else
            ' The dialog is opened to create a hyperlink:
            ' Insert the text of the current selection into the 'Hyperlink Text' text box.
            Dim selCurrentSelection = m_txTextControl.Selection
            If selCurrentSelection.Length > 0 Then
                m_tbxHyperlinkText.Text = selCurrentSelection.Text
            End If
        End If

        ' Update the enabled state of the 'OK' button.
        m_btnOK.Enabled = IsValidHyperlink()
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' TextBox_TextChanged Handler
    ' Update the enabled state of the 'OK' button when the text of the text boxes changes.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles m_tbxLink.TextChanged, m_tbxHyperlinkText.TextChanged
        m_btnOK.Enabled = IsValidHyperlink()
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' OK_Click Handler
    ' Create or edit a hyperlink when clicking the 'OK' button.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub OK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_btnOK.Click
        If m_hlLink IsNot Nothing Then
            ' The dialog is opened to edit a hyperlink:
            ' Update the text of the hyperlink.
            m_hlLink.Text = m_tbxHyperlinkText.Text
            m_hlLink.Target = m_tbxLink.Text
        Else
            ' The dialog is opened to create a hyperlink:
            ' Create a new hyperlink and insert it into the TextControl.
            m_hlLink = New TXTextControl.HypertextLink(m_tbxHyperlinkText.Text, m_tbxLink.Text)
            m_hlLink.DoubledInputPosition = True
            m_txTextControl.HypertextLinks.Add(m_hlLink)
        End If
    End Sub


    '-----------------------------------------------------------------------------------------------------------
    ' M E T H O D S
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' IsValidHyperlink Method
    ' Returns a value indicating whether both text boxes contain text to create or edit 
    ' a hyperlink.
    '
    ' Returns:		True, if both the 'Hyperlink Text' and 'Link' text box contain text. 
    '				Otherwise false.
    '-----------------------------------------------------------------------------------------------------------
    Private Function IsValidHyperlink() As Boolean
        Return m_tbxHyperlinkText.Text.Trim().Length > 0 AndAlso m_tbxLink.Text.Trim().Length > 0
    End Function
End Class