using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NS_HoaDon_BUS
    {
        public static List<NS_HoaDon_DTO> LayDSHoaDon()
        {
            return NS_HoaDon_DAO.LayDSHoaDon();
        }
        public static bool ThemHoaDon(NS_HoaDon_DTO hd)
        {
            return NS_HoaDon_DAO.ThemHoaDon(hd);
        }
        public static bool SuaHoaDon(NS_HoaDon_DTO hd)
        {
            return NS_HoaDon_DAO.SuaHoaDon(hd);
        }
        public static bool XoaHoaDon(NS_HoaDon_DTO hd)
        {
            return NS_HoaDon_DAO.XoaHoaDon(hd);
        }
        public static NS_HoaDon_DTO TimHoaDonTheoMa(string ma)
        {
            return NS_HoaDon_DAO.TimHoaDonTheoMa(ma);
        }
    }
}
