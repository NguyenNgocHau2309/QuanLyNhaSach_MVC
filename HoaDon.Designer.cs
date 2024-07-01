namespace QuanLyNhaSach
{
    partial class HoaDon
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TimeLapHD_add = new System.Windows.Forms.DateTimePicker();
            this.cbKHID_add = new System.Windows.Forms.ComboBox();
            this.cbNVID_add = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHDID_add = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNVID_update = new System.Windows.Forms.ComboBox();
            this.cbMaHD = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeLapHD_update = new System.Windows.Forms.DateTimePicker();
            this.cbKHID_update = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.btnHoanthanhHD = new System.Windows.Forms.Button();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnChonSach = new System.Windows.Forms.Button();
            this.btnCTHD = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.dgvHoadon = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXuatHD = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TimeLapHD_add);
            this.groupBox2.Controls.Add(this.cbKHID_add);
            this.groupBox2.Controls.Add(this.cbNVID_add);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtHDID_add);
            this.groupBox2.Location = new System.Drawing.Point(9, 534);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 152);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm hóa đơn";
            // 
            // TimeLapHD_add
            // 
            this.TimeLapHD_add.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimeLapHD_add.Location = new System.Drawing.Point(369, 99);
            this.TimeLapHD_add.Name = "TimeLapHD_add";
            this.TimeLapHD_add.Size = new System.Drawing.Size(176, 35);
            this.TimeLapHD_add.TabIndex = 2;
            // 
            // cbKHID_add
            // 
            this.cbKHID_add.FormattingEnabled = true;
            this.cbKHID_add.Location = new System.Drawing.Point(355, 45);
            this.cbKHID_add.Name = "cbKHID_add";
            this.cbKHID_add.Size = new System.Drawing.Size(106, 37);
            this.cbKHID_add.TabIndex = 1;
            this.cbKHID_add.SelectedIndexChanged += new System.EventHandler(this.cbKHID_add_SelectedIndexChanged);
            // 
            // cbNVID_add
            // 
            this.cbNVID_add.FormattingEnabled = true;
            this.cbNVID_add.Location = new System.Drawing.Point(90, 99);
            this.cbNVID_add.Name = "cbNVID_add";
            this.cbNVID_add.Size = new System.Drawing.Size(106, 37);
            this.cbNVID_add.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã NV:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(270, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mã KH:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày lập:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã PN:";
            // 
            // txtHDID_add
            // 
            this.txtHDID_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHDID_add.Location = new System.Drawing.Point(90, 48);
            this.txtHDID_add.Multiline = true;
            this.txtHDID_add.Name = "txtHDID_add";
            this.txtHDID_add.Size = new System.Drawing.Size(106, 35);
            this.txtHDID_add.TabIndex = 12;
            this.txtHDID_add.TextChanged += new System.EventHandler(this.txtHDID_add_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(791, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "HÓA ĐƠN(Click vào hàng hóa đơn sẽ hiển thị CTHD đó trên bảng CTHD)";
            // 
            // cbNVID_update
            // 
            this.cbNVID_update.FormattingEnabled = true;
            this.cbNVID_update.Location = new System.Drawing.Point(90, 90);
            this.cbNVID_update.Name = "cbNVID_update";
            this.cbNVID_update.Size = new System.Drawing.Size(106, 37);
            this.cbNVID_update.TabIndex = 1;
            this.cbNVID_update.SelectedIndexChanged += new System.EventHandler(this.cbKHID_add_SelectedIndexChanged);
            // 
            // cbMaHD
            // 
            this.cbMaHD.FormattingEnabled = true;
            this.cbMaHD.Location = new System.Drawing.Point(9, 344);
            this.cbMaHD.Name = "cbMaHD";
            this.cbMaHD.Size = new System.Drawing.Size(117, 37);
            this.cbMaHD.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeLapHD_update);
            this.groupBox1.Controls.Add(this.cbNVID_update);
            this.groupBox1.Controls.Add(this.cbKHID_update);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(9, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 137);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sửa hóa đơn";
            // 
            // timeLapHD_update
            // 
            this.timeLapHD_update.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeLapHD_update.Location = new System.Drawing.Point(369, 56);
            this.timeLapHD_update.Name = "timeLapHD_update";
            this.timeLapHD_update.Size = new System.Drawing.Size(176, 35);
            this.timeLapHD_update.TabIndex = 2;
            // 
            // cbKHID_update
            // 
            this.cbKHID_update.FormattingEnabled = true;
            this.cbKHID_update.Location = new System.Drawing.Point(90, 38);
            this.cbKHID_update.Name = "cbKHID_update";
            this.cbKHID_update.Size = new System.Drawing.Size(106, 37);
            this.cbKHID_update.TabIndex = 1;
            this.cbKHID_update.SelectedIndexChanged += new System.EventHandler(this.cbKHID_update_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 29);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã NV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày lập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã KH:";
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(734, 706);
            this.numSL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(105, 35);
            this.numSL.TabIndex = 52;
            this.numSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnHoanthanhHD
            // 
            this.btnHoanthanhHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHoanthanhHD.Location = new System.Drawing.Point(358, 693);
            this.btnHoanthanhHD.Name = "btnHoanthanhHD";
            this.btnHoanthanhHD.Size = new System.Drawing.Size(246, 52);
            this.btnHoanthanhHD.TabIndex = 49;
            this.btnHoanthanhHD.Text = "Hoàn thành hóa đơn";
            this.btnHoanthanhHD.UseVisualStyleBackColor = false;
            this.btnHoanthanhHD.Click += new System.EventHandler(this.btnHoanthanhHD_Click);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTenKH.Location = new System.Drawing.Point(1046, 5);
            this.txtTenKH.Multiline = true;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(172, 29);
            this.txtTenKH.TabIndex = 43;
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.BackColor = System.Drawing.Color.Red;
            this.btnXoaSach.Location = new System.Drawing.Point(1099, 333);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(119, 52);
            this.btnXoaSach.TabIndex = 44;
            this.btnXoaSach.Text = "Xóa sách";
            this.btnXoaSach.UseVisualStyleBackColor = false;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // btnChonSach
            // 
            this.btnChonSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnChonSach.Location = new System.Drawing.Point(844, 693);
            this.btnChonSach.Name = "btnChonSach";
            this.btnChonSach.Size = new System.Drawing.Size(149, 52);
            this.btnChonSach.TabIndex = 46;
            this.btnChonSach.Text = "Chọn sách";
            this.btnChonSach.UseVisualStyleBackColor = false;
            this.btnChonSach.Click += new System.EventHandler(this.btnChonSach_Click);
            // 
            // btnCTHD
            // 
            this.btnCTHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCTHD.Location = new System.Drawing.Point(130, 335);
            this.btnCTHD.Name = "btnCTHD";
            this.btnCTHD.Size = new System.Drawing.Size(221, 52);
            this.btnCTHD.TabIndex = 45;
            this.btnCTHD.Text = "Chi tiết hóa đơn";
            this.btnCTHD.UseVisualStyleBackColor = false;
            this.btnCTHD.Click += new System.EventHandler(this.btnCTHD_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(633, 706);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 29);
            this.label10.TabIndex = 34;
            this.label10.Text = "Số lượng";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(413, 335);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 52);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(511, 335);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 52);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvSach
            // 
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(624, 391);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 82;
            this.dgvSach.RowTemplate.Height = 33;
            this.dgvSach.Size = new System.Drawing.Size(597, 295);
            this.dgvSach.TabIndex = 40;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(624, 36);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 82;
            this.dgvCTHD.RowTemplate.Height = 33;
            this.dgvCTHD.Size = new System.Drawing.Size(597, 294);
            this.dgvCTHD.TabIndex = 42;
            this.dgvCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellClick);
            // 
            // dgvHoadon
            // 
            this.dgvHoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadon.Location = new System.Drawing.Point(7, 36);
            this.dgvHoadon.Name = "dgvHoadon";
            this.dgvHoadon.RowHeadersWidth = 82;
            this.dgvHoadon.RowTemplate.Height = 33;
            this.dgvHoadon.Size = new System.Drawing.Size(597, 294);
            this.dgvHoadon.TabIndex = 41;
            this.dgvHoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoadon_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(953, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tên KH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(619, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(626, 29);
            this.label4.TabIndex = 37;
            this.label4.Text = "CHỌN SÁCH(Để tạo hóa đơn và được hiển thị trên CTHD)";
            // 
            // btnXuatHD
            // 
            this.btnXuatHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXuatHD.Location = new System.Drawing.Point(1046, 689);
            this.btnXuatHD.Name = "btnXuatHD";
            this.btnXuatHD.Size = new System.Drawing.Size(172, 52);
            this.btnXuatHD.TabIndex = 46;
            this.btnXuatHD.Text = "Xuất hóa đơn";
            this.btnXuatHD.UseVisualStyleBackColor = false;
            this.btnXuatHD.Click += new System.EventHandler(this.btnXuatHD_Click);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 755);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMaHD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numSL);
            this.Controls.Add(this.btnHoanthanhHD);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.btnXoaSach);
            this.Controls.Add(this.btnXuatHD);
            this.Controls.Add(this.btnChonSach);
            this.Controls.Add(this.btnCTHD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.dgvHoadon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDon";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker TimeLapHD_add;
        private System.Windows.Forms.ComboBox cbKHID_add;
        private System.Windows.Forms.ComboBox cbNVID_add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHDID_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNVID_update;
        private System.Windows.Forms.ComboBox cbMaHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker timeLapHD_update;
        private System.Windows.Forms.ComboBox cbKHID_update;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Button btnHoanthanhHD;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Button btnChonSach;
        private System.Windows.Forms.Button btnCTHD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.DataGridView dgvHoadon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXuatHD;
    }
}