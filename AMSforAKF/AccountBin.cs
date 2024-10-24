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
    public partial class AccountBin : Form
    {
        public AccountBin()
        {
            InitializeComponent();
            display();
        }
        string connectionString = "Data Source=DESKTOP-A6GPOLU\\SQLEXPRESS;Initial Catalog=DatabaseforAms;Integrated Security=True;TrustServerCertificate=True";

        private void display()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select * from AccountBin", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void brnRecover_Click_1(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            if (int.TryParse(id, out int userId))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                    BEGIN TRANSACTION;
                    SET IDENTITY_INSERT Users ON;
                    
                    SET IDENTITY_INSERT Users ON
                    INSERT INTO Users (ID, Username, Password, Roles, petName, contact) 
                    SELECT ID, Username, Password, Roles, petName, contact
                    FROM AccountBin
                    WHERE ID = @ID;
                      
                    SET IDENTITY_INSERT Users OFF;
                    DELETE FROM AccountBin
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
                                MessageBox.Show("Account Recovered successfully.");
                                textBox1.Clear();
                                display();
                            }
                            else
                            {
                                MessageBox.Show("Account not found.");
                            }
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

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string EnterID = textBox1.Text;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand sc = new SqlCommand("Delete from AccountBin where ID = @ID", con);
                    sc.Parameters.AddWithValue("@ID", EnterID);
                    sc.ExecuteNonQuery();

                    textBox1.Clear();
                    MessageBox.Show("Succesfully Deleted!");
                    display();
                }
            }
            else
            {
                MessageBox.Show("Account Removal canceled!");
            }
        }
    }
}
