using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanDienThoai
{
    public partial class HangHoa : Form
    {      
        public HangHoa()
        {
            InitializeComponent();
        }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            LoadData_HDT();
        }

   
    }
}
