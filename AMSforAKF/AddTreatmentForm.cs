using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMSforAKF
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
                    MessageBox.Show("Please fill out the medical condition and select a treatment.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-A6GPOLU\\SQLEXPRESS;Initial Catalog=DatabaseforAms;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string treatmentQuery = "INSERT INTO Treatments (AnimalID, MedicalCondition, PossibleTreatment, Notes, TreatmentDate, TreatmentTime) " +
                                            "VALUES (@AnimalID, @MedicalCondition, @PossibleTreatment, @Notes, @TreatmentDate, @TreatmentTime);";

                    using (SqlCommand cmd = new SqlCommand(treatmentQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@AnimalID", _animalID);
                        cmd.Parameters.AddWithValue("@MedicalCondition", medicalCondition);
                        cmd.Parameters.AddWithValue("@PossibleTreatment", possibleTreatment);
                        cmd.Parameters.AddWithValue("@Notes", notes);
                        cmd.Parameters.AddWithValue("@TreatmentDate", treatmentDate);
                        cmd.Parameters.AddWithValue("@TreatmentTime", treatmentTime);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Treatment details saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n{ex.StackTrace}", "Exception Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
