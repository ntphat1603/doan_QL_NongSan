using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NS_KhachHang_BUS
    {
        public static List<NS_KhachHang_DTO> LayDSKhachHang()
        {
            return NS_KhachHang_DAO.LayDSKhachHang();
        }
        public static bool ThemKhachHang(NS_KhachHang_DTO nv)
        {
            return NS_KhachHang_DAO.ThemKhachHang(nv);
        }
        public static bool SuaKhachHang(NS_KhachHang_DTO nv)
        {
            return NS_KhachHang_DAO.SuaKhachHang(nv);
        }
        public static bool XoaKhachHang(NS_KhachHang_DTO nv)
        {
            return NS_KhachHang_DAO.XoaKhachHang(nv);
        }
        public static NS_KhachHang_DTO TimKhachHangTheoMa(string ma)
        {
            return NS_KhachHang_DAO.TimKhachHangTheoMa(ma);
        }
        public static List<NS_KhachHang_DTO> TimKhachHangTheoTen(string ten)
        {
            return NS_KhachHang_DAO.TimKhachHangTheoTen(ten);
        }
    }
}
