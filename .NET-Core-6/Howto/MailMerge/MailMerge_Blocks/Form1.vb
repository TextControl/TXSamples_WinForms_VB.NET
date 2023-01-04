'-----------------------------------------------------------------------------------------------------------
' Form1.vb File
'
' Description:
'      Sample project that is related to the 'Howto: Mail Merge -> Sample: Mail Merge with Repeating Blocks' 
'		article inside the 'Windows Forms User's Guide'.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Imports System.Data
Public Class Form1
    Inherits Form
    '-----------------------------------------------------------------------------------------------------------
    ' M E M B E R   V A R I A B L E S
    '-----------------------------------------------------------------------------------------------------------
    Private m_dsData As DataSet


    '-----------------------------------------------------------------------------------------------------------
    ' H A N D L E R S
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' Form1_Load Handler
    ' Creates a new data set and loads the 'Template.docx' template.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Create a new data set and load the XML file
        m_dsData = New DataSet()
        m_dsData.ReadXml("Files\Data.xml")

        Dim lsLoadSettings As TXTextControl.LoadSettings = New TXTextControl.LoadSettings With {
                .ApplicationFieldFormat = TXTextControl.ApplicationFieldFormat.MSWord,
                .LoadSubTextParts = True
            }

        ' Load the 'Template.docx' template
        m_txTextControl.Load("Files\Template.docx", TXTextControl.StreamType.WordprocessingML, lsLoadSettings)
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' Merge_Click Handler
    ' Use the MailMerge instance to merge the data.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub Merge_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_tmiMerge.Click
        m_mmMailMerge.Merge(m_dsData.Tables("orders"), True)
    End Sub
End Class
