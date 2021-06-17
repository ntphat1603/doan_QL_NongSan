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
    public partial class frm_hdngay : DevExpress.XtraEditors.XtraForm
    {
        public frm_hdngay()
        {
            InitializeComponent();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            reportDemo rp = new reportDemo();
            rp.FilterString = "[ngayban]='" + dtp_ngayban.Text + "'";
            rp.CreateDocument();
            rp.ShowPreviewDialog();
        }

        private void frm_hdngay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NONG_SANDataSet3.hoadon' table. You can move, or remove it, as needed.
            this.hoadonTableAdapter.Fill(this.qL_NONG_SANDataSet3.hoadon);

        }

        private void gridView1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            dtp_ngayban.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]).ToString();
        }
    }
}