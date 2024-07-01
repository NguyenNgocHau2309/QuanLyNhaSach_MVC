using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class PhieuNhap : Form
    {
        private DataProvider dataProvider = new DataProvider();
        string maNV_codinh, mapn, masachCTPN;
        List<string> SachAdd_UpdateCTPN = new List<string>();
        int slnoupdate = 0, rowCTPN = 0;
        public PhieuNhap()
        {
            InitializeComponent();
        }

        public PhieuNhap(string username)
        {
            InitializeComponent();

            maNV_codinh = username;

            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("select NV_Name from Nhanvien where NV_ID = '" + maNV_codinh + "'");
            dt = dataProvider.execQuery(query.ToString());

            txtTenNV.Text = dt.Rows[0][0].ToString();
            txtTenNV.ReadOnly = true;
            init();

            cbNVID_add.Text = username;
            cbNVID_update.Text = username;
            cbNVID_add.Enabled = false;
            cbNVID_update.Enabled = false;
        }
        // Load form
        private void init()
        {
            kho();
            loadDgvPhieunhap();
            loaddgvCTPN();
            loadDgvSach();
            loadcbCTHD();

            AddCheckBoxColumn(dgvSach);
            UpdateCheckBoxes(dgvSach);
        }
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
        private void loaddgvCTPN()
        {
            dgvCTPN.Columns.Add("Mã sách", "Mã sách");
            dgvCTPN.Columns.Add("Tên sách", "Tên sách");
            dgvCTPN.Columns.Add("Số lượng", "Số lượng");
            dgvCTPN.Columns.Add("Tổng tiền", "Tổng tiền");
        }
        private void DgvCTPN(string Idphieunhap)
        {
            dgvCTPN.Rows.Clear();
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("Select A.Sach_ID as [Mã sách], Sach_Name as [Tên sách], A.Soluong as [Số lượng], A.Soluong * B.GiaNhap as [Tổng tiền]" +
            " from CTPN A join Sach B on A.Sach_ID = B.Sach_ID " +
            "where PN_ID = '" + Idphieunhap + "'");
            dt = dataProvider.execQuery(query.ToString());
            foreach (DataRow row in dt.Rows)
            {
                string maSach = row["Mã sách"].ToString();
                string tenSach = row["Tên sách"].ToString();
                string soLuong = row["Số lượng"].ToString();
                string tongTien = row["Tổng tiền"].ToString();

                dgvCTPN.Rows.Add(maSach, tenSach, soLuong, tongTien);
            }
        }
        private void loadcbCTHD()
        {
            DataTable dt = new DataTable();
            if (maNV_codinh.Contains("admin"))
            {
                dt = dataProvider.execQuery("select * from Phieunhap");
                cbMaPN.DisplayMember = "PN_ID";
                cbMaPN.ValueMember = "PN_ID";
                cbMaPN.DataSource = dt;
            }
            else
            {
                dt = dataProvider.execQuery("select * from Phieunhap where NV_ID = '" + maNV_codinh + "'");
                cbMaPN.DisplayMember = "PN_ID";
                cbMaPN.ValueMember = "PN_ID";
                cbMaPN.DataSource = dt;
            }
        }
        private void loadDgvPhieunhap()
        {
            DataTable dt = new DataTable();
            if (maNV_codinh.Contains("admin"))
            {
                StringBuilder query = new StringBuilder("Select PN_ID as [Mã PN], NV_ID as [Mã NV], " +
                "Ngaylap as [Ngày lập], Tongtien as [Tổng tiền] from Phieunhap");
                dt = dataProvider.execQuery(query.ToString());
                dgvPhieunhap.DataSource = dt;
            }
            else
            {
                StringBuilder query = new StringBuilder("Select PN_ID as [Mã PN], NV_ID as [Mã NV], " +
                "Ngaylap as [Ngày lập], Tongtien as [Tổng tiền] from Phieunhap where NV_ID = '" + maNV_codinh + "'");
                dt = dataProvider.execQuery(query.ToString());
                dgvPhieunhap.DataSource = dt;
            }

        }
        private void loadDgvSach()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("Select Sach_ID as [Mã sách], Sach_Name as [Tên sách], GiaNhap as [Giá nhập] from Sach;");
            dt = dataProvider.execQuery(query.ToString());
            dgvSach.DataSource = dt;
        }
        //Hiển thị nội dung cột hóa đơn và CTHD
        private void dgvPhieunhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) rowID = 0;
            if (rowID == dgvPhieunhap.RowCount - 1) rowID = rowID - 1;
            DataGridViewRow row = dgvPhieunhap.Rows[rowID];
            cbNVID_update.Text = row.Cells[1].Value.ToString();
            timeLapPN_update.Value = Convert.ToDateTime(row.Cells[2].Value);
            mapn = row.Cells[0].Value.ToString();
            DgvCTPN(mapn);
            cbMaPN.Text = mapn;
            rowCTPN = dgvCTPN.RowCount;
        }
        private void btnCTPN_Click(object sender, EventArgs e)
        {
            DgvCTPN(cbMaPN.Text);
        }
        private void ResetCheckBoxes(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;
                checkBoxCell.Value = false;
            }
            numSL.Value = 50;
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

            StringBuilder query = new StringBuilder("select Soluong from CTPN where Sach_ID = '" + masach + "' and PN_ID = '" + mapn + "'");
            DataTable dt = dataProvider.execQuery(query.ToString());
            int slCTPN = (int)dt.Rows[0][0];
            int slKho = GetCurrentStock("Sach", masach);
            if (slCTPN > soluong)
            {
                UpdateStock(masach, slKho - (slCTPN - soluong));
            }
            else if (slCTPN < soluong)
            {
                UpdateStock(masach, slKho + (soluong - slCTPN));
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



        private void ThemSachCTPN()
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
                    string giaNhap = row.Cells["Giá nhập"].Value.ToString();
                    int soLuong = Convert.ToInt32(numSL.Value);
                    int slkho = GetCurrentStock("Sach", maSach);

                    if(slkho > 400)
                    {
                        MessageBox.Show("Số lượng sách vượt quá chỉ tiêu không được nhập. Vui kiểm tra hàng cần nhập bên kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ThemSachKho(maSach, soLuong);
                        //Gán mã sách đã chọn vào biến mã sách để thêm sách tring trường hợp sửa CTHD
                        SachAdd_UpdateCTPN.Add(maSach);

                        // Thêm sách vào chi tiết hóa đơn
                        ThemSachExistsCTHD(maSach, tenSach, giaNhap, soLuong);
                    }
                    

                }
            }

            if (coHangDuocChon)
            {
                ResetCheckBoxes(dgvSach);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách trước khi thêm vào phiếu nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ThemSachExistsCTHD(string maSach, string tenSach, string giaNhap, int soLuong)
        {
            // Kiểm tra số lượng sách đã nhập
            if (soLuong == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool found = false;
            foreach (DataGridViewRow dgvRow in dgvCTPN.Rows)
            {
                if (dgvRow.Cells["Mã sách"].Value != null && dgvRow.Cells["Mã sách"].Value.ToString() == maSach)
                {
                    int soLuongCu = Convert.ToInt32(dgvRow.Cells["Số lượng"].Value);
                    dgvRow.Cells["Số lượng"].Value = soLuongCu + soLuong;

                    decimal giaNhapCu = Convert.ToDecimal(giaNhap);
                    decimal tongTienCu = Convert.ToDecimal(dgvRow.Cells["Tổng tiền"].Value);
                    dgvRow.Cells["Tổng tiền"].Value = (soLuongCu + soLuong) * giaNhapCu;

                    found = true;
                    break;
                }
            }
            if (!found)
            {
                dgvCTPN.Rows.Add(maSach, tenSach, soLuong, soLuong * Convert.ToDecimal(giaNhap));
            }
        }
        private void btnChonSach_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem có hàng nào trong cthd k, nếu có thì thêm sách đang là sửa lại CTHD trong hóa đơn đã có
            if (rowCTPN > 0)
            {
                ThemSachCTPN();
            }
            //Nếu không thì chúng ta chọn sách là đang tạo hóa đơn
            else if (txtPNID_add.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập thông tin hóa đơn trước khi thêm sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                ThemSachCTPN();
            }
        }

        //Tạo phiếu nhập
        private void btnCreatePN_Click(object sender, EventArgs e)
        {
            if (txtPNID_add.Text == "" || cbNVID_add.Text == "" || dgvCTPN.RowCount == 1)
            {
                MessageBox.Show("Vui lòng điền thông tin hoặc chưa có chi tiết phiếu nhập!", "THÔNG BÁO");
            }
            else
            {
                DateTime ngaylap = TimeLapPN_add.Value;
                StringBuilder query = new StringBuilder("EXEC pro_them_phieunhap");
                query.Append(" @mapn = '" + txtPNID_add.Text + "'");
                query.Append(", @manv = '" + cbNVID_add.Text + "'");
                query.Append(", @ngaylap = '" + ngaylap.ToString("yyyy-MM-dd") + "'");
                query.Append(", @tongtien = '" + CalculateTotal().ToString() + "'");

                int result1 = dataProvider.execNonQuery(query.ToString());
                int result2;

                foreach (DataGridViewRow dgvRow in dgvCTPN.Rows)
                {
                    if (dgvRow.Cells["Mã sách"].Value != null && dgvRow.Cells["Số lượng"].Value != null && dgvRow.Cells["Tổng tiền"].Value != null)
                    {
                        query = new StringBuilder("EXEC pro_them_ctpn");
                        query.Append(" @mapn = '" + txtPNID_add.Text + "'");
                        query.Append(", @masach = '" + dgvRow.Cells["Mã sách"].Value.ToString() + "'");
                        query.Append(", @soluong = '" + dgvRow.Cells["Số lượng"].Value.ToString() + "'");
                        query.Append(", @thanhtien = '" + dgvRow.Cells["Tổng tiền"].Value.ToString() + "'");

                        result2 = dataProvider.execNonQuery(query.ToString());
                    }
                }


                if (result1 > 0)
                {
                    dgvCTPN.Rows.Clear();
                    txtPNID_add.Text = "";
                    loadDgvPhieunhap();
                    MessageBox.Show("Tạo phiếu nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool IsPNIDExists(string pnID)
        {
            string query = "Select count(*) from Phieunhap where PN_ID = '" + pnID + "'";

            int count = Convert.ToInt32(dataProvider.execScalar(query));
            return count > 0;
        }
        //Khi nhập ô id phiếu nhập nếu đã có tồn tại thì hiển thị thông báo
        private void txtPNID_add_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPNID_add.Text))
            {
                dgvCTPN.Rows.Clear();
            }
            if (!string.IsNullOrEmpty(txtPNID_add.Text))
            {
                if (IsPNIDExists(txtPNID_add.Text))
                {
                    MessageBox.Show("Mã phiếu nhập đã tồn tại trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbMaPN.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập cần xóa!", "Thông báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool canDelete = true;

                    foreach (DataGridViewRow dgvRow in dgvCTPN.Rows)
                    {
                        if (dgvRow.Cells["Mã sách"].Value != null && dgvRow.Cells["Số lượng"].Value != null)
                        {
                            string maSach = dgvRow.Cells["Mã sách"].Value.ToString();
                            int slXoa = Convert.ToInt32(dgvRow.Cells["Số lượng"].Value);
                            int slkho = GetCurrentStock("Sach", maSach);

                            if (slkho < slXoa)
                            {
                                MessageBox.Show("Số lượng kho không đủ nếu xóa phiếu nhập này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                canDelete = false;
                                break;
                            }
                        }
                    }

                    if (canDelete)
                    {
                        foreach (DataGridViewRow dgvRow in dgvCTPN.Rows)
                        {
                            if (dgvRow.Cells["Mã sách"].Value != null && dgvRow.Cells["Số lượng"].Value != null)
                            {
                                string maSach = dgvRow.Cells["Mã sách"].Value.ToString();
                                int slXoa = Convert.ToInt32(dgvRow.Cells["Số lượng"].Value);
                                LaySachKho(maSach, slXoa);
                            }
                        }

                        string query = "DELETE FROM CTPN WHERE PN_ID = '" + cbMaPN.Text + "'";
                        int rowsAffected1 = dataProvider.execNonQuery(query);
                        query = "DELETE FROM Phieunhap WHERE PN_ID = '" + cbMaPN.Text + "'";
                        int rowsAffected2 = dataProvider.execNonQuery(query);

                        if (rowsAffected1 > 0 && rowsAffected2 > 0)
                        {
                            dgvCTPN.Rows.Clear();
                            loadDgvPhieunhap();
                            MessageBox.Show("Xóa phiếu nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("không tìm thấy phiếu nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }




        //Sửa phiếu nhập
        private void dgvCTPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) rowID = 0;
            if (rowID == dgvCTPN.RowCount - 1) rowID = rowID - 1;
            DataGridViewRow row = dgvCTPN.Rows[rowID];
            numSL.Value = Convert.ToInt32(row.Cells[2].Value);
            //Kiểm tra xem biến số lượng có thay đổi không
            slnoupdate = Convert.ToInt32(row.Cells[2].Value);
            masachCTPN = row.Cells[0].Value.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbNVID_update.Text == "")
            {
                MessageBox.Show("Vui lòng nhân viên cần cập nhật!", "Thông báo");
            }
            else
            {
                string maPN = mapn;

                if (dgvCTPN.RowCount < rowCTPN)
                {
                    //Trường hợp này là sửa hóa đơn khi xóa sách 
                    //Vì khi xóa sách đã xóa trong CTHD rồi nên khi Cập nhập lại CTHD sẽ bị sai
                    UpdatePhieunhap(maPN);
                }
                else if (dgvCTPN.RowCount > rowCTPN)//kiểm tra xem dgvCTHD có thêm hàng nào không
                {
                    //Trường hợp này là sửa hóa đơn khi thêm sách bắt buộc phải cập nhập lại CTHD
                    int result = 0;
                    foreach (string maSach in SachAdd_UpdateCTPN)
                    {
                        foreach (DataGridViewRow dgvRow in dgvCTPN.Rows)
                        {
                            if (dgvRow.Cells["Mã sách"].Value == maSach && dgvRow.Cells["Số lượng"].Value != null && dgvRow.Cells["Tổng tiền"].Value != null)
                            {
                                StringBuilder query = new StringBuilder("EXEC pro_them_ctpn");
                                query.Append(" @mapn = '" + maPN + "'");
                                query.Append(", @masach = '" + dgvRow.Cells["Mã sách"].Value.ToString() + "'");
                                query.Append(", @soluong = '" + dgvRow.Cells["Số lượng"].Value.ToString() + "'");
                                query.Append(", @thanhtien = '" + dgvRow.Cells["Tổng tiền"].Value.ToString() + "'");

                                result = dataProvider.execNonQuery(query.ToString());
                            }
                        }
                    }
                    SachAdd_UpdateCTPN.Clear();
                    if (result > 0)
                    {
                        UpdatePhieunhap(maPN);
                    }
                    else
                    {
                        MessageBox.Show("Thêm sách không thành công!", "Thông báo");
                    }

                }
                else
                {
                    string query = "SELECT Ngaylap FROM Phieunhap where PN_ID = '" + maPN + "'";
                    DataTable data = dataProvider.execQuery(query);
                    DateTime ngaylapCSDL = Convert.ToDateTime(data.Rows[0][0]);
                    if (timeLapPN_update.Value != ngaylapCSDL)
                    {
                        //Trường hợp này sửa hóa đơn khi thay đổi thông tin hóa đơn mà không thay đổi thông tin CTPN
                        UpdatePhieunhap(maPN);
                    }
                    else
                    {
                        int slkho = GetCurrentStock("Sach", masachCTPN);
                        int slCTPN = GetCurrentStock("CTPN", masachCTPN);
                        if (slCTPN > (int)numSL.Value && slkho < (slCTPN - (int)numSL.Value))
                        {
                            MessageBox.Show("Không thể thay đổi số lượng nhập vì số lượng kho còn đủ số lượng để bù", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            SuaSachKho(masachCTPN, (int)numSL.Value);
                            //Trường hợp này là sửa hóa đơn khi sửa sách bắt buộc phải cập nhập lại CTHD
                            UpdateCTPN(maPN, masachCTPN, (int)numSL.Value);
                        }


                    }
                }
            }
        }
        private void UpdatePhieunhap(string maPN)
        {
            decimal Tongtien = CalculateTotal();
            DateTime ngaylap = timeLapPN_update.Value;
            StringBuilder query = new StringBuilder("EXEC pro_capnhap_phieunhap");
            query.Append(" @mapn = '" + maPN + "'");
            query.Append(", @manv = '" + cbNVID_update.Text + "'");
            query.Append(", @ngaylap = '" + ngaylap.ToString("yyyy-MM-dd") + "'");
            query.Append(", @tongtien = '" + Convert.ToString(Tongtien) + "'");
            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadDgvPhieunhap();
                MessageBox.Show("Cập nhật phiếu nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Cập nhật phiếu nhập không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateCTPN(string maPN, string masach, int soluong)
        {
            StringBuilder query = new StringBuilder("EXEC pro_capnhap_ctpn");
            query.Append(" @mapn = '" + maPN + "'");
            query.Append(", @masach = '" + masach + "'");
            query.Append(", @soluong = '" + soluong + "'");

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                DgvCTPN(maPN);
                UpdatePhieunhap(maPN);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin chi tiết phiếu nhập không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private decimal CalculateTotal()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow dgvRow in dgvCTPN.Rows)
            {
                if (dgvRow.Cells["Mã sách"].Value != null && dgvRow.Cells["Số lượng"].Value != null && dgvRow.Cells["Tổng tiền"].Value != null)
                {
                    tongTien += Convert.ToDecimal(dgvRow.Cells["Tổng tiền"].Value);
                }
            }
            return tongTien;
        }


        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (dgvCTPN.SelectedCells.Count > 0)
            {
                // Lấy chỉ số hàng của ô được chọn
                int rowIndex = dgvCTPN.SelectedCells[0].RowIndex;

                // Lấy mã sách của dòng được chọn
                string masach = dgvCTPN.Rows[rowIndex].Cells["Mã sách"].Value.ToString();

                //cập nhập kho
                int slkho = GetCurrentStock("Sach", masach);
                int soluong = Convert.ToInt32(dgvCTPN.Rows[rowIndex].Cells["Số lượng"].Value);
                if (slkho > soluong)
                {
                    LaySachKho(masach, soluong);
                    // Xóa dòng được chọn trong DataGridView
                    dgvCTPN.Rows.RemoveAt(rowIndex);

                    // Thực hiện xóa sách khỏi CTHD trong cơ sở dữ liệu
                    string query = "DELETE FROM CTPN WHERE PN_ID = '" + mapn + "' AND Sach_ID = '" + masach + "'";

                    int result = dataProvider.execNonQuery(query.ToString());

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa sách khỏi chi tiết phiếu nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Cập nhật tổng tiền của hóa đơn
                        if (txtPNID_add == null)
                        {
                            UpdatePhieunhap(mapn);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa sách khỏi chi tiết phiếu nhập không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sách này không thể xóa được vì số lượng kho không còn đủ số lượng xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void kho(bool checkQuantity = false)
        {
            DataTable dt = new DataTable();
            string query = "SELECT Sach_ID as [Mã sách], Sach_Name as [Tên sách], Soluong as [Số lượng tồn] from Sach";
            if (checkQuantity)
            {
                query += " WHERE Soluong < 50";
            }

            dt = dataProvider.execQuery(query);
            dgvKho.DataSource = dt;
        }
        private void btCheckkho_Click(object sender, EventArgs e)
        {
            kho(true);
        }



        private void numSL_ValueChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem giá trị có nằm trong khoảng từ 50 đến 300 không
            if (numSL.Value < 50)
            {
                MessageBox.Show("Giá trị không được nhỏ hơn 50", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numSL.Value = 50; // Đặt lại giá trị về 50 nếu nhỏ hơn 50
            }
            else if (numSL.Value > 300)
            {
                MessageBox.Show("Giá trị không được lớn hơn 300", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numSL.Value = 300; // Đặt lại giá trị về 300 nếu lớn hơn 300
            }
        }

    }
}