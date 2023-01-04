'-----------------------------------------------------------------------------------------------------------
' MainWindow_ContextualTabs.vb File
'
' Description:
'     Handles showing/hiding contextual tabs.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Imports TXTextControl.DataVisualization

Namespace TXTextControl.Words
    Partial Class MainWindow

        '-----------------------------------------------------------------------------------------------------------
        ' M E T H O D S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' SetContextualTabsBehavior Method
        ' Sets the header of the contextual tabs and adds all necessary handlers to the TextControl.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetContextualTabsBehavior()
            ' Frame Tools:
            m_ctgFrameTools.Header = My.Resources.ContextualTabGroup_FrameTools ' Set Frame Tools header
            m_ctgFrameTools.ContextualTabs.Remove(m_rtRibbonChartLayoutTab) ' Remove Chart Layout Tab from Frame Tools group

            ' Connect all necessary handlers to act as a Frame Tools group
            AddHandler m_txTextControl.FrameSelected, AddressOf TextControl_FrameSelected
            AddHandler m_txTextControl.FrameDeselected, AddressOf TextControl_FrameDeselected
            AddHandler m_txTextControl.DrawingActivated, AddressOf TextControl_DrawingActivated
            AddHandler m_txTextControl.DrawingDeactivated, AddressOf TextControl_DrawingDeactivated

            ' Table Tools:
            m_ctgTableTools.Header = My.Resources.ContextualTabGroup_TableTools ' Set Table Tools header

            ' Connect all necessary handlers to act as a Table Tools group
            AddHandler m_txTextControl.InputPositionChanged, AddressOf TextControl_InputPositionChanged
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' H A N D L E R S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' TextControl_InputPositionChanged Handler
        ' Checks whether the input position is in a table and makes the table layout tab visible.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub TextControl_InputPositionChanged(ByVal sender As Object, ByVal e As EventArgs)
            m_ctgTableTools.Visible = m_txTextControl.Tables.GetItem() IsNot Nothing
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' TextControl_FrameSelected Handler
        ' A frame has been selected. In this case make the frame layout tab visible.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub TextControl_FrameSelected(ByVal sender As Object, ByVal e As FrameEventArgs)
            ' Check whether the selected frame is an object of type ChartFrame
            If TypeOf e.Frame Is ChartFrame Then
                m_ctgFrameTools.Header = My.Resources.ContextualTabGroup_ChartTools ' Update group header
                If Not m_ctgFrameTools.ContextualTabs.Contains(m_rtRibbonChartLayoutTab) Then
                    ' Because Frame Tools group does not contain the chart layout tab, it is added.
                    m_ctgFrameTools.ContextualTabs.Add(m_rtRibbonChartLayoutTab)
                End If
            End If
            ' show the Frame Tools group
            m_ctgFrameTools.Visible = True
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' TextControl_FrameDeselected Handler
        ' Makes the frame layout tab invisible. When a new frame is selected, the FrameSelected event of the
        ' new frame occurs before the FrameDeselected event of the old frame. Therefore it must be checked
        ' whether a new frame is selected. When a drawing is activated, the tab must also remain visible.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub TextControl_FrameDeselected(ByVal sender As Object, ByVal e As FrameEventArgs)
            Dim fbFrame As FrameBase = m_txTextControl.Frames.GetItem()
            If TypeOf e.Frame Is ChartFrame AndAlso Not (TypeOf fbFrame Is ChartFrame) Then
                ' The deselected frame is an object of type ChartFrame and but not the current frame.
                ' In this case remove the chart layout tab and reset the Frame Tools group's header text.
                m_ctgFrameTools.ContextualTabs.Remove(m_rtRibbonChartLayoutTab)
                m_ctgFrameTools.Header = My.Resources.ContextualTabGroup_FrameTools
            End If
            If fbFrame Is Nothing AndAlso m_txTextControl.Drawings.GetActivatedItem() Is Nothing Then
                ' If no frame is selected and no drawing is activated, hide the Frame Tools group
                m_ctgFrameTools.Visible = False
            End If
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' TextControl_DrawingActivated Handler
        ' When a drawing is activated, the contained shapes can also be formatted with the RibbonFrameLayoutTab.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub TextControl_DrawingActivated(ByVal sender As Object, ByVal e As DrawingEventArgs)
            ' Show the Frame Tools group if the drawing is activated.
            m_ctgFrameTools.Visible = True
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' TextControl_DrawingDeactivated Handler
        ' Makes the frame layout tab invisible. When a frame is selected or another drawing is activated
        ' the tab must remain visible.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub TextControl_DrawingDeactivated(ByVal sender As Object, ByVal e As DrawingEventArgs)
            If m_txTextControl.Frames.GetItem() Is Nothing AndAlso m_txTextControl.Drawings.GetActivatedItem() Is Nothing Then
                ' Hide the Frame Tools group if the drawing is deactivated and no other frame is selected.
                m_ctgFrameTools.Visible = False
            End If
        End Sub
    End Class
End Namespace
