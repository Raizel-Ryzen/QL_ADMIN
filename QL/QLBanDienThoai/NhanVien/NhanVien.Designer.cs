namespace QLBanDienThoai
{
    partial class NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_nhanvien = new System.Windows.Forms.TabPage();
            this.dgv_NV = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_capnhat_NV = new System.Windows.Forms.Button();
            this.btn_luu_NV = new System.Windows.Forms.Button();
            this.btn_xoa_NV = new System.Windows.Forms.Button();
            this.btn_huy_NV = new System.Windows.Forms.Button();
            this.btn_them_NV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MTBox_sdt_NV = new System.Windows.Forms.MaskedTextBox();
            this.dtP_ngaysinh_NV = new System.Windows.Forms.DateTimePicker();
            this.lb_them_NV = new System.Windows.Forms.Label();
            this.txtBox_diachi_NV = new System.Windows.Forms.TextBox();
            this.txtBox_gioitinh_NV = new System.Windows.Forms.TextBox();
            this.txtBox_tennv_NV = new System.Windows.Forms.TextBox();
            this.txtBox_manv_NV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_nhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_nhanvien);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1282, 853);
            this.tabControl_Main.TabIndex = 1;
            // 
            // tabPage_nhanvien
            // 
            this.tabPage_nhanvien.Controls.Add(this.dgv_NV);
            this.tabPage_nhanvien.Controls.Add(this.panel3);
            this.tabPage_nhanvien.Controls.Add(this.panel2);
            this.tabPage_nhanvien.Controls.Add(this.label3);
            this.tabPage_nhanvien.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage_nhanvien.Location = new System.Drawing.Point(4, 35);
            this.tabPage_nhanvien.Name = "tabPage_nhanvien";
            this.tabPage_nhanvien.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_nhanvien.Size = new System.Drawing.Size(1274, 814);
            this.tabPage_nhanvien.TabIndex = 1;
            this.tabPage_nhanvien.Text = "   Nhân Viên   ";
            this.tabPage_nhanvien.UseVisualStyleBackColor = true;
            // 
            // dgv_NV
            // 
            this.dgv_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_NV.Location = new System.Drawing.Point(3, 338);
            this.dgv_NV.Name = "dgv_NV";
            this.dgv_NV.RowHeadersWidth = 51;
            this.dgv_NV.RowTemplate.Height = 24;
            this.dgv_NV.Size = new System.Drawing.Size(1268, 377);
            this.dgv_NV.TabIndex = 4;
            this.dgv_NV.Click += new System.EventHandler(this.dgv_NV_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_capnhat_NV);
            this.panel3.Controls.Add(this.btn_luu_NV);
            this.panel3.Controls.Add(this.btn_xoa_NV);
            this.panel3.Controls.Add(this.btn_huy_NV);
            this.panel3.Controls.Add(this.btn_them_NV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 715);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1268, 96);
            this.panel3.TabIndex = 3;
            // 
            // btn_capnhat_NV
            // 
            this.btn_capnhat_NV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_capnhat_NV.Location = new System.Drawing.Point(550, 24);
            this.btn_capnhat_NV.Name = "btn_capnhat_NV";
            this.btn_capnhat_NV.Size = new System.Drawing.Size(150, 50);
            this.btn_capnhat_NV.TabIndex = 14;
            this.btn_capnhat_NV.Text = "Cập Nhật";
            this.btn_capnhat_NV.UseVisualStyleBackColor = true;
            this.btn_capnhat_NV.Click += new System.EventHandler(this.btn_capnhat_NV_Click);
            // 
            // btn_luu_NV
            // 
            this.btn_luu_NV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_luu_NV.Location = new System.Drawing.Point(794, 24);
            this.btn_luu_NV.Name = "btn_luu_NV";
            this.btn_luu_NV.Size = new System.Drawing.Size(150, 50);
            this.btn_luu_NV.TabIndex = 15;
            this.btn_luu_NV.Text = "Lưu";
            this.btn_luu_NV.UseVisualStyleBackColor = true;
            this.btn_luu_NV.Click += new System.EventHandler(this.btn_luu_NV_Click);
            // 
            // btn_xoa_NV
            // 
            this.btn_xoa_NV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa_NV.Location = new System.Drawing.Point(306, 24);
            this.btn_xoa_NV.Name = "btn_xoa_NV";
            this.btn_xoa_NV.Size = new System.Drawing.Size(150, 50);
            this.btn_xoa_NV.TabIndex = 13;
            this.btn_xoa_NV.Text = "Xóa";
            this.btn_xoa_NV.UseVisualStyleBackColor = true;
            this.btn_xoa_NV.Click += new System.EventHandler(this.btn_xoa_NV_Click);
            // 
            // btn_huy_NV
            // 
            this.btn_huy_NV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_huy_NV.Location = new System.Drawing.Point(1038, 24);
            this.btn_huy_NV.Name = "btn_huy_NV";
            this.btn_huy_NV.Size = new System.Drawing.Size(150, 50);
            this.btn_huy_NV.TabIndex = 16;
            this.btn_huy_NV.Text = "Hủy";
            this.btn_huy_NV.UseVisualStyleBackColor = true;
            this.btn_huy_NV.Click += new System.EventHandler(this.btn_huy_NV_Click);
            // 
            // btn_them_NV
            // 
            this.btn_them_NV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them_NV.Location = new System.Drawing.Point(62, 24);
            this.btn_them_NV.Name = "btn_them_NV";
            this.btn_them_NV.Size = new System.Drawing.Size(150, 50);
            this.btn_them_NV.TabIndex = 12;
            this.btn_them_NV.Text = "Thêm";
            this.btn_them_NV.UseVisualStyleBackColor = true;
            this.btn_them_NV.Click += new System.EventHandler(this.btn_them_NV_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MTBox_sdt_NV);
            this.panel2.Controls.Add(this.dtP_ngaysinh_NV);
            this.panel2.Controls.Add(this.lb_them_NV);
            this.panel2.Controls.Add(this.txtBox_diachi_NV);
            this.panel2.Controls.Add(this.txtBox_gioitinh_NV);
            this.panel2.Controls.Add(this.txtBox_tennv_NV);
            this.panel2.Controls.Add(this.txtBox_manv_NV);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1268, 335);
            this.panel2.TabIndex = 2;
            // 
            // MTBox_sdt_NV
            // 
            this.MTBox_sdt_NV.Location = new System.Drawing.Point(771, 146);
            this.MTBox_sdt_NV.Mask = "999 000 0000";
            this.MTBox_sdt_NV.Name = "MTBox_sdt_NV";
            this.MTBox_sdt_NV.Size = new System.Drawing.Size(185, 39);
            this.MTBox_sdt_NV.TabIndex = 16;
            this.MTBox_sdt_NV.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dtP_ngaysinh_NV
            // 
            this.dtP_ngaysinh_NV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtP_ngaysinh_NV.Location = new System.Drawing.Point(771, 82);
            this.dtP_ngaysinh_NV.Name = "dtP_ngaysinh_NV";
            this.dtP_ngaysinh_NV.Size = new System.Drawing.Size(185, 39);
            this.dtP_ngaysinh_NV.TabIndex = 15;
            // 
            // lb_them_NV
            // 
            this.lb_them_NV.AutoSize = true;
            this.lb_them_NV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_them_NV.ForeColor = System.Drawing.Color.Red;
            this.lb_them_NV.Location = new System.Drawing.Point(17, 294);
            this.lb_them_NV.Name = "lb_them_NV";
            this.lb_them_NV.Size = new System.Drawing.Size(0, 22);
            this.lb_them_NV.TabIndex = 14;
            // 
            // txtBox_diachi_NV
            // 
            this.txtBox_diachi_NV.Location = new System.Drawing.Point(771, 207);
            this.txtBox_diachi_NV.Multiline = true;
            this.txtBox_diachi_NV.Name = "txtBox_diachi_NV";
            this.txtBox_diachi_NV.Size = new System.Drawing.Size(185, 89);
            this.txtBox_diachi_NV.TabIndex = 13;
            // 
            // txtBox_gioitinh_NV
            // 
            this.txtBox_gioitinh_NV.Location = new System.Drawing.Point(359, 207);
            this.txtBox_gioitinh_NV.Name = "txtBox_gioitinh_NV";
            this.txtBox_gioitinh_NV.Size = new System.Drawing.Size(216, 39);
            this.txtBox_gioitinh_NV.TabIndex = 10;
            // 
            // txtBox_tennv_NV
            // 
            this.txtBox_tennv_NV.Location = new System.Drawing.Point(359, 146);
            this.txtBox_tennv_NV.Name = "txtBox_tennv_NV";
            this.txtBox_tennv_NV.Size = new System.Drawing.Size(216, 39);
            this.txtBox_tennv_NV.TabIndex = 9;
            // 
            // txtBox_manv_NV
            // 
            this.txtBox_manv_NV.Location = new System.Drawing.Point(359, 85);
            this.txtBox_manv_NV.Name = "txtBox_manv_NV";
            this.txtBox_manv_NV.Size = new System.Drawing.Size(216, 39);
            this.txtBox_manv_NV.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(625, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 22);
            this.label11.TabIndex = 7;
            this.label11.Text = "Số Điện Thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(659, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 22);
            this.label9.TabIndex = 5;
            this.label9.Text = "Ngày Sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(678, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(253, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Giới Tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(214, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên Nhân Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(214, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(463, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 33);
            this.label3.TabIndex = 1;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 853);
            this.Controls.Add(this.tabControl_Main);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_nhanvien.ResumeLayout(false);
            this.tabPage_nhanvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_nhanvien;
        private System.Windows.Forms.DataGridView dgv_NV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_capnhat_NV;
        private System.Windows.Forms.Button btn_luu_NV;
        private System.Windows.Forms.Button btn_xoa_NV;
        private System.Windows.Forms.Button btn_huy_NV;
        private System.Windows.Forms.Button btn_them_NV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox MTBox_sdt_NV;
        private System.Windows.Forms.DateTimePicker dtP_ngaysinh_NV;
        private System.Windows.Forms.Label lb_them_NV;
        private System.Windows.Forms.TextBox txtBox_diachi_NV;
        private System.Windows.Forms.TextBox txtBox_gioitinh_NV;
        private System.Windows.Forms.TextBox txtBox_tennv_NV;
        private System.Windows.Forms.TextBox txtBox_manv_NV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}