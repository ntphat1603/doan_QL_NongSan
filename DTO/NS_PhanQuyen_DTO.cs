using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NS_PhanQuyen_DTO
    {
        private string sMaPQ;

        public string SMaPQ
        {
            get { return sMaPQ; }
            set { sMaPQ = value; }
        }

        private string sTenPQ;

        public string STenPQ
        {
            get { return sTenPQ; }
            set { sTenPQ = value; }
        }
    }
}
