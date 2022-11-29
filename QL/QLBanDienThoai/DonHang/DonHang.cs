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
    public partial class DonHang : Form
    {
        public DonHang()
        {
            InitializeComponent();
        }

        DataTable tblDH;
        Class.donhang Obj_DH = new Class.donhang();
        private static bool mode_find_DH = false;

        private void setFont_DH() // set Font cho các textBox 
        {
            txtBox_madonhang_DH.Font = new Font("Time New Roman", 12);
            txtBox_mahang_DH.Font = new Font("Time New Roman", 12);
            txtBox_madt_DH.Font = new Font("Time New Roman", 12);
            txtBox_makh_DH.Font = new Font("Time New Roman", 12);
            txtBox_manv_DH.Font = new Font("Time New Roman", 12);
            dTP_ngayban_DH.Font = new Font("Time New Roman", 12);
            txtBox_tongtien_DH.Font = new Font("Time New Roman", 12);
            cbBox_thang_DH.Font = new Font("Time New Roman", 12);
            txtBox_slban_DH.Font = new Font("Time New Roman", 12);
            txtBox_giaban_DH.Font = new Font("Time New Roman", 12);
        }

        private void ResetValues_DH() // reset giá trị cho các mục 
        {
            if (!mode_find_DH)
                cbBox_thang_DH.Text = "";

            txtBox_madonhang_DH.Text = "";
            txtBox_mahang_DH.Text = "";
            txtBox_madt_DH.Text = "";
            txtBox_makh_DH.Text = "";
            txtBox_manv_DH.Text = "";

            dTP_ngayban_DH.CustomFormat = "dd-MM-yyyy";
            dTP_ngayban_DH.Value = DateTime.Now;

            txtBox_tongtien_DH.Text = "";
            txtBox_slban_DH.Text = "";
            txtBox_giaban_DH.Text = "";

            btn_huy_DH.Enabled = false;
            btn_xoa_DH.Enabled = false;
            btn_xemchitiet_DH.Enabled = false;
            txtBox_madonhang_DH.Enabled = false;
        }

        private void getData_fromTable_DH() // lấy dữ liệu từ bảng
        {
            Obj_DH.set_madh(dgv_DH.CurrentRow.Cells["MADH"].Value.ToString());
            Obj_DH.set_mahang(dgv_DH.CurrentRow.Cells["MAHANG"].Value.ToString());
            Obj_DH.set_madt(dgv_DH.CurrentRow.Cells["MADT"].Value.ToString());
            Obj_DH.set_makh(dgv_DH.CurrentRow.Cells["MAKH"].Value.ToString());
            Obj_DH.set_manv(dgv_DH.CurrentRow.Cells["MANV"].Value.ToString());
            Obj_DH.set_ngayban(dgv_DH.CurrentRow.Cells["NGAYBAN"].Value.ToString());
            Obj_DH.set_soluong(dgv_DH.CurrentRow.Cells["SOLUONG"].Value.ToString());
            Obj_DH.set_tongtien(dgv_DH.CurrentRow.Cells["TONGTIEN"].Value.ToString());
        }

        private void DonHang_Load(object sender, EventArgs e)
        {
            // set giá trị cho comboBox
            for (int i = 1; i <= 12; i++)
                cbBox_thang_DH.Items.Add(i.ToString());

            setFont_DH();
            ResetValues_DH();
            LoadData_DonHang();
        }

        private void LoadData_DonHang() // tải dữ liệu vào DataGridView
        {
            string sql = "SELECT DH.MADH, DH.MAHANG, DH.MADT, DH.MAKH, DH.MANV, DH.NGAYBAN, DT.GIABAN, DH.SOLUONG, DH.TONGTIEN " +
                "FROM DONHANG DH, DIENTHOAI DT " +
                "WHERE DH.MADT = DT.MADT";
            tblDH = Class.Functions.GetDataToTable(sql);
            dgv_DH.DataSource = tblDH;

            // set Font cho tên cột
            dgv_DH.Font = new Font("Time New Roman", 13);
            dgv_DH.Columns[0].HeaderText = "Mã Đơn Hàng";
            dgv_DH.Columns[1].HeaderText = "Mã Hãng";
            dgv_DH.Columns[2].HeaderText = "Mã Điện Thoại";
            dgv_DH.Columns[3].HeaderText = "Mã Khách Hàng";
            dgv_DH.Columns[4].HeaderText = "Mã NHân Viên";
            dgv_DH.Columns[5].HeaderText = "Ngày Bán";
            dgv_DH.Columns[6].HeaderText = "Giá Bán";
            dgv_DH.Columns[7].HeaderText = "Số Lượng Bán";
            dgv_DH.Columns[8].HeaderText = "Tổng Tiền";

            // set Font cho dữ liệu hiển thị trong cột
            dgv_DH.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dgv_DH.Columns[0].Width = 150;
            dgv_DH.Columns[1].Width = 110;
            dgv_DH.Columns[2].Width = 160;
            dgv_DH.Columns[3].Width = 170;
            dgv_DH.Columns[4].Width = 160;
            dgv_DH.Columns[5].Width = 120;
            dgv_DH.Columns[6].Width = 120;
            dgv_DH.Columns[7].Width = 150;
            dgv_DH.Columns[8].Width = 150;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_DH.AllowUserToAddRows = false;
            dgv_DH.EditMode = DataGridViewEditMode.EditProgrammatically;

            if (mode_find_DH)
                cbBox_thang_DH.Text = "";
        }

        private void loadData_txtBox()
        {
            txtBox_madonhang_DH.Text = dgv_DH.CurrentRow.Cells["MADH"].Value.ToString();
            txtBox_mahang_DH.Text = dgv_DH.CurrentRow.Cells["MAHANG"].Value.ToString();
            txtBox_madt_DH.Text = dgv_DH.CurrentRow.Cells["MADT"].Value.ToString();
            txtBox_makh_DH.Text = dgv_DH.CurrentRow.Cells["MAKH"].Value.ToString();
            txtBox_manv_DH.Text = dgv_DH.CurrentRow.Cells["MANV"].Value.ToString();
            dTP_ngayban_DH.Text = dgv_DH.CurrentRow.Cells["NGAYBAN"].Value.ToString();
            txtBox_giaban_DH.Text = dgv_DH.CurrentRow.Cells["GIABAN"].Value.ToString();
            txtBox_slban_DH.Text = dgv_DH.CurrentRow.Cells["SOLUONG"].Value.ToString();
            txtBox_tongtien_DH.Text = dgv_DH.CurrentRow.Cells["TONGTIEN"].Value.ToString();

            // set giá trị cho tháng bán
            string sql = "SELECT MONTH(NGAYBAN) " +
                "FROM DONHANG " +
                "WHERE MADH = '" + dgv_DH.CurrentRow.Cells["MADH"].Value.ToString() + "' ";
            cbBox_thang_DH.Text = Class.Functions.GetFieldValues(sql);
        }
        private void dgv_DH_Click(object sender, EventArgs e) // khi click vào dataGridView
        {
            //Nếu không có dữ liệu
            if (tblDH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // set giá trị cho các txtBox
            getData_fromTable_DH();
            txtBox_madonhang_DH.Text = Obj_DH.get_madh();
            txtBox_mahang_DH.Text = Obj_DH.get_mahang();
            txtBox_madt_DH.Text = Obj_DH.get_madt();
            txtBox_makh_DH.Text = Obj_DH.get_makh();
            txtBox_manv_DH.Text = Obj_DH.get_manv();
            dTP_ngayban_DH.Text = Obj_DH.get_ngayban();
            txtBox_giaban_DH.Text = dgv_DH.CurrentRow.Cells["GIABAN"].Value.ToString();
            txtBox_slban_DH.Text = Obj_DH.get_soluong();
            txtBox_tongtien_DH.Text = Obj_DH.get_tongtien();

            // set giá trị cho tháng bán
            string sql = "SELECT MONTH(NGAYBAN) " +
                "FROM DONHANG " +
                "WHERE MADH = '" + dgv_DH.CurrentRow.Cells["MADH"].Value.ToString() + "' ";
            cbBox_thang_DH.Text = Class.Functions.GetFieldValues(sql);

            // xử lí enable các nút      
            btn_xoa_DH.Enabled = true;
            btn_xemchitiet_DH.Enabled = true;
            btn_huy_DH.Enabled = true;
        }

        private void btn_xemchitiet_DH_Click(object sender, EventArgs e) // xử lí xem chi tiết
        {
            // load form chi tiết đơn hàng lên
            Form_chitietdonhang form_chitietdonhang = new Form_chitietdonhang();
            form_chitietdonhang.StartPosition = FormStartPosition.CenterParent;
            form_chitietdonhang.madh_CTDH = txtBox_madonhang_DH.Text.Trim().ToString();
            form_chitietdonhang.ShowDialog();

            // nếu có cập nhật thì load lại dữ liệu vào dataGridView
            if (form_chitietdonhang.was_modify_CTDH)
            {
                form_chitietdonhang.was_modify_CTDH = false;

                LoadData_DonHang();
                loadData_txtBox();
            }
        }

        private void btn_them_DH_Click(object sender, EventArgs e) // xử lí thêm
        {
            Form_chitietdonhang form_chitietdonhang = new Form_chitietdonhang();
            form_chitietdonhang.StartPosition = FormStartPosition.CenterParent;
            form_chitietdonhang.is_them_DH = true;
            form_chitietdonhang.ShowDialog();

            // nếu có thêm thì load lại dữ liệu vào dataGridView
            if (form_chitietdonhang.was_modify_CTDH)
            {
                form_chitietdonhang.was_modify_CTDH = false;
                LoadData_DonHang();
                ResetValues_DH();
            }
        }

        private void btn_xoa_DH_Click(object sender, EventArgs e) // xử lí xóa
        {
            // hỏi người dùng có chắc chắn xóa không ?
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // thực hiện câu lệnh sql xóa
                string sql = "DELETE " +
                    "DONHANG " +
                    "WHERE MADH = '" + txtBox_madonhang_DH.Text + "'";
                Class.Functions.RunSQL(sql);

                // tải dữ liệu lên dataGridView
                if (mode_find_DH)
                    setDaTa_FindMode_DH();
                else
                {
                    LoadData_DonHang();
                    ResetValues_DH();
                }
            }
        }

        private void btn_huy_DH_Click(object sender, EventArgs e) // xử lí hủy
        {
            ResetValues_DH();

            // nếu đang ở chế độ tìm kiếm
            if (mode_find_DH)
            {
                LoadData_DonHang();
                mode_find_DH = false;
            }
        }

        private void btn_thoat_DH_Click(object sender, EventArgs e) // xử lí thoát
        {
            this.Close();
        }

        private void tabPage_donhang_Leave(object sender, EventArgs e) // khi rời tab
        {
            ResetValues_DH();

            // làm trống comboBox
            cbBox_thang_DH.Items.Clear();
        }

        private void btn_timthang_DH_Click(object sender, EventArgs e) // xử lí tìm đơn hàng theo tháng
        {
            mode_find_DH = true;

            // TH nếu chưa chọn tháng
            if (cbBox_thang_DH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TH đã chọn tháng     
            setDaTa_FindMode_DH();

            // nếu tìm ko ra dữ liệu 
            if (tblDH.Rows.Count == 0)
                MessageBox.Show("Không có đơn hàng trong tháng " + cbBox_thang_DH.Text.Trim().ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void setDaTa_FindMode_DH() //tải dữ liệu đã tìm được vào dataGridView
        {
            // xử lí câu lệnh sql
            string sql = "SELECT DH.MADH, DH.MAHANG, DH.MADT, DH.MAKH, DH.MANV, DH.NGAYBAN, DT.GIABAN, DH.SOLUONG, DH.TONGTIEN " +
                "FROM DONHANG DH, DIENTHOAI DT " +
                "WHERE DH.MADT = DT.MADT " +
                "AND MONTH(NGAYBAN) = '" + cbBox_thang_DH.Text.Trim().ToString() + "'";
            tblDH = Class.Functions.GetDataToTable(sql);

            // tải dữ liệu lên dataGridView
            dgv_DH.DataSource = tblDH;

            // reset giá trị cho các mục trừ mục tên hãng điện thoại,xử lí enable các nút       
            ResetValues_DH();
            btn_huy_DH.Enabled = true;
        }        
    }
}
