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
    public partial class phong : Form
    {
        public phong()
        {
            InitializeComponent();
        }
        clsDatabase db = new clsDatabase();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SB2D9J\\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu tc = new TrangChu();
            tc.Show();
        }

        public void LaydsPhong()
        {
          
            try
            {
                conn.Open();
                // command
                SqlCommand cmd = new SqlCommand("SP_LAYPHONG", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // sqldataAdapter
                SqlDataAdapter kh = new SqlDataAdapter(cmd);
                DataTable kk = new DataTable();

                kh.Fill(kk);
                dtgPhong.DataSource = kk;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi " + ex.Message, "Thong bao");// thong bao loi
            }
            finally
            {
                conn.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // command
                SqlCommand cmd = new SqlCommand("sp_themPhong", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MSPHONG", txtMP.Text));
                cmd.Parameters.Add(new SqlParameter("@TINHTRANG", txtTT.Text));
                cmd.Parameters.Add(new SqlParameter("@GIATIEN", txtGT.Text));
             
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Them thanh cong");

                }
                else
                {
                    MessageBox.Show("Khong thanh cong");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi " + ex.Message, "Thong bao");// thong bao loi
            }
            finally
            {
                conn.Close();
                LaydsPhong();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LaydsPhong();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_XOAPHONG", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MSPHONG", txtMP.Text));

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xoa thanh cong");

                }
                else
                {
                    MessageBox.Show("Xoa that bai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi" + ex.Message, "Thong Bao");
            }
            finally
            {
                conn.Close();
                LaydsPhong();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_SUAPHONG", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MSPHONG", txtMP.Text));
                cmd.Parameters.Add(new SqlParameter("@TINHTRANG", txtTT.Text));
                cmd.Parameters.Add(new SqlParameter("@GIATIEN", txtGT.Text));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sua thanh cong");

                }
                else
                {
                    MessageBox.Show("Sua that bai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi" + ex.Message, "Thong Bao");
            }
            finally
            {
                conn.Close();
                LaydsPhong();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMP_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtMP, "You must enter QT");
            else
                this.errorProvider1.Clear();
        }

      

       

        private void txtGT_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtGT, "You must enter QT");
            else
                this.errorProvider1.Clear();
        }

        private void txtTT_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtTT, "You must enter QT");
            else
                this.errorProvider1.Clear();
        }
    }
}
