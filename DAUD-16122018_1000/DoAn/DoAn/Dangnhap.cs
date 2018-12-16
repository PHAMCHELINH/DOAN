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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
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
            try
            {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=QLKS;Integrated Security=True");
            SqlDataAdapter dta = new SqlDataAdapter("Select  * From NHANVIEN Where TAIKHOAN = '" + txtUser.Text + "' and MATKHAU = '" + txtPass.Text + "' and CHUCVU = 'QuanLy'", con);
            DataTable dtb = new DataTable();
            dta.Fill(dtb);
            if (dtb.Rows[0][0].ToString() != "NULL")
            {
                this.Hide();
                QuanliNV ql = new QuanliNV();
                ql.Show();
            }
            
            }catch(Exception ex)
            {

            }
            lblCB.Text = "Tai khong hoac mat khau khong chinh xac!";
        }

       
    }
}
