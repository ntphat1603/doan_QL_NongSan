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
    public partial class frm_report : Form
    {
        public frm_report()
        {
            InitializeComponent();
        }

        private void frm_report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QL_NONG_SANDataSet.nongsan' table. You can move, or remove it, as needed.
            this.nongsanTableAdapter.Fill(this.QL_NONG_SANDataSet.nongsan);

            this.reportViewer1.RefreshReport();
        }
    }
}
