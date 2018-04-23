Imports Microsoft.VisualBasic
Imports System
Namespace Q139656
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
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
			Me.components = New System.ComponentModel.Container()
			Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
			Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.dockPanel1.SuspendLayout()
			Me.dockPanel2.SuspendLayout()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dockManager1
			' 
			Me.dockManager1.Form = Me
			Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.dockPanel1, Me.dockPanel2})
			Me.dockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
			' 
			' dockPanel1
			' 
			Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
			Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
			Me.dockPanel1.ID = New System.Guid("376f325a-ce81-49af-98bb-2ea0ef7ab602")
			Me.dockPanel1.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel1.Name = "dockPanel1"
			Me.dockPanel1.Size = New System.Drawing.Size(200, 543)
			Me.dockPanel1.Text = "dockPanel1"
			' 
			' dockPanel1_Container
			' 
			Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 25)
			Me.dockPanel1_Container.Name = "dockPanel1_Container"
			Me.dockPanel1_Container.Size = New System.Drawing.Size(194, 515)
			Me.dockPanel1_Container.TabIndex = 0
			' 
			' dockPanel2
			' 
			Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
			Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
			Me.dockPanel2.ID = New System.Guid("30cef882-66c0-4777-b7d2-96fab5cf47a2")
			Me.dockPanel2.Location = New System.Drawing.Point(634, 0)
			Me.dockPanel2.Name = "dockPanel2"
			Me.dockPanel2.Size = New System.Drawing.Size(200, 543)
			Me.dockPanel2.Text = "dockPanel2"
			' 
			' dockPanel2_Container
			' 
			Me.dockPanel2_Container.Location = New System.Drawing.Point(3, 25)
			Me.dockPanel2_Container.Name = "dockPanel2_Container"
			Me.dockPanel2_Container.Size = New System.Drawing.Size(194, 515)
			Me.dockPanel2_Container.TabIndex = 0
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(231, 498)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "Dock"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' radioGroup1
			' 
			Me.radioGroup1.Location = New System.Drawing.Point(352, 425)
			Me.radioGroup1.Name = "radioGroup1"
			Me.radioGroup1.Size = New System.Drawing.Size(211, 96)
			Me.radioGroup1.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(834, 543)
			Me.Controls.Add(Me.radioGroup1)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.dockPanel2)
			Me.Controls.Add(Me.dockPanel1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.dockPanel1.ResumeLayout(False)
			Me.dockPanel2.ResumeLayout(False)
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dockManager1 As DevExpress.XtraBars.Docking.DockManager
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private radioGroup1 As DevExpress.XtraEditors.RadioGroup
	End Class
End Namespace

