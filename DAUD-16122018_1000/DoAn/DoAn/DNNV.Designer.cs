namespace DoAn
{
    partial class DNNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoQuanly = new System.Windows.Forms.RadioButton();
            this.rdoNhanvien = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMA = new System.Windows.Forms.Label();
            this.lblCB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.ForeColor = System.Drawing.Color.Purple;
            this.btnExit.Location = new System.Drawing.Point(371, 265);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 38);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLogin.Location = new System.Drawing.Point(217, 265);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 38);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPass.Location = new System.Drawing.Point(217, 133);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(272, 30);
            this.txtPass.TabIndex = 11;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUser.Location = new System.Drawing.Point(217, 86);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(272, 30);
            this.txtUser.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(81, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(81, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "User :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(110, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // rdoQuanly
            // 
            this.rdoQuanly.AutoSize = true;
            this.rdoQuanly.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoQuanly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdoQuanly.Location = new System.Drawing.Point(371, 216);
            this.rdoQuanly.Margin = new System.Windows.Forms.Padding(4);
            this.rdoQuanly.Name = "rdoQuanly";
            this.rdoQuanly.Size = new System.Drawing.Size(115, 30);
            this.rdoQuanly.TabIndex = 16;
            this.rdoQuanly.TabStop = true;
            this.rdoQuanly.Text = "Quản lý";
            this.rdoQuanly.UseVisualStyleBackColor = true;
            // 
            // rdoNhanvien
            // 
            this.rdoNhanvien.AutoSize = true;
            this.rdoNhanvien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoNhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdoNhanvien.Location = new System.Drawing.Point(219, 215);
            this.rdoNhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNhanvien.Name = "rdoNhanvien";
            this.rdoNhanvien.Size = new System.Drawing.Size(136, 30);
            this.rdoNhanvien.TabIndex = 15;
            this.rdoNhanvien.TabStop = true;
            this.rdoNhanvien.Text = "Nhân viên";
            this.rdoNhanvien.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(99, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Chức vụ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblMA
            // 
            this.lblMA.AutoSize = true;
            this.lblMA.Location = new System.Drawing.Point(12, 290);
            this.lblMA.Name = "lblMA";
            this.lblMA.Size = new System.Drawing.Size(0, 17);
            this.lblMA.TabIndex = 17;
            // 
            // lblCB
            // 
            this.lblCB.AutoSize = true;
            this.lblCB.BackColor = System.Drawing.Color.Crimson;
            this.lblCB.Location = new System.Drawing.Point(179, 184);
            this.lblCB.Name = "lblCB";
            this.lblCB.Size = new System.Drawing.Size(0, 17);
            this.lblCB.TabIndex = 18;
            // 
            // DNNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 361);
            this.ControlBox = false;
            this.Controls.Add(this.lblCB);
            this.Controls.Add(this.lblMA);
            this.Controls.Add(this.rdoQuanly);
            this.Controls.Add(this.rdoNhanvien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DNNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DNNV";
            this.Load += new System.EventHandler(this.DNNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoQuanly;
        private System.Windows.Forms.RadioButton rdoNhanvien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblMA;
        private System.Windows.Forms.Label lblCB;
    }
}