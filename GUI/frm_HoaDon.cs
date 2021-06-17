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
using DTO;
using BUS;
using DAO;

namespace GUI
{
    public partial class frm_HoaDon : DevExpress.XtraEditors.XtraForm
    {
        public frm_HoaDon()
        {
            InitializeComponent();
        }
        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NONG_SANDataSet3.hoadonchitiet' table. You can move, or remove it, as needed.
            this.hoadonchitietTableAdapter.Fill(this.qL_NONG_SANDataSet3.hoadonchitiet);
            HienThiLenDataGrid();
            HienThiMaKH();
            HienThiNhanVien();
            HienThiNongSan();
        }
        private void HienThiLenDataGrid()
        {
            this.hoadonchitietTableAdapter.Fill(this.qL_NONG_SANDataSet3.hoadonchitiet);
        }
        private void HienThiMaKH()
        {
            List<NS_KhachHang_DTO> lstKH = NS_KhachHang_BUS.LayDSKhachHang();
            cbo_khachhang.DataSource = lstKH;
            cbo_khachhang.ValueMember = "SMaKH";
            cbo_khachhang.DisplayMember = "SMaKH";
            cbo_tenKH.DataSource = lstKH;
            cbo_tenKH.ValueMember = "STen";
            cbo_tenKH.DisplayMember = "STen";
        }

        private void HienThiNhanVien()
        {
            List<NS_NhanVien_DTO> lstNV = NS_NhanVien_BUS.LayDSNhanVien();
            cbo_manv.DataSource = lstNV;
            cbo_manv.ValueMember = "SMaNV";
            cbo_manv.DisplayMember = "SMaNV";
            cbo_nhanvien.DataSource = lstNV;
            cbo_nhanvien.ValueMember = "STen";
            cbo_nhanvien.DisplayMember = "STen";
        }

        private void HienThiNongSan()
        {
            List<NS_NongSan_DTO> lstNS = NS_NongSan_BUS.LayDSNongSan();
            cbo_maNS.DataSource = lstNS;
            cbo_maNS.ValueMember = "SMaNS";
            cbo_maNS.DisplayMember = "SMaNS";

            cbo_tenNS.DataSource = lstNS;
            cbo_tenNS.ValueMember = "STenNS";
            cbo_tenNS.DisplayMember = "STenNS";

            cbo_LoaiNS.DataSource = lstNS;
            cbo_LoaiNS.ValueMember = "SLoaiNS";
            cbo_LoaiNS.DisplayMember = "SLoaiNS";

            cbo_dongia.DataSource = lstNS;
            cbo_dongia.ValueMember = "SGiaBan";
            cbo_dongia.DisplayMember = "SGiaBan";
        }

