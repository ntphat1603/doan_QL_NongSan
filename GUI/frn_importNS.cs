using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;
using DTO;
using DAO;
using System.Data.SqlClient;

namespace GUI
{
    public partial class frn_importNS : DevExpress.XtraEditors.XtraForm
    {
        string addressFile;
        public frn_importNS()
        {
            InitializeComponent();
        }

        private List<string> getListSheet(string urlFile)
        {
            try
            {
                List<string> sheets = new List<string>();
                string connec = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", urlFile);
                DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");
                DbConnection connection = factory.CreateConnection();
                connection.ConnectionString = connec;
                connection.Open();
                DataTable dt = connection.GetSchema("Tables");
                connection.Close();
                foreach (DataRow row in dt.Rows)
                {
                    string sheetnames = (string)row["TABLE_NAME"];
                    sheets.Add(sheetnames);
                }
                return sheets;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void cbo_sheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connec = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", addressFile);
                string query = string.Format("Select * from [{0}]", cbo_sheet.Text);
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connec);
                DataTable tbSinhVien = new DataTable();
                adapter.Fill(tbSinhVien);
                if (tbSinhVien.Rows.Count > 0)
                {
                    dataGridView1.DataSource = tbSinhVien;
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Test");
            }
        }

        private void opf_FileOk(object sender, CancelEventArgs e)
        {
            addressFile = opf.FileName;
            txt_file.Text = addressFile.Substring(addressFile.LastIndexOf(@"\") + 1);
            List<string> sheets = getListSheet(addressFile);
            cbo_sheet.DataSource = sheets;
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            opf.Filter = "Tất Cả Các File |*.*|Excel 2003 Files |*.xls|Excel 2007 File|*.xlsx";
            opf.FileName = "";
            opf.ShowDialog();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            QL_NONG_SANDataSetTableAdapters.nongsanTableAdapter sv = new QL_NONG_SANDataSetTableAdapters.nongsanTableAdapter();
            int i = 0;
            string SMaNS;
            string SLoaiNS;
            string STenNS;
            DateTime DtNgayNhap;
            int SSLTon;
            int SGiaBan;
            int SGiaNhap;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                i++;
                try
                {

                    SMaNS = row.Cells["ma_nongsan"].Value.ToString();
                    SLoaiNS = row.Cells["loai_nongsan"].Value.ToString();
                    STenNS = row.Cells["ten_nongsan"].Value.ToString();
                    DtNgayNhap = DateTime.Parse(row.Cells["ngay_nhap"].Value.ToString());
                    SSLTon = int.Parse(row.Cells["soluongton"].Value.ToString());
                    SGiaBan = int.Parse(row.Cells["giaban"].Value.ToString());
                    SGiaNhap = int.Parse(row.Cells["gianhap"].Value.ToString());

                    sv.Insert(SMaNS, SLoaiNS, STenNS, DtNgayNhap, SSLTon, SGiaBan, SGiaNhap);
                }
                catch (Exception)
                {

                }
            }
            MessageBox.Show("Nhập Dữ Liệu Xong");
        }

        private void frn_importNS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NONG_SANDataSet1.nongsan' table. You can move, or remove it, as needed.
            this.nongsanTableAdapter.Fill(this.qL_NONG_SANDataSet1.nongsan);

        }
    }
}