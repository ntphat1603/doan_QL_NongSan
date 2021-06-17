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
    public class NS_KhachHang_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả nhân viên
        public static List<NS_KhachHang_DTO> LayDSKhachHang()
        {
            string sTruyVan = "select * from khachhang";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NS_KhachHang_DTO> lstKhachHang = new List<DTO.NS_KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NS_KhachHang_DTO nv = new NS_KhachHang_DTO();
                nv.SMaKH = dt.Rows[i]["makh"].ToString();
                nv.STen = dt.Rows[i]["tenkh"].ToString();
                nv.SPhai = dt.Rows[i]["gioitinh"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                nv.SSDT = dt.Rows[i]["dienthoai"].ToString();
                nv.SDiachi = dt.Rows[i]["diachi"].ToString();
                lstKhachHang.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstKhachHang;
        }
        public static bool ThemKhachHang(NS_KhachHang_DTO nv)
        {
            string sTruyVan = string.Format(@"insert into khachhang values(N'{0}', N'{1}',N'{2}',N'{3}','{4}',N'{5}')",
     nv.SMaKH, nv.STen, nv.SPhai, nv.DtNgaySinh, nv.SSDT, nv.SDiachi);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static NS_KhachHang_DTO TimKhachHangTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from khachhang where makh=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NS_KhachHang_DTO nv = new NS_KhachHang_DTO();
            nv.SMaKH = dt.Rows[0]["makh"].ToString();
            nv.STen = dt.Rows[0]["tenkh"].ToString();
            nv.SPhai = dt.Rows[0]["gioitinh"].ToString();
            nv.DtNgaySinh = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());
            nv.SSDT = dt.Rows[0]["dienthoai"].ToString();
            nv.SDiachi = dt.Rows[0]["diachi"].ToString();
            DataProvider.DongKetNoi(con);
            return nv;
        }
        public static bool SuaKhachHang(NS_KhachHang_DTO nv)
        {
            string sTruyVan = string.Format(@"UPDATE khachhang SET tenkh=N'{1}', gioitinh=N'{2}', ngaysinh='{3}',dienthoai='{4}',diachi=N'{5}'WHERE makh=N'{0}'",
     nv.SMaKH, nv.STen, nv.SPhai, nv.DtNgaySinh, nv.SSDT, nv.SDiachi);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaKhachHang(NS_KhachHang_DTO nv)
        {
            string sTruyVan = string.Format(@"DELETE khachhang WHERE makh=N'{0}'", nv.SMaKH);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static List<NS_KhachHang_DTO> TimKhachHangTheoTen(string ten)

        {
            string sTruyVan = string.Format(@"select * from khachhang where tenkh like '%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)

            {
                return null;

            }
            List<NS_KhachHang_DTO> lstKhachHang = new List<DTO.NS_KhachHang_DTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NS_KhachHang_DTO nv = new NS_KhachHang_DTO();
                nv.SMaKH = dt.Rows[i]["manv"].ToString();
                nv.STen = dt.Rows[i]["tennv"].ToString();
                nv.SPhai = dt.Rows[i]["gioitinh"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                nv.SSDT = dt.Rows[i]["dienthoai"].ToString();
                nv.SDiachi = dt.Rows[i]["diachi"].ToString();
                lstKhachHang.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstKhachHang;
        }
    }
}
