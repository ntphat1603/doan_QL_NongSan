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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Controls;
using DTO;
using BUS;

namespace GUI
{
    public partial class frm_LoaiNS : DevExpress.XtraEditors.XtraForm
    {
        public frm_LoaiNS()
        {
            InitializeComponent();
        }

        private void frm_LoaiNS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NONG_SANDataSet1.loai' table. You can move, or remove it, as needed.
            HienThiDSLoaiLenDatagrid();
        }
        private void HienThiDSLoaiLenDatagrid()
        {
            this.loaiTableAdapter.Fill(this.qL_NONG_SANDataSet1.loai);
        }

        private void dgDSLoai_Click(object sender, EventArgs e)
        {
            txt_maloai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            txt_tenloai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống              
            if (txt_maloai.Text == "" || txt_tenloai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã loại có độ dài chuỗi hợp lệ hay không             
            if (txt_maloai.Text.Length > 8)
            {
                MessageBox.Show("Mã loại tối đa 8 ký tự!");
                return;
            }             // Kiểm tra mã loại có bị trùng không             
            if (NS_Loai_BUS.TimLoaiTheoMa(txt_maloai.Text) != null)
            {
                MessageBox.Show("Mã loại đã tồn tại!");
                return;
            }

            NS_Loai_DTO loai = new NS_Loai_DTO();
            loai.SMaLoai = txt_maloai.Text;
            loai.STenLoai = txt_tenloai.Text;

            if (NS_Loai_BUS.ThemLoai(loai) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            this.loaiTableAdapter.Fill(this.qL_NONG_SANDataSet1.loai);
            HienThiDSLoaiLenDatagrid();
            MessageBox.Show("Đã thêm loại.");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_maloai.Text == "" || txt_tenloai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không             
            if (txt_maloai.Text.Length > 8)
            {
                MessageBox.Show("Mã loại tối đa 8 ký tự!");
                return;
            }
            NS_Loai_DTO loai = new NS_Loai_DTO();
            loai.SMaLoai = txt_maloai.Text;
            loai.STenLoai = txt_tenloai.Text;

            if (NS_Loai_BUS.SuaLoai(loai) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSLoaiLenDatagrid();
            MessageBox.Show("Đã thêm loại.");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            NS_Loai_DTO loai = new NS_Loai_DTO();
            loai.SMaLoai = txt_maloai.Text;
            if (NS_Loai_BUS.XoaLoai(loai) == false)
            {
                MessageBox.Show("Không Xóa được.");
                return;
            }
            HienThiDSLoaiLenDatagrid();
            MessageBox.Show("Đã Xóa loại.");
        }
    }
}