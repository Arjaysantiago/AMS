using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal_Management_System
{
    public partial class WelcomeAdmin : Form
    {
        private int notificationCount = 0;
        string connectionString = "data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\webapp\\Animal Management System\\DatabaseAKF.mdf;Integrated Security=True;Connect Timeout=30";
        public WelcomeAdmin()
        {
            InitializeComponent();
            this.Load += new EventHandler(WelcomeAdmin_Load);
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void UpdateNotificationPanel()
        {
            label11.Text = notificationCount.ToString("00");
            if (notificationCount == 0)
            {
                label10.Text = "No notifications at the moment!";
            }
            else
            {
                label10.Text = "There is a Notification for you!";
            }

        }
        private void DisplayReports_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void panel2_paint(object sender, FormClosedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void OpenReportInModule(int reportId)
        {
            ReportsModule reportsModule = new ReportsModule();
            reportsModule.Show();
        }

        private void btnReports_Click_1(object sender, EventArgs e)
        {

        }
        private void LoadPopulationNotifications()
        {
            int animalPopulationCount = GetAnimalPopulationCount();
            lblPopulation.Text = animalPopulationCount.ToString();
        }

        private int GetAnimalPopulationCount()
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Animals"; 
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    count = (int)command.ExecuteScalar();
                }
            }
            return count;
        }

        private void LoadUserNotifications()
        {
            int totalUserCount = GetTotalUserCount();
            lblTotalUsers.Text = totalUserCount.ToString();
        }

        private int GetTotalUserCount()
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Users"; 
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    count = (int)command.ExecuteScalar();
                }
            }
            return count;
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            AnimalsLibrary al = new AnimalsLibrary();
            al.Show();
            this.Close();
        }
        private void LoadPasswordChangeNotifications()
        {
            int passwordChangeCount = GetPasswordChangeCount();
            lblChangePass.Text = passwordChangeCount.ToString();
            lblChangePass.Refresh();
        }

        private int GetPasswordChangeCount()
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM PasswordChanges"; 
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    count = (int)command.ExecuteScalar();
                }
            }
            return count;
        }
        
        private void btnGoToAccounts_Click(object sender, EventArgs e)
        {
            lblChangePass.Text = "00";
            lblChangePass.Refresh();
            ChangeAccounts ca = new ChangeAccounts();
            ca.ShowDialog();
        }

        private void WelcomeAdmin_Load(object sender, EventArgs e)
        {
            LoadPasswordChangeNotifications();
            LoadPopulationNotifications();
            LoadUserNotifications();
        }
        public void UpdateNotificationForAnimalIntake()
        {
            lblAnimalIntakeNotification.Text = "New Animal Intake Records Available!";
            lblAnimalIntakeNotification.Visible = true;
        }
        private void btnGoToOverview_Click(object sender, EventArgs e)
        {
            AnimalIntakeOverview aio = new AnimalIntakeOverview();
            aio.ShowDialog();
        }
    }
}
