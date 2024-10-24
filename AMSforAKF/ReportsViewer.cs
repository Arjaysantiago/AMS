using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMSforAKF
{
    public partial class ReportsViewer : Form
    {
        public ReportsViewer()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
        public ReportDocument ReportSource
        {
            set
            {
                crystalReportViewer1.ReportSource = value;
                crystalReportViewer1.Refresh();
            }
        }
        private void ReportsViewer_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
        }
    }
}
