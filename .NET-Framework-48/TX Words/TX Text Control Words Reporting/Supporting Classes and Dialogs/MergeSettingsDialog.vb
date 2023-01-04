'-----------------------------------------------------------------------------------------------------------
' MergeSettingsDialog.vb File
'
' Description:
'     Provides a dialog to determine the settings for the following merge process.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------

Namespace TXTextControl.Words
    '-----------------------------------------------------------------------------------------------------------
    ' MergeSettingsDialog Class
    ' Implements a dialog to determine the settings for the following merge process.
    '-----------------------------------------------------------------------------------------------------------
    Partial Public Class MergeSettingsDialog
        Inherits Form
        '-----------------------------------------------------------------------------------------------------------
        ' C O N S T R U C T O R
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' MergeSettingsDialog Constructor
        ' Creates a dialog to determine the settings for the following merge process.
        '-----------------------------------------------------------------------------------------------------------
        Public Sub New()
            InitializeComponent()

            ' Set caption and label texts.
            Text = My.Resources.MergeSettingsDialog_Caption
            m_lblRecords.Text = My.Resources.MergeSettingsDialog_Records
            m_lblNumberOfRecords.Text = My.Resources.MergeSettingsDialog_NumberOfRecords
            m_chbxMergeAllRecords.Text = My.Resources.MergeSettingsDialog_MergeAllRecords
            m_chbxMergeIntoSingleDocument.Text = My.Resources.MergeSettingsDialog_MergeIntoSingleDocument
            m_lblRemoveEmptyMergeElements.Text = My.Resources.MergeSettingsDialog_RemoveEmptyMergeElements
            m_chbxBlocks.Text = My.Resources.MergeSettingsDialog_Blocks
            m_chbxFields.Text = My.Resources.MergeSettingsDialog_Fields
            m_chbxLines.Text = My.Resources.MergeSettingsDialog_Lines
            m_chbxImages.Text = My.Resources.MergeSettingsDialog_Images
            m_chbxTrailingWhitespace.Text = My.Resources.MergeSettingsDialog_TrailingWhitespace
            m_btnOK.Text = My.Resources.MergeSettingsDialog_OK
            m_btnCancel.Text = My.Resources.MergeSettingsDialog_Cancel
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' P R O P E R T I E S 
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' MaxRecords Property
        ' Returns the number of files that should be merged. If the "Merge all records" check box is checked, the
        ' property returns int:MaxValue
        '-----------------------------------------------------------------------------------------------------------
        Friend ReadOnly Property MaxRecords As Integer
            Get
                Return If(m_chbxMergeAllRecords.Checked, Integer.MaxValue, CInt(m_nudNumberOfRecords.Value))
            End Get
        End Property

        '-----------------------------------------------------------------------------------------------------------
        ' MergeIntoSingleFile Property
        ' Returns a value indicating whether all created files should be merged into a single file.
        '-----------------------------------------------------------------------------------------------------------
        Friend ReadOnly Property MergeIntoSingleFile As Boolean
            Get
                Return m_chbxMergeIntoSingleDocument.Checked
            End Get
        End Property

        '-----------------------------------------------------------------------------------------------------------
        ' RemoveEmptyBlocks Property
        ' Returns a value indicating whether or not the content of empty merge blocks should be removed from the
        ' template.
        '-----------------------------------------------------------------------------------------------------------
        Friend ReadOnly Property RemoveEmptyBlocks As Boolean
            Get
                Return m_chbxBlocks.Checked
            End Get
        End Property

        '-----------------------------------------------------------------------------------------------------------
        ' RemoveEmptyFields Property
        ' Returns a value indicating whether or not empty fields should be removed from the template.
        '-----------------------------------------------------------------------------------------------------------
        Friend ReadOnly Property RemoveEmptyFields As Boolean
            Get
                Return m_chbxFields.Checked
            End Get
        End Property

        '-----------------------------------------------------------------------------------------------------------
        ' RemoveEmptyLines Property
        ' Returns a value indicating whether or not text lines which are empty after merging should be removed from
        ' the template.
        '-----------------------------------------------------------------------------------------------------------
        Friend ReadOnly Property RemoveEmptyLines As Boolean
            Get
                Return m_chbxLines.Checked
            End Get
        End Property

        '-----------------------------------------------------------------------------------------------------------
        ' RemoveEmptyImages Property
        ' Returns a value indicating whether or not images which don't have merge data should be removed from the
        ' template.
        '-----------------------------------------------------------------------------------------------------------
        Friend ReadOnly Property RemoveEmptyImages As Boolean
            Get
                Return m_chbxImages.Checked
            End Get
        End Property

        '-----------------------------------------------------------------------------------------------------------
        ' RemoveTrailingWhitespace Property
        ' Returns a value indicating whether trailing whitespace should be removed before saving a document. 
        '-----------------------------------------------------------------------------------------------------------
        Friend ReadOnly Property RemoveTrailingWhitespace As Boolean
            Get
                Return m_chbxTrailingWhitespace.Checked
            End Get
        End Property


        '-----------------------------------------------------------------------------------------------------------
        ' H A N D L E R S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' OK_Click Handler
        ' Closes the dialog with DialogResult.OK when clicked.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub OK_Click(ByVal sender As Object, ByVal e As EventArgs)
            DialogResult = DialogResult.OK
            Close()
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' MergeAllRecords_CheckedChanged Handler
        ' Enables/Disables the "Number of records:" label and numeric up down when the "Merge all records" check box
        ' was checked.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub MergeAllRecords_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            m_lblNumberOfRecords.Enabled = CSharpImpl.Assign(m_nudNumberOfRecords.Enabled, Not m_chbxMergeAllRecords.Checked)
        End Sub

        Private Class CSharpImpl
            Shared Function Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
