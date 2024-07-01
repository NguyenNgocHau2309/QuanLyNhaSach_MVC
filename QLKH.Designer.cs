namespace QuanLyNhaSach
{
    partial class QLKH
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
            this.cbGtinh = new System.Windows.Forms.ComboBox();
            this.Timengaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtKHName = new System.Windows.Forms.TextBox();
            this.txtKHID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnDeleteKH = new System.Windows.Forms.Button();
            this.btnUpdateKH = new System.Windows.Forms.Button();
            this.btnAddKH = new System.Windows.Forms.Button();
            this.btnSearchKH = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKhachhang = new System.Windows.Forms.DataGridView();
            this.txtSdt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGtinh
            // 
            this.cbGtinh.FormattingEnabled = true;
            this.cbGtinh.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cbGtinh.Location = new System.Drawing.Point(618, 641);
            this.cbGtinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbGtinh.Name = "cbGtinh";
            this.cbGtinh.Size = new System.Drawing.Size(140, 37);
            this.cbGtinh.TabIndex = 26;
            // 
            // Timengaysinh
            // 
            this.Timengaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Timengaysinh.Location = new System.Drawing.Point(157, 760);
            this.Timengaysinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Timengaysinh.Name = "Timengaysinh";
            this.Timengaysinh.Size = new System.Drawing.Size(233, 35);
            this.Timengaysinh.TabIndex = 25;
            // 
            // txtKHName
            // 
            this.txtKHName.Location = new System.Drawing.Point(157, 703);
            this.txtKHName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKHName.Multiline = true;
            this.txtKHName.Name = "txtKHName";
            this.txtKHName.Size = new System.Drawing.Size(233, 35);
            this.txtKHName.TabIndex = 24;
            // 
            // txtKHID
            // 
            this.txtKHID.Location = new System.Drawing.Point(157, 644);
            this.txtKHID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKHID.Multiline = true;
            this.txtKHID.Name = "txtKHID";
            this.txtKHID.Size = new System.Drawing.Size(233, 35);
            this.txtKHID.TabIndex = 23;
            this.txtKHID.TextChanged += new System.EventHandler(this.txtKHID_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(618, 700);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(253, 35);
            this.txtEmail.TabIndex = 22;
            // 
            // btnDeleteKH
            // 
            this.btnDeleteKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDeleteKH.Location = new System.Drawing.Point(1079, 740);
            this.btnDeleteKH.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteKH.Name = "btnDeleteKH";
            this.btnDeleteKH.Size = new System.Drawing.Size(152, 55);
            this.btnDeleteKH.TabIndex = 20;
            this.btnDeleteKH.Text = "Xóa";
            this.btnDeleteKH.UseVisualStyleBackColor = false;
            this.btnDeleteKH.Click += new System.EventHandler(this.btnDeleteKH_Click);
            // 
            // btnUpdateKH
            // 
            this.btnUpdateKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnUpdateKH.Location = new System.Drawing.Point(1079, 635);
            this.btnUpdateKH.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateKH.Name = "btnUpdateKH";
            this.btnUpdateKH.Size = new System.Drawing.Size(152, 55);
            this.btnUpdateKH.TabIndex = 21;
            this.btnUpdateKH.Text = "Sửa";
            this.btnUpdateKH.UseVisualStyleBackColor = false;
            this.btnUpdateKH.Click += new System.EventHandler(this.btnUpdateKH_Click);
            // 
            // btnAddKH
            // 
            this.btnAddKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddKH.Location = new System.Drawing.Point(894, 740);
            this.btnAddKH.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddKH.Name = "btnAddKH";
            this.btnAddKH.Size = new System.Drawing.Size(152, 55);
            this.btnAddKH.TabIndex = 19;
            this.btnAddKH.Text = "Thêm";
            this.btnAddKH.UseVisualStyleBackColor = false;
            this.btnAddKH.Click += new System.EventHandler(this.btnAddKH_Click);
            // 
            // btnSearchKH
            // 
            this.btnSearchKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearchKH.Location = new System.Drawing.Point(894, 635);
            this.btnSearchKH.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchKH.Name = "btnSearchKH";
            this.btnSearchKH.Size = new System.Drawing.Size(152, 55);
            this.btnSearchKH.TabIndex = 18;
            this.btnSearchKH.Text = "Tìm kiếm";
            this.btnSearchKH.UseVisualStyleBackColor = false;
            this.btnSearchKH.Click += new System.EventHandler(this.btnSearchKH_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(411, 759);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 36);
            this.label7.TabIndex = 17;
            this.label7.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(458, 643);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 36);
            this.label6.TabIndex = 16;
            this.label6.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 762);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 36);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(483, 700);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 703);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 36);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên KH:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 644);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã KH:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1255, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quản lý khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvKhachhang
            // 
            this.dgvKhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachhang.Location = new System.Drawing.Point(14, 37);
            this.dgvKhachhang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvKhachhang.Name = "dgvKhachhang";
            this.dgvKhachhang.RowHeadersWidth = 82;
            this.dgvKhachhang.RowTemplate.Height = 33;
            this.dgvKhachhang.Size = new System.Drawing.Size(1228, 588);
            this.dgvKhachhang.TabIndex = 10;
            this.dgvKhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachhang_CellClick);
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(618, 759);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSdt.Multiline = true;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(253, 35);
            this.txtSdt.TabIndex = 27;
            // 
            // QLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 813);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.cbGtinh);
            this.Controls.Add(this.Timengaysinh);
            this.Controls.Add(this.txtKHName);
            this.Controls.Add(this.txtKHID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnDeleteKH);
            this.Controls.Add(this.btnUpdateKH);
            this.Controls.Add(this.btnAddKH);
            this.Controls.Add(this.btnSearchKH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKhachhang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "QLKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLKH";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbGtinh;
        private System.Windows.Forms.DateTimePicker Timengaysinh;
        private System.Windows.Forms.TextBox txtKHName;
        private System.Windows.Forms.TextBox txtKHID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnDeleteKH;
        private System.Windows.Forms.Button btnUpdateKH;
        private System.Windows.Forms.Button btnAddKH;
        private System.Windows.Forms.Button btnSearchKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKhachhang;
        private System.Windows.Forms.TextBox txtSdt;
    }
}