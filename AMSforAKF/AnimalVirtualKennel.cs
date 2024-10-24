using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMSforAKF
{
    public partial class AnimalVirtualKennel : Form
    {
        public AnimalVirtualKennel()
        {
            InitializeComponent();
            LoadAnimalVirtualKennel();
        }

        private void LoadAnimalVirtualKennel()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-A6GPOLU\\SQLEXPRESS;Initial Catalog=DatabaseforAms;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string query = @"SELECT a.AnimalID, a.AnimalName, a.Species, a.Breed, t.MedicalCondition, t.PossibleTreatment, t.TreatmentDate
                                     FROM AnimalfromVet a
                                     INNER JOIN Treatments t ON a.AnimalID = t.AnimalID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            pnlKennelContainer.Controls.Clear();
                            int panelYPosition = 0;

                            while (reader.Read())
                            {
                                int animalID = reader.GetInt32(0);
                                string animalName = reader.GetString(1);
                                string species = reader.GetString(2);
                                string breed = reader.GetString(3);
                                string medicalCondition = reader.GetString(4);
                                string possibleTreatment = reader.GetString(5);
                                DateTime treatmentDate = reader.GetDateTime(6);

                                string summary = $"{animalName} ({species} - {breed}): {medicalCondition}, Treatment: {possibleTreatment}, Date: {treatmentDate.ToShortDateString()}";

                                Panel kennelPanel = new Panel
                                {
                                    Width = pnlKennelContainer.Width - 25,
                                    Height = 100,
                                    BorderStyle = BorderStyle.FixedSingle,
                                    Margin = new Padding(5),
                                    Location = new System.Drawing.Point(10, panelYPosition),
                                    Tag = animalID 
                                };

                                Label lblSummary = new Label
                                {
                                    Text = summary,
                                    AutoSize = true,
                                    Location = new System.Drawing.Point(10, 10),
                                    MaximumSize = new System.Drawing.Size(kennelPanel.Width - 20, 0) 
                                };

                                kennelPanel.Click += (sender, e) => KennelPanel_Click(sender, e, animalID);
                                kennelPanel.Controls.Add(lblSummary);
                                pnlKennelContainer.Controls.Add(kennelPanel);

                                panelYPosition += kennelPanel.Height + 10; 
                            }

                            if (pnlKennelContainer.Controls.Count == 0)
                            {
                                MessageBox.Show("No kennel records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n{ex.StackTrace}", "Exception Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KennelPanel_Click(object sender, EventArgs e, int animalID)
        {
            MedicalInfo medicalInfoForm = new MedicalInfo(animalID);
            medicalInfoForm.ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadAnimalVirtualKennel();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
