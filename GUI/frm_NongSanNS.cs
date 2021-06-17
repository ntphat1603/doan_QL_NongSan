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
using DevExpress.XtraReports.UI;
using System.Diagnostics;
using DevExpress.XtraBars;
using ClosedXML.Excel;

namespace GUI
{
    public partial class frm_NongSanNS : DevExpress.XtraEditors.XtraForm
    {
        public frm_NongSanNS()
        {
            InitializeComponent();
        }

        private void frm_NongSanNS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NONG_SANDataSet1.nongsan' table. You can move, or remove it, as needed.
            this.nongsanTableAdapter.Fill(this.qL_NONG_SANDataSet1.nongsan);
            HienThiLoaiLenCombobox();
            HienThiDSNongSanLenDatagrid();
        }
        private void HienThiLoaiLenCombobox()
        {
            List<NS_Loai_DTO> lstLoai = NS_Loai_BUS.LayDSLoai();
            cboLoai.Properties.DataSource=lstLoai;
            cboLoai.Properties.DisplayMember= "STenLoai";
            cboLoai.Properties.ValueMember = "SMaLoai";
        }
        private void HienThiDSNongSanLenDatagrid()
        {
            this.nongsanTableAdapter.Fill(this.qL_NONG_SANDataSet1.nongsan);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtmaNS.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            cboLoai.EditValue = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            txtTenNS.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
            dtpNgayNhap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
            txtSLTon.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]).ToString();
            txtGiaBan.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]).ToString();
            txtGiaNhap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6]).ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống              
            if (txtmaNS.Text == "" || txtTenNS.Text == "" || txtSLTon.Text == "" || txtGiaNhap.Text == "" || txtGiaBan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không             
            if (txtmaNS.Text.Length > 5)
            {
                MessageBox.Show("Mã nông sản tối đa 5 ký tự!");
                return;
            }             // Kiểm tra mã nhân viên có bị trùng không             
            if (NS_NongSan_BUS.TimNongSanTheoMa(txtmaNS.Text) != null)
            {
                MessageBox.Show("Mã nông sản đã tồn tại!");
                return;
            }
            if(NS_NongSan_BUS.TimNongSanTheoTen(txtTenNS.Text)!=null)
            {
                
            }    

            NS_NongSan_DTO ns = new NS_NongSan_DTO();
            ns.SMaNS = txtmaNS.Text;
            ns.STenNS = txtTenNS.Text;
            ns.SLoaiNS = cboLoai.EditValue.ToString();
            ns.DtNgayNhap = DateTime.Parse(dtpNgayNhap.Text);
            ns.SSLTon = txtSLTon.Text;
            ns.SGiaBan = txtGiaBan.Text;
            ns.SGiaNhap = txtGiaNhap.Text;

            if (NS_NongSan_BUS.ThemNongSan(ns) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNongSanLenDatagrid();
            MessageBox.Show("Đã thêm nông sản.");

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txtmaNS.Text == "" || txtTenNS.Text == "" || txtSLTon.Text == "" || txtGiaNhap.Text == "" || txtGiaBan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không             
            if (txtmaNS.Text.Length > 5)
            {
                MessageBox.Show("Mã nông sản tối đa 5 ký tự!");
                return;
            }
            NS_NongSan_DTO ns = new NS_NongSan_DTO();
            ns.SMaNS = txtmaNS.Text;
            ns.STenNS = txtTenNS.Text;
            ns.SLoaiNS = cboLoai.EditValue.ToString();
            ns.DtNgayNhap = DateTime.Parse(dtpNgayNhap.Text);
            ns.SSLTon = txtSLTon.Text;
            ns.SGiaBan = txtGiaBan.Text;
            ns.SGiaNhap = txtGiaNhap.Text;

            if (NS_NongSan_BUS.SuaNongSan(ns) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNongSanLenDatagrid();
            MessageBox.Show("Đã thêm nông sản.");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            NS_NongSan_DTO ns = new NS_NongSan_DTO();
            ns.SMaNS = txtmaNS.Text;
            if (NS_NongSan_BUS.XoaNongSan(ns) == false)
            {
                MessageBox.Show("Không Xóa được.");
                return;
            }
            HienThiDSNongSanLenDatagrid();
            MessageBox.Show("Đã Xóa nông sản.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        frm_ThongKeNhapHang fNH;
        private void btn_in_Click(object sender, EventArgs e)
        {
            if(fNH==null||fNH.IsDisposed)
            {
                fNH = new frm_ThongKeNhapHang();
                fNH.Show();
                this.Close();
            }    
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd=new SaveFileDialog() { Filter="Excel Workbook|*.xlsx"})
            {
                if(sfd.ShowDialog()==DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.qL_NONG_SANDataSet1.nongsan.CopyToDataTable(), "Nông sản");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Đã xuất ra file Excel thành công nha cô!!!", "Congratulations",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
            }    
        }
    }
}