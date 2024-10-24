using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Principal;

namespace Animal_Management_System
{
    public partial class AccountManagement : Form
    {
        string connectionString = "data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\webapp\\Animal Management System\\DatabaseAKF.mdf;Integrated Security=True;Connect Timeout=30";

        public AccountManagement()
        {
            InitializeComponent();
            Display();
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
        }

        private void Display()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select * from Users", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv1.DataSource = dt;
            }
        }

            private int GetSelectedAccountId()
            {

                if (dgv1.SelectedRows.Count > 0)
                {
                    return (int)dgv1.SelectedRows[0].Cells["Id"].Value;
                }

                return -1; 
            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;
            string role = cmbRoles.Text;
            string pet = txtFavepet.Text;
            int contact;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(pet) || string.IsNullOrEmpty(confirm) ||
                string.IsNullOrEmpty(txtContact.Text) || !int.TryParse(txtContact.Text, out contact))
            {
                MessageBox.Show("Please fill out all the information");
            }
            else if (!int.TryParse(txtContact.Text, out contact))
            {
                MessageBox.Show("Please input a numerical value instead of alphabetic value.");
            }
            else if (password != confirm)
            {
                MessageBox.Show("Password does not match!");
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Users (Username, Password, Roles, petName, contact) values (@Username, @Password, @Roles, @petName, @contact)", con);
                cmd.Parameters.AddWithValue("@Username", name);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Roles", role);
                cmd.Parameters.AddWithValue("@petName", pet);
                cmd.Parameters.AddWithValue("@contact", contact);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Account Created Successfully!");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    cmbRoles.Items.Clear();
                    txtConfirm.Clear();
                    txtContact.Clear();
                    txtFavepet.Clear();
                    Display();
                }
                else
                {
                    MessageBox.Show("Failed to create account!");
                }
            }
        }

        private void btnEditPass_Click_1(object sender, EventArgs e)
        {
            string Userid = txtUserid.Text;
            string newPass = txtNewpass.Text;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand ad = new SqlCommand("Update Users set Password = @Password where ID = @ID", con);
                ad.Parameters.AddWithValue("ID", Userid);
                ad.Parameters.AddWithValue("Password", newPass);
                ad.ExecuteNonQuery();

                txtUserid.Clear();
                txtNewpass.Clear();
                con.Close();
                MessageBox.Show("Updated Successfuly");
                Display();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string remove = txtid.Text;

            if (int.TryParse(remove, out int userId))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                    BEGIN TRANSACTION;
                    SET IDENTITY_INSERT AccountBin ON;

                    INSERT INTO AccountBin (ID, Username, Password, Roles, petName, contact) 
                    SELECT ID, Username, Password, Roles, petName, contact
                    FROM Users
                    WHERE ID = @ID;
                       
                    SET IDENTITY_INSERT AccountBin OFF;
                    DELETE FROM Users
                    WHERE ID = @ID;

                    COMMIT TRANSACTION;
                ";

                    using (SqlCommand sm = new SqlCommand(query, con))
                    {
                        sm.Parameters.AddWithValue("@ID", userId);

                        try
                        {
                            int rowsAffected = sm.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Account trashed successfully.");
                                Display();
                            }
                            else
                            {
                            }
                            MessageBox.Show("Account not found.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid User ID.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AccountBin ab = new AccountBin();
            ab.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirm.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirm.PasswordChar = '*';
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

