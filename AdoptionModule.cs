using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Animal_Management_System
{
    public partial class AdoptionModule : Form
    {
        public AdoptionModule(int reportId)
        {
            InitializeComponent();
            LoadAnimals();
        }

        private void LoadAnimals()
        {
            string connectionString = "data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\webapp\\Animal Management System\\DatabaseAKF.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT * FROM Animals";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                AnimalsView.DataSource = dt;
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            string clientName = txtName.Text;
            string clientAddress = txtAddress.Text;
            string clientPhone = txtPhone.Text;
            string clientEmail = txtEmail.Text;

            string selectedAnimal = "";
            if (AnimalsView.SelectedRows.Count > 0)
            {
                selectedAnimal = AnimalsView.SelectedRows[0].Cells["Name"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select an animal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManageAnimals ma = new ManageAnimals();
            ma.Show();
            this.Hide();
        }
    }
}