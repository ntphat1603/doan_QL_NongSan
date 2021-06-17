using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NS_NongSan_DTO
    {
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

        private string sLoaiNS;

        public string SLoaiNS
        {
            get { return sLoaiNS; }
            set { sLoaiNS = value; }
        }

        private DateTime dtNgayNhap;

        public DateTime DtNgayNhap
        {
            get { return dtNgayNhap; }
            set { dtNgayNhap = value; }
        }

        private string sSLTon;

        public string SSLTon { get => sSLTon; set => sSLTon = value; }

        private string sGiaBan;

        public string SGiaBan { get => sGiaBan; set => sGiaBan = value; }

        private string sGiaNhap;

        public string SGiaNhap { get => sGiaNhap; set => sGiaNhap = value; }
    }
}
