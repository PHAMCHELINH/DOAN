using System;
using System.IO;
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
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin lg = new FormLogin();
            lg.Show();
            this.Close();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoten = txtHoten.Text;
            string ngaysinh = txtNgaysinh.Text;
            string quequan = txtQuequan.Text;
            string taikhoan = txtTaikhoang.Text;
            string matkhau = txtMatkhau.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BV0MFSC\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True");
            conn.Open();
            string sqlAdd = "insert into TBNhanVien(HoTen)values("+txtHoten+")";
            SqlCommand cmd = new SqlCommand(sqlAdd,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //

        private void FormQuanLy_Load(object sender, EventArgs e)
        {

        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            string arrCon = @"Data Source=DESKTOP-BV0MFSC\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
            SqlConnection conn = new SqlConnection(arrCon);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand("select *from TBNhanVien",conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string arrCon = @"Data Source=DESKTOP-BV0MFSC\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
                SqlConnection conn = new SqlConnection(arrCon);
                conn.Open();
                string sqlAdd = "INSERT INTO TBNhanVien(MaNV,TaiKhoan,MatKhau,ChucVu,HoTen,Ngaysinh,QueQuan) VALUES('" + txtMaNV.Text +"','" + txtTaikhoang.Text + "','" + txtMatkhau.Text + "','" + txtChucVu.Text + "','" + txtHoten.Text + "','" + txtNgaysinh.Text + "','" + txtQuequan.Text + "')";
                var cmd = new SqlCommand(sqlAdd, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bạn đã thêm thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("select *from TBNhanVien", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Loi ket noi.");
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtChucVu.Text = "";
            txtHoten.Text = "";
            txtMatkhau.Text = "";
            txtNgaysinh.Text = "";
            txtQuequan.Text = "";
            txtTaikhoang.Text = "";
            txtMaNV.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string arrCon = @"Data Source=DESKTOP-BV0MFSC\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
            SqlConnection conn = new SqlConnection(arrCon);
            conn.Open();
            int CurrentIndex = dataGridView1.CurrentCell.RowIndex;
            string key = Convert.ToString(dataGridView1.Rows[CurrentIndex].Cells[0].Value.ToString());
            string deletedStr = "Delete from TBNhanVien where MaNV='" + key + "'";
            SqlCommand deletedCmd = new SqlCommand(deletedStr, conn);
            deletedCmd.CommandType = CommandType.Text;
            deletedCmd.ExecuteNonQuery();
            MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand("select *from TBNhanVien", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void txtHoten_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtHoten, "You must enter Your name");
            else
                this.errorProvider1.Clear();
        }

        private void txtNgaysinh_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtNgaysinh, "You must enter Your name");
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

        private void txtTaikhoang_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtTaikhoang, "You must enter Your name");
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

        private void txtChucVu_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtChucVu, "You must enter Your name");
            else
                this.errorProvider1.Clear();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn đăng xuất?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {  
            string arrCon = @"Data Source=DESKTOP-BV0MFSC\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
            SqlConnection conn = new SqlConnection(arrCon);
            conn.Open();
            int CurrentIndex = dataGridView2.CurrentCell.RowIndex;
            string key = Convert.ToString(dataGridView2.Rows[CurrentIndex].Cells[0].Value.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand("select from TBNhanVien where MaNV='" + key + "'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
        }
    }
}
