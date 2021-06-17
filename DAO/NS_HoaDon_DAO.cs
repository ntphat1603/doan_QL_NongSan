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
    public class NS_HoaDon_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả hoá đơn
        public static List<NS_HoaDon_DTO> LayDSHoaDon()
        {
            string sTruyVan = "select * from hoadon";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NS_HoaDon_DTO> lstHoaDon = new List<DTO.NS_HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NS_HoaDon_DTO hd = new NS_HoaDon_DTO();
                hd.SMaHD = dt.Rows[i]["mahd"].ToString();
                hd.SMaKH = dt.Rows[i]["makh"].ToString();
                hd.STenKH = dt.Rows[i]["tenkh"].ToString();
                hd.SMaNV = dt.Rows[i]["manv"].ToString();
                hd.DtNgayBan = DateTime.Parse(dt.Rows[i]["ngayban"].ToString());
                hd.STONG = int.Parse(dt.Rows[i]["tongtien"].ToString());
                lstHoaDon.Add(hd);
            }
            DataProvider.DongKetNoi(con);
            return lstHoaDon;
        }
        public static bool ThemHoaDon(NS_HoaDon_DTO hd)
        {
            string sTruyVan = string.Format(@"insert into hoadon values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')",
            hd.SMaHD,hd.SMaKH,hd.STenKH, hd.SMaNV, hd.DtNgayBan,hd.STONG);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static NS_HoaDon_DTO TimHoaDonTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from hoadon where mahd=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NS_HoaDon_DTO hd = new NS_HoaDon_DTO();
            hd.SMaHD = dt.Rows[0]["mahd"].ToString();
            hd.SMaKH = dt.Rows[0]["makh"].ToString();
            hd.STenKH = dt.Rows[0]["tenkh"].ToString();
            hd.SMaNV = dt.Rows[0]["manv"].ToString();
            hd.DtNgayBan = DateTime.Parse(dt.Rows[0]["ngayban"].ToString());
            hd.STONG = int.Parse(dt.Rows[0]["tongtien"].ToString());
            DataProvider.DongKetNoi(con);
            return hd;
        }

        public static bool SuaHoaDon(NS_HoaDon_DTO hd)
        {
            string sTruyVan = string.Format(@"UPDATE hoadon SET makh='{1}', tenkh=N'{2}',manv='{3}',ngayban='{4}',tongtien=N'{5}'WHERE mahd=N'{0}'",
     hd.SMaHD, hd.SMaKH, hd.STenKH, hd.SMaNV, hd.DtNgayBan, hd.STONG);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaHoaDon(NS_HoaDon_DTO hd)
        {
            string sTruyVan = string.Format(@"DELETE hoadon WHERE mahd=N'{0}'", hd.SMaHD);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
