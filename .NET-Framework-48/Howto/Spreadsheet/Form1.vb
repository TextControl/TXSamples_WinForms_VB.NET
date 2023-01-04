' -------------------------------------------------------------------------------------------------------------
' Form1.vb File
'
' Description:
'		Sample project that is related to the 'Howto: Use Spreadsheet Formulas in Tables' article inside
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
    ' Set the images of the buttons, loads the sample document and updates the states of some controls that
    ' are related to the TextControl.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'Set the images of the buttons.
        SetImages()

        'Load a sample document.
        m_txTextControl.Load("Files\Cashflow.tx", TXTextControl.StreamType.InternalUnicodeFormat)

        'Add the supported functions and number formats to the UI dropdowns.
        m_cmbxFunctions.Items.AddRange(m_txTextControl.Tables.SupportedFormulaFunctions)
        m_cmbxFormats.Items.AddRange(m_txTextControl.Tables.SupportedNumberFormats)
        m_cmbxFunctions.Text = "SUM"

        'Set default reference style and enable calculation.
        m_btnEnableCalculation.Checked = m_txTextControl.IsFormulaCalculationEnabled
        m_txTextControl.FormulaReferenceStyle = TXTextControl.FormulaReferenceStyle.A1

        'Check the A1 or R1C1 button.
        If m_txTextControl.FormulaReferenceStyle = TXTextControl.FormulaReferenceStyle.A1 Then
            m_btnA1.Checked = True
        Else
            m_btnR1C1.Checked = True
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    'R1C1_Click Handler
    'Determines R1C1 as formula reference style and update the UI.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub R1C1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_btnR1C1.Click
        'Determines R1C1 as formula reference style.
        m_txTextControl.FormulaReferenceStyle = TXTextControl.FormulaReferenceStyle.R1C1

        'Get the current table cell.
        Dim tblCurrentTable As TXTextControl.Table = m_txTextControl.Tables.GetItem()
        If tblCurrentTable IsNot Nothing Then
            Dim tclCurrentTableCell As TXTextControl.TableCell = tblCurrentTable.Cells.GetItem()
            If tclCurrentTableCell IsNot Nothing Then
                'Update the UI.
                UpdateTableCellSettings(tclCurrentTableCell)
            End If
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    'A1_Click Handler
    'Determines A1 as formula reference style and update the UI.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub A1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_btnA1.Click
        'Determines A1 as formula reference style.
        m_txTextControl.FormulaReferenceStyle = TXTextControl.FormulaReferenceStyle.A1

        'Get the current table cell.
        Dim tblCurrentTable As TXTextControl.Table = m_txTextControl.Tables.GetItem()
        If tblCurrentTable IsNot Nothing Then
            Dim tclCurrentTableCell As TXTextControl.TableCell = tblCurrentTable.Cells.GetItem()
            If tclCurrentTableCell IsNot Nothing Then
                'Update the UI.
                UpdateTableCellSettings(tclCurrentTableCell)
            End If
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    'EnableCalculation_Click Handler
    'Set a value indicating whether formulas in tables are automatically calculated when the text of an input 
    'cell is changed.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub EnableCalculation_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_btnEnableCalculation.Click
        m_txTextControl.IsFormulaCalculationEnabled = m_btnEnableCalculation.Checked
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    'AddFunction_Click Handler
    'Add a function to the text box and show a tooltip.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub AddFunction_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_btnAddFunction.Click
        AddFunction(m_cmbxFunctions.Text)
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    'Formula_KeyPress Handler
    'Apply the text of the formula text box as new formula to the current table cell when the Return key is 
    'pressed.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub Formula_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles m_tbxFormula.KeyPress
        If e.KeyChar = Chr(13) Then
            'Check whether the Return key is pressed.
            ApplyFormula()
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    'Formula_TextChanged Handler
    'Hide the tool tip when the text of the formula text box is changed.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub Formula_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles m_tbxFormula.TextChanged
        m_ttInfo.Hide(Me)
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    'Accept_Click Handler
    'Apply a formula to the cell.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub Accept_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_btnAccept.Click
        ApplyFormula()
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    'Remove_Click Handler
    'Remove the formula from the current table cell and update the UI.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub Remove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_btnRemove.Click
        'Get the current table cell.
        Dim tblCurrentTable As TXTextControl.Table = m_txTextControl.Tables.GetItem()
        If tblCurrentTable IsNot Nothing Then
            Dim tclCurrentTableCell As TXTextControl.TableCell = tblCurrentTable.Cells.GetItem()
            If tclCurrentTableCell IsNot Nothing Then
                'Remove the formula from the table cell.
                tclCurrentTableCell.Formula = ""
                'Update the UI.
                UpdateTableCellSettings(tclCurrentTableCell)
            End If
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    'TextFormat_Click Handler
    'Determine that the cell's text is interpreted as text.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub TextFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_btnTextFormat.Click
        SetCellFormat(TXTextControl.TextType.Standard)
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    'NumberFormat_Click Handler
    'Determine that the cell's text is interpreted as a number.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub NumberFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_btnNumberFormat.Click
        SetCellFormat(TXTextControl.TextType.Number)
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    'ApplyNumberFormat_Click Handler
    'Set the number format for the table cell.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub ApplyNumberFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_btnApplyNumberFormat.Click
        'Get the current table cell.
        Dim tblCurrentTable As TXTextControl.Table = m_txTextControl.Tables.GetItem()
        If tblCurrentTable IsNot Nothing Then
            Dim tclCurrentTableCell As TXTextControl.TableCell = tblCurrentTable.Cells.GetItem()
            If tclCurrentTableCell IsNot Nothing Then
                'Set the number format for the table cell.
                tclCurrentTableCell.CellFormat.NumberFormat = m_cmbxFormats.Text
            End If
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    'TextControl_InputPositionChanged Handler
    'Enable formula UI when input position is inside a table and a single cell is selected or active
    '-----------------------------------------------------------------------------------------------------------
    Private Sub TextControl_InputPositionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles m_txTextControl.InputPositionChanged
        'Check whether the current input position is located inside a table.
        Dim tblCurrentTable As TXTextControl.Table = m_txTextControl.Tables.GetItem()
        If tblCurrentTable Is Nothing Then
            m_tsFormula.Enabled = False
            Return
        Else
            'Get the current table cell.
            Dim tclCurrenTableCell As TXTextControl.TableCell = tblCurrentTable.Cells.GetItem()
            If tclCurrenTableCell IsNot Nothing Then
                m_tsFormula.Enabled = True
                UpdateTableCellSettings(tclCurrenTableCell)
            Else
                m_tsFormula.Enabled = False
            End If
        End If
    End Sub


    '-----------------------------------------------------------------------------------------------------------
    'M E T H O D S
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' SetImages Method
    ' Sets the images of the buttons.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub SetImages()
        'm_m_tsFormulaSettings:
        m_btnR1C1.Image = TXTextControl.Windows.Forms.ResourceProvider.GetSmallIcon(TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_EnableR1C1Style.ToString(), Me)
        m_btnA1.Image = TXTextControl.Windows.Forms.ResourceProvider.GetSmallIcon(TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_EnableA1Style.ToString(), Me)
        m_btnEnableCalculation.Image = TXTextControl.Windows.Forms.ResourceProvider.GetSmallIcon(TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_EnableFormulaCalculation.ToString(), Me)

        'm_m_tsFormula:
        m_btnAddFunction.Image = TXTextControl.Windows.Forms.ResourceProvider.GetSmallIcon(TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_AddFunction.ToString(), Me)
        m_btnAccept.Image = TXTextControl.Windows.Forms.ResourceProvider.GetSmallIcon(TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_AcceptFormula.ToString(), Me)
        m_btnRemove.Image = TXTextControl.Windows.Forms.ResourceProvider.GetSmallIcon(TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_CancelFormulaEditing.ToString(), Me)
        m_btnTextFormat.Image = TXTextControl.Windows.Forms.ResourceProvider.GetSmallIcon(TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_TableCellTextTypeText.ToString(), Me)
        m_btnNumberFormat.Image = TXTextControl.Windows.Forms.ResourceProvider.GetSmallIcon(TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_TableCellTextTypeNumber.ToString(), Me)
        m_btnApplyNumberFormat.Image = TXTextControl.Windows.Forms.ResourceProvider.GetSmallIcon(TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_AcceptFormula.ToString(), Me)
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' AddFunction Method
    ' Add a function to the text box and show a tooltip.
    ' Parameters:
    '		function	The function to add.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub AddFunction(ByVal [function] As String)
        'Add the specified function to the text box.
        m_tbxFormula.Text = [function] & "()"
        m_tbxFormula.Select([function].Length + 1, 0)
        m_tbxFormula.Focus()

        'Show the tooltip.
        m_ttInfo.Show("Specify the cell range for the formula calculation." & Environment.NewLine & Environment.NewLine & "For example:" & Environment.NewLine & "SUM(A1:A5)" & Environment.NewLine & "This would calculate the sum for the cell range A1 to A5.", Me, m_tsFormula.Items("m_tbxFormula").Bounds.X, m_tsFormula.Bounds.Y - 100)
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' ApplyFormula Method
    ' Apply a formula to the current table cell.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub ApplyFormula()
        Try
            'Get the current table cell.
            Dim tblCurrentTable As TXTextControl.Table = m_txTextControl.Tables.GetItem()
            If tblCurrentTable IsNot Nothing Then
                Dim tclCurrentTableCell As TXTextControl.TableCell = tblCurrentTable.Cells.GetItem()
                If tclCurrentTableCell IsNot Nothing Then
                    'Apply a formula to the current table cell.
                    tclCurrentTableCell.Formula = m_tbxFormula.Text
                End If
            End If
        Catch exc As Exception
            'Let TXTextControl do the validation.
            MessageBox.Show(exc.Message, "Formula Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' UpdateTableCellSettings Method
    ' Updates the UI based on the specified cell settings.
    ' Parameters:
    '		tableCell	The table cell.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub UpdateTableCellSettings(ByVal tableCell As TXTextControl.TableCell)
        If tableCell IsNot Nothing Then
            'Read the current formula.
            m_tbxFormula.Text = tableCell.Formula

            'Set the check state of the reference style.
            Select Case m_txTextControl.FormulaReferenceStyle
                Case TXTextControl.FormulaReferenceStyle.A1
                    m_btnA1.Checked = True
                    m_btnR1C1.Checked = False
                Case TXTextControl.FormulaReferenceStyle.R1C1
                    m_btnA1.Checked = False
                    m_btnR1C1.Checked = True
            End Select

            'Set the check state of the cell format.
            Select Case tableCell.CellFormat.TextType
                Case TXTextControl.TextType.Standard
                    m_btnTextFormat.Checked = True
                    m_btnNumberFormat.Checked = False
                    m_cmbxFormats.Enabled = False
                    m_btnApplyNumberFormat.Enabled = False
                    m_cmbxFormats.Text = ""
                Case TXTextControl.TextType.Number
                    m_btnTextFormat.Checked = False
                    m_btnNumberFormat.Checked = True
                    m_cmbxFormats.Enabled = True
                    m_btnApplyNumberFormat.Enabled = True
                    m_cmbxFormats.Text = tableCell.CellFormat.NumberFormat
            End Select
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' SetCellFormat Method
    ' Determine that the cell's text is interpreted as text or as a number.
    ' Parameters:
    '		textType	The value how the cell's text is interpreted.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub SetCellFormat(ByVal textType As TXTextControl.TextType)
        'Get the current table cell.
        Dim tblCurrentTable As TXTextControl.Table = m_txTextControl.Tables.GetItem()
        If tblCurrentTable IsNot Nothing Then
            Dim tclCurrentTableCell As TXTextControl.TableCell = tblCurrentTable.Cells.GetItem()
            If tclCurrentTableCell IsNot Nothing Then
                'Determine how the cell's text is interpreted.
                tclCurrentTableCell.CellFormat.TextType = textType
                'Update the UI.
                UpdateTableCellSettings(tclCurrentTableCell)
            End If
        End If
    End Sub
End Class
