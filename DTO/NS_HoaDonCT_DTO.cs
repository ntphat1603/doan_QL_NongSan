using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NS_HoaDonCT_DTO
    {
        private string sMaHDCT;

        public string SMaHDCT
        {
            get { return sMaHDCT; }
            set { sMaHDCT = value; }
        }

        private string sMaHD;

        public string SMaHD
        {
            get { return sMaHD; }
            set { sMaHD = value; }
        }

        private string sMaNS;

        public string SMaNS
        {
            get { return sMaNS; }
            set { sMaNS = value; }
        }
        
        private string sTenNS;

        public string STenNS
        {
            get { return sTenNS; }
            set { sTenNS = value; }
        }

        private string sLoai;

        public string SLoai
        {
            get { return sLoai; }
            set { sLoai = value; }
        }

        private int sSLBan;

        public int SSLBan { get => sSLBan; set => sSLBan = value; }

        private string sDonGiaBan;

        public string SDonGiaBan { get => sDonGiaBan; set => sDonGiaBan = value; }
    }
}
