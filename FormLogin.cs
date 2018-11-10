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
namespace QLkhachsan
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //thong bao exit
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //khong duoc de trong o tao khoang
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtTaiKhoan, "You must enter Your name");
            else
                this.errorProvider1.Clear();
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtMatKhau, "You must enter Your name");
            else
                this.errorProvider1.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            //duong dan toi sql
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BV0MFSC\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                //cau lenh sql
                string sqlNhanVien = "select *from TBNhanVien where TaiKhoan='" + tk + "' and MatKhau ='" + mk + "'";
                string sqlCV = "select ChucVu from TBNhanVien where TaiKhoan='" + tk + "";
                SqlCommand cmd = new SqlCommand(sqlNhanVien,conn);
                SqlDataReader data = cmd.ExecuteReader();
                SqlCommand cv = new SqlCommand(sqlCV, conn);
                if (data.Read()==true)
                {
                    if (data["ChucVu"].ToString() == "QL")
                    {
                        MessageBox.Show("Đăng nhập thành công.");
                        FormQuanLy ql = new FormQuanLy();
                        ql.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công.");
                        FormTrangChu tc = new FormTrangChu();
                        tc.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công.");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Loi ket noi.");
            }
        }
    }
}
