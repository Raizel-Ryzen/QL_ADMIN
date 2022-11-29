using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLBanDienThoai
{
    public partial class ThongKe : Form
    {
        int is_inTab_TK;
        DataTable tblDThu;
        private void setFont_DThu() // set Font cho các textBox 
        {
            txtBox_thang_DThu.Font = new Font("Time New Roman", 12);
            txtBox_soluong_DThu.Font = new Font("Time New Roman", 12);
            txtBox_doanhthu_DThu.Font = new Font("Time New Roman", 12);
            txtBox_loinhuan_DThu.Font = new Font("Time New Roman", 12);
        }

        private void ResetValues_DThu() // reset giá trị cho các mục 
        {
            txtBox_thang_DThu.Text = "";
            txtBox_soluong_DThu.Text = "";
            txtBox_doanhthu_DThu.Text = "";
            txtBox_loinhuan_DThu.Text = "";          
        }

        private void getData_DThu() // lấy dữ liệu đổ vào bảng
        {
            tblDThu = new DataTable();

            // add các cột
            tblDThu.Columns.Add("THANG", typeof(string));
            tblDThu.Columns.Add("SLDABAN", typeof(string));
            tblDThu.Columns.Add("DOANHTHU", typeof(string));
            tblDThu.Columns.Add("LOINHUAN", typeof(string));

            for (int i = 1; i <= 12; i++)
            {
                // số lượng đã bán
                string sql = "SELECT SUM(SOLUONG) " +
                "FROM DONHANG " +
                "WHERE MONTH(NGAYBAN) = '" + i + "'";
                string sl_daban = Class.Functions.GetFieldValues(sql);
                if (sl_daban.Length == 0)
                    sl_daban = "0";

                //lấy tổng doanh thu
                sql = "SELECT SUM(TONGTIEN) " +
                    "FROM DONHANG " +
                    "WHERE MONTH(NGAYBAN) = '" + i + "'";
                int tongdoanhthu = 0;
                if (!sl_daban.Equals("0"))
                    tongdoanhthu = int.Parse(Class.Functions.GetFieldValues(sql));

                // lấy tổng chi phí bỏ ra
                sql = "SELECT SUM(DT.GIANHAP) " +
                    "FROM DIENTHOAI DT, DONHANG DH " +
                    "WHERE DH.MADT = DT.MADT " +
                    "AND MONTH(DH.NGAYBAN) = '" + i + "'";
                int tongchiphi = 0;
                if (!sl_daban.Equals("0"))
                    tongchiphi = int.Parse(Class.Functions.GetFieldValues(sql));

                tblDThu.Rows.Add(new object[] { i.ToString(), sl_daban, tongdoanhthu.ToString(), (tongdoanhthu - tongchiphi).ToString() });
            }

            dgv_DThu.DataSource = tblDThu;
        }
        private void LoadData_DThu() // tải dữ liệu cho dataGridView
        {
            getData_DThu();

            // set Font cho tên cột
            dgv_DThu.Font = new Font("Time New Roman", 13);
            dgv_DThu.Columns[0].HeaderText = "Tháng";
            dgv_DThu.Columns[1].HeaderText = "Số Lượng Đã Bán";
            dgv_DThu.Columns[2].HeaderText = "Doanh Thu";
            dgv_DThu.Columns[3].HeaderText = "Lợi Nhuận";

            // set Font cho dữ liệu hiển thị trong cột
            dgv_DThu.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dgv_DThu.Columns[0].Width = 240;
            dgv_DThu.Columns[1].Width = 240;
            dgv_DThu.Columns[2].Width = 240;
            dgv_DThu.Columns[3].Width = 240;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_DThu.AllowUserToAddRows = false;
            dgv_DThu.EditMode = DataGridViewEditMode.EditProgrammatically;           
        }

        private void dgv_DThu_Click(object sender, EventArgs e) // khi click vào dataGridView
        {
            //Nếu không có dữ liệu
            if (tblDThu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // set giá trị cho các mục 
            txtBox_thang_DThu.Text = dgv_DThu.CurrentRow.Cells["THANG"].Value.ToString();
            txtBox_soluong_DThu.Text = dgv_DThu.CurrentRow.Cells["SLDABAN"].Value.ToString();
            txtBox_doanhthu_DThu.Text = dgv_DThu.CurrentRow.Cells["DOANHTHU"].Value.ToString();
            txtBox_loinhuan_DThu.Text = dgv_DThu.CurrentRow.Cells["LOINHUAN"].Value.ToString();
        }       
        private void tabPage_doanhthu_Enter(object sender, EventArgs e) // tải dữ liệu cho tab
        {
            setFont_DThu();
            ResetValues_DThu();
            LoadData_DThu();

            is_inTab_TK = 3;
        }

        private void tabPage_doanhthu_Leave(object sender, EventArgs e) // khi rời tab
        {
            ResetValues_DThu();          
        }     
    }
}