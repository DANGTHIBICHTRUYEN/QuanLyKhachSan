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
            this.button1 = new System.Windows.Forms.Button();
            this.lbMaPTP = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNgayThue = new System.Windows.Forms.Label();
            this.lbSoPhong = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lbNgayTra = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThongTinThuePhong = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.gbThongTinThuePhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(825, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm Khách";
            this.button1.UseVisualStyleBackColor = false;
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.textBox1.Location = new System.Drawing.Point(132, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 25);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPTP,
            this.MaKhachHang,
            this.NgayDen,
            this.NgayDi,
            this.cSoPhong});
            this.dataGridView1.Location = new System.Drawing.Point(31, 515);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(28, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thông Tin Phòng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(132, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 25);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.textBox3.Location = new System.Drawing.Point(132, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 25);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.textBox4.Location = new System.Drawing.Point(571, 14);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 25);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.textBox5.Location = new System.Drawing.Point(571, 52);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(190, 25);
            this.textBox5.TabIndex = 13;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.textBox6.Location = new System.Drawing.Point(571, 91);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(190, 25);
            this.textBox6.TabIndex = 14;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKhachHang,
            this.SoDT,
            this.DiaChi});
            this.dataGridView2.Location = new System.Drawing.Point(31, 39);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(707, 128);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhong,
            this.LoaiPhong,
            this.GiaPhong,
            this.TinhTrang});
            this.dataGridView3.Location = new System.Drawing.Point(31, 198);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(707, 129);
            this.dataGridView3.TabIndex = 16;
            // 
            // lbNgayTra
            // 
            this.lbNgayTra.AutoSize = true;
            this.lbNgayTra.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbNgayTra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbNgayTra.Location = new System.Drawing.Point(477, 56);
            this.lbNgayTra.Name = "lbNgayTra";
            this.lbNgayTra.Size = new System.Drawing.Size(78, 19);
            this.lbNgayTra.TabIndex = 17;
            this.lbNgayTra.Text = "Ngày Trả";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SkyBlue;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(825, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Cập Nhật Khách";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SkyBlue;
            this.button4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(825, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Cập Nhật Phòng";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SkyBlue;
            this.button5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(825, 612);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Xóa";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SkyBlue;
            this.button6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(825, 565);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "Thuê Phòng";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(822, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "0o0 Nhập Tên 0o0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(822, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "0o0 Loại Phòng 0o0";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(815, 51);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(146, 20);
            this.textBox7.TabIndex = 25;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(815, 223);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(146, 20);
            this.textBox8.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(28, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Thông Tin Khách Hàng";
            // 
            // MaKH
            // 
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 165;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.HeaderText = "Tên Khách Hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Width = 165;
            // 
            // SoDT
            // 
            this.SoDT.HeaderText = "SĐT";
            this.SoDT.Name = "SoDT";
            this.SoDT.Width = 165;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 165;
            // 
            // SoPhong
            // 
            this.SoPhong.HeaderText = "Số Phòng";
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.Width = 165;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.HeaderText = "Loại Phòng";
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.Width = 165;
            // 
            // GiaPhong
            // 
            this.GiaPhong.HeaderText = "Giá Phòng";
            this.GiaPhong.Name = "GiaPhong";
            this.GiaPhong.Width = 165;
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 165;
            // 
            // MaPTP
            // 
            this.MaPTP.HeaderText = "Mã PTP";
            this.MaPTP.Name = "MaPTP";
            this.MaPTP.Width = 145;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.HeaderText = "Mã KH";
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Width = 145;
            // 
            // NgayDen
            // 
            this.NgayDen.HeaderText = "Ngày Đến";
            this.NgayDen.Name = "NgayDen";
            this.NgayDen.Width = 145;
            // 
            // NgayDi
            // 
            this.NgayDi.HeaderText = "Ngày Đi";
            this.NgayDi.Name = "NgayDi";
            this.NgayDi.Width = 145;
            // 
            // cSoPhong
            // 
            this.cSoPhong.HeaderText = "Số Phòng";
            this.cSoPhong.Name = "cSoPhong";
            this.cSoPhong.Width = 145;
            // 
            // gbThongTinThuePhong
            // 
            this.gbThongTinThuePhong.Controls.Add(this.lbNgayTra);
            this.gbThongTinThuePhong.Controls.Add(this.textBox6);
            this.gbThongTinThuePhong.Controls.Add(this.textBox5);
            this.gbThongTinThuePhong.Controls.Add(this.textBox4);
            this.gbThongTinThuePhong.Controls.Add(this.textBox3);
            this.gbThongTinThuePhong.Controls.Add(this.textBox2);
            this.gbThongTinThuePhong.Controls.Add(this.lbDonGia);
            this.gbThongTinThuePhong.Controls.Add(this.lbSoPhong);
            this.gbThongTinThuePhong.Controls.Add(this.lbNgayThue);
            this.gbThongTinThuePhong.Controls.Add(this.lbMaKH);
            this.gbThongTinThuePhong.Controls.Add(this.textBox1);
            this.gbThongTinThuePhong.Controls.Add(this.lbMaPTP);
            this.gbThongTinThuePhong.Location = new System.Drawing.Point(31, 353);
            this.gbThongTinThuePhong.Name = "gbThongTinThuePhong";
            this.gbThongTinThuePhong.Size = new System.Drawing.Size(770, 145);
            this.gbThongTinThuePhong.TabIndex = 28;
            this.gbThongTinThuePhong.TabStop = false;
            this.gbThongTinThuePhong.Text = "Thông Tin Thuê Phòng";
            // 
            // fPhieuThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 693);
            this.Controls.Add(this.gbThongTinThuePhong);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "fPhieuThuePhong";
            this.Text = "Phiếu Thuê Phòng";
            this.Load += new System.EventHandler(this.fPhieuThuePhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.gbThongTinThuePhong.ResumeLayout(false);
            this.gbThongTinThuePhong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbMaPTP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNgayThue;
        private System.Windows.Forms.Label lbSoPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lbNgayTra;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoPhong;
        private System.Windows.Forms.GroupBox gbThongTinThuePhong;
    }
}