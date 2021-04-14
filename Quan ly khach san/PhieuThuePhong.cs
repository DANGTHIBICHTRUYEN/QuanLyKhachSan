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
    public partial class fPhieuThuePhong : Form
    {
        public fPhieuThuePhong()
        {
            InitializeComponent();
        }

        SqlConnection conn;


        private void fPhieuThuePhong_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QLKHACHSAN"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open();
            HienThi();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbMaPTP_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            fMain f = new fMain();
            f.Show();
            this.Close();
        }

        private void fPhieuThuePhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        public void HienThi()
        {
            string sqlSELECT = "Select MAHD, MaKH, NgayBatDau, NGAYTRAPHONG, SOPHONG, DONGIA FROM HOADON";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO HOADON VALUES (@MAHD, @MAKH, @SOPHONG, @NGAYBATDAU, @NGAYTRAPHONG, @SONGAYTHUE, @DONGIA, @THANHTIEN)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
            cmd.Parameters.AddWithValue("MAHD", txtMaHD.Text);
            cmd.Parameters.AddWithValue("NGAYBATDAU", dtNgayBatDau.Value.ToString());
            cmd.Parameters.AddWithValue("SOPHONG", txtSoPhong.Text);
            cmd.Parameters.AddWithValue("MAKH", txtMaKH.Text);
            cmd.Parameters.AddWithValue("NGAYTRAPHONG", dtNgayKetThuc.Value.ToString());
            cmd.Parameters.AddWithValue("DONGIA", txtDonGia.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void dtNgayBatDau_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
