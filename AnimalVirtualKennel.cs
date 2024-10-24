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
    public partial class AnimalVirtualKennel : Form
    {
        public AnimalVirtualKennel()
        {
            InitializeComponent();
        }
        private void LoadAnimalVirtualKennel()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\user\\source\\repos\\webapp\\Animal Management System\\DatabaseAKF.mdf\";Integrated Security=True"))
            {
                conn.Open();
                string query = "SELECT KennelID, Summary FROM AnimalVirtualKennel";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        pnlKennelContainer.Controls.Clear();

                        while (reader.Read())
                        {
                            int kennelID = reader.GetInt32(0);
                            string summary = reader.GetString(1);

                            Panel kennelPanel = new Panel
                            {
                                Width = 300,
                                Height = 100,
                                BorderStyle = BorderStyle.FixedSingle,
                                Margin = new Padding(5),
                                Tag = kennelID 
                            };
                            Label lblSummary = new Label
                            {
                                Text = summary,
                                AutoSize = true,
                                Location = new System.Drawing.Point(10, 10),
                                MaximumSize = new System.Drawing.Size(280, 0)
                            };
                            kennelPanel.Click += (sender, e) => KennelPanel_Click(sender, e, kennelID);
                            kennelPanel.Controls.Add(lblSummary);
                            pnlKennelContainer.Controls.Add(kennelPanel);
                        }
                    }
                }
            }
        }
        private void KennelPanel_Click(object sender, EventArgs e, int kennelID)
        {
            MedicalInfo medicalInfoForm = new MedicalInfo(kennelID);
            medicalInfoForm.ShowDialog();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {

        }
    }
}
