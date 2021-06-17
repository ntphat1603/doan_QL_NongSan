using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Security.Cryptography;

namespace GUI
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        frm_MainNS fm;
        XtraForm1 fMK;
        frm_KhachHangNS fKH;
        MD5 md = MD5.Create();
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md.ComputeHash(Encoding.UTF8.GetBytes(txt_matkhau.Text));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            txt_matkhau.Text = sBuilder.ToString();

            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-CPB5GE8;Initial Catalog=QL_NONG_SAN;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from nhanvien where manv='" + txt_manv.Text + "' and matkhau ='" + txt_matkhau.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                fm = new frm_MainNS(dt.Rows[0][6].ToString(), dt.Rows[0][0].ToString());
                fm.Show();
                
                fMK = new XtraForm1(dt.Rows[0][0].ToString());
                fMK.Show();
                
                fKH = new frm_KhachHangNS(dt.Rows[0][0].ToString());
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                Application.Exit();
            }
            this.DialogResult = DialogResult.Cancel;
        }

        private void txt_matkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_dangnhap_Click(sender, e);
            }
        }
    }
}
