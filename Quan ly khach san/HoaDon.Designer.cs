namespace Quan_ly_khach_san
{
    partial class HoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txMaHD = new System.Windows.Forms.TextBox();
            this.txMaPTP = new System.Windows.Forms.TextBox();
            this.txThanhTien = new System.Windows.Forms.TextBox();
            this.txMaKH = new System.Windows.Forms.TextBox();
            this.txSoPhong = new System.Windows.Forms.TextBox();
            this.txSoNgayThue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gbThongTinHoaDon = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btQuayLai = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txDonGia = new System.Windows.Forms.TextBox();
            this.dtNgayTao = new System.Windows.Forms.DateTimePicker();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTaoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbThongTinHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(55, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaPTP,
            this.MaKH,
            this.SoPhong,
            this.NgayTaoHD,
            this.SoNgayThue,
            this.DonGia,
            this.ThanhTien,
            this.TinhTrang});
            this.dataGridView1.Location = new System.Drawing.Point(32, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(835, 222);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(78, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BurlyWood;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(534, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số Ngày Thuê";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.BurlyWood;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(556, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Thành Tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(68, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "Chi Tiết Hóa Đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.BurlyWood;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(580, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Đơn Giá";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txMaHD
            // 
            this.txMaHD.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMaHD.Location = new System.Drawing.Point(169, 16);
            this.txMaHD.Name = "txMaHD";
            this.txMaHD.Size = new System.Drawing.Size(143, 26);
            this.txMaHD.TabIndex = 12;
            // 
            // txMaPTP
            // 
            this.txMaPTP.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txMaPTP.Location = new System.Drawing.Point(169, 54);
            this.txMaPTP.Name = "txMaPTP";
            this.txMaPTP.Size = new System.Drawing.Size(143, 26);
            this.txMaPTP.TabIndex = 14;
            // 
            // txThanhTien
            // 
            this.txThanhTien.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txThanhTien.Location = new System.Drawing.Point(657, 126);
            this.txThanhTien.Name = "txThanhTien";
            this.txThanhTien.Size = new System.Drawing.Size(143, 26);
            this.txThanhTien.TabIndex = 15;
            // 
            // txMaKH
            // 
            this.txMaKH.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txMaKH.Location = new System.Drawing.Point(169, 126);
            this.txMaKH.Name = "txMaKH";
            this.txMaKH.Size = new System.Drawing.Size(143, 26);
            this.txMaKH.TabIndex = 16;
            // 
            // txSoPhong
            // 
            this.txSoPhong.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txSoPhong.Location = new System.Drawing.Point(169, 90);
            this.txSoPhong.Name = "txSoPhong";
            this.txSoPhong.Size = new System.Drawing.Size(143, 26);
            this.txSoPhong.TabIndex = 17;
            // 
            // txSoNgayThue
            // 
            this.txSoNgayThue.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txSoNgayThue.Location = new System.Drawing.Point(657, 54);
            this.txSoNgayThue.Name = "txSoNgayThue";
            this.txSoNgayThue.Size = new System.Drawing.Size(143, 26);
            this.txSoNgayThue.TabIndex = 18;
            this.txSoNgayThue.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.BurlyWood;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(60, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Mã Hóa Đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BurlyWood;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(497, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ngày Tạo Hóa Đơn";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(640, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 33);
            this.button2.TabIndex = 29;
            this.button2.Text = "Thanh Toán";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // gbThongTinHoaDon
            // 
            this.gbThongTinHoaDon.Controls.Add(this.dtNgayTao);
            this.gbThongTinHoaDon.Controls.Add(this.txDonGia);
            this.gbThongTinHoaDon.Controls.Add(this.label10);
            this.gbThongTinHoaDon.Controls.Add(this.button1);
            this.gbThongTinHoaDon.Controls.Add(this.button5);
            this.gbThongTinHoaDon.Controls.Add(this.button2);
            this.gbThongTinHoaDon.Controls.Add(this.label5);
            this.gbThongTinHoaDon.Controls.Add(this.label9);
            this.gbThongTinHoaDon.Controls.Add(this.txSoNgayThue);
            this.gbThongTinHoaDon.Controls.Add(this.txSoPhong);
            this.gbThongTinHoaDon.Controls.Add(this.txMaKH);
            this.gbThongTinHoaDon.Controls.Add(this.txThanhTien);
            this.gbThongTinHoaDon.Controls.Add(this.txMaPTP);
            this.gbThongTinHoaDon.Controls.Add(this.txMaHD);
            this.gbThongTinHoaDon.Controls.Add(this.label8);
            this.gbThongTinHoaDon.Controls.Add(this.label6);
            this.gbThongTinHoaDon.Controls.Add(this.label4);
            this.gbThongTinHoaDon.Controls.Add(this.label3);
            this.gbThongTinHoaDon.Controls.Add(this.label2);
            this.gbThongTinHoaDon.Location = new System.Drawing.Point(32, 56);
            this.gbThongTinHoaDon.Name = "gbThongTinHoaDon";
            this.gbThongTinHoaDon.Size = new System.Drawing.Size(834, 221);
            this.gbThongTinHoaDon.TabIndex = 30;
            this.gbThongTinHoaDon.TabStop = false;
            this.gbThongTinHoaDon.Text = "Thông Tin Hóa Đơn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(169, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 30);
            this.button1.TabIndex = 33;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SkyBlue;
            this.button5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(27, 184);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 30);
            this.button5.TabIndex = 31;
            this.button5.Text = "Xóa";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btQuayLai
            // 
            this.btQuayLai.BackColor = System.Drawing.Color.SkyBlue;
            this.btQuayLai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuayLai.Location = new System.Drawing.Point(757, 17);
            this.btQuayLai.Name = "btQuayLai";
            this.btQuayLai.Size = new System.Drawing.Size(110, 33);
            this.btQuayLai.TabIndex = 31;
            this.btQuayLai.Text = "Quay lại";
            this.btQuayLai.UseVisualStyleBackColor = false;
            this.btQuayLai.Click += new System.EventHandler(this.btQuayLai_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.BurlyWood;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(96, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 19);
            this.label10.TabIndex = 34;
            this.label10.Text = "Mã PTP";
            // 
            // txDonGia
            // 
            this.txDonGia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDonGia.Location = new System.Drawing.Point(657, 90);
            this.txDonGia.Name = "txDonGia";
            this.txDonGia.Size = new System.Drawing.Size(143, 26);
            this.txDonGia.TabIndex = 35;
            // 
            // dtNgayTao
            // 
            this.dtNgayTao.CustomFormat = "dd-MM-yyyy";
            this.dtNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayTao.Location = new System.Drawing.Point(658, 21);
            this.dtNgayTao.Name = "dtNgayTao";
            this.dtNgayTao.Size = new System.Drawing.Size(142, 20);
            this.dtNgayTao.TabIndex = 36;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 90;
            // 
            // MaPTP
            // 
            this.MaPTP.DataPropertyName = "MaPTP";
            this.MaPTP.HeaderText = "Mã PTP";
            this.MaPTP.Name = "MaPTP";
            this.MaPTP.Width = 85;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "MãKH";
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 85;
            // 
            // SoPhong
            // 
            this.SoPhong.DataPropertyName = "SoPhong";
            this.SoPhong.HeaderText = "Số Phòng";
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.Width = 90;
            // 
            // NgayTaoHD
            // 
            this.NgayTaoHD.DataPropertyName = "NgayTaoHD";
            this.NgayTaoHD.HeaderText = "Ngày Tạo Hóa Đơn";
            this.NgayTaoHD.Name = "NgayTaoHD";
            // 
            // SoNgayThue
            // 
            this.SoNgayThue.DataPropertyName = "SoNgayThue";
            this.SoNgayThue.HeaderText = "Số Ngày Thuê";
            this.SoNgayThue.Name = "SoNgayThue";
            this.SoNgayThue.Width = 40;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 523);
            this.Controls.Add(this.btQuayLai);
            this.Controls.Add(this.gbThongTinHoaDon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "HoaDon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbThongTinHoaDon.ResumeLayout(false);
            this.gbThongTinHoaDon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txMaHD;
        private System.Windows.Forms.TextBox txMaPTP;
        private System.Windows.Forms.TextBox txThanhTien;
        private System.Windows.Forms.TextBox txMaKH;
        private System.Windows.Forms.TextBox txSoPhong;
        private System.Windows.Forms.TextBox txSoNgayThue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbThongTinHoaDon;
        private System.Windows.Forms.Button btQuayLai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txDonGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtNgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTaoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    }
}