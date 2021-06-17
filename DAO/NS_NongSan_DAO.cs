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
    public class NS_NongSan_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả nhân viên
        public static List<NS_NongSan_DTO> LayDSNongSan()
        {
            string sTruyVan = "select * from nongsan";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NS_NongSan_DTO> lstNhanVien = new List<DTO.NS_NongSan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NS_NongSan_DTO ns = new NS_NongSan_DTO();
                ns.SMaNS = dt.Rows[i]["ma_nongsan"].ToString();
                ns.SLoaiNS = dt.Rows[i]["loai_nongsan"].ToString();
                ns.STenNS = dt.Rows[i]["ten_nongsan"].ToString();
                ns.DtNgayNhap = DateTime.Parse(dt.Rows[i]["ngay_nhap"].ToString());
                ns.SSLTon = dt.Rows[i]["soluongton"].ToString();
                ns.SGiaBan = dt.Rows[i]["giaban"].ToString();
                ns.SGiaNhap = dt.Rows[i]["gianhap"].ToString();
                lstNhanVien.Add(ns);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }
        public static bool ThemNongSan(NS_NongSan_DTO nv)
        {
            string sTruyVan = string.Format(@"insert into nongsan values(N'{0}', N'{1}',N'{2}',N'{3}','{4}',N'{5}',N'{6}')", nv.SMaNS, nv.SLoaiNS, nv.STenNS, nv.DtNgayNhap, nv.SSLTon, nv.SGiaBan, nv.SGiaNhap);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static NS_NongSan_DTO TimNongSanTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from nongsan where ma_nongsan=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NS_NongSan_DTO ns = new NS_NongSan_DTO();
            ns.SMaNS = dt.Rows[0]["ma_nongsan"].ToString();
            ns.SLoaiNS = dt.Rows[0]["loai_nongsan"].ToString();
            ns.STenNS = dt.Rows[0]["ten_nongsan"].ToString();
            ns.DtNgayNhap = DateTime.Parse(dt.Rows[0]["ngay_nhap"].ToString());
            ns.SSLTon = dt.Rows[0]["soluongton"].ToString();
            ns.SGiaBan = dt.Rows[0]["giaban"].ToString();
            ns.SGiaNhap = dt.Rows[0]["gianhap"].ToString();
            DataProvider.DongKetNoi(con);
            return ns;
        }
        public static bool SuaNongSan(NS_NongSan_DTO ns)
        {
            string sTruyVan = string.Format(@"UPDATE nongsan SET loai_nongsan=N'{1}', ten_nongsan=N'{2}', ngay_nhap='{3}',soluongton='{4}',giaban='{5}',gianhap='{6}'WHERE ma_nongsan=N'{0}'",
     ns.SMaNS, ns.SLoaiNS, ns.STenNS, ns.DtNgayNhap, ns.SSLTon, ns.SGiaBan, ns.SGiaNhap);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaNongSan(NS_NongSan_DTO ns)
        {
            string sTruyVan = string.Format(@"DELETE nongsan WHERE ma_nongsan=N'{0}'", ns.SMaNS);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static List<NS_NongSan_DTO> TimNongSanTheoTen(string ten)

        {
            string sTruyVan = string.Format(@"select * from nongsan where ten_nongsan like '%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)

            {
                return null;

            }
            List<NS_NongSan_DTO> lstNongSan = new List<DTO.NS_NongSan_DTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NS_NongSan_DTO ns = new NS_NongSan_DTO();
                ns.SMaNS = dt.Rows[i]["ma_nongsan"].ToString();
                ns.SLoaiNS = dt.Rows[i]["loai_nongsan"].ToString();
                ns.STenNS = dt.Rows[i]["ten_nongsan"].ToString();
                ns.DtNgayNhap = DateTime.Parse(dt.Rows[i]["ngay_nhap"].ToString());
                ns.SSLTon = dt.Rows[i]["soluongton"].ToString();
                ns.SGiaBan = dt.Rows[i]["giaban"].ToString();
                ns.SGiaNhap = dt.Rows[i]["gianhap"].ToString();
                lstNongSan.Add(ns);
            }
            DataProvider.DongKetNoi(con);
            return lstNongSan;
        }
    }
}
