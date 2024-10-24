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
    public partial class AnimalR_T : Form
    {
        public int AnimalID { get; private set; }
        public AnimalR_T()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                string animalName = txtName.Text;
                string species = txtSpecies.Text;
                string breed = txtBreed.Text;
                int age = int.Parse(txtAge.Text);
                string rescuerName = txtRescuer.Text;
                string rescuerContact = txtContact.Text;

                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\user\\source\\repos\\webapp\\Animal Management System\\DatabaseAKF.mdf\";Integrated Security=True"))
                {
                    conn.Open();

                    string animalQuery = "INSERT INTO Animals (AnimalName, Species, Breed, Age, RescuerName, RescuerContact) " +
                                         "VALUES (@AnimalName, @Species, @Breed, @Age, @RescuerName, @RescuerContact); " +
                                         "SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(animalQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@AnimalName", animalName);
                        cmd.Parameters.AddWithValue("@Species", species);
                        cmd.Parameters.AddWithValue("@Breed", breed);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@RescuerName", rescuerName);
                        cmd.Parameters.AddWithValue("@RescuerContact", rescuerContact);

                        AnimalID = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    AddTreatmentForm treatmentForm = new AddTreatmentForm(AnimalID);
                    treatmentForm.Show();
                    this.Close(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

