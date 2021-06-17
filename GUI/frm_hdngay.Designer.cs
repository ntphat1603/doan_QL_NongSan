
namespace GUI
{
    partial class frm_hdngay
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.hoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NONG_SANDataSet3 = new GUI.QL_NONG_SANDataSet3();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmahd1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmakh1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenkh1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmanv1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngayban1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtp_ngayban = new DevExpress.XtraEditors.DateEdit();
            this.btn_in = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colmahd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmakh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenkh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmanv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngayban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hoadonTableAdapter = new GUI.QL_NONG_SANDataSet3TableAdapters.hoadonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NONG_SANDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_ngayban.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_ngayban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 36);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(268, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.dtp_ngayban);
            this.layoutControl1.Controls.Add(this.btn_in);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(614, 7, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(440, 215);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.hoadonBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 62);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(416, 141);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
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
            this.colmahd1,
            this.colmakh1,
            this.coltenkh1,
            this.colmanv1,
            this.colngayban1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click_1);
            // 
            // colmahd1
            // 
            this.colmahd1.FieldName = "mahd";
            this.colmahd1.Name = "colmahd1";
            this.colmahd1.OptionsColumn.AllowEdit = false;
            this.colmahd1.Visible = true;
            this.colmahd1.VisibleIndex = 0;
            // 
            // colmakh1
            // 
            this.colmakh1.FieldName = "makh";
            this.colmakh1.Name = "colmakh1";
            this.colmakh1.OptionsColumn.AllowEdit = false;
            this.colmakh1.Visible = true;
            this.colmakh1.VisibleIndex = 1;
            // 
            // coltenkh1
            // 
            this.coltenkh1.FieldName = "tenkh";
            this.coltenkh1.Name = "coltenkh1";
            this.coltenkh1.OptionsColumn.AllowEdit = false;
            this.coltenkh1.Visible = true;
            this.coltenkh1.VisibleIndex = 2;
            // 
            // colmanv1
            // 
            this.colmanv1.FieldName = "manv";
            this.colmanv1.Name = "colmanv1";
            this.colmanv1.OptionsColumn.AllowEdit = false;
            this.colmanv1.Visible = true;
            this.colmanv1.VisibleIndex = 3;
            // 
            // colngayban1
            // 
            this.colngayban1.FieldName = "ngayban";
            this.colngayban1.Name = "colngayban1";
            this.colngayban1.OptionsColumn.AllowEdit = false;
            this.colngayban1.Visible = true;
            this.colngayban1.VisibleIndex = 4;
            // 
            // dtp_ngayban
            // 
            this.dtp_ngayban.EditValue = null;
            this.dtp_ngayban.Location = new System.Drawing.Point(93, 12);
            this.dtp_ngayban.Name = "dtp_ngayban";
            this.dtp_ngayban.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_ngayban.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_ngayban.Size = new System.Drawing.Size(335, 20);
            this.dtp_ngayban.StyleController = this.layoutControl1;
            this.dtp_ngayban.TabIndex = 11;
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(222, 36);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(206, 22);
            this.btn_in.StyleController = this.layoutControl1;
            this.btn_in.TabIndex = 10;
            this.btn_in.Text = "In HD";
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButton1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(272, 98);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(440, 215);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btn_in;
            this.layoutControlItem2.Location = new System.Drawing.Point(210, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(210, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(210, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dtp_ngayban;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(420, 24);
            this.layoutControlItem3.Text = "Ngày in hoá đơn";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(420, 145);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
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
            // hoadonTableAdapter
            // 
            this.hoadonTableAdapter.ClearBeforeFill = true;
            // 
            // frm_hdngay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 215);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frm_hdngay";
            this.Text = "frm_hdngay";
            this.Load += new System.EventHandler(this.frm_hdngay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NONG_SANDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_ngayban.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_ngayban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit dtp_ngayban;
        private DevExpress.XtraEditors.SimpleButton btn_in;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn colmahd;
        private DevExpress.XtraGrid.Columns.GridColumn colmakh;
        private DevExpress.XtraGrid.Columns.GridColumn coltenkh;
        private DevExpress.XtraGrid.Columns.GridColumn colmanv;
        private DevExpress.XtraGrid.Columns.GridColumn colngayban;
        private QL_NONG_SANDataSet3 qL_NONG_SANDataSet3;
        private System.Windows.Forms.BindingSource hoadonBindingSource;
        private QL_NONG_SANDataSet3TableAdapters.hoadonTableAdapter hoadonTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colmahd1;
        private DevExpress.XtraGrid.Columns.GridColumn colmakh1;
        private DevExpress.XtraGrid.Columns.GridColumn coltenkh1;
        private DevExpress.XtraGrid.Columns.GridColumn colmanv1;
        private DevExpress.XtraGrid.Columns.GridColumn colngayban1;
    }
}