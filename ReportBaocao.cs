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
    public partial class ReportBaocao : Form
    {
        private DataProvider dataProvider = new DataProvider();
        public ReportBaocao()
        {
            InitializeComponent();
        }
        DateTime start,end;
        public ReportBaocao(DateTime start, DateTime end)
        {
            InitializeComponent();
            this.start = start;
            this.end = end;
        }

        private void ReportBaocao_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("EXEC pro_In_baocao @start = '" + start + "', @end = '" + end + "'");

            dt = dataProvider.execQuery(query.ToString());

            reportViewer1.LocalReport.ReportPath = "ReportBC.rdlc";

            ReportDataSource rds = new ReportDataSource("DataSetDoanhthu", dt);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }
    }
}
