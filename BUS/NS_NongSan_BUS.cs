using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NS_NongSan_BUS
    {
        public static List<NS_NongSan_DTO> LayDSNongSan()
        {
            return NS_NongSan_DAO.LayDSNongSan();
        }
        public static bool ThemNongSan(NS_NongSan_DTO ns)
        {
            return NS_NongSan_DAO.ThemNongSan(ns);
        }
        public static bool SuaNongSan(NS_NongSan_DTO ns)
        {
            return NS_NongSan_DAO.SuaNongSan(ns);
        }
        public static bool XoaNongSan(NS_NongSan_DTO ns)
        {
            return NS_NongSan_DAO.XoaNongSan(ns);
        }
        public static NS_NongSan_DTO TimNongSanTheoMa(string ma)
        {
            return NS_NongSan_DAO.TimNongSanTheoMa(ma);
        }
        public static List<NS_NongSan_DTO> TimNongSanTheoTen(string ten)
        {
            return NS_NongSan_DAO.TimNongSanTheoTen(ten);
        }
    }
}
