using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QLBanDienThoai
{
    public partial class Main : Form
    {
        Thread t;
        public Main()
        {
            InitializeComponent();
        }
        
        // xử lí mở form con
        private Form activeform = null;
        private void openChildForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm_AD.Controls.Add(childForm);
            panelChildForm_AD.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // xử lí chuyển màu khi click vào button
        private Button currentButton;
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#4169E1");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(39, 39, 58);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }

        private void btn_hanghoa_AD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new HangHoa());
        }

        private void btn_donhang_AD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new DonHang());
        }

        private void btn_khachhang_AD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new KhachHang());
        }

        private void btn_nhanvien_AD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new NhanVien());
        }

        private void btn_thongke_AD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new ThongKe());
        }

        private void btn_thoat_AD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {          
            //Mở kết nối
            Class.Functions.Connect();

            btn_hanghoa_AD.PerformClick();

            if ((bool)Properties.Settings.Default["FirstRun"] == true)
            {
                Properties.Settings.Default["FirstRun"] = false;

                // TH link ảnh cũ . tức là đã di chuyển Project qua 1 chỗ khác  
                // hoặc mở Project trên 1 máy khác thì link ảnh phải được cập nhật,
                // do ở đây là truyền link ảnh chứ không phải lưu ảnh ở Database   
                Class.Functions.update_imageLink();
            }

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Đóng kết nối
            Class.Functions.Disconnect();

            //Thoát
            Application.Exit();
        }
    }
}
