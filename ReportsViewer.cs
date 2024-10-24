using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Animal_Management_System
{
    public partial class ReportsViewer : Form
    {
        public ReportsViewer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("data source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\user\\source\\repos\\webapp\\Animal Management System\\DatabaseAKF.mdf;");
        private void ReportsViewer_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Animals", con);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DatabaseAkf",dt);
            reportViewer1.LocalReport.ReportPath = "Animals.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }
    }
}
