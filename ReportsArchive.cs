using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Animal_Management_System
{
    public partial class ReportsArchive : Form
    {
        private string connectionString = "data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\webapp\\Animal Management System\\DatabaseAKF.mdf;Integrated Security=True;Connect Timeout=30";
        private Panel selectedPanel;

        public ReportsArchive()
        {
            InitializeComponent();
            LoadArchivedRecords();
        }

        private void LoadArchivedRecords()
        {
            if (flowLayoutPanel1 == null)
            {
                MessageBox.Show("FlowLayoutPanel (flowLayoutPanel1) is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            flowLayoutPanel1.Controls.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM MedicalRecords";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("No records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            while (reader.Read())
                            {
                                Panel recordPanel = new Panel
                                {
                                    Size = new System.Drawing.Size(300, 60),
                                    Margin = new Padding(5),
                                    BorderStyle = BorderStyle.FixedSingle,
                                    Tag = reader["RecordID"].ToString(),
                                    BackColor = Color.Aquamarine
                                };

                                Label lblOwner = new Label
                                {
                                    Text = "Owner: " + reader["OwnerName"].ToString(),
                                    Location = new System.Drawing.Point(5, 5),
                                    AutoSize = true
                                };

                                Label lblAnimal = new Label
                                {
                                    Text = "Animal: " + reader["AnimalName"].ToString(),
                                    Location = new System.Drawing.Point(5, 25),
                                    AutoSize = true
                                };

                                recordPanel.Controls.Add(lblOwner);
                                recordPanel.Controls.Add(lblAnimal);
                                recordPanel.Click += RecordPanel_Click;

                                flowLayoutPanel1.Controls.Add(recordPanel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecordPanel_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;
            if (clickedPanel != null)
            {
                if (selectedPanel != null)
                {
                    selectedPanel.BackColor = System.Drawing.Color.Transparent;
                }

                clickedPanel.BackColor = System.Drawing.Color.LightBlue;
                selectedPanel = clickedPanel;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (selectedPanel != null)
            {
                string recordId = selectedPanel.Tag.ToString();

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF files (*.pdf)|*.pdf",
                    Title = "Save PDF File",
                    FileName = "GeneratedReport.pdf"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                }
            }
            else
            {
                MessageBox.Show("Please select a record to generate a report.", "No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
