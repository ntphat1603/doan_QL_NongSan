using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace GUI
{
    public partial class frm_MainNS : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string quyen = "", manv = "";
        public frm_MainNS()
        {
            InitializeComponent();
        }
        
        frm_LoaiNS fCV;
        frm_NhanVien_NS fNV;
        frm_NongSanNS fNS;
        frm_PhanQuyenNS fPQ;
        frm_HoaDon fHD;
        frm_HoaDonIn fHDI;
        frm_KhachHangNS fKH;
        frm_DangNhap FDN;
        frm_Backup fBK;
        frm_hdngay fRP;
        frn_importNS fip;
        //report rp;
        frm_hdDemo hd;

        public frm_MainNS(string quyen, string manv)
        {
            InitializeComponent();
            this.quyen = quyen;
            this.manv = manv;
        }

        private void btn_logout_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (FDN == null || FDN.IsDisposed)
            {
                FDN = new frm_DangNhap();
                FDN.Show();
                this.Hide();
            }
        }

        private void btn_nhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(quyen=="Quản lý")
            {
                if (fNV == null || fNV.IsDisposed)
                {
                    fNV = new frm_NhanVien_NS();
                    fNV.MdiParent = this;
                    fNV.Show();
                }
                else fNV.Activate();
            }
            else
            {
                MessageBox.Show("Tính năng chỉ được sử dụng cho quản lý");
            } 
        }

        private void btn_khachhang_ItemClick(object sender, ItemClickEventArgs e)
        {

                if (fKH == null || fKH.IsDisposed)
                {
                    fKH = new frm_KhachHangNS();
                    fKH.MdiParent = this;
                    fKH.Show();
                }
                else fKH.Activate();
        }

        private void btnLoai_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (quyen == "Quản lý")
            {
                if (fCV == null || fCV.IsDisposed)
                {
                    fCV = new frm_LoaiNS();
                    fCV.MdiParent = this;
                    fCV.Show();
                }
                else fCV.Activate();
            }
            else
            {
                MessageBox.Show("Tính năng chỉ được sử dụng cho quản lý");
            }
        }

        private void btn_nongsan_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (quyen == "Quản lý")
            {
                if (fNS == null || fNS.IsDisposed)
                {
                    fNS = new frm_NongSanNS();
                    fNS.MdiParent = this;
                    fNS.Show();
                }
                else fNS.Activate();
            }
            else
            {
                MessageBox.Show("Tính năng chỉ được sử dụng cho quản lý");
            }
        }

        private void btn_hoadon_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fHD == null || fHD.IsDisposed)
            {
                fHD = new frm_HoaDon();
                fHD.MdiParent = this;
                fHD.Show();
            }
            else fHD.Activate();
        }

        private void btn_backup_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (quyen == "Quản lý")
            {
                if (fBK == null || fBK.IsDisposed)
                {
                    fBK = new frm_Backup();
                    fBK.MdiParent = this;
                    fBK.Show();
                }
                else fBK.Activate();
            }
            else
            {
                MessageBox.Show("Tính năng chỉ được sử dụng cho quản lý");
            }
            
        }

        private void btn_report_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (quyen == "Quản lý")
            {
                if (fRP == null || fRP.IsDisposed)
                {
                    fRP = new frm_hdngay();
                    fRP.MdiParent = this;
                    fRP.Show();
                }
                else fRP.Activate();
            }
            else
            {
                MessageBox.Show("Tính năng chỉ được sử dụng cho quản lý");
            }
        }

        private void btn_hoadonct_ItemClick(object sender, ItemClickEventArgs e)
        {
            btn_hoadon_ItemClick(sender, e);
        }

        private void btn_QLKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            btn_khachhang_ItemClick(sender, e);
        }

        private void frm_MainNS_Load(object sender, EventArgs e)
        {
            //txt_manv.EditValue= manv.ToString();
        }

        private void btn_matkhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (FDN == null || FDN.IsDisposed)
            {
                FDN = new frm_DangNhap();
                FDN.Show();
                this.Hide();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("https://www.facebook.com/ntphatdesigner");
        }

        private void btn_thoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                Application.Exit();
            }
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_inhoadon_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fHDI == null || fHDI.IsDisposed)
            {
                fHDI = new frm_HoaDonIn();
                fHDI.MdiParent = this;
                fHDI.Show();
            }
            else fHDI.Activate();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (quyen == "Quản lý")
            {
                if (fip == null || fip.IsDisposed)
                {
                    fip = new frn_importNS();
                    fip.MdiParent = this;
                    fip.Show();
                }
            }
            else
            {
                MessageBox.Show("Tính năng chỉ được sử dụng cho quản lý");
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (hd == null || hd.IsDisposed)
            {
                hd = new frm_hdDemo();
                hd.MdiParent = this;
                hd.Show();
            }
            else hd.Activate();
        }

        private void btn_Phanquyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (quyen == "Quản lý")
            {
                if (fPQ == null || fPQ.IsDisposed)
                {
                    fPQ = new frm_PhanQuyenNS();
                    fPQ.MdiParent = this;
                    fPQ.Show();
                }
            }
            else
            {
                MessageBox.Show("Tính năng chỉ được sử dụng cho quản lý");
            }
        }
    }
}