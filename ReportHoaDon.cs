using Microsoft.Reporting.WinForms;
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
    public partial class ReportHoaDon : Form
    {
        private DataProvider dataProvider = new DataProvider();
        public ReportHoaDon()
        {
            InitializeComponent();
        }
        string mahd;
        public ReportHoaDon(string mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
        }

        private void ReportHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("EXEC pro_In_cthd @mahd = '" + mahd + "'");

            dt = dataProvider.execQuery(query.ToString());

            reportViewer1.LocalReport.ReportPath = "ReportCTHD.rdlc";

            ReportDataSource rds = new ReportDataSource("DataSetCTHD", dt);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }
    }
}
