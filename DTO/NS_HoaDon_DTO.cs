using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NS_HoaDon_DTO
    {
        private string sMaHD;

        public string SMaHD
        {
            get { return sMaHD; }
            set { sMaHD = value; }
        }
        private String sMaKH;

        public String SMaKH
        {
            get { return sMaKH; }
            set { sMaKH = value; }
        }

        private string sTenKH;

        public string STenKH
        {
            get { return sTenKH; }
            set { sTenKH = value; }
        }

        private string sMaNV;

        public string SMaNV
        {
            get { return sMaNV; }
            set { sMaNV = value; }
        }
        private DateTime dtNgayBan;

        public DateTime DtNgayBan
        {
            get { return dtNgayBan; }
            set { dtNgayBan = value; }
        }
        private int sTONG;

        public int STONG
        {
            get { return sTONG; }
            set { sTONG = value; }
        }
    }
}