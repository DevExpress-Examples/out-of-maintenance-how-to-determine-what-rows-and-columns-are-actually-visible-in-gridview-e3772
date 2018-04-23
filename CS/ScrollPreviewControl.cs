using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace WindowsApplication1
{
    public partial class ScrollPreviewControl : UserControl
    {
        private GridView _View;
        public ScrollPreviewControl()
        {
            InitializeComponent();
        }

        public void RegisterGridView(GridView view)
        {
            _View = view;
            view.TopRowChanged += new EventHandler(view_TopRowChanged);
            view.LeftCoordChanged += new EventHandler(view_LeftCoordChanged);
        }

        void view_LeftCoordChanged(object sender, EventArgs e)
        {
            OnViewScrolled();
        }

        void view_TopRowChanged(object sender, EventArgs e)
        {
            OnViewScrolled();
        }
        private void OnViewScrolled()
        {
            Invalidate();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_View != null)
            {
                Rectangle totalAreaRect = _View.GetAllCellsArea();
                double dx = Width * 1.0 / totalAreaRect.Width;
                double dy = Height * 1.0 / totalAreaRect.Height;
                Rectangle rect = _View.GetVisibleCells();
                rect.Y = Convert.ToInt32(rect.Y * dy);
                rect.Height = Convert.ToInt32( rect.Height * dy);
                rect.Width =  Convert.ToInt32(rect.Width * dx);
                rect.X = Convert.ToInt32( rect.X * dx);
                e.Graphics.DrawRectangle(Pens.Red, rect);
            }
        }
     
    }
}
