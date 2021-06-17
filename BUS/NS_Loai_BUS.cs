using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class NS_Loai_BUS
    {
        public static List<NS_Loai_DTO> LayDSLoai()
        {
            return NS_Loai_DAO.LayDSLoai();
        }
        public static bool ThemLoai(NS_Loai_DTO loai)
        {
            return NS_Loai_DAO.ThemLoai(loai);
        }
        public static bool SuaLoai(NS_Loai_DTO loai)
        {
            return NS_Loai_DAO.SuaLoai(loai);
        }
        public static bool XoaLoai(NS_Loai_DTO loai)
        {
            return NS_Loai_DAO.XoaLoai(loai);
        }
        public static NS_Loai_DTO TimLoaiTheoMa(string ma)
        {
            return NS_Loai_DAO.TimLoaiTheoMa(ma);
        }
        public static List<NS_Loai_DTO> TimLoaiTheoTen(string ten)
        {
            return NS_Loai_DAO.TimLoaiTheoTen(ten);
        }
    }
}
