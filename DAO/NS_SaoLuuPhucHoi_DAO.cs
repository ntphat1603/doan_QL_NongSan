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
    public class NS_SaoLuuPhucHoi_DAO
    {
        static SqlConnection con;
        public static bool PhuchoiDuLieu(string sDuongDan)
        {
            //sDuongDan = sDuongDan.Substring(0, sDuongDan.Length - 2);
            string stRestore = "USE MASTER; ALTER DATABASE QL_NONG_SAN SET SINGLE_USER WITH ROLLBACK IMMEDIATE ";
            stRestore += " RESTORE DATABASE QL_NONG_SAN FROM DISK = N'" + sDuongDan + "'";
            stRestore += " WITH REPLACE";

           

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(stRestore, con);


            return kq;
        }
    }
}
