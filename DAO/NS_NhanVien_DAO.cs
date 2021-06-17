using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NS_NhanVien_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả nhân viên
        public static List<NS_NhanVien_DTO> LayDSNhanVien()
        {
            string sTruyVan = "select * from nhanvien";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NS_NhanVien_DTO> lstNhanVien = new List<DTO.NS_NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NS_NhanVien_DTO nv = new NS_NhanVien_DTO();
                nv.SMaNV = dt.Rows[i]["manv"].ToString();
                nv.STen = dt.Rows[i]["tennv"].ToString();
                nv.SPhai = dt.Rows[i]["gioitinh"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                nv.SSDT = dt.Rows[i]["dienthoai"].ToString();
                nv.SDiachi = dt.Rows[i]["diachi"].ToString();
                nv.SQuyen = dt.Rows[i]["quyen"].ToString();
                lstNhanVien.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }
        public static bool ThemNhanVien(NS_NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"insert into nhanvien values(N'{0}', N'{1}',N'{2}',N'{3}','{4}',N'{5}',N'{6}','{7}')",
     nv.SMaNV, nv.STen, nv.SPhai, nv.DtNgaySinh, nv.SSDT, nv.SDiachi, nv.SQuyen, nv.SMatkhau);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static NS_NhanVien_DTO TimNhanVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from nhanVien where manv=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NS_NhanVien_DTO nv = new NS_NhanVien_DTO();
            nv.SMaNV = dt.Rows[0]["manv"].ToString();
            nv.STen = dt.Rows[0]["tennv"].ToString();
            nv.SPhai = dt.Rows[0]["gioitinh"].ToString();
            nv.DtNgaySinh = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());
            nv.SSDT = dt.Rows[0]["dienthoai"].ToString();
            nv.SDiachi = dt.Rows[0]["diachi"].ToString();
            nv.SQuyen = dt.Rows[0]["quyen"].ToString();
            nv.SMatkhau = dt.Rows[0]["matkhau"].ToString();
            DataProvider.DongKetNoi(con);
            return nv;
        }
        public static bool SuaNhanVien(NS_NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"UPDATE nhanVien SET tennv=N'{1}', gioitinh=N'{2}', ngaysinh='{3}',dienthoai='{4}',diachi=N'{5}',quyen=N'{6}',matkhau='{7}'WHERE manv=N'{0}'",
     nv.SMaNV, nv.STen, nv.SPhai, nv.DtNgaySinh, nv.SSDT, nv.SDiachi, nv.SQuyen, nv.SMatkhau);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaNhanVien(NS_NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"DELETE NhanVien WHERE manv=N'{0}'", nv.SMaNV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static List<NS_NhanVien_DTO> TimNhanVienTheoTen(string ten)

        {
            string sTruyVan = string.Format(@"select * from nhanvien where tennv like '%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)

            {
                return null;

            }
            List<NS_NhanVien_DTO> lstNhanVien = new List<DTO.NS_NhanVien_DTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NS_NhanVien_DTO nv = new NS_NhanVien_DTO();
                nv.SMaNV = dt.Rows[i]["manv"].ToString();
                nv.STen = dt.Rows[i]["tennv"].ToString();
                nv.SPhai = dt.Rows[i]["gioitinh"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                nv.SSDT = dt.Rows[i]["dienthoai"].ToString();
                nv.SDiachi = dt.Rows[i]["diachi"].ToString();
                nv.SQuyen = dt.Rows[i]["quyen"].ToString();
                nv.SMatkhau = dt.Rows[i]["matkhau"].ToString();
                lstNhanVien.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }
    }
}