        private void cbo_maNS_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soluong = Convert.ToInt32(num_SL.Value);
            int dongia = Convert.ToInt32(cbo_dongia.Text);
            int thanhtien = soluong * dongia;
            txt_tongtien.Text = thanhtien.ToString();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txt_hdct.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            txt_hoadon.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            cbo_maNS.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
            cbo_tenNS.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
            cbo_LoaiNS.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]).ToString();
            num_SL.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]).ToString();
            cbo_dongia.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6]).ToString();

        }

        private void btn_hd_Click(object sender, EventArgs e)
        {
            txt_hoadon.ReadOnly = false;
            // Kiểm tra dữ liệu có bị bỏ trống              
            if (txt_hoadon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không             
            if (txt_hoadon.Text.Length > 6)
            {
                MessageBox.Show("Mã hóa đơn tối đa 5 ký tự!");
                return;
            }            // Kiểm tra mã nhân viên có bị trùng không             
            if (NS_HoaDon_BUS.TimHoaDonTheoMa(txt_hoadon.Text) != null)
            {
                MessageBox.Show("Mã Hóa đon đã tồn tại!");
                return;
            }

            NS_HoaDon_DTO hd = new NS_HoaDon_DTO();
            hd.SMaHD = txt_hoadon.Text;
            // hd.STenSP = cbotenSP.SelectedValue.ToString();
            hd.SMaKH = cbo_khachhang.SelectedValue.ToString();
            hd.STenKH = cbo_tenKH.SelectedValue.ToString();
            //hd.SGIA = int.Parse(cboGia.SelectedValue.ToString());
            //hd.SSL = int.Parse(txtSL.Value.ToString());
            //hd.SMAU = cboMau.SelectedValue.ToString();
            hd.SMaNV = cbo_manv.SelectedValue.ToString();
            hd.DtNgayBan = DateTime.Parse(dtp_ngayban.Text);
            hd.STONG = int.Parse(txt_tongtien.Text);

            //hd.SMaSP = cbomasp.SelectedValue.ToString();

            if (NS_HoaDon_BUS.ThemHoaDon(hd) == false)
            {
                MessageBox.Show("Không tạo được.");
                return;
            }
            HienThiLenDataGrid();
            MessageBox.Show("Đã tạo hóa đơn.");
            txt_tongtien.Reset();
            txt_hoadon.ReadOnly = true;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon;


            if (txt_hdct.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không             
            if (txt_hdct.Text.Length > 10)
            {
                MessageBox.Show("Mã chi tiết hóa đơn tối đa 10 ký tự!");
                return;
            }

            NS_HoaDonCT_DTO hd = new NS_HoaDonCT_DTO();
            hd.SMaHDCT = txt_hdct.Text;
            hd.SMaHD = txt_hoadon.Text;
            hd.SMaNS = cbo_maNS.SelectedValue.ToString();
            hd.STenNS = cbo_tenNS.SelectedValue.ToString();
            hd.SLoai = cbo_LoaiNS.SelectedValue.ToString();
            hd.SSLBan = int.Parse(num_SL.Value.ToString());
            hd.SDonGiaBan = cbo_dongia.SelectedValue.ToString();
            
            
            //hd.SAnh = txtanh.Text;
            // hd.SMaNV = cbomaNV.SelectedValue.ToString();
            // hd.STONG = int.Parse(txttong.Text);
            // hd.SMaKH = cbomakh.SelectedValue.ToString();
            //  hd.SNgayban = DateTime.Parse(dtpNgayBan.Text);
            sl = Convert.ToDouble(DataProvider.GetFieldValues("SELECT soluongton FROM nongsan WHERE ma_nongsan = N'" + cbo_maNS.SelectedValue + "'"));
            if (Convert.ToDouble(num_SL.Text) > sl)
            {
                MessageBox.Show("Số lượng sản phẩm này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                num_SL.Text = "";
                num_SL.Focus();
                return;
            }
            if (NS_HoaDonCT_BUS.ThemHoaDonCT(hd) == false)
            {
                MessageBox.Show("Không lưu được.");
                return;
            }
            HienThiLenDataGrid();
            MessageBox.Show("Đã lưu hóa đơn.");
            SLcon = sl - Convert.ToDouble(num_SL.Text);
            sql = "UPDATE nongsan SET soluongton =" + SLcon + " WHERE ma_nongsan= N'" + cbo_maNS.SelectedValue + "'";
            DataProvider.RunSQL(sql);
            txt_tongtien.Reset();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txt_hdct.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không             
            if (txt_hdct.Text.Length > 10)
            {
                MessageBox.Show("Mã hóa đơn tối đa 10 ký tự!");
                return;
            }
            NS_HoaDonCT_DTO hd = new NS_HoaDonCT_DTO();
            hd.SMaHDCT = txt_hdct.Text;
            hd.SMaHD = txt_hoadon.Text;
            hd.SMaNS = cbo_maNS.SelectedValue.ToString();
            hd.STenNS = cbo_tenNS.SelectedValue.ToString();
            hd.SLoai = cbo_LoaiNS.SelectedValue.ToString();
            hd.SSLBan = int.Parse(num_SL.Value.ToString());
            hd.SDonGiaBan = cbo_dongia.SelectedValue.ToString();

            // hd.SMaNV = cbomaNV.SelectedValue.ToString();
            // hd.STONG = int.Parse(txttong.Text);
            // hd.SMaKH = cbomakh.SelectedValue.ToString();

            //  hd.SNgayban = DateTime.Parse(dtpNgayBan.Text);
            if (NS_HoaDonCT_BUS.SuaHoaDonCT(hd) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            HienThiLenDataGrid();
            MessageBox.Show("Đã sừa hóa đơn.");
            txt_tongtien.Refresh();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            NS_HoaDonCT_DTO hd = new NS_HoaDonCT_DTO();
            hd.SMaHDCT = txt_hdct.Text;
            if (NS_HoaDonCT_BUS.XoaHoaDonCT(hd) == false)
            {
                MessageBox.Show("Không xóa được.");
                return;
            }
            HienThiLenDataGrid();
            MessageBox.Show("Đã xóa hóa đơn.");
            txt_tongtien.Refresh();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            report_hd rp = new report_hd();
            rp.FilterString = "[mahd]='" + txt_hoadon.Text + "'";
            rp.CreateDocument();
            frm_reporting frm = new frm_reporting();
            frm.documentViewer1.DocumentSource = rp;
            frm.ShowDialog();
        }
    }
}