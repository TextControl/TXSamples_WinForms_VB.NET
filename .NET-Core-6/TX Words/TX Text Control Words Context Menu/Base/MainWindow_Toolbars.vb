'-----------------------------------------------------------------------------------------------------------
' MainWindow_Toolbars.vb File
'
' Description:
'      Customizes the style of the status bar and the ruler bars.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------

Namespace TXTextControl.Words
    Partial Class MainWindow

        '-----------------------------------------------------------------------------------------------------------
        ' M E T H O D S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' SetRulerBarsDesign Method
        ' Customize the RulerBars' style by colors.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetRulerBarsDesign()
            ' Horizontal ruler bar

            ' Vertical ruler bar
            m_rbHorizontalRulerBar.DisplayColors.GradientBackColor = CSharpImpl.Assign(m_rbHorizontalRulerBar.DisplayColors.BackColor, CSharpImpl.Assign(m_rbVerticalRulerBar.DisplayColors.GradientBackColor, CSharpImpl.Assign(m_rbVerticalRulerBar.DisplayColors.BackColor, Color.FromArgb(255, 245, 246, 247))))
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' SetStatusBarDesign Method
        ' Customize the StatusBar's style by setting texts and colors.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetStatusBarDesign()
            ' Status bar texts
            m_sbStatusBar.LineText = My.Resources.StatusBar_Line
            m_sbStatusBar.PageText = My.Resources.StatusBar_Page
            m_sbStatusBar.ColumnText = My.Resources.StatusBar_Column
            m_sbStatusBar.SectionText = My.Resources.StatusBar_Section

            ' Status bar colors
            m_sbStatusBar.DisplayColors.BackColorBottom = CSharpImpl.Assign(m_sbStatusBar.DisplayColors.BackColorMiddle, CSharpImpl.Assign(m_sbStatusBar.DisplayColors.BackColorTop, CSharpImpl.Assign(m_sbStatusBar.DisplayColors.FrameColor, CSharpImpl.Assign(m_sbStatusBar.DisplayColors.SeparatorColorLight, Color.FromArgb(255, 43, 86, 154)))))
            m_sbStatusBar.DisplayColors.ForeColor = Color.White
            m_sbStatusBar.DisplayColors.SeparatorColorDark = Color.White
        End Sub
    End Class
End Namespace
