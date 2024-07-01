namespace QuanLyNhaSach
{
    partial class PhieuNhap
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnChonSach = new System.Windows.Forms.Button();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TimeLapPN_add = new System.Windows.Forms.DateTimePicker();
            this.cbNVID_add = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPNID_add = new System.Windows.Forms.TextBox();
            this.cbMaPN = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeLapPN_update = new System.Windows.Forms.DateTimePicker();
            this.cbNVID_update = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreatePN = new System.Windows.Forms.Button();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnCTPN = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.dgvPhieunhap = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btCheckkho = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieunhap)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1246, 792);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnChonSach);
            this.tabPage1.Controls.Add(this.numSL);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.cbMaPN);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnCreatePN);
            this.tabPage1.Controls.Add(this.txtTenNV);
            this.tabPage1.Controls.Add(this.btnXoaSach);
            this.tabPage1.Controls.Add(this.btnCTPN);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.dgvSach);
            this.tabPage1.Controls.Add(this.dgvCTPN);
            this.tabPage1.Controls.Add(this.dgvPhieunhap);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(8, 43);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1230, 741);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phiếu nhập ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnChonSach
            // 
            this.btnChonSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnChonSach.Location = new System.Drawing.Point(867, 679);
            this.btnChonSach.Name = "btnChonSach";
            this.btnChonSach.Size = new System.Drawing.Size(125, 52);
            this.btnChonSach.TabIndex = 28;
            this.btnChonSach.Text = "Chọn sách";
            this.btnChonSach.UseVisualStyleBackColor = false;
            this.btnChonSach.Click += new System.EventHandler(this.btnChonSach_Click);
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(721, 690);
            this.numSL.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numSL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(105, 35);
            this.numSL.TabIndex = 15;
            this.numSL.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numSL.ValueChanged += new System.EventHandler(this.numSL_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TimeLapPN_add);
            this.groupBox2.Controls.Add(this.cbNVID_add);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPNID_add);
            this.groupBox2.Location = new System.Drawing.Point(6, 528);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 142);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm hóa đơn";
            // 
            // TimeLapPN_add
            // 
            this.TimeLapPN_add.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimeLapPN_add.Location = new System.Drawing.Point(369, 56);
            this.TimeLapPN_add.Name = "TimeLapPN_add";
            this.TimeLapPN_add.Size = new System.Drawing.Size(176, 35);
            this.TimeLapPN_add.TabIndex = 2;
            // 
            // cbNVID_add
            // 
            this.cbNVID_add.FormattingEnabled = true;
            this.cbNVID_add.Location = new System.Drawing.Point(91, 94);
            this.cbNVID_add.Name = "cbNVID_add";
            this.cbNVID_add.Size = new System.Drawing.Size(106, 37);
            this.cbNVID_add.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã NV:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày lập:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã PN:";
            // 
            // txtPNID_add
            // 
            this.txtPNID_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPNID_add.Location = new System.Drawing.Point(91, 43);
            this.txtPNID_add.Multiline = true;
            this.txtPNID_add.Name = "txtPNID_add";
            this.txtPNID_add.Size = new System.Drawing.Size(106, 35);
            this.txtPNID_add.TabIndex = 12;
            this.txtPNID_add.TextChanged += new System.EventHandler(this.txtPNID_add_TextChanged);
            // 
            // cbMaPN
            // 
            this.cbMaPN.FormattingEnabled = true;
            this.cbMaPN.Location = new System.Drawing.Point(6, 345);
            this.cbMaPN.Name = "cbMaPN";
            this.cbMaPN.Size = new System.Drawing.Size(117, 37);
            this.cbMaPN.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeLapPN_update);
            this.groupBox1.Controls.Add(this.cbNVID_update);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(6, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 127);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sửa hóa đơn";
            // 
            // timeLapPN_update
            // 
            this.timeLapPN_update.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeLapPN_update.Location = new System.Drawing.Point(369, 59);
            this.timeLapPN_update.Name = "timeLapPN_update";
            this.timeLapPN_update.Size = new System.Drawing.Size(176, 35);
            this.timeLapPN_update.TabIndex = 2;
            // 
            // cbNVID_update
            // 
            this.cbNVID_update.FormattingEnabled = true;
            this.cbNVID_update.Location = new System.Drawing.Point(90, 59);
            this.cbNVID_update.Name = "cbNVID_update";
            this.cbNVID_update.Size = new System.Drawing.Size(106, 37);
            this.cbNVID_update.TabIndex = 1;
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
            this.label5.Location = new System.Drawing.Point(5, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã NV:";
            // 
            // btnCreatePN
            // 
            this.btnCreatePN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreatePN.Location = new System.Drawing.Point(1016, 676);
            this.btnCreatePN.Name = "btnCreatePN";
            this.btnCreatePN.Size = new System.Drawing.Size(191, 52);
            this.btnCreatePN.TabIndex = 13;
            this.btnCreatePN.Text = "Tạo phiếu nhập";
            this.btnCreatePN.UseVisualStyleBackColor = false;
            this.btnCreatePN.Click += new System.EventHandler(this.btnCreatePN_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTenNV.Location = new System.Drawing.Point(1045, 0);
            this.txtTenNV.Multiline = true;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(172, 32);
            this.txtTenNV.TabIndex = 12;
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.BackColor = System.Drawing.Color.Red;
            this.btnXoaSach.Location = new System.Drawing.Point(1085, 335);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(132, 52);
            this.btnXoaSach.TabIndex = 13;
            this.btnXoaSach.Text = "Xóa sách";
            this.btnXoaSach.UseVisualStyleBackColor = false;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // btnCTPN
            // 
            this.btnCTPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCTPN.Location = new System.Drawing.Point(128, 337);
            this.btnCTPN.Name = "btnCTPN";
            this.btnCTPN.Size = new System.Drawing.Size(221, 52);
            this.btnCTPN.TabIndex = 13;
            this.btnCTPN.Text = "Chi tiết hóa đơn";
            this.btnCTPN.UseVisualStyleBackColor = false;
            this.btnCTPN.Click += new System.EventHandler(this.btnCTPN_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(620, 690);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Số lượng";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(410, 337);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 52);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(508, 337);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 52);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvSach
            // 
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(621, 393);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 82;
            this.dgvSach.RowTemplate.Height = 33;
            this.dgvSach.Size = new System.Drawing.Size(597, 277);
            this.dgvSach.TabIndex = 11;
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPN.Location = new System.Drawing.Point(620, 35);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.RowHeadersWidth = 82;
            this.dgvCTPN.RowTemplate.Height = 33;
            this.dgvCTPN.Size = new System.Drawing.Size(597, 294);
            this.dgvCTPN.TabIndex = 11;
            this.dgvCTPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPN_CellClick);
            // 
            // dgvPhieunhap
            // 
            this.dgvPhieunhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieunhap.Location = new System.Drawing.Point(5, 35);
            this.dgvPhieunhap.Name = "dgvPhieunhap";
            this.dgvPhieunhap.RowHeadersWidth = 82;
            this.dgvPhieunhap.RowTemplate.Height = 33;
            this.dgvPhieunhap.Size = new System.Drawing.Size(597, 294);
            this.dgvPhieunhap.TabIndex = 11;
            this.dgvPhieunhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieunhap_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(951, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên NV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "CHI TIẾT PHIẾU NHẬP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(626, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "CHỌN SÁCH(Để tạo hóa đơn và được hiển thị trên CTHD)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(824, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU NHẬP(Click vào hàng hóa đơn sẽ hiển thị CTPN đó trên bảng CTPN)";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btCheckkho);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.dgvKho);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(8, 43);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1230, 741);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kho";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btCheckkho
            // 
            this.btCheckkho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCheckkho.Location = new System.Drawing.Point(361, 708);
            this.btCheckkho.Name = "btCheckkho";
            this.btCheckkho.Size = new System.Drawing.Size(192, 53);
            this.btCheckkho.TabIndex = 14;
            this.btCheckkho.Text = "Kiểm tra";
            this.btCheckkho.UseVisualStyleBackColor = false;
            this.btCheckkho.Click += new System.EventHandler(this.btCheckkho_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 718);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(364, 37);
            this.label11.TabIndex = 13;
            this.label11.Text = "Kiểm tra sách cần nhập:";
            // 
            // dgvKho
            // 
            this.dgvKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKho.Location = new System.Drawing.Point(18, 22);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.RowHeadersWidth = 82;
            this.dgvKho.RowTemplate.Height = 33;
            this.dgvKho.Size = new System.Drawing.Size(1189, 669);
            this.dgvKho.TabIndex = 12;
            // 
            // PhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 802);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhieuNhap";
            this.Text = "PhieuNhap";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieunhap)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnChonSach;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker TimeLapPN_add;
        private System.Windows.Forms.ComboBox cbNVID_add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPNID_add;
        private System.Windows.Forms.ComboBox cbMaPN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker timeLapPN_update;
        private System.Windows.Forms.ComboBox cbNVID_update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreatePN;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Button btnCTPN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridView dgvCTPN;
        private System.Windows.Forms.DataGridView dgvPhieunhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btCheckkho;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvKho;
    }
}