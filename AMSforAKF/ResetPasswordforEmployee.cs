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
    public partial class ResetPasswordforEmployee : Form
    {
        private string username;
        private int resetAttempts = 0;
        private bool isCooldown = false;
        private System.Timers.Timer cooldownTimer;
        public ResetPasswordforEmployee(string user)
        {
            InitializeComponent();
            SetupFormInitialState();
            username = user; 
            SetupFormInitialState();
            cooldownTimer = new System.Timers.Timer();
            cooldownTimer.Interval = 300000; 
            cooldownTimer.Elapsed += CooldownTimer_Elapsed;
            cooldownTimer.AutoReset = false;
        }
        private void CooldownTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            isCooldown = false;
            resetAttempts = 0;
            MessageBox.Show("You can now try resetting your password again.");
        }
        private void SetupFormInitialState()
        {
            this.Height = 250;

            lvlNewPass.Visible = false;
            lblConfirmNew.Visible = false;
            txtNewPass.Visible = false;
            txtConfirmPass.Visible = false;
            btnSubmit.Visible = false;
        }

        private void ExpandFormForPasswordReset()
        {
            this.Height = 450; 

            lvlNewPass.Visible = true;
            lblConfirmNew.Visible = true;
            txtNewPass.Visible = true;
            txtConfirmPass.Visible = true;
            btnSubmit.Visible = true;
        }
        private void btnverify_Click(object sender, EventArgs e)
        {
            if (isCooldown)
            {
                MessageBox.Show("You have used all your attempts. Please try again in 5 minutes.");
                return;
            }

            string favoritePet = txtFavepet.Text;
            string contact = txtContact.Text;

            if (string.IsNullOrEmpty(favoritePet) || string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Please fill out both fields.");
                return;
            }

            using (SqlConnection conn = new SqlConnection("data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\webapp\\Animals Management System\\DatabaseAKF.mdf;"))
            {
                try
                {
                    conn.Open();
                    SqlCommand checkDetailsCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Users WHERE Username=@username AND petName=@petName AND contact=@contact", conn);
                    checkDetailsCmd.Parameters.AddWithValue("@username", username);
                    checkDetailsCmd.Parameters.AddWithValue("@petName", favoritePet);
                    checkDetailsCmd.Parameters.AddWithValue("@contact", contact);


                    int detailsMatch = (int)checkDetailsCmd.ExecuteScalar();

                    if (detailsMatch > 0)
                    {
                        MessageBox.Show("Details verified. You can now reset your password.");
                        ExpandFormForPasswordReset();
                    }
                    else
                    {
                        resetAttempts++;
                        if (resetAttempts >= 3)
                        {
                            MessageBox.Show("You have used all your attempts. Please try again in 5 minutes.");
                            isCooldown = true;
                            cooldownTimer.Start();
                        }
                        else
                        {
                            MessageBox.Show($"Invalid details. You have {3 - resetAttempts} attempt(s) remaining.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAMS ms = new frmAMS();
            ms.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPass.Text;
            string confirmPassword = txtConfirmPass.Text;

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter and confirm your new password.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            using (SqlConnection conn = new SqlConnection("data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\webapp\\Animals Management System\\DatabaseAKF.mdf;"))
            {
                try
                {
                    conn.Open();
                    SqlCommand updatePasswordCmd = new SqlCommand(
                    "UPDATE Users SET Password=@newPassword WHERE Username=@username", conn);
                    updatePasswordCmd.Parameters.AddWithValue("@newPassword", newPassword);
                    updatePasswordCmd.Parameters.AddWithValue("@username", username);


                    int rowsAffected = updatePasswordCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully.");
                        this.Close(); 
                    }
                    else
                    {
                        MessageBox.Show("Failed to update password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }
        private void LogPasswordChange(string username)
        {
            using (SqlConnection conn = new SqlConnection("data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\webapp\\Animal Management System\\DatabaseAKF.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    conn.Open();
                    SqlCommand logPasswordChangeCmd = new SqlCommand(
                    "INSERT INTO PasswordChanges (Username, ChangeDate) VALUES (@username, @changeDate)", conn);
                    logPasswordChangeCmd.Parameters.AddWithValue("@username", username);
                    logPasswordChangeCmd.Parameters.AddWithValue("@changeDate", DateTime.Now);
                    logPasswordChangeCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while logging the password change: " + ex.Message);
                }
            }
        }
    }
}
