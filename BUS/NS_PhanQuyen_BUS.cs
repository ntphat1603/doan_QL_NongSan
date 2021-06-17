using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NS_PhanQuyen_BUS
    {
        public static List<NS_PhanQuyen_DTO> LayDSPhanQuyen()
        {
            return NS_PhanQuyen_DAO.LayDSPhanQuyen();
        }
        public static bool ThemPhanQuyen(NS_PhanQuyen_DTO pq)
        {
            return NS_PhanQuyen_DAO.ThemPhanQuyen(pq);
        }
        public static bool SuaPhanQuyen(NS_PhanQuyen_DTO pq)
        {
            return NS_PhanQuyen_DAO.SuaPhanQuyen(pq);
        }
        public static bool XoaPhanQuyen(NS_PhanQuyen_DTO pq)
        {
            return NS_PhanQuyen_DAO.XoaPhanQuyen(pq);
        }
        public static NS_PhanQuyen_DTO TimPhanQuyenTheoMa(string ma)
        {
            return NS_PhanQuyen_DAO.TimPhanQuyenTheoMa(ma);
        }
        public static List<NS_PhanQuyen_DTO> TimPhanQuyenTheoTen(string ten)
        {
            return NS_PhanQuyen_DAO.TimPhanQuyenTheoTen(ten);
        }
    }
}
