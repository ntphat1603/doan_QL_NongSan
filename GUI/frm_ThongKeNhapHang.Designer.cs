
namespace GUI
{
    partial class frm_ThongKeNhapHang
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.nongsanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NONG_SANDataSet1 = new GUI.QL_NONG_SANDataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colma_nongsan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colten_nongsan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngay_nhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_in = new DevExpress.XtraEditors.SimpleButton();
            this.dtp_ngaynhap = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.nongsanTableAdapter = new GUI.QL_NONG_SANDataSet1TableAdapters.nongsanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nongsanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NONG_SANDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_ngaynhap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_ngaynhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.btn_in);
            this.layoutControl1.Controls.Add(this.dtp_ngaynhap);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(346, 7, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(482, 195);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.nongsanBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 38);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(458, 145);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // nongsanBindingSource
            // 
            this.nongsanBindingSource.DataMember = "nongsan";
            this.nongsanBindingSource.DataSource = this.qL_NONG_SANDataSet1;
            // 
            // qL_NONG_SANDataSet1
            // 
            this.qL_NONG_SANDataSet1.DataSetName = "QL_NONG_SANDataSet1";
            this.qL_NONG_SANDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colma_nongsan,
            this.colten_nongsan,
            this.colngay_nhap});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colma_nongsan
            // 
            this.colma_nongsan.FieldName = "ma_nongsan";
            this.colma_nongsan.Name = "colma_nongsan";
            this.colma_nongsan.OptionsColumn.AllowEdit = false;
            this.colma_nongsan.Visible = true;
            this.colma_nongsan.VisibleIndex = 0;
            // 
            // colten_nongsan
            // 
            this.colten_nongsan.FieldName = "ten_nongsan";
            this.colten_nongsan.Name = "colten_nongsan";
            this.colten_nongsan.OptionsColumn.AllowEdit = false;
            this.colten_nongsan.Visible = true;
            this.colten_nongsan.VisibleIndex = 1;
            // 
            // colngay_nhap
            // 
            this.colngay_nhap.FieldName = "ngay_nhap";
            this.colngay_nhap.Name = "colngay_nhap";
            this.colngay_nhap.OptionsColumn.AllowEdit = false;
            this.colngay_nhap.Visible = true;
            this.colngay_nhap.VisibleIndex = 2;
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(329, 12);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(141, 22);
            this.btn_in.StyleController = this.layoutControl1;
            this.btn_in.TabIndex = 5;
            this.btn_in.Text = "In Thống kê";
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // dtp_ngaynhap
            // 
            this.dtp_ngaynhap.EditValue = new System.DateTime(2021, 6, 12, 16, 28, 28, 908);
            this.dtp_ngaynhap.Location = new System.Drawing.Point(71, 12);
            this.dtp_ngaynhap.Name = "dtp_ngaynhap";
            this.dtp_ngaynhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_ngaynhap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_ngaynhap.Properties.EditFormat.FormatString = "dd/MM/YYYY";
            this.dtp_ngaynhap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtp_ngaynhap.Size = new System.Drawing.Size(254, 20);
            this.dtp_ngaynhap.StyleController = this.layoutControl1;
            this.dtp_ngaynhap.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(482, 195);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dtp_ngaynhap;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(317, 26);
            this.layoutControlItem1.Text = "Ngày nhập:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btn_in;
            this.layoutControlItem2.Location = new System.Drawing.Point(317, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(145, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(462, 149);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // nongsanTableAdapter
            // 
            this.nongsanTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ThongKeNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 195);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frm_ThongKeNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ThongKeNhapHang";
            this.Load += new System.EventHandler(this.frm_ThongKeNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nongsanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NONG_SANDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_ngaynhap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_ngaynhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.DateEdit dtp_ngaynhap;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_in;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private QL_NONG_SANDataSet1 qL_NONG_SANDataSet1;
        private System.Windows.Forms.BindingSource nongsanBindingSource;
        private QL_NONG_SANDataSet1TableAdapters.nongsanTableAdapter nongsanTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colma_nongsan;
        private DevExpress.XtraGrid.Columns.GridColumn colten_nongsan;
        private DevExpress.XtraGrid.Columns.GridColumn colngay_nhap;
    }
}