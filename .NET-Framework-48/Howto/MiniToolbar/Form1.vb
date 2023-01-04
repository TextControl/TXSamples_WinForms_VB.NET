'-----------------------------------------------------------------------------------------------------------
' Form1.vb File
'
' Description:
'		Sample project that is related to the 'Howto: Manipulate the MiniToolbar' article inside
'		the 'Windows Forms User's Guide'.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Public Class Form1
    '-----------------------------------------------------------------------------------------------------------
    ' H A N D L E R S
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' Form1_Load Handler
    ' Load the sample document.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        m_txTextControl.Load("Files\Sample.tx", TXTextControl.StreamType.InternalFormat)
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' TextControl_TextMiniToolbarInitialized Handler
    ' Modify the basic structure of the TextMiniToolbar.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub TextControl_TextMiniToolbarInitialized(ByVal sender As Object, ByVal e As TXTextControl.MiniToolbarInitializedEventArgs) Handles m_txTextControl.TextMiniToolbarInitialized
        ' Ensure that the TextMiniToolbar's table layout group won't be displayed if the input position is inside a table.
        e.MiniToolbar.RibbonGroups.Remove(TryCast(TryCast(e.MiniToolbar, TXTextControl.TextMiniToolbar).FindItem(TXTextControl.TextMiniToolbar.RibbonItem.TXITEM_TableLayoutGroup), TXTextControl.Windows.Forms.Ribbon.RibbonGroup))

        ' Create and add a ribbon group to the TextMiniToolbar that provides an "Edit Hyperlink" button.
        e.MiniToolbar.RibbonGroups.Add(CreateEditHyperlinkGroup())
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' TextControl_MiniToolbarOpening Handler
    ' Update the TextMiniToolbar's content visibility.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub TextControl_MiniToolbarOpening(ByVal sender As Object, ByVal e As TXTextControl.MiniToolbarOpeningEventArgs) Handles m_txTextControl.MiniToolbarOpening
        ' Check whether the opening mini tool bar is of type TextMiniToolbar.
        If TypeOf e.MiniToolbar Is TXTextControl.TextMiniToolbar Then
            e.MiniToolbar.RibbonGroups(1).Visible = True   ' Ensure that the TextMiniToolbar's Styles group is always shown (even if the input position is inside a table).

            ' Ensure that the Styles group's separator and the "Edit Hyperlink" group are displayed if
            ' the current context is TextField and the text field is of type TXTextControl.HypertextLink..
            e.MiniToolbar.RibbonGroups(1).ShowSeperator = CSharpImpl.Assign(e.MiniToolbar.RibbonGroups(2).Visible, (e.MiniToolbarContext And TXTextControl.ContextMenuLocation.TextField) = TXTextControl.ContextMenuLocation.TextField AndAlso m_txTextControl.HypertextLinks.GetItem() IsNot Nothing)
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' EditHyperlink_Click Handler
    ' Opens the TXTextControl HyperlinkDialog.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub EditHyperlink_Click(ByVal sender As Object, ByVal e As EventArgs)
        Call New TXTextControl.HyperlinkDialog(m_txTextControl).ShowDialog(m_txTextControl)
    End Sub


    '-----------------------------------------------------------------------------------------------------------
    ' M E T H O D S
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' CreateEditHyperlinkGroup Method
    ' Creates a RibbonGroup that contains an 'Edit Hyperlink' button.
    '
    ' Returns:   The created RibbonGroup.
    '-----------------------------------------------------------------------------------------------------------
    Private Function CreateEditHyperlinkGroup() As TXTextControl.Windows.Forms.Ribbon.RibbonGroup
        ' Create a ribbon group that contains...
        Dim rgEditHyperlinkGroup As TXTextControl.Windows.Forms.Ribbon.RibbonGroup = New TXTextControl.Windows.Forms.Ribbon.RibbonGroup() With {
            .ShowSeperator = False
        }
        ' ... a button to open the TextControl Edit HyperlinkDialog.
        Dim rbtnEditHyperlink As TXTextControl.Windows.Forms.Ribbon.RibbonButton = New TXTextControl.Windows.Forms.Ribbon.RibbonButton()
        rbtnEditHyperlink.Text = "Edit Hyperlink"
        rbtnEditHyperlink.LargeIcon = TXTextControl.Windows.Forms.ResourceProvider.GetLargeIcon(TXTextControl.Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertHyperlink.ToString(), Me)
        AddHandler rbtnEditHyperlink.Click, AddressOf EditHyperlink_Click

        ' Add the edit hyperlink button to group.
        rgEditHyperlinkGroup.RibbonItems.Add(rbtnEditHyperlink)

        Return rgEditHyperlinkGroup
    End Function


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
