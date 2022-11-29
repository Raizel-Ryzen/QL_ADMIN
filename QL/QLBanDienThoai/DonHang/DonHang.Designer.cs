namespace QLBanDienThoai
{
    partial class DonHang
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
            this.tabPage_donhang = new System.Windows.Forms.TabPage();
            this.dgv_DH = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_them_DH = new System.Windows.Forms.Button();
            this.btn_xoa_DH = new System.Windows.Forms.Button();
            this.btn_xemchitiet_DH = new System.Windows.Forms.Button();
            this.btn_huy_DH = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dTP_ngayban_DH = new System.Windows.Forms.DateTimePicker();
            this.txtBox_giaban_DH = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.txtBox_slban_DH = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbBox_thang_DH = new System.Windows.Forms.ComboBox();
            this.btn_timthang_DH = new System.Windows.Forms.Button();
            this.label42 = new System.Windows.Forms.Label();
            this.txtBox_madt_DH = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtBox_tongtien_DH = new System.Windows.Forms.TextBox();
            this.txtBox_manv_DH = new System.Windows.Forms.TextBox();
            this.txtBox_makh_DH = new System.Windows.Forms.TextBox();
            this.txtBox_mahang_DH = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBox_madonhang_DH = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_donhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DH)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_donhang);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1282, 853);
            this.tabControl_Main.TabIndex = 1;
            // 
            // tabPage_donhang
            // 
            this.tabPage_donhang.Controls.Add(this.dgv_DH);
            this.tabPage_donhang.Controls.Add(this.panel8);
            this.tabPage_donhang.Controls.Add(this.panel7);
            this.tabPage_donhang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage_donhang.Location = new System.Drawing.Point(4, 35);
            this.tabPage_donhang.Name = "tabPage_donhang";
            this.tabPage_donhang.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_donhang.Size = new System.Drawing.Size(1274, 814);
            this.tabPage_donhang.TabIndex = 3;
            this.tabPage_donhang.Text = "   Đơn Hàng   ";
            this.tabPage_donhang.UseVisualStyleBackColor = true;
            // 
            // dgv_DH
            // 
            this.dgv_DH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DH.Location = new System.Drawing.Point(3, 380);
            this.dgv_DH.Name = "dgv_DH";
            this.dgv_DH.RowHeadersWidth = 51;
            this.dgv_DH.RowTemplate.Height = 24;
            this.dgv_DH.Size = new System.Drawing.Size(1268, 341);
            this.dgv_DH.TabIndex = 2;
            this.dgv_DH.Click += new System.EventHandler(this.dgv_DH_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_them_DH);
            this.panel8.Controls.Add(this.btn_xoa_DH);
            this.panel8.Controls.Add(this.btn_xemchitiet_DH);
            this.panel8.Controls.Add(this.btn_huy_DH);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(3, 721);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1268, 90);
            this.panel8.TabIndex = 1;
            // 
            // btn_them_DH
            // 
            this.btn_them_DH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them_DH.Location = new System.Drawing.Point(390, 24);
            this.btn_them_DH.Name = "btn_them_DH";
            this.btn_them_DH.Size = new System.Drawing.Size(150, 50);
            this.btn_them_DH.TabIndex = 20;
            this.btn_them_DH.Text = "Thêm";
            this.btn_them_DH.UseVisualStyleBackColor = true;
            this.btn_them_DH.Click += new System.EventHandler(this.btn_them_DH_Click);
            // 
            // btn_xoa_DH
            // 
            this.btn_xoa_DH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa_DH.Location = new System.Drawing.Point(715, 24);
            this.btn_xoa_DH.Name = "btn_xoa_DH";
            this.btn_xoa_DH.Size = new System.Drawing.Size(150, 50);
            this.btn_xoa_DH.TabIndex = 19;
            this.btn_xoa_DH.Text = "Xóa";
            this.btn_xoa_DH.UseVisualStyleBackColor = true;
            this.btn_xoa_DH.Click += new System.EventHandler(this.btn_xoa_DH_Click);
            // 
            // btn_xemchitiet_DH
            // 
            this.btn_xemchitiet_DH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xemchitiet_DH.Location = new System.Drawing.Point(65, 24);
            this.btn_xemchitiet_DH.Name = "btn_xemchitiet_DH";
            this.btn_xemchitiet_DH.Size = new System.Drawing.Size(150, 50);
            this.btn_xemchitiet_DH.TabIndex = 18;
            this.btn_xemchitiet_DH.Text = "Xem Chi Tiết";
            this.btn_xemchitiet_DH.UseVisualStyleBackColor = true;
            this.btn_xemchitiet_DH.Click += new System.EventHandler(this.btn_xemchitiet_DH_Click);
            // 
            // btn_huy_DH
            // 
            this.btn_huy_DH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_huy_DH.Location = new System.Drawing.Point(1040, 24);
            this.btn_huy_DH.Name = "btn_huy_DH";
            this.btn_huy_DH.Size = new System.Drawing.Size(150, 50);
            this.btn_huy_DH.TabIndex = 16;
            this.btn_huy_DH.Text = "Hủy";
            this.btn_huy_DH.UseVisualStyleBackColor = true;
            this.btn_huy_DH.Click += new System.EventHandler(this.btn_huy_DH_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dTP_ngayban_DH);
            this.panel7.Controls.Add(this.txtBox_giaban_DH);
            this.panel7.Controls.Add(this.label43);
            this.panel7.Controls.Add(this.txtBox_slban_DH);
            this.panel7.Controls.Add(this.label23);
            this.panel7.Controls.Add(this.cbBox_thang_DH);
            this.panel7.Controls.Add(this.btn_timthang_DH);
            this.panel7.Controls.Add(this.label42);
            this.panel7.Controls.Add(this.txtBox_madt_DH);
            this.panel7.Controls.Add(this.label41);
            this.panel7.Controls.Add(this.txtBox_tongtien_DH);
            this.panel7.Controls.Add(this.txtBox_manv_DH);
            this.panel7.Controls.Add(this.txtBox_makh_DH);
            this.panel7.Controls.Add(this.txtBox_mahang_DH);
            this.panel7.Controls.Add(this.label22);
            this.panel7.Controls.Add(this.label21);
            this.panel7.Controls.Add(this.label20);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.txtBox_madonhang_DH);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1268, 377);
            this.panel7.TabIndex = 0;
            // 
            // dTP_ngayban_DH
            // 
            this.dTP_ngayban_DH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_ngayban_DH.Location = new System.Drawing.Point(827, 139);
            this.dTP_ngayban_DH.Name = "dTP_ngayban_DH";
            this.dTP_ngayban_DH.Size = new System.Drawing.Size(210, 39);
            this.dTP_ngayban_DH.TabIndex = 24;
            // 
            // txtBox_giaban_DH
            // 
            this.txtBox_giaban_DH.Location = new System.Drawing.Point(827, 194);
            this.txtBox_giaban_DH.Multiline = true;
            this.txtBox_giaban_DH.Name = "txtBox_giaban_DH";
            this.txtBox_giaban_DH.Size = new System.Drawing.Size(210, 35);
            this.txtBox_giaban_DH.TabIndex = 23;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label43.ForeColor = System.Drawing.Color.Blue;
            this.label43.Location = new System.Drawing.Point(734, 201);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(75, 22);
            this.label43.TabIndex = 22;
            this.label43.Text = "Giá Bán";
            // 
            // txtBox_slban_DH
            // 
            this.txtBox_slban_DH.Location = new System.Drawing.Point(827, 244);
            this.txtBox_slban_DH.Name = "txtBox_slban_DH";
            this.txtBox_slban_DH.Size = new System.Drawing.Size(210, 39);
            this.txtBox_slban_DH.TabIndex = 21;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label23.ForeColor = System.Drawing.Color.Blue;
            this.label23.Location = new System.Drawing.Point(686, 253);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(123, 22);
            this.label23.TabIndex = 20;
            this.label23.Text = "Số Lượng Bán";
            // 
            // cbBox_thang_DH
            // 
            this.cbBox_thang_DH.FormattingEnabled = true;
            this.cbBox_thang_DH.Location = new System.Drawing.Point(827, 86);
            this.cbBox_thang_DH.Name = "cbBox_thang_DH";
            this.cbBox_thang_DH.Size = new System.Drawing.Size(210, 39);
            this.cbBox_thang_DH.TabIndex = 19;
            // 
            // btn_timthang_DH
            // 
            this.btn_timthang_DH.BackColor = System.Drawing.Color.White;
            this.btn_timthang_DH.Image = global::QLBanDienThoai.Properties.Resources.icon_find;
            this.btn_timthang_DH.Location = new System.Drawing.Point(1052, 86);
            this.btn_timthang_DH.Name = "btn_timthang_DH";
            this.btn_timthang_DH.Size = new System.Drawing.Size(46, 40);
            this.btn_timthang_DH.TabIndex = 18;
            this.btn_timthang_DH.UseVisualStyleBackColor = false;
            this.btn_timthang_DH.Click += new System.EventHandler(this.btn_timthang_DH_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label42.ForeColor = System.Drawing.Color.Blue;
            this.label42.Location = new System.Drawing.Point(715, 96);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(94, 22);
            this.label42.TabIndex = 16;
            this.label42.Text = "Tháng Bán";
            // 
            // txtBox_madt_DH
            // 
            this.txtBox_madt_DH.Location = new System.Drawing.Point(345, 191);
            this.txtBox_madt_DH.Name = "txtBox_madt_DH";
            this.txtBox_madt_DH.Size = new System.Drawing.Size(210, 39);
            this.txtBox_madt_DH.TabIndex = 15;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label41.ForeColor = System.Drawing.Color.Blue;
            this.label41.Location = new System.Drawing.Point(195, 201);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(130, 22);
            this.label41.TabIndex = 14;
            this.label41.Text = "Mã Điện Thoại";
            // 
            // txtBox_tongtien_DH
            // 
            this.txtBox_tongtien_DH.Location = new System.Drawing.Point(827, 298);
            this.txtBox_tongtien_DH.Name = "txtBox_tongtien_DH";
            this.txtBox_tongtien_DH.Size = new System.Drawing.Size(210, 39);
            this.txtBox_tongtien_DH.TabIndex = 13;
            // 
            // txtBox_manv_DH
            // 
            this.txtBox_manv_DH.Location = new System.Drawing.Point(345, 299);
            this.txtBox_manv_DH.Name = "txtBox_manv_DH";
            this.txtBox_manv_DH.Size = new System.Drawing.Size(210, 39);
            this.txtBox_manv_DH.TabIndex = 11;
            // 
            // txtBox_makh_DH
            // 
            this.txtBox_makh_DH.Location = new System.Drawing.Point(345, 243);
            this.txtBox_makh_DH.Name = "txtBox_makh_DH";
            this.txtBox_makh_DH.Size = new System.Drawing.Size(210, 39);
            this.txtBox_makh_DH.TabIndex = 10;
            // 
            // txtBox_mahang_DH
            // 
            this.txtBox_mahang_DH.Location = new System.Drawing.Point(345, 139);
            this.txtBox_mahang_DH.Name = "txtBox_mahang_DH";
            this.txtBox_mahang_DH.Size = new System.Drawing.Size(210, 39);
            this.txtBox_mahang_DH.TabIndex = 9;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label22.ForeColor = System.Drawing.Color.Blue;
            this.label22.Location = new System.Drawing.Point(722, 150);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 22);
            this.label22.TabIndex = 8;
            this.label22.Text = "Ngày Bán";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label21.ForeColor = System.Drawing.Color.Blue;
            this.label21.Location = new System.Drawing.Point(722, 308);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 22);
            this.label21.TabIndex = 7;
            this.label21.Text = "Tổng Tiền";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(204, 310);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 22);
            this.label20.TabIndex = 6;
            this.label20.Text = "Mã Nhân Viên";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(193, 253);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 22);
            this.label19.TabIndex = 5;
            this.label19.Text = "Mã khách Hàng";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(243, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 22);
            this.label18.TabIndex = 4;
            this.label18.Text = "Mã Hãng";
            // 
            // txtBox_madonhang_DH
            // 
            this.txtBox_madonhang_DH.Location = new System.Drawing.Point(345, 87);
            this.txtBox_madonhang_DH.Name = "txtBox_madonhang_DH";
            this.txtBox_madonhang_DH.Size = new System.Drawing.Size(210, 39);
            this.txtBox_madonhang_DH.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(204, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 22);
            this.label17.TabIndex = 1;
            this.label17.Text = "Mã Đơn Hàng";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(475, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(326, 33);
            this.label16.TabIndex = 0;
            this.label16.Text = "DANH SÁCH ĐƠN HÀNG";
            // 
            // DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 853);
            this.Controls.Add(this.tabControl_Main);
            this.Name = "DonHang";
            this.Text = "DonHang";
            this.Load += new System.EventHandler(this.DonHang_Load);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_donhang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DH)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_donhang;
        private System.Windows.Forms.DataGridView dgv_DH;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_them_DH;
        private System.Windows.Forms.Button btn_xoa_DH;
        private System.Windows.Forms.Button btn_xemchitiet_DH;
        private System.Windows.Forms.Button btn_huy_DH;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker dTP_ngayban_DH;
        private System.Windows.Forms.TextBox txtBox_giaban_DH;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox txtBox_slban_DH;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbBox_thang_DH;
        private System.Windows.Forms.Button btn_timthang_DH;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtBox_madt_DH;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtBox_tongtien_DH;
        private System.Windows.Forms.TextBox txtBox_manv_DH;
        private System.Windows.Forms.TextBox txtBox_makh_DH;
        private System.Windows.Forms.TextBox txtBox_mahang_DH;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBox_madonhang_DH;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}