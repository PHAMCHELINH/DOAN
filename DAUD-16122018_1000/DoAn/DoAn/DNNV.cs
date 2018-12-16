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
    public partial class DNNV : Form
    {
        public DNNV()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu tc = new TrangChu();
            tc.Show();
        }
        private void txtUser_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtUser, "You must enter Your name");
            else
                this.errorProvider1.Clear();
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtPass, "You must enter Your name");
            else
                this.errorProvider1.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=QLKS;Integrated Security=True");
            String ChucVu = "";
            



            if (rdoQuanly.Checked == true)
            {
                try
                {
                    ChucVu = "QuanLy";
                    
                    SqlDataAdapter dta = new SqlDataAdapter("Select * From NHANVIEN Where TAIKHOAN = '" + txtUser.Text + "' and MATKHAU = '" + txtPass.Text + "' and CHUCVU = 'QuanLy'", con);
                    DataTable dtb = new DataTable();
                    dta.Fill(dtb);
                    if (dtb.Rows[0][0].ToString() != "NULL")
                    {
                        lblMA.Text = dtb.Rows[0][0].ToString();
                        con.Close();
                        try{
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SP_Login", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@MSNV", lblMA.Text));
                        cmd.Parameters.Add(new SqlParameter("@TAIKHOAN", txtUser.Text));
                        cmd.Parameters.Add(new SqlParameter("@MATKHAU", txtPass.Text));
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Dang Nhap thanh cong");

                        }
                        else
                        {
                            MessageBox.Show("Dang Nhap Khong thanh cong");
                        }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Loi ket noi " + ex.Message, "Thong bao");// thong bao loi
                        }


                        
                        this.Hide();
                        TrangChu tc = new TrangChu();
                        tc.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tai khong hoac mat khau khong chinh xac!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                try
                {
                    ChucVu = "NhanVien";
                    SqlDataAdapter dta = new SqlDataAdapter("Select  * From NHANVIEN Where TAIKHOAN = '" + txtUser.Text + "' and MATKHAU = '" + txtPass.Text + "' and CHUCVU = 'NhanVien'", con);
                    DataTable dtb = new DataTable();
                    dta.Fill(dtb);
                    if (dtb.Rows[0][0].ToString() != "NULL")
                    {
                        lblMA.Text = dtb.Rows[0][0].ToString();
                        con.Close();
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("SP_Login", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@MSNV", lblMA.Text));
                            cmd.Parameters.Add(new SqlParameter("@TAIKHOAN", txtUser.Text));
                            cmd.Parameters.Add(new SqlParameter("@MATKHAU", txtPass.Text));
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Dang Nhap thanh cong");

                            }
                            else
                            {
                                MessageBox.Show("Dang Nhap Khong thanh cong");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Loi ket noi " + ex.Message, "Thong bao");// thong bao loi
                        }
                        this.Hide();
                        TrangChu tc = new TrangChu();
                        tc.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tai khong hoac mat khau khong chinh xac!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {

                }
                
            }
            con.Close();
            lblCB.Text = "Tai khong hoac mat khau khong chinh xac!";
        }

        private void DNNV_Load(object sender, EventArgs e)
        {

        }
    }
}
