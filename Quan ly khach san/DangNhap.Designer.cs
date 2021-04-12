
namespace Quan_ly_khach_san
{
    partial class fDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDangNhap));
            this.txMatKhau = new System.Windows.Forms.TextBox();
            this.txTaiKhoan = new System.Windows.Forms.TextBox();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txMatKhau
            // 
            this.txMatKhau.Location = new System.Drawing.Point(264, 145);
            this.txMatKhau.Name = "txMatKhau";
            this.txMatKhau.PasswordChar = '*';
            this.txMatKhau.Size = new System.Drawing.Size(140, 20);
            this.txMatKhau.TabIndex = 0;
            this.txMatKhau.UseSystemPasswordChar = true;
            this.txMatKhau.TextChanged += new System.EventHandler(this.txMatKhau_TextChanged);
            // 
            // txTaiKhoan
            // 
            this.txTaiKhoan.BackColor = System.Drawing.SystemColors.Window;
            this.txTaiKhoan.Location = new System.Drawing.Point(264, 113);
            this.txTaiKhoan.Name = "txTaiKhoan";
            this.txTaiKhoan.Size = new System.Drawing.Size(140, 20);
            this.txTaiKhoan.TabIndex = 1;
            this.txTaiKhoan.TextChanged += new System.EventHandler(this.txTaiKhoan_TextChanged);
            // 
            // btDangNhap
            // 
            this.btDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(64)))), ((int)(((byte)(52)))));
            this.btDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDangNhap.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangNhap.ForeColor = System.Drawing.Color.Transparent;
            this.btDangNhap.Location = new System.Drawing.Point(187, 207);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(217, 42);
            this.btDangNhap.TabIndex = 2;
            this.btDangNhap.Text = "Đăng Nhập";
            this.btDangNhap.UseVisualStyleBackColor = false;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lbTaiKhoan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.lbTaiKhoan.Location = new System.Drawing.Point(179, 114);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(79, 19);
            this.lbTaiKhoan.TabIndex = 4;
            this.lbTaiKhoan.Text = "Tài khoản:";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lbMatKhau.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.ForeColor = System.Drawing.Color.White;
            this.lbMatKhau.Location = new System.Drawing.Point(179, 146);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(79, 19);
            this.lbMatKhau.TabIndex = 5;
            this.lbMatKhau.Text = "Mật khẩu:";
            this.lbMatKhau.Click += new System.EventHandler(this.lbMatKhau_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(226, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Xin Chào";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // fDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(568, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbTaiKhoan);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.txTaiKhoan);
            this.Controls.Add(this.txMatKhau);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "fDangNhap";
            this.Text = "Dang nhap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txMatKhau;
        private System.Windows.Forms.TextBox txTaiKhoan;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label label1;
    }
}

