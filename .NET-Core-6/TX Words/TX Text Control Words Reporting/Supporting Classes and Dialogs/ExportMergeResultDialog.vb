'-----------------------------------------------------------------------------------------------------------
' ExportMergeResultDialog.vb File
'
' Description:
'     Provides a dialog to export the results of the merge process.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Imports System.IO

Namespace TXTextControl.Words
    Partial Public Class ExportMergeResultDialog
        Inherits Form
        '----------------------------------------------------------------------------------------------
        ' Class FormatItem
        ' Represents the 'Format' combo box item. It provides the displayed text, the format extension
        ' and the TXTextControl.StreamType to use.
        '----------------------------------------------------------------------------------------------
        Friend Class FormatItem
            ' Member Variables
            Private m_strFormat As String
            Private m_strExtension As String
            Private m_stStreamType As StreamType

            ' Constructor
            Friend Sub New(ByVal displayedText As String, ByVal extension As String, ByVal streamType As StreamType)
                m_strFormat = displayedText
                m_strExtension = extension
                m_stStreamType = streamType
            End Sub

            ' Properties
            Friend ReadOnly Property Extension As String
                Get
                    Return m_strExtension
                End Get
            End Property

            Friend ReadOnly Property StreamType As StreamType
                Get
                    Return m_stStreamType
                End Get
            End Property

            ' Overridden Methods.
            Public Overrides Function ToString() As String
                Return String.Format(m_strFormat, m_strExtension)
            End Function
        End Class


        '----------------------------------------------------------------------------------------------
        ' C O N S T R U C T O R
        '----------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' ExportMergeResultDialog Constructor
        ' Creates a dialog to export the results of the merge process.
        '-----------------------------------------------------------------------------------------------------------
        Public Sub New()
            InitializeComponent()

            ' Set caption and label texts.
            Text = My.Resources.ExportMergeResultDialog_Caption
            m_lblFilePrefix.Text = My.Resources.ExportMergeResultDialog_FilePrefix
            m_lblDirectory.Text = My.Resources.ExportMergeResultDialog_Directory
            m_lblFormat.Text = My.Resources.ExportMergeResultDialog_Format
            m_btnOK.Text = My.Resources.ExportMergeResultDialog_OK
            m_btnCancel.Text = My.Resources.ExportMergeResultDialog_Cancel
            m_chbxopenDirectory.Text = My.Resources.ExportMergeResultDialog_openDirectory

            ' Add format items.
            m_cmbxFormat.Items.AddRange(New FormatItem() {New FormatItem(My.Resources.ExportMergeResultDialog_Format_RTF, ".rtf", StreamType.RichTextFormat), New FormatItem(My.Resources.ExportMergeResultDialog_Format_HTML, ".html", StreamType.HTMLFormat), New FormatItem(My.Resources.ExportMergeResultDialog_Format_DOCX, ".docx", StreamType.SpreadsheetML), New FormatItem(My.Resources.ExportMergeResultDialog_Format_DOC, ".doc", StreamType.MSWord), New FormatItem(My.Resources.ExportMergeResultDialog_Format_PDF, ".pdf", StreamType.AdobePDFA), New FormatItem(My.Resources.ExportMergeResultDialog_Format_TXT, ".txt", StreamType.PlainText), New FormatItem(My.Resources.ExportMergeResultDialog_Format_TX, ".tx", StreamType.InternalFormat)})

            ' Select the PDF item.
            m_cmbxFormat.SelectedIndex = 4
        End Sub


        '----------------------------------------------------------------------------------------------
        ' P R O P E R T I E S
        '----------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' Directory Property
        ' Gets or sets the directoy where to export the created files of the merge process. 
        '-----------------------------------------------------------------------------------------------------------
        Friend Property Directory As String
            Get
                Return m_tbxDirectory.Text.Trim()
            End Get
            Set(ByVal value As String)
                m_tbxDirectory.Text = value
            End Set
        End Property

        '-----------------------------------------------------------------------------------------------------------
        ' FilePrefix Property
        ' Gets or sets the prefix string that is used when exporting the created files of the merge process.
        '-----------------------------------------------------------------------------------------------------------
        Friend Property FilePrefix As String
            Get
                Return m_tbxFilePrefix.Text.Trim()
            End Get
            Set(ByVal value As String)
                m_tbxFilePrefix.Text = Path.GetFileNameWithoutExtension(value)
            End Set
        End Property

        '-----------------------------------------------------------------------------------------------------------
        ' Format Property
        ' Gets the document format that is used when exporting the created files of the merge process.
        '-----------------------------------------------------------------------------------------------------------
        Friend ReadOnly Property Format As FormatItem
            Get
                Return TryCast(m_cmbxFormat.SelectedItem, FormatItem)
            End Get
        End Property

        '-----------------------------------------------------------------------------------------------------------
        ' openDirectory Property
        ' Gets a value indicating whether the directory where the merged files are exported should be openeded.
        '-----------------------------------------------------------------------------------------------------------
        Friend ReadOnly Property openDirectory As Boolean
            Get
                Return m_chbxopenDirectory.Checked
            End Get
        End Property


        '----------------------------------------------------------------------------------------------
        ' H A N D L E R S
        '----------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' OpenFolderBrowser_Click Handler
        ' Opens the folder browser dialog to determine the directory where to export the created files of the merge 
        ' process. 
        '-----------------------------------------------------------------------------------------------------------
        Private Sub OpenFolderBrowser_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgFolderBrowser As FolderBrowserDialog = New FolderBrowserDialog()
            ' Sets the current directory path as selected path.
            If IO.Directory.Exists(Directory) Then
                dlgFolderBrowser.SelectedPath = Directory
            End If

            ' Update the directory text box if a path is selected by the folder browser dialog.
            If dlgFolderBrowser.ShowDialog() = DialogResult.OK Then
                m_tbxDirectory.Text = dlgFolderBrowser.SelectedPath
            End If
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Directory_TextChanged Handler
        ' Handles the enabled state of the OK button.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Directory_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            m_btnOK.Enabled = Directory.Length > 0
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' OK_Click Handler
        ' If the specified directory path exists, close the dialog.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub OK_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not IO.Directory.Exists(Directory) Then
                MessageBox.Show(My.Resources.MessageBox_ExportMergeResultDialog_DirectoryDoesNotExist_Text, My.Resources.MessageBox_ExportMergeResultDialog_DirectoryDoesNotExist_Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                DialogResult = DialogResult.OK
                Close()
            End If
        End Sub
    End Class
End Namespace
