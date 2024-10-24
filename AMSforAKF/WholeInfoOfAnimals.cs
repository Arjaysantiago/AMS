using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMSforAKF
{
    public partial class WholeInfoOfAnimals : Form
    {
        string connectionString = "Data Source=DESKTOP-A6GPOLU\\SQLEXPRESS;Initial Catalog=DatabaseforAms;Integrated Security=True;TrustServerCertificate=True";
        private int animalID;
        private string name;
        private string species;
        private string breed;
        private string gender;
        private int age;
        private string medicalCondition;
        private string possibleTreatment;
        private string notes;
        private DateTime treatmentDate;
        private string treatmentTime;

        public WholeInfoOfAnimals(int animalID) 
        {
            InitializeComponent();
            this.animalID = animalID; 
            LoadAnimalData();
        }
        private void LoadAnimalData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT a.AnimalName, a.Species, a.Breed, a.Gender, a.Age, 
                                            t.MedicalCondition, t.PossibleTreatment, t.Notes, 
                                            t.TreatmentDate, t.TreatmentTime
                                     FROM AnimalfromVet AS a
                                     LEFT JOIN Treatments AS t ON a.AnimalID = t.AnimalID
                                     WHERE a.AnimalID = @AnimalID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@AnimalID", animalID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        name = reader["AnimalName"].ToString();
                        species = reader["Species"].ToString();
                        breed = reader["Breed"].ToString();
                        gender = reader["Gender"].ToString();
                        age = reader.IsDBNull(4) ? 0 : Convert.ToInt32(reader["Age"]);
                        medicalCondition = reader["MedicalCondition"].ToString();
                        possibleTreatment = reader["PossibleTreatment"].ToString();
                        notes = reader["Notes"].ToString();
                        treatmentDate = reader.IsDBNull(8) ? DateTime.MinValue : Convert.ToDateTime(reader["TreatmentDate"]);
                        treatmentTime = reader["TreatmentTime"].ToString();

                        PopulateFields(); 
                    }
                    else
                    {
                        MessageBox.Show("No data found for the selected animal.");
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the animal data: " + ex.Message);
            }
        }

        private void PopulateFields()
        {
            txtName.Text = name;
            txtSpecies.Text = species;
            txtBreed.Text = breed;
            txtGender.Text = gender;
            txtAge.Text = age.ToString();
            txtMedicalCondition.Text = medicalCondition;
            txtTreatments.Text = possibleTreatment;
            txtNotes.Text = notes;
            txtDate.Text = treatmentDate.ToShortDateString();
            txtTime.Text = treatmentTime;
        }

        public void AddToAdoptables()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string selectQuery = @"SELECT AnimalID, AnimalName, Species, Breed, Gender, Age, RescuerName, RescuerContact 
                                           FROM AnimalfromVet WHERE AnimalID = @AnimalID";
                    SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                    selectCmd.Parameters.AddWithValue("@AnimalID", animalID);

                    SqlDataReader reader = selectCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string name = reader["AnimalName"].ToString();
                        string species = reader["Species"].ToString();
                        string breed = reader["Breed"].ToString();
                        string gender = reader["Gender"].ToString();
                        int age = Convert.ToInt32(reader["Age"]);
                        string rescuerName = reader["RescuerName"].ToString();
                        string rescuerContact = reader["RescuerContact"].ToString();

                        reader.Close();

                        string insertAdoptablesQuery = @"INSERT INTO Adoptables (AnimalID, AnimalName, Species, Breed, Gender, Age,
                                                        RescuerName, RescuerContact, MedicalCondition, PossibleTreatment, Notes, DateAdded) 
                                                        VALUES (@AnimalID, @AnimalName, @Species, @Breed, @Gender, @Age,
                                                        @RescuerName, @RescuerContact, @MedicalCondition, @PossibleTreatment, @Notes, @DateAdded)";
                        using (SqlCommand insertCmd = new SqlCommand(insertAdoptablesQuery, con))
                        {
                            insertCmd.Parameters.AddWithValue("@AnimalID", animalID);
                            insertCmd.Parameters.AddWithValue("@AnimalName", name);
                            insertCmd.Parameters.AddWithValue("@Species", species);
                            insertCmd.Parameters.AddWithValue("@Breed", breed);
                            insertCmd.Parameters.AddWithValue("@Gender", gender);
                            insertCmd.Parameters.AddWithValue("@Age", age);
                            insertCmd.Parameters.AddWithValue("@RescuerName", rescuerName);
                            insertCmd.Parameters.AddWithValue("@RescuerContact", rescuerContact);
                            insertCmd.Parameters.AddWithValue("@MedicalCondition", medicalCondition);
                            insertCmd.Parameters.AddWithValue("@PossibleTreatment", possibleTreatment);
                            insertCmd.Parameters.AddWithValue("@Notes", notes);
                            insertCmd.Parameters.AddWithValue("@DateAdded", DateTime.Now);

                            insertCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Animal successfully transferred to adoptables!");
                    }
                    else
                    {
                        MessageBox.Show("Animal not found in AnimalfromVet.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void WholeInfoOfAnimals_Load(object sender, EventArgs e)
        {
            PopulateFields();
        }

        private void btnAddtoAdoptables_Click(object sender, EventArgs e)
        {
            AddToAdoptables(); 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
