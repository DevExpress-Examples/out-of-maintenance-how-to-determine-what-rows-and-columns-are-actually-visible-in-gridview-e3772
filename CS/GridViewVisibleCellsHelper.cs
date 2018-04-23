using System;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;
using System.Drawing;

namespace WindowsApplication1
{
    public static class GridViewVisibleCellsHelper
    {

        public static GridViewInfo GetViewInfo(GridView view)
        {
            return view.GetViewInfo() as GridViewInfo;
        }
        public static int GetTopVisibleRow(this GridView view)
        {
            return view.TopRowIndex;
        }

        public static int GetVisibleRowCount(this GridView view)
        {
            return GetViewInfo(view).RowsLoadInfo.ResultRowCount;
        }
        public static int GetBottomVisibleRow(this GridView view)
        {
            int visibleRowsCount = GetVisibleRowCount(view);
            return view.GetTopVisibleRow() + visibleRowsCount - 1;
        }

        public static GridColumn GetFirstVisibleColumn(this GridView view)
        {
            return GetViewInfo(view).ColumnsInfo.FirstColumnInfo.Column;
        }

        public static GridColumn GetLastVisibleColumn(this GridView view)
        {
            return GetViewInfo(view).ColumnsInfo.LastColumnInfo.Column;
        }

        public static Rectangle GetVisibleCells(this GridView view)
        {
            int x = view.GetFirstVisibleColumn().VisibleIndex;
            int y = view.GetTopVisibleRow();
            int width = view.GetLastVisibleColumn().VisibleIndex - x;
            int height = view.GetBottomVisibleRow() - y;
            return new Rectangle(x, y, width, height);
        }

        public static Rectangle GetAllCellsArea(this GridView view)
        {
            int x = 0;
            int y = 0;
            int width = view.VisibleColumns.Count;
            int height =view.RowCount;
            return new Rectangle(x, y, width, height);
        }
    }
}
