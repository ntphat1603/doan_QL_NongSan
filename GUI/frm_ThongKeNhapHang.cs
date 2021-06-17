using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace GUI
{
    public partial class frm_ThongKeNhapHang : DevExpress.XtraEditors.XtraForm
    {
        public frm_ThongKeNhapHang()
        {
            InitializeComponent();
        }

        private void frm_ThongKeNhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NONG_SANDataSet1.nongsan' table. You can move, or remove it, as needed.
            this.nongsanTableAdapter.Fill(this.qL_NONG_SANDataSet1.nongsan);

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            dtp_ngaynhap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            report_nongsan rp = new report_nongsan();
            rp.FilterString = "[ngay_nhap]='" + dtp_ngaynhap.Text + "'";
            rp.CreateDocument();
            rp.ShowPreviewDialog();
        }
    }
}