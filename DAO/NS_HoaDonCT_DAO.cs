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
    public class NS_HoaDonCT_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả hoá đơn
        public static List<NS_HoaDonCT_DTO> LayDSHoaDonCT()
        {
            string sTruyVan = "select * from hoadonchitiet";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NS_HoaDonCT_DTO> lstHoaDonCT = new List<DTO.NS_HoaDonCT_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NS_HoaDonCT_DTO hd = new NS_HoaDonCT_DTO();
                hd.SMaHDCT = dt.Rows[i]["mahdct"].ToString();
                hd.SMaHD = dt.Rows[i]["mahd"].ToString();
                hd.SMaNS = dt.Rows[i]["ma_nongsan"].ToString();
                hd.STenNS = dt.Rows[i]["ten_nongsan"].ToString();
                hd.SLoai = dt.Rows[i]["loai"].ToString();
                hd.SSLBan = int.Parse(dt.Rows[i]["soluong"].ToString());
                hd.SDonGiaBan = dt.Rows[i]["dongia"].ToString();
                //hd.SThanhTien = int.Parse(dt.Rows[i]["thanhtien"].ToString());
                lstHoaDonCT.Add(hd);
            }
            DataProvider.DongKetNoi(con);
            return lstHoaDonCT;
        }
        public static bool ThemHoaDonCT(NS_HoaDonCT_DTO hd)
        {
            string sTruyVan = string.Format(@"insert into hoadonchitiet values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
            hd.SMaHDCT,hd.SMaHD, hd.SMaNS, hd.STenNS,hd.SLoai, hd.SSLBan, hd.SDonGiaBan);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static NS_HoaDonCT_DTO TimHoaDonCTTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from hoadonchitiet where mahdct=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NS_HoaDonCT_DTO hd = new NS_HoaDonCT_DTO();
            hd.SMaHDCT = dt.Rows[0]["mahdct"].ToString();
            hd.SMaHD = dt.Rows[0]["mahd"].ToString();
            hd.SMaNS = dt.Rows[0]["ma_nongsan"].ToString();
            hd.STenNS = dt.Rows[0]["ten_nongsan"].ToString();
            hd.SLoai = dt.Rows[0]["loai"].ToString();
            hd.SSLBan = int.Parse(dt.Rows[0]["soluong"].ToString());
            hd.SDonGiaBan = dt.Rows[0]["dongia"].ToString();
            DataProvider.DongKetNoi(con);
            return hd;
        }
        public static bool SuaHoaDonCT(NS_HoaDonCT_DTO hd)
        {
            string sTruyVan = string.Format(@"UPDATE hoadonchitiet SET mahd=N'{1}',ma_nongsan=N'{2}',ten_nongsan=N'{3}',loai=N'{4}',soluong='{5}',dongia='{6}'WHERE mahdct=N'{0}'",
    hd.SMaHDCT,hd.SMaHD, hd.SMaNS, hd.STenNS, hd.SLoai, hd.SSLBan, hd.SDonGiaBan);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaHoaDonCT(NS_HoaDonCT_DTO hd)
        {
            string sTruyVan = string.Format(@"DELETE hoadonchitiet WHERE mahdct=N'{0}'", hd.SMaHDCT);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
