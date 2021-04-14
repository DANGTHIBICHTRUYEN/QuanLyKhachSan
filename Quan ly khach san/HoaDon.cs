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
    public partial class HoaDon : Form
    {
        SqlConnection conn;
        public HoaDon()
        {
            InitializeComponent();
        }

        public void HienThi()
        {
            string sqlSELECT = "Select * FROM HOADON";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            fMain f = new fMain();
            f.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
          
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QLKHACHSAN"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open();
            HienThi();
        }
    }
}
