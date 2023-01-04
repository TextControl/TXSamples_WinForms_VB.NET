'-----------------------------------------------------------------------------------------------------------
' MainWindow_TableMenuItem_DropDownOpening.vb File
'
' Description: Provides all DropDownOpening handlers associated with 'Table' menu items.
'     
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------

Namespace TXTextControl.Words
    Partial Class MainWindow
        '-----------------------------------------------------------------------------------------------------------
        ' Table_DropDownOpening Handler
        '
        ' Updates the enabled state of 'Table' drop down menu items.
        ' 
        ' Item: 'Table'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Table_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs)
            ' Get current table states
            Dim tblCurrentTable As Table = m_txTextControl.Tables.GetItem()
            Dim bIsTable As Boolean = tblCurrentTable IsNot Nothing
            Dim bCanTableFormat As Boolean = m_txTextControl.CanTableFormat
            Dim colTableCells As TableCellCollection = If(bIsTable, tblCurrentTable.Cells, Nothing)
            Dim colTableColumns As TableColumnCollection = If(bIsTable, tblCurrentTable.Columns, Nothing)
            Dim colTableRows As TableRowCollection = If(bIsTable, tblCurrentTable.Rows, Nothing)


            ' 'Insert'
            m_tmiTable_Insert.Enabled = bCanTableFormat
            m_tmiTable_Insert_ColumnToTheLeft.Enabled = CSharpImpl.Assign(m_tmiTable_Insert_ColumnToTheRight.Enabled, bCanTableFormat AndAlso bIsTable AndAlso colTableColumns.CanAdd)
            m_tmiTable_Insert_RowAbove.Enabled = CSharpImpl.Assign(m_tmiTable_Insert_RowBelow.Enabled, bCanTableFormat AndAlso bIsTable AndAlso colTableRows.CanAdd)

            ' 'Delete'
            m_tmiTable_Delete.Enabled = CSharpImpl.Assign(m_tmiTable_Delete_Table.Enabled, bCanTableFormat AndAlso bIsTable)
            m_tmiTable_Delete_Cells.Enabled = bCanTableFormat AndAlso bIsTable AndAlso colTableCells.CanRemove
            m_tmiTable_Delete_Columns.Enabled = bCanTableFormat AndAlso bIsTable AndAlso colTableColumns.CanRemove
            m_tmiTable_Delete_Rows.Enabled = bCanTableFormat AndAlso bIsTable AndAlso colTableRows.CanRemove

            ' 'Select'
            m_tmiTable_Select.Enabled = CSharpImpl.Assign(m_tmiTable_Select_Table.Enabled, bCanTableFormat AndAlso bIsTable)
            m_tmiTable_Select_Cell.Enabled = bCanTableFormat AndAlso bIsTable AndAlso colTableCells.GetItem() IsNot Nothing
            m_tmiTable_Select_Column.Enabled = bCanTableFormat AndAlso bIsTable AndAlso colTableColumns.GetItem() IsNot Nothing
            m_tmiTable_Select_Row.Enabled = bCanTableFormat AndAlso bIsTable AndAlso colTableRows.GetItem() IsNot Nothing

            ' 'Merge Cells'
            m_tmiTable_MergeCells.Enabled = bCanTableFormat AndAlso bIsTable AndAlso tblCurrentTable.CanMergeCells

            ' 'Split Cells'
            m_tmiTable_SplitCells.Enabled = bCanTableFormat AndAlso bIsTable AndAlso tblCurrentTable.CanSplitCells

            ' 'Split Table'
            m_tmiTable_SplitTable.Enabled = bCanTableFormat AndAlso bIsTable AndAlso tblCurrentTable.CanSplit

            ' 'Formulas'
            m_tmiTable_Formulas_A1ReferenceStyle.Enabled = CSharpImpl.Assign(m_tmiTable_Formulas_R1C1ReferenceStyle.Enabled, CSharpImpl.Assign(m_tmiTable_Formulas_AutomaticCalculation.Enabled, bCanTableFormat))
            m_tmiTable_Formulas_EditFormula.Enabled = bCanTableFormat AndAlso bIsTable

            ' 'Properties...'
            m_tmiTable_Properties.Enabled = bCanTableFormat AndAlso bIsTable
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' Formulas_DropDownOpening Handler
        '
        ' Updates the checked state of 'Formulas' drop down menu items.
        ' 
        ' Item: 'Formulas'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub Formulas_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs)
            ' Set the check states of the 'Formulas' drop down items.
            Dim frsReferenceStyle As FormulaReferenceStyle = m_txTextControl.FormulaReferenceStyle
            m_tmiTable_Formulas_A1ReferenceStyle.Checked = frsReferenceStyle = FormulaReferenceStyle.A1
            m_tmiTable_Formulas_R1C1ReferenceStyle.Checked = frsReferenceStyle = FormulaReferenceStyle.R1C1
            m_tmiTable_Formulas_AutomaticCalculation.Checked = m_txTextControl.IsFormulaCalculationEnabled
        End Sub
    End Class
End Namespace
