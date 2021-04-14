
namespace Quan_ly_khach_san
{
    partial class fDanhSachPhong
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
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txSoPhong = new System.Windows.Forms.TextBox();
            this.txGhiChu = new System.Windows.Forms.TextBox();
            this.txDonGia = new System.Windows.Forms.TextBox();
            this.cbxTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbxLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbThongTinKhachHang = new System.Windows.Forms.GroupBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbThongTinKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(35, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 32);
            this.label8.TabIndex = 25;
            this.label8.Text = "Danh Sách Phòng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhong,
            this.LoaiPhong,
            this.DonGia,
            this.GhiChu,
            this.TinhTrang});
            this.dataGridView1.Location = new System.Drawing.Point(32, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 191);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SoPhong
            // 
            this.SoPhong.DataPropertyName = "SoPhong";
            this.SoPhong.HeaderText = "Số Phòng";
            this.SoPhong.Name = "SoPhong";
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.DataPropertyName = "LoaiPhong";
            this.LoaiPhong.HeaderText = "Loại Phòng";
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.Width = 150;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 150;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 150;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trang";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSalmon;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tình Trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSalmon;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ghi Chú";
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
            this.label9.Location = new System.Drawing.Point(13, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Loại Phòng";
            // 
            // txSoPhong
            // 
            this.txSoPhong.Location = new System.Drawing.Point(156, 15);
            this.txSoPhong.Name = "txSoPhong";
            this.txSoPhong.Size = new System.Drawing.Size(190, 20);
            this.txSoPhong.TabIndex = 9;
            // 
            // txGhiChu
            // 
            this.txGhiChu.Location = new System.Drawing.Point(532, 16);
            this.txGhiChu.Name = "txGhiChu";
            this.txGhiChu.Size = new System.Drawing.Size(190, 20);
            this.txGhiChu.TabIndex = 11;
            // 
            // txDonGia
            // 
            this.txDonGia.Location = new System.Drawing.Point(156, 92);
            this.txDonGia.Name = "txDonGia";
            this.txDonGia.Size = new System.Drawing.Size(190, 20);
            this.txDonGia.TabIndex = 12;
            // 
            // cbxTinhTrang
            // 
            this.cbxTinhTrang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTinhTrang.FormattingEnabled = true;
            this.cbxTinhTrang.Items.AddRange(new object[] {
            "Chưa Được Thuê",
            "Đang Được Thuê",
            "Đang Tu Sửa"});
            this.cbxTinhTrang.Location = new System.Drawing.Point(532, 54);
            this.cbxTinhTrang.Name = "cbxTinhTrang";
            this.cbxTinhTrang.Size = new System.Drawing.Size(190, 21);
            this.cbxTinhTrang.TabIndex = 18;
            // 
            // cbxLoaiPhong
            // 
            this.cbxLoaiPhong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoaiPhong.FormattingEnabled = true;
            this.cbxLoaiPhong.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbxLoaiPhong.Location = new System.Drawing.Point(156, 54);
            this.cbxLoaiPhong.Name = "cbxLoaiPhong";
            this.cbxLoaiPhong.Size = new System.Drawing.Size(190, 21);
            this.cbxLoaiPhong.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkSalmon;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "Đơn Giá";
            // 
            // gbThongTinKhachHang
            // 
            this.gbThongTinKhachHang.Controls.Add(this.btSua);
            this.gbThongTinKhachHang.Controls.Add(this.btThem);
            this.gbThongTinKhachHang.Controls.Add(this.btXoa);
            this.gbThongTinKhachHang.Controls.Add(this.label10);
            this.gbThongTinKhachHang.Controls.Add(this.cbxLoaiPhong);
            this.gbThongTinKhachHang.Controls.Add(this.cbxTinhTrang);
            this.gbThongTinKhachHang.Controls.Add(this.txDonGia);
            this.gbThongTinKhachHang.Controls.Add(this.txGhiChu);
            this.gbThongTinKhachHang.Controls.Add(this.txSoPhong);
            this.gbThongTinKhachHang.Controls.Add(this.label9);
            this.gbThongTinKhachHang.Controls.Add(this.label7);
            this.gbThongTinKhachHang.Controls.Add(this.label4);
            this.gbThongTinKhachHang.Controls.Add(this.label2);
            this.gbThongTinKhachHang.Controls.Add(this.label1);
            this.gbThongTinKhachHang.Location = new System.Drawing.Point(32, 59);
            this.gbThongTinKhachHang.Name = "gbThongTinKhachHang";
            this.gbThongTinKhachHang.Size = new System.Drawing.Size(740, 173);
            this.gbThongTinKhachHang.TabIndex = 27;
            this.gbThongTinKhachHang.TabStop = false;
            this.gbThongTinKhachHang.Text = " ";
            this.gbThongTinKhachHang.Enter += new System.EventHandler(this.gbThongTinKhachHang_Enter);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.SkyBlue;
            this.btSua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSua.Location = new System.Drawing.Point(441, 129);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(136, 30);
            this.btSua.TabIndex = 33;
            this.btSua.Text = "Sửa ";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.SkyBlue;
            this.btThem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btThem.Location = new System.Drawing.Point(156, 129);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(136, 30);
            this.btThem.TabIndex = 32;
            this.btThem.Text = "Thêm ";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.button6_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.SkyBlue;
            this.btXoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btXoa.Location = new System.Drawing.Point(299, 129);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(136, 30);
            this.btXoa.TabIndex = 31;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(636, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 28);
            this.button2.TabIndex = 38;
            this.button2.Text = "Quay lại";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fDanhSachPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbThongTinKhachHang);
            this.Name = "fDanhSachPhong";
            this.Text = "DanhSachPhong";
            this.Load += new System.EventHandler(this.fDanhSachPhong_Load);
            this.Click += new System.EventHandler(this.fDanhSachPhong_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbThongTinKhachHang.ResumeLayout(false);
            this.gbThongTinKhachHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txSoPhong;
        private System.Windows.Forms.TextBox txGhiChu;
        private System.Windows.Forms.TextBox txDonGia;
        private System.Windows.Forms.ComboBox cbxTinhTrang;
        private System.Windows.Forms.ComboBox cbxLoaiPhong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbThongTinKhachHang;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    }
}