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
    public partial class AnimalIntakeOverview : Form
    {
        string connectionString = "data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\webapp\\Animal Management System\\DatabaseAKF.mdf;Integrated Security=True;Connect Timeout=30";
        private int lastRecordCount = 0;
        public AnimalIntakeOverview()
        {
            InitializeComponent();
        }

        private void AnimalIntakeOverview_Load(object sender, EventArgs e)
        {
            LoadAnimalIntakeData();
            timerCheckForNewData.Start();
        }
        private void LoadAnimalIntakeData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM AnimalIntake", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewAnimalIntakeOverview.DataSource = dt;
                lastRecordCount = dt.Rows.Count;
            }
        }
        private void timerCheckForNewData_Tick(object sender, EventArgs e)
        {
            CheckForNewAnimalIntakeData();
        }
        private void CheckForNewAnimalIntakeData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM AnimalIntake", conn);
                conn.Open();
                int currentRecordCount = (int)cmd.ExecuteScalar();

                if (currentRecordCount > lastRecordCount)
                {
                    ShowAdminNotification(currentRecordCount - lastRecordCount);
                    LoadAnimalIntakeData();
                }
            }
        }
        private void ShowAdminNotification(int newRecordCount)
        {
            MessageBox.Show($"{newRecordCount} new animal intake record(s) have been added.", "New Animal Intake Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NotifyAdminDashboard();
        }
        private void NotifyAdminDashboard()
        {

            WelcomeAdmin welcome = Application.OpenForms["WelcomeAdmin"] as WelcomeAdmin;

            if (welcome != null)
            {
                welcome.UpdateNotificationForAnimalIntake();
            }

            ManageAnimals manage = Application.OpenForms["ManageAnimals"] as ManageAnimals;
            if (manage != null)
            {
                manage.UpdateNotificationForAnimalIntake();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
