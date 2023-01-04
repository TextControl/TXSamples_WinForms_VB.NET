'-----------------------------------------------------------------------------------------------------------
' MainWindow_Reporting_Layout.vb File
'
' Description:
'		Sets the layout of the added application menu's sample template button, the RibbonReportingTab's  
'		'Database Sample' button,  Merge' group and the reporting "Result" tab.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Imports TXTextControl.Windows.Forms
Imports TXTextControl.Windows.Forms.Ribbon

Namespace TXTextControl.Words
    Partial Class MainWindow
        '-----------------------------------------------------------------------------------------------------------
        ' M E M B E R   V A R I A B L E S
        '-----------------------------------------------------------------------------------------------------------
        ' RibbonReportingTab
        Private m_rbtnSampleDatabaseButton As RibbonButton = Nothing
        Private ReadOnly m_rgMerge As RibbonGroup = New RibbonGroup()
        Private m_rbtnMergeAndExport As RibbonButton = Nothing

        ' Result Tab
        Private m_rgMergeResultsTab_ResultGroup As RibbonGroup = New RibbonGroup()
        Private m_rbtnExitMergeResultsTab As RibbonButton = New RibbonButton()

        Private m_rgNavigateGroup As RibbonGroup = New RibbonGroup()
        Private m_rbtnFirstRecord As RibbonButton = New RibbonButton()
        Private m_rbtnPreviousRecord As RibbonButton = New RibbonButton()
        Private m_rbtnNextRecord As RibbonButton = New RibbonButton()
        Private m_rbtnLastRecord As RibbonButton = New RibbonButton()

        Private m_rgExportGroup As RibbonGroup = New RibbonGroup()
        Private m_rbtnExportMergeResult As RibbonButton = Nothing

        '-----------------------------------------------------------------------------------------------------------
        ' M E T H O D S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' Application Menu
        '-----------------------------------------------------------------------------------------------------------
        '-----------------------------------------------------------------------------------------------------------
        ' SetOpenSampleTemplateButtonDesign Method
        ' Sets the design of the menu button with a drop down menu that references to three different templates which are
        ' associated with the sample base.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetOpenSampleTemplateButtonDesign()
            m_rmbtnOpenSampleTemplate.SmallIcon = GetSmallIcon("OpenSampleTemplate_Small.svg")
            m_rmbtnOpenSampleTemplate.LargeIcon = GetLargeIcon("OpenSampleTemplate_Large.svg")
            m_rmbtnOpenSampleTemplate.Text = My.Resources.ApplicationMenu_OpenSampleTemplate
            m_rmbtnOpenSampleTemplate.KeyTip = My.Resources.ApplicationMenu_OpenSampleTemplate_KeyTip
            m_rmbtnOpenSampleTemplate.ToolTip.Title = My.Resources.ApplicationMenu_OpenSampleTemplate_ToolTip_Title
            m_rmbtnOpenSampleTemplate.ToolTip.Description = My.Resources.ApplicationMenu_OpenSampleTemplate_ToolTip_Description

            m_rbtnSampleInvoiceTemplate.Text = My.Resources.ApplicationMenu_SampleInvoiceTemplate
            m_rbtnSampleInvoiceTemplate.KeyTip = My.Resources.ApplicationMenu_SampleInvoiceTemplate_KeyTip
            AddHandler m_rbtnSampleInvoiceTemplate.Click, AddressOf SampleInvoiceTemplate_Click
            m_rbtnSamplePackingListTemplate.Text = My.Resources.ApplicationMenu_SamplePackingListTemplate
            m_rbtnSamplePackingListTemplate.KeyTip = My.Resources.ApplicationMenu_SamplePackingListTemplate_KeyTip
            AddHandler m_rbtnSamplePackingListTemplate.Click, AddressOf SamplePackingListTemplate_Click
            m_rbtnSampleShippingLabelTemplate.Text = My.Resources.ApplicationMenu_SampleShippingLabelTemplate
            m_rbtnSampleShippingLabelTemplate.KeyTip = My.Resources.ApplicationMenu_SampleShippingLabelTemplate_KeyTip
            AddHandler m_rbtnSampleShippingLabelTemplate.Click, AddressOf SampleShippingLabelTemplate_Click
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' RibbonReportingTab
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' AddSampleDatabaseButton Method
        ' Creates a ribbon button that loads the sampled database when clicked. That button is added to the drop 
        ' down menu of the 'Select Data Source' button.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub AddSampleDatabaseButton()
            ' Create the ribbon button
            m_rbtnSampleDatabaseButton = New RibbonButton() With {
                .Text = My.Resources.RibbonReportingTab_LoadSampleDatabase,
                .SmallIcon = GetSmallIcon("SampleDatabase_Small.svg"),
                .DisplayMode = IconTextRelation.SmallIconLabeled
            }

            ' Add tool tips
            m_rbtnSampleDatabaseButton.ToolTip.Title = My.Resources.RibbonReportingTab_LoadSampleDatabase_ToolTip_Title
            m_rbtnSampleDatabaseButton.ToolTip.Description = My.Resources.RibbonReportingTab_LoadSampleDatabase_ToolTip_Description

            ' Add the handler that loads the sampled database when clicked
            AddHandler m_rbtnSampleDatabaseButton.Click, AddressOf SampleDatabaseButton_Click

            ' Add the ribbon button to the drop down menu of the 'Select Data Source' button.
            Dim rsbtnSelectDataSource As RibbonSplitButton = TryCast(m_rtRibbonReportingTab.FindItem(RibbonReportingTab.RibbonItem.TXITEM_DataSource), RibbonSplitButton)
            rsbtnSelectDataSource.DropDownItems.Insert(4, m_rbtnSampleDatabaseButton)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' AddMergeGroup Method
        ' Creates a ribbon group with a ribbon button that starts merging files and switches to the 'Result' tab when 
        ' clicked.
        '
        ' Parameters:
        '      ribbonTab:   The ribbon tab where to add the created ribbon group.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub AddMergeGroup(ByVal ribbonTab As RibbonReportingTab)
            ' Create the icons for the ribbon group and ribbon button.
            Dim bmpSmallIcon = GetSmallIcon("MergeAndExport_Small.svg")
            Dim bmpLargeIcon = GetLargeIcon("MergeAndExport_Large.svg")

            ' Set ribbon group design
            SetReportingGroupDesign(Nothing, m_rgMerge, "Merge")
            m_rgMerge.SmallIcon = bmpSmallIcon
            m_rgMerge.LargeIcon = bmpLargeIcon

            ' Add a ribbon button that starts merging files and switches to the 'Result' tab when clicked.
            AddMergeAndExportButton(m_rgMerge, bmpSmallIcon, bmpLargeIcon)

            ' Add the ribbon group to the ribbon tab
            ribbonTab.RibbonGroups.Add(m_rgMerge)

            ' The group's enabled state depends on the IsMergingPossible property value of the 
            ' RibbonReportingTab's DataSourceManager 
            m_rgMerge.Enabled = m_rtRibbonReportingTab.DataSourceManager.IsMergingPossible
            AddHandler m_rtRibbonReportingTab.DataSourceManager.IsMergingPossibleChanged, AddressOf DataSourceManager_IsMergingPossibleChanged
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' AddMergeAndExportButton Method
        ' Creates a ribbon button that starts merging files and switches to the 'Result' tab when clicked. That 
        ' ribbon button is added to the specified ribbon group. 
        '
        ' Parameters:
        '      ribbonGroup:    The ribbon group where to add the created ribbon button.
        '      smallIcon:      The bitmap that is used as the ribbon button's small icon.
        '      largeIcon:      The bitmap that is used as the ribbon button's large icon.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub AddMergeAndExportButton(ByVal ribbonGroup As RibbonGroup, ByVal smallIcon As Bitmap, ByVal largeIcon As Bitmap)

            ' Create the ribbon button
            m_rbtnMergeAndExport = New RibbonButton() With {
                .Text = My.Resources.MergeAndExport,
                .SmallIcon = smallIcon,
                .LargeIcon = largeIcon,
                .KeyTip = My.Resources.MergeAndExport_KeyTip
            }

            ' Add tool tips
            m_rbtnMergeAndExport.ToolTip.Title = My.Resources.MergeAndExport_ToolTip_Title
            m_rbtnMergeAndExport.ToolTip.Description = My.Resources.MergeAndExport_ToolTip_Description

            ' Add the handler that starts merging files and switches to the 'Result' tab when clicked.
            AddHandler m_rbtnMergeAndExport.Click, AddressOf MergeAndExport_Click

            ' Add the ribbon button to the ribbon group
            ribbonGroup.RibbonItems.Add(m_rbtnMergeAndExport)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' 'Reporting' ContextualTabGroup and 'Result' RibbonTab
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' SetMergeResultsTabDesign Method
        ' Creates groups and sets the design of the reporting 'Result' tab.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetMergeResultsTabDesign()
            ' Set the header texts of the  'Result' contextual tab group and ribbon tab.
            m_ctgReportingResult.Header = My.Resources.ContextualTabGroup_Reporting
            m_rtMergeResultsTab.Text = My.Resources.MergeResultsTab
            ' Set the key tip of the 'Result' ribbon tab.
            m_rtMergeResultsTab.KeyTip = My.Resources.MergeResultsTab_KeyTip

            ' Create the 'Result', 'Navigate' and 'Export' groups.
            CreateResultGroup()
            CreateNavigateGroup()
            CreateExportGroup()
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' CreateResultGroup Method
        ' Creates the reporting 'Result' tab's 'Result' group.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub CreateResultGroup()
            ' Set the design of the 'Result' group and the "Exit" button.
            SetReportingGroupDesign(ResourceProvider.FileMenuItem.TXITEM_Exit.ToString(), m_rgMergeResultsTab_ResultGroup, "MergeResultsTab_Result")
            SetReportingButtonDesign(ResourceProvider.FileMenuItem.TXITEM_Exit.ToString(), m_rbtnExitMergeResultsTab, "MergeResultsTab_Exit")

            ' Add a handler to the "Exit" button that closes the 'Result' tab when the button is clicked.
            AddHandler m_rbtnExitMergeResultsTab.Click, AddressOf ExitResultTab_Click

            ' Add the "Exit" button to the 'Result' tab's 'Result' group.
            m_rgMergeResultsTab_ResultGroup.RibbonItems.Add(m_rbtnExitMergeResultsTab)

            ' Add the 'Result' group to the reporting 'Result' tab.
            m_rtMergeResultsTab.RibbonGroups.Add(m_rgMergeResultsTab_ResultGroup)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' CreateNavigateGroup Method
        ' Creates the reporting 'Result' tab's "Navigate" group.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub CreateNavigateGroup()
            ' Set the design of the "Navigate" group and the navigate buttons.
            SetReportingGroupDesign(ResourceProvider.GeneralItem.TXITEM_NavigateToNext.ToString(), m_rgNavigateGroup, "MergeResultsTab_Navigate")
            SetReportingButtonDesign(ResourceProvider.GeneralItem.TXITEM_NavigateToFirst.ToString(), m_rbtnFirstRecord, "MergeResultsTab_FirstRecord")
            SetReportingButtonDesign(ResourceProvider.GeneralItem.TXITEM_NavigateToPrevious.ToString(), m_rbtnPreviousRecord, "MergeResultsTab_PreviousRecord")
            SetReportingButtonDesign(ResourceProvider.GeneralItem.TXITEM_NavigateToNext.ToString(), m_rbtnNextRecord, "MergeResultsTab_NextRecord")
            SetReportingButtonDesign(ResourceProvider.GeneralItem.TXITEM_NavigateToLast.ToString(), m_rbtnLastRecord, "MergeResultsTab_LastRecord")

            ' Add the handlers to the navigate buttons to load the specified record when the button is clicked.
            AddHandler m_rbtnFirstRecord.Click, AddressOf FirstRecord_Click
            AddHandler m_rbtnPreviousRecord.Click, AddressOf PreviousRecord_Click
            AddHandler m_rbtnNextRecord.Click, AddressOf NextRecord_Click
            AddHandler m_rbtnLastRecord.Click, AddressOf LastRecord_Click

            ' Add the navigate buttons to the 'Result' tab's "Navigate" group.
            m_rgNavigateGroup.RibbonItems.AddRange(New RibbonButton() {m_rbtnFirstRecord, m_rbtnPreviousRecord, m_rbtnNextRecord, m_rbtnLastRecord})

            ' Add the "Navigate" group to the reporting 'Result' tab.
            m_rtMergeResultsTab.RibbonGroups.Add(m_rgNavigateGroup)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' CreateExportGroup Method
        ' Creates the reporting 'Result' tab's "Export" group.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub CreateExportGroup()
            ' Create the icons for the ribbon group and ribbon button.
            Dim bmpSmallIcon = GetSmallIcon("MergeAndExport_Small.svg")
            Dim bmpLargeIcon = GetLargeIcon("MergeAndExport_Large.svg")

            ' Set ribbon group design
            SetReportingGroupDesign(Nothing, m_rgExportGroup, "MergeResultsTab_Export")
            m_rgExportGroup.SmallIcon = bmpSmallIcon
            m_rgExportGroup.LargeIcon = bmpLargeIcon

            ' Add a ribbon button that opens a dialog to export the merge result.
            AddExportMergeResultButton(m_rgExportGroup, bmpSmallIcon, bmpLargeIcon)

            ' Add the ribbon group to the ribbon tab
            m_rtMergeResultsTab.RibbonGroups.Add(m_rgExportGroup)
        End Sub

        '-----------------------------------------------------------------------------------------------------
        ' SetReportingGroupDesign Method
        ' Sets the icons, text, key tip and settings for a specific RibbonGroup.
        '
        ' Parameters:
        '      identifier:		The id that is used as name and to identify the corresponding icons.
        '      ribbonGroup:	The ribbon group to update.
        '      resourceID:     The resource id that is used to identify the correponding text and key tip.
        '-----------------------------------------------------------------------------------------------------
        Private Sub SetReportingGroupDesign(ByVal identifier As String, ByVal ribbonGroup As RibbonGroup, ByVal resourceID As String)
            ' Set icons and the name of the ribbon group
            ribbonGroup.Name = identifier
            If Not String.IsNullOrEmpty(identifier) Then
                ribbonGroup.SmallIcon = ResourceProvider.GetSmallIcon(identifier, m_fDPI)
                ribbonGroup.LargeIcon = ResourceProvider.GetLargeIcon(identifier, m_fDPI)
            End If

            ' Set some group settings.
            ribbonGroup.IsAddToQuickAccessToolbarEnabled = False
            ribbonGroup.DialogBoxLauncher.Visible = False
            ribbonGroup.HorizontalContentAlignment = HorizontalAlignment.Center

            ' Set the ribbon group's text and key tip.
            ribbonGroup.Text = m_rmResources.GetString(resourceID)
            ribbonGroup.KeyTip = m_rmResources.GetString(resourceID & "_KeyTip")
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' AddExportMergeResultButton Method
        ' Creates a ribbon button that opens a dialog to export the merge result when clicked. That 
        ' ribbon button is added to the specified ribbon group. 
        '
        ' Parameters:
        '      ribbonGroup:    The ribbon group where to add the created ribbon button.
        '      smallIcon:      The bitmap that is used as the ribbon button's small icon.
        '      largeIcon:      The bitmap that is used as the ribbon button's large icon.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub AddExportMergeResultButton(ByVal ribbonGroup As RibbonGroup, ByVal smallIcon As Bitmap, ByVal largeIcon As Bitmap)

            ' Create the ribbon button
            m_rbtnExportMergeResult = New RibbonButton() With {
                .Text = My.Resources.ExportMergeResult,
                .SmallIcon = smallIcon,
                .LargeIcon = largeIcon,
                .KeyTip = My.Resources.ExportMergeResult_KeyTip
            }

            ' Add tool tips
            m_rbtnExportMergeResult.ToolTip.Title = My.Resources.ExportMergeResult_ToolTip_Title
            m_rbtnExportMergeResult.ToolTip.Description = My.Resources.ExportMergeResult_ToolTip_Description

            ' Add the handler that opens a dialog to export the merge result.
            AddHandler m_rbtnExportMergeResult.Click, AddressOf ExportMergeResult_Click

            ' Add the ribbon button to the ribbon group
            ribbonGroup.RibbonItems.Add(m_rbtnExportMergeResult)
        End Sub

        '-----------------------------------------------------------------------------------------------------
        ' SetReportingButtonDesign Method
        ' Sets the icons, text, key tip and tool tip for a specific RibbonButton.
        '
        ' Parameters:
        '      iconID:			The id that is used as name and to identify the corresponding icons.
        '      ribbonGroup:	The ribbon button to update.
        '      resourceID:     The resource id that is used to identify the correponding text, key tip and 
        '						tool tip
        '-----------------------------------------------------------------------------------------------------
        Private Sub SetReportingButtonDesign(ByVal identifier As String, ByVal ribbonButton As RibbonButton, ByVal resourceID As String)
            ' Set icons and the name of the ribbon button
            ribbonButton.Name = identifier
            ribbonButton.SmallIcon = ResourceProvider.GetSmallIcon(identifier, m_fDPI)
            ribbonButton.LargeIcon = ResourceProvider.GetLargeIcon(identifier, m_fDPI)

            ' Set the ribbon button's text, key tip and tool tip.
            ribbonButton.Text = m_rmResources.GetString(resourceID)
            ribbonButton.KeyTip = m_rmResources.GetString(resourceID & "_KeyTip")
            ribbonButton.ToolTip.Title = m_rmResources.GetString(resourceID & "_ToolTip_Title")
            ribbonButton.ToolTip.Description = m_rmResources.GetString(resourceID & "_ToolTip_Description")

            ' Add the button to the list of custom ribbon buttons that are updated when the application's
            m_lstCustomRibbonButtons.Add(ribbonButton)
        End Sub
    End Class
End Namespace
