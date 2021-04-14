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
    public partial class fDanhSachKhachHang : Form
    {
        SqlConnection conn;

        public fDanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {

        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            fMain f = new fMain();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fMain f = new fMain();
            f.Show();
            this.Close();
        }

        private void fDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QLKHACHSAN"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open();
            HienThi();
        }

        public void HienThi()
        {
            string sqlSELECT = "Select * FROM KhachHang";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txMaKhachHang.Text = row.Cells[0].Value.ToString();
                txTenKhachHang.Text = row.Cells[1].Value.ToString();
                txSoDienThoai.Text = row.Cells[3].Value.ToString();
                txCMND.Text = row.Cells[4].Value.ToString();
                cbxGioiTinh.Text = row.Cells[2].Value.ToString();
                txDiaChi.Text = row.Cells[5].Value.ToString();
                txQuocTich.Text = row.Cells[6].Value.ToString();
                cbxLoaiKhach.Text = row.Cells[7].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string SqlDELETE = "DELETE FROM KHACHHANG WHERE (MAKH = '" + txMaKhachHang.Text + "')";
            SqlCommand cmd = new SqlCommand(SqlDELETE, conn);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btSua_Click_1(object sender, EventArgs e)
        {
            string sqlUPDATE = "UPDATE KHACHHANG SET TenKH =  @TenKH, GioiTinh = @GioiTinh," +
             " SDT = @SDT, CMND = @CMND, DiaChi = @DiaChi, QuocTich = @QuocTich, LoaiKhach = @LoaiKhach" +
             " WHERE MaKH = @MaKH;";
            SqlCommand cmd = new SqlCommand(sqlUPDATE, conn);
            cmd.Parameters.AddWithValue("MaKH", txMaKhachHang.Text);
            cmd.Parameters.AddWithValue("TenKH", txTenKhachHang.Text);
            cmd.Parameters.AddWithValue("SDT", txSoDienThoai.Text);
            cmd.Parameters.AddWithValue("CMND", txCMND.Text);
            cmd.Parameters.AddWithValue("GioiTInh", cbxGioiTinh.Text);
            cmd.Parameters.AddWithValue("DiaChi", txDiaChi.Text);
            cmd.Parameters.AddWithValue("QuocTich", txQuocTich.Text);
            cmd.Parameters.AddWithValue("LoaiKhach", cbxLoaiKhach.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO KHACHHANG VALUES ( @MaKH, @TenKH,   @GioiTinh,   @SDT,  @CMND,  @DiaChi,  @QuocTich, @LoaiKhach)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
            cmd.Parameters.AddWithValue("MaKH", txMaKhachHang.Text);
            cmd.Parameters.AddWithValue("TenKH", txTenKhachHang.Text);
            cmd.Parameters.AddWithValue("SDT", txSoDienThoai.Text);
            cmd.Parameters.AddWithValue("CMND", txCMND.Text);
            cmd.Parameters.AddWithValue("GioiTInh", cbxGioiTinh.Text);
            cmd.Parameters.AddWithValue("DiaChi", txDiaChi.Text);
            cmd.Parameters.AddWithValue("QuocTich", txQuocTich.Text);
            cmd.Parameters.AddWithValue("LoaiKhach", cbxLoaiKhach.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }
    }
}
