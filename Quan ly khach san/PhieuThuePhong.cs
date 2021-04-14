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


        

        private void lbMaPTP_Click(object sender, EventArgs e)
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
            string sqlSELECT = "Select * FROM PHIEUTHUEPHONG";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string dangduocthue = "Đang Được Thuê";
            string sqlINSERT = "INSERT INTO PhieuThuePhong VALUES (@MaPTP, @SoPhong, @MaKH, @NgayThue, @NgayTra, @DonGia); " +
                "UPDATE DSPHONG SET TinhTrang = N'Đang Được Thuê' WHERE SoPhong = @SoPhong;";
            SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
            cmd.Parameters.AddWithValue("MaPTP", txMaPTP.Text);
            cmd.Parameters.AddWithValue("SoPhong", txtSoPhong.Text);
            cmd.Parameters.AddWithValue("MaKH", txtMaKH.Text);
            cmd.Parameters.AddWithValue("NgayThue", dtNgayBatDau.Value);
            cmd.Parameters.AddWithValue("NgayTra", dtNgayKetThuc.Value);
            cmd.Parameters.AddWithValue("DonGia", txtDonGia.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void dtNgayBatDau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txMaPTP.Text = row.Cells[0].Value.ToString();
                txtSoPhong.Text = row.Cells[1].Value.ToString();
                txtMaKH.Text = row.Cells[2].Value.ToString();
                dtNgayBatDau.Text = row.Cells[3].Value.ToString();
                dtNgayKetThuc.Text = row.Cells[4].Value.ToString();
                txtDonGia.Text = row.Cells[5].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlUPDATE = "UPDATE PhieuThuePhong SET  SoPhong =  @SoPhong, MaKH = @MaKH, NgayThue = @NgayThue, NgayTra=@NgayTra, DonGia = @DonGia WHERE MaPTP = @MaPTP;";
            SqlCommand cmd = new SqlCommand(sqlUPDATE, conn);
            cmd.Parameters.AddWithValue("MaPTP", txMaPTP.Text);
            cmd.Parameters.AddWithValue("SoPhong", txtSoPhong.Text);
            cmd.Parameters.AddWithValue("MaKH", txtMaKH.Text);
            cmd.Parameters.AddWithValue("NgayThue", dtNgayBatDau.Value);
            cmd.Parameters.AddWithValue("NgayTra", dtNgayKetThuc.Value);
            int i = Convert.ToInt32(txtDonGia.Text);
            cmd.Parameters.AddWithValue("DonGia", i);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string SqlDELETE = "DELETE FROM PhieuThuePhong WHERE (MAPTP = '" + txMaPTP.Text + "')";
            SqlCommand cmd = new SqlCommand(SqlDELETE, conn);
            cmd.ExecuteNonQuery();
            HienThi();
        }
    }
}
