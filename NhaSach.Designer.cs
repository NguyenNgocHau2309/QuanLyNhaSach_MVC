namespace QuanLyNhaSach
{
    partial class NhaSach
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnQLHD = new System.Windows.Forms.Button();
            this.btnQLPN = new System.Windows.Forms.Button();
            this.btnBCTK = new System.Windows.Forms.Button();
            this.btnQLSach = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtNVID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1109, 53);
            this.label2.TabIndex = 3;
            this.label2.Text = "HỆ THỐNG QUẢN LÝ NHÀ SÁCH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQLHD
            // 
            this.btnQLHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQLHD.Location = new System.Drawing.Point(-8, 419);
            this.btnQLHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnQLHD.Name = "btnQLHD";
            this.btnQLHD.Size = new System.Drawing.Size(372, 202);
            this.btnQLHD.TabIndex = 4;
            this.btnQLHD.Text = "Quản lý hóa đơn";
            this.btnQLHD.UseVisualStyleBackColor = false;
            this.btnQLHD.Click += new System.EventHandler(this.btnQLHD_Click);
            // 
            // btnQLPN
            // 
            this.btnQLPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQLPN.Location = new System.Drawing.Point(361, 419);
            this.btnQLPN.Margin = new System.Windows.Forms.Padding(2);
            this.btnQLPN.Name = "btnQLPN";
            this.btnQLPN.Size = new System.Drawing.Size(372, 202);
            this.btnQLPN.TabIndex = 4;
            this.btnQLPN.Text = "Quản lý phiếu nhập";
            this.btnQLPN.UseVisualStyleBackColor = false;
            this.btnQLPN.Click += new System.EventHandler(this.btnQLPN_Click);
            // 
            // btnBCTK
            // 
            this.btnBCTK.BackColor = System.Drawing.Color.Cyan;
            this.btnBCTK.Location = new System.Drawing.Point(730, 419);
            this.btnBCTK.Margin = new System.Windows.Forms.Padding(2);
            this.btnBCTK.Name = "btnBCTK";
            this.btnBCTK.Size = new System.Drawing.Size(372, 202);
            this.btnBCTK.TabIndex = 4;
            this.btnBCTK.Text = "Báo cáo thống kê";
            this.btnBCTK.UseVisualStyleBackColor = false;
            this.btnBCTK.Click += new System.EventHandler(this.btnBCTK_Click);
            // 
            // btnQLSach
            // 
            this.btnQLSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnQLSach.Location = new System.Drawing.Point(-8, 216);
            this.btnQLSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnQLSach.Name = "btnQLSach";
            this.btnQLSach.Size = new System.Drawing.Size(372, 206);
            this.btnQLSach.TabIndex = 4;
            this.btnQLSach.Text = "Quản lý sách";
            this.btnQLSach.UseVisualStyleBackColor = false;
            this.btnQLSach.Click += new System.EventHandler(this.btnQLSach_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnQLNV.Location = new System.Drawing.Point(361, 216);
            this.btnQLNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(372, 206);
            this.btnQLNV.TabIndex = 4;
            this.btnQLNV.Text = "Quản lý nhân viên";
            this.btnQLNV.UseVisualStyleBackColor = false;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnQLKH
            // 
            this.btnQLKH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQLKH.Location = new System.Drawing.Point(731, 216);
            this.btnQLKH.Margin = new System.Windows.Forms.Padding(2);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(372, 206);
            this.btnQLKH.TabIndex = 4;
            this.btnQLKH.Text = "Quản lý khách hàng";
            this.btnQLKH.UseVisualStyleBackColor = false;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Nhân viên";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(684, 102);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(229, 61);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtNVID
            // 
            this.txtNVID.Location = new System.Drawing.Point(361, 113);
            this.txtNVID.Name = "txtNVID";
            this.txtNVID.Size = new System.Drawing.Size(168, 40);
            this.txtNVID.TabIndex = 8;
            // 
            // NhaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 619);
            this.Controls.Add(this.txtNVID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQLKH);
            this.Controls.Add(this.btnBCTK);
            this.Controls.Add(this.btnQLNV);
            this.Controls.Add(this.btnQLPN);
            this.Controls.Add(this.btnQLSach);
            this.Controls.Add(this.btnQLHD);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "NhaSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà sách";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQLHD;
        private System.Windows.Forms.Button btnQLPN;
        private System.Windows.Forms.Button btnBCTK;
        private System.Windows.Forms.Button btnQLSach;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtNVID;
    }
}

