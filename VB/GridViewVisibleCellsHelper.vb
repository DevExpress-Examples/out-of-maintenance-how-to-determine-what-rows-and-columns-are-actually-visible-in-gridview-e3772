Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports System.Drawing

Namespace WindowsApplication1
	Public  Module GridViewVisibleCellsHelper

		
		Public  Function GetViewInfo(ByVal view As GridView) As GridViewInfo
			Return TryCast(view.GetViewInfo(), GridViewInfo)
		End Function
		<System.Runtime.CompilerServices.Extension> _
		Public  Function GetTopVisibleRow(ByVal view As GridView) As Integer
			Return view.TopRowIndex
		End Function

		<System.Runtime.CompilerServices.Extension> _
		Public  Function GetVisibleRowCount(ByVal view As GridView) As Integer
			Return GetViewInfo(view).RowsLoadInfo.ResultRowCount
		End Function
		<System.Runtime.CompilerServices.Extension> _
		Public  Function GetBottomVisibleRow(ByVal view As GridView) As Integer
			Dim visibleRowsCount As Integer = GetVisibleRowCount(view)
			Return view.GetTopVisibleRow() + visibleRowsCount - 1
		End Function

		<System.Runtime.CompilerServices.Extension> _
		Public  Function GetFirstVisibleColumn(ByVal view As GridView) As GridColumn
			Return GetViewInfo(view).ColumnsInfo.FirstColumnInfo.Column
		End Function

		<System.Runtime.CompilerServices.Extension> _
		Public  Function GetLastVisibleColumn(ByVal view As GridView) As GridColumn
			Return GetViewInfo(view).ColumnsInfo.LastColumnInfo.Column
		End Function

		<System.Runtime.CompilerServices.Extension> _
		Public  Function GetVisibleCells(ByVal view As GridView) As Rectangle
			Dim x As Integer = view.GetFirstVisibleColumn().VisibleIndex
			Dim y As Integer = view.GetTopVisibleRow()
			Dim width As Integer = view.GetLastVisibleColumn().VisibleIndex - x
			Dim height As Integer = view.GetBottomVisibleRow() - y
			Return New Rectangle(x, y, width, height)
		End Function

		<System.Runtime.CompilerServices.Extension> _
		Public  Function GetAllCellsArea(ByVal view As GridView) As Rectangle
			Dim x As Integer = 0
			Dim y As Integer = 0
			Dim width As Integer = view.VisibleColumns.Count
			Dim height As Integer =view.RowCount
			Return New Rectangle(x, y, width, height)
		End Function
	End Module
End Namespace
