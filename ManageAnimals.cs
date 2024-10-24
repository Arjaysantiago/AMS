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
    public partial class ManageAnimals : Form
    {
        public ManageAnimals()
        {
            InitializeComponent();
        }
        private void btnMedic_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmAMS fm = new frmAMS();
            fm.Show();
            this.Hide();
        }
        private void btnAdoption_Click(object sender, EventArgs e)
        {
            CreateReport ap = new CreateReport();
            ap.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            AnimalsLibrary animalsLibrary = new AnimalsLibrary();
            animalsLibrary.Show();
            this.Hide();
        }

        private void btnAddAnimals_Click_1(object sender, EventArgs e)
        {
            AnimalProfile ap = new AnimalProfile();
            ap.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnIntake_Click(object sender, EventArgs e)
        {
            AnimalIntakeOverview ap = new AnimalIntakeOverview();
            ap.ShowDialog();
        }
        public void UpdateNotificationForAnimalIntake()
        {
            lblAnimalIntakeNotification.Text = "New Animal Intake Records Available!";
            lblAnimalIntakeNotification.Visible = true;
        }
    }
}
