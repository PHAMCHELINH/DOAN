namespace DoAn
{
    partial class HDThanhToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMSTT = new System.Windows.Forms.TextBox();
            this.cmbThuePhong = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SOTHANHTOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOHDONGTHUEPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTHANHTOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.dttNgayTT = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(225, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỢP ĐỒNG THANH TOÁN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Thanh Toán :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số HD Thuê Phòng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(408, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "MSNV :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(409, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Thanh Toán :";
            // 
            // txtMSTT
            // 
            this.txtMSTT.Location = new System.Drawing.Point(204, 64);
            this.txtMSTT.Margin = new System.Windows.Forms.Padding(4);
            this.txtMSTT.Name = "txtMSTT";
            this.txtMSTT.Size = new System.Drawing.Size(160, 22);
            this.txtMSTT.TabIndex = 6;
            this.txtMSTT.TextChanged += new System.EventHandler(this.txtMSTT_TextChanged);
            // 
            // cmbThuePhong
            // 
            this.cmbThuePhong.FormattingEnabled = true;
            this.cmbThuePhong.Location = new System.Drawing.Point(204, 112);
            this.cmbThuePhong.Margin = new System.Windows.Forms.Padding(4);
            this.cmbThuePhong.Name = "cmbThuePhong";
            this.cmbThuePhong.Size = new System.Drawing.Size(160, 24);
            this.cmbThuePhong.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SOTHANHTOAN,
            this.SOHDONGTHUEPHONG,
            this.MSNV,
            this.NGAYTHANHTOAN,
            this.TIENPHONG});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 364);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(837, 136);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // SOTHANHTOAN
            // 
            this.SOTHANHTOAN.DataPropertyName = "SOTHANHTOAN";
            this.SOTHANHTOAN.HeaderText = "Số Thanh Toán";
            this.SOTHANHTOAN.Name = "SOTHANHTOAN";
            // 
            // SOHDONGTHUEPHONG
            // 
            this.SOHDONGTHUEPHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SOHDONGTHUEPHONG.DataPropertyName = "SOHDONGTHUEPHONG";
            this.SOHDONGTHUEPHONG.HeaderText = "Số hợp đồng";
            this.SOHDONGTHUEPHONG.Name = "SOHDONGTHUEPHONG";
            // 
            // MSNV
            // 
            this.MSNV.DataPropertyName = "MSNV";
            this.MSNV.HeaderText = "Mã NV";
            this.MSNV.Name = "MSNV";
            // 
            // NGAYTHANHTOAN
            // 
            this.NGAYTHANHTOAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYTHANHTOAN.DataPropertyName = "NGAYTHANHTOAN";
            this.NGAYTHANHTOAN.HeaderText = "Ngày TT";
            this.NGAYTHANHTOAN.Name = "NGAYTHANHTOAN";
            // 
            // TIENPHONG
            // 
            this.TIENPHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TIENPHONG.DataPropertyName = "TIENPHONG";
            this.TIENPHONG.HeaderText = "Tiền Phòng";
            this.TIENPHONG.Name = "TIENPHONG";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(45, 183);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoa.Location = new System.Drawing.Point(195, 183);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSua.Location = new System.Drawing.Point(45, 259);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 36);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Purple;
            this.btnThoat.Location = new System.Drawing.Point(714, 288);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 39);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(12, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 23);
            this.label9.TabIndex = 40;
            this.label9.Text = "Danh sách hợp đồng thanh toán :";
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(586, 62);
            this.txtMSNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(174, 22);
            this.txtMSNV.TabIndex = 41;
            // 
            // dttNgayTT
            // 
            this.dttNgayTT.CustomFormat = "yyyy-MM-dd";
            this.dttNgayTT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttNgayTT.Location = new System.Drawing.Point(586, 114);
            this.dttNgayTT.Name = "dttNgayTT";
            this.dttNgayTT.Size = new System.Drawing.Size(174, 22);
            this.dttNgayTT.TabIndex = 42;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLoad.Location = new System.Drawing.Point(195, 259);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 36);
            this.btnLoad.TabIndex = 43;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(41, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 19);
            this.label6.TabIndex = 44;
            this.label6.Text = "Chỉ cho phép sửa ngày thanh toán";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "Mã số HD";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(137, 42);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(160, 30);
            this.txtTim.TabIndex = 46;
            this.txtTim.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(315, 39);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(81, 28);
            this.btnTim.TabIndex = 47;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(346, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 108);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // HDThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 500);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dttNgayTT);
            this.Controls.Add(this.txtMSNV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbThuePhong);
            this.Controls.Add(this.txtMSTT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HDThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HDThanhToan";
            this.Load += new System.EventHandler(this.HDThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMSTT;
        private System.Windows.Forms.ComboBox cmbThuePhong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.DateTimePicker dttNgayTT;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTHANHTOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOHDONGTHUEPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTHANHTOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENPHONG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}