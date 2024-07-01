namespace QuanLyNhaSach
{
    partial class QLNV
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
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearchNV = new System.Windows.Forms.Button();
            this.btnAddNV = new System.Windows.Forms.Button();
            this.btnUpdateNV = new System.Windows.Forms.Button();
            this.btnDeleteNV = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtNVID = new System.Windows.Forms.TextBox();
            this.txtNVName = new System.Windows.Forms.TextBox();
            this.Timengaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbGtinh = new System.Windows.Forms.ComboBox();
            this.cbNhiemvu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Location = new System.Drawing.Point(14, 37);
            this.dgvNhanvien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.RowHeadersWidth = 82;
            this.dgvNhanvien.RowTemplate.Height = 33;
            this.dgvNhanvien.Size = new System.Drawing.Size(1221, 600);
            this.dgvNhanvien.TabIndex = 0;
            this.dgvNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanvien_CellClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1252, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 652);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã NV:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 710);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên NV:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 773);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 648);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(411, 704);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 36);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giới tính:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(410, 769);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 36);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nhiệm vụ:";
            // 
            // btnSearchNV
            // 
            this.btnSearchNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearchNV.Location = new System.Drawing.Point(894, 646);
            this.btnSearchNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchNV.Name = "btnSearchNV";
            this.btnSearchNV.Size = new System.Drawing.Size(152, 55);
            this.btnSearchNV.TabIndex = 4;
            this.btnSearchNV.Text = "Tìm kiếm";
            this.btnSearchNV.UseVisualStyleBackColor = false;
            this.btnSearchNV.Click += new System.EventHandler(this.btnSearchNV_Click);
            // 
            // btnAddNV
            // 
            this.btnAddNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddNV.Location = new System.Drawing.Point(894, 748);
            this.btnAddNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(152, 55);
            this.btnAddNV.TabIndex = 4;
            this.btnAddNV.Text = "Thêm";
            this.btnAddNV.UseVisualStyleBackColor = false;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // btnUpdateNV
            // 
            this.btnUpdateNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnUpdateNV.Location = new System.Drawing.Point(1083, 646);
            this.btnUpdateNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateNV.Name = "btnUpdateNV";
            this.btnUpdateNV.Size = new System.Drawing.Size(152, 55);
            this.btnUpdateNV.TabIndex = 4;
            this.btnUpdateNV.Text = "Sửa";
            this.btnUpdateNV.UseVisualStyleBackColor = false;
            this.btnUpdateNV.Click += new System.EventHandler(this.btnUpdateNV_Click);
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDeleteNV.Location = new System.Drawing.Point(1083, 746);
            this.btnDeleteNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Size = new System.Drawing.Size(152, 55);
            this.btnDeleteNV.TabIndex = 4;
            this.btnDeleteNV.Text = "Xóa";
            this.btnDeleteNV.UseVisualStyleBackColor = false;
            this.btnDeleteNV.Click += new System.EventHandler(this.btnDeleteNV_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(565, 648);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(298, 35);
            this.txtpassword.TabIndex = 6;
            // 
            // txtNVID
            // 
            this.txtNVID.Location = new System.Drawing.Point(158, 652);
            this.txtNVID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNVID.Multiline = true;
            this.txtNVID.Name = "txtNVID";
            this.txtNVID.Size = new System.Drawing.Size(233, 35);
            this.txtNVID.TabIndex = 6;
            this.txtNVID.TextChanged += new System.EventHandler(this.txtNVID_TextChanged);
            // 
            // txtNVName
            // 
            this.txtNVName.Location = new System.Drawing.Point(158, 710);
            this.txtNVName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNVName.Multiline = true;
            this.txtNVName.Name = "txtNVName";
            this.txtNVName.Size = new System.Drawing.Size(233, 35);
            this.txtNVName.TabIndex = 6;
            // 
            // Timengaysinh
            // 
            this.Timengaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Timengaysinh.Location = new System.Drawing.Point(158, 770);
            this.Timengaysinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Timengaysinh.Name = "Timengaysinh";
            this.Timengaysinh.Size = new System.Drawing.Size(233, 35);
            this.Timengaysinh.TabIndex = 7;
            // 
            // cbGtinh
            // 
            this.cbGtinh.FormattingEnabled = true;
            this.cbGtinh.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cbGtinh.Location = new System.Drawing.Point(566, 704);
            this.cbGtinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbGtinh.Name = "cbGtinh";
            this.cbGtinh.Size = new System.Drawing.Size(140, 37);
            this.cbGtinh.TabIndex = 8;
            // 
            // cbNhiemvu
            // 
            this.cbNhiemvu.FormattingEnabled = true;
            this.cbNhiemvu.Items.AddRange(new object[] {
            "Nhân viên bán hàng",
            "Nhân viên kho",
            "Admin",
            "Quản lý"});
            this.cbNhiemvu.Location = new System.Drawing.Point(565, 764);
            this.cbNhiemvu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbNhiemvu.Name = "cbNhiemvu";
            this.cbNhiemvu.Size = new System.Drawing.Size(297, 37);
            this.cbNhiemvu.TabIndex = 9;
            // 
            // QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 820);
            this.Controls.Add(this.cbNhiemvu);
            this.Controls.Add(this.cbGtinh);
            this.Controls.Add(this.Timengaysinh);
            this.Controls.Add(this.txtNVName);
            this.Controls.Add(this.txtNVID);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.btnDeleteNV);
            this.Controls.Add(this.btnUpdateNV);
            this.Controls.Add(this.btnAddNV);
            this.Controls.Add(this.btnSearchNV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNhanvien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "QLNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLNV";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearchNV;
        private System.Windows.Forms.Button btnAddNV;
        private System.Windows.Forms.Button btnUpdateNV;
        private System.Windows.Forms.Button btnDeleteNV;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtNVID;
        private System.Windows.Forms.TextBox txtNVName;
        private System.Windows.Forms.DateTimePicker Timengaysinh;
        private System.Windows.Forms.ComboBox cbGtinh;
        private System.Windows.Forms.ComboBox cbNhiemvu;
    }
}