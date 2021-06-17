using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NS_SaoLuuPhucHoi_BUS
    {
        public static bool PhuchoiSaoLuu(string sDuongDan)
        {
            return NS_SaoLuuPhucHoi_DAO.PhuchoiDuLieu(sDuongDan);
        }
    }
}
