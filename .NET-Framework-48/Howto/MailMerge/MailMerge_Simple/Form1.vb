'-----------------------------------------------------------------------------------------------------------
' Form1.vb File
'
' Description:
'      Sample project that is related to the 'Howto: Mail Merge -> Sample: Simple Mail Merge' 
'	   article inside the 'Windows Forms User's Guide'.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Public Class Form1
    '-----------------------------------------------------------------------------------------------------------
    ' M E M B E R   V A R I A B L E S
    '-----------------------------------------------------------------------------------------------------------
    Private m_dsAddresses As DataSet


    '-----------------------------------------------------------------------------------------------------------
    ' H A N D L E R S
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' Form1_Load Handler
    ' Creates the addresses data set, adds an item for each database field to the 'Add' item drop down and 
    ' loads the 'Instructions.tx' sample template.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Create a new DataSet and load the XML file.
        m_dsAddresses = New DataSet()
        m_dsAddresses.ReadXml("Files\Data.xml")

        ' Create a new ToolStripMenuItem for each database field.
        For Each dataColumn As DataColumn In m_dsAddresses.Tables(0).Columns
            Dim tmiDatabaseFieldItem As ToolStripMenuItem = New ToolStripMenuItem(dataColumn.ColumnName)
            AddHandler tmiDatabaseFieldItem.Click, New EventHandler(AddressOf DatabaseFieldItem_Click)
            m_tmiAdd.DropDown.Items.Add(tmiDatabaseFieldItem)
        Next

        ' Load the 'Instructions.tx' sample template.
        m_txTextControl.Selection.Load("Files\Instructions.tx", TXTextControl.StreamType.InternalUnicodeFormat)
    End Sub


    '-----------------------------------------------------------------------------------------------------------
    ' 'Application Fields' Drop Down
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' ApplicationFields_DropDownOpening Handler
    ' Sets the enabled state of the 'Add' and 'Properties' items when the 'Application Fields' 
    ' drop down is opening.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub ApplicationFields_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs) Handles m_tmiApplicationFields.DropDownOpening
        m_tmiProperties.Enabled = If(m_txTextControl.ApplicationFields.GetItem() Is Nothing, False, True)
        m_tmiAdd.Enabled = m_txTextControl.ApplicationFields.CanAdd
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' DatabaseFieldItem_Click Handler
    ' Creates with the text of the clicked database field item a new TXTextControl.DocumentServer.Fields.MergeField  
    ' and adds it to TextControl.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub DatabaseFieldItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim tmiClickedItem = CType(sender, ToolStripMenuItem)
        InsertMergeField(tmiClickedItem.Text)
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' Properties_Click Handler
    ' Creates with the text of the clicked database field item a new TXTextControl.DocumentServer.Fields.MergeField  
    ' and adds it to TextControl.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub Properties_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_tmiProperties.Click
        Dim mfMergeField As TXTextControl.DocumentServer.Fields.MergeField = New TXTextControl.DocumentServer.Fields.MergeField(m_txTextControl.ApplicationFields.GetItem())
        mfMergeField.ShowDialog(Me)
    End Sub


    '-----------------------------------------------------------------------------------------------------------
    ' 'Mail Merge' Drop Down
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' MailMerge_DropDownOpening Handler
    ' Sets the enabled state of the 'Merge' item when the 'Mail Merge' drop down is opening.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub MailMerge_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs) Handles m_tmiMailMerge.DropDownOpening
        m_tmiMerge.Enabled = m_txTextControl.ApplicationFields.Count > 0
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    ' Merge_Click Handler
    ' Use the MailMerge instance to merge the data into the application fields.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub Merge_Click(ByVal sender As Object, ByVal e As EventArgs) Handles m_tmiMerge.Click
        m_mmMailMerge.Merge(m_dsAddresses.Tables(0), True)
    End Sub


    '-----------------------------------------------------------------------------------------------------------
    ' M E T H O D S
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------------
    ' InsertMergeField Method
    ' Creates with the text of the clicked database field item a new TXTextControl.DocumentServer.Fields.MergeField  
    ' and adds it to TextControl.
    '
    ' Parameters:
    '		name:		The name of the merge field that is created and added to the TextControl.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub InsertMergeField(ByVal name As String)
        ' Create a new TXTextControl.DocumentServer.Fields.MergeField
        ' and add it to TextControl.
        Dim mfMergeField As TXTextControl.DocumentServer.Fields.MergeField = New TXTextControl.DocumentServer.Fields.MergeField()
        mfMergeField.Name = name
        mfMergeField.Text = "{ " & name & " }"
        mfMergeField.ApplicationField.HighlightMode = TXTextControl.HighlightMode.Activated
        mfMergeField.ApplicationField.DoubledInputPosition = True

        m_txTextControl.ApplicationFields.Add(mfMergeField.ApplicationField)
    End Sub
End Class
