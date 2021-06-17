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
using BUS;
using DTO;

namespace GUI
{
    public partial class frm_KhachHangNS : DevExpress.XtraEditors.XtraForm
    {
        string quyen = "";
        public frm_KhachHangNS()
        {
            InitializeComponent();
        }
        public frm_KhachHangNS(string quyen)
        {
            InitializeComponent();
            this.quyen = quyen;
        }

        private void frm_KhachHangNS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NONG_SANDataSet2.khachhang' table. You can move, or remove it, as needed.
            
            HienThiDSKhachHangLenDatagrid();
        }
        private void HienThiDSKhachHangLenDatagrid()
        {
            this.khachhangTableAdapter.Fill(this.qL_NONG_SANDataSet2.khachhang);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống              
            if (txtMaNV.Text == "" || txtSDT.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không             
            if (txtMaNV.Text.Length > 5)
            {
                MessageBox.Show("Mã nhân viên tối đa 5 ký tự!");
                return;
            }             // Kiểm tra mã nhân viên có bị trùng không             
            if (NS_KhachHang_BUS.TimKhachHangTheoMa(txtMaNV.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }

            NS_KhachHang_DTO nv = new NS_KhachHang_DTO();
            nv.SMaKH = txtMaNV.Text;
            nv.STen = txtTen.Text;

            if (radNam.Checked == true)
            {
                nv.SPhai = "Nam";
            }
            else
            {
                nv.SPhai = "Nữ";

            }
            nv.DtNgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            nv.SSDT = txtSDT.Text;
            nv.SDiachi = txtDiachi.Text;

            if (NS_KhachHang_BUS.ThemKhachHang(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSKhachHangLenDatagrid();
            MessageBox.Show("Đã thêm khách hàng.");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtSDT.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không             
            if (txtMaNV.Text.Length > 5)
            {
                MessageBox.Show("Mã nhân viên tối đa 5 ký tự!");
                return;
            }
            NS_KhachHang_DTO nv = new NS_KhachHang_DTO();
            nv.SMaKH = txtMaNV.Text;
            nv.STen = txtTen.Text;

            if (radNam.Checked == true)
            {
                nv.SPhai = "Nam";
            }
            else
            {
                nv.SPhai = "Nữ";

            }
            nv.DtNgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            nv.SSDT = txtSDT.Text;
            nv.SDiachi = txtDiachi.Text;

            if (NS_KhachHang_BUS.SuaKhachHang(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSKhachHangLenDatagrid();
            MessageBox.Show("Đã thêm khách hàng.");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            NS_KhachHang_DTO nv = new NS_KhachHang_DTO();
            nv.SMaKH = txtMaNV.Text;
            if (NS_KhachHang_BUS.XoaKhachHang(nv) == false)
            {
                MessageBox.Show("Không Xóa được.");
                return;
            }
            HienThiDSKhachHangLenDatagrid();
            MessageBox.Show("Đã Xóa Khách hàng.");
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            txtTen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            dtpNgaySinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
            txtSDT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]).ToString();
            txtDiachi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]).ToString();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtSDT_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}