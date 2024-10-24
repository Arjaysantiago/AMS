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
    public partial class ServiceForm : Form
    {
        string connectionString = "Data Source=DESKTOP-A6GPOLU\\SQLEXPRESS;Initial Catalog=DatabaseforAms;Integrated Security=True;TrustServerCertificate=True";
        public ServiceForm()
        {
            InitializeComponent();
            LoadServicesData();
        }
        private void LoadServicesData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Services", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv1.DataSource = dt;
            }
        }
        private bool ValidateServiceInputs()
        {
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Service Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtprice.Text) || !decimal.TryParse(txtprice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtdesc.Text))
            {
                MessageBox.Show("Please input some description.","Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (ValidateServiceInputs())
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "INSERT INTO Services (serviceName, description, price) OUTPUT INSERTED.serviceID VALUES (@serviceName, @description, @price)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@serviceName", txtname.Text);
                            cmd.Parameters.AddWithValue("@description", txtdesc.Text);
                            cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtprice.Text));
                            con.Open();
                            int newServiceID = (int)cmd.ExecuteScalar();

                            MedicineForm mf = new MedicineForm(newServiceID);
                            mf.Show();
                        }
                    }
                    LoadServicesData();
                    MessageBox.Show("Service added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            string search = txtid.Text;
            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Please input an ID first", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Services WHERE serviceID = @serviceID;";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@keyword", search);
                        con.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgv1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            if (ValidateServiceInputs())
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE Services SET serviceName = @serviceName, description = @description, price = @price, date = @date WHERE serviceID = @serviceID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@serviceName", txtname.Text);
                            cmd.Parameters.AddWithValue("@description", txtdesc.Text);
                            cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtprice.Text));
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadServicesData();
                    MessageBox.Show("Service updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                try
                {
                    int serviceID = Convert.ToInt32(dgv1.SelectedRows[0].Cells["serviceID"].Value);
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlTransaction transaction = con.BeginTransaction();

                        string deleteMedicinesQuery = "DELETE FROM Medicines WHERE serviceID = @serviceID";
                        using (SqlCommand cmd = new SqlCommand(deleteMedicinesQuery, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@serviceID", serviceID);
                            cmd.ExecuteNonQuery();
                        }

                        string deleteServiceQuery = "DELETE FROM Services WHERE serviceID = @serviceID";
                        using (SqlCommand cmd = new SqlCommand(deleteServiceQuery, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@serviceID", serviceID);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    LoadServicesData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a service to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            NurseForm frm = new NurseForm();
            frm.Show();
            this.Hide();
        }
    }
}
