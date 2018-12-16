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
    public partial class HDThanhToan : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QLKS;Integrated Security=True");
        String str = "";
        int i = 0;
        float fTT = 0;
        public HDThanhToan()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu tc = new TrangChu();
            tc.Show();
        }

        private void LoadNV()
        {
            try
            {
                conn.Open();
                // command
                SqlDataAdapter dta = new SqlDataAdapter("Select * From DANGNHAP ", conn);
                DataTable dtb = new DataTable();
                dta.Fill(dtb);
                txtMSNV.Text = dtb.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi " + ex.Message, "Thong bao");// thong bao loi
            }
            conn.Close();

        }

        private void HDThanhToan_Load(object sender, EventArgs e)
        {
            LoadNV();
            LaydsThuePhong();
            loadHD();
        }

        private void LaydsThuePhong()
        {
            try
            {
                conn.Open();
                // command
                SqlCommand cmd = new SqlCommand("sp_layHopDong", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // sqldataAdapter
                SqlDataAdapter kh = new SqlDataAdapter(cmd);
                DataTable kk = new DataTable();

                kh.Fill(kk);
                dataGridView1.DataSource = kk;

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

        private void loadHD()
        {
            try
            {
                conn.Open();
                // command
                SqlCommand dta = new SqlCommand("Select SOHDONGTHUEPHONG From THUEPHONG ", conn);
                SqlDataReader dr = dta.ExecuteReader();
                DataTable dts = new DataTable();
                dts.Load(dr);
                cmbThuePhong.DisplayMember = "SOHDONGTHUEPHONG";
                cmbThuePhong.DataSource = dts;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi " + ex.Message, "Thong bao");// thong bao loi
            }
            conn.Close();
        }

        private void TinhTien()
        {
            try
            {
                conn.Open();
                // command
                SqlDataAdapter dta = new SqlDataAdapter("Select MSPHONG,GIATIEN From PHONG Where MSPHONG = '" + str + "'", conn);
                DataTable dtb = new DataTable();
                dta.Fill(dtb);
                float f = float.Parse(dtb.Rows[0][1].ToString());
                fTT = i * f;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi 111" + ex.Message, "Thong bao");// thong bao loi
            }
            conn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMSTT.Text == "" || cmbThuePhong.Text == "" || txtMSNV.Text == "" || dttNgayTT.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            else
            {
                LayHD();
                TinhTien();
                try
                {
                    conn.Open();
                    // command
                    SqlCommand cmd = new SqlCommand("sp_ThemHopDong", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@SOTHANHTOAN", txtMSTT.Text));
                    cmd.Parameters.Add(new SqlParameter("@SOHDONGTHUEPHONG", cmbThuePhong.Text));
                    cmd.Parameters.Add(new SqlParameter("@MSNV", txtMSNV.Text));
                    cmd.Parameters.Add(new SqlParameter("@NGAYTHANHTOAN", dttNgayTT.Text));
                    cmd.Parameters.Add(new SqlParameter("@TIENPHONG", fTT));
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Them thanh cong");
                        fTT = 0;
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
                conn.Close();
                LaydsThuePhong();
            }
        }

        private void LayHD()
        {
            try
            {
                conn.Open();
                SqlDataAdapter dta = new SqlDataAdapter("Select NGAYTHUE,NGAYTRADK,MSPHONG From THUEPHONG Where SOHDONGTHUEPHONG = '" + cmbThuePhong.Text + "'", conn);
                DataTable dtb = new DataTable();
                dta.Fill(dtb);
                DateTime date1 = Convert.ToDateTime(dtb.Rows[0][0].ToString());
                DateTime date2 = Convert.ToDateTime(dtb.Rows[0][1].ToString());
                TimeSpan time = date2.Subtract(date1);
                i = time.Days;
                str = dtb.Rows[0][2].ToString();
                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi " + ex.Message, "Thong bao");// thong bao loi
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //Chon ca dong du lieu
                dataGridView1.CurrentRow.Selected = true;
            }
            catch
            {
            }
            LoadDT();
        }

        private void LoadDT()
        {
            txtMSTT.DataBindings.Clear();//xoa du lieu trong text co san
            txtMSTT.DataBindings.Add("Text", dataGridView1.DataSource, "SOTHANHTOAN");
            txtMSNV.DataBindings.Clear();//xoa du lieu trong text co san
            txtMSNV.DataBindings.Add("Text", dataGridView1.DataSource, "MSNV");
            dttNgayTT.DataBindings.Clear();//xoa du lieu trong text co san
            dttNgayTT.DataBindings.Add("Text", dataGridView1.DataSource, "NGAYTHANHTOAN");
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_xoaHopDong", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SOTHANHTOAN", txtMSTT.Text));

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
                LaydsThuePhong();

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadNV();
            LaydsThuePhong();
            loadHD();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMSTT.Text == "" || dttNgayTT.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            else
            {
                try
                {
                    conn.Open();
                    // command
                    SqlCommand cmd = new SqlCommand("sp_SuaHopDong", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@SOTHANHTOAN", txtMSTT.Text));
                    cmd.Parameters.Add(new SqlParameter("@NGAYTHANHTOAN", dttNgayTT.Text));

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sửa thanh cong");

                    }
                    else
                    {
                        MessageBox.Show("Khong thanh cong");
                    }
                }
                catch (Exception ex)
                { }
                conn.Close();
                LaydsThuePhong();
            }
        }

        private void txtMSTT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // command
                SqlCommand cmd = new SqlCommand("SP_TimHD", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SOTHANHTOAN", txtTim.Text));

                // sqldataAdapter
                SqlDataAdapter kh = new SqlDataAdapter(cmd);
                DataTable kk = new DataTable();

                kh.Fill(kk);
                dataGridView1.DataSource = kk;

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

    }
}
