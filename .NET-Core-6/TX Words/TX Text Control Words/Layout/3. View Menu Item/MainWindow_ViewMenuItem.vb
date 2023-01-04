'-----------------------------------------------------------------------------------------------------------
' MainWindow_ViewMenuItem.vb File
'
' Description: Provides methods to set the layout and behavior of the 'View' menu items.
'     
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------

Namespace TXTextControl.Words
    Partial Class MainWindow
        '-----------------------------------------------------------------------------------------------------------
        ' SetViewItemsTexts Method
        '
        ' Sets the texts of the 'View' menu items.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetViewItemsTexts()
            ' 'View'
            SetItemText(m_tmiView)

            ' 'Page Layout'
            SetItemText(m_tmiView_PageLayout)

            ' 'Draft'
            SetItemText(m_tmiView_Draft)

            ' 'Button Bar'
            SetItemText(m_tmiView_ButtonBar)

            ' 'Status Bar'
            SetItemText(m_tmiView_StatusBar)

            ' 'Horizontal Ruler'
            SetItemText(m_tmiView_HorizontalRuler)

            ' 'Vertical Ruler'
            SetItemText(m_tmiView_VerticalRuler)

            ' 'Table Gridlines'
            SetItemText(m_tmiView_TableGridlines)

            ' 'Bookmark Markers'
            SetItemText(m_tmiView_BookmarkMarkers)

            ' 'Text Frame Marker Lines'
            SetItemText(m_tmiView_TextFrameMarkerLines)

            ' 'Drawing Marker Lines'
            SetItemText(m_tmiView_DrawingMarkerLines)

            ' 'Control Chars'
            SetItemText(m_tmiView_ControlChars)

            ' 'Editable Regions'
            SetItemText(m_tmiView_EditableRegions)
            SetItemText(m_tmiView_EditableRegions_Always)
            SetItemText(m_tmiView_EditableRegions_Current)
            SetItemText(m_tmiView_EditableRegions_Never)

            ' 'Tracked Changes'
            SetItemText(m_tmiView_TrackedChanges)

            ' 'Comments'
            SetItemText(m_tmiView_Comments)
            SetItemText(m_tmiView_Comments_Always)
            SetItemText(m_tmiView_Comments_Current)
            SetItemText(m_tmiView_Comments_Never)

            ' 'Zoom'
            SetItemText(m_tmiView_Zoom)
            SetItemText(m_tmiView_Zoom_50, My.Resources.Item_View_Zoom_Factor_Text, "&50")
            SetItemText(m_tmiView_Zoom_75, My.Resources.Item_View_Zoom_Factor_Text, "&75")
            SetItemText(m_tmiView_Zoom_100, My.Resources.Item_View_Zoom_Factor_Text, "&100")
            SetItemText(m_tmiView_Zoom_150, My.Resources.Item_View_Zoom_Factor_Text, "15&0")
            SetItemText(m_tmiView_Zoom_200, My.Resources.Item_View_Zoom_Factor_Text, "&200")
            SetItemText(m_tmiView_Zoom_300, My.Resources.Item_View_Zoom_Factor_Text, "&300")
            SetItemText(m_tmiView_Zoom_400, My.Resources.Item_View_Zoom_Factor_Text, "&400")

            ' 'Right to Left Layout'
            SetItemText(m_tmiView_RightToLeftLayout)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' SetViewItemsImages Method
        '
        ' Sets the images of the 'View' menu items.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetViewItemsImages()
            ' 'Page Layout'
            SetItemImage(m_tmiView_PageLayout, Windows.Forms.Ribbon.RibbonViewTab.RibbonItem.TXITEM_PrintLayout.ToString())

            ' 'Draft'
            SetItemImage(m_tmiView_Draft, Windows.Forms.Ribbon.RibbonViewTab.RibbonItem.TXITEM_Draft.ToString())

            ' 'Table Gridlines'
            SetItemImage(m_tmiView_TableGridlines, Windows.Forms.Ribbon.RibbonViewTab.RibbonItem.TXITEM_ShowTableGridlines.ToString())

            ' 'Bookmark Markers'
            SetItemImage(m_tmiView_BookmarkMarkers, Windows.Forms.Ribbon.RibbonViewTab.RibbonItem.TXITEM_ShowBookmarkMarkers.ToString())

            ' 'Text Frame Marker Lines'
            SetItemImage(m_tmiView_TextFrameMarkerLines, Windows.Forms.Ribbon.RibbonViewTab.RibbonItem.TXITEM_ShowTextFrameMarkersLines.ToString())

            ' 'Drawing Marker Lines'
            SetItemImage(m_tmiView_DrawingMarkerLines, Windows.Forms.Ribbon.RibbonViewTab.RibbonItem.TXITEM_ShowDrawingFrameMarkersLines.ToString())

            ' 'Control Chars'
            SetItemImage(m_tmiView_ControlChars, Windows.Forms.Ribbon.RibbonViewTab.RibbonItem.TXITEM_ShowControlChars.ToString())

            ' 'Editable Regions'
            SetItemImage(m_tmiView_EditableRegions, Windows.Forms.Ribbon.RibbonPermissionsTab.RibbonItem.TXITEM_HighlightEditableRegions.ToString())

            ' 'Tracked Changes'
            SetItemImage(m_tmiView_TrackedChanges, Windows.Forms.Ribbon.RibbonProofingTab.RibbonItem.TXITEM_TrackChanges.ToString())

            ' 'Comments'
            SetItemImage(m_tmiView_Comments, Windows.Forms.Ribbon.RibbonProofingTab.RibbonItem.TXITEM_CommentsViewMode.ToString())

            ' 'Zoom'
            SetItemImage(m_tmiView_Zoom, Windows.Forms.Ribbon.RibbonViewTab.RibbonItem.TXITEM_ZoomFactor.ToString())

            ' 'Right to Left Layout'
            m_tmiView_RightToLeftLayout.Image = GetSmallIcon("RightToLeft_Small.svg")
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' ConnectViewItemsHandlers Method
        '
        ' Connects the 'View' menu items to Click and DropDownOpening handlers.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub ConnectViewItemsHandlers()
            ' 'Page Layout'
            AddHandler m_tmiView_PageLayout.Click, AddressOf View_PageLayout_Click

            ' 'Draft'
            AddHandler m_tmiView_Draft.Click, AddressOf View_Draft_Click

            ' 'Button Bar'
            AddHandler m_tmiView_ButtonBar.Click, AddressOf View_ButtonBar_Click

            ' 'Status Bar'
            AddHandler m_tmiView_StatusBar.Click, AddressOf View_StatusBar_Click

            ' 'Horizontal Ruler'
            AddHandler m_tmiView_HorizontalRuler.Click, AddressOf View_HorizontalRuler_Click

            ' 'Vertical Ruler'
            AddHandler m_tmiView_VerticalRuler.Click, AddressOf View_VerticalRuler_Click

            ' 'Table Gridlines'
            AddHandler m_tmiView_TableGridlines.Click, AddressOf View_TableGridlines_Click

            ' 'Bookmark Markers'
            AddHandler m_tmiView_BookmarkMarkers.Click, AddressOf View_BookmarkMarkers_Click

            ' 'Text Frame Marker Lines'
            AddHandler m_tmiView_TextFrameMarkerLines.Click, AddressOf View_TextFrameMarkerLines_Click

            ' 'Drawing Marker Lines'
            AddHandler m_tmiView_DrawingMarkerLines.Click, AddressOf View_DrawingMarkerLines_Click

            ' 'Control Chars'
            AddHandler m_tmiView_ControlChars.Click, AddressOf View_ControlChars_Click

            ' 'Editable Regions'
            AddHandler m_tmiView_EditableRegions_Always.Click, AddressOf View_EditableRegions_Always_Click
            AddHandler m_tmiView_EditableRegions_Current.Click, AddressOf View_EditableRegions_Current_Click
            AddHandler m_tmiView_EditableRegions_Never.Click, AddressOf View_EditableRegions_Never_Click

            ' 'Tracked Changes'
            AddHandler m_tmiView_TrackedChanges.Click, AddressOf View_TrackedChanges_Click

            ' 'Comments'
            AddHandler m_tmiView_Comments_Always.Click, AddressOf View_Comments_Always_Click
            AddHandler m_tmiView_Comments_Current.Click, AddressOf View_Comments_Current_Click
            AddHandler m_tmiView_Comments_Never.Click, AddressOf View_Comments_Never_Click

            ' 'Zoom'
            For Each item As ToolStripMenuItem In m_tmiView_Zoom.DropDownItems
                AddHandler item.Click, AddressOf View_Zoom_MenuItem_Click
            Next

            ' 'Right to Left Layout'
            AddHandler m_tmiView_RightToLeftLayout.Click, AddressOf View_RightToLeftLayout_Click


            ' DropDownOpening Handlers
            AddHandler m_tmiView.DropDownOpening, AddressOf View_DropDownOpening
            AddHandler m_tmiView_EditableRegions.DropDownOpening, AddressOf View_EditableRegions_DropDownOpening
            AddHandler m_tmiView_Comments.DropDownOpening, AddressOf View_Comments_DropDownOpening
            AddHandler m_tmiView_Zoom.DropDownOpening, AddressOf View_Zoom_DropDownOpening
        End Sub
    End Class
End Namespace
