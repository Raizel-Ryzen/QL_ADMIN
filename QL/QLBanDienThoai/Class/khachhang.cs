using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDienThoai.Class
{
    public class khachhang
    {
        private string makh;
        private string tenkh;
        private string diachi;
        private string sdt;

        public khachhang() { }

        public string get_makh() { return makh; }
        public string get_tenkh() { return tenkh; }
        public string get_sdt() { return sdt; }
        public string get_diachi() { return diachi; }

        public void set_makh(string value) { makh = value; }
        public void set_tenkh(string value) { tenkh = value; }
        public void set_sdt(string value) { sdt = value; }
        public void set_diachi(string value) { diachi = value; }
        public bool Check_Data()
        {
            if (makh.Length == 0 | tenkh.Length == 0 | sdt.Length == 0 | diachi.Length == 0)
                return false;
            return true;
        }

        public void Reset()
        {
            makh = "";
            tenkh = "";
            diachi = "";
            sdt = "";
        }
    }
}
