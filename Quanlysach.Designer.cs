namespace QuanLyNhaSach
{
    partial class Quanlysach
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
            this.tbtacgia = new System.Windows.Forms.TabControl();
            this.tpSach = new System.Windows.Forms.TabPage();
            this.numGianhap = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.cbTheloai = new System.Windows.Forms.ComboBox();
            this.cbNhaXB = new System.Windows.Forms.ComboBox();
            this.cbTacgia = new System.Windows.Forms.ComboBox();
            this.TimeNamXB = new System.Windows.Forms.DateTimePicker();
            this.txtSachID = new System.Windows.Forms.TextBox();
            this.txtSachName = new System.Windows.Forms.TextBox();
            this.btnDeleteSach = new System.Windows.Forms.Button();
            this.btnSearchSach = new System.Windows.Forms.Button();
            this.btnUpdateSach = new System.Windows.Forms.Button();
            this.btnAddSach = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.tpTacgia = new System.Windows.Forms.TabPage();
            this.Timenamsinh = new System.Windows.Forms.DateTimePicker();
            this.txtQuequan = new System.Windows.Forms.TextBox();
            this.txtTGName = new System.Windows.Forms.TextBox();
            this.txtTGID = new System.Windows.Forms.TextBox();
            this.btnSearchTG = new System.Windows.Forms.Button();
            this.btnUpdateTG = new System.Windows.Forms.Button();
            this.btnDeleteTG = new System.Windows.Forms.Button();
            this.btnAddTG = new System.Windows.Forms.Button();
            this.dgvTacgia = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTheloai = new System.Windows.Forms.TabPage();
            this.txtTheloai = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDeleteTL = new System.Windows.Forms.Button();
            this.btnAddTL = new System.Windows.Forms.Button();
            this.dgvTheloai = new System.Windows.Forms.DataGridView();
            this.tbNhaXB = new System.Windows.Forms.TabPage();
            this.btnDeleteNXB = new System.Windows.Forms.Button();
            this.btnAddNXB = new System.Windows.Forms.Button();
            this.txtNhaxb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            this.tbtacgia.SuspendLayout();
            this.tpSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGianhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.tpTacgia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacgia)).BeginInit();
            this.tbTheloai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheloai)).BeginInit();
            this.tbNhaXB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1283, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbtacgia
            // 
            this.tbtacgia.Controls.Add(this.tpSach);
            this.tbtacgia.Controls.Add(this.tpTacgia);
            this.tbtacgia.Controls.Add(this.tbTheloai);
            this.tbtacgia.Controls.Add(this.tbNhaXB);
            this.tbtacgia.Location = new System.Drawing.Point(6, 42);
            this.tbtacgia.Margin = new System.Windows.Forms.Padding(2);
            this.tbtacgia.Name = "tbtacgia";
            this.tbtacgia.SelectedIndex = 0;
            this.tbtacgia.Size = new System.Drawing.Size(1277, 717);
            this.tbtacgia.TabIndex = 1;
            // 
            // tpSach
            // 
            this.tpSach.Controls.Add(this.numGianhap);
            this.tpSach.Controls.Add(this.label15);
            this.tpSach.Controls.Add(this.numGia);
            this.tpSach.Controls.Add(this.cbTheloai);
            this.tpSach.Controls.Add(this.cbNhaXB);
            this.tpSach.Controls.Add(this.cbTacgia);
            this.tpSach.Controls.Add(this.TimeNamXB);
            this.tpSach.Controls.Add(this.txtSachID);
            this.tpSach.Controls.Add(this.txtSachName);
            this.tpSach.Controls.Add(this.btnDeleteSach);
            this.tpSach.Controls.Add(this.btnSearchSach);
            this.tpSach.Controls.Add(this.btnUpdateSach);
            this.tpSach.Controls.Add(this.btnAddSach);
            this.tpSach.Controls.Add(this.label6);
            this.tpSach.Controls.Add(this.label4);
            this.tpSach.Controls.Add(this.label14);
            this.tpSach.Controls.Add(this.label7);
            this.tpSach.Controls.Add(this.label5);
            this.tpSach.Controls.Add(this.label3);
            this.tpSach.Controls.Add(this.label2);
            this.tpSach.Controls.Add(this.dgvSach);
            this.tpSach.Location = new System.Drawing.Point(8, 43);
            this.tpSach.Margin = new System.Windows.Forms.Padding(2);
            this.tpSach.Name = "tpSach";
            this.tpSach.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpSach.Size = new System.Drawing.Size(1261, 666);
            this.tpSach.TabIndex = 0;
            this.tpSach.Text = "Sách";
            this.tpSach.UseVisualStyleBackColor = true;
            // 
            // numGianhap
            // 
            this.numGianhap.Location = new System.Drawing.Point(639, 145);
            this.numGianhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numGianhap.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numGianhap.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numGianhap.Name = "numGianhap";
            this.numGianhap.Size = new System.Drawing.Size(140, 35);
            this.numGianhap.TabIndex = 8;
            this.numGianhap.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(525, 147);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 29);
            this.label15.TabIndex = 7;
            this.label15.Text = "Giá nhập";
            // 
            // numGia
            // 
            this.numGia.Location = new System.Drawing.Point(639, 89);
            this.numGia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numGia.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numGia.Name = "numGia";
            this.numGia.Size = new System.Drawing.Size(140, 35);
            this.numGia.TabIndex = 6;
            this.numGia.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // cbTheloai
            // 
            this.cbTheloai.FormattingEnabled = true;
            this.cbTheloai.Location = new System.Drawing.Point(122, 220);
            this.cbTheloai.Margin = new System.Windows.Forms.Padding(2);
            this.cbTheloai.Name = "cbTheloai";
            this.cbTheloai.Size = new System.Drawing.Size(275, 37);
            this.cbTheloai.TabIndex = 5;
            this.cbTheloai.SelectedIndexChanged += new System.EventHandler(this.cbTheloai_SelectedIndexChanged);
            // 
            // cbNhaXB
            // 
            this.cbNhaXB.FormattingEnabled = true;
            this.cbNhaXB.Location = new System.Drawing.Point(639, 20);
            this.cbNhaXB.Margin = new System.Windows.Forms.Padding(2);
            this.cbNhaXB.Name = "cbNhaXB";
            this.cbNhaXB.Size = new System.Drawing.Size(215, 37);
            this.cbNhaXB.TabIndex = 5;
            this.cbNhaXB.SelectedIndexChanged += new System.EventHandler(this.cbNhaXB_SelectedIndexChanged);
            // 
            // cbTacgia
            // 
            this.cbTacgia.FormattingEnabled = true;
            this.cbTacgia.Location = new System.Drawing.Point(170, 152);
            this.cbTacgia.Margin = new System.Windows.Forms.Padding(2);
            this.cbTacgia.Name = "cbTacgia";
            this.cbTacgia.Size = new System.Drawing.Size(227, 37);
            this.cbTacgia.TabIndex = 5;
            this.cbTacgia.SelectedIndexChanged += new System.EventHandler(this.cbTacgia_SelectedIndexChanged);
            // 
            // TimeNamXB
            // 
            this.TimeNamXB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimeNamXB.Location = new System.Drawing.Point(639, 209);
            this.TimeNamXB.Margin = new System.Windows.Forms.Padding(2);
            this.TimeNamXB.Name = "TimeNamXB";
            this.TimeNamXB.Size = new System.Drawing.Size(190, 35);
            this.TimeNamXB.TabIndex = 4;
            this.TimeNamXB.Value = new System.DateTime(2024, 5, 7, 20, 34, 12, 0);
            // 
            // txtSachID
            // 
            this.txtSachID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSachID.Location = new System.Drawing.Point(122, 15);
            this.txtSachID.Margin = new System.Windows.Forms.Padding(2);
            this.txtSachID.Multiline = true;
            this.txtSachID.Name = "txtSachID";
            this.txtSachID.Size = new System.Drawing.Size(275, 49);
            this.txtSachID.TabIndex = 3;
            this.txtSachID.TextChanged += new System.EventHandler(this.txtSachID_TextChanged);
            // 
            // txtSachName
            // 
            this.txtSachName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSachName.Location = new System.Drawing.Point(122, 82);
            this.txtSachName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSachName.Multiline = true;
            this.txtSachName.Name = "txtSachName";
            this.txtSachName.Size = new System.Drawing.Size(275, 49);
            this.txtSachName.TabIndex = 3;
            // 
            // btnDeleteSach
            // 
            this.btnDeleteSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDeleteSach.Location = new System.Drawing.Point(1127, 159);
            this.btnDeleteSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteSach.Name = "btnDeleteSach";
            this.btnDeleteSach.Size = new System.Drawing.Size(119, 49);
            this.btnDeleteSach.TabIndex = 2;
            this.btnDeleteSach.Text = "Xóa";
            this.btnDeleteSach.UseVisualStyleBackColor = false;
            this.btnDeleteSach.Click += new System.EventHandler(this.btnDeleteSach_Click);
            // 
            // btnSearchSach
            // 
            this.btnSearchSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearchSach.Location = new System.Drawing.Point(955, 49);
            this.btnSearchSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchSach.Name = "btnSearchSach";
            this.btnSearchSach.Size = new System.Drawing.Size(139, 49);
            this.btnSearchSach.TabIndex = 2;
            this.btnSearchSach.Text = "Tìm kiếm";
            this.btnSearchSach.UseVisualStyleBackColor = false;
            this.btnSearchSach.Click += new System.EventHandler(this.btnSearchSach_Click);
            // 
            // btnUpdateSach
            // 
            this.btnUpdateSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnUpdateSach.Location = new System.Drawing.Point(955, 159);
            this.btnUpdateSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateSach.Name = "btnUpdateSach";
            this.btnUpdateSach.Size = new System.Drawing.Size(119, 49);
            this.btnUpdateSach.TabIndex = 2;
            this.btnUpdateSach.Text = "Sửa";
            this.btnUpdateSach.UseVisualStyleBackColor = false;
            this.btnUpdateSach.Click += new System.EventHandler(this.btnUpdateSach_Click);
            // 
            // btnAddSach
            // 
            this.btnAddSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddSach.Location = new System.Drawing.Point(1127, 49);
            this.btnAddSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSach.Name = "btnAddSach";
            this.btnAddSach.Size = new System.Drawing.Size(119, 49);
            this.btnAddSach.TabIndex = 2;
            this.btnAddSach.Text = "Thêm";
            this.btnAddSach.UseVisualStyleBackColor = false;
            this.btnAddSach.Click += new System.EventHandler(this.btnAddSach_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tác giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thể loại";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(531, 95);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 29);
            this.label14.TabIndex = 1;
            this.label14.Text = "Giá bán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 213);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Năm xuất bản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhà xuất bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sách";
            // 
            // dgvSach
            // 
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(2, 281);
            this.dgvSach.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 82;
            this.dgvSach.RowTemplate.Height = 33;
            this.dgvSach.Size = new System.Drawing.Size(1253, 368);
            this.dgvSach.TabIndex = 0;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
            // 
            // tpTacgia
            // 
            this.tpTacgia.Controls.Add(this.Timenamsinh);
            this.tpTacgia.Controls.Add(this.txtQuequan);
            this.tpTacgia.Controls.Add(this.txtTGName);
            this.tpTacgia.Controls.Add(this.txtTGID);
            this.tpTacgia.Controls.Add(this.btnSearchTG);
            this.tpTacgia.Controls.Add(this.btnUpdateTG);
            this.tpTacgia.Controls.Add(this.btnDeleteTG);
            this.tpTacgia.Controls.Add(this.btnAddTG);
            this.tpTacgia.Controls.Add(this.dgvTacgia);
            this.tpTacgia.Controls.Add(this.label11);
            this.tpTacgia.Controls.Add(this.label10);
            this.tpTacgia.Controls.Add(this.label9);
            this.tpTacgia.Controls.Add(this.label8);
            this.tpTacgia.Location = new System.Drawing.Point(8, 43);
            this.tpTacgia.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tpTacgia.Name = "tpTacgia";
            this.tpTacgia.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tpTacgia.Size = new System.Drawing.Size(1261, 666);
            this.tpTacgia.TabIndex = 1;
            this.tpTacgia.Text = "Tác Giả";
            this.tpTacgia.UseVisualStyleBackColor = true;
            // 
            // Timenamsinh
            // 
            this.Timenamsinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Timenamsinh.Location = new System.Drawing.Point(167, 364);
            this.Timenamsinh.Margin = new System.Windows.Forms.Padding(2);
            this.Timenamsinh.Name = "Timenamsinh";
            this.Timenamsinh.Size = new System.Drawing.Size(190, 35);
            this.Timenamsinh.TabIndex = 5;
            this.Timenamsinh.Value = new System.DateTime(2024, 5, 7, 20, 34, 12, 0);
            // 
            // txtQuequan
            // 
            this.txtQuequan.Location = new System.Drawing.Point(167, 246);
            this.txtQuequan.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuequan.Multiline = true;
            this.txtQuequan.Name = "txtQuequan";
            this.txtQuequan.Size = new System.Drawing.Size(255, 48);
            this.txtQuequan.TabIndex = 3;
            // 
            // txtTGName
            // 
            this.txtTGName.Location = new System.Drawing.Point(167, 144);
            this.txtTGName.Margin = new System.Windows.Forms.Padding(2);
            this.txtTGName.Multiline = true;
            this.txtTGName.Name = "txtTGName";
            this.txtTGName.Size = new System.Drawing.Size(255, 48);
            this.txtTGName.TabIndex = 3;
            // 
            // txtTGID
            // 
            this.txtTGID.Location = new System.Drawing.Point(167, 57);
            this.txtTGID.Margin = new System.Windows.Forms.Padding(2);
            this.txtTGID.Multiline = true;
            this.txtTGID.Name = "txtTGID";
            this.txtTGID.Size = new System.Drawing.Size(255, 48);
            this.txtTGID.TabIndex = 3;
            this.txtTGID.TextChanged += new System.EventHandler(this.txtTGID_TextChanged);
            // 
            // btnSearchTG
            // 
            this.btnSearchTG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearchTG.Location = new System.Drawing.Point(191, 470);
            this.btnSearchTG.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchTG.Name = "btnSearchTG";
            this.btnSearchTG.Size = new System.Drawing.Size(141, 52);
            this.btnSearchTG.TabIndex = 2;
            this.btnSearchTG.Text = "Tìm kiếm";
            this.btnSearchTG.UseVisualStyleBackColor = false;
            this.btnSearchTG.Click += new System.EventHandler(this.btnSearchTG_Click);
            // 
            // btnUpdateTG
            // 
            this.btnUpdateTG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnUpdateTG.Location = new System.Drawing.Point(22, 567);
            this.btnUpdateTG.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateTG.Name = "btnUpdateTG";
            this.btnUpdateTG.Size = new System.Drawing.Size(113, 52);
            this.btnUpdateTG.TabIndex = 2;
            this.btnUpdateTG.Text = "Sửa";
            this.btnUpdateTG.UseVisualStyleBackColor = false;
            this.btnUpdateTG.Click += new System.EventHandler(this.btnUpdateTG_Click);
            // 
            // btnDeleteTG
            // 
            this.btnDeleteTG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDeleteTG.Location = new System.Drawing.Point(191, 567);
            this.btnDeleteTG.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteTG.Name = "btnDeleteTG";
            this.btnDeleteTG.Size = new System.Drawing.Size(141, 52);
            this.btnDeleteTG.TabIndex = 2;
            this.btnDeleteTG.Text = "Xóa";
            this.btnDeleteTG.UseVisualStyleBackColor = false;
            this.btnDeleteTG.Click += new System.EventHandler(this.btnDeleteTG_Click);
            // 
            // btnAddTG
            // 
            this.btnAddTG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddTG.Location = new System.Drawing.Point(22, 470);
            this.btnAddTG.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTG.Name = "btnAddTG";
            this.btnAddTG.Size = new System.Drawing.Size(113, 52);
            this.btnAddTG.TabIndex = 2;
            this.btnAddTG.Text = "Thêm";
            this.btnAddTG.UseVisualStyleBackColor = false;
            this.btnAddTG.Click += new System.EventHandler(this.btnAddTG_Click);
            // 
            // dgvTacgia
            // 
            this.dgvTacgia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTacgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTacgia.Location = new System.Drawing.Point(438, 20);
            this.dgvTacgia.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTacgia.Name = "dgvTacgia";
            this.dgvTacgia.RowHeadersWidth = 82;
            this.dgvTacgia.RowTemplate.Height = 33;
            this.dgvTacgia.Size = new System.Drawing.Size(814, 626);
            this.dgvTacgia.TabIndex = 1;
            this.dgvTacgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTacgia_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 371);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 29);
            this.label11.TabIndex = 0;
            this.label11.Text = "Năm sinh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 264);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Quê quán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên tác giả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã tác giả";
            // 
            // tbTheloai
            // 
            this.tbTheloai.Controls.Add(this.txtTheloai);
            this.tbTheloai.Controls.Add(this.label12);
            this.tbTheloai.Controls.Add(this.btnDeleteTL);
            this.tbTheloai.Controls.Add(this.btnAddTL);
            this.tbTheloai.Controls.Add(this.dgvTheloai);
            this.tbTheloai.Location = new System.Drawing.Point(8, 43);
            this.tbTheloai.Margin = new System.Windows.Forms.Padding(2);
            this.tbTheloai.Name = "tbTheloai";
            this.tbTheloai.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tbTheloai.Size = new System.Drawing.Size(1261, 666);
            this.tbTheloai.TabIndex = 2;
            this.tbTheloai.Text = "Thể Loại";
            this.tbTheloai.UseVisualStyleBackColor = true;
            // 
            // txtTheloai
            // 
            this.txtTheloai.Location = new System.Drawing.Point(133, 535);
            this.txtTheloai.Margin = new System.Windows.Forms.Padding(2);
            this.txtTheloai.Multiline = true;
            this.txtTheloai.Name = "txtTheloai";
            this.txtTheloai.Size = new System.Drawing.Size(414, 59);
            this.txtTheloai.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 553);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 29);
            this.label12.TabIndex = 2;
            this.label12.Text = "Thể loại";
            // 
            // btnDeleteTL
            // 
            this.btnDeleteTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDeleteTL.Location = new System.Drawing.Point(908, 542);
            this.btnDeleteTL.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteTL.Name = "btnDeleteTL";
            this.btnDeleteTL.Size = new System.Drawing.Size(139, 52);
            this.btnDeleteTL.TabIndex = 1;
            this.btnDeleteTL.Text = "Xóa";
            this.btnDeleteTL.UseVisualStyleBackColor = false;
            this.btnDeleteTL.Click += new System.EventHandler(this.btnDeleteTL_Click);
            // 
            // btnAddTL
            // 
            this.btnAddTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddTL.Location = new System.Drawing.Point(658, 542);
            this.btnAddTL.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTL.Name = "btnAddTL";
            this.btnAddTL.Size = new System.Drawing.Size(148, 52);
            this.btnAddTL.TabIndex = 1;
            this.btnAddTL.Text = "Thêm";
            this.btnAddTL.UseVisualStyleBackColor = false;
            this.btnAddTL.Click += new System.EventHandler(this.btnAddTL_Click);
            // 
            // dgvTheloai
            // 
            this.dgvTheloai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTheloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheloai.Location = new System.Drawing.Point(16, 19);
            this.dgvTheloai.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTheloai.Name = "dgvTheloai";
            this.dgvTheloai.RowHeadersWidth = 82;
            this.dgvTheloai.RowTemplate.Height = 33;
            this.dgvTheloai.Size = new System.Drawing.Size(1236, 451);
            this.dgvTheloai.TabIndex = 0;
            this.dgvTheloai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheloai_CellClick);
            // 
            // tbNhaXB
            // 
            this.tbNhaXB.Controls.Add(this.btnDeleteNXB);
            this.tbNhaXB.Controls.Add(this.btnAddNXB);
            this.tbNhaXB.Controls.Add(this.txtNhaxb);
            this.tbNhaXB.Controls.Add(this.label13);
            this.tbNhaXB.Controls.Add(this.dgvNXB);
            this.tbNhaXB.Location = new System.Drawing.Point(8, 43);
            this.tbNhaXB.Margin = new System.Windows.Forms.Padding(2);
            this.tbNhaXB.Name = "tbNhaXB";
            this.tbNhaXB.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tbNhaXB.Size = new System.Drawing.Size(1261, 666);
            this.tbNhaXB.TabIndex = 3;
            this.tbNhaXB.Text = "Nhà xuất bản";
            this.tbNhaXB.UseVisualStyleBackColor = true;
            // 
            // btnDeleteNXB
            // 
            this.btnDeleteNXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDeleteNXB.Location = new System.Drawing.Point(880, 535);
            this.btnDeleteNXB.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteNXB.Name = "btnDeleteNXB";
            this.btnDeleteNXB.Size = new System.Drawing.Size(156, 55);
            this.btnDeleteNXB.TabIndex = 3;
            this.btnDeleteNXB.Text = "Xóa";
            this.btnDeleteNXB.UseVisualStyleBackColor = false;
            this.btnDeleteNXB.Click += new System.EventHandler(this.btnDeleteNXB_Click);
            // 
            // btnAddNXB
            // 
            this.btnAddNXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddNXB.Location = new System.Drawing.Point(648, 535);
            this.btnAddNXB.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNXB.Name = "btnAddNXB";
            this.btnAddNXB.Size = new System.Drawing.Size(152, 55);
            this.btnAddNXB.TabIndex = 3;
            this.btnAddNXB.Text = "Thêm";
            this.btnAddNXB.UseVisualStyleBackColor = false;
            this.btnAddNXB.Click += new System.EventHandler(this.btnAddNXB_Click);
            // 
            // txtNhaxb
            // 
            this.txtNhaxb.Location = new System.Drawing.Point(198, 532);
            this.txtNhaxb.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhaxb.Multiline = true;
            this.txtNhaxb.Name = "txtNhaxb";
            this.txtNhaxb.Size = new System.Drawing.Size(325, 56);
            this.txtNhaxb.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 543);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 29);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nhà xuất bản";
            // 
            // dgvNXB
            // 
            this.dgvNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXB.Location = new System.Drawing.Point(9, 19);
            this.dgvNXB.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.RowHeadersWidth = 82;
            this.dgvNXB.RowTemplate.Height = 33;
            this.dgvNXB.Size = new System.Drawing.Size(1243, 452);
            this.dgvNXB.TabIndex = 0;
            this.dgvNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNXB_CellClick);
            // 
            // Quanlysach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 770);
            this.Controls.Add(this.tbtacgia);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Quanlysach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.tbtacgia.ResumeLayout(false);
            this.tpSach.ResumeLayout(false);
            this.tpSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGianhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.tpTacgia.ResumeLayout(false);
            this.tpTacgia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacgia)).EndInit();
            this.tbTheloai.ResumeLayout(false);
            this.tbTheloai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheloai)).EndInit();
            this.tbNhaXB.ResumeLayout(false);
            this.tbNhaXB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbtacgia;
        private System.Windows.Forms.TabPage tpSach;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.TabPage tpTacgia;
        private System.Windows.Forms.TabPage tbTheloai;
        private System.Windows.Forms.TabPage tbNhaXB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteSach;
        private System.Windows.Forms.Button btnSearchSach;
        private System.Windows.Forms.Button btnUpdateSach;
        private System.Windows.Forms.Button btnAddSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTheloai;
        private System.Windows.Forms.ComboBox cbNhaXB;
        private System.Windows.Forms.ComboBox cbTacgia;
        private System.Windows.Forms.DateTimePicker TimeNamXB;
        private System.Windows.Forms.TextBox txtSachID;
        private System.Windows.Forms.TextBox txtSachName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvTacgia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddTG;
        private System.Windows.Forms.Button btnSearchTG;
        private System.Windows.Forms.TextBox txtQuequan;
        private System.Windows.Forms.TextBox txtTGName;
        private System.Windows.Forms.TextBox txtTGID;
        private System.Windows.Forms.Button btnUpdateTG;
        private System.Windows.Forms.Button btnDeleteTG;
        private System.Windows.Forms.TextBox txtTheloai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDeleteTL;
        private System.Windows.Forms.Button btnAddTL;
        private System.Windows.Forms.DataGridView dgvTheloai;
        private System.Windows.Forms.Button btnDeleteNXB;
        private System.Windows.Forms.Button btnAddNXB;
        private System.Windows.Forms.TextBox txtNhaxb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvNXB;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker Timenamsinh;
        private System.Windows.Forms.NumericUpDown numGianhap;
        private System.Windows.Forms.Label label15;
    }
}