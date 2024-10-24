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
    public partial class Animals_InTake_Form : Form
    {
        string connectionString = "data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\webapp\\Animal Management System\\DatabaseAKF.mdf;Integrated Security=True;Connect Timeout=30";
        public Animals_InTake_Form()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string generatedAnimalID = GenerateAnimalID();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                INSERT INTO AnimalIntake 
                (Incident, IntakePersonnelName, Title, Date, Time, GeneratedAnimalID, ArrivalStatus, 
                Name, Species, Breed, Gender, Collar, IDTag, License, Rabies, 
                OwnerName, OwnerAddress, OwnerPhoneHome, OwnerPhoneCell, OwnerEmail, 
                VeterinarianName, VeterinarianPhone, EmergencyContactName, EmergencyContactRelationship, 
                EmergencyContactPhone)
                VALUES 
                (@Incident, @IntakePersonnelName, @Title, @Date, @Time, @GeneratedAnimalID, @ArrivalStatus,
                @Name, @Species, @Breed, @Gender, @Collar, @IDTag, @License, @Rabies, 
                @OwnerName, @OwnerAddress, @OwnerPhoneHome, @OwnerPhoneCell, @OwnerEmail, 
                @VeterinarianName, @VeterinarianPhone, @EmergencyContactName, @EmergencyContactRelationship, 
                @EmergencyContactPhone)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Incident", txtIncident.Text);
                cmd.Parameters.AddWithValue("@IntakePersonnelName", txtIntakePersonnelName.Text);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@Time", dateTimePickerTime.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@GeneratedAnimalID", generatedAnimalID);

                string selectedArrivalStatus = GetSelectedArrivalStatus();
                cmd.Parameters.AddWithValue("@ArrivalStatus", selectedArrivalStatus);

                cmd.Parameters.AddWithValue("@Name", txtAnimalName.Text);
                cmd.Parameters.AddWithValue("@Species", txtSpecies.Text);
                cmd.Parameters.AddWithValue("@Breed", txtBreed.Text);

                string selectedGender = GetSelectedGender();
                cmd.Parameters.AddWithValue("@Gender", selectedGender);

                cmd.Parameters.AddWithValue("@Collar", chkCollar.Checked);
                cmd.Parameters.AddWithValue("@IDTag", chkIDTag.Checked);
                cmd.Parameters.AddWithValue("@License", txtLicense.Text);
                cmd.Parameters.AddWithValue("@Rabies", txtRabies.Text);

                cmd.Parameters.AddWithValue("@OwnerName", string.IsNullOrEmpty(txtOwnerName.Text) ? (object)DBNull.Value : txtOwnerName.Text);
                cmd.Parameters.AddWithValue("@OwnerAddress", string.IsNullOrEmpty(txtOwnerAddress.Text) ? (object)DBNull.Value : txtOwnerAddress.Text);
                cmd.Parameters.AddWithValue("@OwnerPhoneHome", string.IsNullOrEmpty(txtPhoneHome.Text) ? (object)DBNull.Value : txtPhoneHome.Text);
                cmd.Parameters.AddWithValue("@OwnerPhoneCell", string.IsNullOrEmpty(txtPhoneCell.Text) ? (object)DBNull.Value : txtPhoneCell.Text);
                cmd.Parameters.AddWithValue("@OwnerEmail", string.IsNullOrEmpty(txtOwnerEmail.Text) ? (object)DBNull.Value : txtOwnerEmail.Text);

                cmd.Parameters.AddWithValue("@VeterinarianName", txtVetName.Text);
                cmd.Parameters.AddWithValue("@VeterinarianPhone", txtVetPhone.Text);

                cmd.Parameters.AddWithValue("@EmergencyContactName", txtEmergencyContactName.Text);
                cmd.Parameters.AddWithValue("@EmergencyContactRelationship", txtEmergencyContactRelationship.Text);
                cmd.Parameters.AddWithValue("@EmergencyContactPhone", txtEmergencyContactPhone.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Animal intake record successfully added.");
                this.Close();
            }
        }
        private string GenerateAnimalID()
        {
            return "ANIMAL-" + DateTime.Now.Ticks.ToString();
        }
        private string GetSelectedGender()
        {
            if (chkFemale.Checked) return "Female";
            if (chkMale.Checked) return "Male";
            return string.Empty;
        }
        private string GetSelectedArrivalStatus()
        {
            if (chkRescued.Checked) return "Rescued";
            if (chkFound.Checked) return "Found";
            if (chkOwnerAgentDropOff.Checked) return "Owner/Agent Drop-off";
            if (chkRelinquished.Checked) return "Relinquished";
            if (chkOwnerRequested.Checked) return "Owner Requested";
            if (chkDeceased.Checked) return "Deceased";
            return string.Empty;
        }
    }
}
