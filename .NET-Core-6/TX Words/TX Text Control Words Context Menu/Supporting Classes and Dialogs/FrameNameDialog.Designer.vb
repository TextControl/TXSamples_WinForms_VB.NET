
Namespace TXTextControl.Words
    Partial Friend Class FrameNameDialog
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
            m_btnCancel = New System.Windows.Forms.Button()
            m_lblFrameName = New System.Windows.Forms.Label()
            m_tbxFrameName = New System.Windows.Forms.TextBox()
            m_btnOK = New System.Windows.Forms.Button()
            m_tlpMainPanel.SuspendLayout()
            SuspendLayout()
            ' 
            ' m_tlpMainPanel
            ' 
            m_tlpMainPanel.AutoSize = True
            m_tlpMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_tlpMainPanel.ColumnCount = 3
            m_tlpMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            m_tlpMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            m_tlpMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            m_tlpMainPanel.Controls.Add(m_btnCancel, 3, 2)
            m_tlpMainPanel.Controls.Add(m_lblFrameName, 0, 0)
            m_tlpMainPanel.Controls.Add(m_tbxFrameName, 0, 1)
            m_tlpMainPanel.Controls.Add(m_btnOK, 1, 2)
            m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            m_tlpMainPanel.Location = New System.Drawing.Point(9, 13)
            m_tlpMainPanel.Margin = New System.Windows.Forms.Padding(0)
            m_tlpMainPanel.Name = "m_tlpMainPanel"
            m_tlpMainPanel.RowCount = 4
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            m_tlpMainPanel.Size = New System.Drawing.Size(278, 87)
            m_tlpMainPanel.TabIndex = 0
            ' 
            ' m_btnCancel
            ' 
            m_btnCancel.AutoSize = True
            m_btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            m_btnCancel.Dock = System.Windows.Forms.DockStyle.Top
            m_btnCancel.Location = New System.Drawing.Point(191, 64)
            m_btnCancel.Margin = New System.Windows.Forms.Padding(0)
            m_btnCancel.MinimumSize = New System.Drawing.Size(87, 27)
            m_btnCancel.Name = "m_btnCancel"
            m_btnCancel.Size = New System.Drawing.Size(87, 27)
            m_btnCancel.TabIndex = 3
            m_btnCancel.Text = "Cancel"
            m_btnCancel.UseVisualStyleBackColor = True
            ' 
            ' m_lblFrameName
            ' 
            m_lblFrameName.AutoSize = True
            m_tlpMainPanel.SetColumnSpan(m_lblFrameName, 3)
            m_lblFrameName.Dock = System.Windows.Forms.DockStyle.Top
            m_lblFrameName.Location = New System.Drawing.Point(0, 0)
            m_lblFrameName.Margin = New System.Windows.Forms.Padding(0, 0, 0, 9)
            m_lblFrameName.Name = "m_lblFrameName"
            m_lblFrameName.Size = New System.Drawing.Size(278, 15)
            m_lblFrameName.TabIndex = 0
            m_lblFrameName.Text = "Frame name:"
            ' 
            ' m_tbxFrameName
            ' 
            m_tlpMainPanel.SetColumnSpan(m_tbxFrameName, 3)
            m_tbxFrameName.Dock = System.Windows.Forms.DockStyle.Top
            m_tbxFrameName.Location = New System.Drawing.Point(3, 24)
            m_tbxFrameName.Margin = New System.Windows.Forms.Padding(3, 0, 0, 17)
            m_tbxFrameName.MinimumSize = New System.Drawing.Size(291, 4)
            m_tbxFrameName.Name = "m_tbxFrameName"
            m_tbxFrameName.Size = New System.Drawing.Size(291, 23)
            m_tbxFrameName.TabIndex = 1
            ' 
            ' m_btnOK
            ' 
            m_btnOK.AutoSize = True
            m_btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
            m_btnOK.Dock = System.Windows.Forms.DockStyle.Top
            m_btnOK.Location = New System.Drawing.Point(91, 64)
            m_btnOK.Margin = New System.Windows.Forms.Padding(0, 0, 13, 0)
            m_btnOK.MinimumSize = New System.Drawing.Size(87, 27)
            m_btnOK.Name = "m_btnOK"
            m_btnOK.Size = New System.Drawing.Size(87, 27)
            m_btnOK.TabIndex = 2
            m_btnOK.Text = "OK"
            m_btnOK.UseVisualStyleBackColor = True
            ' 
            ' FrameNameDialog
            ' 
            AcceptButton = m_btnOK
            AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            AutoSize = True
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            CancelButton = m_btnCancel
            ClientSize = New System.Drawing.Size(300, 113)
            Controls.Add(m_tlpMainPanel)
            Font = New System.Drawing.Font("Segoe UI", 9.0F)
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            MaximizeBox = False
            MinimizeBox = False
            Name = "FrameNameDialog"
            Padding = New System.Windows.Forms.Padding(9, 13, 13, 13)
            ShowInTaskbar = False
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Text = "Enter Frame Name"
            m_tlpMainPanel.ResumeLayout(False)
            m_tlpMainPanel.PerformLayout()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private m_tlpMainPanel As System.Windows.Forms.TableLayoutPanel
        Private m_btnCancel As System.Windows.Forms.Button
        Private m_lblFrameName As System.Windows.Forms.Label
        Private m_tbxFrameName As System.Windows.Forms.TextBox
        Private m_btnOK As System.Windows.Forms.Button
    End Class
End Namespace
