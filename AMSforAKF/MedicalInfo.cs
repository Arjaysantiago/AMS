using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMSforAKF
{
    public partial class MedicalInfo : Form
    {
        private int _animalID;

        public MedicalInfo(int animalID)
        {
            _animalID = animalID;
            InitializeComponent();
            this.Load += new EventHandler(MedicalInfo_Load);
        }

        private void LoadMedicalInfo()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-A6GPOLU\\SQLEXPRESS;Initial Catalog=DatabaseforAms;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string query = @"SELECT t.MedicalCondition, t.PossibleTreatment, t.Notes, t.TreatmentDate
                                     FROM Treatments t
                                     WHERE t.AnimalID = @AnimalID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@AnimalID", SqlDbType.Int) { Value = _animalID });

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtMedicalCondition.Text = reader["MedicalCondition"].ToString();
                                lblPossibleTreatment.Text = reader["PossibleTreatment"].ToString();
                                txtNotes.Text = reader["Notes"].ToString();
                                lblDateAdded.Text = Convert.ToDateTime(reader["TreatmentDate"]).ToString("d");
                            }
                            else
                            {
                                MessageBox.Show("No treatment records found for the specified animal.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                var reportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                string reportPath = "C:\\Users\\user\\source\\repos\\AMSforAKF\\AMSforAKF\\AnimalTreatmentReport.rpt";
                MessageBox.Show($"Report path: {reportPath}");

                if (!System.IO.File.Exists(reportPath))
                {
                    MessageBox.Show($"Report file not found at: {reportPath}", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                reportDocument.Load(reportPath);

                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-A6GPOLU\\SQLEXPRESS;Initial Catalog=DatabaseforAms;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    string query = @"SELECT MedicalCondition, PossibleTreatment, Notes, TreatmentDate, TreatmentTime
                             FROM Treatments
                             WHERE AnimalID = @AnimalID";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@AnimalID", _animalID);
                        adapter.Fill(ds, "TreatmentData");
                    }

                    reportDocument.SetDataSource(ds.Tables["TreatmentData"]);
                    ReportsViewer rv = new ReportsViewer
                    {
                        ReportSource = reportDocument
                    };
                    rv.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nDetails: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPasstoStaff_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-A6GPOLU\\SQLEXPRESS;Initial Catalog=DatabaseforAms;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO ManagingStaffVirtualKennel(AnimalID, TreatmentID) " +
                              "SELECT AnimalID, TreatmentID from Treatments where TreatmentID = @TreatmentID", conn);
                    command.Parameters.AddWithValue("@TreatmentID", _animalID);
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MedicalInfo_Load(object sender, EventArgs e)
        {
            LoadMedicalInfo();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
