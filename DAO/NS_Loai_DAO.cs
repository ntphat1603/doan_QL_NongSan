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
    public class NS_Loai_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả loại nông sản

        public static List<NS_Loai_DTO> LayDSLoai()
        {
            string sTruyVan = "select * from loai";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NS_Loai_DTO> lstLoai = new List<DTO.NS_Loai_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NS_Loai_DTO loai = new NS_Loai_DTO();
                loai.SMaLoai = dt.Rows[i]["maloai"].ToString();
                loai.STenLoai = dt.Rows[i]["tenloai"].ToString();
                lstLoai.Add(loai);
            }
            DataProvider.DongKetNoi(con);
            return lstLoai;
        }
        public static bool ThemLoai(NS_Loai_DTO loai)
        {
            string sTruyVan = string.Format(@"insert into loai values(N'{0}', N'{1}')", loai.SMaLoai, loai.STenLoai);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static NS_Loai_DTO TimLoaiTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from loai where maloai=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NS_Loai_DTO loai = new NS_Loai_DTO();
            loai.SMaLoai = dt.Rows[0]["maloai"].ToString();
            loai.STenLoai = dt.Rows[0]["tenloai"].ToString();
            DataProvider.DongKetNoi(con);
            return loai;
        }
        public static bool SuaLoai(NS_Loai_DTO loai)
        {
            string sTruyVan = string.Format(@"UPDATE loai SET tenloai=N'{1}'WHERE maloai=N'{0}'", loai.SMaLoai, loai.STenLoai);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaLoai(NS_Loai_DTO loai)
        {
            string sTruyVan = string.Format(@"DELETE loai WHERE maloai=N'{0}'", loai.SMaLoai);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static List<NS_Loai_DTO> TimLoaiTheoTen(string ten)

        {
            string sTruyVan = string.Format(@"select * from loai where tenloai like '%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)

            {
                return null;

            }
            List<NS_Loai_DTO> lstLoai = new List<DTO.NS_Loai_DTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NS_Loai_DTO loai = new NS_Loai_DTO();
                loai.SMaLoai = dt.Rows[i]["maloai"].ToString();
                loai.STenLoai = dt.Rows[i]["tenloai"].ToString();
            }
            DataProvider.DongKetNoi(con);
            return lstLoai;
        }
    }
}
