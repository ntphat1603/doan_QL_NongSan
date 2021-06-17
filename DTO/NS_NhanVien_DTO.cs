using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NS_NhanVien_DTO
    {
        private string sMaNV;

        public string SMaNV
        {
            get { return sMaNV; }
            set { sMaNV = value; }
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

        private string sQuyen;

        public string SQuyen { get => sQuyen; set => sQuyen = value; }

        private string sMatkhau;

        public string SMatkhau { get => sMatkhau; set => sMatkhau = value; }
    }
}
