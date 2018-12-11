using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAn
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Dangnhap ql = new Dangnhap();
            //ql.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn Thoát?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dangnhap dn = new Dangnhap();
            dn.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanliNV ql = new QuanliNV();
            ql.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            khachhang ql = new khachhang();
            ql.Show();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            phong tc = new phong();
            tc.Show();
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThuePhong tc = new ThuePhong();
            tc.Show();
        }

        private void hợpĐồngThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HDThanhToan tc = new HDThanhToan();
            tc.Show();
        }
    }
}
