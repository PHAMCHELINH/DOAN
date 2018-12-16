namespace DoAn
{
    partial class QuanliNV
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCl = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.daten = new System.Windows.Forms.DateTimePicker();
            this.dtpNS = new System.Windows.Forms.DateTimePicker();
            this.txtSODT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxGT = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdoQuanly = new System.Windows.Forms.RadioButton();
            this.rdoNhanvien = new System.Windows.Forms.RadioButton();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.txtQuequan = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvNHANVIEN = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MSNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAIKHOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYVAOLAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUCVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNHANVIEN)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(840, 125);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 38);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSua.Location = new System.Drawing.Point(840, 183);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 38);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExit.Location = new System.Drawing.Point(863, 398);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 38);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCl
            // 
            this.btnCl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCl.Location = new System.Drawing.Point(840, 253);
            this.btnCl.Margin = new System.Windows.Forms.Padding(4);
            this.btnCl.Name = "btnCl";
            this.btnCl.Size = new System.Drawing.Size(119, 39);
            this.btnCl.TabIndex = 7;
            this.btnCl.Text = "Clean";
            this.btnCl.UseVisualStyleBackColor = true;
            this.btnCl.Click += new System.EventHandler(this.btnCl_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.Location = new System.Drawing.Point(840, 64);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 39);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.daten);
            this.groupBox1.Controls.Add(this.dtpNS);
            this.groupBox1.Controls.Add(this.txtSODT);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbxGT);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMANV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rdoQuanly);
            this.groupBox1.Controls.Add(this.rdoNhanvien);
            this.groupBox1.Controls.Add(this.txtMatkhau);
            this.groupBox1.Controls.Add(this.txtTaikhoan);
            this.groupBox1.Controls.Add(this.txtQuequan);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(774, 309);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÊM NHÂN VIÊN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(12, 253);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 23);
            this.label11.TabIndex = 21;
            this.label11.Text = "Ngày Làm :";
            // 
            // daten
            // 
            this.daten.CustomFormat = "yyyy-MM-dd";
            this.daten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.daten.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.daten.Location = new System.Drawing.Point(128, 252);
            this.daten.Name = "daten";
            this.daten.Size = new System.Drawing.Size(209, 28);
            this.daten.TabIndex = 20;
            this.daten.ValueChanged += new System.EventHandler(this.daten_ValueChanged);
            // 
            // dtpNS
            // 
            this.dtpNS.CustomFormat = "yyyy-MM-dd";
            this.dtpNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNS.Location = new System.Drawing.Point(128, 146);
            this.dtpNS.Name = "dtpNS";
            this.dtpNS.Size = new System.Drawing.Size(209, 28);
            this.dtpNS.TabIndex = 19;
            // 
            // txtSODT
            // 
            this.txtSODT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSODT.Location = new System.Drawing.Point(128, 199);
            this.txtSODT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSODT.Name = "txtSODT";
            this.txtSODT.Size = new System.Drawing.Size(209, 30);
            this.txtSODT.TabIndex = 18;
            this.txtSODT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSODT_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(8, 199);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Số DT :";
            // 
            // cbxGT
            // 
            this.cbxGT.FormattingEnabled = true;
            this.cbxGT.Items.AddRange(new object[] {
            "Nam",
            "Nu",
            "Khac"});
            this.cbxGT.Location = new System.Drawing.Point(511, 199);
            this.cbxGT.Name = "cbxGT";
            this.cbxGT.Size = new System.Drawing.Size(209, 31);
            this.cbxGT.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(383, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Giới tính :";
            // 
            // txtMANV
            // 
            this.txtMANV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMANV.Location = new System.Drawing.Point(128, 45);
            this.txtMANV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(209, 30);
            this.txtMANV.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(8, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã NV :";
            // 
            // rdoQuanly
            // 
            this.rdoQuanly.AutoSize = true;
            this.rdoQuanly.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoQuanly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rdoQuanly.Location = new System.Drawing.Point(649, 258);
            this.rdoQuanly.Margin = new System.Windows.Forms.Padding(4);
            this.rdoQuanly.Name = "rdoQuanly";
            this.rdoQuanly.Size = new System.Drawing.Size(115, 30);
            this.rdoQuanly.TabIndex = 12;
            this.rdoQuanly.TabStop = true;
            this.rdoQuanly.Text = "Quản lý";
            this.rdoQuanly.UseVisualStyleBackColor = true;
            // 
            // rdoNhanvien
            // 
            this.rdoNhanvien.AutoSize = true;
            this.rdoNhanvien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoNhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdoNhanvien.Location = new System.Drawing.Point(510, 258);
            this.rdoNhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNhanvien.Name = "rdoNhanvien";
            this.rdoNhanvien.Size = new System.Drawing.Size(136, 30);
            this.rdoNhanvien.TabIndex = 11;
            this.rdoNhanvien.TabStop = true;
            this.rdoNhanvien.Text = "Nhân viên";
            this.rdoNhanvien.UseVisualStyleBackColor = true;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatkhau.Location = new System.Drawing.Point(511, 141);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(209, 30);
            this.txtMatkhau.TabIndex = 10;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTaikhoan.Location = new System.Drawing.Point(511, 87);
            this.txtTaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(209, 30);
            this.txtTaikhoan.TabIndex = 9;
            // 
            // txtQuequan
            // 
            this.txtQuequan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtQuequan.Location = new System.Drawing.Point(511, 36);
            this.txtQuequan.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuequan.Name = "txtQuequan";
            this.txtQuequan.Size = new System.Drawing.Size(209, 30);
            this.txtQuequan.TabIndex = 8;
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoten.Location = new System.Drawing.Point(128, 96);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(209, 30);
            this.txtHoten.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(380, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(383, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mật khẩu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(383, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tài khoản :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(383, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quên quán :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(8, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(8, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Họ tên :";
            // 
            // dgvNHANVIEN
            // 
            this.dgvNHANVIEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNHANVIEN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSNV,
            this.HOTENNV,
            this.TAIKHOAN,
            this.NGAYSINH,
            this.GIOITINH,
            this.DIACHI,
            this.DIENTHOAI,
            this.NGAYVAOLAM,
            this.CHUCVU});
            this.dgvNHANVIEN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNHANVIEN.Location = new System.Drawing.Point(0, 546);
            this.dgvNHANVIEN.Name = "dgvNHANVIEN";
            this.dgvNHANVIEN.RowTemplate.Height = 24;
            this.dgvNHANVIEN.Size = new System.Drawing.Size(995, 145);
            this.dgvNHANVIEN.TabIndex = 8;
            this.dgvNHANVIEN.SelectionChanged += new System.EventHandler(this.dgvNHANVIEN_SelectionChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(9, 480);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 23);
            this.label12.TabIndex = 40;
            this.label12.Text = "Danh sách nhân viên:";
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLoad.Location = new System.Drawing.Point(730, 397);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(119, 38);
            this.btnLoad.TabIndex = 41;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(331, 75);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(81, 28);
            this.btnTim.TabIndex = 50;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(151, 75);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(160, 30);
            this.txtTim.TabIndex = 49;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 25);
            this.label13.TabIndex = 48;
            this.label13.Text = "Mã số NV";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.txtTim);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(250, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 137);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // MSNV
            // 
            this.MSNV.DataPropertyName = "MSNV";
            this.MSNV.HeaderText = "Mã NV";
            this.MSNV.Name = "MSNV";
            // 
            // HOTENNV
            // 
            this.HOTENNV.DataPropertyName = "HOTENNV";
            this.HOTENNV.HeaderText = "Họ Tên";
            this.HOTENNV.Name = "HOTENNV";
            // 
            // TAIKHOAN
            // 
            this.TAIKHOAN.DataPropertyName = "TAIKHOAN";
            this.TAIKHOAN.HeaderText = "Tài Khoản";
            this.TAIKHOAN.Name = "TAIKHOAN";
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.Name = "GIOITINH";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Width = 152;
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.DataPropertyName = "DIENTHOAI";
            this.DIENTHOAI.HeaderText = "Điện thoại";
            this.DIENTHOAI.Name = "DIENTHOAI";
            // 
            // NGAYVAOLAM
            // 
            this.NGAYVAOLAM.DataPropertyName = "NGAYVAOLAM";
            this.NGAYVAOLAM.HeaderText = "Ngày làm";
            this.NGAYVAOLAM.Name = "NGAYVAOLAM";
            // 
            // CHUCVU
            // 
            this.CHUCVU.DataPropertyName = "CHUCVU";
            this.CHUCVU.HeaderText = "Chức vụ";
            this.CHUCVU.Name = "CHUCVU";
            // 
            // QuanliNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(995, 691);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvNHANVIEN);
            this.Controls.Add(this.btnCl);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuanliNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanliNV";
            this.Load += new System.EventHandler(this.QuanliNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNHANVIEN)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCl;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSODT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxGT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdoQuanly;
        private System.Windows.Forms.RadioButton rdoNhanvien;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.TextBox txtQuequan;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvNHANVIEN;
        private System.Windows.Forms.DateTimePicker dtpNS;
        private System.Windows.Forms.DateTimePicker daten;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAIKHOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYVAOLAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUCVU;
    }
}