using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLBanDienThoai
{
    public partial class ThongKe : Form
    {
        private static int thangban_MHBC = 0;
        DataTable tblMHBC;
        private void setFont_MHBC() // set Font cho các textBox 
        {
            txtBox_mahang_MHBC.Font = new Font("Time New Roman", 12);
            txtBox_tenhang_MHBC.Font = new Font("Time New Roman", 12);
            txtBox_madt_MHBC.Font = new Font("Time New Roman", 12);
            txtBox_tendt_MHBC.Font = new Font("Time New Roman", 12);
            txtBox_soluongban_MHBC.Font = new Font("Time New Roman", 12);
            cbBox_thangban_MHBC.Font = new Font("Time New Roman", 12);
            txtBox_linkanh_MHBC.Font = new Font("Time New Roman", 12);
        }

        private void ResetValues_MHBC() // reset giá trị cho các mục 
        {
            txtBox_mahang_MHBC.Text = "";
            txtBox_tenhang_MHBC.Text = "";
            txtBox_madt_MHBC.Text = "";
            txtBox_tendt_MHBC.Text = "";
            txtBox_soluongban_MHBC.Text = "";         
            txtBox_linkanh_MHBC.Text = "";
            picBox_anh_MHBC.Image = null;

            // lấy tháng trước ra
            DateTime date = DateTime.Now;
            thangban_MHBC = date.Month - 1;
            cbBox_thangban_MHBC.Text = thangban_MHBC.ToString();
        }

        private void getData_MHBC()
        {
            // khi vào tab chúng ta sẽ lấy top 10 mặt hàng bán chạy nhất tháng trước và tải vào DataGridView
            // xử lí lấy mã hãng, tên hãng, madt , tên dt, link ảnh
            string sql = "SELECT HDT.MAHANG, HDT.TENHANG, DT.MADT, DT.TENDT, DT.ANH " +
                "FROM DIENTHOAI DT, HANGDIENTHOAI HDT " +
                "WHERE DT.MAHANG = HDT.MAHANG " +
                "AND DT.MADT IN (SELECT TOP 10 DT2.MADT " +
                                   "FROM DIENTHOAI DT2, DONHANG DH2 " +
                                   "WHERE DT2.MADT = DH2.MADT " +
                                   "AND MONTH(DH2.NGAYBAN) = '" + thangban_MHBC + "' " +
                                   "GROUP BY DT2.MADT " +
                                   "ORDER BY SUM(DH2.SOLUONG) DESC)";
            tblMHBC = Class.Functions.GetDataToTable(sql);

            // xử lí lấy số lượng bán được trong tháng
            sql = "SELECT TOP 10 SUM(DH.SOLUONG) AS SOLUONGBAN " +
                "FROM DIENTHOAI DT, DONHANG DH " +
                "WHERE DT.MADT = DH.MADT " +
                "AND MONTH(DH.NGAYBAN) = '" + thangban_MHBC + "' " +
                "GROUP BY DT.MADT " +
                "ORDER BY SUM(DH.SOLUONG) DESC";
            DataTable tbl2 = Class.Functions.GetDataToTable(sql);

            int i = 0;
            tblMHBC.Columns.Add("SOLUONGDABAN", typeof(System.Int32));
            foreach (DataRow row in tblMHBC.Rows)
            {
                row["SOLUONGDABAN"] = tbl2.Rows[i].Field<Int32>(0);
                i++;
            }
            dgv_MHBC.DataSource = tblMHBC;
        }

        private void LoadData_MHBC() // tải dữ liệu vào DataGridView
        {
            // xử lí câu lệnh sql
            getData_MHBC();

            // set Font cho tên cột
            dgv_MHBC.Font = new Font("Time New Roman", 13);
            dgv_MHBC.Columns[0].HeaderText = "Mã Hãng";
            dgv_MHBC.Columns[1].HeaderText = "Tên Hãng";
            dgv_MHBC.Columns[2].HeaderText = "Mã Điện Thoại";
            dgv_MHBC.Columns[3].HeaderText = "Tên Điện Thoại";           
            dgv_MHBC.Columns[4].HeaderText = "Ảnh";
            dgv_MHBC.Columns[5].HeaderText = "Số Lượng Đã Bán";

            // set Font cho dữ liệu hiển thị trong cột
            dgv_MHBC.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dgv_MHBC.Columns[0].Width = 120;
            dgv_MHBC.Columns[1].Width = 120;
            dgv_MHBC.Columns[2].Width = 160;
            dgv_MHBC.Columns[3].Width = 160;
            dgv_MHBC.Columns[4].Width = 220;
            dgv_MHBC.Columns[5].Width = 180;          

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_MHBC.AllowUserToAddRows = false;
            dgv_MHBC.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void tabPage_mathangbanchay_Enter(object sender, EventArgs e) // tải dữ liệu cho tab
        {        
            // set giá trị cho comboBox
            for (int i = 1; i <= 12; i++)
                cbBox_thangban_MHBC.Items.Add(i.ToString());         

            setFont_MHBC();
            ResetValues_MHBC();
            LoadData_MHBC();

            is_inTab_TK = 2;
        }

        private void tabPage_mathangbanchay_Leave(object sender, EventArgs e) // khi rời tab
        {
            ResetValues_MHBC();

            // làm trống comboBox
            cbBox_thangban_MHBC.Items.Clear();
        }

        private void btn_timkiem_MHBC_Click(object sender, EventArgs e) // khi click vào nút tìm kiếm
        {
            // TH nếu chưa chọn tháng
            if (cbBox_thangban_MHBC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn tháng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // reset lại các TextBox, PicBox
            txtBox_mahang_MHBC.Text = "";
            txtBox_tenhang_MHBC.Text = "";
            txtBox_madt_MHBC.Text = "";
            txtBox_tendt_MHBC.Text = "";
            txtBox_soluongban_MHBC.Text = "";
            txtBox_linkanh_MHBC.Text = "";
            picBox_anh_MHBC.Image = null;


            thangban_MHBC = Int32.Parse(cbBox_thangban_MHBC.Text.Trim().ToString());

            // xử lí câu lệnh sql
            getData_MHBC();

            // TH nếu ko có dữ liệu         
            if (tblMHBC.Rows.Count == 0)
            {
                MessageBox.Show("Không có mặt hàng nào được bán trong tháng " + thangban_MHBC, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void dgv_MHBC_Click(object sender, EventArgs e) // khi click vào dataGridView
        {
            //Nếu không có dữ liệu
            if (tblMHBC.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // set giá trị cho các mục 
            txtBox_mahang_MHBC.Text = dgv_MHBC.CurrentRow.Cells["MAHANG"].Value.ToString();
            txtBox_tenhang_MHBC.Text = dgv_MHBC.CurrentRow.Cells["TENHANG"].Value.ToString();
            txtBox_madt_MHBC.Text = dgv_MHBC.CurrentRow.Cells["MADT"].Value.ToString();
            txtBox_tendt_MHBC.Text = dgv_MHBC.CurrentRow.Cells["TENDT"].Value.ToString();
            txtBox_soluongban_MHBC.Text = dgv_MHBC.CurrentRow.Cells["SOLUONGDABAN"].Value.ToString();
            txtBox_linkanh_MHBC.Text = dgv_MHBC.CurrentRow.Cells["ANH"].Value.ToString();
            try
            {
                picBox_anh_MHBC.Image = Image.FromFile(txtBox_linkanh_MHBC.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load ảnh thất bại, vui lòng kiểm tra lại đường dẫn tới ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                     
        }
    }
}
