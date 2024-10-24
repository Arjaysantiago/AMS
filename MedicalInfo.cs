using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal_Management_System
{
    public partial class MedicalInfo : Form
    {
        private int _kennelID;
        public MedicalInfo(int kennelID)
        {
            _kennelID = kennelID;
            InitializeComponent();
            LoadMedicalInfo();
        }
        private void LoadMedicalInfo()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\user\\source\\repos\\webapp\\Animal Management System\\DatabaseAKF.mdf\";Integrated Security=True"))
            {
                conn.Open();
                string query = "SELECT MedicalCondition, PossibleTreatment, Notes, DateAdded " +
                               "FROM Treatments INNER JOIN AnimalVirtualKennel " +
                               "ON Treatments.TreatmentID = AnimalVirtualKennel.TreatmentID " +
                               "WHERE AnimalVirtualKennel.KennelID = @KennelID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@KennelID", _kennelID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblMedicalCondition.Text = reader["MedicalCondition"].ToString();
                            lblPossibleTreatment.Text = reader["PossibleTreatment"].ToString();
                            lblNotes.Text = reader["Notes"].ToString();
                            lblDateAdded.Text = Convert.ToDateTime(reader["DateAdded"]).ToString("g");
                        }
                    }
                }
            }
        }

        private void MedicalInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                var reportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                reportDocument.Load("AnimalTreatmentReport.rpt");

                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\user\\source\\repos\\webapp\\Animal Management System\\DatabaseAKF.mdf\";Integrated Security=True"))
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    string query = "SELECT MedicalCondition, PossibleTreatment, Notes, DateAdded " +
                                   "FROM Treatments INNER JOIN AnimalVirtualKennel " +
                                   "ON Treatments.TreatmentID = AnimalVirtualKennel.TreatmentID " +
                                   "WHERE AnimalVirtualKennel.KennelID = @KennelID";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@KennelID", _kennelID);
                        adapter.Fill(ds, "TreatmentData");
                    }
                    reportDocument.SetDataSource(ds);
                    var reportViewerForm = new NewReportsViewer();
                    reportViewerForm.reportViewer1.ReportSource = reportDocument;
                    reportViewerForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnPasstoStaff_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\user\\source\\repos\\webapp\\Animal Management System\\DatabaseAKF.mdf\";Integrated Security=True"))
                {
                    conn.Open();
                    string passQuery = "INSERT INTO ManagingStaffVirtualKennel (MedicalCondition, PossibleTreatment, Notes, DateAdded) " +
                                       "VALUES (@MedicalCondition, @PossibleTreatment, @Notes, @DateAdded)";

                    using (SqlCommand cmd = new SqlCommand(passQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MedicalCondition", lblMedicalCondition.Text);
                        cmd.Parameters.AddWithValue("@PossibleTreatment", lblPossibleTreatment.Text);
                        cmd.Parameters.AddWithValue("@Notes", lblNotes.Text);
                        cmd.Parameters.AddWithValue("@DateAdded", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Information passed to managing staff successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void lblBack_Click(object sender, EventArgs e)
        {
            
        }
    }
}
