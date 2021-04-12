namespace Quan_ly_khach_san
{
    partial class fDanhSachKhachHang
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txMaKhachHang = new System.Windows.Forms.TextBox();
            this.txTenKhachHang = new System.Windows.Forms.TextBox();
            this.txQuocTich = new System.Windows.Forms.TextBox();
            this.txDiaChi = new System.Windows.Forms.TextBox();
            this.txSoDienThoai = new System.Windows.Forms.TextBox();
            this.txCMND = new System.Windows.Forms.TextBox();
            this.cbxGioiTinh = new System.Windows.Forms.ComboBox();
            this.cbxLoaiKhach = new System.Windows.Forms.ComboBox();
            this.btThemKhach = new System.Windows.Forms.Button();
            this.btXoaKhach = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btSua = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbThongTinKhachHang = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbThongTinKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khách Hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSalmon;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSalmon;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Khách Hàng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSalmon;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quốc tịch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSalmon;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "CMND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSalmon;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số Điện Thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkSalmon;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(422, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Loại Khách";
            // 
            // txMaKhachHang
            // 
            this.txMaKhachHang.Location = new System.Drawing.Point(156, 18);
            this.txMaKhachHang.Name = "txMaKhachHang";
            this.txMaKhachHang.Size = new System.Drawing.Size(190, 20);
            this.txMaKhachHang.TabIndex = 9;
            // 
            // txTenKhachHang
            // 
            this.txTenKhachHang.Location = new System.Drawing.Point(156, 52);
            this.txTenKhachHang.Name = "txTenKhachHang";
            this.txTenKhachHang.Size = new System.Drawing.Size(190, 20);
            this.txTenKhachHang.TabIndex = 10;
            // 
            // txQuocTich
            // 
            this.txQuocTich.Location = new System.Drawing.Point(532, 52);
            this.txQuocTich.Name = "txQuocTich";
            this.txQuocTich.Size = new System.Drawing.Size(190, 20);
            this.txQuocTich.TabIndex = 11;
            // 
            // txDiaChi
            // 
            this.txDiaChi.Location = new System.Drawing.Point(156, 126);
            this.txDiaChi.Name = "txDiaChi";
            this.txDiaChi.Size = new System.Drawing.Size(190, 20);
            this.txDiaChi.TabIndex = 12;
            // 
            // txSoDienThoai
            // 
            this.txSoDienThoai.Location = new System.Drawing.Point(156, 90);
            this.txSoDienThoai.Name = "txSoDienThoai";
            this.txSoDienThoai.Size = new System.Drawing.Size(190, 20);
            this.txSoDienThoai.TabIndex = 15;
            // 
            // txCMND
            // 
            this.txCMND.Location = new System.Drawing.Point(532, 90);
            this.txCMND.Name = "txCMND";
            this.txCMND.Size = new System.Drawing.Size(190, 20);
            this.txCMND.TabIndex = 16;
            // 
            // cbxGioiTinh
            // 
            this.cbxGioiTinh.FormattingEnabled = true;
            this.cbxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxGioiTinh.Location = new System.Drawing.Point(532, 18);
            this.cbxGioiTinh.Name = "cbxGioiTinh";
            this.cbxGioiTinh.Size = new System.Drawing.Size(190, 21);
            this.cbxGioiTinh.TabIndex = 18;
            this.cbxGioiTinh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbxLoaiKhach
            // 
            this.cbxLoaiKhach.FormattingEnabled = true;
            this.cbxLoaiKhach.Items.AddRange(new object[] {
            "Nội Địa",
            "Nước Ngoài"});
            this.cbxLoaiKhach.Location = new System.Drawing.Point(532, 126);
            this.cbxLoaiKhach.Name = "cbxLoaiKhach";
            this.cbxLoaiKhach.Size = new System.Drawing.Size(190, 21);
            this.cbxLoaiKhach.TabIndex = 19;
            // 
            // btThemKhach
            // 
            this.btThemKhach.ImageIndex = 2;
            this.btThemKhach.Location = new System.Drawing.Point(583, 223);
            this.btThemKhach.Name = "btThemKhach";
            this.btThemKhach.Size = new System.Drawing.Size(30, 30);
            this.btThemKhach.TabIndex = 20;
            this.btThemKhach.UseVisualStyleBackColor = true;
            // 
            // btXoaKhach
            // 
            this.btXoaKhach.ImageIndex = 2;
            this.btXoaKhach.Location = new System.Drawing.Point(643, 223);
            this.btXoaKhach.Name = "btXoaKhach";
            this.btXoaKhach.Size = new System.Drawing.Size(30, 30);
            this.btXoaKhach.TabIndex = 21;
            this.btXoaKhach.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(268, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(326, 32);
            this.label8.TabIndex = 22;
            this.label8.Text = "Danh Sách Khách Hàng";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btSua
            // 
            this.btSua.ImageIndex = 2;
            this.btSua.Location = new System.Drawing.Point(703, 223);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(30, 30);
            this.btSua.TabIndex = 23;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkSalmon;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "Địa Chỉ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(12, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 228);
            this.dataGridView1.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã KH";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Khách Hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SĐT";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "CMND";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Địa Chỉ";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Quốc Tịch";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Loại Khách";
            this.Column8.Name = "Column8";
            // 
            // gbThongTinKhachHang
            // 
            this.gbThongTinKhachHang.Controls.Add(this.label10);
            this.gbThongTinKhachHang.Controls.Add(this.cbxLoaiKhach);
            this.gbThongTinKhachHang.Controls.Add(this.cbxGioiTinh);
            this.gbThongTinKhachHang.Controls.Add(this.txCMND);
            this.gbThongTinKhachHang.Controls.Add(this.txSoDienThoai);
            this.gbThongTinKhachHang.Controls.Add(this.txDiaChi);
            this.gbThongTinKhachHang.Controls.Add(this.txQuocTich);
            this.gbThongTinKhachHang.Controls.Add(this.txTenKhachHang);
            this.gbThongTinKhachHang.Controls.Add(this.txMaKhachHang);
            this.gbThongTinKhachHang.Controls.Add(this.label9);
            this.gbThongTinKhachHang.Controls.Add(this.label7);
            this.gbThongTinKhachHang.Controls.Add(this.label6);
            this.gbThongTinKhachHang.Controls.Add(this.label5);
            this.gbThongTinKhachHang.Controls.Add(this.label4);
            this.gbThongTinKhachHang.Controls.Add(this.label3);
            this.gbThongTinKhachHang.Controls.Add(this.label2);
            this.gbThongTinKhachHang.Controls.Add(this.label1);
            this.gbThongTinKhachHang.Location = new System.Drawing.Point(26, 41);
            this.gbThongTinKhachHang.Name = "gbThongTinKhachHang";
            this.gbThongTinKhachHang.Size = new System.Drawing.Size(740, 173);
            this.gbThongTinKhachHang.TabIndex = 26;
            this.gbThongTinKhachHang.TabStop = false;
            this.gbThongTinKhachHang.Text = "Thông tin Khách Hàng";
            // 
            // fDanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 499);
            this.Controls.Add(this.gbThongTinKhachHang);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btXoaKhach);
            this.Controls.Add(this.btThemKhach);
            this.Name = "fDanhSachKhachHang";
            this.Text = "DanhSachKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbThongTinKhachHang.ResumeLayout(false);
            this.gbThongTinKhachHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txMaKhachHang;
        private System.Windows.Forms.TextBox txTenKhachHang;
        private System.Windows.Forms.TextBox txQuocTich;
        private System.Windows.Forms.TextBox txDiaChi;
        private System.Windows.Forms.TextBox txSoDienThoai;
        private System.Windows.Forms.TextBox txCMND;
        private System.Windows.Forms.ComboBox cbxGioiTinh;
        private System.Windows.Forms.ComboBox cbxLoaiKhach;
        private System.Windows.Forms.Button btThemKhach;
        private System.Windows.Forms.Button btXoaKhach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbThongTinKhachHang;
    }
}