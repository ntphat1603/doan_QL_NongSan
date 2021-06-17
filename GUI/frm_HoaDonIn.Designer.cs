
namespace GUI
{
    partial class frm_HoaDonIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HoaDonIn));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.hoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NONG_SANDataSet3 = new GUI.QL_NONG_SANDataSet3();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmahd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmakh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenkh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmanv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngayban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_mahd = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.hoadonTableAdapter = new GUI.QL_NONG_SANDataSet3TableAdapters.hoadonTableAdapter();
            this.btn_in = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NONG_SANDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mahd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btn_in);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.txt_mahd);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(346, 7, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(432, 260);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.hoadonBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 52);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(408, 196);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // hoadonBindingSource
            // 
            this.hoadonBindingSource.DataMember = "hoadon";
            this.hoadonBindingSource.DataSource = this.qL_NONG_SANDataSet3;
            // 
            // qL_NONG_SANDataSet3
            // 
            this.qL_NONG_SANDataSet3.DataSetName = "QL_NONG_SANDataSet3";
            this.qL_NONG_SANDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmahd,
            this.colmakh,
            this.coltenkh,
            this.colmanv,
            this.colngayban});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // colmahd
            // 
            this.colmahd.FieldName = "mahd";
            this.colmahd.Name = "colmahd";
            this.colmahd.OptionsColumn.AllowEdit = false;
            this.colmahd.Visible = true;
            this.colmahd.VisibleIndex = 0;
            // 
            // colmakh
            // 
            this.colmakh.FieldName = "makh";
            this.colmakh.Name = "colmakh";
            this.colmakh.OptionsColumn.AllowEdit = false;
            this.colmakh.Visible = true;
            this.colmakh.VisibleIndex = 1;
            // 
            // coltenkh
            // 
            this.coltenkh.FieldName = "tenkh";
            this.coltenkh.Name = "coltenkh";
            this.coltenkh.OptionsColumn.AllowEdit = false;
            this.coltenkh.Visible = true;
            this.coltenkh.VisibleIndex = 2;
            // 
            // colmanv
            // 
            this.colmanv.FieldName = "manv";
            this.colmanv.Name = "colmanv";
            this.colmanv.OptionsColumn.AllowEdit = false;
            this.colmanv.Visible = true;
            this.colmanv.VisibleIndex = 3;
            // 
            // colngayban
            // 
            this.colngayban.FieldName = "ngayban";
            this.colngayban.Name = "colngayban";
            this.colngayban.OptionsColumn.AllowEdit = false;
            this.colngayban.Visible = true;
            this.colngayban.VisibleIndex = 4;
            // 
            // txt_mahd
            // 
            this.txt_mahd.Location = new System.Drawing.Point(71, 12);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(197, 20);
            this.txt_mahd.StyleController = this.layoutControl1;
            this.txt_mahd.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(432, 260);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txt_mahd;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(260, 40);
            this.layoutControlItem1.Text = "Mã hoá đơn";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(412, 200);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // hoadonTableAdapter
            // 
            this.hoadonTableAdapter.ClearBeforeFill = true;
            // 
            // btn_in
            // 
            this.btn_in.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_in.ImageOptions.SvgImage")));
            this.btn_in.Location = new System.Drawing.Point(272, 12);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(148, 36);
            this.btn_in.StyleController = this.layoutControl1;
            this.btn_in.TabIndex = 7;
            this.btn_in.Text = "In hoá đơn";
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btn_in;
            this.layoutControlItem4.Location = new System.Drawing.Point(260, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(152, 40);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // frm_HoaDonIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 260);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frm_HoaDonIn";
            this.Text = "In Hoá đơn";
            this.Load += new System.EventHandler(this.frm_HoaDonIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NONG_SANDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mahd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txt_mahd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private QL_NONG_SANDataSet3 qL_NONG_SANDataSet3;
        private System.Windows.Forms.BindingSource hoadonBindingSource;
        private QL_NONG_SANDataSet3TableAdapters.hoadonTableAdapter hoadonTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colmahd;
        private DevExpress.XtraGrid.Columns.GridColumn colmakh;
        private DevExpress.XtraGrid.Columns.GridColumn coltenkh;
        private DevExpress.XtraGrid.Columns.GridColumn colmanv;
        private DevExpress.XtraGrid.Columns.GridColumn colngayban;
        private DevExpress.XtraEditors.SimpleButton btn_in;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}