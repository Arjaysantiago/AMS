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
    public partial class WholeInfo : Form
    {
        private SqlConnection sqlConnection;
        private int animalId;
        public WholeInfo(int id)
        {
            sqlConnection = new SqlConnection("data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\webapp\\Animal Management System\\DatabaseAKF.mdf;Integrated Security=True;Connect Timeout=30");
            InitializeComponent();
            animalId = id;
            LoadAnimalDetails();
        }
        private void LoadAnimalDetails()
        {
            try
            {
                string query = "SELECT * FROM Animals WHERE AnimalID = @AnimalID";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@AnimalID", animalId);

                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtName.Text = reader["Name"].ToString();
                    txtBreed.Text = reader["Breed"].ToString();
                    txtSpecies.Text = reader["Species"].ToString();
                    txtGender.Text = reader["Gender"].ToString();
                    txtAge.Text = reader["Age"].ToString();
                    txtMedical.Text = reader["MedicalRecords"].ToString();
                    txtBackground.Text = reader["Background"].ToString();

                    byte[] pictureData = reader["Picture"] as byte[];
                    if (pictureData != null)
                    {
                        picAnimal.Image = ConvertBytesToImage(pictureData);
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private Image ConvertBytesToImage(byte[] imageBytes)
        {
            if (imageBytes != null && imageBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
        }

        private void WholeInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
