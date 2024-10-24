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
using System.Xml.Linq;

namespace Animal_Management_System
{
    public partial class MedicineForm : Form
    {
        string connectionString = "data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\webapp\\Animal Management System\\DatabaseAKF.mdf;Integrated Security=True;Connect Timeout=30";
        private int? serviceID;
        public MedicineForm(int serviceID = 0)
        {
            InitializeComponent();
            LoadMedicinesData();
            LoadServicesDropdown();
            this.serviceID = serviceID;
            SetDefaultService();
        }
        private void LoadMedicinesData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Medicines";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv1.DataSource = dt;
                }
            }
        }
        private void LoadServicesDropdown()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT serviceID, serviceName FROM Services";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cmbServices.DisplayMember = "serviceName";
                    cmbServices.ValueMember = "serviceID";
                    cmbServices.DataSource = dt;
                }
            }
        }
        private void SetDefaultService()
        {
            if (serviceID > 0)
            {
                cmbServices.SelectedValue = serviceID;
            }
        }
        private bool ValidateMedicineInputs()
        {
            if (string.IsNullOrEmpty(txtname.Text.Trim()) || string.IsNullOrEmpty(txtdosage.Text.Trim()) || cmbServices.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void ClearMedicineInputs()
        {
            txtname.Clear();
            txtdesc.Clear();
            txtdosage.Clear();
            txtfrequency.Clear();
            txtprice.Clear();
            cmbServices.SelectedIndex = -1;
        }
        private void MedicineForm_Load(object sender, EventArgs e)
        {

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (ValidateMedicineInputs())
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "INSERT INTO Medicines (name, description, dosage, frequency, price, serviceID) VALUES (@name, @description, @dosage, @frequency, @price, @serviceID)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@name", txtname.Text.Trim());
                            cmd.Parameters.AddWithValue("@description", txtdesc.Text.Trim());
                            cmd.Parameters.AddWithValue("@dosage", txtdosage.Text.Trim());
                            cmd.Parameters.AddWithValue("@frequency", txtfrequency.Text.Trim());
                            cmd.Parameters.AddWithValue("@price", decimal.Parse(txtprice.Text.Trim()));
                            cmd.Parameters.AddWithValue("@serviceID", cmbServices.SelectedValue);

                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadMedicinesData();
                    ClearMedicineInputs();
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
                    string query = "SELECT * FROM Medicines WHERE medicineID = @medicineID;";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@medicineID", search);
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
            if (ValidateMedicineInputs())
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE Medicines SET name = @name, description = @description, dosage = @dosage, frequency = @frequency, price = @price, serviceID = @serviceID WHERE medicineID = @medicineID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@name", txtname.Text.Trim());
                            cmd.Parameters.AddWithValue("@description", txtdesc.Text.Trim());
                            cmd.Parameters.AddWithValue("@dosage", txtdosage.Text.Trim());
                            cmd.Parameters.AddWithValue("@frequency", txtfrequency.Text.Trim());
                            cmd.Parameters.AddWithValue("@price", decimal.Parse(txtprice.Text.Trim()));
                            cmd.Parameters.AddWithValue("@serviceID", cmbServices.SelectedValue);
                            cmd.Parameters.AddWithValue("@medicineID", Convert.ToInt32(dgv1.SelectedRows[0].Cells["medicineID"].Value));

                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadMedicinesData();
                    ClearMedicineInputs();
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
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlTransaction transaction = con.BeginTransaction();

                        foreach (DataGridViewRow row in dgv1.SelectedRows)
                        {
                            int medicineID = Convert.ToInt32(row.Cells["medicineID"].Value);
                            string query = "DELETE FROM Medicines WHERE medicineID = @medicineID";

                            using (SqlCommand cmd = new SqlCommand(query, con, transaction))
                            {
                                cmd.Parameters.AddWithValue("@medicineID", medicineID);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    LoadMedicinesData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select at least one medicine to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            NurseForm nf = new NurseForm();
            nf.Show();
            this.Hide();
        }
    }
}
