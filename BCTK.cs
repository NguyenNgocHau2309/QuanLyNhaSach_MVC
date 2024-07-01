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
    public partial class BCTK : Form
    {
        private DataProvider dataProvider = new DataProvider();
        public BCTK()
        {
            InitializeComponent();
        }
        public BCTK(string username)
        {
            InitializeComponent();
            txtusername.Text = username;
            txtusername.Enabled = true;
            txtusername.ReadOnly = true;
        }
        private void btThongke_Click(object sender, EventArgs e)
        {
            DateTime timeStart = TimeStart.Value;
            DateTime timeEnd = TimeEnd.Value;

            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("SELECT s.Sach_ID as [Mã sách], s.Sach_Name as [Tên sách], SUM(cthd.Soluong) as [Số lượng], SUM(cthd.Soluong * s.gia) as [Tổng tiền]");
            query.Append(" FROM Hoadon hd JOIN CTHD cthd ON hd.HD_ID = cthd.HD_ID JOIN Sach s ON cthd.Sach_ID = s.Sach_ID");
            query.Append(" WHERE hd.NgayLap BETWEEN '" + timeStart.ToString() + "'");
            query.Append(" AND '" + timeEnd.ToString() + "'");
            query.Append(" GROUP BY s.Sach_ID, s.Sach_Name");

            dt = dataProvider.execQuery(query.ToString());
            dgvTKBC.DataSource = dt;

            int soluong = 0;
            decimal tongTien = 0;
            foreach (DataGridViewRow dgvrow in dgvTKBC.Rows)
            {
                if (dgvrow.Cells["Số lượng"].Value != null)
                {
                    soluong += Convert.ToInt32(dgvrow.Cells["Số lượng"].Value);
                }

                if (dgvrow.Cells["Tổng tiền"].Value != null)
                {
                    tongTien += Convert.ToDecimal(dgvrow.Cells["Tổng tiền"].Value);
                }
            }

            txtSoluong.Text = soluong.ToString();
            txtDoanhthu.Text = tongTien.ToString();
        }

        private void btXuatBC_Click(object sender, EventArgs e)
        {
            DateTime start = TimeStart.Value;
            DateTime end = TimeEnd.Value;
            ReportBaocao f = new ReportBaocao(start, end);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

    }
}
