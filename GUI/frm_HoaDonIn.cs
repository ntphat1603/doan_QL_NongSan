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

namespace GUI
{
    public partial class frm_HoaDonIn : DevExpress.XtraEditors.XtraForm
    {
        public frm_HoaDonIn()
        {
            InitializeComponent();
        }

        private void frm_HoaDonIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NONG_SANDataSet3.hoadon' table. You can move, or remove it, as needed.
            this.hoadonTableAdapter.Fill(this.qL_NONG_SANDataSet3.hoadon);

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            txt_mahd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            report_hd rp = new report_hd();
            rp.FilterString = "[mahd]='" + txt_mahd.Text + "'";
            rp.CreateDocument();
            frm_reporting frm = new frm_reporting();
            frm.documentViewer1.DocumentSource = rp;
            frm.ShowDialog();
        }
    }
}