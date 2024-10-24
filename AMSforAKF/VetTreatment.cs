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

namespace AMSforAKF
{
    public partial class VetTreatment : Form
    {
        private string connectionString = "Data Source=DESKTOP-A6GPOLU\\SQLEXPRESS;Initial Catalog=\"Animals Management System for Animal Kingdom Foundation\";Integrated Security=True;TrustServerCertificate=True";
        public VetTreatment()
        {
            InitializeComponent();
            LoadServices();
            LoadMedicines();
        }
        private decimal CalculateTotalCost()
        {
            decimal serviceCost = 0;
            decimal medicineCost = 0;

            string selectedService = cmbServices.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedService))
            {
                serviceCost = GetServiceCost(selectedService);
            }
            string selectedMedicine = cmbMedicines.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedMedicine))
            {
                medicineCost = GetMedicineCost(selectedMedicine);
            }

            return serviceCost + medicineCost;
        }
        private decimal GetServiceCost(string serviceName)
        {
            decimal cost = 0;

            string query = "SELECT TOP 1 [price] FROM [Services] WHERE [ServiceName] = @ServiceName";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ServiceName", serviceName);

                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        cost = Convert.ToDecimal(result);
                    }
                }
            }

            return cost;
        }
        private decimal GetMedicineCost(string medicineName)
        {
            decimal cost = 0;

            string query = "SELECT TOP 1 [price] FROM [Medicines] WHERE [name] = @MedicineName";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MedicineName", medicineName);

                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        cost = Convert.ToDecimal(result);
                    }
                }
            }

            return cost;
        }
        private void SaveToDatabase(decimal totalCost)
        {
            string query = "INSERT INTO MedicalRecords (AnimalName, Age, Species, Breed, OwnerName, Implications, Service, Medicine, TreatmentDate, TotalCost) " +
                           "VALUES (@AnimalName, @Age, @Species, @Breed, @OwnerName, @Implications, @Service, @Medicine, @TreatmentDate, @TotalCost)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AnimalName", txtName.Text);
                    cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                    cmd.Parameters.AddWithValue("@Species", txtSpecies.Text);
                    cmd.Parameters.AddWithValue("@Breed", txtBreed.Text);
                    cmd.Parameters.AddWithValue("@OwnerName", txtOwnerName.Text);
                    cmd.Parameters.AddWithValue("@Implications", txtImplications.Text);
                    cmd.Parameters.AddWithValue("@Service", cmbServices.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@Medicine", cmbMedicines.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@TreatmentDate", dtDate.Value);
                    cmd.Parameters.AddWithValue("@TotalCost", totalCost);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void LoadServices()
        {
            string query = "SELECT [ServiceName] FROM [Services]";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbServices.Items.Add(reader["ServiceName"].ToString());
                    }
                }
            }
        }
        private void LoadMedicines()
        {
            string query = "SELECT [name] FROM [Medicines]";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbMedicines.Items.Add(reader["name"].ToString());
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            decimal totalCost = CalculateTotalCost();
            lblTotalCost.Text = $"Total Cost: {totalCost:C}";

            SaveToDatabase(totalCost);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal totalCost = CalculateTotalCost();
            lblTotalCost.Text = $"Total Cost: {totalCost:C}";

            SaveToDatabase(totalCost);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {

        }
    }
}
