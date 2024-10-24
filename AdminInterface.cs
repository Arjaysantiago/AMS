using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal_Management_System
{
    public partial class AdminInterface : Form
    {
        bool isAdminDisplayed = true;
        public AdminInterface()
        {
            this.IsMdiContainer = true;
            InitializeComponent();
        }
        private void CloseAllMdiChildren()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }
        private void AdminInterface_Load(object sender, EventArgs e)
        {
           
        }   
        private void sidebarcontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebarcontainer_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAccounts_Click_1(object sender, EventArgs e)
        {
            CloseAllMdiChildren();
            AccountManagement am = new AccountManagement()
            { 
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            am.Dock = DockStyle.Fill;
            am.Show();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            CloseAllMdiChildren();
            WelcomeAdmin welcomeAdmin = new WelcomeAdmin() {
                MdiParent = this, 
                WindowState = FormWindowState.Maximized
            };
            welcomeAdmin.Dock = DockStyle.Fill;
            welcomeAdmin.Show();
            
        }

        private void btnReports_Click_1(object sender, EventArgs e)
        {
            CloseAllMdiChildren();
            ReportsModule reportModule = new ReportsModule() { 
            MdiParent = this,
            WindowState = FormWindowState.Maximized};
            reportModule.Dock = DockStyle.Fill;
            reportModule.Show();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            LandingPage lp = new LandingPage();
            lp.Show();
            this.Hide();
        }

        private void AdminInterface_Load_1(object sender, EventArgs e)
        {
            CloseAllMdiChildren();
            WelcomeAdmin welcomeAdmin = new WelcomeAdmin() { MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            welcomeAdmin.Dock = DockStyle.Fill;
            welcomeAdmin.Show();
        }
    }
}
