using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DoAn
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QLKS;Integrated Security=True");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

    

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Dangnhap ql = new Dangnhap();
            //ql.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn Thoát?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dangnhap dn = new Dangnhap();
            dn.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dangnhap tc = new Dangnhap();
            tc.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                // command
                SqlDataAdapter dta = new SqlDataAdapter("Select Count (*) From DANGNHAP ", conn);
                DataTable dtb = new DataTable();
                dta.Fill(dtb);
                if (dtb.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    khachhang ql = new khachhang();
                    ql.Show();
                }
                else {
                    this.Hide();
                    DNNV tc = new DNNV();
                    tc.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi " + ex.Message, "Thong bao");// thong bao loi
            }
            conn.Close();
            
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // command
                SqlDataAdapter dta = new SqlDataAdapter("Select Count (*) From DANGNHAP ", conn);
                DataTable dtb = new DataTable();
                dta.Fill(dtb);
                if (dtb.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    phong tc = new phong();
                    tc.Show();
                }
                else
                {
                    this.Hide();
                    DNNV tc = new DNNV();
                    tc.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi " + ex.Message, "Thong bao");// thong bao loi
            }
            conn.Close();
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // command
                SqlDataAdapter dta = new SqlDataAdapter("Select Count (*) From DANGNHAP ", conn);
                DataTable dtb = new DataTable();
                dta.Fill(dtb);
                if (dtb.Rows[0][0].ToString() == "1")
                {   
                    this.Hide();
                    ThuePhong tc = new ThuePhong();
                    tc.Show();                 
                }
                else
                {
                    this.Hide();
                    DNNV tc = new DNNV();
                    tc.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi " + ex.Message, "Thong bao");// thong bao loi
            }

            conn.Close();
        }

        private void hợpĐồngThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // command
                SqlDataAdapter dta = new SqlDataAdapter("Select Count (*) From DANGNHAP ", conn);
                DataTable dtb = new DataTable();
                dta.Fill(dtb);
                if (dtb.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    HDThanhToan tc = new HDThanhToan();
                    tc.Show();
                }
                else
                {
                    this.Hide();
                    DNNV tc = new DNNV();
                    tc.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi " + ex.Message, "Thong bao");// thong bao loi
            }
            conn.Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_LogOut", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    //MessageBox.Show("Dang Xuat thanh cong");

                }
                else
                {
                    //MessageBox.Show("Dang Xuat that bai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi" + ex.Message, "Thong Bao");
            }
            conn.Close();
            this.Hide();
            DNNV tc = new DNNV();
            tc.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_LogOut", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Dang Xuat thanh cong");

                }
                else
                {
                    MessageBox.Show("Dang Xuat that bai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi" + ex.Message, "Thong Bao");
            }
            conn.Close();
        }
    }
}
