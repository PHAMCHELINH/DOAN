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
    public partial class ThuePhong : Form
    {
        public ThuePhong()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QLKS;Integrated Security=True");
        String str = "";
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu tc = new TrangChu();
            tc.Show();
        }

        private void ThuePhong_Load(object sender, EventArgs e)
        {
            LaydsThuePhong();
            LoadNV();
            loadPh();
            loadKH();
        }

        private void loadPh()
        {
            try
            {
                conn.Open();
                // command
                SqlCommand dta = new SqlCommand("Select MSPHONG From PHONG Where TINHTRANG = 'Trong' ", conn);
                SqlDataReader dr = dta.ExecuteReader();
                DataTable dts = new DataTable();
                dts.Load(dr);
                cmbPhong.DisplayMember = "MSPHONG";
                cmbPhong.DataSource = dts;
        
        
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi " + ex.Message, "Thong bao");// thong bao loi
            }
            conn.Close();
        }

        private void loadKH()
        {
            try
            {
                conn.Open();
                // command
                SqlCommand dta = new SqlCommand("Select MSKH From KHACHHANG ", conn);
                SqlDataReader dr = dta.ExecuteReader();
                DataTable dts = new DataTable();
                dts.Load(dr);
                cmbKH.DisplayMember = "MSKH";
                cmbKH.DataSource = dts;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi " + ex.Message, "Thong bao");// thong bao loi
            }
            conn.Close();
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
                txtMANV.Text = dtb.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi " + ex.Message, "Thong bao");// thong bao loi
            }
            conn.Close();
 
        }

        private int KiemTra()
        {
            DateTime date1 = Convert.ToDateTime(dttNgayThue.Text);
            DateTime date2 = Convert.ToDateTime(dttNgayTra.Text);
            TimeSpan time = date2.Subtract(date1);
            int i = time.Days;
            return i;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoTP.Text == "" || txtMANV.Text == "" || cmbKH.Text == "" || cmbPhong.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            else
            {
                int kT = KiemTra();
                if (kT > 0)
                {
                    try
                    {
                        conn.Open();
                        // command
                        SqlCommand cmd = new SqlCommand("sp_ThemThuePhong", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@SOHDONGTHUEPHONG", txtSoTP.Text));
                        cmd.Parameters.Add(new SqlParameter("@MSNV", txtMANV.Text));
                        cmd.Parameters.Add(new SqlParameter("@NGAYTHUE", dttNgayThue.Text));
                        cmd.Parameters.Add(new SqlParameter("@NGAYTRADK", dttNgayTra.Text));
                        cmd.Parameters.Add(new SqlParameter("@MSKH", cmbKH.Text));
                        cmd.Parameters.Add(new SqlParameter("@MSPHONG", cmbPhong.Text));

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            conn.Close();
                            MessageBox.Show("Them thanh cong");
                            uPDATE();
                        }
                        else
                        {
                            conn.Close();
                            MessageBox.Show("Khong thanh cong");
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Loi ket noi " + ex.Message, "Thong bao");// thong bao loi
                    }
                    finally
                    {

                        LaydsThuePhong();

                        loadPh();
                    }
                }
                else
                {
                    MessageBox.Show("Loi Ngày thuê không lớn hơn ngày trả");
                }
            }
            
        }

        private void uPDATE()
        {
            try
            {
                conn.Open();
                // command
                SqlCommand cmd = new SqlCommand("SP_UPDATE", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MSPHONG", cmbPhong.Text));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Update thanh cong");

                }
                else
                {
                    MessageBox.Show("Update Khong thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi " + ex.Message, "Thong bao");// thong bao loi
            }
            conn.Close();
        }

        private void LaydsThuePhong()
        {
            try
            {
                conn.Open();
                // command
                SqlCommand cmd = new SqlCommand("sp_LaythuePhong", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // sqldataAdapter
                SqlDataAdapter kh = new SqlDataAdapter(cmd);
                DataTable kk = new DataTable();

                kh.Fill(kk);
                dGVThuePhong.DataSource = kk;

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

        private void dGVThuePhong_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //Chon ca dong du lieu
                dGVThuePhong.CurrentRow.Selected = true;
            }
            catch
            {
            }
            LoadTP();
        }

        private void LoadTP()
        {
            txtSoTP.DataBindings.Clear();//xoa du lieu trong text co san
            txtSoTP.DataBindings.Add("Text", dGVThuePhong.DataSource, "SOHDONGTHUEPHONG");//chen cho textbox du lieu tu hang
            txtMANV.DataBindings.Clear();
            txtMANV.DataBindings.Add("Text", dGVThuePhong.DataSource, "MSNV");
            dttNgayThue.DataBindings.Clear();
            dttNgayThue.DataBindings.Add("Text", dGVThuePhong.DataSource, "NGAYTHUE");
            dttNgayTra.DataBindings.Clear();
            dttNgayTra.DataBindings.Add("Text", dGVThuePhong.DataSource, "NGAYTRADK");
            cmbKH.DataBindings.Clear();
            cmbKH.DataBindings.Add("Text", dGVThuePhong.DataSource, "MSKH");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LayMP();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_xoaThuePhong", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SOHDONGTHUEPHONG", txtSoTP.Text));

                if (cmd.ExecuteNonQuery() > 0)
                {
                    conn.Close();
                    MessageBox.Show("Xoa thanh cong");
                    Set_PH();

                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Xoa that bai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi" + ex.Message, "Thong Bao");
            }
            finally
            {
                
                LaydsThuePhong();
                loadPh();
            }
        }



        private void LayMP() {
            try
            {
                conn.Open();
                SqlDataAdapter dta = new SqlDataAdapter("Select MSPHONG From THUEPHONG Where SOHDONGTHUEPHONG = '" +txtSoTP.Text + "'", conn);
                DataTable dtb = new DataTable();
                dta.Fill(dtb);
                str = dtb.Rows[0][0].ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
 
            }
        }

        private void Set_PH()
        {
            try
            {
                conn.Open();
                // command
                SqlCommand cmd = new SqlCommand("SP_XoaUPDATE", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MSPHONG", str));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    //MessageBox.Show("Update thanh cong");

                }
                else
                {
                    MessageBox.Show("Update Khong thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi " + ex.Message, "Thong bao");// thong bao loi
            }
            conn.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtSoTP.Text == "" || txtMANV.Text == "" || cmbKH.Text == "" || cmbPhong.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            else
            {
                LayMP();
                try
                {
                    conn.Open();
                    // command
                    SqlCommand cmd = new SqlCommand("sp_SuathuePhong", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@SOHDONGTHUEPHONG", txtSoTP.Text));
                    cmd.Parameters.Add(new SqlParameter("@MSNV", txtMANV.Text));
                    cmd.Parameters.Add(new SqlParameter("@NGAYTHUE", dttNgayThue.Text));
                    cmd.Parameters.Add(new SqlParameter("@NGAYTRADK", dttNgayTra.Text));
                    cmd.Parameters.Add(new SqlParameter("@MSKH", cmbKH.Text));
                    cmd.Parameters.Add(new SqlParameter("@MSPHONG", cmbPhong.Text));

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        conn.Close();
                        MessageBox.Show("Sửa thanh cong");
                        uPDATE();
                        Set_PH();
                    }
                    else
                    {
                        conn.Close();
                        MessageBox.Show("Khong thanh cong");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi ket noi " + ex.Message, "Thong bao");// thong bao loi
                }
                finally
                {

                    LaydsThuePhong();

                    loadPh();
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LaydsThuePhong();
            LoadNV();
            loadPh();
            loadKH();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // command
                SqlCommand cmd = new SqlCommand("SP_TimTP", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SOHDONGTHUEPHONG", txtTim.Text));

                // sqldataAdapter
                SqlDataAdapter kh = new SqlDataAdapter(cmd);
                DataTable kk = new DataTable();

                kh.Fill(kk);
                dGVThuePhong.DataSource = kk;

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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        
    }
}
