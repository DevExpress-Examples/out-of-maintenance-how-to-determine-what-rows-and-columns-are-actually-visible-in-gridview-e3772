Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
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
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.label1 = New System.Windows.Forms.Label()
			Me.scrollPreviewControl1 = New WindowsApplication1.ScrollPreviewControl()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(487, 481)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.ColumnAutoWidth = False
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick);
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.label1)
			Me.groupControl1.Controls.Add(Me.scrollPreviewControl1)
			Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Right
			Me.groupControl1.Location = New System.Drawing.Point(487, 0)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(271, 481)
			Me.groupControl1.TabIndex = 1
			Me.groupControl1.Text = "groupControl1"
			' 
			' label1
			' 
			Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.label1.Location = New System.Drawing.Point(2, 223)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(267, 256)
			Me.label1.TabIndex = 2
			Me.label1.Text = "label1"
			' 
			' scrollPreviewControl1
			' 
			Me.scrollPreviewControl1.BackColor = System.Drawing.Color.White
			Me.scrollPreviewControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.scrollPreviewControl1.Location = New System.Drawing.Point(2, 21)
			Me.scrollPreviewControl1.Name = "scrollPreviewControl1"
			Me.scrollPreviewControl1.Size = New System.Drawing.Size(267, 202)
			Me.scrollPreviewControl1.TabIndex = 3
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(758, 481)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.groupControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private label1 As System.Windows.Forms.Label
		Private scrollPreviewControl1 As ScrollPreviewControl
	End Class
End Namespace

