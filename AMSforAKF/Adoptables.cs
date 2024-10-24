using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMSforAKF
{
    public partial class Adoptables : Form
    {
        private SqlConnection sqlConnection;
        private Panel selectedPanel;

        public Adoptables()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=DESKTOP-A6GPOLU\\SQLEXPRESS;Initial Catalog=DatabaseforAms;Integrated Security=True;TrustServerCertificate=True");
            LoadAdoptables();
        }

        public void LoadAdoptables()
        {
            try
            {
                sqlConnection.Open();
                string query = "SELECT AnimalID, AnimalName, Species, Breed, Gender, Age, MedicalCondition, PossibleTreatment, Notes, DateAdded FROM Adoptables";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();

                flpAdoptables.Controls.Clear();

                while (reader.Read())
                {
                    int animalId = reader.GetInt32(0);
                    string animalName = reader.IsDBNull(1) ? "N/A" : reader.GetString(1);
                    string species = reader.IsDBNull(2) ? "N/A" : reader.GetString(2);
                    string breed = reader.IsDBNull(3) ? "N/A" : reader.GetString(3);
                    string gender = reader.IsDBNull(4) ? "N/A" : reader.GetString(4);
                    int age = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
                    string medicalCondition = reader.IsDBNull(6) ? "N/A" : reader.GetString(6);
                    string treatment = reader.IsDBNull(7) ? "N/A" : reader.GetString(7);
                    string notes = reader.IsDBNull(8) ? "N/A" : reader.GetString(8);
                    DateTime dateTime = reader.IsDBNull(9) ? DateTime.Now : reader.GetDateTime(9);

                    DateTime datePart = dateTime.Date;
                    TimeSpan timePart = dateTime.TimeOfDay;

                    Panel adoptablePanel = CreateAdoptablePanel(animalId, animalName, species, breed, gender, age);
                    flpAdoptables.Controls.Add(adoptablePanel);

                    adoptablePanel.Tag = new AnimalDetails
                    {
                        AnimalId = animalId,
                        AnimalName = animalName,
                        Species = species,
                        Breed = breed,
                        Gender = gender,
                        Age = age,
                        MedicalCondition = medicalCondition,
                        Treatment = treatment,
                        Notes = notes,
                        Date = datePart,
                        Time = timePart
                    };
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading adoptables: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public Panel CreateAdoptablePanel(int animalId, string animalName, string species, string breed, string gender, int age)
        {
            Panel panel = new Panel
            {
                Width = 150,
                Height = 200,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = animalId
            };

            panel.Controls.Add(new Label { Text = $"Name: {animalName}", Dock = DockStyle.Top });
            panel.Controls.Add(new Label { Text = $"Species: {species}", Dock = DockStyle.Top });
            panel.Controls.Add(new Label { Text = $"Breed: {breed}", Dock = DockStyle.Top });
            panel.Controls.Add(new Label { Text = $"Gender: {gender}", Dock = DockStyle.Top });
            panel.Controls.Add(new Label { Text = $"Age: {age}", Dock = DockStyle.Top });

            panel.Click += AdoptablePanel_Click;

            return panel;
        }

        private void AdoptablePanel_Click(object sender, EventArgs e)
        {
            if (sender is Panel clickedPanel)
            {
                selectedPanel = clickedPanel;
                AnimalDetails details = (AnimalDetails)clickedPanel.Tag;
                AdoptablesInfo infoForm = new AdoptablesInfo(details);
                infoForm.ShowDialog();
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
            LoadAdoptables();
        }
    }
    public class AnimalDetails
    {
        public int AnimalId { get; set; }
        public string AnimalName { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string MedicalCondition { get; set; }
        public string Treatment { get; set; }
        public string Notes { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
    }
}
