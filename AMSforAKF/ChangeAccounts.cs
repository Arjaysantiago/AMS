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
    public partial class ChangeAccounts : Form
    {
        string connectionString = "Data Source=DESKTOP-A6GPOLU\\SQLEXPRESS;Initial Catalog=DatabaseforAms;Integrated Security=True;TrustServerCertificate=True";

        public ChangeAccounts()
        {
            InitializeComponent();
            display(); 
        }
        private void display()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PasswordChanges", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying data: " + ex.Message);
            }
        }
        private void ResetPasswordChangeNotifications()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM PasswordChanges";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Password change notifications have been reset.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resetting notifications: " + ex.Message);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ResetPasswordChangeNotifications();
            display(); 
            this.Close(); 
        }
    }
}
