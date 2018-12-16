namespace DoAn
{
    partial class khachhang
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
            this.txtqt = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgKhachHang = new System.Windows.Forms.DataGridView();
            this.MSKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINHKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHIKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAIKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUOCTICH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtgt = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txttkh = new System.Windows.Forms.TextBox();
            this.txtmkh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtqt
            // 
            this.txtqt.Location = new System.Drawing.Point(185, 198);
            this.txtqt.Margin = new System.Windows.Forms.Padding(4);
            this.txtqt.Name = "txtqt";
            this.txtqt.Size = new System.Drawing.Size(132, 22);
            this.txtqt.TabIndex = 32;
            this.txtqt.Leave += new System.EventHandler(this.txtqt_Leave);
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(433, 157);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(138, 22);
            this.txtsdt.TabIndex = 31;
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            this.txtsdt.Leave += new System.EventHandler(this.txtsdt_Leave);
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(185, 159);
            this.txtcmnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(132, 22);
            this.txtcmnd.TabIndex = 30;
            this.txtcmnd.Leave += new System.EventHandler(this.txtcmnd_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(75, 199);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Quốc Tịch:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(362, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "SĐT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(100, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "CMND:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(248, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(512, 30);
            this.label5.TabIndex = 26;
            this.label5.Text = "KHÁCH HÀNG";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtgKhachHang
            // 
            this.dtgKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSKH,
            this.HOTENKH,
            this.GIOITINHKH,
            this.DIACHIKH,
            this.CMND,
            this.DIENTHOAIKH,
            this.QUOCTICH});
            this.dtgKhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgKhachHang.Location = new System.Drawing.Point(0, 362);
            this.dtgKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dtgKhachHang.Name = "dtgKhachHang";
            this.dtgKhachHang.Size = new System.Drawing.Size(1041, 179);
            this.dtgKhachHang.TabIndex = 25;
            this.dtgKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKhachHang_CellContentClick);
            this.dtgKhachHang.SelectionChanged += new System.EventHandler(this.dtgKhachHang_SelectionChanged);
            // 
            // MSKH
            // 
            this.MSKH.DataPropertyName = "MSKH";
            this.MSKH.HeaderText = "MSKH";
            this.MSKH.Name = "MSKH";
            // 
            // HOTENKH
            // 
            this.HOTENKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HOTENKH.DataPropertyName = "HOTENKH";
            this.HOTENKH.HeaderText = "HOTENKH";
            this.HOTENKH.Name = "HOTENKH";
            // 
            // GIOITINHKH
            // 
            this.GIOITINHKH.DataPropertyName = "GIOITINHKH";
            this.GIOITINHKH.HeaderText = "GIOITINHKH";
            this.GIOITINHKH.Name = "GIOITINHKH";
            // 
            // DIACHIKH
            // 
            this.DIACHIKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DIACHIKH.DataPropertyName = "DIACHIKH";
            this.DIACHIKH.HeaderText = "DIACHIKH";
            this.DIACHIKH.Name = "DIACHIKH";
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            // 
            // DIENTHOAIKH
            // 
            this.DIENTHOAIKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DIENTHOAIKH.DataPropertyName = "DIENTHOAIKH";
            this.DIENTHOAIKH.HeaderText = "DIENTHOAIKH";
            this.DIENTHOAIKH.Name = "DIENTHOAIKH";
            // 
            // QUOCTICH
            // 
            this.QUOCTICH.DataPropertyName = "QUOCTICH";
            this.QUOCTICH.HeaderText = "QUOCTICH";
            this.QUOCTICH.Name = "QUOCTICH";
            // 
            // txtgt
            // 
            this.txtgt.Location = new System.Drawing.Point(433, 116);
            this.txtgt.Margin = new System.Windows.Forms.Padding(4);
            this.txtgt.Name = "txtgt";
            this.txtgt.Size = new System.Drawing.Size(139, 22);
            this.txtgt.TabIndex = 24;
            this.txtgt.Leave += new System.EventHandler(this.txtgt_Leave);
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(433, 74);
            this.txtdc.Margin = new System.Windows.Forms.Padding(4);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(139, 22);
            this.txtdc.TabIndex = 23;
            this.txtdc.Leave += new System.EventHandler(this.txtdc_Leave);
            // 
            // txttkh
            // 
            this.txttkh.Location = new System.Drawing.Point(185, 116);
            this.txttkh.Margin = new System.Windows.Forms.Padding(4);
            this.txttkh.Name = "txttkh";
            this.txttkh.Size = new System.Drawing.Size(132, 22);
            this.txttkh.TabIndex = 22;
            this.txttkh.Leave += new System.EventHandler(this.txttkh_Leave);
            // 
            // txtmkh
            // 
            this.txtmkh.Location = new System.Drawing.Point(185, 75);
            this.txtmkh.Margin = new System.Windows.Forms.Padding(4);
            this.txtmkh.Name = "txtmkh";
            this.txtmkh.Size = new System.Drawing.Size(132, 22);
            this.txtmkh.TabIndex = 21;
            this.txtmkh.Leave += new System.EventHandler(this.txtmkh_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(325, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Giới Tính :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(331, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Địa Chỉ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(20, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên Khách Hàng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(19, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã Khách Hàng :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(304, 262);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 44);
            this.button1.TabIndex = 33;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(843, 262);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 44);
            this.button4.TabIndex = 36;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(563, 262);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 44);
            this.button3.TabIndex = 37;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(430, 262);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 44);
            this.button5.TabIndex = 38;
            this.button5.Text = "Xóa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(12, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(256, 26);
            this.label9.TabIndex = 39;
            this.label9.Text = "Danh sách khách hàng :";
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLoad.Location = new System.Drawing.Point(704, 262);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 44);
            this.btnLoad.TabIndex = 40;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(331, 50);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(89, 37);
            this.btnTim.TabIndex = 50;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(146, 57);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(160, 30);
            this.txtTim.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 25);
            this.label10.TabIndex = 48;
            this.label10.Text = "Mã số KH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(603, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 106);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 541);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtqt);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtcmnd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgKhachHang);
            this.Controls.Add(this.txtgt);
            this.Controls.Add(this.txtdc);
            this.Controls.Add(this.txttkh);
            this.Controls.Add(this.txtmkh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "khachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "khachhang";
            this.Load += new System.EventHandler(this.khachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtqt;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgKhachHang;
        private System.Windows.Forms.TextBox txtgt;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txttkh;
        private System.Windows.Forms.TextBox txtmkh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINHKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHIKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAIKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUOCTICH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}