using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace QLBanDienThoai
{
    public partial class HangHoa : Form
    {        
        DataTable tblDT; // Chứa dữ liệu bảng DIENTHOAI

        bool mode_find_DT = false;
        Class.dienthoai Obj_DT = new Class.dienthoai();

        private void setFont_DT() // set Font cho các textBox 
        {
            txtBox_madt_DT.Font = new Font("Time New Roman", 12);
            txtBox_tendt_DT.Font = new Font("Time New Roman", 12);
            txtBox_soluong_DT.Font = new Font("Time New Roman", 12);
            txtBox_gianhap_DT.Font = new Font("Time New Roman", 12);
            txtBox_giaban_DT.Font = new Font("Time New Roman", 12);
            txtBox_linkanh_DT.Font = new Font("Time New Roman", 12);
            cbBox_mahang_DT.Font = new Font("Time New Roman", 12);
        }

        private void ResetValues_DT() // reset giá trị cho các mục 
        {
            if (!mode_find_DT)
                cbBox_mahang_DT.Text = "";

            txtBox_madt_DT.Text = "";
            txtBox_tendt_DT.Text = "";
            txtBox_soluong_DT.Text = "";
            txtBox_gianhap_DT.Text = "";
            txtBox_giaban_DT.Text = "";
            txtBox_linkanh_DT.Text = "";          
            picBox_anh_DT.Image = null;

            btn_capnhat_DT.Enabled = false;
            btn_xoa_DT.Enabled = false;
            btn_luu_DT.Enabled = false;
            btn_huy_DT.Enabled = false;
            txtBox_madt_DT.Enabled = false;
        }

        private void getData_fromTable_DT() // lấy dữ liệu từ bảng
        {
            Obj_DT.set_mahang(dgv_DT.CurrentRow.Cells["MAHANG"].Value.ToString());
            Obj_DT.set_madt(dgv_DT.CurrentRow.Cells["MADT"].Value.ToString());
            Obj_DT.set_tendt(dgv_DT.CurrentRow.Cells["TENDT"].Value.ToString());
            Obj_DT.set_soluong(dgv_DT.CurrentRow.Cells["SOLUONG"].Value.ToString());
            Obj_DT.set_gianhap(dgv_DT.CurrentRow.Cells["GIANHAP"].Value.ToString());
            Obj_DT.set_giaban(dgv_DT.CurrentRow.Cells["GIABAN"].Value.ToString());
            Obj_DT.set_linkanh(dgv_DT.CurrentRow.Cells["ANH"].Value.ToString());
        }

        private void getData_fromTxtBox_DT() // lấy dữ liệu từ các TextBox
        {
            Obj_DT.Reset();

            Obj_DT.set_mahang(cbBox_mahang_DT.SelectedValue.ToString());
            Obj_DT.set_madt(txtBox_madt_DT.Text.Trim().ToString());
            Obj_DT.set_tendt(txtBox_tendt_DT.Text.Trim().ToString());
            Obj_DT.set_soluong(txtBox_soluong_DT.Text.Trim().ToString());
            Obj_DT.set_gianhap(txtBox_gianhap_DT.Text.Trim().ToString());
            Obj_DT.set_giaban(txtBox_giaban_DT.Text.Trim().ToString());
            Obj_DT.set_linkanh(txtBox_linkanh_DT.Text.Trim().ToString());
        }

        private void tabPage_dienthoai_Enter(object sender, EventArgs e) //tải dữ liệu khi vào tab 
        {
            // load dữ liệu cho comboBox tên hãng điện thoại
            string sql = "SELECT * " +
                  "FROM HANGDIENTHOAI";
            Class.Functions.FillCombo(sql, cbBox_mahang_DT, "MAHANG", "TENHANG");
            cbBox_mahang_DT.SelectedIndex = -1;

            ResetValues_DT();
            setFont_DT();
            LoadData_DienThoai();
        }

        private void LoadData_DienThoai() // tải dữ liệu vào DataGridView
        {
            string sql = "SELECT * FROM DIENTHOAI";
            tblDT = Class.Functions.GetDataToTable(sql);      
            dgv_DT.DataSource = tblDT;

            // set Font cho tên cột
            dgv_DT.Font = new Font("Time New Roman", 13);           
            dgv_DT.Columns[0].HeaderText = "Mã Điện Thoại";
            dgv_DT.Columns[1].HeaderText = "Tên Điện Thoại";
            dgv_DT.Columns[2].HeaderText = "Mã Hãng";
            dgv_DT.Columns[3].HeaderText = "Số Lượng";
            dgv_DT.Columns[4].HeaderText = "Giá Nhập";
            dgv_DT.Columns[5].HeaderText = "Giá Bán";
            dgv_DT.Columns[6].HeaderText = "Ảnh";

            // set Font cho dữ liệu hiển thị trong cột
            dgv_DT.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dgv_DT.Columns[0].Width = 155;
            dgv_DT.Columns[1].Width = 160;
            dgv_DT.Columns[2].Width = 115;
            dgv_DT.Columns[3].Width = 115;
            dgv_DT.Columns[4].Width = 110;
            dgv_DT.Columns[5].Width = 100;
            dgv_DT.Columns[6].Width = 200;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_DT.AllowUserToAddRows = false;
            dgv_DT.EditMode = DataGridViewEditMode.EditProgrammatically;

            if (mode_find_DT)
                cbBox_mahang_DT.Text = "";
        }

        private void dgv_DT_Click(object sender, EventArgs e) // khi click vào dataGridView
        {
            //Nếu không có dữ liệu
            if (tblDT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // nếu đang ở chế độ thêm mà user click vào DataGridView
            if (btn_them_DT.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox_madt_DT.Focus();
                return;
            }

            // set giá trị cho các TextBox, set ảnh
            getData_fromTable_DT();
            txtBox_madt_DT.Text = Obj_DT.get_madt();
            txtBox_tendt_DT.Text = Obj_DT.get_tendt();
            txtBox_soluong_DT.Text = Obj_DT.get_soluong();
            txtBox_gianhap_DT.Text = Obj_DT.get_gianhap();
            txtBox_giaban_DT.Text = Obj_DT.get_giaban();
            txtBox_linkanh_DT.Text = Obj_DT.get_linkanh();

            try
            {
                picBox_anh_DT.Image = Image.FromFile(Obj_DT.get_linkanh());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load ảnh thất bại, vui lòng kiểm tra lại đường dẫn tới ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);             
            }

            // lấy Tên Hãng thông qua Mã Hãng và set giá trị cho comboBox        
            string sql = "SELECT TENHANG " +
                "FROM HANGDIENTHOAI " +
                "WHERE MAHANG = '" + Obj_DT.get_mahang() + "'";
            cbBox_mahang_DT.Text = Class.Functions.GetFieldValues(sql);

            // xử lí enable các nút
            btn_capnhat_DT.Enabled = true;
            btn_xoa_DT.Enabled = true;
            btn_huy_DT.Enabled = true;
        }
       
        private void btn_them_DT_Click(object sender, EventArgs e) // xử lí thêm
        {
            ResetValues_DT();

            // set label thông báo cho người dùng biết là đang ở chế độ thêm
            lb_them_DT.ForeColor = System.Drawing.Color.Red;
            lb_them_DT.Text = "*Bạn đang ở chế độ thêm";

            // xử lí enable các nút
            txtBox_madt_DT.Enabled = true;
            txtBox_madt_DT.Focus();
            btn_huy_DT.Enabled = true;
            btn_luu_DT.Enabled = true;
            btn_them_DT.Enabled = false;
        }

        private void btn_xoa_DT_Click(object sender, EventArgs e) // xử lí xóa
        {       
            // hỏi người dùng có chắc chắn xóa không ?
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // thực hiện câu lệnh sql xóa
                string sql = "DELETE " +
                    "DIENTHOAI " +
                    "WHERE MADT = N'" + txtBox_madt_DT.Text + "'";
                Class.Functions.RunSQL(sql);

                // tải dữ liệu lên dataGridView
                if (mode_find_DT)
                    setDaTa_FindMode_DT();
                else
                {
                    LoadData_DienThoai();
                    ResetValues_DT();
                }
            }
        }

        private void btn_capnhat_DT_Click(object sender, EventArgs e) // xử lí cập nhật
        {      
            getData_fromTxtBox_DT();

            // TH nếu chưa nhập đầy đủ dữ liệu
            if (!Obj_DT.Check_Data())
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // xử lí câu lệnh sql cập nhật dữ liệu
            string sql = "UPDATE DIENTHOAI " +
                "SET TENDT = N'" + Obj_DT.get_tendt() + "'," +
                "MAHANG = '" + Obj_DT.get_mahang() + "'," +
                "SOLUONG = '" + Obj_DT.get_soluong() + "'," +
                "GIANHAP = '" + Obj_DT.get_gianhap() + "'," +
                "GIABAN = '" + Obj_DT.get_giaban() + "'," +
                "ANH = N'" + Obj_DT.get_linkanh() + "'" +
                "WHERE MADT = '" + Obj_DT.get_madt() + "'";
            Class.Functions.RunSQL(sql);

            if (mode_find_DT)
                setDaTa_FindMode_DT();
            else
            {
                LoadData_DienThoai();
                ResetValues_DT();
            }
        }

        private void btn_luu_DT_Click(object sender, EventArgs e) // xử lí lưu
        {
            getData_fromTxtBox_DT();

            // TH nếu chưa nhập đầy đủ dữ liệu
            if (!Obj_DT.Check_Data())
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // xử lí khi trùng mã điện thoại
            string sql = "SELECT " +
                "MADT " +
                "FROM DIENTHOAI " +
                "WHERE MADT = '" + Obj_DT.get_madt() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox_madt_DT.Focus();
                return;
            }

            // xử lí câu lệnh sql thêm dữ liệu
            sql = "INSERT INTO DIENTHOAI " +
                "VALUES('" + Obj_DT.get_madt() + 
                "',N'" + Obj_DT.get_tendt() +
                "','" + Obj_DT.get_mahang() +
                "','" + Obj_DT.get_soluong() + 
                "','" + Obj_DT.get_gianhap() +
                "','" + Obj_DT.get_giaban() + 
                "',N'" + Obj_DT.get_linkanh() + "')";
            Class.Functions.RunSQL(sql);

            // tải dữ liệu lên dataGridView
            if (mode_find_DT)
                setDaTa_FindMode_DT();
            else
            {
                LoadData_DienThoai();
                ResetValues_DT();
            }

            btn_them_DT.Enabled = true;
            lb_them_DT.Text = "";
        }

        private void btn_huy_DT_Click(object sender, EventArgs e) // xử lí hủy
        {           
            // nếu đang ở chế độ thêm
            if (btn_them_DT.Enabled == false)
                lb_them_DT.Text = "";
            
            // nếu đang ở chế độ tìm kiếm
            if (mode_find_DT)
            {
                LoadData_DienThoai();              
                mode_find_DT = false;
            }

            ResetValues_DT();
            btn_them_DT.Enabled = true;
        }

        private void btn_thoat_DT_Click(object sender, EventArgs e) // xử lí thoát
        {
            this.Close();
        }

        private void tabPage_dienthoai_Leave(object sender, EventArgs e) // xử lí khi rời tab
        {
            ResetValues_DT();

            if (btn_them_DT.Enabled == false)
                lb_them_DT.Text = "";
            btn_them_DT.Enabled = true;
        }

        private void btn_chonhinh_DT_Click(object sender, EventArgs e) // khi click vào nút chọn hình
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn hình minh họa";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picBox_anh_DT.Image = Image.FromFile(dlgOpen.FileName);
                txtBox_linkanh_DT.Text = dlgOpen.FileName;
            }           
        }
       
        private void btn_timkiem_DT_Click(object sender, EventArgs e) // tìm kiếm theo hãng điện thoại
        {           
            mode_find_DT = true;

            // nếu đang ở chế độ thêm mà user click vào nút tìm kiếm
            if (btn_them_DT.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox_madt_DT.Focus();
                return;
            }

            // TH nếu chưa chọn tên hãng 
                if (cbBox_mahang_DT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn tên hãng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            setDaTa_FindMode_DT();

            // nếu tìm ko ra dữ liệu 
            if (tblDT.Rows.Count == 0)
                MessageBox.Show("Không có hàng của hãng " + cbBox_mahang_DT.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void setDaTa_FindMode_DT() // tải dữ liệu đã tìm kiếm dc vào DataGridView
        {       
            // thực hiện câu lệnh SQL
            string sql = "SELECT * " +
                "FROM DIENTHOAI " +
                "WHERE MAHANG = '" + cbBox_mahang_DT.SelectedValue + "'";
            tblDT = Class.Functions.GetDataToTable(sql);

            // tải dữ liệu lên dataGridView
            dgv_DT.DataSource = tblDT;

            // reset giá trị cho các mục trừ mục tên hãng điện thoại,xử lí enable các nút       
            ResetValues_DT();
            btn_huy_DT.Enabled = true;
        }
    }
}