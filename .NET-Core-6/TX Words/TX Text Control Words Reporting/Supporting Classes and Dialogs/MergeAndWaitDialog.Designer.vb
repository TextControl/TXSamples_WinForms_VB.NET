Namespace TXTextControl.Words
    Partial Class MergeAndWaitDialog
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
            m_pbProgressBar = New System.Windows.Forms.ProgressBar()
            m_lblMerging = New System.Windows.Forms.Label()
            m_tlpMainPanel = New System.Windows.Forms.TableLayoutPanel()
            m_bwMergeFiles = New ComponentModel.BackgroundWorker()
            m_tlpMainPanel.SuspendLayout()
            SuspendLayout()
            ' 
            ' m_pbProgressBar
            ' 
            m_pbProgressBar.Dock = System.Windows.Forms.DockStyle.Top
            m_pbProgressBar.Location = New System.Drawing.Point(3, 20)
            m_pbProgressBar.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
            m_pbProgressBar.MarqueeAnimationSpeed = 50
            m_pbProgressBar.MinimumSize = New System.Drawing.Size(220, 0)
            m_pbProgressBar.Name = "m_pbProgressBar"
            m_pbProgressBar.Size = New System.Drawing.Size(220, 50)
            m_pbProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
            m_pbProgressBar.TabIndex = 0
            m_pbProgressBar.Value = 100
            ' 
            ' m_lblMerging
            ' 
            m_lblMerging.AutoSize = True
            m_lblMerging.Dock = System.Windows.Forms.DockStyle.Top
            m_lblMerging.Location = New System.Drawing.Point(0, 0)
            m_lblMerging.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
            m_lblMerging.Name = "m_lblMerging"
            m_lblMerging.Size = New System.Drawing.Size(219, 15)
            m_lblMerging.TabIndex = 1
            m_lblMerging.Text = "Merging…"
            ' 
            ' m_tlpMainPanel
            ' 
            m_tlpMainPanel.AutoSize = True
            m_tlpMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            m_tlpMainPanel.ColumnCount = 1
            m_tlpMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
            m_tlpMainPanel.Controls.Add(m_pbProgressBar, 0, 1)
            m_tlpMainPanel.Controls.Add(m_lblMerging, 0, 0)
            m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            m_tlpMainPanel.Location = New System.Drawing.Point(8, 11)
            m_tlpMainPanel.Name = "m_tlpMainPanel"
            m_tlpMainPanel.RowCount = 3
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            m_tlpMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
            m_tlpMainPanel.Size = New System.Drawing.Size(219, 36)
            m_tlpMainPanel.TabIndex = 2
            ' 
            ' m_bwMergeFiles
            ' 
            m_bwMergeFiles.WorkerSupportsCancellation = True
            AddHandler m_bwMergeFiles.DoWork, New ComponentModel.DoWorkEventHandler(AddressOf BackgroundWorker_DoWork)
            AddHandler m_bwMergeFiles.RunWorkerCompleted, New ComponentModel.RunWorkerCompletedEventHandler(AddressOf BackgroundWorker_RunWorkerCompleted)
            ' 
            ' MergeAndWaitDialog
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            ClientSize = New System.Drawing.Size(238, 58)
            Controls.Add(m_tlpMainPanel)
            Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            MaximizeBox = False
            MinimizeBox = False
            Name = "MergeAndWaitDialog"
            Padding = New System.Windows.Forms.Padding(8, 11, 11, 11)
            RightToLeftLayout = True
            ShowInTaskbar = False
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Text = "Please wait"
            m_tlpMainPanel.ResumeLayout(False)
            m_tlpMainPanel.PerformLayout()
            ResumeLayout(False)
            PerformLayout()

        End Sub



        Private m_pbProgressBar As System.Windows.Forms.ProgressBar
        Private m_lblMerging As System.Windows.Forms.Label
        Private m_tlpMainPanel As System.Windows.Forms.TableLayoutPanel
        Private m_bwMergeFiles As ComponentModel.BackgroundWorker
    End Class
End Namespace
