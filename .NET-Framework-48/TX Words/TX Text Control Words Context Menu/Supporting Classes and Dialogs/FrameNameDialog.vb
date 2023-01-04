'-----------------------------------------------------------------------------------------------------------
' FrameNameDialog.vb File
'
' Description:
'     Provides a dialog to to edit the name of a frame.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------

Namespace TXTextControl.Words
    '-----------------------------------------------------------------------------------------------------------
    ' FrameNameDialog Class
    ' A dialog to to edit the name of a frame.
    '-----------------------------------------------------------------------------------------------------------
    Partial Friend Class FrameNameDialog
        Inherits Form

        '-----------------------------------------------------------------------------------------------------------
        ' C O N S T R U C T O R S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' FrameNameDialog Constructor
        ' Opens the dialog to edit the name of a frame.
        '
        ' Parameters:
        '      frameName:   The current name of the frame.
        '-----------------------------------------------------------------------------------------------------------
        Friend Sub New(ByVal frameName As String)
            InitializeComponent()
            m_tbxFrameName.Text = frameName ' Set the text box text.

            ' Update the texts of the controls.
            Text = My.Resources.ContextMenu_FrameNameDialog_Caption
            m_lblFrameName.Text = My.Resources.ContextMenu_FrameNameDialog_Label
            m_btnOK.Text = My.Resources.ContextMenu_FrameNameDialog_OK
            m_btnCancel.Text = My.Resources.ContextMenu_FrameNameDialog_Cancel
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' P R O P E R T I E S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' FrameName Property
        ' Returns the text of the frame name text box.
        '-----------------------------------------------------------------------------------------------------------
        Friend ReadOnly Property FrameName As String
            Get
                Return m_tbxFrameName.Text
            End Get
        End Property
    End Class
End Namespace
