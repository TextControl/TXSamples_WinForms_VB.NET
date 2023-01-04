'-----------------------------------------------------------------------------------------------------------
' DeleteAndGoToTargetDialog.vb File
'
' Description:
'      A custom dialog to delete or navigate to document targets.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Public Class DeleteAndGoToTargetDialog
    Inherits Form
    '-----------------------------------------------------------------------------------------------------------
    ' M E M B E R   V A R I A B L E S
    '-----------------------------------------------------------------------------------------------------------
    Private m_txTextControl As TXTextControl.TextControl
    Private m_lstTagetsToDelete As List(Of TXTextControl.DocumentTarget) = New List(Of TXTextControl.DocumentTarget)()


    '-----------------------------------------------------------------------------------------------------------
    ' C O N S T R U C T O R
    '-----------------------------------------------------------------------------------------------------------
    Public Sub New(ByVal textControl As TXTextControl.TextControl)
        m_txTextControl = textControl
        InitializeComponent()
    End Sub


    '-----------------------------------------------------------------------------------------------------------
    ' H A N D L E R S
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' DeleteAndGoToTargetDialog_Load Handler
    ' Updates the dialog layout.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub DeleteAndGoToTargetDialog_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Fill the 'Document Targets' list box with all document targets of the document.
        Dim colDocumentTargets = m_txTextControl.DocumentTargets
        For Each documentTarget As TXTextControl.DocumentTarget In colDocumentTargets
            m_lbxDocumentTargets.Items.Add(New DocumentTargetItem(documentTarget))
        Next

        ' Select the first item.
        If m_lbxDocumentTargets.Items.Count > 0 Then
            m_lbxDocumentTargets.SelectedIndex = 0
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' DocumentTargets_SelectedIndexChanged Handler
    ' Update the enabled state of the 'Delete' and 'Go To' buttons when the selected index of the 
    ' 'Document Targets' list box changed.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub DocumentTargets_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles m_lbxDocumentTargets.SelectedIndexChanged
        m_btnDelete.Enabled = CSharpImpl.Assign(m_btnGoTo.Enabled, m_lbxDocumentTargets.SelectedIndex <> -1)
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' Delete_Click Handler
    ' Remove the selected item from the 'Document Targets' list box.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub Delete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_btnDelete.Click
        ' Remember the current index.
        Dim iSelectedIndex = m_lbxDocumentTargets.SelectedIndex

        ' Get the current selected item.
        Dim dtiItemToDelete As DocumentTargetItem = TryCast(m_lbxDocumentTargets.SelectedItem, DocumentTargetItem)
        m_lstTagetsToDelete.Add(dtiItemToDelete.DocumentTarget) ' Remember that item.
        m_lbxDocumentTargets.Items.Remove(dtiItemToDelete) ' Remove that item from the 'Document Targets' list box.

        ' Select a new item.
        If m_lbxDocumentTargets.Items.Count > 0 Then
            m_lbxDocumentTargets.SelectedIndex = Math.Max(0, Math.Min(iSelectedIndex, m_lbxDocumentTargets.Items.Count - 1))
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' GoTo_Click Handler
    ' Scroll to the document target that is represented by the selected item inside the 
    ' 'Document Targets' list box.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub GoTo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_btnGoTo.Click
        TryCast(m_lbxDocumentTargets.SelectedItem, DocumentTargetItem).DocumentTarget.ScrollTo()
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' OK_Click Handler
    ' Delete all corresponding document targets that were removed from the 'Document Targets' list box.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub OK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_btnOK.Click
        If m_lstTagetsToDelete.Count > 0 Then
            Dim colDocumentTargets = m_txTextControl.DocumentTargets
            For Each documentTarget In m_lstTagetsToDelete
                colDocumentTargets.Remove(documentTarget)
            Next
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