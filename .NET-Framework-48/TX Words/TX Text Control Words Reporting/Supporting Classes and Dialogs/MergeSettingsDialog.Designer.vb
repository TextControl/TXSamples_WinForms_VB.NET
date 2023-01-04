Namespace TXTextControl.Words
    Partial Class MergeSettingsDialog
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub



        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            m_tlpMainPanel = New System.Windows.Forms.TableLayoutPanel()
            m_tlpRemoveEmptyMergeElementsHeader = New System.Windows.Forms.TableLayoutPanel()
            m_lblRemoveEmptyMergeElements = New System.Windows.Forms.Label()
            m_lblRemoveEmptyMergeElementsSeparator = New System.Windows.Forms.Label()
            m_lblNumberOfRecords = New System.Windows.Forms.Label()
            m_nudNumberOfRecords = New System.Windows.Forms.NumericUpDown()
            m_tlpButtonPanel = New System.Windows.Forms.TableLayoutPanel()
            m_btnCancel = New System.Windows.Forms.Button()
            m_btnOK = New System.Windows.Forms.Button()
            m_chbxMergeIntoSingleDocument = New System.Windows.Forms.CheckBox()
            m_chbxMergeAllRecords = New System.Windows.Forms.CheckBox()
            m_tlpRecordsHeader = New System.Windows.Forms.TableLayoutPanel()
            m_lblRecords = New System.Windows.Forms.Label()
            m_lblRecordsSeparator = New System.Windows.Forms.Label()
            m_tlpRemoveEmptyMergeElements = New System.Windows.Forms.TableLayoutPanel()
            m_chbxTrailingWhitespace = New System.Windows.Forms.CheckBox()
            m_chbxBlocks = New System.Windows.Forms.CheckBox()
            m_chbxFields = New System.Windows.Forms.CheckBox()
            m_chbxImages = New System.Windows.Forms.CheckBox()
            m_chbxLines = New System.Windows.Forms.CheckBox()
            m_tlpMainPanel.SuspendLayout()
            m_tlpRemoveEmptyMergeElementsHeader.SuspendLayout()
            CType(m_nudNumberOfRecords, ComponentModel.ISupportInitialize).BeginInit()
            m_tlpButtonPanel.SuspendLayout()
            m_tlpRecordsHeader.SuspendLayout()
            m_tlpRemoveEmptyMergeElements.SuspendLayout()
            SuspendLayout()
            ' 
            ' m_tlpMainPanel
            ' 
            m_tlpMainPanel.AutoSize = True
            m_tlpMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_tlpMainPanel.ColumnCount = 2
            m_tlpMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            m_tlpMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
            m_tlpMainPanel.Controls.Add(m_tlpRemoveEmptyMergeElementsHeader, 0, 4)
            m_tlpMainPanel.Controls.Add(m_lblNumberOfRecords, 0, 1)
            m_tlpMainPanel.Controls.Add(m_nudNumberOfRecords, 1, 1)
            m_tlpMainPanel.Controls.Add(m_tlpButtonPanel, 0, 6)
            m_tlpMainPanel.Controls.Add(m_chbxMergeIntoSingleDocument, 0, 3)
            m_tlpMainPanel.Controls.Add(m_chbxMergeAllRecords, 0, 2)
            m_tlpMainPanel.Controls.Add(m_tlpRecordsHeader, 0, 0)
            m_tlpMainPanel.Controls.Add(m_tlpRemoveEmptyMergeElements, 0, 5)
            m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            m_tlpMainPanel.Location = New Drawing.Point(8, 6)
            m_tlpMainPanel.Margin = New System.Windows.Forms.Padding(0)
            m_tlpMainPanel.MinimumSize = New Drawing.Size(319, 0)
            m_tlpMainPanel.Name = "m_tlpMainPanel"
            m_tlpMainPanel.RowCount = 7
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
            m_tlpMainPanel.Size = New Drawing.Size(319, 225)
            m_tlpMainPanel.TabIndex = 0
            ' 
            ' m_tlpRemoveEmptyMergeElementsHeader
            ' 
            m_tlpRemoveEmptyMergeElementsHeader.AutoSize = True
            m_tlpRemoveEmptyMergeElementsHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_tlpRemoveEmptyMergeElementsHeader.ColumnCount = 2
            m_tlpMainPanel.SetColumnSpan(m_tlpRemoveEmptyMergeElementsHeader, 2)
            m_tlpRemoveEmptyMergeElementsHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            m_tlpRemoveEmptyMergeElementsHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
            m_tlpRemoveEmptyMergeElementsHeader.Controls.Add(m_lblRemoveEmptyMergeElements, 0, 0)
            m_tlpRemoveEmptyMergeElementsHeader.Controls.Add(m_lblRemoveEmptyMergeElementsSeparator, 1, 0)
            m_tlpRemoveEmptyMergeElementsHeader.Dock = System.Windows.Forms.DockStyle.Top
            m_tlpRemoveEmptyMergeElementsHeader.Location = New Drawing.Point(0, 107)
            m_tlpRemoveEmptyMergeElementsHeader.Margin = New System.Windows.Forms.Padding(0, 15, 0, 0)
            m_tlpRemoveEmptyMergeElementsHeader.Name = "m_tlpRemoveEmptyMergeElementsHeader"
            m_tlpRemoveEmptyMergeElementsHeader.RowCount = 1
            m_tlpRemoveEmptyMergeElementsHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpRemoveEmptyMergeElementsHeader.Size = New Drawing.Size(319, 18)
            m_tlpRemoveEmptyMergeElementsHeader.TabIndex = 8
            ' 
            ' m_lblRemoveEmptyMergeElements
            ' 
            m_lblRemoveEmptyMergeElements.AutoSize = True
            m_lblRemoveEmptyMergeElements.Location = New Drawing.Point(0, 0)
            m_lblRemoveEmptyMergeElements.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
            m_lblRemoveEmptyMergeElements.Name = "m_lblRemoveEmptyMergeElements"
            m_lblRemoveEmptyMergeElements.Size = New Drawing.Size(142, 15)
            m_lblRemoveEmptyMergeElements.TabIndex = 9
            m_lblRemoveEmptyMergeElements.Text = "Remove empty structures"
            ' 
            ' m_lblRemoveEmptyMergeElementsSeparator
            ' 
            m_lblRemoveEmptyMergeElementsSeparator.AutoSize = True
            m_lblRemoveEmptyMergeElementsSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            m_lblRemoveEmptyMergeElementsSeparator.Dock = System.Windows.Forms.DockStyle.Top
            m_lblRemoveEmptyMergeElementsSeparator.Location = New Drawing.Point(145, 5)
            m_lblRemoveEmptyMergeElementsSeparator.Margin = New System.Windows.Forms.Padding(3, 5, 0, 0)
            m_lblRemoveEmptyMergeElementsSeparator.MaximumSize = New Drawing.Size(0, 1)
            m_lblRemoveEmptyMergeElementsSeparator.Name = "m_lblRemoveEmptyMergeElementsSeparator"
            m_lblRemoveEmptyMergeElementsSeparator.Size = New Drawing.Size(174, 1)
            m_lblRemoveEmptyMergeElementsSeparator.TabIndex = 10
            ' 
            ' m_lblNumberOfRecords
            ' 
            m_lblNumberOfRecords.AutoSize = True
            m_lblNumberOfRecords.Dock = System.Windows.Forms.DockStyle.Left
            m_lblNumberOfRecords.Location = New Drawing.Point(0, 18)
            m_lblNumberOfRecords.Margin = New System.Windows.Forms.Padding(0, 0, 11, 0)
            m_lblNumberOfRecords.Name = "m_lblNumberOfRecords"
            m_lblNumberOfRecords.Size = New Drawing.Size(113, 26)
            m_lblNumberOfRecords.TabIndex = 4
            m_lblNumberOfRecords.Text = "&Number of Records:"
            m_lblNumberOfRecords.TextAlign = Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_nudNumberOfRecords
            ' 
            m_nudNumberOfRecords.Dock = System.Windows.Forms.DockStyle.Left
            m_nudNumberOfRecords.Location = New Drawing.Point(124, 21)
            m_nudNumberOfRecords.Margin = New System.Windows.Forms.Padding(0, 3, 1, 0)
            m_nudNumberOfRecords.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
            m_nudNumberOfRecords.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            m_nudNumberOfRecords.Name = "m_nudNumberOfRecords"
            m_nudNumberOfRecords.Size = New Drawing.Size(87, 23)
            m_nudNumberOfRecords.TabIndex = 5
            m_nudNumberOfRecords.Value = New Decimal(New Integer() {2, 0, 0, 0})
            ' 
            ' m_tlpButtonPanel
            ' 
            m_tlpButtonPanel.AutoSize = True
            m_tlpButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_tlpButtonPanel.ColumnCount = 3
            m_tlpMainPanel.SetColumnSpan(m_tlpButtonPanel, 2)
            m_tlpButtonPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
            m_tlpButtonPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            m_tlpButtonPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            m_tlpButtonPanel.Controls.Add(m_btnCancel, 2, 0)
            m_tlpButtonPanel.Controls.Add(m_btnOK, 1, 0)
            m_tlpButtonPanel.Dock = System.Windows.Forms.DockStyle.Top
            m_tlpButtonPanel.Location = New Drawing.Point(0, 195)
            m_tlpButtonPanel.Margin = New System.Windows.Forms.Padding(0)
            m_tlpButtonPanel.Name = "m_tlpButtonPanel"
            m_tlpButtonPanel.RowCount = 1
            m_tlpButtonPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpButtonPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F))
            m_tlpButtonPanel.Size = New Drawing.Size(319, 43)
            m_tlpButtonPanel.TabIndex = 17
            ' 
            ' m_btnCancel
            ' 
            m_btnCancel.AutoSize = True
            m_btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            m_btnCancel.Dock = System.Windows.Forms.DockStyle.Top
            m_btnCancel.Location = New Drawing.Point(244, 15)
            m_btnCancel.Margin = New System.Windows.Forms.Padding(0, 15, 0, 3)
            m_btnCancel.MinimumSize = New Drawing.Size(75, 23)
            m_btnCancel.Name = "m_btnCancel"
            m_btnCancel.Size = New Drawing.Size(75, 25)
            m_btnCancel.TabIndex = 19
            m_btnCancel.Text = "Cancel"
            m_btnCancel.UseVisualStyleBackColor = True
            ' 
            ' m_btnOK
            ' 
            m_btnOK.AutoSize = True
            m_btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
            m_btnOK.Dock = System.Windows.Forms.DockStyle.Top
            m_btnOK.Location = New Drawing.Point(158, 15)
            m_btnOK.Margin = New System.Windows.Forms.Padding(0, 15, 11, 3)
            m_btnOK.MinimumSize = New Drawing.Size(75, 23)
            m_btnOK.Name = "m_btnOK"
            m_btnOK.Size = New Drawing.Size(75, 25)
            m_btnOK.TabIndex = 18
            m_btnOK.Text = "OK"
            m_btnOK.UseVisualStyleBackColor = True
            AddHandler m_btnOK.Click, New EventHandler(AddressOf OK_Click)
            ' 
            ' m_chbxMergeIntoSingleDocument
            ' 
            m_chbxMergeIntoSingleDocument.AutoSize = True
            m_tlpMainPanel.SetColumnSpan(m_chbxMergeIntoSingleDocument, 2)
            m_chbxMergeIntoSingleDocument.Dock = System.Windows.Forms.DockStyle.Top
            m_chbxMergeIntoSingleDocument.Location = New Drawing.Point(3, 73)
            m_chbxMergeIntoSingleDocument.Margin = New System.Windows.Forms.Padding(3, 5, 0, 0)
            m_chbxMergeIntoSingleDocument.Name = "m_chbxMergeIntoSingleDocument"
            m_chbxMergeIntoSingleDocument.Size = New Drawing.Size(316, 19)
            m_chbxMergeIntoSingleDocument.TabIndex = 7
            m_chbxMergeIntoSingleDocument.Text = "&Merge into single document"
            m_chbxMergeIntoSingleDocument.UseVisualStyleBackColor = True
            ' 
            ' m_chbxMergeAllRecords
            ' 
            m_chbxMergeAllRecords.AutoSize = True
            m_chbxMergeAllRecords.Dock = System.Windows.Forms.DockStyle.Top
            m_chbxMergeAllRecords.Location = New Drawing.Point(3, 49)
            m_chbxMergeAllRecords.Margin = New System.Windows.Forms.Padding(3, 5, 0, 0)
            m_chbxMergeAllRecords.Name = "m_chbxMergeAllRecords"
            m_chbxMergeAllRecords.Size = New Drawing.Size(121, 19)
            m_chbxMergeAllRecords.TabIndex = 6
            m_chbxMergeAllRecords.Text = "Merge &all records"
            m_chbxMergeAllRecords.UseVisualStyleBackColor = True
            AddHandler m_chbxMergeAllRecords.CheckedChanged, New EventHandler(AddressOf MergeAllRecords_CheckedChanged)
            ' 
            ' m_tlpRecordsHeader
            ' 
            m_tlpRecordsHeader.AutoSize = True
            m_tlpRecordsHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_tlpRecordsHeader.ColumnCount = 2
            m_tlpMainPanel.SetColumnSpan(m_tlpRecordsHeader, 2)
            m_tlpRecordsHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            m_tlpRecordsHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
            m_tlpRecordsHeader.Controls.Add(m_lblRecords, 0, 0)
            m_tlpRecordsHeader.Controls.Add(m_lblRecordsSeparator, 1, 0)
            m_tlpRecordsHeader.Dock = System.Windows.Forms.DockStyle.Top
            m_tlpRecordsHeader.Location = New Drawing.Point(0, 0)
            m_tlpRecordsHeader.Margin = New System.Windows.Forms.Padding(0)
            m_tlpRecordsHeader.Name = "m_tlpRecordsHeader"
            m_tlpRecordsHeader.RowCount = 1
            m_tlpRecordsHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpRecordsHeader.Size = New Drawing.Size(319, 18)
            m_tlpRecordsHeader.TabIndex = 1
            ' 
            ' m_lblRecords
            ' 
            m_lblRecords.AutoSize = True
            m_lblRecords.Location = New Drawing.Point(0, 0)
            m_lblRecords.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
            m_lblRecords.Name = "m_lblRecords"
            m_lblRecords.Size = New Drawing.Size(49, 15)
            m_lblRecords.TabIndex = 2
            m_lblRecords.Text = "Records"
            ' 
            ' m_lblRecordsSeparator
            ' 
            m_lblRecordsSeparator.AutoSize = True
            m_lblRecordsSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            m_lblRecordsSeparator.Dock = System.Windows.Forms.DockStyle.Top
            m_lblRecordsSeparator.Location = New Drawing.Point(52, 5)
            m_lblRecordsSeparator.Margin = New System.Windows.Forms.Padding(3, 5, 0, 0)
            m_lblRecordsSeparator.MaximumSize = New Drawing.Size(0, 1)
            m_lblRecordsSeparator.Name = "m_lblRecordsSeparator"
            m_lblRecordsSeparator.Size = New Drawing.Size(267, 1)
            m_lblRecordsSeparator.TabIndex = 3
            ' 
            ' m_tlpRemoveEmptyMergeElements
            ' 
            m_tlpRemoveEmptyMergeElements.AutoSize = True
            m_tlpRemoveEmptyMergeElements.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_tlpRemoveEmptyMergeElements.ColumnCount = 2
            m_tlpMainPanel.SetColumnSpan(m_tlpRemoveEmptyMergeElements, 2)
            m_tlpRemoveEmptyMergeElements.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
            m_tlpRemoveEmptyMergeElements.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
            m_tlpRemoveEmptyMergeElements.Controls.Add(m_chbxTrailingWhitespace, 1, 1)
            m_tlpRemoveEmptyMergeElements.Controls.Add(m_chbxBlocks, 0, 0)
            m_tlpRemoveEmptyMergeElements.Controls.Add(m_chbxFields, 0, 1)
            m_tlpRemoveEmptyMergeElements.Controls.Add(m_chbxImages, 1, 0)
            m_tlpRemoveEmptyMergeElements.Controls.Add(m_chbxLines, 0, 2)
            m_tlpRemoveEmptyMergeElements.Dock = System.Windows.Forms.DockStyle.Top
            m_tlpRemoveEmptyMergeElements.Location = New Drawing.Point(3, 128)
            m_tlpRemoveEmptyMergeElements.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
            m_tlpRemoveEmptyMergeElements.Name = "m_tlpRemoveEmptyMergeElements"
            m_tlpRemoveEmptyMergeElements.RowCount = 3
            m_tlpRemoveEmptyMergeElements.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpRemoveEmptyMergeElements.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpRemoveEmptyMergeElements.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpRemoveEmptyMergeElements.Size = New Drawing.Size(316, 67)
            m_tlpRemoveEmptyMergeElements.TabIndex = 11
            ' 
            ' m_chbxTrailingWhitespace
            ' 
            m_chbxTrailingWhitespace.AutoSize = True
            m_chbxTrailingWhitespace.Checked = True
            m_chbxTrailingWhitespace.CheckState = System.Windows.Forms.CheckState.Checked
            m_chbxTrailingWhitespace.Dock = System.Windows.Forms.DockStyle.Top
            m_chbxTrailingWhitespace.Location = New Drawing.Point(158, 24)
            m_chbxTrailingWhitespace.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
            m_chbxTrailingWhitespace.Name = "m_chbxTrailingWhitespace"
            m_chbxTrailingWhitespace.Size = New Drawing.Size(158, 19)
            m_chbxTrailingWhitespace.TabIndex = 16
            m_chbxTrailingWhitespace.Text = "&Trailing Whitespace"
            m_chbxTrailingWhitespace.UseVisualStyleBackColor = True
            ' 
            ' m_chbxBlocks
            ' 
            m_chbxBlocks.AutoSize = True
            m_chbxBlocks.Checked = True
            m_chbxBlocks.CheckState = System.Windows.Forms.CheckState.Checked
            m_chbxBlocks.Dock = System.Windows.Forms.DockStyle.Top
            m_chbxBlocks.Location = New Drawing.Point(0, 0)
            m_chbxBlocks.Margin = New System.Windows.Forms.Padding(0, 0, 11, 0)
            m_chbxBlocks.Name = "m_chbxBlocks"
            m_chbxBlocks.Size = New Drawing.Size(147, 19)
            m_chbxBlocks.TabIndex = 12
            m_chbxBlocks.Text = "&Blocks"
            m_chbxBlocks.UseVisualStyleBackColor = True
            ' 
            ' m_chbxFields
            ' 
            m_chbxFields.AutoSize = True
            m_chbxFields.Checked = True
            m_chbxFields.CheckState = System.Windows.Forms.CheckState.Checked
            m_chbxFields.Dock = System.Windows.Forms.DockStyle.Top
            m_chbxFields.Location = New Drawing.Point(0, 24)
            m_chbxFields.Margin = New System.Windows.Forms.Padding(0, 5, 11, 0)
            m_chbxFields.Name = "m_chbxFields"
            m_chbxFields.Size = New Drawing.Size(147, 19)
            m_chbxFields.TabIndex = 13
            m_chbxFields.Text = "&Fields"
            m_chbxFields.UseVisualStyleBackColor = True
            ' 
            ' m_chbxImages
            ' 
            m_chbxImages.AutoSize = True
            m_chbxImages.Checked = True
            m_chbxImages.CheckState = System.Windows.Forms.CheckState.Checked
            m_chbxImages.Location = New Drawing.Point(158, 0)
            m_chbxImages.Margin = New System.Windows.Forms.Padding(0)
            m_chbxImages.Name = "m_chbxImages"
            m_chbxImages.Size = New Drawing.Size(64, 19)
            m_chbxImages.TabIndex = 15
            m_chbxImages.Text = "&Images"
            m_chbxImages.UseVisualStyleBackColor = True
            ' 
            ' m_chbxLines
            ' 
            m_chbxLines.AutoSize = True
            m_chbxLines.Checked = True
            m_chbxLines.CheckState = System.Windows.Forms.CheckState.Checked
            m_chbxLines.Dock = System.Windows.Forms.DockStyle.Top
            m_chbxLines.Location = New Drawing.Point(0, 48)
            m_chbxLines.Margin = New System.Windows.Forms.Padding(0, 5, 11, 0)
            m_chbxLines.Name = "m_chbxLines"
            m_chbxLines.Size = New Drawing.Size(147, 19)
            m_chbxLines.TabIndex = 14
            m_chbxLines.Text = "&Lines"
            m_chbxLines.UseVisualStyleBackColor = True
            ' 
            ' MergeSettingsDialog
            ' 
            AcceptButton = m_btnOK
            AutoScaleDimensions = New Drawing.SizeF(7F, 15F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            AutoSize = True
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            CancelButton = m_btnCancel
            ClientSize = New Drawing.Size(338, 239)
            Controls.Add(m_tlpMainPanel)
            Font = New Drawing.Font("Segoe UI", 9F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            MaximizeBox = False
            MinimizeBox = False
            Name = "MergeSettingsDialog"
            Padding = New System.Windows.Forms.Padding(8, 6, 11, 8)
            RightToLeftLayout = True
            ShowInTaskbar = False
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Text = "Merge Settings"
            m_tlpMainPanel.ResumeLayout(False)
            m_tlpMainPanel.PerformLayout()
            m_tlpRemoveEmptyMergeElementsHeader.ResumeLayout(False)
            m_tlpRemoveEmptyMergeElementsHeader.PerformLayout()
            CType(m_nudNumberOfRecords, ComponentModel.ISupportInitialize).EndInit()
            m_tlpButtonPanel.ResumeLayout(False)
            m_tlpButtonPanel.PerformLayout()
            m_tlpRecordsHeader.ResumeLayout(False)
            m_tlpRecordsHeader.PerformLayout()
            m_tlpRemoveEmptyMergeElements.ResumeLayout(False)
            m_tlpRemoveEmptyMergeElements.PerformLayout()
            ResumeLayout(False)
            PerformLayout()

        End Sub



        Private m_tlpMainPanel As System.Windows.Forms.TableLayoutPanel
        Private m_lblNumberOfRecords As System.Windows.Forms.Label
        Private m_nudNumberOfRecords As System.Windows.Forms.NumericUpDown
        Private m_tlpButtonPanel As System.Windows.Forms.TableLayoutPanel
        Private m_btnCancel As System.Windows.Forms.Button
        Private m_btnOK As System.Windows.Forms.Button
        Private m_chbxMergeIntoSingleDocument As System.Windows.Forms.CheckBox
        Private m_chbxMergeAllRecords As System.Windows.Forms.CheckBox
        Private m_lblRecords As System.Windows.Forms.Label
        Private m_tlpRemoveEmptyMergeElements As System.Windows.Forms.TableLayoutPanel
        Private m_chbxBlocks As System.Windows.Forms.CheckBox
        Private m_chbxFields As System.Windows.Forms.CheckBox
        Private m_chbxLines As System.Windows.Forms.CheckBox
        Private m_chbxImages As System.Windows.Forms.CheckBox
        Private m_tlpRemoveEmptyMergeElementsHeader As System.Windows.Forms.TableLayoutPanel
        Private m_lblRemoveEmptyMergeElements As System.Windows.Forms.Label
        Private m_lblRemoveEmptyMergeElementsSeparator As System.Windows.Forms.Label
        Private m_tlpRecordsHeader As System.Windows.Forms.TableLayoutPanel
        Private m_lblRecordsSeparator As System.Windows.Forms.Label
        Private m_chbxTrailingWhitespace As System.Windows.Forms.CheckBox
    End Class
End Namespace
