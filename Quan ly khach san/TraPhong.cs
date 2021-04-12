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
    public partial class TraPhong : Form
    {
        public TraPhong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            fMain f = new fMain();
            f.Show();
            this.Close();
        }

        private void TraPhong_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            this.AutoScroll = true;
        }
    }
}
