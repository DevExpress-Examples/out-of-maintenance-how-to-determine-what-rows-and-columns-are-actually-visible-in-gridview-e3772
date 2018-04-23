using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            for (int i = 0; i < 10; i++)
            {
                tbl.Columns.Add(String.Format("Column{0}", i));
            }
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) });
            return tbl;
        }

        public Form1()
        {
            InitializeComponent();
            gridControl1.DataSource = CreateTable(200);
            scrollPreviewControl1.RegisterGridView(gridView1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateText();
        }
        private void UpdateText()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Top row=" + gridView1.GetTopVisibleRow());
            sb.AppendLine("Visible rows count=" + gridView1.GetVisibleRowCount());
            sb.AppendLine("Bottom row=" + gridView1.GetBottomVisibleRow());
            sb.AppendLine("First visible column=" + gridView1.GetFirstVisibleColumn());
            sb.AppendLine("Last visible column=" + gridView1.GetLastVisibleColumn());
            sb.AppendLine("Visible cells=" + gridView1.GetVisibleCells());
            label1.Text = sb.ToString();
        }
    }
}