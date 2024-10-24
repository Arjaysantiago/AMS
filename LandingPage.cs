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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(btnLogin_KeyDown);
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string name = txtuname.Text;
            string pass = txtpword.Text;

            if (name.Equals("Admin") && pass.Equals("Admin1234"))
            {
                this.Hide();
                AdminInterface am = new AdminInterface();
                am.Show();
            }
            else if (name.Equals("") && pass.Equals(""))
            {
                MessageBox.Show("Please fill All Information");
            }
            else
            {
                MessageBox.Show("The username or password is incorrect!");
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void llblemployeelogin_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmAMS fb = new frmAMS();
            fb.Show();
        }
    }
}
