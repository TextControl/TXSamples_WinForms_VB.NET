'-----------------------------------------------------------------------------------------------------------
' Form1.vb File
'
' Description:
'   Sample project that is related to the 'Howto: User XML Files -> Editing in XML Mode' article inside
'	the 'Windows Forms User's Guide'.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Public Class Form1
    '-----------------------------------------------------------------------------------------------------------
    ' H A N D L E R S
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' Open_Click Handler
    ' Load an XML file by using the TextControl built-in load dialog.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub Open_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_tmiOpen.Click
        m_txTextControl.Load(TXTextControl.StreamType.XMLFormat)
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' LoadSample_Click Handler
    ' Load the XML 'address_list.xml' file.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub LoadSample_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_tmiSample.Click
        m_txTextControl.Load("Files\address_list.xml", TXTextControl.StreamType.XMLFormat)
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' TextControl_XmlInvalid Handler
    ' Shows a message box with the corresponding information when a loaded or changed XML document cannot be 
    ' validated with the document type definition (DTD) referenced in the document.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub TextControl_XmlInvalid(ByVal sender As Object, ByVal e As TXTextControl.XmlErrorEventArgs) Handles m_txTextControl.XmlInvalid
        MessageBox.Show(Me, e.Reason, "Invalid XML", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
End Class
