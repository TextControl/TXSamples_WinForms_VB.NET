'-----------------------------------------------------------------------------------------------------------
' MainWindow_ViewMenuItem_DropDownOpening.vb File
'
' Description: Provides all DropDownOpening handlers associated with 'View' menu items.
'     
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------

Namespace TXTextControl.Words
    Partial Class MainWindow
        '-----------------------------------------------------------------------------------------------------------
        ' View_DropDownOpening Handler
        '
        ' Updates the checked state of 'View' drop down menu items.
        ' 
        ' Item: 'View'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub View_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs)
            ' 'Page Layout'
            m_tmiView_PageLayout.Checked = m_txTextControl.ViewMode = ViewMode.PageView

            ' 'Draft'
            m_tmiView_Draft.Checked = m_txTextControl.ViewMode = ViewMode.Normal

            ' 'Button Bar'
            m_tmiView_ButtonBar.Checked = m_bbButtonBar.Visible

            ' 'Status Bar'
            m_tmiView_StatusBar.Checked = m_sbStatusBar.Visible

            ' 'Horizontal Ruler'
            m_tmiView_HorizontalRuler.Checked = m_rbHorizontalRulerBar.Visible

            ' 'Vertical Ruler'
            m_tmiView_VerticalRuler.Checked = m_rbVerticalRulerBar.Visible

            ' 'Table Gridlines'
            m_tmiView_TableGridlines.Checked = m_txTextControl.Tables.GridLines

            ' 'Bookmark Markers'
            m_tmiView_BookmarkMarkers.Checked = m_txTextControl.DocumentTargetMarkers

            ' 'Text Frame Marker Lines'
            m_tmiView_TextFrameMarkerLines.Checked = m_txTextControl.TextFrameMarkerLines

            ' 'Drawing Marker Lines'
            m_tmiView_DrawingMarkerLines.Checked = m_txTextControl.DrawingMarkerLines

            If m_plTXLicense >= VersionInfo.ProductLevel.Professional Then
                ' 'Tracked Changes'

                ' Step through all tracked changes to get their common highlight mode.
                Dim colTrackedChanges As TrackedChangeCollection = m_txTextControl.TrackedChanges
                Dim iCount As Integer = colTrackedChanges.Count
                Dim hmCurrentHighlightMode As HighlightMode = HighlightMode.Always
                Dim i As Integer
                For i = 1 To iCount - 1
                    hmCurrentHighlightMode = colTrackedChanges(i).HighlightMode
                    ' Check whether the current tracked change highlight mode differs to the next one's
                    If hmCurrentHighlightMode <> colTrackedChanges(i + 1).HighlightMode Then
                        ' In that case set the 'Tracked Changes' item's checked state to CheckState.Indeterminate
                        m_tmiView_TrackedChanges.CheckState = CheckState.Indeterminate
                        Return
                    End If
                Next

                ' The 'Tracked Changes' item is checked if the highlight mode of all tracked changes
                ' is set to HighlightMode.Always
                m_tmiView_TrackedChanges.Checked = hmCurrentHighlightMode = HighlightMode.Always
            End If

            ' 'Right to Left Layout'
            m_tmiView_RightToLeftLayout.Checked = RightToLeftLayout

        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' View_EditableRegions_DropDownOpening Handler
        '
        ' Updates the checked state of 'Editable Regions' drop down menu items.
        ' 
        ' Item: 'Editable Regions'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub View_EditableRegions_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs)
            ' Set the check states of the 'Editable Regions' drop down items.
            Dim hmHighlightMode As HighlightMode = m_txTextControl.EditableRegionHighlightMode
            m_tmiView_EditableRegions_Always.Checked = hmHighlightMode = HighlightMode.Always
            m_tmiView_EditableRegions_Current.Checked = hmHighlightMode = HighlightMode.Activated
            m_tmiView_EditableRegions_Never.Checked = hmHighlightMode = HighlightMode.Never
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' View_Comments_DropDownOpening Handler
        '
        ' Updates the checked state of 'Comments' drop down menu items.
        ' 
        ' Item: 'Comments'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub View_Comments_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs)
            ' Set the check states of the 'Comments' drop down items.
            Dim hmHighlightMode As HighlightMode = m_txTextControl.CommentHighlightMode
            m_tmiView_Comments_Always.Checked = hmHighlightMode = HighlightMode.Always
            m_tmiView_Comments_Current.Checked = hmHighlightMode = HighlightMode.Activated
            m_tmiView_Comments_Never.Checked = hmHighlightMode = HighlightMode.Never
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' View_Zoom_DropDownOpening Handler
        '
        ' Updates the checked state of 'Zoom' drop down menu items.
        ' 
        ' Item: 'Zoom'
        '-----------------------------------------------------------------------------------------------------------
        Private Sub View_Zoom_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs)
            ' Set the check states of the 'Zoom' drop down items.
            Dim strZoomFactor As String = m_txTextControl.ZoomFactor.ToString()
            For Each item As ToolStripMenuItem In m_tmiView_Zoom.DropDownItems
                item.Checked = Equals(item.Tag.ToString(), strZoomFactor)
            Next
        End Sub
    End Class
End Namespace
