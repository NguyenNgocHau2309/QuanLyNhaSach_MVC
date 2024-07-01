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
    public partial class QLNV : Form
    {
        private DataProvider dataProvider = new DataProvider();
        int NoNotificationID = 0;
        public QLNV()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            loadDgvNhanvien();
        }
        private void loadDgvNhanvien()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("Select NV_ID as [Mã NV], NV_Name as [Tên NV], Pass_word as [Mật khẩu]," +
                "Ngaysinh as [Ngày sinh], Gioitinh as [Giới tính],Nhiemvu as [Nhiệm vụ] from Nhanvien ;");
            dt = dataProvider.execQuery(query.ToString());
            dgvNhanvien.DataSource = dt;
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) rowID = 0;
            if (rowID == dgvNhanvien.RowCount - 1) rowID = rowID - 1;
            DataGridViewRow row = dgvNhanvien.Rows[rowID];
            NoNotificationID = 1;
            txtNVID.Text = row.Cells[0].Value.ToString();
            NoNotificationID = 0;
            txtNVName.Text = row.Cells[1].Value.ToString();
            txtpassword.Text = row.Cells[2].Value.ToString();
            Timengaysinh.Value = Convert.ToDateTime(row.Cells[3].Value);
            cbGtinh.Text = row.Cells[4].Value.ToString();
            cbNhiemvu.Text = row.Cells[5].Value.ToString();
        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            string keyword = txtNVID.Text.Trim();
            StringBuilder query = new StringBuilder("SELECT NV_ID as [Mã NV], NV_Name as [Tên NV], Pass_word as [Mật khẩu], " +
                "Ngaysinh as [Ngày sinh], Gioitinh as [Giới tính], Nhiemvu as [Nhiệm vụ] FROM Nhanvien " +
                "WHERE NV_ID LIKE '%" + keyword + "%'");


            DataTable dt = dataProvider.execQuery(query.ToString());
            dgvNhanvien.DataSource = dt;
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            if (txtNVID.Text == "" || txtNVName.Text == "" || txtpassword.Text == "" || cbGtinh.Text == "" || cbNhiemvu.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin!", "THÔNG BÁO");
            }
            else
            {
                DateTime namsinh = Timengaysinh.Value;
                StringBuilder query = new StringBuilder("EXEC pro_them_nhanvien");
                query.Append(" @manv = '" + txtNVID.Text + "'");
                query.Append(", @tennv = N'" + txtNVName.Text + "'");
                query.Append(", @pass = N'" + txtpassword.Text + "'");
                query.Append(", @ns = '" + namsinh.ToString("yyyy-MM-dd") + "'");
                query.Append(", @gt = N'" + cbGtinh.Text + "'");
                query.Append(", @nv = N'" + cbNhiemvu.Text + "'");


                int result = dataProvider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    loadDgvNhanvien();
                    MessageBox.Show("Thêm nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            if (txtNVID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo");
            }
            else
            {
                if (txtNVID.Text == "" || txtNVName.Text == "" || txtpassword.Text == "" || cbGtinh.Text == "" || cbNhiemvu.Text == "")
                {
                    MessageBox.Show("Vui lòng điền thông tin!", "THÔNG BÁO");
                }
                else
                {
                    DateTime namsinh = Timengaysinh.Value;
                    StringBuilder query = new StringBuilder("EXEC pro_capnhap_nhanvien");
                    query.Append(" @manv = '" + txtNVID.Text + "'");
                    query.Append(", @tennv = N'" + txtNVName.Text + "'");
                    query.Append(", @pass = N'" + txtpassword.Text + "'");
                    query.Append(", @ns = '" + namsinh.ToString("yyyy-MM-dd") + "'");
                    query.Append(", @gt = N'" + cbGtinh.Text + "'");
                    query.Append(", @nv = N'" + cbNhiemvu.Text + "'");

                    int result = dataProvider.execNonQuery(query.ToString());
                    if (result > 0)
                    {
                        loadDgvNhanvien();
                        MessageBox.Show("Cập nhật nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật nhân viên không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            if (txtNVID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM Nhanvien WHERE NV_ID = '" + txtNVID.Text + "'";
                    int rowsAffected = dataProvider.execNonQuery(query);
                    if (rowsAffected > 0)
                    {
                        loadDgvNhanvien();
                        MessageBox.Show("Xóa nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool IsMaNVIDExists(string nvID)
        {
            string query = "Select count(*) from Nhanvien where NV_ID = '" + nvID + "'";

            int count = Convert.ToInt32(dataProvider.execScalar(query));
            return count > 0;
        }
        private void txtNVID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNVID.Text) && NoNotificationID == 0)
            {
                if (IsMaNVIDExists(txtNVID.Text))
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
