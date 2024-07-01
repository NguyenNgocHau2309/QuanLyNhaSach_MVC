namespace QuanLyNhaSach
{
    partial class BCTK
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
            this.dgvTKBC = new System.Windows.Forms.DataGridView();
            this.TimeStart = new System.Windows.Forms.DateTimePicker();
            this.TimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btThongke = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtDoanhthu = new System.Windows.Forms.TextBox();
            this.btXuatBC = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKBC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTKBC
            // 
            this.dgvTKBC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTKBC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKBC.Location = new System.Drawing.Point(9, 232);
            this.dgvTKBC.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvTKBC.Name = "dgvTKBC";
            this.dgvTKBC.RowHeadersWidth = 82;
            this.dgvTKBC.RowTemplate.Height = 33;
            this.dgvTKBC.Size = new System.Drawing.Size(1078, 398);
            this.dgvTKBC.TabIndex = 1;
            // 
            // TimeStart
            // 
            this.TimeStart.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.TimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimeStart.Location = new System.Drawing.Point(193, 107);
            this.TimeStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.Size = new System.Drawing.Size(240, 48);
            this.TimeStart.TabIndex = 2;
            // 
            // TimeEnd
            // 
            this.TimeEnd.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.TimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimeEnd.Location = new System.Drawing.Point(193, 171);
            this.TimeEnd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TimeEnd.Name = "TimeEnd";
            this.TimeEnd.Size = new System.Drawing.Size(240, 48);
            this.TimeEnd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.label1.Location = new System.Drawing.Point(18, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.label2.Location = new System.Drawing.Point(18, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1100, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thống kê báo cáo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btThongke
            // 
            this.btThongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btThongke.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.btThongke.Location = new System.Drawing.Point(519, 165);
            this.btThongke.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btThongke.Name = "btThongke";
            this.btThongke.Size = new System.Drawing.Size(174, 54);
            this.btThongke.TabIndex = 5;
            this.btThongke.Text = "Thống kê";
            this.btThongke.UseVisualStyleBackColor = false;
            this.btThongke.Click += new System.EventHandler(this.btThongke_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(582, 645);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doanh thu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(105, 647);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 46);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số lượng";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F);
            this.txtSoluong.Location = new System.Drawing.Point(296, 648);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSoluong.Multiline = true;
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(72, 53);
            this.txtSoluong.TabIndex = 6;
            // 
            // txtDoanhthu
            // 
            this.txtDoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtDoanhthu.Location = new System.Drawing.Point(799, 648);
            this.txtDoanhthu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDoanhthu.Multiline = true;
            this.txtDoanhthu.Name = "txtDoanhthu";
            this.txtDoanhthu.Size = new System.Drawing.Size(203, 53);
            this.txtDoanhthu.TabIndex = 6;
            // 
            // btXuatBC
            // 
            this.btXuatBC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btXuatBC.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.btXuatBC.Location = new System.Drawing.Point(859, 165);
            this.btXuatBC.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btXuatBC.Name = "btXuatBC";
            this.btXuatBC.Size = new System.Drawing.Size(228, 54);
            this.btXuatBC.TabIndex = 5;
            this.btXuatBC.Text = "Xuất báo cáo";
            this.btXuatBC.UseVisualStyleBackColor = false;
            this.btXuatBC.Click += new System.EventHandler(this.btXuatBC_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.label6.Location = new System.Drawing.Point(80, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 41);
            this.label6.TabIndex = 3;
            this.label6.Text = "Thời gian thống kê";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.label7.Location = new System.Drawing.Point(552, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 41);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nhân viên";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(717, 68);
            this.txtusername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(211, 39);
            this.txtusername.TabIndex = 7;
            // 
            // BCTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 731);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtDoanhthu);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.btXuatBC);
            this.Controls.Add(this.btThongke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeEnd);
            this.Controls.Add(this.TimeStart);
            this.Controls.Add(this.dgvTKBC);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BCTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BCTK";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKBC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTKBC;
        private System.Windows.Forms.DateTimePicker TimeStart;
        private System.Windows.Forms.DateTimePicker TimeEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btThongke;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtDoanhthu;
        private System.Windows.Forms.Button btXuatBC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtusername;
    }
}