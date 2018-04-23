Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			For i As Integer = 0 To 9
				tbl.Columns.Add(String.Format("Column{0}", i))
			Next i
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) })
			Next i
			Return tbl
		End Function

		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = CreateTable(200)
			scrollPreviewControl1.RegisterGridView(gridView1)
		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			UpdateText()
		End Sub
		Private Sub UpdateText()
			Dim sb As New StringBuilder()
            sb.AppendLine(String.Format("Top row={0}", gridView1.GetTopVisibleRow()))
            sb.AppendLine(String.Format("Visible rows count={0}", gridView1.GetVisibleRowCount()))
            sb.AppendLine(String.Format("Bottom row={0}", gridView1.GetBottomVisibleRow()))
            sb.AppendLine(String.Format("First visible column={0}", gridView1.GetFirstVisibleColumn()))
            sb.AppendLine(String.Format("Last visible column={0}", gridView1.GetLastVisibleColumn()))
            sb.AppendLine(String.Format("Visible cells={0}", gridView1.GetVisibleCells()))
			label1.Text = sb.ToString()
		End Sub
	End Class
End Namespace