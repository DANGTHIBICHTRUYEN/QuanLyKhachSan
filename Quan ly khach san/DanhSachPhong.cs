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
    public partial class fDanhSachPhong : Form
    {
        public fDanhSachPhong()
        {
            InitializeComponent();
        }

        //SqlConnection conn;

        private void gbThongTinKhachHang_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fMain f = new fMain();
            f.Show();
            this.Close();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
           
        }



        /*private void fDanhSachPhong_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QLKHACHSAN"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open();
            HienThi();
        }*/

        /*public void HienThi()
        {
            string sqlSELECT = "Select * FROM DSPHONG";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }*/

        /*private void button6_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO DSPHONG VALUES (@SoPhong, @LoaiPhong, @DonGia, @GhiChu, @TinhTrang)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
            cmd.Parameters.AddWithValue("SoPhong", txSoPhong.Text);
            cmd.Parameters.AddWithValue("LoaiPhong", cbxLoaiPhong.Text);
            int i = Convert.ToInt32(txDonGia.Text);
            cmd.Parameters.AddWithValue("DonGia", i);
            cmd.Parameters.AddWithValue("GhiChu", txGhiChu.Text);
            cmd.Parameters.AddWithValue("TinhTrang", cbxTinhTrang.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string SqlDELETE = "DELETE FROM DSPHONG WHERE (SOPHONG = '"+txSoPhong.Text+"')";
            SqlCommand cmd = new SqlCommand(SqlDELETE, conn);
            cmd.ExecuteNonQuery();
            HienThi();

        }


        private void fDanhSachPhong_Click(object sender, EventArgs e)
        {
            txSoPhong.Text = "";
            txDonGia.Text = "";
            txGhiChu.Text = "";
            cbxTinhTrang.Text = "";
            cbxLoaiPhong.Text = "";
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string sqlUPDATE = "UPDATE DSPHONG SET  LoaiPhong = @LoaiPhong,DonGia =  @DonGia, GhiChu = @GhiChu, TinhTrang = @TinhTrang WHERE SoPhong = @SoPhong;";
            SqlCommand cmd = new SqlCommand(sqlUPDATE, conn);
            cmd.Parameters.AddWithValue("SoPhong", txSoPhong.Text);
            cmd.Parameters.AddWithValue("LoaiPhong", cbxLoaiPhong.Text);
            int i = Convert.ToInt32(txDonGia.Text);
            cmd.Parameters.AddWithValue("DonGia", i);
            cmd.Parameters.AddWithValue("GhiChu", txGhiChu.Text);
            cmd.Parameters.AddWithValue("TinhTrang", cbxTinhTrang.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txSoPhong.Text = row.Cells[0].Value.ToString();
                txDonGia.Text = row.Cells[2].Value.ToString();
                txGhiChu.Text = row.Cells[3].Value.ToString();
                cbxTinhTrang.Text = row.Cells[4].Value.ToString();
                cbxLoaiPhong.Text = row.Cells[1].Value.ToString();
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }*/
    }
}
