using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_khach_san
{
    public partial class fDangNhap : Form
    {
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fDanhMucPhong ri = new fDanhMucPhong();
            ri.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            fDanhMucPhong f = new fDanhMucPhong();
            f.Show();
            this.Hide();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
