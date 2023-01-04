'-----------------------------------------------------------------------------------------------------------
' Form1.vb File
'
' Description:
'      Sample project that is related to the 'Howto: Mail Merge -> Sample: Mail Merge with Nested 
'		Repeating Blocks' article inside the 'Windows Forms User's Guide'.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Imports System.Data
Public Class Form1
    '-----------------------------------------------------------------------------------------------------------
    ' H A N D L E R S
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' Form1_Load Handler
    ' Creates load the 'Accruals Report.docx' template.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Set the image of the 'Create Report' button.
        m_tmiCreateReport.Image = TXTextControl.Windows.Forms.ResourceProvider.GetSmallIcon(TXTextControl.Windows.Forms.ResourceProvider.GeneralItem.TXITEM_NavigateToNext.ToString(), Me)

        ' Load the DOCX template.
        Dim lsLoadSettings As TXTextControl.LoadSettings = New TXTextControl.LoadSettings With {
                .ApplicationFieldFormat = TXTextControl.ApplicationFieldFormat.MSWord,
                .LoadSubTextParts = True
            }
        m_txTextControl.Load("Files\Accruals Report.docx", TXTextControl.StreamType.WordprocessingML, lsLoadSettings)

        ' Do not show table grid lines.
        m_txTextControl.Tables.GridLines = False
    End Sub


    '-----------------------------------------------------------------------------------------------------------
    ' LoadSampleDatasource_Click Handler
    ' Get the reference to the 'Data.xml' sample
    '-----------------------------------------------------------------------------------------------------------
    Private Sub LoadSampleDatasource_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_tmiLoadSampleDatasource.Click
        ' Update the text box.
        m_tbxLoadedDatabaseFile.Tag = "Files\Data.xml"
        m_tbxLoadedDatabaseFile.Text = "Data.xml"
        m_tmiCreateReport.Enabled = True
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' LoadXML_Click Handler
    ' Create and open an OpenFileDialog to get the reference to an XML database.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub LoadXML_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_tmiLoadXML.Click
        ' Create and open an OpenFileDialog to load an XML database.
        Dim dlgLoadXML As OpenFileDialog = New OpenFileDialog()
        dlgLoadXML.Filter = "XML Database | *.xml"
        dlgLoadXML.InitialDirectory = Application.StartupPath

        If dlgLoadXML.ShowDialog(Me) = DialogResult.OK Then
            ' Update the text box.
            m_tbxLoadedDatabaseFile.Tag = dlgLoadXML.FileName
            m_tbxLoadedDatabaseFile.Text = dlgLoadXML.SafeFileName
            m_tmiCreateReport.Enabled = True
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' CreateReport_Click Handler
    ' Merge the template with the data source.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub CreateReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_tmiCreateReport.Click
        Try
            ' Load the XML file.
            Dim dsData As DataSet = New DataSet()
            dsData.ReadXml(TryCast(m_tbxLoadedDatabaseFile.Tag, String), XmlReadMode.Auto)

            ' Add the relations for the main block and its child blocks.
            Dim relCompanyEmployee As DataRelation = New DataRelation("company_employee", dsData.Tables("company").Columns("company_number"), dsData.Tables("employee").Columns("company_number"))

            Dim relEmployeeSick As DataRelation = New DataRelation("employee_sick", dsData.Tables("employee").Columns("employee_number"), dsData.Tables("sick").Columns("employee_number"))

            Dim relEmployeeVacation As DataRelation = New DataRelation("employee_vacation", dsData.Tables("employee").Columns("employee_number"), dsData.Tables("vacation").Columns("employee_number"))

            dsData.Relations.Add(relCompanyEmployee)
            dsData.Relations.Add(relEmployeeSick)
            dsData.Relations.Add(relEmployeeVacation)

            ' Update the progress bar.
            m_pbProgress.Maximum = dsData.Tables("employee").Rows.Count

            ' Merge.
            m_mmMailMerge.Merge(dsData.Tables("company"), True)

            ' Reset the progress bar.
            m_pbProgress.Value = 0
        Catch exc As Exception
            MessageBox.Show(Me, exc.Message)
        End Try
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' MailMerge_BlockRowMerged Handler
    ' Update the progress bar.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub MailMerge_BlockRowMerged(ByVal sender As Object, ByVal e As TXTextControl.DocumentServer.MailMerge.BlockRowMergedEventArgs) Handles m_mmMailMerge.BlockRowMerged
        If e.MergeBlockName = "employee" Then
            m_pbProgress.PerformStep()
        End If
    End Sub
End Class
