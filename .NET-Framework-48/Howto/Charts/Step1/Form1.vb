'-----------------------------------------------------------------------------------------------------------
' Form1.vb File
'
' Description:
'      Sample project that is related to the 'Howto: Add charting support to your applications -> Creating 
'	   a template that contains chart objects' article inside the 'Windows Forms User's Guide'.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    '-----------------------------------------------------------------------------------------------------------
    ' M E M B E R   V A R I A B L E S
    '-----------------------------------------------------------------------------------------------------------
    Private m_dtData As DataTable = New DataTable()
    Private m_cfCurrentChart As TXTextControl.DataVisualization.ChartFrame
    '-----------------------------------------------------------------------------------------------------------
    ' H A N D L E R S
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' Form1_Load Handler
    ' Creates the default data table.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Add default data points for demo purposes.
        m_dtData.Columns.Add("Country")
        m_dtData.Columns.Add("Value")

        m_dtData.Rows.Add(New Object() {"United States", 700})
        m_dtData.Rows.Add(New Object() {"Europe", 600})
        m_dtData.Rows.Add(New Object() {"Asia", 800})
        m_dtData.Rows.Add(New Object() {"Africa", 400})
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' 'File' Drop Down
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' New_Click Handler
    ' Deletes the entire contents of a Text Control.
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
    ' SaveAs_Click Handler
    ' Opens a built-in dialog to save the document.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub SaveAs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_tmiSaveAs.Click
        m_txTextControl.Save()
    End Sub


    '-----------------------------------------------------------------------------------------------------------
    ' 'Insert' Drop Down
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' Chart_Click Handler
    ' Creates a new chart frame and adds it into the TextControl.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub Chart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_tmiChart.Click
        ' Create an object of type System.Windows.Forms.DataVisualization.Charting.Chart,
        Dim chChart As Chart = New Chart()

        ' Add a series and a chart area.
        chChart.Series.Add("series1")
        chChart.ChartAreas.Add("area1")

        ' Set the data source.
        chChart.DataSource = m_dtData

        ' Set series members names for the X and Y values.
        chChart.Series(0).XValueMember = "Country"
        chChart.Series(0).YValueMembers = "Value"

        ' Data bind to the selected data source.
        chChart.DataBind()

        ' Create new ChartFrame.
        Dim chartFrame As TXTextControl.DataVisualization.ChartFrame = New TXTextControl.DataVisualization.ChartFrame(chChart)
        chartFrame.Name = "points"

        ' Add it to the TextControl.
        m_txTextControl.Charts.Add(chartFrame, -1)
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' TextControl_ChartSelected Handler
    ' Sets the current chart frame and updates the chart panel controls.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub TextControl_ChartSelected(ByVal sender As Object, ByVal e As TXTextControl.DataVisualization.ChartEventArgs) Handles m_txTextControl.ChartSelected
        ' Set the current chart frame.
        m_cfCurrentChart = e.ChartFrame

        ' Update chart name text box and chart property grid.
        m_tbxChartName.Text = m_cfCurrentChart.Name
        m_pgChartProperties.SelectedObject = m_cfCurrentChart.Chart

        ' Enable the chart panel.
        m_tlpChartPanel.Enabled = True
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' TextControl_ChartDeselected Handler
    ' Sets the current chart frame to null and resets the chart panel controls.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub TextControl_ChartDeselected(ByVal sender As Object, ByVal e As TXTextControl.DataVisualization.ChartEventArgs) Handles m_txTextControl.ChartDeselected
        ' Set the current chart frame to null.
        m_cfCurrentChart = Nothing

        ' Reset chart name text box and chart property grid.
        m_tbxChartName.Text = ""
        m_pgChartProperties.SelectedObject = Nothing

        ' Disable the chart panel.
        m_tlpChartPanel.Enabled = False
    End Sub


    '-----------------------------------------------------------------------------------------------------------
    ' Chart panel
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' ChartName_TextChanged Handler
    ' Updates the enabled state of the 'Apply Chart Name' button when the chart name text box text is changed.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub ChartName_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles m_tbxChartName.TextChanged
        m_btnApplyChartName.Enabled = m_tbxChartName.Text.Trim().Length > 0
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' ApplyChartName_Click Handler
    ' Updates the chart name with the text of the chart name text box.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub ApplyChartName_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_btnApplyChartName.Click
        SetChartName()
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' ChartName_KeyUp Handler
    ' Updates the chart name with the text of the chart name text box when the Enter key is pressed.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub ChartName_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles m_tbxChartName.KeyUp
        If e.KeyCode = Keys.Enter Then
            SetChartName()
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' ChartProperties_PropertyValueChanged Handler
    ' Refreshes the current chart frame layout when a property of the chart property grid is changed.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub ChartProperties_PropertyValueChanged(ByVal s As Object, ByVal e As PropertyValueChangedEventArgs) Handles m_pgChartProperties.PropertyValueChanged
        m_cfCurrentChart.Refresh()
    End Sub


    '-----------------------------------------------------------------------------------------------------------
    ' M E T H O D S
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' SetChartName Method
    ' Updates the chart name with the text of the chart name text box.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub SetChartName()
        If m_btnApplyChartName.Enabled Then
            m_cfCurrentChart.Name = m_tbxChartName.Text.Trim()
            m_txTextControl.Focus()
        End If
    End Sub
End Class
