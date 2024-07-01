using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace QuanLyNhaSach
{
    public partial class HoaDon : Form
    {
        private DataProvider dataProvider = new DataProvider();
        string maNV_codinh, masachCTHD, mahd = "";
        List<string> maSachAdd_UpdateCTHD = new List<string>();
        int slnoupdate = 0, rowCTHD = 0;
        public HoaDon()
        {
            InitializeComponent();
        }
        public HoaDon(string username)
        {
            InitializeComponent();
            maNV_codinh = username;
            init();
            cbNVID_add.Text = username;
            cbNVID_update.Text = username;
            cbNVID_add.Enabled = false;
            cbNVID_update.Enabled = false;
        }
        // Để thêm cột CheckBox vào DataGridView
        private void AddCheckBoxColumn(DataGridView dataGridView)
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Chọn";
            checkBoxColumn.Name = "checkBoxColumn";
            dataGridView.Columns.Insert(0, checkBoxColumn);
        }
        // Để cập nhật trạng thái checkbox dựa trên dữ liệu
        private void UpdateCheckBoxes(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)row.Cells["checkBoxColumn"];
                checkBox.Value = false; // Set giá trị ban đầu cho checkbox là false (không chọn)
            }
        }

        // Đặt lại các checkbox, chỉ cho phép chọn một hàng tại một thời điểm
        private void ResetCheckBoxes(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;
                checkBoxCell.Value = false;
            }
            numSL.Value = 1;
        }

        // Load form
        private void init()
        {
            loadDgvHoadon();
            loadDgvSach();
            loadcbKHID_update();
            loadcbKHID_add();
            loaddgvCTHD();

            AddCheckBoxColumn(dgvSach);
            UpdateCheckBoxes(dgvSach);
        }
        private void loaddgvCTHD()
        {
            dgvCTHD.Columns.Add("Mã sách", "Mã sách");
            dgvCTHD.Columns.Add("Tên sách", "Tên sách");
            dgvCTHD.Columns.Add("Số lượng", "Số lượng");
            dgvCTHD.Columns.Add("Tổng tiền", "Tổng tiền");
        }
        private void DgvCTHD(string Idhoadon)
        {
            dgvCTHD.Rows.Clear();
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("Select A.Sach_ID as [Mã sách], Sach_Name as [Tên sách], A.Soluong as [Số lượng], A.Soluong * B.gia as [Tổng tiền]" +
            " from CTHD A join Sach B on A.Sach_ID = B.Sach_ID " +
            "where HD_ID = '" + Idhoadon + "'");
            dt = dataProvider.execQuery(query.ToString());
            foreach (DataRow row in dt.Rows)
            {
                string maSach = row["Mã sách"].ToString();
                string tenSach = row["Tên sách"].ToString();
                string soLuong = row["Số lượng"].ToString();
                string tongTien = row["Tổng tiền"].ToString();

                // Thêm thông tin về sách vào dgvCTHD
                dgvCTHD.Rows.Add(maSach, tenSach, soLuong, tongTien);
            }
        }
        private void loadcbCTHD()
        {
            DataTable dt = new DataTable();
            if (maNV_codinh.Contains("admin"))
            {
                dt = dataProvider.execQuery("select * from Hoadon");
                cbMaHD.DisplayMember = "HD_ID";
                cbMaHD.ValueMember = "HD_ID";
                cbMaHD.DataSource = dt;
            }
            else
            {
                dt = dataProvider.execQuery("select * from Hoadon where NV_ID = '" + maNV_codinh + "'");
                cbMaHD.DisplayMember = "HD_ID";
                cbMaHD.ValueMember = "HD_ID";
                cbMaHD.DataSource = dt;
            }
        }
        private void loadDgvHoadon()
        {
            DataTable dt = new DataTable();
            if (maNV_codinh.Contains("admin"))
            {
                StringBuilder query = new StringBuilder("Select HD_ID as [Mã HD], KH_ID as [Mã KH], NV_ID as [Mã NV]," +
               "Ngaylap as [Ngày lập], Tongtien as [Tổng tiền] from Hoadon ;");
                dt = dataProvider.execQuery(query.ToString());
                dgvHoadon.DataSource = dt;
                loadcbCTHD();
            }
            else
            {
                StringBuilder query = new StringBuilder("Select HD_ID as [Mã HD], KH_ID as [Mã KH], NV_ID as [Mã NV]," +
                "Ngaylap as [Ngày lập], Tongtien as [Tổng tiền] from Hoadon where NV_ID = '" + maNV_codinh + "'");
                dt = dataProvider.execQuery(query.ToString());
                dgvHoadon.DataSource = dt;
                loadcbCTHD();
            }
        }
        private void loadcbKHID_add()
        {
            DataTable dt = new DataTable();
            dt = dataProvider.execQuery("select * from Khachhang");
            cbKHID_add.DisplayMember = "KH_ID";
            cbKHID_add.ValueMember = "KH_ID";
            cbKHID_add.DataSource = dt;
        }
        private void loadcbKHID_update()
        {
            DataTable dt = new DataTable();
            dt = dataProvider.execQuery("select * from Khachhang");
            cbKHID_update.DisplayMember = "KH_ID";
            cbKHID_update.ValueMember = "KH_ID";
            cbKHID_update.DataSource = dt;
        }
        private void loadtxtTenKH(string maHD)
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("Select C.KH_Name " +
                "from CTHD A join Hoadon B on B.HD_ID = A.HD_ID join " +
                "Khachhang C on C.KH_ID = B.KH_ID where B.HD_ID = '" + maHD + "'");
            dt = dataProvider.execQuery(query.ToString());

            // Kiểm tra xem DataTable có dữ liệu không
            if (dt.Rows.Count > 0)
            {
                // Lấy giá trị từ dòng đầu tiên của cột KH_Name
                string tenKH = dt.Rows[0]["KH_Name"].ToString();

                // Gán giá trị vào TextBox
                txtTenKH.Text = tenKH;
            }
            else
            {
                txtTenKH.Text = ""; // Nếu không có dữ liệu, gán giá trị rỗng cho TextBox
            }
        }
        private void loadDgvSach()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("Select Sach_ID as [Mã sách], Sach_Name as [Tên sách], gia as [Giá bán] from Sach;");
            dt = dataProvider.execQuery(query.ToString());
            dgvSach.DataSource = dt;
        }

        //Hiển thị nội dung cột hóa đơn và CTHD
        private void dgvHoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) rowID = 0;
            if (rowID == dgvHoadon.RowCount - 1) rowID = rowID - 1;
            DataGridViewRow row = dgvHoadon.Rows[rowID];
            cbNVID_update.Text = row.Cells[2].Value.ToString();
            cbKHID_update.Text = row.Cells[1].Value.ToString();
            timeLapHD_update.Value = Convert.ToDateTime(row.Cells[3].Value);
            mahd = row.Cells[0].Value.ToString();
            DgvCTHD(mahd);
            loadtxtTenKH(mahd);
            cbMaHD.Text = mahd;
            //Kiểm tra xem dgvCTHD có bao nhiu hàng để khi thêm vào CTHD đã có
            rowCTHD = dgvCTHD.RowCount;
        }
        private void btnCTHD_Click(object sender, EventArgs e)
        {
            DgvCTHD(cbMaHD.Text);
        }

        //

        //Thêm hóa đơn
        private void ThemSachCTHD()
        {
            bool coHangDuocChon = false;
            foreach (DataGridViewRow row in dgvSach.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(checkBoxCell.Value))
                {
                    coHangDuocChon = true;

                    string maSach = row.Cells["Mã sách"].Value.ToString();
                    string tenSach = row.Cells["Tên sách"].Value.ToString();
                    string giaBan = row.Cells["Giá bán"].Value.ToString();
                    int soLuong = Convert.ToInt32(numSL.Value);
                    int slkho = GetCurrentStock("Sach", maSach);
                    if(slkho < soLuong)
                    {
                        MessageBox.Show("Hàng này hiện tại đang hết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        LaySachKho(maSach, soLuong);
                        //Gán mã sách đã chọn vào biến mã sách để thêm sách tring trường hợp sửa CTHD
                        maSachAdd_UpdateCTHD.Add(maSach);

                        // Thêm sách vào chi tiết hóa đơn
                        ThemSachExistsCTHD(maSach, tenSach, giaBan, soLuong);
                    }
                }
            }

            if (coHangDuocChon)
            {
                ResetCheckBoxes(dgvSach);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách trước khi thêm vào hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ThemSachExistsCTHD(string maSach, string tenSach, string giaBan, int soLuong)
        {
            // Kiểm tra số lượng sách đã nhập
            if (soLuong == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool found = false;
            foreach (DataGridViewRow dgvRow in dgvCTHD.Rows)
            {
                if (dgvRow.Cells["Mã sách"].Value != null && dgvRow.Cells["Mã sách"].Value.ToString() == maSach)
                {
                    int soLuongCu = Convert.ToInt32(dgvRow.Cells["Số lượng"].Value);
                    dgvRow.Cells["Số lượng"].Value = soLuongCu + soLuong;

                    decimal giaBanCu = Convert.ToDecimal(giaBan);
                    decimal tongTienCu = Convert.ToDecimal(dgvRow.Cells["Tổng tiền"].Value);
                    dgvRow.Cells["Tổng tiền"].Value = (soLuongCu + soLuong) * giaBanCu;

                    found = true;
                    break;
                }
            }
            if (!found)
            {
                dgvCTHD.Rows.Add(maSach, tenSach, soLuong, soLuong * Convert.ToDecimal(giaBan));
            }
        }
        private void btnChonSach_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem có hàng nào trong cthd k, nếu có thì thêm sách đang là sửa lại CTHD trong hóa đơn đã có
            if (rowCTHD > 0)
            {
                ThemSachCTHD();
            }
            //Nếu không thì chúng ta chọn sách là đang tạo hóa đơn
            else if (txtHDID_add.Text == "" || cbKHID_add.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin hóa đơn trước khi thêm sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                ThemSachCTHD();
            }
        }
        //Gán vào ô tên khách hàng
        private void CapnhapTenKH(ComboBox comboBox)
        {
            if (comboBox.SelectedItem != null)
            {
                string selectedKHID = comboBox.SelectedValue.ToString(); 

                DataTable dt = new DataTable();
                StringBuilder query = new StringBuilder("SELECT KH_Name FROM Khachhang WHERE KH_ID = '" + selectedKHID + "'");
                dt = dataProvider.execQuery(query.ToString());

                if (dt.Rows.Count > 0)
                {
                    string tenKH = dt.Rows[0]["KH_Name"].ToString();

                    txtTenKH.Text = tenKH;
                }
                else
                {
                    txtTenKH.Text = ""; 
                }
            }
            txtTenKH.ReadOnly = true;
        }
        private void cbKHID_add_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapnhapTenKH(cbKHID_add);
        }

        private void cbKHID_update_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapnhapTenKH(cbKHID_update);
        }


        //Cập nhập kho
        private void LaySachKho(string masach, int soluong)
        {
            int slKho = GetCurrentStock("Sach", masach);
            int slmoi = slKho - soluong;
            UpdateStock(masach, slmoi);
        }
        private void ThemSachKho(string masach, int soluong)
        {
            int slKho = GetCurrentStock("Sach", masach);
            int slmoi = slKho + soluong;
            UpdateStock(masach, slmoi);
        }
        private void SuaSachKho(string masach, int soluong)
        {
            StringBuilder query = new StringBuilder("select Soluong from CTHD where Sach_ID = '"+ masach + "' and HD_ID = '" + mahd + "'");
            DataTable dt = dataProvider.execQuery(query.ToString());
            int slCTHD = (int)dt.Rows[0][0];
            int slKho = GetCurrentStock("Sach", masach);

            if (slCTHD > soluong)
            {
                UpdateStock(masach, slKho + (slCTHD - soluong));
            }
            else if (slCTHD < soluong)
            {
                UpdateStock(masach, slKho - (soluong - slCTHD));
            }
        }
        private int GetCurrentStock(string tableName, string masach)
        {
            StringBuilder query = new StringBuilder($"select Soluong from {tableName} where Sach_ID = '{masach}'");
            DataTable dt = dataProvider.execQuery(query.ToString());
            return (int)dt.Rows[0][0];
        }
        private void UpdateStock(string masach, int slMoi)
        {
            StringBuilder query = new StringBuilder("EXEC pro_capnhap_kho");
            query.Append(" @masach = '" + masach + "'");
            query.Append(", @soluong = '" + Convert.ToString(slMoi) + "'");
            int result = dataProvider.execNonQuery(query.ToString());
        }


        //Thêm hóa đơn
        private void btnHoanthanhHD_Click(object sender, EventArgs e)
        {
            if (txtHDID_add.Text == "" || cbKHID_add.Text == "" || dgvCTHD.RowCount == 1)
            {
                MessageBox.Show("Vui lòng điền thông tin!", "THÔNG BÁO");
            }
            else
            {

                DateTime ngaylap = TimeLapHD_add.Value;
                StringBuilder query = new StringBuilder("EXEC pro_them_hoadon");
                query.Append(" @mahd = '" + txtHDID_add.Text + "'");
                query.Append(", @makh = '" + cbKHID_add.Text + "'");
                query.Append(", @manv = '" + cbNVID_add.Text + "'");
                query.Append(", @ngaylap = '" + ngaylap.ToString("yyyy-MM-dd") + "'");
                query.Append(", @tongtien = '" + CalculateTotal().ToString() + "'");

                int result1 = dataProvider.execNonQuery(query.ToString());


                foreach (DataGridViewRow dgvRow in dgvCTHD.Rows)
                {
                    if (dgvRow.Cells["Mã sách"].Value != null && dgvRow.Cells["Số lượng"].Value != null && dgvRow.Cells["Tổng tiền"].Value != null)
                    {
                        query = new StringBuilder("EXEC pro_them_cthd");
                        query.Append(" @mahd = '" + txtHDID_add.Text + "'");
                        query.Append(", @masach = '" + dgvRow.Cells["Mã sách"].Value.ToString() + "'");
                        query.Append(", @soluong = '" + dgvRow.Cells["Số lượng"].Value.ToString() + "'");
                        query.Append(", @thanhtien = '" + dgvRow.Cells["Tổng tiền"].Value.ToString() + "'");

                        int result2 = dataProvider.execNonQuery(query.ToString());

                        LaySachKho(dgvRow.Cells["Mã sách"].Value.ToString(), (int)dgvRow.Cells["Số lượng"].Value);
                    }
                }


                if (result1 > 0)
                {
                    dgvCTHD.Rows.Clear();
                    txtHDID_add.Text = "";
                    loadDgvHoadon();
                    MessageBox.Show("Thêm hóa đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private decimal CalculateTotal()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow dgvRow in dgvCTHD.Rows)
            {
                if (dgvRow.Cells["Mã sách"].Value != null && dgvRow.Cells["Số lượng"].Value != null && dgvRow.Cells["Tổng tiền"].Value != null)
                {
                    tongTien += Convert.ToDecimal(dgvRow.Cells["Tổng tiền"].Value);
                }
            }
            return tongTien;
        }
        private bool IsHDIDExists(string hdID)
        {
            string query = "Select count(*) from Hoadon where HD_ID = '" + hdID + "'";

            int count = Convert.ToInt32(dataProvider.execScalar(query));
            return count > 0;
        }
        //Khi nhập ô id hóa đơn nếu đã có tồn tại thì hiển thị thông báo
        private void txtHDID_add_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHDID_add.Text))
            {
                dgvCTHD.Rows.Clear();
            }
            if (!string.IsNullOrEmpty(txtHDID_add.Text))
            {
                if (IsHDIDExists(txtHDID_add.Text))
                {
                    MessageBox.Show("Mã hóa đơn đã tồn tại trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        //Xóa Hóa đơn
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbMaHD.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa!", "Thông báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    foreach (DataGridViewRow dgvRow in dgvCTHD.Rows)
                    {
                        if (dgvRow.Cells["Mã sách"].Value != null && dgvRow.Cells["Số lượng"].Value != null && dgvRow.Cells["Tổng tiền"].Value != null)
                        {
                            ThemSachKho(dgvRow.Cells["Mã sách"].Value.ToString(), Convert.ToInt32(dgvRow.Cells["Số lượng"].Value));
                        }
                    }
                    string query = "DELETE FROM CTHD WHERE HD_ID = '" + cbMaHD.Text + "'";
                    int rowsAffected1 = dataProvider.execNonQuery(query);
                    query = "DELETE FROM Hoadon WHERE HD_ID = '" + cbMaHD.Text + "'";
                    int rowsAffected2 = dataProvider.execNonQuery(query);

                    if (rowsAffected1 > 0 && rowsAffected2 > 0)
                    {
                        dgvCTHD.Rows.Clear();
                        loadDgvHoadon();
                        MessageBox.Show("Xóa Hóa đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("không tìm thấy hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        //Sửa hóa đơn
        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) rowID = 0;
            if (rowID == dgvCTHD.RowCount - 1) rowID = rowID - 1;
            DataGridViewRow row = dgvCTHD.Rows[rowID];
            numSL.Value = Convert.ToInt32(row.Cells[2].Value);
            //Kiểm tra xem biến số lượng có thay đổi không
            slnoupdate = Convert.ToInt32(row.Cells[2].Value);
            masachCTHD = row.Cells[0].Value.ToString();

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string maKH = cbKHID_update.Text;
            string maNV = cbNVID_update.Text;
            DateTime ngayLap = timeLapHD_update.Value;
            decimal tongTien = CalculateTotal(); // Tính tổng tiền của hóa đơn
                                                 //Kiểm tra xem ô mã nv và mã kh có nội dung không
            if (cbKHID_update.Text == "" || cbNVID_update.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng và nhân viên cần cập nhật!", "Thông báo");
            }
            else
            {
                //Trường hợp này là sửa hóa đơn khi xóa sách 
                //Vì khi xóa sách đã xóa trong CTHD rồi nên khi Cập nhập lại CTHD sẽ bị sai
                if (dgvCTHD.RowCount < rowCTHD)
                {
                    UpdateHoadon(mahd);
                }
                //Trường hợp này là sửa hóa đơn khi thêm sách bắt buộc phải cập nhập lại CTHD
                else if (dgvCTHD.RowCount > rowCTHD)//kiểm tra xem dgvCTHD có thêm hàng nào không
                {
                    int result = 0;
                    foreach (string maSach in maSachAdd_UpdateCTHD)
                    {
                        foreach (DataGridViewRow dgvRow in dgvCTHD.Rows)
                        {
                            if (dgvRow.Cells["Mã sách"].Value == maSach && dgvRow.Cells["Số lượng"].Value != null && dgvRow.Cells["Tổng tiền"].Value != null)
                            {
                                StringBuilder query = new StringBuilder("EXEC pro_them_cthd");
                                query.Append(" @mahd = '" + mahd + "'");
                                query.Append(", @masach = '" + dgvRow.Cells["Mã sách"].Value.ToString() + "'");
                                query.Append(", @soluong = '" + dgvRow.Cells["Số lượng"].Value.ToString() + "'");
                                query.Append(", @thanhtien = '" + dgvRow.Cells["Tổng tiền"].Value.ToString() + "'");

                                result += dataProvider.execNonQuery(query.ToString());
                            }
                        }
                    }
                    maSachAdd_UpdateCTHD.Clear();
                    if (result > 0)
                    {
                        UpdateHoadon(mahd);
                    }
                    else
                    {
                        MessageBox.Show("Thêm sách không thành công!", "Thông báo");
                    }
                }
                //Trường hợp còn lại là sửa hóa đơn khi sửa sách bắt buộc phải cập nhập lại CTHD
                else
                {
                    string query = "SELECT Ngaylap FROM Hoadon where HD_ID = '" + mahd + "'";
                    DataTable data = dataProvider.execQuery(query);
                    DateTime ngaylapCSDL = Convert.ToDateTime(data.Rows[0][0]);
                    string query1 = "SELECT KH_ID FROM Hoadon where HD_ID = '" + mahd + "'";
                    DataTable data1 = dataProvider.execQuery(query1);
                    string KH_CSDL = Convert.ToString(data1.Rows[0][0]);
                    if (timeLapHD_update.Value != ngaylapCSDL || cbKHID_update.Text != KH_CSDL)
                    {
                        //Trường hợp này sửa hóa đơn khi thay đổi thông tin hóa đơn mà không thay đổi thông tin CTPN
                        UpdateHoadon(mahd);
                    }
                    else
                    {
                        int slkho = GetCurrentStock("Sach", masachCTHD);
                        int slCTHD = GetCurrentStock("CTHD", masachCTHD);
                        int slthaydoi = (int)numSL.Value;

                        if (slthaydoi > slCTHD && slkho < (slthaydoi - slCTHD))
                        {
                            MessageBox.Show("Hàng đã hết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            SuaSachKho(masachCTHD, slthaydoi);
                            //Trường hợp này là sửa hóa đơn khi sửa sách bắt buộc phải cập nhập lại CTHD
                            UpdateCTHD(mahd, masachCTHD, slthaydoi);
                        }
                        
                    }
                }
            }
        }


        private void UpdateHoadon(string maHD)
        {
            decimal Tongtien = CalculateTotal();
            DateTime ngaylap = timeLapHD_update.Value;
            StringBuilder query = new StringBuilder("EXEC pro_capnhap_hoadon");
            query.Append(" @mahd = '" + maHD + "'");
            query.Append(", @makh = '" + cbKHID_update.Text + "'");
            query.Append(", @manv = '" + cbNVID_update.Text + "'");
            query.Append(", @ngaylap = '" + ngaylap.ToString("yyyy-MM-dd") + "'");
            query.Append(", @tongtien = '" + Convert.ToString(Tongtien) + "'");
            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadDgvHoadon();
                MessageBox.Show("Cập nhật hóa đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Cập nhật hóa đơn không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCTHD(string maHD, string masach, int soluong)
        {
            StringBuilder query = new StringBuilder("EXEC pro_capnhap_cthd");
            query.Append(" @mahd = '" + maHD + "'");
            query.Append(", @masach = '" + masach + "'");
            query.Append(", @soluong = '" + soluong + "'");

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                DgvCTHD(maHD);
                UpdateHoadon(maHD);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin chi tiết hóa đơn không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (dgvCTHD.SelectedCells.Count > 0)
            {
                // Lấy chỉ số hàng của ô được chọn
                int rowIndex = dgvCTHD.SelectedCells[0].RowIndex;

                // Lấy mã sách của dòng được chọn
                string masach = dgvCTHD.Rows[rowIndex].Cells["Mã sách"].Value.ToString();
                int soluong = Convert.ToInt32(dgvCTHD.Rows[rowIndex].Cells["Số lượng"].Value);
                ThemSachKho(masach, soluong);

                // Xóa dòng được chọn trong DataGridView
                dgvCTHD.Rows.RemoveAt(rowIndex);

                // Thực hiện xóa sách khỏi CTHD trong cơ sở dữ liệu
                string query = "DELETE FROM CTHD WHERE HD_ID = '" + mahd + "' AND Sach_ID = '" + masach + "'";

                int result = dataProvider.execNonQuery(query.ToString());

                if (result > 0)
                {
                    MessageBox.Show("Xóa sách khỏi chi tiết hóa đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Cập nhật tổng tiền của hóa đơn
                    if (txtHDID_add == null)
                    {
                        UpdateHoadon(mahd);
                    }
                }
                else
                {
                    MessageBox.Show("Xóa sách khỏi chi tiết hóa đơn không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            if (mahd == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ReportHoaDon f = new ReportHoaDon(mahd);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

    }
}