Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid

Namespace WindowsApplication1
	Partial Public Class ScrollPreviewControl
		Inherits UserControl
		Private _View As GridView
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub RegisterGridView(ByVal view As GridView)
			_View = view
			AddHandler view.TopRowChanged, AddressOf view_TopRowChanged
			AddHandler view.LeftCoordChanged, AddressOf view_LeftCoordChanged
		End Sub

		Private Sub view_LeftCoordChanged(ByVal sender As Object, ByVal e As EventArgs)
			OnViewScrolled()
		End Sub

		Private Sub view_TopRowChanged(ByVal sender As Object, ByVal e As EventArgs)
			OnViewScrolled()
		End Sub
		Private Sub OnViewScrolled()
			Invalidate()
		End Sub


		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			MyBase.OnPaint(e)
			If _View IsNot Nothing Then
				Dim totalAreaRect As Rectangle = _View.GetAllCellsArea()
				Dim dx As Double = Width * 1.0 / totalAreaRect.Width
				Dim dy As Double = Height * 1.0 / totalAreaRect.Height
				Dim rect As Rectangle = _View.GetVisibleCells()
				rect.Y = Convert.ToInt32(rect.Y * dy)
				rect.Height = Convert.ToInt32(rect.Height * dy)
				rect.Width = Convert.ToInt32(rect.Width * dx)
				rect.X = Convert.ToInt32(rect.X * dx)
				e.Graphics.DrawRectangle(Pens.Red, rect)
			End If
		End Sub

	End Class
End Namespace
