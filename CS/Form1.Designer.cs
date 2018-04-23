namespace WindowsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.scrollPreviewControl1 = new WindowsApplication1.ScrollPreviewControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(487, 481);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.scrollPreviewControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(487, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(271, 481);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 256);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // scrollPreviewControl1
            // 
            this.scrollPreviewControl1.BackColor = System.Drawing.Color.White;
            this.scrollPreviewControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.scrollPreviewControl1.Location = new System.Drawing.Point(2, 21);
            this.scrollPreviewControl1.Name = "scrollPreviewControl1";
            this.scrollPreviewControl1.Size = new System.Drawing.Size(267, 202);
            this.scrollPreviewControl1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 481);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private ScrollPreviewControl scrollPreviewControl1;
    }
}

