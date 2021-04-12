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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txMaKhachHang = new System.Windows.Forms.TextBox();
            this.txSoPhong = new System.Windows.Forms.TextBox();
            this.txDonGia = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbxLoaiPhong = new System.Windows.Forms.ComboBox();
            this.cbxTinhTrang = new System.Windows.Forms.ComboBox();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThongTinPhong = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbThongTinPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGreen;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(31, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGreen;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(31, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGreen;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(388, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGreen;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(388, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tình Trạng";
            // 
            // txMaKhachHang
            // 
            this.txMaKhachHang.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMaKhachHang.Location = new System.Drawing.Point(154, 21);
            this.txMaKhachHang.Name = "txMaKhachHang";
            this.txMaKhachHang.Size = new System.Drawing.Size(155, 26);
            this.txMaKhachHang.TabIndex = 6;
            // 
            // txSoPhong
            // 
            this.txSoPhong.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txSoPhong.Location = new System.Drawing.Point(154, 66);
            this.txSoPhong.Name = "txSoPhong";
            this.txSoPhong.Size = new System.Drawing.Size(155, 26);
            this.txSoPhong.TabIndex = 9;
            this.txSoPhong.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txDonGia
            // 
            this.txDonGia.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txDonGia.Location = new System.Drawing.Point(504, 21);
            this.txDonGia.Name = "txDonGia";
            this.txDonGia.Size = new System.Drawing.Size(155, 26);
            this.txDonGia.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.SoPhong,
            this.LoaiPhong,
            this.DonGia,
            this.TinhTrang});
            this.dataGridView1.Location = new System.Drawing.Point(21, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 240);
            this.dataGridView1.TabIndex = 15;
            // 
            // cbxLoaiPhong
            // 
            this.cbxLoaiPhong.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.cbxLoaiPhong.FormattingEnabled = true;
            this.cbxLoaiPhong.Location = new System.Drawing.Point(154, 113);
            this.cbxLoaiPhong.Name = "cbxLoaiPhong";
            this.cbxLoaiPhong.Size = new System.Drawing.Size(155, 28);
            this.cbxLoaiPhong.TabIndex = 24;
            // 
            // cbxTinhTrang
            // 
            this.cbxTinhTrang.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.cbxTinhTrang.FormattingEnabled = true;
            this.cbxTinhTrang.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbxTinhTrang.Location = new System.Drawing.Point(504, 67);
            this.cbxTinhTrang.Name = "cbxTinhTrang";
            this.cbxTinhTrang.Size = new System.Drawing.Size(155, 28);
            this.cbxTinhTrang.TabIndex = 25;
            // 
            // MaKH
            // 
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 130;
            // 
            // SoPhong
            // 
            this.SoPhong.HeaderText = "Số Phòng";
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.Width = 130;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.HeaderText = "Loại Phòng";
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.Width = 130;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 130;
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 130;
            // 
            // gbThongTinPhong
            // 
            this.gbThongTinPhong.Controls.Add(this.cbxTinhTrang);
            this.gbThongTinPhong.Controls.Add(this.cbxLoaiPhong);
            this.gbThongTinPhong.Controls.Add(this.txDonGia);
            this.gbThongTinPhong.Controls.Add(this.txSoPhong);
            this.gbThongTinPhong.Controls.Add(this.txMaKhachHang);
            this.gbThongTinPhong.Controls.Add(this.label6);
            this.gbThongTinPhong.Controls.Add(this.label5);
            this.gbThongTinPhong.Controls.Add(this.label4);
            this.gbThongTinPhong.Controls.Add(this.label3);
            this.gbThongTinPhong.Controls.Add(this.label2);
            this.gbThongTinPhong.Location = new System.Drawing.Point(35, 58);
            this.gbThongTinPhong.Name = "gbThongTinPhong";
            this.gbThongTinPhong.Size = new System.Drawing.Size(678, 158);
            this.gbThongTinPhong.TabIndex = 26;
            this.gbThongTinPhong.TabStop = false;
            this.gbThongTinPhong.Text = "Thông Tin Phòng";
            // 
            // fDanhSachPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 498);
            this.Controls.Add(this.gbThongTinPhong);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "fDanhSachPhong";
            this.Text = "DanhSachPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbThongTinPhong.ResumeLayout(false);
            this.gbThongTinPhong.PerformLayout();
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
        private System.Windows.Forms.TextBox txMaKhachHang;
        private System.Windows.Forms.TextBox txSoPhong;
        private System.Windows.Forms.TextBox txDonGia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbxLoaiPhong;
        private System.Windows.Forms.ComboBox cbxTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.GroupBox gbThongTinPhong;
    }
}