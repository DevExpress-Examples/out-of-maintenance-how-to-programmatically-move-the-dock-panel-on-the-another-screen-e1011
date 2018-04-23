Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraBars.Docking

Namespace Q139656
	Public Module DockPanelExtension
		<System.Runtime.CompilerServices.Extension> _
		Public Sub MoveToScreen(ByVal dockPanel As DockPanel, ByVal point As Point, ByVal screenIndex As Integer)
			If screenIndex < 0 OrElse screenIndex >= Screen.AllScreens.Length Then
				Return
			End If
			dockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
			If screenIndex < Screen.AllScreens.Length Then
				Dim screen As Screen = Screen.AllScreens(screenIndex)
				point = New Point(screen.WorkingArea.X + point.X, screen.WorkingArea.Y + point.Y)
				dockPanel.MakeFloat(point)
			End If
		End Sub
	End Module
End Namespace
