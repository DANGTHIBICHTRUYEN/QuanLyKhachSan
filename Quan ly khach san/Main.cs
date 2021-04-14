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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rrtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýDanhSáchPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDoanhThu f = new fDoanhThu();
            f.Show();
            this.Close();
        }

        private void bÁoCÁoDoanhThuTheoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void danhSáchPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDanhSachPhong f = new fDanhSachPhong();
            f.Show();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDanhSachKhachHang f = new fDanhSachKhachHang();
            f.Show();
            this.Close();
        }

        private void lapPhieuThuePhongToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fDanhSachPhong f = new fDanhSachPhong();
            f.Show();
            this.Close();
        }

        private void traPhongToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HoaDon f = new HoaDon();
            f.Show();
            this.Close();
        }

        private void lapHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon f = new HoaDon();
            f.Show();
            this.Close();
        }

        private void chucNangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lậpPhiếuThuêPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fPhieuThuePhong f = new fPhieuThuePhong();
            f.Show();
            this.Close();
        }
    }
}
