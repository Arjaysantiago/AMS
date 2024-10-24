using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AMSforAKF
{
    public partial class AnimalsLibrary : Form
    {
        private SqlConnection sqlConnection;
        private Panel selectedPanel;

        public AnimalsLibrary()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=DESKTOP-A6GPOLU\\SQLEXPRESS;Initial Catalog=DatabaseforAms;Integrated Security=True;TrustServerCertificate=True");
            LoadAnimals();
        }

        private void LoadAnimals()
        {
            try
            {
                sqlConnection.Open();
                string query = @"
                SELECT a.AnimalID, a.AnimalName, a.Species, a.Gender, a.Age, t.TreatmentDate
                FROM AnimalfromVet AS a
                LEFT JOIN Treatments AS t ON a.AnimalID = t.AnimalID";

                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();

                flowPanel1.Controls.Clear();

                while (reader.Read())
                {
                    int animalId = reader.GetInt32(0);
                    string animalName = reader.IsDBNull(1) ? "N/A" : reader.GetString(1);
                    string species = reader.IsDBNull(2) ? "N/A" : reader.GetString(2);
                    string gender = reader.IsDBNull(3) ? "N/A" : reader.GetString(3);
                    int age = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);
                    DateTime treatmentDate = reader.IsDBNull(5) ? DateTime.MinValue : reader.GetDateTime(5);

                    Panel animalPanel = CreateAnimalPanel(animalId, animalName, species, gender, age, treatmentDate);
                    flowPanel1.Controls.Add(animalPanel);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading animals: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void ShowAnimalDetails(int animalId)
        {
            try
            {
                sqlConnection.Open();
                string query = @"
                SELECT a.AnimalName, a.Species, a.Breed, a.Gender, a.Age,
                t.MedicalCondition, t.PossibleTreatment, t.Notes, 
                t.TreatmentDate, t.TreatmentTime
                FROM AnimalfromVet a
                LEFT JOIN Treatments t ON a.AnimalID = t.AnimalID
                WHERE a.AnimalID = @AnimalID";

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@AnimalID", animalId);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string name = reader["AnimalName"]?.ToString() ?? "N/A";
                        string species = reader["Species"]?.ToString() ?? "N/A";
                        string breed = reader["Breed"]?.ToString() ?? "N/A";
                        string gender = reader["Gender"]?.ToString() ?? "N/A";
                        int age = reader["Age"] != DBNull.Value ? Convert.ToInt32(reader["Age"]) : 0;
                        string medicalCondition = reader["MedicalCondition"]?.ToString() ?? "N/A";
                        string treatments = reader["PossibleTreatment"]?.ToString() ?? "N/A";
                        string notes = reader["Notes"]?.ToString() ?? "N/A";
                        DateTime treatmentDate = reader["TreatmentDate"] != DBNull.Value ? Convert.ToDateTime(reader["TreatmentDate"]) : DateTime.MinValue;
                        string treatmentTime = reader["TreatmentTime"]?.ToString() ?? "N/A";

                        // Corrected form initialization, ensure correct parameter type
                        WholeInfoOfAnimals detailsForm = new WholeInfoOfAnimals(animalId);
                        detailsForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No information found for the selected animal.");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving animal details: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public Panel CreateAnimalPanel(int animalId, string animalName, string species, string gender, int age, DateTime dateAdded)
        {
            Panel panel = new Panel
            {
                Width = 150,
                Height = 200,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = animalId
            };

            panel.Controls.Add(new Label { Text = $"Name: {animalName}", Dock = DockStyle.Top, TextAlign = ContentAlignment.MiddleCenter });
            panel.Controls.Add(new Label { Text = $"Species: {species}", Dock = DockStyle.Top, TextAlign = ContentAlignment.MiddleCenter });
            panel.Controls.Add(new Label { Text = $"Gender: {gender}", Dock = DockStyle.Top, TextAlign = ContentAlignment.MiddleCenter });
            panel.Controls.Add(new Label { Text = $"Age: {age}", Dock = DockStyle.Top, TextAlign = ContentAlignment.MiddleCenter });
            panel.Controls.Add(new Label { Text = $"Date Added: {dateAdded.ToShortDateString()}", Dock = DockStyle.Top, TextAlign = ContentAlignment.MiddleCenter });

            panel.Click += AnimalPanel_Click;

            return panel;
        }

        private void AnimalPanel_Click(object sender, EventArgs e)
        {
            if (sender is Panel clickedPanel)
            {
                selectedPanel = clickedPanel;
                int animalId = (int)clickedPanel.Tag;
                ShowAnimalDetails(animalId);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManageAnimals ma = new ManageAnimals();
            ma.Show();
            this.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadAnimals();
        }
    }
}
