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
    public class NS_PhanQuyen_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả loại nông sản

        public static List<NS_PhanQuyen_DTO> LayDSPhanQuyen()
        {
            string sTruyVan = "select * from phanquyen";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NS_PhanQuyen_DTO> lstLoai = new List<DTO.NS_PhanQuyen_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NS_PhanQuyen_DTO pq = new NS_PhanQuyen_DTO();
                pq.SMaPQ = dt.Rows[i]["maphanquyen"].ToString();
                pq.STenPQ = dt.Rows[i]["tenphanquyen"].ToString();
                lstLoai.Add(pq);
            }
            DataProvider.DongKetNoi(con);
            return lstLoai;
        }
        public static bool ThemPhanQuyen(NS_PhanQuyen_DTO pq)
        {
            string sTruyVan = string.Format(@"insert into phanquyen values(N'{0}', N'{1}')", pq.SMaPQ, pq.STenPQ);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static NS_PhanQuyen_DTO TimPhanQuyenTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from phanquyen where maphanquyen=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NS_PhanQuyen_DTO pq = new NS_PhanQuyen_DTO();
            pq.SMaPQ = dt.Rows[0]["maphanquyen"].ToString();
            pq.STenPQ = dt.Rows[0]["tenphanquyen"].ToString();
            DataProvider.DongKetNoi(con);
            return pq;
        }
        public static bool SuaPhanQuyen(NS_PhanQuyen_DTO pq)
        {
            string sTruyVan = string.Format(@"UPDATE phanquyen SET tenphanquyen=N'{1}'WHERE maphanquyen=N'{0}'", pq.SMaPQ, pq.STenPQ);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaPhanQuyen(NS_PhanQuyen_DTO pq)
        {
            string sTruyVan = string.Format(@"DELETE phanquyen WHERE maphanquyen=N'{0}'", pq.SMaPQ);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static List<NS_PhanQuyen_DTO> TimPhanQuyenTheoTen(string ten)

        {
            string sTruyVan = string.Format(@"select * from phanquyen where tenphanquyen like '%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)

            {
                return null;

            }
            List<NS_PhanQuyen_DTO> lstPhanQuyen = new List<DTO.NS_PhanQuyen_DTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NS_PhanQuyen_DTO pq = new NS_PhanQuyen_DTO();
                pq.SMaPQ = dt.Rows[i]["maphanquyen"].ToString();
                pq.STenPQ = dt.Rows[i]["tenphanquyen"].ToString();
            }
            DataProvider.DongKetNoi(con);
            return lstPhanQuyen;
        }
    }
}
