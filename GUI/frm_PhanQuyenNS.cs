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

namespace GUI
{
    public partial class frm_PhanQuyenNS : DevExpress.XtraEditors.XtraForm
    {
        public frm_PhanQuyenNS()
        {
            InitializeComponent();
        }

        private void frm_PhanQuyenNS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NONG_SANDataSet1.phanquyen' table. You can move, or remove it, as needed.
            
            HienThiDSPhanQuyenLenDatagrid();
        }
        private void HienThiDSPhanQuyenLenDatagrid()
        {
            this.phanquyenTableAdapter.Fill(this.qL_NONG_SANDataSet1.phanquyen);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txt_ma_phanquyen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            txt_ten_phanquyen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txt_ma_phanquyen.Text == "" || txt_ten_phanquyen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã loại có độ dài chuỗi hợp lệ hay không             
            if (txt_ma_phanquyen.Text.Length > 6)
            {
                MessageBox.Show("Mã phân quyền tối đa 6 ký tự!");
                return;
            }             // Kiểm tra mã loại có bị trùng không             
            if (NS_PhanQuyen_BUS.TimPhanQuyenTheoMa(txt_ma_phanquyen.Text) != null)
            {
                MessageBox.Show("Mã loại đã tồn tại!");
                return;
            }

            NS_PhanQuyen_DTO pq = new NS_PhanQuyen_DTO();
            pq.SMaPQ = txt_ma_phanquyen.Text;
            pq.STenPQ = txt_ten_phanquyen.Text;

            if (NS_PhanQuyen_BUS.ThemPhanQuyen(pq) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSPhanQuyenLenDatagrid();
            MessageBox.Show("Đã thêm phân quyền.");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_ma_phanquyen.Text == "" || txt_ten_phanquyen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không             
            if (txt_ma_phanquyen.Text.Length > 6)
            {
                MessageBox.Show("Mã phân quyền tối đa 6 ký tự!");
                return;
            }
            NS_PhanQuyen_DTO pq = new NS_PhanQuyen_DTO();
            pq.SMaPQ = txt_ma_phanquyen.Text;
            pq.STenPQ = txt_ten_phanquyen.Text;

            if (NS_PhanQuyen_BUS.SuaPhanQuyen(pq) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSPhanQuyenLenDatagrid();
            MessageBox.Show("Đã thêm loại.");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            NS_PhanQuyen_DTO pq = new NS_PhanQuyen_DTO();
            pq.SMaPQ = txt_ma_phanquyen.Text;
            if (NS_PhanQuyen_BUS.XoaPhanQuyen(pq) == false)
            {
                MessageBox.Show("Không Xóa được.");
                return;
            }
            HienThiDSPhanQuyenLenDatagrid();
            MessageBox.Show("Đã Xóa phân quyền.");
        }
    }
}