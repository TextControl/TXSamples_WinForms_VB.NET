
Namespace TXTextControl.Words
    Partial Class MainWindow
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
            Me.m_txTextControl = New TXTextControl.TextControl()
            Me.m_rbnRibbon = New TXTextControl.Windows.Forms.Ribbon.Ribbon()
            Me.m_rlblRecentFiles = New TXTextControl.Windows.Forms.Ribbon.RibbonLabel()
            Me.m_rsepSeparator2 = New TXTextControl.Windows.Forms.Ribbon.RibbonSeperator()
            Me.m_rbtnNew = New TXTextControl.Windows.Forms.Ribbon.RibbonButton()
            Me.m_rbtnOpen = New TXTextControl.Windows.Forms.Ribbon.RibbonButton()
            Me.m_rbtnSave = New TXTextControl.Windows.Forms.Ribbon.RibbonButton()
            Me.m_rbtnSaveAs = New TXTextControl.Windows.Forms.Ribbon.RibbonButton()
            Me.m_rsbtnPrint = New TXTextControl.Windows.Forms.Ribbon.RibbonSplitButton()
            Me.m_rbtnPrint = New TXTextControl.Windows.Forms.Ribbon.RibbonButton()
            Me.m_rbtnPrintQuick = New TXTextControl.Windows.Forms.Ribbon.RibbonButton()
            Me.m_rbtnPrintPreview = New TXTextControl.Windows.Forms.Ribbon.RibbonButton()
            Me.m_rtbtnAbout = New TXTextControl.Windows.Forms.Ribbon.RibbonToggleButton()
            Me.m_ctgTableTools = New TXTextControl.Windows.Forms.Ribbon.ContextualTabGroup()
            Me.m_rtRibbonTableLayoutTab = New TXTextControl.Windows.Forms.Ribbon.RibbonTableLayoutTab()
            Me.m_rtRibbonFormulaTab = New TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab()
            Me.m_ctgFrameTools = New TXTextControl.Windows.Forms.Ribbon.ContextualTabGroup()
            Me.m_rtRibbonFrameLayoutTab = New TXTextControl.Windows.Forms.Ribbon.RibbonFrameLayoutTab()
            Me.m_rtRibbonChartLayoutTab = New TXTextControl.Windows.Forms.Ribbon.RibbonChartLayoutTab()
            Me.m_rtRibbonFormattingTab = New TXTextControl.Windows.Forms.Ribbon.RibbonFormattingTab()
            Me.m_sbSidebarBottom = New TXTextControl.Windows.Forms.Sidebar()
            Me.m_sbSidebarRight = New TXTextControl.Windows.Forms.Sidebar()
            Me.m_rtRibbonInsertTab = New TXTextControl.Windows.Forms.Ribbon.RibbonInsertTab()
            Me.m_rtRibbonPermissionsTab = New TXTextControl.Windows.Forms.Ribbon.RibbonPermissionsTab()
            Me.m_rtRibbonFormFieldsTab = New TXTextControl.Windows.Forms.Ribbon.RibbonFormFieldsTab()
            Me.m_rbHorizontalRulerBar = New TXTextControl.RulerBar()
            Me.m_sbStatusBar = New TXTextControl.StatusBar()
            Me.m_rbVerticalRulerBar = New TXTextControl.RulerBar()
            Me.m_sbSidebarLeft = New TXTextControl.Windows.Forms.Sidebar()
            Me.m_rbnRibbon.SuspendLayout()
            Me.SuspendLayout()
            '
            'm_txTextControl
            '
            Me.m_txTextControl.AllowDrag = True
            Me.m_txTextControl.AllowDrop = True
            Me.m_txTextControl.DisplayColors.FormFieldColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.m_txTextControl.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.m_txTextControl.FormattingPrinter = "Standard"
            Me.m_txTextControl.HideSelection = False
            Me.m_txTextControl.IsFormFieldValidationEnabled = True
            Me.m_txTextControl.Location = New System.Drawing.Point(333, 174)
            Me.m_txTextControl.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.m_txTextControl.Name = "m_txTextControl"
            Me.m_txTextControl.PageMargins.Bottom = 78.75R
            Me.m_txTextControl.PageMargins.Left = 78.75R
            Me.m_txTextControl.PageMargins.Right = 78.75R
            Me.m_txTextControl.PageMargins.Top = 78.75R
            Me.m_txTextControl.PageSize.Height = 1169.31R
            Me.m_txTextControl.PageSize.Width = 826.81R
            Me.m_txTextControl.Ribbon = Me.m_rbnRibbon
            Me.m_txTextControl.RulerBar = Me.m_rbHorizontalRulerBar
            Me.m_txTextControl.Size = New System.Drawing.Size(601, 628)
            Me.m_txTextControl.StatusBar = Me.m_sbStatusBar
            Me.m_txTextControl.TabIndex = 1
            Me.m_txTextControl.UserNames = Nothing
            Me.m_txTextControl.VerticalRulerBar = Me.m_rbVerticalRulerBar
            '
            'm_rbnRibbon
            '
            Me.m_rbnRibbon.ApplicationMenuHelpPaneItems.AddRange(New System.Windows.Forms.Control() {Me.m_rlblRecentFiles, Me.m_rsepSeparator2})
            Me.m_rbnRibbon.ApplicationMenuItems.AddRange(New System.Windows.Forms.Control() {Me.m_rbtnNew, Me.m_rbtnOpen, Me.m_rbtnSave, Me.m_rbtnSaveAs, Me.m_rsbtnPrint, Me.m_rtbtnAbout})
            Me.m_rbnRibbon.ContextualTabGroups.Add(Me.m_ctgTableTools)
            Me.m_rbnRibbon.ContextualTabGroups.Add(Me.m_ctgFrameTools)
            Me.m_rbnRibbon.Controls.Add(Me.m_rtRibbonFormattingTab)
            Me.m_rbnRibbon.Controls.Add(Me.m_rtRibbonInsertTab)
            Me.m_rbnRibbon.Controls.Add(Me.m_rtRibbonPermissionsTab)
            Me.m_rbnRibbon.Controls.Add(Me.m_rtRibbonFormFieldsTab)
            Me.m_rbnRibbon.Dock = System.Windows.Forms.DockStyle.Top
            Me.m_rbnRibbon.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.m_rbnRibbon.HotTrack = True
            Me.m_rbnRibbon.Location = New System.Drawing.Point(0, 31)
            Me.m_rbnRibbon.Name = "m_rbnRibbon"
            Me.m_rbnRibbon.SelectedIndex = 1
            Me.m_rbnRibbon.Size = New System.Drawing.Size(1234, 118)
            Me.m_rbnRibbon.TabIndex = 2
            Me.m_rbnRibbon.Text = "ribbon1"
            '
            'm_rlblRecentFiles
            '
            Me.m_rlblRecentFiles.BackColor = System.Drawing.Color.Transparent
            Me.m_rlblRecentFiles.Dock = System.Windows.Forms.DockStyle.Top
            Me.m_rlblRecentFiles.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.m_rlblRecentFiles.Location = New System.Drawing.Point(0, 0)
            Me.m_rlblRecentFiles.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
            Me.m_rlblRecentFiles.Name = "m_rlblRecentFiles"
            Me.m_rlblRecentFiles.Size = New System.Drawing.Size(191, 24)
            Me.m_rlblRecentFiles.TabIndex = 0
            Me.m_rlblRecentFiles.TabStop = False
            Me.m_rlblRecentFiles.Text = "ribbonLabel1"
            '
            'm_rsepSeparator2
            '
            Me.m_rsepSeparator2.BackColor = System.Drawing.Color.Transparent
            Me.m_rsepSeparator2.Dock = System.Windows.Forms.DockStyle.Top
            Me.m_rsepSeparator2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.m_rsepSeparator2.Location = New System.Drawing.Point(0, 24)
            Me.m_rsepSeparator2.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
            Me.m_rsepSeparator2.Name = "m_rsepSeparator2"
            Me.m_rsepSeparator2.Size = New System.Drawing.Size(191, 5)
            Me.m_rsepSeparator2.TabIndex = 0
            Me.m_rsepSeparator2.TabStop = False
            Me.m_rsepSeparator2.Text = "ribbonSeperator2"
            '
            'm_rbtnNew
            '
            Me.m_rbtnNew.BackColor = System.Drawing.Color.Transparent
            Me.m_rbtnNew.Dock = System.Windows.Forms.DockStyle.Top
            Me.m_rbtnNew.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.m_rbtnNew.KeyTip = ""
            Me.m_rbtnNew.Location = New System.Drawing.Point(0, 0)
            Me.m_rbtnNew.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
            Me.m_rbtnNew.Name = "m_rbtnNew"
            Me.m_rbtnNew.Size = New System.Drawing.Size(191, 38)
            Me.m_rbtnNew.TabIndex = 0
            Me.m_rbtnNew.Text = "New"
            '
            'm_rbtnOpen
            '
            Me.m_rbtnOpen.BackColor = System.Drawing.Color.Transparent
            Me.m_rbtnOpen.Dock = System.Windows.Forms.DockStyle.Top
            Me.m_rbtnOpen.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.m_rbtnOpen.KeyTip = ""
            Me.m_rbtnOpen.Location = New System.Drawing.Point(0, 38)
            Me.m_rbtnOpen.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
            Me.m_rbtnOpen.Name = "m_rbtnOpen"
            Me.m_rbtnOpen.Size = New System.Drawing.Size(191, 38)
            Me.m_rbtnOpen.TabIndex = 0
            Me.m_rbtnOpen.Text = "Open..."
            '
            'm_rbtnSave
            '
            Me.m_rbtnSave.BackColor = System.Drawing.Color.Transparent
            Me.m_rbtnSave.Dock = System.Windows.Forms.DockStyle.Top
            Me.m_rbtnSave.Enabled = False
            Me.m_rbtnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.m_rbtnSave.KeyTip = ""
            Me.m_rbtnSave.Location = New System.Drawing.Point(0, 76)
            Me.m_rbtnSave.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
            Me.m_rbtnSave.Name = "m_rbtnSave"
            Me.m_rbtnSave.Size = New System.Drawing.Size(191, 38)
            Me.m_rbtnSave.TabIndex = 0
            Me.m_rbtnSave.Text = "Save"
            '
            'm_rbtnSaveAs
            '
            Me.m_rbtnSaveAs.BackColor = System.Drawing.Color.Transparent
            Me.m_rbtnSaveAs.Dock = System.Windows.Forms.DockStyle.Top
            Me.m_rbtnSaveAs.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.m_rbtnSaveAs.KeyTip = ""
            Me.m_rbtnSaveAs.Location = New System.Drawing.Point(0, 114)
            Me.m_rbtnSaveAs.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
            Me.m_rbtnSaveAs.Name = "m_rbtnSaveAs"
            Me.m_rbtnSaveAs.Size = New System.Drawing.Size(191, 38)
            Me.m_rbtnSaveAs.TabIndex = 0
            Me.m_rbtnSaveAs.Text = "Save As..."
            '
            'm_rsbtnPrint
            '
            Me.m_rsbtnPrint.BackColor = System.Drawing.Color.Transparent
            Me.m_rsbtnPrint.Dock = System.Windows.Forms.DockStyle.Top
            Me.m_rsbtnPrint.DropDownItems.AddRange(New System.Windows.Forms.Control() {Me.m_rbtnPrint, Me.m_rbtnPrintQuick, Me.m_rbtnPrintPreview})
            Me.m_rsbtnPrint.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.m_rsbtnPrint.KeyTip = ""
            Me.m_rsbtnPrint.Location = New System.Drawing.Point(0, 152)
            Me.m_rsbtnPrint.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
            Me.m_rsbtnPrint.Name = "m_rsbtnPrint"
            Me.m_rsbtnPrint.Size = New System.Drawing.Size(191, 38)
            Me.m_rsbtnPrint.TabIndex = 0
            Me.m_rsbtnPrint.Text = "Print..."
            '
            'm_rbtnPrint
            '
            Me.m_rbtnPrint.BackColor = System.Drawing.Color.Transparent
            Me.m_rbtnPrint.Dock = System.Windows.Forms.DockStyle.Top
            Me.m_rbtnPrint.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.m_rbtnPrint.KeyTip = ""
            Me.m_rbtnPrint.Location = New System.Drawing.Point(0, 0)
            Me.m_rbtnPrint.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
            Me.m_rbtnPrint.Name = "m_rbtnPrint"
            Me.m_rbtnPrint.Size = New System.Drawing.Size(128, 38)
            Me.m_rbtnPrint.TabIndex = 0
            Me.m_rbtnPrint.Text = "ribbonButton1"
            '
            'm_rbtnPrintQuick
            '
            Me.m_rbtnPrintQuick.BackColor = System.Drawing.Color.Transparent
            Me.m_rbtnPrintQuick.Dock = System.Windows.Forms.DockStyle.Top
            Me.m_rbtnPrintQuick.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.m_rbtnPrintQuick.KeyTip = ""
            Me.m_rbtnPrintQuick.Location = New System.Drawing.Point(0, 0)
            Me.m_rbtnPrintQuick.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
            Me.m_rbtnPrintQuick.Name = "m_rbtnPrintQuick"
            Me.m_rbtnPrintQuick.Size = New System.Drawing.Size(128, 38)
            Me.m_rbtnPrintQuick.TabIndex = 0
            Me.m_rbtnPrintQuick.Text = "ribbonButton2"
            '
            'm_rbtnPrintPreview
            '
            Me.m_rbtnPrintPreview.BackColor = System.Drawing.Color.Transparent
            Me.m_rbtnPrintPreview.Dock = System.Windows.Forms.DockStyle.Top
            Me.m_rbtnPrintPreview.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.m_rbtnPrintPreview.KeyTip = ""
            Me.m_rbtnPrintPreview.Location = New System.Drawing.Point(0, 0)
            Me.m_rbtnPrintPreview.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
            Me.m_rbtnPrintPreview.Name = "m_rbtnPrintPreview"
            Me.m_rbtnPrintPreview.Size = New System.Drawing.Size(128, 38)
            Me.m_rbtnPrintPreview.TabIndex = 0
            Me.m_rbtnPrintPreview.Text = "ribbonButton3"
            '
            'm_rtbtnAbout
            '
            Me.m_rtbtnAbout.BackColor = System.Drawing.Color.Transparent
            Me.m_rtbtnAbout.Checked = True
            Me.m_rtbtnAbout.Dock = System.Windows.Forms.DockStyle.Top
            Me.m_rtbtnAbout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.m_rtbtnAbout.KeyTip = ""
            Me.m_rtbtnAbout.Location = New System.Drawing.Point(0, 0)
            Me.m_rtbtnAbout.Name = "m_rtbtnAbout"
            Me.m_rtbtnAbout.Size = New System.Drawing.Size(0, 0)
            Me.m_rtbtnAbout.TabIndex = 0
            Me.m_rtbtnAbout.Text = "ribbonToggleButton1"
            '
            'm_ctgTableTools
            '
            Me.m_ctgTableTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.m_ctgTableTools.ContextualTabs.Add(Me.m_rtRibbonTableLayoutTab)
            Me.m_ctgTableTools.ContextualTabs.Add(Me.m_rtRibbonFormulaTab)
            Me.m_ctgTableTools.Name = "m_ctgTableTools"
            '
            'm_rtRibbonTableLayoutTab
            '
            Me.m_rtRibbonTableLayoutTab.Location = New System.Drawing.Point(0, 0)
            Me.m_rtRibbonTableLayoutTab.Name = "m_rtRibbonTableLayoutTab"
            Me.m_rtRibbonTableLayoutTab.Size = New System.Drawing.Size(200, 40)
            Me.m_rtRibbonTableLayoutTab.TabIndex = 0
            '
            'm_rtRibbonFormulaTab
            '
            Me.m_rtRibbonFormulaTab.Location = New System.Drawing.Point(0, 0)
            Me.m_rtRibbonFormulaTab.Name = "m_rtRibbonFormulaTab"
            Me.m_rtRibbonFormulaTab.Size = New System.Drawing.Size(200, 40)
            Me.m_rtRibbonFormulaTab.TabIndex = 0
            '
            'm_ctgFrameTools
            '
            Me.m_ctgFrameTools.BackColor = System.Drawing.Color.LightGray
            Me.m_ctgFrameTools.ContextualTabs.Add(Me.m_rtRibbonFrameLayoutTab)
            Me.m_ctgFrameTools.ContextualTabs.Add(Me.m_rtRibbonChartLayoutTab)
            Me.m_ctgFrameTools.Name = "m_ctgChartTools"
            '
            'm_rtRibbonFrameLayoutTab
            '
            Me.m_rtRibbonFrameLayoutTab.Location = New System.Drawing.Point(0, 0)
            Me.m_rtRibbonFrameLayoutTab.Name = "m_rtRibbonFrameLayoutTab"
            Me.m_rtRibbonFrameLayoutTab.Size = New System.Drawing.Size(200, 40)
            Me.m_rtRibbonFrameLayoutTab.TabIndex = 0
            '
            'm_rtRibbonChartLayoutTab
            '
            Me.m_rtRibbonChartLayoutTab.Location = New System.Drawing.Point(0, 0)
            Me.m_rtRibbonChartLayoutTab.Name = "m_rtRibbonChartLayoutTab"
            Me.m_rtRibbonChartLayoutTab.Size = New System.Drawing.Size(200, 40)
            Me.m_rtRibbonChartLayoutTab.TabIndex = 0
            '
            'm_rtRibbonFormattingTab
            '
            Me.m_rtRibbonFormattingTab.FindHorizontalSidebar = Me.m_sbSidebarBottom
            Me.m_rtRibbonFormattingTab.FindSidebar = Me.m_sbSidebarRight
            Me.m_rtRibbonFormattingTab.GotoHorizontalSidebar = Me.m_sbSidebarBottom
            Me.m_rtRibbonFormattingTab.Location = New System.Drawing.Point(4, 24)
            Me.m_rtRibbonFormattingTab.Name = "m_rtRibbonFormattingTab"
            Me.m_rtRibbonFormattingTab.ReplaceHorizontalSidebar = Me.m_sbSidebarBottom
            Me.m_rtRibbonFormattingTab.ReplaceSidebar = Me.m_sbSidebarRight
            Me.m_rtRibbonFormattingTab.Size = New System.Drawing.Size(1226, 90)
            Me.m_rtRibbonFormattingTab.StylesSidebar = Me.m_sbSidebarRight
            Me.m_rtRibbonFormattingTab.TabIndex = 1
            '
            'm_sbSidebarBottom
            '
            Me.m_sbSidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.m_sbSidebarBottom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.m_sbSidebarBottom.IsShown = False
            Me.m_sbSidebarBottom.Location = New System.Drawing.Point(308, 802)
            Me.m_sbSidebarBottom.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.m_sbSidebarBottom.Name = "m_sbSidebarBottom"
            Me.m_sbSidebarBottom.Padding = New System.Windows.Forms.Padding(6)
            Me.m_sbSidebarBottom.ShowTitle = False
            Me.m_sbSidebarBottom.Size = New System.Drawing.Size(626, 18)
            Me.m_sbSidebarBottom.TabIndex = 6
            Me.m_sbSidebarBottom.Text = "m_sbHorizontalSidebar"
            Me.m_sbSidebarBottom.TextControl = Me.m_txTextControl
            '
            'm_sbSidebarRight
            '
            Me.m_sbSidebarRight.ContentLayout = TXTextControl.Windows.Forms.Sidebar.SidebarContentLayout.ConditionalInstructions
            Me.m_sbSidebarRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.m_sbSidebarRight.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.m_sbSidebarRight.Location = New System.Drawing.Point(934, 149)
            Me.m_sbSidebarRight.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.m_sbSidebarRight.Name = "m_sbSidebarRight"
            Me.m_sbSidebarRight.Padding = New System.Windows.Forms.Padding(6)
            Me.m_sbSidebarRight.Size = New System.Drawing.Size(300, 671)
            Me.m_sbSidebarRight.TabIndex = 8
            Me.m_sbSidebarRight.TextControl = Me.m_txTextControl
            '
            'm_rtRibbonInsertTab
            '
            Me.m_rtRibbonInsertTab.Location = New System.Drawing.Point(4, 24)
            Me.m_rtRibbonInsertTab.Name = "m_rtRibbonInsertTab"
            Me.m_rtRibbonInsertTab.Size = New System.Drawing.Size(1226, 90)
            Me.m_rtRibbonInsertTab.TabIndex = 2
            '
            'm_rtRibbonPermissionsTab
            '
            Me.m_rtRibbonPermissionsTab.AllowAddingUserNames = True
            Me.m_rtRibbonPermissionsTab.Location = New System.Drawing.Point(4, 24)
            Me.m_rtRibbonPermissionsTab.Name = "m_rtRibbonPermissionsTab"
            Me.m_rtRibbonPermissionsTab.RegisteredUserNames = New String(-1) {}
            Me.m_rtRibbonPermissionsTab.Size = New System.Drawing.Size(1226, 90)
            Me.m_rtRibbonPermissionsTab.TabIndex = 7
            '
            'm_rtRibbonFormFieldsTab
            '
            Me.m_rtRibbonFormFieldsTab.ConditionalInstructionsSidebar = Me.m_sbSidebarRight
            Me.m_rtRibbonFormFieldsTab.Location = New System.Drawing.Point(4, 24)
            Me.m_rtRibbonFormFieldsTab.Name = "m_rtRibbonFormFieldsTab"
            Me.m_rtRibbonFormFieldsTab.Size = New System.Drawing.Size(1226, 90)
            Me.m_rtRibbonFormFieldsTab.TabIndex = 8
            '
            'm_rbHorizontalRulerBar
            '
            Me.m_rbHorizontalRulerBar.Dock = System.Windows.Forms.DockStyle.Top
            Me.m_rbHorizontalRulerBar.Location = New System.Drawing.Point(308, 149)
            Me.m_rbHorizontalRulerBar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.m_rbHorizontalRulerBar.Name = "m_rbHorizontalRulerBar"
            Me.m_rbHorizontalRulerBar.Size = New System.Drawing.Size(626, 25)
            Me.m_rbHorizontalRulerBar.TabIndex = 5
            Me.m_rbHorizontalRulerBar.Text = "rulerBar2"
            '
            'm_sbStatusBar
            '
            Me.m_sbStatusBar.BackColor = System.Drawing.SystemColors.Control
            Me.m_sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.m_sbStatusBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.m_sbStatusBar.Location = New System.Drawing.Point(0, 820)
            Me.m_sbStatusBar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.m_sbStatusBar.Name = "m_sbStatusBar"
            Me.m_sbStatusBar.Size = New System.Drawing.Size(1234, 22)
            Me.m_sbStatusBar.TabIndex = 3
            '
            'm_rbVerticalRulerBar
            '
            Me.m_rbVerticalRulerBar.Alignment = TXTextControl.RulerBarAlignment.Left
            Me.m_rbVerticalRulerBar.Dock = System.Windows.Forms.DockStyle.Left
            Me.m_rbVerticalRulerBar.Location = New System.Drawing.Point(308, 174)
            Me.m_rbVerticalRulerBar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.m_rbVerticalRulerBar.Name = "m_rbVerticalRulerBar"
            Me.m_rbVerticalRulerBar.Size = New System.Drawing.Size(25, 628)
            Me.m_rbVerticalRulerBar.TabIndex = 4
            Me.m_rbVerticalRulerBar.Text = "rulerBar1"
            '
            'm_sbSidebarLeft
            '
            Me.m_sbSidebarLeft.ContentLayout = TXTextControl.Windows.Forms.Sidebar.SidebarContentLayout.About
            Me.m_sbSidebarLeft.DialogStyle = TXTextControl.Windows.Forms.Sidebar.SidebarDialogStyle.StandardSizable
            Me.m_sbSidebarLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.m_sbSidebarLeft.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.m_sbSidebarLeft.Location = New System.Drawing.Point(0, 149)
            Me.m_sbSidebarLeft.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.m_sbSidebarLeft.Name = "m_sbSidebarLeft"
            Me.m_sbSidebarLeft.Padding = New System.Windows.Forms.Padding(6)
            Me.m_sbSidebarLeft.ShowPinButton = False
            Me.m_sbSidebarLeft.Size = New System.Drawing.Size(308, 671)
            Me.m_sbSidebarLeft.TabIndex = 7
            Me.m_sbSidebarLeft.TextControl = Me.m_txTextControl
            '
            'MainWindow
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1234, 842)
            Me.Controls.Add(Me.m_txTextControl)
            Me.Controls.Add(Me.m_rbVerticalRulerBar)
            Me.Controls.Add(Me.m_rbHorizontalRulerBar)
            Me.Controls.Add(Me.m_sbSidebarBottom)
            Me.Controls.Add(Me.m_sbSidebarRight)
            Me.Controls.Add(Me.m_sbSidebarLeft)
            Me.Controls.Add(Me.m_sbStatusBar)
            Me.Controls.Add(Me.m_rbnRibbon)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.Name = "MainWindow"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "TX Text Control Words"
            Me.m_rbnRibbon.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private m_txTextControl As TextControl
        Private m_rbnRibbon As Windows.Forms.Ribbon.Ribbon
        Private m_rtRibbonFormattingTab As Windows.Forms.Ribbon.RibbonFormattingTab
        Private m_sbSidebarBottom As Windows.Forms.Sidebar
        Private m_sbSidebarRight As Windows.Forms.Sidebar
        Private m_rtRibbonInsertTab As Windows.Forms.Ribbon.RibbonInsertTab
        Private m_sbSidebarLeft As Windows.Forms.Sidebar
        Private m_rtRibbonPermissionsTab As Windows.Forms.Ribbon.RibbonPermissionsTab
        Private m_rtRibbonFormFieldsTab As Windows.Forms.Ribbon.RibbonFormFieldsTab
        Private m_rbHorizontalRulerBar As RulerBar
        Private m_sbStatusBar As StatusBar
        Private m_rbVerticalRulerBar As RulerBar
        Private m_rbtnNew As Windows.Forms.Ribbon.RibbonButton
        Private m_rbtnOpen As Windows.Forms.Ribbon.RibbonButton
        Private m_rbtnSave As Windows.Forms.Ribbon.RibbonButton
        Private m_rbtnSaveAs As Windows.Forms.Ribbon.RibbonButton
        Private m_rsbtnPrint As Windows.Forms.Ribbon.RibbonSplitButton
        Private m_rbtnPrint As Windows.Forms.Ribbon.RibbonButton
        Private m_rbtnPrintQuick As Windows.Forms.Ribbon.RibbonButton
        Private m_rbtnPrintPreview As Windows.Forms.Ribbon.RibbonButton
        Private m_ctgTableTools As Windows.Forms.Ribbon.ContextualTabGroup
        Private m_rtRibbonTableLayoutTab As Windows.Forms.Ribbon.RibbonTableLayoutTab
        Private m_rtRibbonFormulaTab As Windows.Forms.Ribbon.RibbonFormulaTab
        Private m_ctgFrameTools As Windows.Forms.Ribbon.ContextualTabGroup
        Private m_rtRibbonFrameLayoutTab As Windows.Forms.Ribbon.RibbonFrameLayoutTab
        Private m_rtRibbonChartLayoutTab As Windows.Forms.Ribbon.RibbonChartLayoutTab
        Private m_rlblRecentFiles As Windows.Forms.Ribbon.RibbonLabel
        Private m_rsepSeparator2 As Windows.Forms.Ribbon.RibbonSeperator
        Private m_rtbtnAbout As Windows.Forms.Ribbon.RibbonToggleButton
    End Class
End Namespace
