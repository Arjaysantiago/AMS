using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AMSforAKF
{
    public partial class AnimalProfile : Form
    {
        public AnimalProfile()
        {
            InitializeComponent();
            
        }

        private void AnimalProfile_Load(object sender, EventArgs e)
        {

        }

        private byte[] ConvertImageToBytes(Image image)
        {
            if (image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, image.RawFormat);
                    return ms.ToArray();
                }
            }
            return null;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string species = cmbSpecies.Text;
            string breed = txtBreed.Text;
            string gender = cmbGender.Text;
            string age = txtAge.Text;
            string medical = txtmedical.Text;
            string background = txtBackground.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(species) || string.IsNullOrEmpty(breed) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(medical) ||
                string.IsNullOrEmpty(background))
            {
                MessageBox.Show("Please input all the information");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are those data are final?", "finalize your input!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection("data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\webapp\\Animal Management System\\DatabaseAKF.mdf;Integrated Security=True;"))
                    {
                        try
                        {
                            conn.Open();
                            string query = "INSERT INTO Animals (Name, Species, Breed, Gender, Age, MedicalRecords, Background, Picture) " +
                                               "VALUES (@Name, @Species, @Breed, @Gender, @Age, @MedicalRecords, @Background, @Picture)";

                            SqlCommand command = new SqlCommand(query, conn);
                            command.Parameters.AddWithValue("@Name", txtName.Text);
                            command.Parameters.AddWithValue("@Species", cmbSpecies.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@Breed", txtBreed.Text);
                            command.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                            command.Parameters.AddWithValue("@MedicalRecords", txtmedical.Text);
                            command.Parameters.AddWithValue("@Background", txtBackground.Text);

                            // Convert the image from PictureBox to a byte array
                            byte[] imageBytes = ConvertImageToBytes(pictureBox1.Image);
                            command.Parameters.AddWithValue("@Picture", imageBytes);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Animal added successfully!");

                            this.Close();
                        }
                        catch (SqlException ex) when (ex.Number == 2627) // SQL error for unique constraint
                        {
                            MessageBox.Show("Duplicate animal information detected. Please check the data.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }

            }
        }
    }
}
