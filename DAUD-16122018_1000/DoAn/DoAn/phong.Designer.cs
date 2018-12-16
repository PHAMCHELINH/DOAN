namespace DoAn
{
    partial class phong
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.dtgPhong = new System.Windows.Forms.DataGridView();
            this.MSPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TINHTRANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTT = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Phòng";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(435, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(674, 69);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(555, 69);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(674, 132);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(93, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã Phòng:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMP
            // 
            this.txtMP.Location = new System.Drawing.Point(203, 69);
            this.txtMP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(192, 22);
            this.txtMP.TabIndex = 6;
            this.txtMP.Leave += new System.EventHandler(this.txtMP_Leave);
            // 
            // dtgPhong
            // 
            this.dtgPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSPHONG,
            this.TINHTRANG,
            this.GIATIEN});
            this.dtgPhong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgPhong.Location = new System.Drawing.Point(0, 338);
            this.dtgPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dtgPhong.Name = "dtgPhong";
            this.dtgPhong.Size = new System.Drawing.Size(833, 120);
            this.dtgPhong.TabIndex = 7;
            this.dtgPhong.SelectionChanged += new System.EventHandler(this.dtgPhong_SelectionChanged);
            // 
            // MSPHONG
            // 
            this.MSPHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MSPHONG.DataPropertyName = "MSPHONG";
            this.MSPHONG.HeaderText = "Mã phòng";
            this.MSPHONG.Name = "MSPHONG";
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TINHTRANG.DataPropertyName = "TINHTRANG";
            this.TINHTRANG.HeaderText = "Tình trạng";
            this.TINHTRANG.Name = "TINHTRANG";
            // 
            // GIATIEN
            // 
            this.GIATIEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIATIEN.DataPropertyName = "GIATIEN";
            this.GIATIEN.HeaderText = "Giá tiền";
            this.GIATIEN.Name = "GIATIEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(93, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giá Tiền:";
            // 
            // txtGT
            // 
            this.txtGT.Location = new System.Drawing.Point(203, 113);
            this.txtGT.Margin = new System.Windows.Forms.Padding(4);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(192, 22);
            this.txtGT.TabIndex = 9;
            this.txtGT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGT_KeyPress);
            this.txtGT.Leave += new System.EventHandler(this.txtGT_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(89, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tình Trạng:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtTT
            // 
            this.txtTT.FormattingEnabled = true;
            this.txtTT.Items.AddRange(new object[] {
            "Trong",
            "DaThue"});
            this.txtTT.Location = new System.Drawing.Point(203, 156);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(192, 24);
            this.txtTT.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(12, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 23);
            this.label9.TabIndex = 40;
            this.label9.Text = "Danh sách phòng :";
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLoad.Location = new System.Drawing.Point(435, 132);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 37);
            this.btnLoad.TabIndex = 41;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(394, 46);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(81, 37);
            this.btnTim.TabIndex = 50;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(217, 53);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(160, 30);
            this.txtTim.TabIndex = 49;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 25);
            this.label7.TabIndex = 48;
            this.label7.Text = "Mã số Phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(280, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 94);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 458);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgPhong);
            this.Controls.Add(this.txtMP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "phong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "phong";
            this.Load += new System.EventHandler(this.phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.DataGridView dtgPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TINHTRANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATIEN;
        private System.Windows.Forms.ComboBox txtTT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}