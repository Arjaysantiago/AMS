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
    public partial class AddTreatmentForm : Form
    {
        private int _animalID;
        public AddTreatmentForm(int animalID)
        {
            _animalID = animalID;
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string medicalCondition = rtbMcondition.Text;
                string possibleTreatment = cmbTreatments.SelectedItem?.ToString();
                string notes = rtbNotes.Text;
                DateTime treatmentDate = dtpDate.Value.Date;
                TimeSpan treatmentTime = dtpTime.Value.TimeOfDay;

                if (string.IsNullOrEmpty(medicalCondition) || string.IsNullOrEmpty(possibleTreatment))
                {
                    MessageBox.Show("Please fill out the medical condition and select a treatment.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\user\\source\\repos\\webapp\\Animal Management System\\DatabaseAKF.mdf\";Integrated Security=True"))
                {
                    conn.Open();
                    string treatmentQuery = "INSERT INTO Treatments (MedicalCondition, PossibleTreatment, Notes, TreatmentDate, TreatmentTime) " +
                                            "VALUES (@MedicalCondition, @PossibleTreatment, @Notes, @TreatmentDate, @TreatmentTime); " +
                                            "SELECT SCOPE_IDENTITY();";

                    int treatmentID;
                    using (SqlCommand cmd = new SqlCommand(treatmentQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MedicalCondition", medicalCondition);
                        cmd.Parameters.AddWithValue("@PossibleTreatment", possibleTreatment);
                        cmd.Parameters.AddWithValue("@Notes", notes);
                        cmd.Parameters.AddWithValue("@TreatmentDate", treatmentDate);
                        cmd.Parameters.AddWithValue("@TreatmentTime", treatmentTime);

                        treatmentID = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    string updateAnimalQuery = "UPDATE Animals SET TreatmentID = @TreatmentID WHERE AnimalID = @AnimalID";
                    using (SqlCommand cmd = new SqlCommand(updateAnimalQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@TreatmentID", treatmentID);
                        cmd.Parameters.AddWithValue("@AnimalID", _animalID);
                        cmd.ExecuteNonQuery();
                    }

                    string kennelQuery = "INSERT INTO AnimalVirtualKennel (AnimalID, Summary, DateAdded) " +
                                         "VALUES (@AnimalID, @Summary, @DateAdded)";
                    using (SqlCommand kennelCmd = new SqlCommand(kennelQuery, conn))
                    {
                        kennelCmd.Parameters.AddWithValue("@AnimalID", _animalID);
                        kennelCmd.Parameters.AddWithValue("@Summary", $"{medicalCondition} - {possibleTreatment}");
                        kennelCmd.Parameters.AddWithValue("@DateAdded", DateTime.Now);
                        kennelCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Treatment details and animal information saved successfully in the virtual kennel.");
                    this.Close(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
