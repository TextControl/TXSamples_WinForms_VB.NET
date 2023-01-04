'-----------------------------------------------------------------------------------------------------------
' MainWindow_QAT.vb File
'
' Description:
'      Creates an undo and a redo button and adds these button plus references to the [current user], Save,  
'      Open, New and Print buttons to the Quick Access Toolbar.
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

        Private m_rbtnUndo, m_rbtnRedo As RibbonButton


        '-----------------------------------------------------------------------------------------------------------
        ' M E T H O D S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' SetQATItemsDesign Method
        ' Creates an undo and a redo button and adds these button plus references to the [current user], Save, Open, 
        ' New and Print buttons to the Quick Access Toolbar.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetQATItemsDesign()
            Me.SetRibbonButtonDesign(ResourceProvider.GeneralItem.TXITEM_Undo.ToString(), CSharpImpl.Assign(m_rbtnUndo, New RibbonButton()))
            Me.SetRibbonButtonDesign(ResourceProvider.GeneralItem.TXITEM_Redo.ToString(), CSharpImpl.Assign(m_rbtnRedo, New RibbonButton()))
            SetQuickAccessToolbarStandardItems(New RibbonButton() {m_rbtnSave, m_rbtnOpen, m_rbtnUndo, m_rbtnRedo, m_rbtnNew, m_rsbtnPrint})
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' SetUndoRedoButtonsBehavior Method
        ' Manages the RibbonButtons that should act like an 'Undo' and a 'Redo' button.
        '-----------------------------------------------------------------------------------------------------------
        Friend Sub SetUndoRedoButtonsBehavior()
            ' Undo
            m_rbtnUndo.Enabled = False
            AddHandler m_rbtnUndo.Click, AddressOf Undo_Click
            AddHandler m_rbtnUndo.ToolTip.Opening, AddressOf Undo_ToolTip_Opening

            ' Redo
            m_rbtnRedo.Enabled = False
            AddHandler m_rbtnRedo.Click, AddressOf Redo_Click
            AddHandler m_rbtnRedo.ToolTip.Opening, AddressOf Redo_ToolTip_Opening

            ' Add handler for button Enable state handling
            AddHandler m_txTextControl.PropertyChanged, AddressOf TextControl_PropertyChanged_UndoRedo
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' H A N D L E R S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' Undo_Click Handler
        ' Invokes the TextControl Undo method to undo the last action.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Undo_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.Undo()
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Undo_ToolTip_Opening Handler
        ' Sets the tool tip of the Undo button when the tool tip is opening. The tool tip shows the undo action
        ' that is performed when the Undo button is clicked.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Undo_ToolTip_Opening(ByVal sender As Object, ByVal e As EventArgs)
            Dim strUndoActionName = m_txTextControl.UndoActionName
            m_rbtnUndo.ToolTip.Description = If(Not String.IsNullOrEmpty(strUndoActionName), strUndoActionName, ResourceProvider.GetToolTipDescription(ResourceProvider.GeneralItem.TXITEM_Undo.ToString()))
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Redo_Click Handler
        ' Invokes the TextControl Redo method to redo the last action.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Redo_Click(ByVal sender As Object, ByVal e As EventArgs)
            m_txTextControl.Redo()
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Redo_ToolTip_Opening Handler
        ' Sets the tool tip of the Redo button when the tool tip is opening. The tool tip shows the redo action
        ' that is performed when the Redo button is clicked.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Redo_ToolTip_Opening(ByVal sender As Object, ByVal e As EventArgs)
            Dim strRedoActionName = m_txTextControl.RedoActionName
            m_rbtnRedo.ToolTip.Description = If(Not String.IsNullOrEmpty(strRedoActionName), strRedoActionName, ResourceProvider.GetToolTipDescription(ResourceProvider.GeneralItem.TXITEM_Redo.ToString()))
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' TextControl_PropertyChanged_UndoRedo Handler
        ' Updates the enabled state of the Undo or Redo button when the TextControl CanUndo or CanRedo 
        ' property value changed.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub TextControl_PropertyChanged_UndoRedo(ByVal sender As Object, ByVal e As ComponentModel.PropertyChangedEventArgs)
            Select Case e.PropertyName
                Case "CanUndo"
                    m_rbtnUndo.Enabled = m_txTextControl.CanUndo
                Case "CanRedo"
                    m_rbtnRedo.Enabled = m_txTextControl.CanRedo
            End Select
        End Sub
    End Class
End Namespace
