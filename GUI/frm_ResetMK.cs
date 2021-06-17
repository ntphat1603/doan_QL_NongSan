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
using System.Data.SqlClient;
using System.Security.Cryptography;
using DTO;
using BUS;
using DAO;

namespace GUI
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }
        frm_DangNhap FDN;
        frm_MainNS FM;
        public XtraForm1(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }
        string manv = "";

        MD5 md = MD5.Create();

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            HienThiNhanVienLenCombobox();
            cbo_manv.Text = manv.ToString();
        }
        private void HienThiNhanVienLenCombobox()
        {
            List<NS_NhanVien_DTO> lstNhanVien = NS_NhanVien_BUS.LayDSNhanVien();
            cbo_manv.DataSource = lstNhanVien;
            cbo_manv.DisplayMember = "SMaNV";
            cbo_manv.ValueMember = "SMaNV";
        }

        private void cbo_manv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string slq;
            if (cbo_manv.Text == "")
            {
                txt_tennv.Text = "";
                txt_gioitinh.Text = "";
                txt_diachi.Text = "";
                txt_ngaysinh.Text = "";
                txt_quyen.Text = "";
                txt_sdt.Text = "";
                XtraForm1_Load(sender, e);
            }
            slq = "Select tennv from nhanvien where MANV =N'" + cbo_manv.SelectedValue + "'";
            txt_tennv.Text = (string)DataProvider.GetFieldValues(slq);
            slq = "Select gioitinh from nhanvien where MANV =N'" + cbo_manv.SelectedValue + "'";
            txt_gioitinh.Text = (string)DataProvider.GetFieldValues(slq);
            slq = "Select diachi from nhanvien where MANV =N'" + cbo_manv.SelectedValue + "'";
            txt_diachi.Text = (string)DataProvider.GetFieldValues(slq);
            slq = "Select ngaysinh from nhanvien where MANV =N'" + cbo_manv.SelectedValue + "'";
            txt_ngaysinh.Text = (string)DataProvider.GetFieldValues(slq);
            slq = "Select quyen from nhanvien where MANV =N'" + cbo_manv.SelectedValue + "'";
            txt_quyen.Text = (string)DataProvider.GetFieldValues(slq);
            slq = "Select dienthoai from nhanvien where MANV =N'" + cbo_manv.SelectedValue + "'";
            txt_sdt.Text = (string)DataProvider.GetFieldValues(slq);
            XtraForm1_Load(sender, e);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(txt_pass.Text==txt_nhaplai.Text)
            {
                if (txt_tennv.Text == "" || cbo_manv.Text == "" || txt_pass.Text == "")
                {
                    MessageBox.Show("Vui lòng kiểm tra thông tin cá nhân và nhập mật khẩu mới. Nếu thông tin cá nhân có sai sót vui lòng liên hệ Quản lý.    " +
                        "Xin cám ơn!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không             
                if (cbo_manv.Text.Length > 5)
                {
                    MessageBox.Show("Mã nhân viên tối đa 5 ký tự!");
                    return;
                }
                NS_NhanVien_DTO nv = new NS_NhanVien_DTO();
                nv.SMaNV = cbo_manv.Text;
                nv.STen = txt_tennv.Text;
                nv.SPhai = txt_gioitinh.Text;
                nv.DtNgaySinh = DateTime.Parse(txt_ngaysinh.Text);
                nv.SSDT = txt_sdt.Text;
                nv.SDiachi = txt_diachi.Text;
                nv.SQuyen = txt_quyen.Text;
                // Convert the input string to a byte array and compute the hash.
                byte[] data = md.ComputeHash(Encoding.UTF8.GetBytes(txt_pass.Text));
                // Create a new Stringbuilder to collect the bytes
                // and create a string.
                StringBuilder sBuilder = new StringBuilder();
                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                nv.SMatkhau = sBuilder.ToString();

                if (NS_NhanVien_BUS.SuaNhanVien(nv) == false)
                {
                    MessageBox.Show("Không thêm được.");
                    return;
                }
                MessageBox.Show("Đã đổi mật khẩu thành công.");
                this.Close();
            }
            else
            {
                if(txt_pass==null)
                {
                    errorProvider1.SetError(txt_pass, "Bạn chưa điền mật khẩu mới");
                }    
                if(txt_pass.Text!=txt_nhaplai.Text)
                {
                    errorProvider1.SetError(txt_nhaplai, "Bạn nhập lại mật khẩu mới không khớp");
                }    
                
            }

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}