Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraBars.Docking
Imports System.Runtime.CompilerServices

Namespace Q139656
    Module DockPanelExtensions
        <Extension()> _
        Public Sub MoveToScreen(ByVal dockPanel As DockPanel, ByVal point As Point, ByVal screenIndex As Integer)
            dockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            If screenIndex < Screen.AllScreens.Length Then
                Dim screen As Screen = screen.AllScreens(screenIndex)
                point = New Point(screen.WorkingArea.X + point.X, screen.WorkingArea.Y + point.Y)
                dockPanel.MakeFloat(point)
            End If
        End Sub
    End Module
End Namespace