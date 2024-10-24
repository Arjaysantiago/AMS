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

namespace AMSforAKF
{
    public partial class ClientForm : Form
    {
        private AnimalDetails animalDetails;
        public ClientForm(AnimalDetails animalDetails)
        {
            InitializeComponent();
            this.animalDetails = animalDetails;
            DisplayPetDetails();
        }
        private void DisplayPetDetails()
        {
            txtpetname.Text = animalDetails.AnimalName;
            txtbreed.Text = animalDetails.Breed;

            txtpetname.ReadOnly = true;
            txtbreed.ReadOnly = true;
        }
        private string GetHousingType()
        {
            if (cbCondo.Checked) return "Apt/Condo";
            if (cbHouse.Checked) return "House";
            return "Other";
        }
        private string GetReasonForAdoption()
        {
            string reason = "";
            if (cbreason1.Checked) reason += "Companionship for child ";
            if (cbreason2.Checked) reason += "Companionship for other animals";
            if (cbreason3.Checked) reason += "Therapy Animal";
            if (cbreason4.Checked) reason += "Security";
            if (cbreason5.Checked) reason += "House Pet";
            if (cbreason6.Checked) reason += "Breeding";
            return reason.TrimEnd(',', ' ');
        }
        private void ClearForm()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtlandlord.Clear();
            txtcontact.Clear();
            txtwho.Clear();
            txthours.Clear();
            txtpetname.Clear();
            txtbreed.Clear();
            rtbsmallinfo.Clear();
            cmbtall.SelectedIndex = -1;
            cbrentyes.Checked = false;
            cbfenceyes.Checked = false;
            cbgiftyes.Checked = false;
            cbapproveyes.Checked = false;
            cballergyyes.Checked = false;
            cbfinancialyes.Checked = false;
            cbdewormyes.Checked = false;
            cbvaccineyes.Checked = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-A6GPOLU\\SQLEXPRESS;Initial Catalog=DatabaseforAms;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO ClientForm 
                                    (ApplicantsName, Address, Phone, Email, HousingType, Rent, LandlordName, LandlordContact, 
                                    Fence, FenceHeight, ReasonForAdoption, GiftForSomeone, GiftForWho, FamilyApproves, 
                                    AllergyToAnimals, HoursAlone, FinancialSupport, MonthlyDeworming, YearlyVaccination, 
                                    PetName, PetBreed, AdditionalInfo) 
                                    VALUES (@ApplicantsName, @Address, @Phone, @Email, @HousingType, @Rent, @LandlordName, 
                                    @LandlordContact, @Fence, @FenceHeight, @ReasonForAdoption, @GiftForSomeone, @GiftForWho, 
                                    @FamilyApproves, @AllergyToAnimals, @HoursAlone, @FinancialSupport, @MonthlyDeworming, 
                                    @YearlyVaccination, @PetName, @PetBreed, @AdditionalInfo)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ApplicantsName", txtName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@HousingType", GetHousingType());
                    cmd.Parameters.AddWithValue("@Rent", cbrentyes.Checked);
                    cmd.Parameters.AddWithValue("@LandlordName", txtlandlord.Text);
                    cmd.Parameters.AddWithValue("@LandlordContact", txtcontact.Text);
                    cmd.Parameters.AddWithValue("@Fence", cbfenceyes.Checked); 
                    cmd.Parameters.AddWithValue("@FenceHeight", cmbtall.Text);
                    cmd.Parameters.AddWithValue("@ReasonForAdoption", GetReasonForAdoption());
                    cmd.Parameters.AddWithValue("@GiftForSomeone", cbgiftyes.Checked);
                    cmd.Parameters.AddWithValue("@GiftForWho", txtwho.Text);
                    cmd.Parameters.AddWithValue("@FamilyApproves", cbapproveyes.Checked); 
                    cmd.Parameters.AddWithValue("@AllergyToAnimals", cballergyyes.Checked);
                    cmd.Parameters.AddWithValue("@HoursAlone", txthours.Text);
                    cmd.Parameters.AddWithValue("@FinancialSupport", cbfinancialyes.Checked); 
                    cmd.Parameters.AddWithValue("@MonthlyDeworming", cbdewormyes.Checked); 
                    cmd.Parameters.AddWithValue("@YearlyVaccination", cbvaccineyes.Checked); 
                    cmd.Parameters.AddWithValue("@PetName", txtpetname.Text); 
                    cmd.Parameters.AddWithValue("@PetBreed", txtbreed.Text); 
                    cmd.Parameters.AddWithValue("@AdditionalInfo", rtbsmallinfo.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Form submitted successfully!");

                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {

        }
    }
}
