using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;



namespace Quan_ly_khach_san
{
    public partial class fDangNhap : Form
    {
        SqlConnection conn;
        public fDangNhap()
        {
            InitializeComponent();
        }

        void AddButton()
        {
            Button bt = new Button();
            bt.Text = "yes";
            this.Controls.Add(bt);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QLKHACHSAN"].ConnectionString.ToString();
             conn = new SqlConnection(conString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fDanhSachPhong ri = new fDanhSachPhong();
            ri.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            
            try
            {
                conn.Open();
                string tk = txTaiKhoan.Text;
                string mk = txMatKhau.Text;
                string sql = "Select * From DangNhap where TaiKhoan = '"  +tk+  "' and MatKhau = '"  +mk+  "' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if(dta.Read()==true)
                {
                    MessageBox.Show("Đăng Nhập Thành Công");
                    fMain f = new fMain();
                    f.Show();
                    this.Hide();
                }    
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
   
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối");
                
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txMatKhau_TextChanged(object sender, EventArgs e)
        {

        }



        private void fDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btDangNhap_Click(this, new EventArgs());
            }
        }
    }
}
