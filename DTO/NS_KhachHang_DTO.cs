using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NS_KhachHang_DTO
    {
        private string sMaKH;

        public string SMaKH
        {
            get { return sMaKH; }
            set { sMaKH = value; }
        }


        private string sTen;

        public string STen
        {
            get { return sTen; }
            set { sTen = value; }
        }

        private string sPhai;

        public string SPhai
        {
            get { return sPhai; }
            set { sPhai = value; }
        }

        private DateTime dtNgaySinh;

        public DateTime DtNgaySinh
        {
            get { return dtNgaySinh; }
            set { dtNgaySinh = value; }
        }

        private string sSDT;

        public string SSDT { get => sSDT; set => sSDT = value; }

        private string sDiachi;

        public string SDiachi { get => sDiachi; set => sDiachi = value; }
    }
}
