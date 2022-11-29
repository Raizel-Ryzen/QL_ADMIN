using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDienThoai.Class
{
    public class hangdienthoai
    {
        private string mahang;
        private string tenhang;

        public hangdienthoai() { }

        public void set_mahang(string mahang2)
        {
            mahang = mahang2;
        }

        public void set_tenhang(string tenhang2)
        {
            tenhang = tenhang2;
        }

        public string get_mahang()
        {
            return mahang;
        }

        public string get_tenhang()
        {
            return tenhang;
        }

        public bool Check_Data()
        {
            if (mahang.Length == 0 | tenhang.Length == 0)
                return false;
            return true;
        }

        public void Reset()
        {
            mahang = "";
            tenhang = "";
        }

    }
}
