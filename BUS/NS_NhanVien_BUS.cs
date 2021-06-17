using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NS_NhanVien_BUS
    {
        public static List<NS_NhanVien_DTO> LayDSNhanVien()
        {
            return NS_NhanVien_DAO.LayDSNhanVien();
        }
        public static bool ThemNhanVien(NS_NhanVien_DTO nv)
        {
            return NS_NhanVien_DAO.ThemNhanVien(nv);
        }
        public static bool SuaNhanVien(NS_NhanVien_DTO nv)
        {
            return NS_NhanVien_DAO.SuaNhanVien(nv);
        }
        public static bool XoaNhanVien(NS_NhanVien_DTO nv)
        {
            return NS_NhanVien_DAO.XoaNhanVien(nv);
        }
        public static NS_NhanVien_DTO TimNhanVienTheoMa(string ma)
        {
            return NS_NhanVien_DAO.TimNhanVienTheoMa(ma);
        }
        public static List<NS_NhanVien_DTO> TimNhanVienTheoTen(string ten)
        {
            return NS_NhanVien_DAO.TimNhanVienTheoTen(ten);
        }
    }
}
