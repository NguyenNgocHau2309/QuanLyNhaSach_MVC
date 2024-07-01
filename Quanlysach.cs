using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class Quanlysach : Form
    {
        private DataProvider dataProvider = new DataProvider();
        private string stTacgia;
        private string stTheloai;
        private string stNhaxb;
        int NoNotificationID = 0;
        public Quanlysach()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            loadDgvSach();
            loadDgvTacgia();
            loadDgvTheloai();
            loadDgvNhaxb();
            loadcbtheloai_Sach();
            loadcbtacgia_Sach();
            loadcbnxb_Sach();
        }
        private void loadDgvSach()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("Select Sach_ID as [Mã sách], Sach_Name as [Tên sách], TG_Name as [Tên tác giả]," +
                "TL_Name as [Thể loại], NXB_Name as [Nhà xuất bản],NamXB as [Năm xuất bản], gia as [Giá bán], GiaNhap as [Giá nhập] from Sach A join Tacgia B on A.TG_ID = B.TG_ID;");
            dt = dataProvider.execQuery(query.ToString());
            dgvSach.DataSource = dt;
        }
        private void loadcbtacgia_Sach()
        {
            DataTable dt = new DataTable();
            dt = dataProvider.execQuery("select * from Tacgia");
            cbTacgia.DisplayMember = "TG_Name";
            cbTacgia.ValueMember = "TG_ID";
            cbTacgia.DataSource = dt;
        }
        private void loadcbtheloai_Sach()
        {
            DataTable dt = new DataTable();
            dt = dataProvider.execQuery("select * from Theloai");
            cbTheloai.DisplayMember = "TL_Name";
            cbTheloai.ValueMember = "TL_Name";
            cbTheloai.DataSource = dt;
        }
        private void loadcbnxb_Sach()
        {
            DataTable dt = new DataTable();
            dt = dataProvider.execQuery("select * from NhaXB");
            cbNhaXB.DisplayMember = "NXB_Name";
            cbNhaXB.ValueMember = "NXB_Name";
            cbNhaXB.DataSource = dt;
        }
        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) rowID = 0;
            if (rowID == dgvSach.RowCount - 1) rowID = rowID - 1;
            DataGridViewRow row = dgvSach.Rows[rowID];
            NoNotificationID = 1;
            txtSachID.Text = row.Cells[0].Value.ToString();
            NoNotificationID = 0;
            txtSachName.Text = row.Cells[1].Value.ToString();
            cbTacgia.Text = row.Cells[2].Value.ToString();
            cbTheloai.Text = row.Cells[3].Value.ToString();
            cbNhaXB.Text = row.Cells[4].Value.ToString();
            TimeNamXB.Value = Convert.ToDateTime(row.Cells[5].Value);
            numGia.Value = Convert.ToInt32(row.Cells[6].Value);


        }
        private void cbTheloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            stTheloai = comboBox.SelectedValue.ToString();
        }
        private void cbTacgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            string query = "Select TG_ID from Tacgia where TG_Name = N'" + cbTacgia.Text + "'";
            DataTable data = dataProvider.execQuery(query);
            if (data.Rows.Count > 0)
            {
                stTacgia = data.Rows[0]["TG_ID"].ToString();
            }
            else
            {
                stTacgia = ""; // Gán giá trị mặc định khi không tìm thấy dữ liệu
            }
        }
        private void cbNhaXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            stNhaxb = comboBox.SelectedValue.ToString();
        }


        //Quản lý sách
        //Kiểm tra mã sách có tồn tại không
        private bool IsMaSachExists(string maSach)
        {
            bool isExists = false;
            StringBuilder query = new StringBuilder("SELECT Sach_ID FROM Sach WHERE Sach_ID = '" + txtSachID.Text + "'");

            DataTable result = dataProvider.execQuery(query.ToString());
            if (result.Rows.Count > 0)
            {
                isExists = true;
            }

            return isExists;
        }

        private void btnAddSach_Click(object sender, EventArgs e)
        {
            if (!IsMaSachExists(txtSachID.Text))
            {
                if (txtSachID.Text == "" || txtSachName.Text == "" || cbTacgia.Text == "" || cbTheloai.Text == "" || cbNhaXB.Text == "")
                {
                    MessageBox.Show("Vui lòng điền thông tin!", "THÔNG BÁO");
                }
                else
                {
                    if (Convert.ToInt32(numGia.Value) > Convert.ToInt32(numGianhap.Value))
                    {
                        DateTime namxb = TimeNamXB.Value;
                        StringBuilder query = new StringBuilder("EXEC pro_them_sach");
                        query.Append(" @masach = '" + txtSachID.Text + "'");
                        query.Append(",@tensach = N'" + txtSachName.Text + "'");
                        query.Append(",@matg = N'" + stTacgia + "'");
                        query.Append(",@theloai = N'" + stTheloai + "'");
                        query.Append(",@nhaxb = N'" + stNhaxb + "'");
                        query.Append(",@gia = " + numGia.Value);
                        query.Append(",@gianhap = " + numGianhap.Value);
                        query.Append(",@namxb = '" + namxb.ToString("yyyy-MM-dd") + "'");
                        query.Append(",@sl = '" + 0);

                        int result = dataProvider.execNonQuery(query.ToString());


                        if (result > 0)
                        {
                            loadDgvSach();
                            MessageBox.Show("Thêm sách thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Thêm sách không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giá nhập không được lớn hơn giá bán!", "Thông báo", MessageBoxButtons.OK);
                    }
                    
                }
            }
            else
            {
                txtSachID.Text = "";
                txtSachName.Text = "";
                MessageBox.Show("Mã sách đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
            }
            
        }
        private void btnUpdateSach_Click(object sender, EventArgs e)
        {
            if (txtSachID.Text == "" || txtSachName.Text == "" || cbTacgia.Text == "" || cbTheloai.Text == "" || cbNhaXB.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin!", "THÔNG BÁO");
            }
            else
            {
                if (Convert.ToInt32(numGia.Value) > Convert.ToInt32(numGianhap.Value))
                {

                    DateTime namxb = TimeNamXB.Value;
                    StringBuilder query = new StringBuilder("EXEC pro_capnhap_sach");
                    query.Append(" @masach = '" + txtSachID.Text + "'");
                    query.Append(",@tensach = N'" + txtSachName.Text + "'");
                    query.Append(",@matg = N'" + stTacgia + "'");
                    query.Append(",@theloai = N'" + stTheloai + "'");
                    query.Append(",@nhaxb = N'" + stNhaxb + "'");
                    query.Append(",@gia = " + numGia.Value);
                    query.Append(",@namxb = '" + namxb.ToString("yyyy-MM-dd") + "'");

                    int result = dataProvider.execNonQuery(query.ToString());
                    if (result > 0)
                    {
                        loadDgvSach();
                        MessageBox.Show("Cập nhập sách thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhập sách không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Giá nhập không được lớn hơn giá bán!", "Thông báo", MessageBoxButtons.OK);
                }

            }
        }
        private void btnDeleteSach_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa sách " + txtSachName.Text + " ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                string query = "DELETE FROM Sach WHERE Sach_ID = '" + txtSachID.Text + "'";
                int result = dataProvider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    loadDgvSach();
                    MessageBox.Show("Xóa sách thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Xóa sách không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnSearchSach_Click(object sender, EventArgs e)
        {
            // Lấy giá trị tìm kiếm từ TextBox hoặc các điều khiển tương tự
            string keyword = txtSachID.Text.Trim();

            // Tạo câu truy vấn SQL để tìm kiếm sách có tên hoặc thông tin liên quan chứa keyword
            StringBuilder query = new StringBuilder("Select Sach_ID as [Mã sách], Sach_Name as [Tên sách], TG_Name as [Tên tác giả]," +
                "TL_Name as [Thể loại], NXB_Name as [Nhà xuất bản], NamXB as [Năm xuất bản], gia as [Giá bán] from Sach A join Tacgia B on A.TG_ID = B.TG_ID " +
                "where Sach_ID like '%" + keyword + "%'");

            // Thực hiện truy vấn
            DataTable dt = dataProvider.execQuery(query.ToString());

            // Hiển thị kết quả tìm kiếm trên DataGridView
            dgvSach.DataSource = dt;
        }



        private void loadDgvTacgia()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("Select TG_ID as [Mã tác giả], TG_Name as [Tên tác giả], Namsinh as [Năm sinh]," +
                "Quequan as [Quê quán] from Tacgia;");
            dt = dataProvider.execQuery(query.ToString());
            dgvTacgia.DataSource = dt;
        }
        private void dgvTacgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) rowID = 0;
            if (rowID == dgvTacgia.RowCount - 1) rowID = rowID - 1;
            DataGridViewRow row = dgvTacgia.Rows[rowID];
            NoNotificationID = 1;
            txtTGID.Text = row.Cells[0].Value.ToString();
            NoNotificationID = 0;
            txtTGName.Text = row.Cells[1].Value.ToString();
            Timenamsinh.Value = Convert.ToDateTime(row.Cells[2].Value);
            txtQuequan.Text = row.Cells[3].Value.ToString();
        }
        private bool IsMaTacgiaExists(string matg)
        {
            bool isExists = false;
            StringBuilder query = new StringBuilder("SELECT TG_ID FROM Tacgia WHERE TG_ID = '" + txtTGID.Text + "'");

            DataTable result = dataProvider.execQuery(query.ToString());
            if (result.Rows.Count > 0)
            {
                isExists = true;
            }

            return isExists;
        }
        private void btnAddTG_Click(object sender, EventArgs e)
        {
            if (!IsMaTacgiaExists(txtTGID.Text))
            {
                if (txtTGID.Text == "" || txtTGName.Text == "" || txtQuequan.Text == "")
                {
                    MessageBox.Show("Vui lòng điền thông tin!", "THÔNG BÁO");
                }
                else
                {
                    DateTime namsinh = Timenamsinh.Value;
                    StringBuilder query = new StringBuilder("EXEC pro_them_tacgia");
                    query.Append(" @matg = '" + txtTGID.Text + "'");
                    query.Append(",@tentg = N'" + txtTGName.Text + "'");
                    query.Append(",@ngaysinh = '" + namsinh.ToString("yyyy-MM-dd") + "'");
                    query.Append(",@quequan = N'" + txtQuequan.Text + "'");

                    int result = dataProvider.execNonQuery(query.ToString());
                    if (result > 0)
                    {
                        loadcbtacgia_Sach();
                        loadDgvTacgia();
                        MessageBox.Show("Thêm tác giả thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Thêm tác giả không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                txtTGID.Text = "";
                txtTGName.Text = "";
                txtQuequan.Text = "";
                MessageBox.Show("Mã tác giả đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void btnUpdateTG_Click(object sender, EventArgs e)
        {
            string checkQuery = "SELECT COUNT(*) FROM Sach WHERE TG_ID = '" + txtTGID.Text + "'";
            DataTable checkResult = dataProvider.execQuery(checkQuery);
            int count = Convert.ToInt32(checkResult.Rows[0][0]);

            if (count > 0)
            {
                MessageBox.Show("Không thể cập nhật vì tác giả này có sách trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DateTime ngaysinh = Timenamsinh.Value;
                StringBuilder query = new StringBuilder("EXEC pro_capnhap_tacgia");
                query.Append(" @matg = '" + txtTGID.Text + "'");
                query.Append(",@tentg = N'" + txtTGName.Text + "'");
                query.Append(",@ngaysinh = '" + ngaysinh.ToString("yyyy-MM-dd") + "'");
                query.Append(",@quequan = N'" + txtQuequan.Text + "'");


                int result = dataProvider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    loadcbtacgia_Sach();
                    loadDgvTacgia();
                    MessageBox.Show("Cập nhập tác giả thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Cập nhập tác giả không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnDeleteTG_Click(object sender, EventArgs e)
        {
            string checkQuery = "SELECT COUNT(*) FROM Sach WHERE TG_ID = '" + txtTGID.Text + "'";
            DataTable checkResult = dataProvider.execQuery(checkQuery);
            int count = Convert.ToInt32(checkResult.Rows[0][0]);

            if (count > 0)
            {
                MessageBox.Show("Không thể xóa vì tác giả này có sách trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả " + txtTGName.Text + " ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    string query = "DELETE FROM Tacgia WHERE TG_ID = '" + txtTGID.Text + "'";
                    int result = dataProvider.execNonQuery(query.ToString());
                    if (result > 0)
                    {
                        loadcbtacgia_Sach();
                        loadDgvTacgia();
                        MessageBox.Show("Xóa tác giả thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Xóa tác giả không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnSearchTG_Click(object sender, EventArgs e)
        {
            string keyword = txtTGID.Text;
            // Tạo câu truy vấn SQL để tìm kiếm tác giả có tên hoặc thông tin liên quan chứa keyword
            StringBuilder query = new StringBuilder("Select TG_ID as [Mã tác giả], TG_Name as [Tên tác giả], Namsinh  as [Năm sinh]," +
                "Quequan as [Quê quán] from Tacgia " +
                "where TG_ID like '%" + keyword + "%'");

            // Thực hiện truy vấn
            DataTable dt = dataProvider.execQuery(query.ToString());

            // Hiển thị kết quả tìm kiếm trên DataGridView
            dgvTacgia.DataSource = dt;
        }


        //Thể loại
        private void loadDgvTheloai()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("Select TL_Name as [Thể loại] from Theloai;");
            dt = dataProvider.execQuery(query.ToString());
            dgvTheloai.DataSource = dt;
        }
        private void dgvTheloai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) rowID = 0;
            if (rowID == dgvTheloai.RowCount - 1) rowID = rowID - 1;
            DataGridViewRow row = dgvTheloai.Rows[rowID];
            txtTheloai.Text = row.Cells[0].Value.ToString();
        }
        private bool IsMaTheloaiExists(string tentl)
        {
            bool isExists = false;
            StringBuilder query = new StringBuilder("SELECT TL_Name FROM Theloai WHERE TL_Name = N'" + txtTheloai.Text + "'");

            DataTable result = dataProvider.execQuery(query.ToString());
            if (result.Rows.Count > 0)
            {
                isExists = true;
            }

            return isExists;
        }
        private void btnAddTL_Click(object sender, EventArgs e)
        {
            if (!IsMaTheloaiExists(txtTheloai.Text))
            {
                if (txtTheloai.Text == "")
                {
                    MessageBox.Show("Vui lòng điền thông tin!", "THÔNG BÁO");
                }
                else
                {
                    StringBuilder query = new StringBuilder("EXEC pro_them_theloai");
                    query.Append(" @tentl = N'" + txtTheloai.Text + "'");

                    int result = dataProvider.execNonQuery(query.ToString());
                    if (result > 0)
                    {

                        loadcbtheloai_Sach();
                        loadDgvTheloai();
                        MessageBox.Show("Thêm thể loại thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thể loại không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                txtTheloai.Text = "";
                MessageBox.Show("Thể loại này đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void btnDeleteTL_Click(object sender, EventArgs e)
        {
            string checkQuery = "SELECT COUNT(*) FROM Sach WHERE TL_Name = N'" + txtTheloai.Text + "'";
            DataTable checkResult = dataProvider.execQuery(checkQuery);
            int count = Convert.ToInt32(checkResult.Rows[0][0]);

            if (count > 0)
            {
                MessageBox.Show("Không thể xóa vì thể loại này có sách trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa thể loại " + txtTheloai.Text + " ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    string query = "DELETE FROM Theloai WHERE TL_Name = N'" + txtTheloai.Text + "'";
                    int result = dataProvider.execNonQuery(query.ToString());
                    if (result > 0)
                    {
                        loadcbtheloai_Sach();
                        loadDgvTheloai();
                        MessageBox.Show("Xóa thể loại thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thể loại không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void loadDgvNhaxb()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("Select NXB_Name as [Tên Nhà xuất bản] from NhaXB;");
            dt = dataProvider.execQuery(query.ToString());
            dgvNXB.DataSource = dt;
        }
        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) rowID = 0;
            if (rowID == dgvNXB.RowCount - 1) rowID = rowID - 1;
            DataGridViewRow row = dgvNXB.Rows[rowID];
            txtNhaxb.Text = row.Cells[0].Value.ToString();
        }
        private bool IsMaNXBExists(string tennxb)
        {
            bool isExists = false;
            StringBuilder query = new StringBuilder("SELECT NXB_Name FROM NhaXB WHERE NXB_Name = N'" + txtNhaxb.Text + "'");

            DataTable result = dataProvider.execQuery(query.ToString());
            if (result.Rows.Count > 0)
            {
                isExists = true;
            }

            return isExists;
        }
        private void btnAddNXB_Click(object sender, EventArgs e)
        {
            if (!IsMaNXBExists(txtNhaxb.Text))
            {
                if (txtNhaxb.Text == "")
                {
                    MessageBox.Show("Vui lòng điền thông tin!", "THÔNG BÁO");
                }
                else
                {
                    StringBuilder query = new StringBuilder("EXEC pro_them_nhaxb");
                    query.Append(" @tennxb = N'" + txtNhaxb.Text + "'");

                    int result = dataProvider.execNonQuery(query.ToString());
                    if (result > 0)
                    {
                        loadcbnxb_Sach();
                        loadDgvNhaxb();
                        MessageBox.Show("Thêm nhà xuất bản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhà xuất bản không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                txtNhaxb.Text = "";
                MessageBox.Show("Nhà xuất bản này đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
            }
            
        }

        private void btnDeleteNXB_Click(object sender, EventArgs e)
        {
            string checkQuery = "SELECT COUNT(*) FROM Sach WHERE NXB_Name = N'" + txtNhaxb.Text + "'";
            DataTable checkResult = dataProvider.execQuery(checkQuery);
            int count = Convert.ToInt32(checkResult.Rows[0][0]);

            if (count > 0)
            {
                MessageBox.Show("Không thể xóa vì nhà xuất bản này có sách trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà xuất bản " + txtNhaxb.Text + " ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    string query = "DELETE FROM NhaXB WHERE NXB_Name = N'" + txtNhaxb.Text + "'";
                    int result = dataProvider.execNonQuery(query.ToString());
                    if (result > 0)
                    {
                        loadcbnxb_Sach();
                        loadDgvNhaxb();
                        MessageBox.Show("Xóa nhà xuất bản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhà xuất bản không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool IsMaSachIDExists(string SachID)
        {
            string query = "Select count(*) from Sach where Sach_ID = '" + SachID + "'";

            int count = Convert.ToInt32(dataProvider.execScalar(query));
            return count > 0;
        }
        private bool IsMaTGIDExists(string TGID)
        {
            string query = "Select count(*) from Tacgia where TG_ID = '" + TGID + "'";

            int count = Convert.ToInt32(dataProvider.execScalar(query));
            return count > 0;
        }
        private void txtSachID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSachID.Text) && NoNotificationID == 0)
            {
                if (IsMaSachIDExists(txtSachID.Text))
                {
                    MessageBox.Show("Mã sách đã tồn tại trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtTGID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTGID.Text) && NoNotificationID == 0)
            {
                if (IsMaTGIDExists(txtTGID.Text))
                {
                    MessageBox.Show("Mã tác giả đã tồn tại trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
