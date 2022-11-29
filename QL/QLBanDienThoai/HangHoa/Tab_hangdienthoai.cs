using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace QLBanDienThoai
{ 
    public partial class HangHoa : Form
    {
        DataTable tblHDT; // Chứa dữ liệu bảng HANGDIENTHOAI
        Class.hangdienthoai Obj_HDT = new Class.hangdienthoai();

        private void setFont_HDT() // set Font cho các textBox 
        {
            txtBox_mahang_HDT.Font = new Font("Time New Roman", 12);
            txtBox_tenhang_HDT.Font = new Font("Time New Roman", 12);
            
        }

        private void ResetValues_HDT() // reset giá trị cho các mục 
        {
            txtBox_mahang_HDT.Text = "";
            txtBox_tenhang_HDT.Text = "";

            btn_capnhat_HDT.Enabled = false;
            btn_xoa_HDT.Enabled = false;
            btn_luu_HDT.Enabled = false;
            btn_huy_HDT.Enabled = false;
            txtBox_mahang_HDT.Enabled = false;         
        }

        private void getData_fromTable_HDT() // lấy dữ liệu từ bảng
        {           
            Obj_HDT.set_mahang(dgv_HDT.CurrentRow.Cells["MAHANG"].Value.ToString());
            Obj_HDT.set_tenhang(dgv_HDT.CurrentRow.Cells["TENHANG"].Value.ToString());
        }

        private void getData_fromTxtBox_HDT() // lấy dữ liệu từ các TextBox
        {
            Obj_HDT.Reset();

            Obj_HDT.set_mahang(txtBox_mahang_HDT.Text.Trim().ToString());
            Obj_HDT.set_tenhang(txtBox_tenhang_HDT.Text.Trim().ToString());
        }

        private void LoadData_HDT() // tải dữ liệu vào DataGridView
        {          
            ResetValues_HDT();
            setFont_HDT();                   

            string sql = "SELECT MAHANG, TENHANG " +
                  "FROM HANGDIENTHOAI";          
            tblHDT = Class.Functions.GetDataToTable(sql);          
            dgv_HDT.DataSource = tblHDT;
          
            // set Font cho tên cột
            dgv_HDT.Font = new Font("Time New Roman", 13);
            dgv_HDT.Columns[0].HeaderText = "Mã Hãng";
            dgv_HDT.Columns[1].HeaderText = "Tên Hãng";

            // set Font cho dữ liệu hiển thị trong cột
            dgv_HDT.DefaultCellStyle.Font = new Font("Time New Roman", 12);  
            
            // set kích thước cột
            dgv_HDT.Columns[0].Width = 430;
            dgv_HDT.Columns[1].Width = 430;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_HDT.AllowUserToAddRows = false;       
            dgv_HDT.EditMode = DataGridViewEditMode.EditProgrammatically;          
        }

        private void dgv_HDT_Click(object sender, EventArgs e) // xử lí khi click vào DataGridView
        {
            //Nếu không có dữ liệu
            if (tblHDT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // nếu đang ở chế độ thêm mà user click vào DataGridView
            if (btn_them_HDT.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox_mahang_HDT.Focus();
                return;
            }

            // set dữ liệu cho textBox
            getData_fromTable_HDT();
            txtBox_mahang_HDT.Text = Obj_HDT.get_mahang();
            txtBox_tenhang_HDT.Text = Obj_HDT.get_tenhang();

            // xử lí Enable các nút
            btn_capnhat_HDT.Enabled = true;
            btn_xoa_HDT.Enabled = true;
            btn_huy_HDT.Enabled = true;          
        }

        private void btn_them_HDT_Click(object sender, EventArgs e) // xử lí thêm
        {
            ResetValues_HDT();

            // set label thông báo cho người dùng biết là đang ở chế độ thêm
            lb_them_HDT.Text = "*Bạn đang ở chế độ thêm";

            // xử lí enable các nút
            txtBox_mahang_HDT.Enabled = true;
            txtBox_mahang_HDT.Focus();
            btn_huy_HDT.Enabled = true;
            btn_luu_HDT.Enabled = true;
            btn_them_HDT.Enabled = false;
        }

        private void btn_xoa_HDT_Click(object sender, EventArgs e) // xử lí xóa
        {       
            // hỏi người dùng có chắc chắn xóa không
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE HANGDIENTHOAI" +
                    " WHERE MAHANG = N'" + txtBox_mahang_HDT.Text + "'";
                Class.Functions.RunSQL(sql);

                // tải dữ liệu vào dataGridView
                LoadData_HDT();
                ResetValues_HDT();
            }
        }

        private void btn_capnhat_HDT_Click(object sender, EventArgs e) // xử lí cập nhật
        {       
            getData_fromTxtBox_HDT();

            // TH nếu chưa nhập đầy đủ dữ liệu
            if (!Obj_HDT.Check_Data())
            {
                MessageBox.Show("Vui lòng đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox_mahang_HDT.Focus();
                return;
            }

            // thực hiện câu lệnh sql cập nhật dữ liệu
            string sql = "UPDATE HANGDIENTHOAI" +
                " SET TENHANG = N'" + Obj_HDT.get_tenhang() +
                "' WHERE MAHANG = '" + Obj_HDT.get_mahang() + "'";
            Class.Functions.RunSQL(sql);

            // tải dữ liệu vào dataGridView
            LoadData_HDT();
            ResetValues_HDT();

            // xử lí enable các nút
            btn_huy_HDT.Enabled = false;      
        }  
        
        private void btn_luu_HDT_Click(object sender, EventArgs e) // xử lí lưu
        {
            getData_fromTxtBox_HDT();

            // nếu chưa nhập đầy đủ dữ liệu
            if (!Obj_HDT.Check_Data())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox_mahang_HDT.Focus();
                return;
            }

            // kiểm tra có trùng mã hãng hay không
            string sql = "Select MAHANG " +
                "From HANGDIENTHOAI " +
                "where MAHANG = N'" + Obj_HDT.get_mahang() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hãng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBox_mahang_HDT.Focus();
                return;
            }
     
            // thực hiện câu lệnh sql thêm dữ liệu
            sql = "INSERT INTO HANGDIENTHOAI " +
                "VALUES('" + Obj_HDT.get_mahang() + "',N'" + Obj_HDT.get_tenhang() + "')";         
            Class.Functions.RunSQL(sql);

            // tải dữ liệu vào dataGridView
            LoadData_HDT();         
            ResetValues_HDT();

            // xử lí enable các nút
            btn_them_HDT.Enabled = true;
            lb_them_HDT.Text = "";       
        }

        private void btn_huy_HDT_Click(object sender, EventArgs e) // xử lí hủy
        {
            // nếu đang ở chế độ thêm
            if (btn_them_HDT.Enabled == false)
                lb_them_HDT.Text = "";

            ResetValues_HDT();
            btn_them_HDT.Enabled = true;
        }

        private void btn_thoat_HDT_Click(object sender, EventArgs e) // xử lí thoát
        {
            this.Close();
        }
        
        private void tabPage_hangdienthoai_Leave(object sender, EventArgs e) // xử lí khi rời tab 
        {
            ResetValues_HDT();
            if (btn_them_HDT.Enabled == false)
                lb_them_HDT.Text = "";
            btn_them_HDT.Enabled = true;
        }

    }
}
