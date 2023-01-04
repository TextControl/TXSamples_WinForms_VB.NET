'-----------------------------------------------------------------------------------------------------------
' MainWindow_Sidebars.vb File
'
' Description:
'     Manages the layout of the sidebars when the content layout changed.
'
' copyright:		© Text Control GmbH
'-----------------------------------------------------------------------------------------------------------
Imports TXTextControl.Windows.Forms

Namespace TXTextControl.Words
    Partial Class MainWindow

        '-----------------------------------------------------------------------------------------------------------
        ' M E T H O D S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' SetSidebarBehavior Method
        ' Connects the sidebars with the corresponding PropertyChanged handlers.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SetSidebarBehavior()
            ' Left sidebar:
            AddHandler m_sbSidebarLeft.PropertyChanged, AddressOf SidebarLeft_PropertyChanged

            ' Right sidebar:
            AddHandler m_sbSidebarRight.PropertyChanged, AddressOf SidebarRight_PropertyChanged

            ' Bottom sidebar:
            AddHandler m_sbSidebarBottom.PropertyChanged, AddressOf SidebarBottom_PropertyChanged
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' H A N D L E R S
        '-----------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------
        ' SidebarLeft_PropertyChanged Handler
        ' Manages the layout of the left sidebar if its ContentLayout is set to About. 
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SidebarLeft_PropertyChanged(ByVal sender As Object, ByVal e As ComponentModel.PropertyChangedEventArgs)
            Select Case e.PropertyName
                Case "ContentLayout"
                    Select Case m_sbSidebarLeft.ContentLayout
                        Case Sidebar.SidebarContentLayout.About
                            m_sbSidebarLeft.ShowPinButton = False
                            m_sbSidebarLeft.IsPinned = True
                    End Select
                Case "IsShown"
                    m_rtbtnAbout.Checked = m_sbSidebarLeft.ContentLayout = Sidebar.SidebarContentLayout.About AndAlso m_sbSidebarLeft.IsShown
            End Select
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' SidebarRight_PropertyChanged Handler
        ' Manages the layout of the right sidebar if its ContentLayout is set to Styles, Comments, TrackedChanges,
        ' Find or Replace.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SidebarRight_PropertyChanged(ByVal sender As Object, ByVal e As ComponentModel.PropertyChangedEventArgs)
            If Equals(e.PropertyName, "ContentLayout") Then
                Select Case m_sbSidebarRight.ContentLayout
                    Case Sidebar.SidebarContentLayout.Styles
                        m_sbSidebarRight.ShowPinButton = False
                        m_sbSidebarRight.IsPinned = True
                        m_sbSidebarRight.DialogStyle = Sidebar.SidebarDialogStyle.Standard
                    Case Sidebar.SidebarContentLayout.Comments, Sidebar.SidebarContentLayout.TrackedChanges
                        m_sbSidebarRight.ShowPinButton = True
                        m_sbSidebarRight.DialogStyle = Sidebar.SidebarDialogStyle.StandardSizable
                    Case Else
                        ' Find or Replace
                        m_sbSidebarRight.ShowPinButton = True
                        m_sbSidebarRight.DialogStyle = Sidebar.SidebarDialogStyle.Standard
                End Select
            End If
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' SidebarBottom_PropertyChanged Handler
        ' Manages the layout of the bottom sidebar if its ContentLayout is set to TrackedChanges, Comments, Find,
        ' Replace and GoTo.
        '-----------------------------------------------------------------------------------------------------------
        Private Sub SidebarBottom_PropertyChanged(ByVal sender As Object, ByVal e As ComponentModel.PropertyChangedEventArgs)
            If Equals(e.PropertyName, "ContentLayout") Then
                Select Case m_sbSidebarBottom.ContentLayout
                    Case Sidebar.SidebarContentLayout.TrackedChanges, Sidebar.SidebarContentLayout.Comments
                        m_sbSidebarBottom.ShowTitle = True
                        m_sbSidebarBottom.DialogStyle = Sidebar.SidebarDialogStyle.StandardSizable
                    Case Else
                        ' Find, Replace and GoTo
                        m_sbSidebarBottom.ShowTitle = False
                        m_sbSidebarBottom.DialogStyle = Sidebar.SidebarDialogStyle.Standard
                End Select
            End If
        End Sub
    End Class
End Namespace
