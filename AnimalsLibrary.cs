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
    public partial class AnimalsLibrary : Form
    {
        private SqlConnection sqlConnection;
        public AnimalsLibrary()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\user\\source\\repos\\webapp\\Animal Management System\\DatabaseAKF.mdf\";Integrated Security=True");
            LoadAnimals();
            SetupSortComboBox();
            
        }
        private void SetupSortComboBox()
        {
            cmbSort.Items.Add("Name");
            cmbSort.Items.Add("Breed");
            cmbSort.Items.Add("Age");
            cmbSort.Items.Add("Species");
            cmbSort.SelectedIndex = 0; 
        }
        private void LoadAnimals(string sortBy = "Name")
        {
            try
            {
                string query = $"SELECT AnimalID, Name, Species, Breed, Age, Picture FROM Animals ORDER BY {sortBy}";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                flowPanel1.Controls.Clear();

                while (reader.Read())
                {
                    int animalId = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string species = reader.GetString(2);
                    string breed = reader.GetString(3);
                    int age = reader.GetInt32(4);
                    byte[] pictureData = reader["Picture"] as byte[];

                    Panel animalPanel = CreateAnimalPanel(animalId, name, species, breed, age, pictureData);
                    flowPanel1.Controls.Add(animalPanel);
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
        private Panel CreateAnimalPanel(int animalId, string name, string species, string breed, int age, byte[] pictureData)
        {
            Panel panel = new Panel
            {
                Width = 150,
                Height = 200,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = animalId
            };

            PictureBox pictureBox = new PictureBox
            {
                Width = 130,
                Height = 130,
                Image = pictureData != null ? ConvertBytesToImage(pictureData) : null,
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Top
            };

            Label nameLabel = new Label
            {
                Text = $"{name} ({species})",
                Dock = DockStyle.Bottom,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label breedLabel = new Label
            {
                Text = $"Breed: {breed}",
                Dock = DockStyle.Bottom,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label ageLabel = new Label
            {
                Text = $"Age: {age}",
                Dock = DockStyle.Bottom,
                TextAlign = ContentAlignment.MiddleCenter
            };

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(breedLabel);
            panel.Controls.Add(ageLabel);
            panel.Click += AnimalPanel_Click;

            return panel;
        }
        private void AnimalPanel_Click(Object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;
            int animalId = (int)clickedPanel.Tag;
            ShowAnimalDetails(animalId);
        }
        private void ShowAnimalDetails(int animalId)
        {
            WholeInfo detailsForm = new WholeInfo(animalId);
            detailsForm.ShowDialog();
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
        private void btnSort_Click(object sender, EventArgs e)
        {
            string selectedSort = cmbSort.SelectedItem.ToString();
            LoadAnimals(selectedSort);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManageAnimals ma = new ManageAnimals();
            ma.Show();
            this.Close();
        }
    }
}
