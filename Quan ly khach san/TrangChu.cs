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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btDanhSachPhong_Click(object sender, EventArgs e)
        {
            fDanhSachPhong f = new fDanhSachPhong();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fDanhSachKhachHang f = new fDanhSachKhachHang();
            f.Show();
            this.Close();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
