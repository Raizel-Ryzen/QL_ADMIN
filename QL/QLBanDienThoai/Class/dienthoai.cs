using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDienThoai.Class
{
    public class dienthoai
    {
        private string mahang;
        private string madt;
        private string tendt;
        private string soluong;
        private string gianhap;
        private string giaban;
        private string linkanh;

        public dienthoai() { }

        public bool Check_Data()
        {
            if (mahang.Length == 0 | madt.Length == 0 | tendt.Length == 0 | soluong.Length == 0 |
                gianhap.Length == 0 | giaban.Length == 0 | linkanh.Length == 0 )
                return false;
            return true;
        }

        public void Reset()
        {
            mahang = "";
            madt = "";
            tendt = "";
            soluong = "";
            gianhap = "";
            giaban = "";
            linkanh = "";
        }

        public string get_mahang() { return mahang; }
        public string get_madt() { return madt;}
        public string get_tendt() { return tendt; }
        public string get_soluong () { return soluong ; }
        public string get_gianhap () { return gianhap; }
        public string get_giaban() { return giaban; }
        public string get_linkanh() { return linkanh; }

        public void set_mahang (string value) { mahang = value; }
        public void set_madt(string value) {  madt = value; }
        public void set_tendt(string value) { tendt = value; }
        public void set_soluong(string value) { soluong = value; }
        public void set_gianhap(string value) { gianhap = value; }
        public void set_giaban(string value) { giaban = value; }
        public void set_linkanh(string value) { linkanh = value; }
    }
}
