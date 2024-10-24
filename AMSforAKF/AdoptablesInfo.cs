using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMSforAKF
{
    public partial class AdoptablesInfo : Form
    {
        private AnimalDetails animalDetails;

        public AdoptablesInfo(AnimalDetails details)
        {
            InitializeComponent();
            animalDetails = details;
            DisplayAnimalDetails();
        }
        private void DisplayAnimalDetails()
        {
            txtName.Text = animalDetails.AnimalName;
            txtSpecies.Text = animalDetails.Species;
            txtBreed.Text = animalDetails.Breed;
            txtGender.Text = animalDetails.Gender;
            txtAge.Text = animalDetails.Age.ToString();
            txtDate.Text = animalDetails.Date.ToShortDateString();
            txtTime.Text = animalDetails.Time.ToString(@"hh\:mm");

            rtbMedCon.Text = animalDetails.MedicalCondition;
            txtTreat.Text = animalDetails.Treatment;
            rtbNotes.Text = animalDetails.Notes;
        }

        private void SaveToAdoptionArchive()
        {
            string connectionString = "Data Source=DESKTOP-A6GPOLU\\SQLEXPRESS;Initial Catalog=DatabaseforAms;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO AdoptionArchive 
                                 (ClientID, AnimalName, Breed, AdoptionDate, Notes) 
                                 VALUES (@ClientID, @AnimalName, @Breed, @AdoptionDate, @Notes)";

                SqlCommand cmd = new SqlCommand(query, conn);

                int clientId = GetClientId();

                cmd.Parameters.AddWithValue("@ClientID", clientId);
                cmd.Parameters.AddWithValue("@AnimalName", animalDetails.AnimalName);
                cmd.Parameters.AddWithValue("@Breed", animalDetails.Breed);
                cmd.Parameters.AddWithValue("@AdoptionDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@Notes", "Adopted Successfully");

                cmd.ExecuteNonQuery();
            }
        }
        private void btnAdopt_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm(animalDetails);
            clientForm.ShowDialog();
            SaveToAdoptionArchive();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int GetClientId()
        {
            return 1; 
        }
    }
}
