using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NS_HoaDonCT_BUS
    {
        public static List<NS_HoaDonCT_DTO> LayDSHoaDonCT()
        {
            return NS_HoaDonCT_DAO.LayDSHoaDonCT();
        }
        public static bool ThemHoaDonCT(NS_HoaDonCT_DTO hd)
        {
            return NS_HoaDonCT_DAO.ThemHoaDonCT(hd);
        }
        public static bool SuaHoaDonCT(NS_HoaDonCT_DTO hd)
        {
            return NS_HoaDonCT_DAO.SuaHoaDonCT(hd);
        }
        public static bool XoaHoaDonCT(NS_HoaDonCT_DTO hd)
        {
            return NS_HoaDonCT_DAO.XoaHoaDonCT(hd);
        }
        public static NS_HoaDonCT_DTO TimHoaDonCTTheoMa(string ma)
        {
            return NS_HoaDonCT_DAO.TimHoaDonCTTheoMa(ma);
        }
    }
}
