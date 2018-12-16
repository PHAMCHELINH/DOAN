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
    public partial class khachhang : Form
    {
        public khachhang()
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
        
         public void LaydsKhachHang()
        {
            // ket noi db
           // SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SB2D9J\\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
             
            // mo ket noi
            try
            {
                conn.Open();
                // command
                SqlCommand cmd = new SqlCommand("sp_LayKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // sqldataAdapter
                SqlDataAdapter kh = new SqlDataAdapter(cmd);
                DataTable kk = new DataTable();
                
                kh.Fill(kk);
                dtgKhachHang.DataSource = kk;

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
            if (txtmkh.Text == "" || txttkh.Text == "" || txtgt.Text == "" || txtdc.Text == "" || txtcmnd.Text == "" || txtsdt.Text == "" || txtqt.Text == "")
            {
                MessageBox.Show("Vui long nhập day đủ thông tin");
            }
            else
            {
                try
                {
                    conn.Open();
                    // command
                    SqlCommand cmd = new SqlCommand("sp_ThemKhachHang", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MSKH", txtmkh.Text));
                    cmd.Parameters.Add(new SqlParameter("@HOTENKH", txttkh.Text));
                    cmd.Parameters.Add(new SqlParameter("@GIOITINHKH", txtgt.Text));
                    cmd.Parameters.Add(new SqlParameter("@DIACHIKH", txtdc.Text));
                    cmd.Parameters.Add(new SqlParameter("@CMND", txtcmnd.Text));
                    cmd.Parameters.Add(new SqlParameter("@DIENTHOAIKH", txtsdt.Text));
                    cmd.Parameters.Add(new SqlParameter("@QUOCTICH", txtqt.Text));
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
                    LaydsKhachHang();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // dtgKhachHang.DataSource = db.GetDataTable("KHACHHANG");
            LaydsKhachHang();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MSKH", txtmkh.Text));

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
                LaydsKhachHang();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtmkh.Text == "" || txttkh.Text == "" || txtgt.Text == "" || txtdc.Text == "" || txtcmnd.Text == "" || txtsdt.Text == "" || txtqt.Text == "")
            {
                MessageBox.Show("Vui long nhập day đủ thông tin");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_SuaKhachHang", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MSKH", txtmkh.Text));
                    cmd.Parameters.Add(new SqlParameter("@HOTENKH", txttkh.Text));
                    cmd.Parameters.Add(new SqlParameter("@GIOITINHKH", txtgt.Text));
                    cmd.Parameters.Add(new SqlParameter("@DIACHIKH", txtdc.Text));
                    cmd.Parameters.Add(new SqlParameter("@CMND", txtcmnd.Text));
                    cmd.Parameters.Add(new SqlParameter("@DIENTHOAIKH", txtsdt.Text));
                    cmd.Parameters.Add(new SqlParameter("@QUOCTICH", txtqt.Text));
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
                    LaydsKhachHang();
                }
            }
        }



   

 


        private void txtmkh_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtmkh, "You must enter ma khach hang");
            else
                this.errorProvider1.Clear();
        }

        private void txttkh_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txttkh, "You must enter Ten Khach hang");
            else
                this.errorProvider1.Clear();
        }

        private void txtdc_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtdc, "You must enter dia chi");
            else
                this.errorProvider1.Clear();
        }

        private void txtgt_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtgt, "You must enter gt");
            else
                this.errorProvider1.Clear();
        }

        private void txtcmnd_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtcmnd, "You must enter cmnd");
            else
                this.errorProvider1.Clear();
        }

        private void txtsdt_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtsdt, "You must enter sdt");
            else
                this.errorProvider1.Clear();
        }

        private void txtqt_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtqt, "You must enter QT");
            else
                this.errorProvider1.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtgKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void khachhang_Load(object sender, EventArgs e)
        {
            LaydsKhachHang();
        }

        private void dtgKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            loadDT();
            try
            {
                //Chon ca dong du lieu
                dtgKhachHang.CurrentRow.Selected = true;
            }
            catch { 
            }
            
        }
        private void loadDT() 
        {
            txtcmnd.DataBindings.Clear();//xoa du lieu trong text co san
            txtcmnd.DataBindings.Add("Text",dtgKhachHang.DataSource,"CMND");//chen cho textbox du lieu tu hang
            txtdc.DataBindings.Clear();
            txtdc.DataBindings.Add("Text", dtgKhachHang.DataSource, "DIACHIKH");
            txtgt.DataBindings.Clear();
            txtgt.DataBindings.Add("Text", dtgKhachHang.DataSource, "GIOITINHKH");
            txtmkh.DataBindings.Clear();
            txtmkh.DataBindings.Add("Text", dtgKhachHang.DataSource, "MSKH");
            txtqt.DataBindings.Clear();
            txtqt.DataBindings.Add("Text", dtgKhachHang.DataSource, "QUOCTICH");
            txtsdt.DataBindings.Clear();
            txtsdt.DataBindings.Add("Text", dtgKhachHang.DataSource, "DIENTHOAIKH");
            txttkh.DataBindings.Clear();
            txttkh.DataBindings.Add("Text", dtgKhachHang.DataSource, "HOTENKH");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LaydsKhachHang();
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
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
                SqlCommand cmd = new SqlCommand("SP_TimKH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MSKH", txtTim.Text));

                // sqldataAdapter
                SqlDataAdapter kh = new SqlDataAdapter(cmd);
                DataTable kk = new DataTable();

                kh.Fill(kk);
                dtgKhachHang.DataSource = kk;

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

        }
    }


