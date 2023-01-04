'-----------------------------------------------------------------------------------------------------------
' DocumentTargetDialog.vb File
'
' Description:
'      A custom dialog to create or edit a document targets.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Public Class DocumentTargetDialog
    '-----------------------------------------------------------------------------------------------------------
    ' E N U M S
    '-----------------------------------------------------------------------------------------------------------
    Friend Enum DialogMode
        Insert
        Edit
    End Enum


    '-----------------------------------------------------------------------------------------------------------
    ' M E M B E R   V A R I A B L E S
    '-----------------------------------------------------------------------------------------------------------
    Private m_dtDocumentTarget As TXTextControl.DocumentTarget
    Private m_txTextControl As TXTextControl.TextControl
    Private m_dmDialogMode As DialogMode


    '-----------------------------------------------------------------------------------------------------------
    ' C O N S T R U C T O R
    '-----------------------------------------------------------------------------------------------------------
    Public Sub New(ByVal documentTarget As TXTextControl.DocumentTarget, ByVal textControl As TXTextControl.TextControl)
        m_dtDocumentTarget = documentTarget
        m_txTextControl = textControl
        InitializeComponent()

        ' Determine the dialog mode.
        m_dmDialogMode = If(m_dtDocumentTarget Is Nothing, DialogMode.Insert, DialogMode.Edit)
    End Sub


    '-----------------------------------------------------------------------------------------------------------
    ' H A N D L E R S
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' DocumentTargetDialog_Load Handler
    ' Updates the dialog layout according to the handled document target.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub DocumentTargetDialog_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Fill the 'Document targets at current input position' list box with all document targets that 
        ' are located at the current input position.
        Dim rdtCurrentDocumentTargets As TXTextControl.DocumentTarget() = m_txTextControl.DocumentTargets.GetItems()
        If rdtCurrentDocumentTargets IsNot Nothing Then
            Dim iCurrentIndex = -1
            For i = 0 To rdtCurrentDocumentTargets.Length - 1
                Dim rdtCurrentDocumentTarget = rdtCurrentDocumentTargets(i)
                m_lbxCurrentDocumentTargets.Items.Add(New DocumentTargetItem(rdtCurrentDocumentTarget))
                ' Determine the index of that item that represents the document target that
                ' should be edited.
                If m_dmDialogMode = DialogMode.Edit AndAlso rdtCurrentDocumentTarget.GetHashCode() = m_dtDocumentTarget.GetHashCode() Then
                    iCurrentIndex = i
                End If
            Next
            ' Select the item that represents the document target that should be edited.
            m_lbxCurrentDocumentTargets.SelectedIndex = iCurrentIndex
        End If

        ' Update the caption of the dialog, the visibility of the change button and the selection
        ' mode of the 'Document targets at current input position' combo box
        Select Case m_dmDialogMode
            Case DialogMode.Insert
                Text = "Insert Document Target"
                m_btnChangeName.Visible = False
                m_lbxCurrentDocumentTargets.SelectionMode = SelectionMode.None
            Case DialogMode.Edit
                Text = "Edit Docoment Targets"
        End Select

        ' Fill the 'Document targets in document' list box with all document targets of the document.
        Dim colDocumentTargets = m_txTextControl.DocumentTargets
        For Each target As TXTextControl.DocumentTarget In colDocumentTargets
            m_lbxAllDocumentTargets.Items.Add(New DocumentTargetItem(target))
        Next

        ' Update the enabled state of the 'OK' and 'Change Name' button.
        m_btnOK.Enabled = CSharpImpl.Assign(m_btnChangeName.Enabled, m_tbxTargetName.Text.Trim().Length > 0)
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' Name_TextChanged Handler
    ' Update the enabled state of the 'OK' and the 'Change Name' button when the text of the 'Target Name' 
    ' text box changed.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub TargetName_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles m_tbxTargetName.TextChanged
        m_btnOK.Enabled = CSharpImpl.Assign(m_btnChangeName.Enabled, m_tbxTargetName.Text.Trim().Length > 0)
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' OK_Click Handler
    ' Create or edit a hyperlink when clicking the 'OK' button.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub OK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_btnOK.Click
        Select Case m_dmDialogMode
            Case DialogMode.Insert
                ' The dialog is opened to create a document target:
                ' Create a new document target and insert it into the TextControl.
                Dim dtDocumentTarget As TXTextControl.DocumentTarget = New TXTextControl.DocumentTarget(m_tbxTargetName.Text)
                dtDocumentTarget.Deleteable = m_chbxCanBeDeleted.Checked
                m_txTextControl.DocumentTargets.Add(dtDocumentTarget)
            Case DialogMode.Edit
                ' The dialog is opened to edit a document target:
                ' Update the TargetName and the Deleteable property values of the document target.
                For Each item As DocumentTargetItem In m_lbxCurrentDocumentTargets.Items
                    item.DocumentTarget.TargetName = item.DisplayedText
                    item.DocumentTarget.Deleteable = item.IsDocumentTargetDeletable
                Next
        End Select
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' CurrentDocumentTargets_SelectedIndexChanged Handler
    ' Update the text of the 'Target Name' text box with the displayed text of the new selected item. Furthermore,
    ' the 'Can be deleted during editing' check box is updated.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub CurrentDocumentTargets_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles m_lbxCurrentDocumentTargets.SelectedIndexChanged
        If m_lbxCurrentDocumentTargets.SelectedIndex <> -1 Then
            Dim dtiSelectedItem As DocumentTargetItem = TryCast(m_lbxCurrentDocumentTargets.SelectedItem, DocumentTargetItem)
            m_tbxTargetName.Text = dtiSelectedItem.DisplayedText
            m_chbxCanBeDeleted.Checked = dtiSelectedItem.IsDocumentTargetDeletable
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' ChangeName_Click Handler
    ' Change the DisplayedText property value of the selected item inside the 'Document targets at current input 
    ' position' list box to the text of the 'Target Name' text box when the 'Change Name' button is clicked.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub ChangeName_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_btnChangeName.Click
        Dim dtiNewItem As DocumentTargetItem = New DocumentTargetItem(TryCast(m_lbxCurrentDocumentTargets.SelectedItem, DocumentTargetItem).DocumentTarget)
        dtiNewItem.DisplayedText = m_tbxTargetName.Text
        m_lbxCurrentDocumentTargets.Items(m_lbxCurrentDocumentTargets.SelectedIndex) = dtiNewItem
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' CanBeDeleted_CheckedChanged Handler
    ' Change the IsDocumentTargetDeletable property value of the selected item inside the 'Document targets at  
    ' current input position' list box to the check state of the 'Can be deleted during editing' check box.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub CanBeDeleted_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles m_chbxCanBeDeleted.CheckedChanged
        If m_lbxCurrentDocumentTargets.SelectedIndex <> -1 Then
            Dim dtiSelectedItem As DocumentTargetItem = TryCast(m_lbxCurrentDocumentTargets.SelectedItem, DocumentTargetItem)
            dtiSelectedItem.IsDocumentTargetDeletable = m_chbxCanBeDeleted.Checked
        End If
    End Sub


    '-----------------------------------------------------------------------------------------------------------
    ' S U P P O R T I N G   C L A S S E S
    '-----------------------------------------------------------------------------------------------------------
    Private Class CSharpImpl
        Shared Function Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Class