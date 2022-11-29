using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;


namespace QLBanDienThoai
{
    public partial class ThongKe : Form
    {
        DataTable tblMHSH;
        private void setFont_MHSH() // set Font cho các textBox 
        {
            txtBox_mahang_MHSH.Font = new Font("Time New Roman", 12);
            txtBox_tenhang_MHSH.Font = new Font("Time New Roman", 12);
            txtBox_madt_MHSH.Font = new Font("Time New Roman", 12);
            txtBox_tendt_MHSH.Font = new Font("Time New Roman", 12);
            txtBox_soluong_MHSH.Font = new Font("Time New Roman", 12);
            txtBox_linkanh_MHSH.Font = new Font("Time New Roman", 12);
        }

        private void ResetValues_MHSH() // reset giá trị cho các mục 
        {
            txtBox_mahang_MHSH.Text = "";
            txtBox_tenhang_MHSH.Text = "";
            txtBox_madt_MHSH.Text = "";
            txtBox_tendt_MHSH.Text = "";
            txtBox_soluong_MHSH.Text = "";
            txtBox_linkanh_MHSH.Text = "";
            picBox_anh_MHSH.Image = null;
        }

        private void LoadData_MHSH() // tải dữ liệu vào DataGridView
        {
            string sql;         
            
            sql = "SELECT DT.MAHANG, HDT.TENHANG, DT.MADT, DT.TENDT, DT.SOLUONG, DT.ANH " +
                "FROM DIENTHOAI DT JOIN HANGDIENTHOAI HDT ON DT.MAHANG = HDT.MAHANG " +
                "WHERE DT.SOLUONG < 10 ";
            tblMHSH = Class.Functions.GetDataToTable(sql);
            dgv_MHSH.DataSource = tblMHSH;

            // set Font cho tên cột
            dgv_MHSH.Font = new Font("Time New Roman", 13);
            dgv_MHSH.Columns[0].HeaderText = "Mã Hãng";
            dgv_MHSH.Columns[1].HeaderText = "Tên Hãng";
            dgv_MHSH.Columns[2].HeaderText = "Mã Điện Thoại";
            dgv_MHSH.Columns[3].HeaderText = "Tên Điện Thoại";
            dgv_MHSH.Columns[4].HeaderText = "Số Lượng Còn Lại";
            dgv_MHSH.Columns[5].HeaderText = "Ảnh";

            // set Font cho dữ liệu hiển thị trong cột
            dgv_MHSH.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dgv_MHSH.Columns[0].Width = 120;
            dgv_MHSH.Columns[1].Width = 120;
            dgv_MHSH.Columns[2].Width = 160;
            dgv_MHSH.Columns[3].Width = 160;
            dgv_MHSH.Columns[4].Width = 180;
            dgv_MHSH.Columns[5].Width = 220;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_MHSH.AllowUserToAddRows = false;
            dgv_MHSH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void tabPage_mathangsaphet_Enter(object sender, EventArgs e) // khi vào tab 
        {         
            setFont_MHSH();
            ResetValues_MHSH();
            LoadData_MHSH();
        }

        // khi vào tab thống kê, xử lí load dữ liệu cho các tab con mà người dùng đang chọn
        // TH chọn tab doanh thu ở tab thống kê, khi qua tab đơn hàng chỉnh sửa thông tin đơn hàng 
        // thì khi quay lại tab doanh thu dữ liệu sẽ được cập nhật luôn
        private void tabPage_thongke_Enter(object sender, EventArgs e) 
        {
            //if (is_inTab_TK == 1)                                      
            {
                setFont_MHSH();
                ResetValues_MHSH();
                LoadData_MHSH();
            }
          //  else if (is_inTab_TK == 2)
            {
                setFont_MHBC();
                ResetValues_MHBC();
                LoadData_MHBC();
            }
          //  else if (is_inTab_TK == 3)
            {
                setFont_DThu();
                ResetValues_DThu();
                LoadData_DThu();
            }
        }

        private void tabPage_mathangsaphet_Leave(object sender, EventArgs e) // xử lí khi rời tab 
        {
            ResetValues_MHSH();
        }
        private void dgv_MHSH_Click(object sender, EventArgs e) // khi click vào dataGridView
        {          
            //Nếu không có dữ liệu
            if (tblMHSH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // set giá trị cho các mục 
            txtBox_mahang_MHSH.Text = dgv_MHSH.CurrentRow.Cells["MAHANG"].Value.ToString();
            txtBox_tenhang_MHSH.Text = dgv_MHSH.CurrentRow.Cells["TENHANG"].Value.ToString();
            txtBox_madt_MHSH.Text = dgv_MHSH.CurrentRow.Cells["MADT"].Value.ToString();
            txtBox_tendt_MHSH.Text = dgv_MHSH.CurrentRow.Cells["TENDT"].Value.ToString();
            txtBox_soluong_MHSH.Text = dgv_MHSH.CurrentRow.Cells["SOLUONG"].Value.ToString();
            txtBox_linkanh_MHSH.Text = dgv_MHSH.CurrentRow.Cells["ANH"].Value.ToString();
            try
            {
                picBox_anh_MHSH.Image = Image.FromFile(txtBox_linkanh_MHSH.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load ảnh thất bại, vui lòng kiểm tra lại đường dẫn tới ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}