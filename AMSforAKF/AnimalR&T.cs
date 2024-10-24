using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMSforAKF
{
    public partial class AnimalR_T : Form
    {
        public int AnimalID { get; private set; }

        public AnimalR_T()
        {
            InitializeComponent();
            cmbSpecies.SelectedIndexChanged += cmbSpecies_SelectedIndexChanged;
        }
        private void cmbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBreed.Items.Clear();
            if (cmbSpecies.Text == "Dog")
            {
                cmbBreed.Items.AddRange(new string[] { "Labrador Retriever", "German Shepherd", "Bulldog", "Beagle", "Poodle", "Askal" });
            }
            else if (cmbSpecies.Text == "Cat")
            {
                cmbBreed.Items.AddRange(new string[] { "Siamese", "Persian", "Maine Coon", "Ragdoll", "Bengal" });
            }
            if (cmbBreed.Items.Count > 0)
            {
                cmbBreed.SelectedIndex = 0;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                string animalName = txtName.Text;
                string species = cmbSpecies.Text;
                string breed = cmbBreed.Text;
                string gender = cmbGender.Text;
                int age = int.Parse(txtAge.Text);
                string rescuerName = txtRescuer.Text;
                string rescuerContact = txtContact.Text;

                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-A6GPOLU\\SQLEXPRESS;Initial Catalog=DatabaseforAms;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();

                    string animalQuery = "INSERT INTO AnimalfromVet (AnimalName, Species, Breed, Gender, Age, RescuerName, RescuerContact) " +
                                         "VALUES (@AnimalName, @Species, @Breed, @Gender, @Age, @RescuerName, @RescuerContact); " +
                                         "SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(animalQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@AnimalName", animalName);
                        cmd.Parameters.AddWithValue("@Species", species);
                        cmd.Parameters.AddWithValue("@Breed", breed);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@RescuerName", rescuerName);
                        cmd.Parameters.AddWithValue("@RescuerContact", rescuerContact);

                        AnimalID = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    txtName.Clear();
                    txtAge.Clear();
                    txtContact.Clear();
                    txtRescuer.Clear();
                    cmbBreed.Items.Clear();
                    cmbGender.Items.Clear();
                    cmbSpecies.Items.Clear(); 
                    AddTreatmentForm treatmentForm = new AddTreatmentForm(AnimalID);
                    treatmentForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Exception Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}