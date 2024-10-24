using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Timers;

namespace AMSforAKF
{
    public partial class frmAMS : Form
    {
        private int loginAttempts = 0;
        private bool isCooldown = false;
        private System.Timers.Timer cooldownTimer;

        public frmAMS()
        {
            InitializeComponent();
            cbxCheck.CheckedChanged += new EventHandler(cbxCheck_CheckedChanged);
            cooldownTimer = new System.Timers.Timer();
            cooldownTimer.Interval = 60000;
            cooldownTimer.Elapsed += CooldownTimer_Elapsed;
            cooldownTimer.AutoReset = false;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(btnLogin_KeyDown);
        }
        private void HandleFailedLogin()
        {
            loginAttempts++;

            if (loginAttempts >= 3)
            {
                MessageBox.Show("You have reached the maximum login attempts. Please try again in 1 minutes.");
                isCooldown = true;
                cooldownTimer.Start();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
        private void CooldownTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            isCooldown = false;
            loginAttempts = 0;
            MessageBox.Show("You can now try logging in again.");
        }
        private void cbxCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCheck.Checked)
            {
                txtPassword.PasswordChar = '\0'; 
            }
            else
            {
                txtPassword.PasswordChar = '*'; 
            }
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            LandingPage lp = new LandingPage();
            lp.Show();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (isCooldown)
            {
                MessageBox.Show("You have reached the maximum login attempts. Please try again in 3 minutes.");
                return;
            }
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }
            else if (username.Contains(" ") && password.Contains(" "))
            {
                MessageBox.Show("The username or password should not contain spaces");
                return;
            }
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-A6GPOLU\\SQLEXPRESS;Initial Catalog=DatabaseforAms;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    conn.Open();
                    SqlCommand checkUserCmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username=@username", conn);
                    checkUserCmd.Parameters.AddWithValue("@username", username);

                    int userExists = (int)checkUserCmd.ExecuteScalar();

                    if (userExists == 0)
                    {
                        MessageBox.Show("The user you entered does not exist.");
                        return;
                    }

                    SqlCommand cmd = new SqlCommand("SELECT Roles FROM Users WHERE Username=@username AND Password=@password", conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    string role = (string)cmd.ExecuteScalar();

                    if (role != null)
                    {
                        MessageBox.Show("Login successful.");
                        loginAttempts = 0;
                        switch (role)
                        {
                            case "Veterinarian":
                                VetDashBoard vetDashBoard = new VetDashBoard();
                                vetDashBoard.Show();
                                this.Hide();
                                break;
                            case "Managing Staff":
                                ManageAnimals ma = new ManageAnimals();
                                ma.Show();
                                this.Hide();
                                break;
                            case "Nurse":
                                NurseForm nf = new NurseForm();
                                nf.Show();
                                this.Hide();
                                break;
                            default:
                                MessageBox.Show("Unknown role.");
                                break;
                        }
                    }
                    else { HandleFailedLogin(); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username to reset your password.");
                return;
            }

            ResetPasswordforEmployee resetForm = new ResetPasswordforEmployee(username);
            resetForm.Show();
        }
    }
}
