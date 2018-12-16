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
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QLKS;Integrated Security=True");
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
            if (txtMP.Text == "" || txtTT.Text == "" || txtGT.Text == "")
            {
                MessageBox.Show("Vui long nhan day du thong tin");
            }
            else
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
            if (txtMP.Text == "" || txtTT.Text == "" || txtGT.Text == "")
            {
                MessageBox.Show("Vui long nhan day du thong tin");
            }
            else
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

        private void phong_Load(object sender, EventArgs e)
        {
            LaydsPhong();
        }

        private void dtgPhong_SelectionChanged(object sender, EventArgs e)
        {
            loadDT();
            try
            {
                //Chon ca dong du lieu
                dtgPhong.CurrentRow.Selected = true;
            }
            catch
            {
            }
        }
        private void loadDT()
        {
            txtMP.DataBindings.Clear();//xoa du lieu trong text co san
            txtMP.DataBindings.Add("Text", dtgPhong.DataSource, "MSPHONG");//chen cho textbox du lieu tu hang
            txtTT.DataBindings.Clear();
            txtTT.DataBindings.Add("Text", dtgPhong.DataSource, "TINHTRANG");
            txtGT.DataBindings.Clear();
            txtGT.DataBindings.Add("Text", dtgPhong.DataSource, "GIATIEN");
        }


        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            LaydsPhong();
        }

        private void txtGT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // command
                SqlCommand cmd = new SqlCommand("SP_TimPHONG", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MSPHONG", txtTim.Text));
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {

        }

        

    }
}
