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
    public partial class QuanliNV : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QLKS;Integrated Security=True");
        public QuanliNV()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu tc = new TrangChu();
            tc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }
        private void LaydsNV()
        {
            try
            {
                conn.Open();
                // command
                SqlCommand cmd = new SqlCommand("sp_LayNV", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // sqldataAdapter
                SqlDataAdapter kh = new SqlDataAdapter(cmd);
                DataTable kk = new DataTable();
                
                kh.Fill(kk);
                dgvNHANVIEN.DataSource = kk;

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

        private int KiemTra()
        {
            int i = 1;
            try
            {
                
                conn.Open();
                SqlDataAdapter dta = new SqlDataAdapter("Select  * From NHANVIEN Where TAIKHOAN = '" + txtTaikhoan.Text + "'", conn);
                DataTable dtb = new DataTable();
                dta.Fill(dtb);
                if (dtb.Rows[0][0].ToString() != "NULL")
                {
                    i = 0;
                }
                
                
            }
            catch (Exception Ex)
            { 
            }
            conn.Close();
            return i;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMANV.Text == "" || txtHoten.Text == "" || txtTaikhoan.Text == "" || txtMatkhau.Text == "" || dtpNS.Text == "" || cbxGT.Text == "" || txtQuequan.Text == "" || txtSODT.Text == "" || (rdoNhanvien.Checked == false && rdoQuanly.Checked == false))
            {
                MessageBox.Show("Vui long dien du thong tin");
            }
            else
            {

                int kT = KiemTra();
                if (kT == 1)
                {
                    String ChucVu = "";
                    if (rdoQuanly.Checked == true)
                    {
                        ChucVu = "QuanLy";
                    }
                    else
                    {
                        ChucVu = "NhanVien";
                    }
                    try
                    {
                        conn.Open();
                        // command
                        SqlCommand cmd = new SqlCommand("sp_ThemNhanVien", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@MSNV", txtMANV.Text));
                        cmd.Parameters.Add(new SqlParameter("@HOTENNV", txtHoten.Text));
                        cmd.Parameters.Add(new SqlParameter("@TAIKHOAN", txtTaikhoan.Text));
                        cmd.Parameters.Add(new SqlParameter("@MATKHAU", txtMatkhau.Text));
                        cmd.Parameters.Add(new SqlParameter("@NGAYSINH", dtpNS.Text));
                        cmd.Parameters.Add(new SqlParameter("@GIOITINH", cbxGT.Text));
                        cmd.Parameters.Add(new SqlParameter("@DIACHI", txtQuequan.Text));
                        cmd.Parameters.Add(new SqlParameter("@DIENTHOAI", txtSODT.Text));
                        cmd.Parameters.Add(new SqlParameter("@NGAYVAOLAM", daten.Text));
                        cmd.Parameters.Add(new SqlParameter("@CHUCVU", ChucVu));
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
                        MessageBox.Show("Loi ket noi 111" + ex.Message, "Thong bao");// thong bao loi
                    }
                    finally
                    {
                        conn.Close();
                        LaydsNV();
                    }
                }
                else
                {
                    MessageBox.Show("Tai Khoan Da Duoc Su Dung");
                }

            }
        
        }

        private void QuanliNV_Load(object sender, EventArgs e)
        {
            LaydsNV();

        }

        private void daten_ValueChanged(object sender, EventArgs e)
        {

        }
        private void txtHoten_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtHoten, "You must enter Your name");
            else
                this.errorProvider1.Clear();
        }

        private void txtQuequan_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtQuequan, "You must enter Your name");
            else
                this.errorProvider1.Clear();
        }

        private void txtTaikhoan_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtTaikhoan, "You must enter Your name");
            else
                this.errorProvider1.Clear();
        }

        private void txtMatkhau_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtMatkhau, "You must enter Your name");
            else
                this.errorProvider1.Clear();
        }

        private void txtMANV_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtMANV, "You must enter Your name");
            else
                this.errorProvider1.Clear();
        }

        private void dgvNHANVIEN_SelectionChanged(object sender, EventArgs e)
        {
            loadDT();
            try
            {
                //Chon ca dong du lieu
                dgvNHANVIEN.CurrentRow.Selected = true;
            }
            catch
            {
            }
        }
        private void loadDT()
        {
            txtMANV.DataBindings.Clear();//xoa du lieu trong text co san
            txtMANV.DataBindings.Add("Text", dgvNHANVIEN.DataSource, "MSNV");//chen cho textbox du lieu tu hang
            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("Text", dgvNHANVIEN.DataSource, "HOTENNV");
            txtTaikhoan.DataBindings.Clear();
            txtTaikhoan.DataBindings.Add("Text", dgvNHANVIEN.DataSource, "TAIKHOAN");
            txtMatkhau.DataBindings.Clear();
            txtMatkhau.DataBindings.Add("Text", dgvNHANVIEN.DataSource, "MATKHAU");
            txtQuequan.DataBindings.Clear();
            txtQuequan.DataBindings.Add("Text", dgvNHANVIEN.DataSource, "DIACHI");
            txtSODT.DataBindings.Clear();
            txtSODT.DataBindings.Add("Text", dgvNHANVIEN.DataSource, "DIENTHOAI");
        }

        private void btnCl_Click(object sender, EventArgs e)
        {
            txtMANV.Text = "";
            txtHoten.Text = "";
            txtTaikhoan.Text = "";
            txtMatkhau.Text = "";
            txtQuequan.Text = "";
            txtSODT.Text = "";
        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaNhanVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MSNV", txtMANV.Text));

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
                LaydsNV();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMANV.Text == "" || txtHoten.Text == "" || txtTaikhoan.Text == "" || txtMatkhau.Text == "" || dtpNS.Text == "" || cbxGT.Text == "" || txtQuequan.Text == "" || txtSODT.Text == "" || (rdoNhanvien.Checked == false && rdoQuanly.Checked == false))
            {
                MessageBox.Show("Vui long dien du thong tin");
            }
            else
            {
                String ChucVu = "";
                if (rdoQuanly.Checked == true)
                {
                    ChucVu = "QuanLy";
                }
                else
                {
                    ChucVu = "NhanVien";
                }
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_Suanv", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MSNV", txtMANV.Text));
                    cmd.Parameters.Add(new SqlParameter("@HOTENNV", txtHoten.Text));
                    cmd.Parameters.Add(new SqlParameter("@TAIKHOAN", txtTaikhoan.Text));
                    cmd.Parameters.Add(new SqlParameter("@MATKHAU", txtMatkhau.Text));
                    cmd.Parameters.Add(new SqlParameter("@NGAYSINH", dtpNS.Text));
                    cmd.Parameters.Add(new SqlParameter("@GIOITINH", cbxGT.Text));
                    cmd.Parameters.Add(new SqlParameter("@DIACHI", txtQuequan.Text));
                    cmd.Parameters.Add(new SqlParameter("@DIENTHOAI", txtSODT.Text));
                    cmd.Parameters.Add(new SqlParameter("@NGAYVAOLAM", daten.Text));
                    cmd.Parameters.Add(new SqlParameter("@CHUCVU", ChucVu));
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
                    LaydsNV();
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LaydsNV();
        }

        private void txtSODT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // command
                SqlCommand cmd = new SqlCommand("SP_TimNV1", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MSNV", txtTim.Text));
                // sqldataAdapter
                SqlDataAdapter kh = new SqlDataAdapter(cmd);
                DataTable kk = new DataTable();

                kh.Fill(kk);
                dgvNHANVIEN.DataSource = kk;

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

        private void txtTim_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
