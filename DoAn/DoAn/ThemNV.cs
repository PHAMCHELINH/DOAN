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
    public partial class ThemNV : Form
    {
        public ThemNV()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Close();
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

        private void txtNgaysinh_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
                this.errorProvider1.SetError(txtNgaysinh, "This is not invalid number");
            else
                this.errorProvider1.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanliNV ql = new QuanliNV();
            ql.Show();
        }
    }
}
