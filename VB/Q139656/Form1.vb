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
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			For i As Integer = 0 To Screen.AllScreens.Length - 1
				radioGroup1.Properties.Items.Add(New RadioGroupItem(i, "Screen #" & i.ToString()))
			Next i
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			dockPanel1.MoveToScreen(New Point(100, 100), radioGroup1.SelectedIndex)
		End Sub
	End Class
End Namespace