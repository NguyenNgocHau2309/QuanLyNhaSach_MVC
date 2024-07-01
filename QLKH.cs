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
    public partial class QLKH : Form
    {
        private DataProvider dataProvider = new DataProvider();
        int NoNotificationID = 0;
        public QLKH()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            loadDgvkhachhang();
        }
        private void loadDgvkhachhang()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("Select KH_ID as [Mã KH], KH_Name as [Tên KH], Ngaysinh as [Ngày sinh]," +
                "Gioitinh as [Giới tính], KH_Email as [Email], KH_phone as [Số điện thoại] from Khachhang ;");
            dt = dataProvider.execQuery(query.ToString());
            dgvKhachhang.DataSource = dt;
        }
        private void dgvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) rowID = 0;
            if (rowID == dgvKhachhang.RowCount - 1) rowID = rowID - 1;
            DataGridViewRow row = dgvKhachhang.Rows[rowID];
            NoNotificationID = 1;
            txtKHID.Text = row.Cells[0].Value.ToString();
            NoNotificationID = 0;
            txtKHName.Text = row.Cells[1].Value.ToString();
            Timengaysinh.Value = Convert.ToDateTime(row.Cells[2].Value);
            cbGtinh.Text = row.Cells[3].Value.ToString();
            txtEmail.Text = row.Cells[4].Value.ToString();
            txtSdt.Text = row.Cells[5].Value.ToString();
        }

        private void btnSearchKH_Click(object sender, EventArgs e)
        {
            string keyword = txtKHID.Text.Trim();
            StringBuilder query = new StringBuilder("SELECT KH_ID as [Mã KH], KH_Name as [Tên KH], Ngaysinh as [Ngày sinh], Gioitinh as [Giới tính], KH_Email as [Email], KH_phone as [Số điện thoại] FROM Khachhang WHERE KH_ID LIKE '%" + keyword + "%' OR KH_Name LIKE N'%" + keyword + "%'");

            DataTable dt = dataProvider.execQuery(query.ToString());
            dgvKhachhang.DataSource = dt;
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            if (txtKHID.Text == "" || txtKHName.Text == "" || txtEmail.Text == "" || txtSdt.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo");
            }
            else
            {
                DateTime ngaysinh = Timengaysinh.Value;
                StringBuilder query = new StringBuilder("EXEC pro_them_khachhang");
                query.Append(" @makh = '" + txtKHID.Text + "'");
                query.Append(", @tenkh = N'" + txtKHName.Text + "'");
                query.Append(", @ngaysinh = '" + ngaysinh.ToString("yyyy-MM-dd") + "'");
                query.Append(", @gioitinh = N'" + cbGtinh.Text + "'");
                query.Append(", @email = N'" + txtEmail.Text + "'");
                query.Append(", @sdt = '" + txtSdt.Text + "'");

                int result = dataProvider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    loadDgvkhachhang();
                    MessageBox.Show("Thêm khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateKH_Click(object sender, EventArgs e)
        {
            if (txtKHID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo");
            }
            else
            {
                if (txtKHID.Text == "" || txtKHName.Text == "" || txtEmail.Text == "" || txtSdt.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần cập nhật!", "Thông báo");
                }
                else
                {
                    DateTime ngaysinh = Timengaysinh.Value;
                    StringBuilder query = new StringBuilder("EXEC pro_capnhap_khachhang");
                    query.Append(" @makh = '" + txtKHID.Text + "'");
                    query.Append(", @tenkh = N'" + txtKHName.Text + "'");
                    query.Append(", @ngaysinh = '" + ngaysinh.ToString("yyyy-MM-dd") + "'");
                    query.Append(", @gioitinh = N'" + cbGtinh.Text + "'");
                    query.Append(", @email = N'" + txtEmail.Text + "'");
                    query.Append(", @sdt = '" + txtSdt.Text + "'");

                    int result = dataProvider.execNonQuery(query.ToString());
                    if (result > 0)
                    {
                        loadDgvkhachhang();
                        MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin khách hàng không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDeleteKH_Click(object sender, EventArgs e)
        {
            if (txtKHID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM Khachhang WHERE KH_ID = '" + txtKHID.Text + "'";
                    int rowsAffected = dataProvider.execNonQuery(query);
                    if (rowsAffected > 0)
                    {
                        loadDgvkhachhang();
                        MessageBox.Show("Xóa khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool IsMaKHIDExists(string khID)
        {
            string query = "Select count(*) from Khachhang where KH_ID = '" + khID + "'";

            int count = Convert.ToInt32(dataProvider.execScalar(query));
            return count > 0;
        }
        private void txtKHID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKHID.Text) && NoNotificationID == 0)
            {
                if (IsMaKHIDExists(txtKHID.Text))
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
