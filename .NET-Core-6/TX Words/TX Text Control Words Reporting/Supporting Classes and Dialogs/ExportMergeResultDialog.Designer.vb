Namespace TXTextControl.Words
    Partial Class ExportMergeResultDialog
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

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            m_tlpMainPanel = New System.Windows.Forms.TableLayoutPanel()
            m_btnOpenFolderBrowser = New System.Windows.Forms.Button()
            m_lblFilePrefix = New System.Windows.Forms.Label()
            m_lblDirectory = New System.Windows.Forms.Label()
            m_lblFormat = New System.Windows.Forms.Label()
            m_tbxDirectory = New System.Windows.Forms.TextBox()
            m_tbxFilePrefix = New System.Windows.Forms.TextBox()
            m_cmbxFormat = New System.Windows.Forms.ComboBox()
            m_tlpBottomPanel = New System.Windows.Forms.TableLayoutPanel()
            m_btnCancel = New System.Windows.Forms.Button()
            m_btnOK = New System.Windows.Forms.Button()
            m_chbxopenDirectory = New System.Windows.Forms.CheckBox()
            m_tlpMainPanel.SuspendLayout()
            m_tlpBottomPanel.SuspendLayout()
            SuspendLayout()
            ' 
            ' m_tlpMainPanel
            ' 
            m_tlpMainPanel.AutoSize = True
            m_tlpMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_tlpMainPanel.ColumnCount = 3
            m_tlpMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            m_tlpMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
            m_tlpMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            m_tlpMainPanel.Controls.Add(m_btnOpenFolderBrowser, 2, 1)
            m_tlpMainPanel.Controls.Add(m_lblFilePrefix, 0, 0)
            m_tlpMainPanel.Controls.Add(m_lblDirectory, 0, 1)
            m_tlpMainPanel.Controls.Add(m_lblFormat, 0, 2)
            m_tlpMainPanel.Controls.Add(m_tbxDirectory, 1, 1)
            m_tlpMainPanel.Controls.Add(m_tbxFilePrefix, 1, 0)
            m_tlpMainPanel.Controls.Add(m_cmbxFormat, 1, 2)
            m_tlpMainPanel.Controls.Add(m_tlpBottomPanel, 0, 4)
            m_tlpMainPanel.Controls.Add(m_chbxopenDirectory, 0, 3)
            m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            m_tlpMainPanel.Location = New System.Drawing.Point(11, 11)
            m_tlpMainPanel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            m_tlpMainPanel.Name = "m_tlpMainPanel"
            m_tlpMainPanel.RowCount = 5
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.Size = New System.Drawing.Size(275, 156)
            m_tlpMainPanel.TabIndex = 0
            ' 
            ' m_btnOpenFolderBrowser
            ' 
            m_btnOpenFolderBrowser.AutoSize = True
            m_btnOpenFolderBrowser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_btnOpenFolderBrowser.Dock = System.Windows.Forms.DockStyle.Top
            m_btnOpenFolderBrowser.Location = New System.Drawing.Point(249, 31)
            m_btnOpenFolderBrowser.Margin = New System.Windows.Forms.Padding(11, 0, 0, 8)
            m_btnOpenFolderBrowser.MaximumSize = New System.Drawing.Size(47, 923)
            m_btnOpenFolderBrowser.Name = "m_btnOpenFolderBrowser"
            m_btnOpenFolderBrowser.Size = New System.Drawing.Size(26, 25)
            m_btnOpenFolderBrowser.TabIndex = 5
            m_btnOpenFolderBrowser.Text = "..."
            m_btnOpenFolderBrowser.UseVisualStyleBackColor = True
            AddHandler m_btnOpenFolderBrowser.Click, New EventHandler(AddressOf OpenFolderBrowser_Click)
            ' 
            ' m_lblFilePrefix
            ' 
            m_lblFilePrefix.AutoSize = True
            m_lblFilePrefix.Dock = System.Windows.Forms.DockStyle.Left
            m_lblFilePrefix.Location = New System.Drawing.Point(0, 0)
            m_lblFilePrefix.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
            m_lblFilePrefix.Name = "m_lblFilePrefix"
            m_lblFilePrefix.Size = New System.Drawing.Size(61, 23)
            m_lblFilePrefix.TabIndex = 1
            m_lblFilePrefix.Text = "File &Prefix:"
            m_lblFilePrefix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_lblDirectory
            ' 
            m_lblDirectory.AutoSize = True
            m_lblDirectory.Dock = System.Windows.Forms.DockStyle.Left
            m_lblDirectory.Location = New System.Drawing.Point(0, 31)
            m_lblDirectory.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
            m_lblDirectory.Name = "m_lblDirectory"
            m_lblDirectory.Size = New System.Drawing.Size(58, 25)
            m_lblDirectory.TabIndex = 3
            m_lblDirectory.Text = "&Directory:"
            m_lblDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_lblFormat
            ' 
            m_lblFormat.AutoSize = True
            m_lblFormat.Dock = System.Windows.Forms.DockStyle.Left
            m_lblFormat.Location = New System.Drawing.Point(0, 64)
            m_lblFormat.Margin = New System.Windows.Forms.Padding(0)
            m_lblFormat.Name = "m_lblFormat"
            m_lblFormat.Padding = New System.Windows.Forms.Padding(0, 0, 0, 8)
            m_lblFormat.Size = New System.Drawing.Size(48, 31)
            m_lblFormat.TabIndex = 6
            m_lblFormat.Text = "&Format:"
            m_lblFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_tbxDirectory
            ' 
            m_tbxDirectory.Dock = System.Windows.Forms.DockStyle.Top
            m_tbxDirectory.Location = New System.Drawing.Point(72, 32)
            m_tbxDirectory.Margin = New System.Windows.Forms.Padding(11, 1, 0, 8)
            m_tbxDirectory.MinimumSize = New System.Drawing.Size(233, 4)
            m_tbxDirectory.Name = "m_tbxDirectory"
            m_tbxDirectory.Size = New System.Drawing.Size(233, 23)
            m_tbxDirectory.TabIndex = 4
            AddHandler m_tbxDirectory.TextChanged, New EventHandler(AddressOf Directory_TextChanged)
            ' 
            ' m_tbxFilePrefix
            ' 
            m_tlpMainPanel.SetColumnSpan(m_tbxFilePrefix, 2)
            m_tbxFilePrefix.Dock = System.Windows.Forms.DockStyle.Top
            m_tbxFilePrefix.Location = New System.Drawing.Point(72, 0)
            m_tbxFilePrefix.Margin = New System.Windows.Forms.Padding(11, 0, 0, 8)
            m_tbxFilePrefix.Name = "m_tbxFilePrefix"
            m_tbxFilePrefix.Size = New System.Drawing.Size(203, 23)
            m_tbxFilePrefix.TabIndex = 2
            ' 
            ' m_cmbxFormat
            ' 
            m_tlpMainPanel.SetColumnSpan(m_cmbxFormat, 2)
            m_cmbxFormat.Dock = System.Windows.Forms.DockStyle.Top
            m_cmbxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            m_cmbxFormat.FormattingEnabled = True
            m_cmbxFormat.Location = New System.Drawing.Point(72, 64)
            m_cmbxFormat.Margin = New System.Windows.Forms.Padding(11, 0, 0, 8)
            m_cmbxFormat.Name = "m_cmbxFormat"
            m_cmbxFormat.Size = New System.Drawing.Size(203, 23)
            m_cmbxFormat.TabIndex = 7
            ' 
            ' m_tlpBottomPanel
            ' 
            m_tlpBottomPanel.AutoSize = True
            m_tlpBottomPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_tlpBottomPanel.ColumnCount = 3
            m_tlpMainPanel.SetColumnSpan(m_tlpBottomPanel, 3)
            m_tlpBottomPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
            m_tlpBottomPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            m_tlpBottomPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            m_tlpBottomPanel.Controls.Add(m_btnCancel, 2, 0)
            m_tlpBottomPanel.Controls.Add(m_btnOK, 1, 0)
            m_tlpBottomPanel.Dock = System.Windows.Forms.DockStyle.Top
            m_tlpBottomPanel.Location = New System.Drawing.Point(0, 134)
            m_tlpBottomPanel.Margin = New System.Windows.Forms.Padding(0, 17, 0, 0)
            m_tlpBottomPanel.Name = "m_tlpBottomPanel"
            m_tlpBottomPanel.RowCount = 1
            m_tlpBottomPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
            m_tlpBottomPanel.Size = New System.Drawing.Size(275, 27)
            m_tlpBottomPanel.TabIndex = 9
            ' 
            ' m_btnCancel
            ' 
            m_btnCancel.AutoSize = True
            m_btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            m_btnCancel.Dock = System.Windows.Forms.DockStyle.Top
            m_btnCancel.Location = New System.Drawing.Point(187, 0)
            m_btnCancel.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
            m_btnCancel.MinimumSize = New System.Drawing.Size(88, 27)
            m_btnCancel.Name = "m_btnCancel"
            m_btnCancel.Size = New System.Drawing.Size(88, 27)
            m_btnCancel.TabIndex = 11
            m_btnCancel.Text = "Cancel"
            m_btnCancel.UseVisualStyleBackColor = True
            ' 
            ' m_btnOK
            ' 
            m_btnOK.AutoSize = True
            m_btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_btnOK.Dock = System.Windows.Forms.DockStyle.Top
            m_btnOK.Enabled = False
            m_btnOK.Location = New System.Drawing.Point(86, 0)
            m_btnOK.Margin = New System.Windows.Forms.Padding(0)
            m_btnOK.MinimumSize = New System.Drawing.Size(88, 27)
            m_btnOK.Name = "m_btnOK"
            m_btnOK.Size = New System.Drawing.Size(88, 27)
            m_btnOK.TabIndex = 10
            m_btnOK.Text = "OK"
            m_btnOK.UseVisualStyleBackColor = True
            AddHandler m_btnOK.Click, New EventHandler(AddressOf OK_Click)
            ' 
            ' m_chbxopenDirectory
            ' 
            m_chbxopenDirectory.AutoSize = True
            m_tlpMainPanel.SetColumnSpan(m_chbxopenDirectory, 3)
            m_chbxopenDirectory.Dock = System.Windows.Forms.DockStyle.Top
            m_chbxopenDirectory.Location = New System.Drawing.Point(3, 98)
            m_chbxopenDirectory.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
            m_chbxopenDirectory.Name = "m_chbxopenDirectory"
            m_chbxopenDirectory.Size = New System.Drawing.Size(272, 19)
            m_chbxopenDirectory.TabIndex = 8
            m_chbxopenDirectory.Text = "&Open directory after export"
            m_chbxopenDirectory.UseVisualStyleBackColor = True
            ' 
            ' ExportMergeResultDialog
            ' 
            AcceptButton = m_btnOK
            AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            AutoSize = True
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            CancelButton = m_btnCancel
            ClientSize = New System.Drawing.Size(297, 178)
            Controls.Add(m_tlpMainPanel)
            Font = New System.Drawing.Font("Segoe UI", 9.0F)
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            MaximizeBox = False
            MinimizeBox = False
            Name = "ExportMergeResultDialog"
            Padding = New System.Windows.Forms.Padding(11)
            ShowInTaskbar = False
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Text = "Export Merge Result"
            m_tlpMainPanel.ResumeLayout(False)
            m_tlpMainPanel.PerformLayout()
            m_tlpBottomPanel.ResumeLayout(False)
            m_tlpBottomPanel.PerformLayout()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private m_tlpMainPanel As System.Windows.Forms.TableLayoutPanel
        Private m_btnOpenFolderBrowser As System.Windows.Forms.Button
        Private m_lblFilePrefix As System.Windows.Forms.Label
        Private m_lblDirectory As System.Windows.Forms.Label
        Private m_lblFormat As System.Windows.Forms.Label
        Private m_tbxDirectory As System.Windows.Forms.TextBox
        Private m_tbxFilePrefix As System.Windows.Forms.TextBox
        Private m_cmbxFormat As System.Windows.Forms.ComboBox
        Private m_tlpBottomPanel As System.Windows.Forms.TableLayoutPanel
        Private m_btnCancel As System.Windows.Forms.Button
        Private m_btnOK As System.Windows.Forms.Button
        Private m_chbxopenDirectory As System.Windows.Forms.CheckBox
    End Class
End Namespace
