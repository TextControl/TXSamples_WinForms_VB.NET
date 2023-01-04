'-----------------------------------------------------------------------------------------------------------
' Form1.vb File
'
' Description:
'      Sample project that is related to the 'Howto: Add charting support to your applications -> Merging 
'		the chart objects with data' article inside the 'Windows Forms User's Guide'.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data

Public Class Form1
    '-----------------------------------------------------------------------------------------------------------
    ' H A N D L E R S
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' 'File' Drop Down
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' New_Click Handler
    ' Deletes the entire contents of a TextControl.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub New_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_tmiNew.Click
        m_txTextControl.ResetContents()
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' Open_Click Handler
    ' Opens a built-in dialog to load a document into the TextControl.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub Open_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_tmiOpen.Click
        m_txTextControl.Load()
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' SampleTemplate_Click Handler
    ' Loads a sample template that contains charts.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub SampleTemplate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_tmiSampleTemplate.Click
        m_txTextControl.Load("Files\SampleTemplate.rtf", TXTextControl.StreamType.RichTextFormat)
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' SaveAs_Click Handler
    ' Opens a built-in dialog to save the document.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub SaveAs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_tmiSaveAs.Click
        m_txTextControl.Save()
    End Sub


    '-----------------------------------------------------------------------------------------------------------
    ' 'Charts' Drop Down
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' Merge_Click Handler
    ' Merge data with chart frames.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub Merge_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_tmiMerge.Click
        ' Check whether the current document contains chart frames.
        Dim colChartFrames = m_txTextControl.Charts
        If colChartFrames.Count = 0 Then
            MessageBox.Show(Me, "To merge data with charts it is necessary to load a template that contains chart frames.", "No Chart Frames detected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Create a new DataSet and load the XML data.
        Dim dsDataSet As DataSet = New DataSet()
        dsDataSet.ReadXml("Files\Data.xml")

        For Each chartFrame As TXTextControl.DataVisualization.ChartFrame In colChartFrames
            ' Check whether the DataSet contains data
            ' related to the chart name.
            If Not dsDataSet.Tables.Contains(chartFrame.Name) Then
                Continue For
            End If

            ' Get the Chart object from the chart frame.
            Dim chChart As Chart = TryCast(chartFrame.Chart, Chart)

            ' Set the x and y values to the first 2 columns of the DataTable.
            chChart.Series(0).XValueMember = dsDataSet.Tables(chartFrame.Name).Columns(0).ColumnName
            chChart.Series(0).YValueMembers = dsDataSet.Tables(chartFrame.Name).Columns(1).ColumnName

            ' Set the data to the chart.
            chChart.DataSource = dsDataSet.Tables(chartFrame.Name)

            ' Data bind to the selected data source.
            chChart.DataBind()

            ' Update the chartFrame to reflect the changes.
            chartFrame.Refresh()
        Next
    End Sub
End Class