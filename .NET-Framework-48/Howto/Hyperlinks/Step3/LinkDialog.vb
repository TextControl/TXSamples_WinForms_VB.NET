'-----------------------------------------------------------------------------------------------------------
' LinkDialog.vb File
'
' Description:
'      A custom dialog to create or edit a link.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Public Class LinkDialog
    '-----------------------------------------------------------------------------------------------------------
    ' E N U M S
    '-----------------------------------------------------------------------------------------------------------
    Friend Enum DialogMode
        InsertLink
        EditHyperlink
        EditDocumentLink
    End Enum


    '-----------------------------------------------------------------------------------------------------------
    ' M E M B E R   V A R I A B L E S
    '-----------------------------------------------------------------------------------------------------------
    Private m_dmDialogMode As DialogMode
    Private m_tfLink As TXTextControl.TextField
    Private m_txTextControl As TXTextControl.TextControl


    '-----------------------------------------------------------------------------------------------------------
    ' C O N S T R U C T O R
    '-----------------------------------------------------------------------------------------------------------
    Public Sub New(ByVal link As TXTextControl.TextField, ByVal textControl As TXTextControl.TextControl)
        m_tfLink = link
        m_txTextControl = textControl
        InitializeComponent()

        ' Determine the dialog mode.
        m_dmDialogMode = If(m_tfLink Is Nothing, DialogMode.InsertLink, If(TypeOf m_tfLink Is TXTextControl.HypertextLink, DialogMode.EditHyperlink, DialogMode.EditDocumentLink))
    End Sub


    '-----------------------------------------------------------------------------------------------------------
    ' H A N D L E R S
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' CustomLinkDialog_Load Handler
    ' Updates the dialog layout according to the handled link.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub CustomLinkDialog_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Update the dialog layout considering the set dialog mode.
        Select Case m_dmDialogMode
            Case DialogMode.InsertLink
                m_cmbxDocumentTargets.Visible = False
                Text = "Insert Link"
            Case DialogMode.EditHyperlink
                Text = "Edit Hyperlink"
                m_tlpLinkType.Visible = False
                m_cmbxDocumentTargets.Visible = False
            Case DialogMode.EditDocumentLink
                Text = "Edit Document Link"
                m_tlpLinkType.Visible = False
                m_tbxHyperlink.Visible = False
        End Select

        ' Fill the document targets combo box with references to the document targets
        ' of the document.
        If m_dmDialogMode <> DialogMode.EditHyperlink Then
            Dim colDocumentTargets = m_txTextControl.DocumentTargets
            For Each target As TXTextControl.DocumentTarget In colDocumentTargets
                m_cmbxDocumentTargets.Items.Add(New DocumentTargetItem(target))
            Next
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' Type_CheckedChanged Handler
    ' Update the visibility of the corresponding control when the type radio button checked state changed.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub Type_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles m_tbxHyperlink.TextChanged, m_rbtnTypeHyperlink.CheckedChanged
        If Not m_rbtnTypeHyperlink.Checked Then
            ' The document targets combo box is displayed when the 'Document Link' radio button is toggled.
            m_tbxHyperlink.Visible = False
            m_cmbxDocumentTargets.Visible = True
        Else
            ' The text box is displayed to enter a hyperlink when the 'Hyperlink' radio button is toggled.
            m_cmbxDocumentTargets.Visible = False
            m_tbxHyperlink.Visible = True
        End If

        ' Update the enabled state of the OK button.
        m_btnOK.Enabled = IsValidLink()
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' LinkParameter_Changed Handler
    ' Update the enabled state of the 'OK' button when the text of any text boxes or the selected item of the 
    ' document targets combo box changed.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub LinkParameter_Changed(ByVal sender As Object, ByVal e As EventArgs) Handles m_tbxDisplayedText.TextChanged, m_cmbxDocumentTargets.SelectedIndexChanged
        m_btnOK.Enabled = IsValidLink()
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' OK_Click Handler
    ' Create or edit a link when clicking the 'OK' button.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub OK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_btnOK.Click
        ' Consider the current mode.
        Select Case m_dmDialogMode
            Case DialogMode.InsertLink
                ' The dialog is opened to create a link:
                If m_rbtnTypeHyperlink.Checked Then
                    ' Create a new hyperlink and insert it into the TextControl.
                    Dim hlHypertextLink As TXTextControl.HypertextLink = New TXTextControl.HypertextLink(m_tbxDisplayedText.Text, m_tbxHyperlink.Text)
                    hlHypertextLink.DoubledInputPosition = True
                    m_txTextControl.HypertextLinks.Add(hlHypertextLink)
                Else
                    ' Create a new document link and insert it into the TextControl.
                    Dim dlDocumentLink As TXTextControl.DocumentLink = New TXTextControl.DocumentLink(m_tbxDisplayedText.Text, TryCast(m_cmbxDocumentTargets.SelectedItem, DocumentTargetItem).DocumentTarget)
                    dlDocumentLink.DoubledInputPosition = True
                    m_txTextControl.DocumentLinks.Add(dlDocumentLink)
                End If
            Case DialogMode.EditHyperlink
                ' The dialog is opened to edit a hyperlink:
                ' Update the text of the hyperlink.
                Dim hlHypertextLink As TXTextControl.HypertextLink = TryCast(m_tfLink, TXTextControl.HypertextLink)
                hlHypertextLink.Text = m_tbxDisplayedText.Text
                hlHypertextLink.Target = m_tbxHyperlink.Text
            Case DialogMode.EditDocumentLink
                ' The dialog is opened to edit a document link:
                ' Update the text and the document target of the document link.
                Dim dlDocumentLink As TXTextControl.DocumentLink = TryCast(m_tfLink, TXTextControl.DocumentLink)
                dlDocumentLink.Text = m_tbxDisplayedText.Text
                dlDocumentLink.DocumentTarget = TryCast(m_cmbxDocumentTargets.SelectedItem, DocumentTargetItem).DocumentTarget
        End Select
    End Sub


    '-----------------------------------------------------------------------------------------------------------
    ' M E T H O D S
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' IsValidLink Method
    ' Returns a value indicating whether both the 'Displayed Text' text box contains text and the link specific
    ' control (hyperlink text box or document link combo box) contains a valid value.
    '
    ' Returns:		True, if both the 'Displayed Text' text box contains text and the link specific control 
    '				(hyperlink text box or document link combo box) contains a valid value.
    '				Otherwise false.
    '-----------------------------------------------------------------------------------------------------------
    Private Function IsValidLink() As Boolean
        Return m_tbxDisplayedText.Text.Trim().Length > 0 AndAlso (If(m_cmbxDocumentTargets.Visible, m_cmbxDocumentTargets.SelectedIndex <> -1, m_tbxHyperlink.Text.Trim().Length > 0))
    End Function
End Class