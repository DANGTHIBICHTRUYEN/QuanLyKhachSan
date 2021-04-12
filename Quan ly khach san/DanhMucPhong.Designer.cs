
namespace Quan_ly_khach_san
{
    partial class fDanhMucPhong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhMucPhong));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txMaPhong = new System.Windows.Forms.TextBox();
            this.cbxLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txDonGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btThemPhong = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btXoaPhong = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txGhiChu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Phong,
            this.LoaiPhong,
            this.DonGia,
            this.GhiChu});
            this.dataGridView1.Location = new System.Drawing.Point(21, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // Phong
            // 
            this.Phong.HeaderText = "Phòng";
            this.Phong.Name = "Phong";
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.HeaderText = "Loại Phòng";
            this.LoaiPhong.Name = "LoaiPhong";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // txMaPhong
            // 
            this.txMaPhong.Location = new System.Drawing.Point(113, 57);
            this.txMaPhong.Name = "txMaPhong";
            this.txMaPhong.Size = new System.Drawing.Size(100, 20);
            this.txMaPhong.TabIndex = 1;
            this.txMaPhong.TextChanged += new System.EventHandler(this.txMaPhong_TextChanged);
            // 
            // cbxLoaiPhong
            // 
            this.cbxLoaiPhong.FormattingEnabled = true;
            this.cbxLoaiPhong.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbxLoaiPhong.Location = new System.Drawing.Point(414, 57);
            this.cbxLoaiPhong.Name = "cbxLoaiPhong";
            this.cbxLoaiPhong.Size = new System.Drawing.Size(121, 21);
            this.cbxLoaiPhong.TabIndex = 2;
            this.cbxLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbxLoaiPhong_SelectedIndexChanged);
            // 
            // txDonGia
            // 
            this.txDonGia.Location = new System.Drawing.Point(113, 107);
            this.txDonGia.Name = "txDonGia";
            this.txDonGia.Size = new System.Drawing.Size(100, 20);
            this.txDonGia.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Loại Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giá Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(143, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "BẢNG LẬP DANH MỤC PHÒNG";
            // 
            // btThemPhong
            // 
            this.btThemPhong.ImageIndex = 1;
            this.btThemPhong.ImageList = this.imageList1;
            this.btThemPhong.Location = new System.Drawing.Point(542, 145);
            this.btThemPhong.Name = "btThemPhong";
            this.btThemPhong.Size = new System.Drawing.Size(30, 30);
            this.btThemPhong.TabIndex = 9;
            this.btThemPhong.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1200px-Flat_tick_icon.svg.png");
            this.imageList1.Images.SetKeyName(1, "cercle+close+delete+dismiss+remove+icon-1320196712448219692.png");
            this.imageList1.Images.SetKeyName(2, "add-icon-png-1.png");
            // 
            // btXoaPhong
            // 
            this.btXoaPhong.ImageIndex = 2;
            this.btXoaPhong.ImageList = this.imageList1;
            this.btXoaPhong.Location = new System.Drawing.Point(505, 145);
            this.btXoaPhong.Name = "btXoaPhong";
            this.btXoaPhong.Size = new System.Drawing.Size(30, 30);
            this.btXoaPhong.TabIndex = 10;
            this.btXoaPhong.UseVisualStyleBackColor = true;
            this.btXoaPhong.Click += new System.EventHandler(this.btXoaPhong_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ghi Chú";
            // 
            // txGhiChu
            // 
            this.txGhiChu.Location = new System.Drawing.Point(414, 105);
            this.txGhiChu.Name = "txGhiChu";
            this.txGhiChu.Size = new System.Drawing.Size(121, 20);
            this.txGhiChu.TabIndex = 12;
            // 
            // fDanhMucPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 363);
            this.Controls.Add(this.txGhiChu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btXoaPhong);
            this.Controls.Add(this.btThemPhong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txDonGia);
            this.Controls.Add(this.cbxLoaiPhong);
            this.Controls.Add(this.txMaPhong);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fDanhMucPhong";
            this.Text = "Danh Mục Phòng";
            this.Load += new System.EventHandler(this.Thong_tin_phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.TextBox txMaPhong;
        private System.Windows.Forms.TextBox txDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btThemPhong;
        private System.Windows.Forms.Button btXoaPhong;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txGhiChu;
        private System.Windows.Forms.ComboBox cbxLoaiPhong;
    }
}