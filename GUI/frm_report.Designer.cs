
namespace GUI
{
    partial class frm_report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.nongsanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QL_NONG_SANDataSet = new GUI.QL_NONG_SANDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nongsanTableAdapter = new GUI.QL_NONG_SANDataSetTableAdapters.nongsanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nongsanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QL_NONG_SANDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nongsanBindingSource
            // 
            this.nongsanBindingSource.DataMember = "nongsan";
            this.nongsanBindingSource.DataSource = this.QL_NONG_SANDataSet;
            // 
            // QL_NONG_SANDataSet
            // 
            this.QL_NONG_SANDataSet.DataSetName = "QL_NONG_SANDataSet";
            this.QL_NONG_SANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nongsanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(744, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // nongsanTableAdapter
            // 
            this.nongsanTableAdapter.ClearBeforeFill = true;
            // 
            // frm_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_report";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.frm_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nongsanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QL_NONG_SANDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource nongsanBindingSource;
        private QL_NONG_SANDataSet QL_NONG_SANDataSet;
        private QL_NONG_SANDataSetTableAdapters.nongsanTableAdapter nongsanTableAdapter;
    }
}