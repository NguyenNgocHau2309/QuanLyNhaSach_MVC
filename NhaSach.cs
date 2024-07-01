using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class NhaSach : Form
    {
        string manv;
        public NhaSach()
        {
            InitializeComponent();
        }
        public NhaSach(string username)
        {
            InitializeComponent();
            txtNVID.Text = username;
            txtNVID.ReadOnly = true;
        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            manv = txtNVID.Text;
            if (!string.IsNullOrEmpty(manv) && manv.Contains("NVK") || !string.IsNullOrEmpty(manv) && manv.Contains("admin"))
            {
                Quanlysach f = new Quanlysach();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            manv = txtNVID.Text;
            if (!string.IsNullOrEmpty(manv) && manv.Contains("NVQL") || !string.IsNullOrEmpty(manv) && manv.Contains("admin"))
            {
                QLNV f = new QLNV();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            manv = txtNVID.Text;
            if (!string.IsNullOrEmpty(manv) && manv.Contains("NVBH") || !string.IsNullOrEmpty(manv) && manv.Contains("admin"))
            {
                HoaDon f = new HoaDon(txtNVID.Text);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            manv = txtNVID.Text;
            if (!string.IsNullOrEmpty(manv) && manv.Contains("NVBH") || !string.IsNullOrEmpty(manv) && manv.Contains("admin"))
            {
                QLKH f = new QLKH();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnQLPN_Click(object sender, EventArgs e)
        {
            manv = txtNVID.Text;
            if (!string.IsNullOrEmpty(manv) && manv.Contains("NVK") || !string.IsNullOrEmpty(manv) && manv.Contains("admin"))
            {
                PhieuNhap f = new PhieuNhap(txtNVID.Text);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBCTK_Click(object sender, EventArgs e)
        {
            manv = txtNVID.Text;
            if (!string.IsNullOrEmpty(manv) && manv.Contains("NVQL") || !string.IsNullOrEmpty(manv) && manv.Contains("admin"))
            {
                BCTK f = new BCTK(txtNVID.Text);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
