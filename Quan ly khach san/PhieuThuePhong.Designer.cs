namespace Quan_ly_khach_san
{
    partial class fPhieuThuePhong
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
            this.lbMaPTP = new System.Windows.Forms.Label();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbNgayThue = new System.Windows.Forms.Label();
            this.lbSoPhong = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lbNgayTra = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.gbThongTinThuePhong = new System.Windows.Forms.GroupBox();
            this.dtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.btQuayLai = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MaPTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbThongTinThuePhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMaPTP
            // 
            this.lbMaPTP.AutoSize = true;
            this.lbMaPTP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbMaPTP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbMaPTP.Location = new System.Drawing.Point(24, 18);
            this.lbMaPTP.Name = "lbMaPTP";
            this.lbMaPTP.Size = new System.Drawing.Size(67, 19);
            this.lbMaPTP.TabIndex = 1;
            this.lbMaPTP.Text = "Mã PTP";
            this.lbMaPTP.Click += new System.EventHandler(this.lbMaPTP_Click);
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtSoPhong.Location = new System.Drawing.Point(132, 91);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(190, 25);
            this.txtSoPhong.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPTP,
            this.MaKH,
            this.cSoPhong,
            this.NgayDen,
            this.NgayDi,
            this.DonGia});
            this.dataGridView1.Location = new System.Drawing.Point(31, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbMaKH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbMaKH.Location = new System.Drawing.Point(477, 18);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(59, 19);
            this.lbMaKH.TabIndex = 4;
            this.lbMaKH.Text = "Mã KH";
            // 
            // lbNgayThue
            // 
            this.lbNgayThue.AutoSize = true;
            this.lbNgayThue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbNgayThue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbNgayThue.Location = new System.Drawing.Point(24, 56);
            this.lbNgayThue.Name = "lbNgayThue";
            this.lbNgayThue.Size = new System.Drawing.Size(92, 19);
            this.lbNgayThue.TabIndex = 6;
            this.lbNgayThue.Text = "Ngày Thuê";
            // 
            // lbSoPhong
            // 
            this.lbSoPhong.AutoSize = true;
            this.lbSoPhong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbSoPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbSoPhong.Location = new System.Drawing.Point(24, 95);
            this.lbSoPhong.Name = "lbSoPhong";
            this.lbSoPhong.Size = new System.Drawing.Size(85, 19);
            this.lbSoPhong.TabIndex = 7;
            this.lbSoPhong.Text = "Số Phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 8;
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbDonGia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbDonGia.Location = new System.Drawing.Point(477, 95);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(71, 19);
            this.lbDonGia.TabIndex = 9;
            this.lbDonGia.Text = "Đơn Giá";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(132, 14);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(190, 25);
            this.txtMaHD.TabIndex = 10;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtMaKH.Location = new System.Drawing.Point(571, 14);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(190, 25);
            this.txtMaKH.TabIndex = 12;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtDonGia.Location = new System.Drawing.Point(571, 91);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(190, 25);
            this.txtDonGia.TabIndex = 14;
            // 
            // lbNgayTra
            // 
            this.lbNgayTra.AutoSize = true;
            this.lbNgayTra.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbNgayTra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbNgayTra.Location = new System.Drawing.Point(477, 56);
            this.lbNgayTra.Name = "lbNgayTra";
            this.lbNgayTra.Size = new System.Drawing.Size(77, 19);
            this.lbNgayTra.TabIndex = 17;
            this.lbNgayTra.Text = "Ngày Trả";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SkyBlue;
            this.button5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(173, 221);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 30);
            this.button5.TabIndex = 21;
            this.button5.Text = "Xóa";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SkyBlue;
            this.button6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(31, 221);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 30);
            this.button6.TabIndex = 22;
            this.button6.Text = "Thuê Phòng";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // gbThongTinThuePhong
            // 
            this.gbThongTinThuePhong.Controls.Add(this.dtNgayKetThuc);
            this.gbThongTinThuePhong.Controls.Add(this.dtNgayBatDau);
            this.gbThongTinThuePhong.Controls.Add(this.lbNgayTra);
            this.gbThongTinThuePhong.Controls.Add(this.txtDonGia);
            this.gbThongTinThuePhong.Controls.Add(this.txtMaKH);
            this.gbThongTinThuePhong.Controls.Add(this.txtMaHD);
            this.gbThongTinThuePhong.Controls.Add(this.lbDonGia);
            this.gbThongTinThuePhong.Controls.Add(this.lbSoPhong);
            this.gbThongTinThuePhong.Controls.Add(this.lbNgayThue);
            this.gbThongTinThuePhong.Controls.Add(this.lbMaKH);
            this.gbThongTinThuePhong.Controls.Add(this.txtSoPhong);
            this.gbThongTinThuePhong.Controls.Add(this.lbMaPTP);
            this.gbThongTinThuePhong.Location = new System.Drawing.Point(31, 70);
            this.gbThongTinThuePhong.Name = "gbThongTinThuePhong";
            this.gbThongTinThuePhong.Size = new System.Drawing.Size(770, 145);
            this.gbThongTinThuePhong.TabIndex = 28;
            this.gbThongTinThuePhong.TabStop = false;
            this.gbThongTinThuePhong.Text = "Thông Tin Thuê Phòng";
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.CustomFormat = "yyyy-MM-dd";
            this.dtNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(571, 56);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(190, 22);
            this.dtNgayKetThuc.TabIndex = 19;
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.CustomFormat = "yyyy-MM-dd";
            this.dtNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayBatDau.Location = new System.Drawing.Point(132, 55);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Size = new System.Drawing.Size(190, 22);
            this.dtNgayBatDau.TabIndex = 18;
            this.dtNgayBatDau.ValueChanged += new System.EventHandler(this.dtNgayBatDau_ValueChanged);
            // 
            // btQuayLai
            // 
            this.btQuayLai.BackColor = System.Drawing.Color.SkyBlue;
            this.btQuayLai.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuayLai.Location = new System.Drawing.Point(665, 15);
            this.btQuayLai.Name = "btQuayLai";
            this.btQuayLai.Size = new System.Drawing.Size(136, 28);
            this.btQuayLai.TabIndex = 29;
            this.btQuayLai.Text = "Quay lại";
            this.btQuayLai.UseVisualStyleBackColor = false;
            this.btQuayLai.Click += new System.EventHandler(this.btQuayLai_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(34, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(377, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "Quản Lý Phiếu Thuê Phòng";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(315, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 30);
            this.button1.TabIndex = 30;
            this.button1.Text = "Sửa TT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(616, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 33);
            this.button2.TabIndex = 31;
            this.button2.Text = "Lập Hóa Đơn";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // MaPTP
            // 
            this.MaPTP.DataPropertyName = "MaHD";
            this.MaPTP.HeaderText = "Mã PTP";
            this.MaPTP.Name = "MaPTP";
            this.MaPTP.Width = 110;
            // 
            // MaKH
            // 
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.Name = "MaKH";
            // 
            // cSoPhong
            // 
            this.cSoPhong.DataPropertyName = "SoPhong";
            this.cSoPhong.HeaderText = "Số Phòng";
            this.cSoPhong.Name = "cSoPhong";
            // 
            // NgayDen
            // 
            this.NgayDen.DataPropertyName = "NgayBatDau";
            this.NgayDen.HeaderText = "Ngày Đến";
            this.NgayDen.Name = "NgayDen";
            this.NgayDen.Width = 140;
            // 
            // NgayDi
            // 
            this.NgayDi.DataPropertyName = "NgayTraPhong";
            this.NgayDi.HeaderText = "Ngày Đi";
            this.NgayDi.Name = "NgayDi";
            this.NgayDi.Width = 140;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 135;
            // 
            // fPhieuThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 414);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btQuayLai);
            this.Controls.Add(this.gbThongTinThuePhong);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fPhieuThuePhong";
            this.Text = "Phiếu Thuê Phòng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fPhieuThuePhong_FormClosed);
            this.Load += new System.EventHandler(this.fPhieuThuePhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbThongTinThuePhong.ResumeLayout(false);
            this.gbThongTinThuePhong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbMaPTP;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbNgayThue;
        private System.Windows.Forms.Label lbSoPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lbNgayTra;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox gbThongTinThuePhong;
        private System.Windows.Forms.Button btQuayLai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtNgayBatDau;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}