using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLBanDienThoai
{
    public partial class Form_chitietdonhang : Form
    {
        public bool was_modify_CTDH = false;
        public bool is_them_DH = false;
        public string madh_CTDH = "";

        string mahang_CTDH; 
        bool noData_nv_CTDH = false;
        bool noData_kh_CTDH = false;
        bool noData_dt_CTDH = false;
        bool update_sldtmuamoi_CTDH = false;      

        int sldt_bancu_CTDH = 0;
        int sldt_banmoi_CTDH = 0;
        int sldt_ban_CTDH = 0;
        int sldt_hang_CTDH = 0;
        
        public Form_chitietdonhang()
        {
            InitializeComponent();
        }

        private void SetFont_CTDH() // set Font cho các textBox 
        {
            txtBox_madh_CTDH.Font = new Font("Time New Roman", 12);
            txtBox_manv_CTDH.Font = new Font("Time New Roman", 12);
            txtBox_tennv_CTDH.Font = new Font("Time New Roman", 12);
            dtP_ngayban_CTDH.Font = new Font("Time New Roman", 12);

            txtBox_makh_CTDH.Font = new Font("Time New Roman", 12);
            txtBox_tenkh_CTDH.Font = new Font("Time New Roman", 12);
            MTBox_sdtkh_CTDH.Font = new Font("Time New Roman", 12);
            txtBox_dckh_CTDH.Font = new Font("Time New Roman", 12);

            txtBox_hangdt_CTDH.Font = new Font("Time New Roman", 12);
            txtBox_madt_CTDH.Font = new Font("Time New Roman", 12);
            txtBox_tendt_CTDH.Font = new Font("Time New Roman", 12);
            txtBox_slhang_CTDH.Font = new Font("Time New Roman", 12);

            txtBox_soluongban_CTDH.Font = new Font("Time New Roman", 12);
            txtBox_giamgia_CTDH.Font = new Font("Time New Roman", 12);
            txtBox_tongtien_CTDH.Font = new Font("Time New Roman", 12);
        }

        private void Resetvalues_CTDH() // reset giá trị cho các mục 
        {
            txtBox_madh_CTDH.Text = "";
            txtBox_manv_CTDH.Text = "";
            txtBox_tennv_CTDH.Text = "";

            dtP_ngayban_CTDH.CustomFormat = "dd-MM-yyyy";
            dtP_ngayban_CTDH.Value = DateTime.Now;

            txtBox_makh_CTDH.Text = "";
            txtBox_tenkh_CTDH.Text = "";
            MTBox_sdtkh_CTDH.Text = "";
            txtBox_dckh_CTDH.Text = "";

            txtBox_hangdt_CTDH.Text = "";
            txtBox_madt_CTDH.Text = "";
            txtBox_tendt_CTDH.Text = "";
            txtBox_slhang_CTDH.Text = "";

            txtBox_soluongban_CTDH.Text = "";
            txtBox_giamgia_CTDH.Text = "";
            txtBox_tongtien_CTDH.Text = "";

            btn_capnhat_CTDH.Enabled = true;
            btn_quaylai_CTDH.Enabled = true;
            btn_luu_CTDH.Enabled = false;
            btn_huy_CTDH.Enabled = true;

            txtBox_madh_CTDH.Enabled = false;
            txtBox_tennv_CTDH.Enabled = false;
            txtBox_tenkh_CTDH.Enabled = false;
            MTBox_sdtkh_CTDH.Enabled = false;
            txtBox_dckh_CTDH.Enabled = false;
            txtBox_tendt_CTDH.Enabled = false;
            txtBox_hangdt_CTDH.Enabled = false;
            txtBox_slhang_CTDH.Enabled = false;

            txtBox_giabandt_CTDH.Enabled = false;
        }

        private void LoadData_CTDH() // tải dữ liệu cho các TextBox
        {
            DataTable tblCTDH; // table để chứa dữ liệu truy vấn
            btn_luu_CTDH.Enabled = false;

            // set text cho mã đơn hàng
            txtBox_madh_CTDH.Text = madh_CTDH;

            // set text cho manv, makh, madt, soluong, giamgia, tongtien
            string sql = "SELECT MANV, MAKH ,MADT, SOLUONG, GIAMGIA, TONGTIEN " +
                "FROM DONHANG " +
                "WHERE MADH = '" + madh_CTDH + "' ";
            tblCTDH = Class.Functions.GetDataToTable(sql);

            txtBox_manv_CTDH.Text = tblCTDH.Rows[0].Field<string>(0);
            txtBox_makh_CTDH.Text = tblCTDH.Rows[0].Field<string>(1);
            txtBox_madt_CTDH.Text = tblCTDH.Rows[0].Field<string>(2);
            txtBox_soluongban_CTDH.Text = tblCTDH.Rows[0].Field<Int32>(3).ToString();
            txtBox_giamgia_CTDH.Text = tblCTDH.Rows[0].Field<Int32>(4).ToString();      

            // set text cho ngayban
            sql = "SELECT NGAYBAN " +
                "FROM DONHANG " +
                "WHERE MADH = '" + madh_CTDH + "'";
            dtP_ngayban_CTDH.Text = Class.Functions.GetFieldValues(sql);

            // set text cho tongtien
            sql = "SELECT TONGTIEN " +
                "FROM DONHANG " +
                "WHERE MADH = '" + madh_CTDH + "'";
            txtBox_tongtien_CTDH.Text = Class.Functions.GetFieldValues(sql);

            // set hình điện thoại
            string linkanh;
            sql = "SELECT DT.ANH " +
                "FROM DONHANG DH, DIENTHOAI DT " +
                "WHERE MADH = '" + madh_CTDH + "' " +
                "AND DH.MADT = DT.MADT";
            linkanh = Class.Functions.GetFieldValues(sql);

            try
            {
                picBox_hinhdt_CTDH.Image = Image.FromFile(linkanh);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load ảnh thất bại, vui lòng kiểm tra lại đường dẫn tới ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // lấy số lượng điện thoại đã bán
            sldt_bancu_CTDH = Int32.Parse(txtBox_soluongban_CTDH.Text.Trim().ToString());

            // lấy số lượng hàng của điện thoại
            sql = "SELECT SOLUONG " +
                    "FROM DIENTHOAI " +
                    "WHERE MADT = '" + txtBox_madt_CTDH.Text.Trim().ToString() + "'";
            sldt_hang_CTDH = Int32.Parse(Class.Functions.GetFieldValues(sql));
        }

        private void Form_chitietdonhang_Load(object sender, EventArgs e) // tải dữ liệu khi vào Form
        {
            SetFont_CTDH();
            Resetvalues_CTDH();
        
            if (is_them_DH)
            {
                lb_them_CTDH.Text = "*Bạn đang ở chế độ thêm";
                txtBox_madh_CTDH.Enabled = true;
                btn_luu_CTDH.Enabled = true;
                btn_capnhat_CTDH.Enabled = false;              
            }
            else LoadData_CTDH();
        }

        private void btn_capnhat_CTDH_Click(object sender, EventArgs e) // xử lí cập nhật
        {
            string sql;

            // TH nếu không có dữ liệu nhân viên
            if (noData_nv_CTDH)
            {
                MessageBox.Show("Mã nhân viên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TH nếu không có dữ liệu khách hàng
            if (noData_kh_CTDH)
            {
                MessageBox.Show("Mã khách hàng không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TH nếu không có dữ liệu điện thoại
            if (noData_dt_CTDH)
            {
                MessageBox.Show("Mã điện thoại không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TH nếu chưa nhập tổng tiền
            if (txtBox_tongtien_CTDH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tổng tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // cập nhật lại số lượng bán, số lượng hàng nếu người dùng sửa
            sldt_ban_CTDH = sldt_banmoi_CTDH - sldt_bancu_CTDH;

            if (sldt_hang_CTDH < sldt_ban_CTDH)
            {
                MessageBox.Show("Không đủ hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (update_sldtmuamoi_CTDH)
            {
                // cập nhật lại sl điện thoại
                sql = "UPDATE DIENTHOAI " +
                    "SET SOLUONG = '" + (sldt_hang_CTDH - sldt_ban_CTDH).ToString() + "' " +
                    "WHERE MADT = '" + txtBox_madt_CTDH.Text.Trim().ToString() + "'";
                Class.Functions.RunSQL(sql);
            }
           
            // xử lí UPDATE
            sql = "UPDATE DONHANG " +
                "SET MANV = '" + txtBox_manv_CTDH.Text.Trim().ToString() + "', " +
                "MAKH = '" + txtBox_makh_CTDH.Text.Trim().ToString() + "', " +
                "MADT = '" + txtBox_madt_CTDH.Text.Trim().ToString() + "', " +
                "MAHANG = '" + mahang_CTDH + "', " +
                "GIAMGIA = '" + txtBox_giamgia_CTDH.Text.Trim().ToString() + "', " +
                "SOLUONG = '" + txtBox_soluongban_CTDH.Text.Trim().ToString() + "', " +
                "NGAYBAN = '" + Class.Functions.ConvertDateTime(dtP_ngayban_CTDH.Text.Trim().ToString()) + "', " +
                "TONGTIEN = '" + txtBox_tongtien_CTDH.Text.Trim().ToString() + "' " +
                "WHERE MADH = '" + txtBox_madh_CTDH.Text.Trim().ToString() + "'";
            Class.Functions.RunSQL(sql);

            was_modify_CTDH = true;

            // thông báo cập nhật thành công
            MessageBox.Show("Cập Nhật Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // cập nhật lại số lượng hàng
            sql = "SELECT SOLUONG " +
                "FROM DIENTHOAI " +
                "WHERE MADT = '" + txtBox_madt_CTDH.Text.Trim().ToString() + "'";
            txtBox_slhang_CTDH.Text = Class.Functions.GetFieldValues(sql);
        }

        private void btn_luu_CTDH_Click(object sender, EventArgs e) // xử lí lưu
        {
            //TH nếu madh đã tồn tại
            string sql = "SELECT MADH " +
                "FROM " +
                "DONHANG " +
                "WHERE MADH = '" + txtBox_madh_CTDH.Text.Trim().ToString() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã đơn hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox_madh_CTDH.Focus();
                return;
            }

            // TH nếu không có dữ liệu nhân viên
            if (noData_nv_CTDH)
            {
                MessageBox.Show("Mã nhân viên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TH nếu không có dữ liệu khách hàng
            if (noData_kh_CTDH)
            {
                MessageBox.Show("Mã khách hàng không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TH nếu không có dữ liệu điện thoại
            if (noData_dt_CTDH)
            {
                MessageBox.Show("Mã điện thoại không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TH nếu chưa nhập số lương bán
            if (txtBox_soluongban_CTDH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập số lượng bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TH nếu chưa nhập giảm giá
            if (txtBox_soluongban_CTDH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TH nếu chưa nhập tổng tiền
            if (txtBox_tongtien_CTDH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tổng tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // cập nhật lại số lượng bán, số lượng hàng nếu người dùng sửa
            sldt_ban_CTDH = sldt_banmoi_CTDH;

            if (sldt_hang_CTDH < sldt_ban_CTDH)
            {
                MessageBox.Show("Không đủ hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (update_sldtmuamoi_CTDH)
            {
                // cập nhật lại sl điện thoại
                sql = "UPDATE DIENTHOAI " +
                    "SET SOLUONG = '" + (sldt_hang_CTDH - sldt_ban_CTDH).ToString() + "' " +
                    "WHERE MADT = '" + txtBox_madt_CTDH.Text.Trim().ToString() + "'";
                Class.Functions.RunSQL(sql);
            }

            // xử lí thêm
            sql = "INSERT INTO DONHANG " +
                "VALUES('" + txtBox_madh_CTDH.Text.Trim().ToString() +
                "','" + txtBox_makh_CTDH.Text.Trim().ToString() +
                "','" + txtBox_manv_CTDH.Text.Trim().ToString() +
                "','" + txtBox_madt_CTDH.Text.Trim().ToString() +
                "','" + txtBox_soluongban_CTDH.Text.Trim() +
                "','" + txtBox_giamgia_CTDH.Text.Trim() +
                "','" + Class.Functions.ConvertDateTime(dtP_ngayban_CTDH.Text.Trim().ToString()) +
                "','" + txtBox_tongtien_CTDH.Text.Trim() +
                "','" + mahang_CTDH + "')";
            Class.Functions.RunSQL(sql);

            // thông báo thêm thành công
            MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            was_modify_CTDH = true;
            lb_them_CTDH.Text = "";
            btn_capnhat_CTDH.Enabled = true;
            btn_luu_CTDH.Enabled = false;

            // cập nhật lại số lượng hàng
            sql = "SELECT SOLUONG " +
                "FROM DIENTHOAI " +
                "WHERE MADT = '" + txtBox_madt_CTDH.Text.Trim().ToString() + "'";
            txtBox_slhang_CTDH.Text = Class.Functions.GetFieldValues(sql);

            madh_CTDH = txtBox_madh_CTDH.Text.Trim().ToString();
        }

        private void btn_huy_CTDH_Click(object sender, EventArgs e) // xử lí hủy
        {
            if (is_them_DH && madh_CTDH.Length == 0)
            {
                Resetvalues_CTDH();
                txtBox_madh_CTDH.Enabled = true;
                txtBox_madh_CTDH.Focus();
                btn_luu_CTDH.Enabled = true;
                btn_capnhat_CTDH.Enabled = false;
            }
            else
                LoadData_CTDH();           
        }

        private void btn_quaylai_DHCT_Click(object sender, EventArgs e) // xử lí quay lại
        {           
            this.Close();
        }
       
        private void txtBox_manv_CTDH_TextChanged(object sender, EventArgs e) // hiện thông tin của nv khi người dùng nhập manv
        {
            string sql = "SELECT TENNV " +
                "FROM NHANVIEN " +
                "WHERE MANV = '" + txtBox_manv_CTDH.Text + "' ";
            string tennv = Class.Functions.GetFieldValues(sql);

            if (tennv.Length > 0)
            {
                noData_nv_CTDH = false;
                txtBox_tennv_CTDH.Text = tennv;
            }
            else
            {
                txtBox_tennv_CTDH.Text = "";
                noData_nv_CTDH = true;
            }
            
        }

        private void txtBox_makh_CTDH_TextChanged(object sender, EventArgs e) // hiện thông tin của khách hàng khi người dùng nhập 1 makh khác
        {            
            string sql = "SELECT TENKH, SDT, DIACHI " +
                "FROM KHACHHANG " +
                "WHERE MAKH = '" + txtBox_makh_CTDH.Text + "' ";
            DataTable tblKH = Class.Functions.GetDataToTable(sql);

            if (tblKH.Rows.Count != 0)
            {
                noData_kh_CTDH = false;
                txtBox_tenkh_CTDH.Text = tblKH.Rows[0].Field<string>(0);
                MTBox_sdtkh_CTDH.Text = tblKH.Rows[0].Field<string>(1);
                txtBox_dckh_CTDH.Text = tblKH.Rows[0].Field<string>(2);
            }
            else
            {
                txtBox_tenkh_CTDH.Text = "";
                MTBox_sdtkh_CTDH.Text = "";
                txtBox_dckh_CTDH.Text = "";
                noData_kh_CTDH = true;
            }           
        }

        private void txtBox_madt_CTDH_TextChanged(object sender, EventArgs e) // hiện thông tin của điện thoại khi người dùng nhập madt
        {         
            // set tên dt, tên hãng, ảnh từ mã dt
            string sql = "SELECT DT.TENDT, HDT.TENHANG, DT.ANH, DT.MAHANG, DT.SOLUONG " +
                "FROM DIENTHOAI DT, HANGDIENTHOAI HDT " +
                "WHERE MADT = '" + txtBox_madt_CTDH.Text + "' " +
                "AND DT.MAHANG = HDT.MAHANG";
            DataTable tblDT = Class.Functions.GetDataToTable(sql);

            if (tblDT.Rows.Count != 0)
            {
                noData_dt_CTDH = false;
                txtBox_tendt_CTDH.Text = tblDT.Rows[0].Field<string>(0);
                txtBox_hangdt_CTDH.Text = tblDT.Rows[0].Field<string>(1);
                mahang_CTDH = tblDT.Rows[0].Field<string>(3);
                txtBox_slhang_CTDH.Text = tblDT.Rows[0].Field<Int32>(4).ToString();
                sldt_hang_CTDH = tblDT.Rows[0].Field<Int32>(4);
                try
                {
                    picBox_hinhdt_CTDH.Image = Image.FromFile(tblDT.Rows[0].Field<string>(2));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Load ảnh thất bại, vui lòng kiểm tra lại đường dẫn tới ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                txtBox_tendt_CTDH.Text = "";
                txtBox_hangdt_CTDH.Text = "";
                txtBox_slhang_CTDH.Text = "";
                sldt_hang_CTDH = 0;
                picBox_hinhdt_CTDH.Image = null;
                noData_dt_CTDH = true;
            }

            //set giá bán điện thoại          
            sql = "SELECT GIABAN " +
                "FROM DIENTHOAI " +
                "WHERE MADT = '" + txtBox_madt_CTDH.Text.Trim() + "'";
            txtBox_giabandt_CTDH.Text = Class.Functions.GetFieldValues(sql);

            // khi thay đổi madt thì số lượng bán, giảm giá, tổng tiền sẽ là 1 số mới
            txtBox_giamgia_CTDH.Text = "";
            txtBox_soluongban_CTDH.Text = "";
            txtBox_tongtien_CTDH.Text = "";
            sldt_bancu_CTDH = 0;
        }
        
        private void btn_autotongtien_CTDH_Click(object sender, EventArgs e) // tự động tính tổng tiền
        {
            if (txtBox_giabandt_CTDH.Text.Trim().Length != 0 && txtBox_soluongban_CTDH.Text.Trim().Length != 0 &&
                txtBox_giamgia_CTDH.Text.Trim().Length != 0)
            {
                float giaban = float.Parse(txtBox_giabandt_CTDH.Text.Trim().ToString());
                int soluong = int.Parse(txtBox_soluongban_CTDH.Text.Trim().ToString());
                float giamgia = float.Parse(txtBox_giamgia_CTDH.Text.Trim().ToString());

                float tongtien = (giaban * soluong) - (giaban * (giamgia / 100));

                txtBox_tongtien_CTDH.Text = ((int)tongtien).ToString();
            }
        }

        private void txtBox_soluongban_CTDH_TextChanged(object sender, EventArgs e) // xử lí khi nhập số lượng bán
        {
            // khi thay đổi số lượng mua thì tổng tiền sẽ là 1 số mới            
            txtBox_tongtien_CTDH.Text = "";                      
        }

        private void txtBox_giamgia_CTDH_TextChanged(object sender, EventArgs e) // xử lí khi nhập giảm giá
        {
            // khi thay đổi giảm giá thì tổng tiền sẽ là 1 số mới 
            txtBox_tongtien_CTDH.Text = "";
        }

        private void txtBox_soluongban_CTDH_Leave(object sender, EventArgs e) // xử lí khi nhập xong số lượng bán
        {
            // kt nếu giá trị trong textBox là 1 số int
            if (!int.TryParse(txtBox_soluongban_CTDH.Text.Trim().ToString(), out sldt_banmoi_CTDH))
                return;

            // cập nhật số lượng mua mới        
            sldt_banmoi_CTDH = Int32.Parse(txtBox_soluongban_CTDH.Text.Trim().ToString());
          
            update_sldtmuamoi_CTDH = true;
        } 
    }
}
