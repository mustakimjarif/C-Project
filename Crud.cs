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

namespace Parlor
{
    public partial class Crud : Form
    {
        // Database Connection
        private readonly string connectionString = "Data Source=MUSTAKIM-JARIF\\SQLEXPRESS;Initial Catalog=CrudProject;Integrated Security=True";
        private readonly DataTable dt = new DataTable();

        public Crud()
        {
            InitializeComponent();
        }

        // Load data into DataGridView
        private void BindData()
        {
            dt.Clear(); // Clear existing data
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Table_projectCrud";

                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(sqlCommand))
                    {
                        sda.Fill(dt);

                        // Display data in the DataGridView
                        dataGridView.DataSource = dt;
                    }
                }
            }
        }

        // Form load event to bind data initially
        private void Crud_Load(object sender, EventArgs e)
        {
            BindData();
        }

        // Insert the values to the database
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Table_projectCrud(appointmentId, customerName, service, price) " +
                                   "VALUES (@appointmentId, @customerName, @service, @price)";

                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@appointmentId", int.Parse(textAppointId.Text));
                        sqlCommand.Parameters.AddWithValue("@customerName", textcustomerName.Text);
                        sqlCommand.Parameters.AddWithValue("@service", comboBox1.Text);
                        sqlCommand.Parameters.AddWithValue("@price", decimal.Parse(Price.Text));

                        sqlCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Successfully Saved", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the data in the DataGridView after insertion
                    BindData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // update data from Database
        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textcustomerName.Text) && !string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(Price.Text))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE Table_projectCrud " +
                                       "SET customerName=@customerName, service=@service, price=@price " +
                                       "WHERE appointmentId=@appointmentId";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@appointmentId", int.Parse(textAppointId.Text));
                            cmd.Parameters.AddWithValue("@customerName", textcustomerName.Text);
                            cmd.Parameters.AddWithValue("@service", comboBox1.Text);
                            cmd.Parameters.AddWithValue("@price", decimal.Parse(Price.Text));

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Data Details Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter mandatory details!");
            }
        }


        // Delete Data From Database
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Table_projectCrud WHERE appointmentId=@appointmentId";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@appointmentId", int.Parse(textAppointId.Text));

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BindData(); // Refresh the data in the DataGridView after deletion
                        }
                        else
                        {
                            MessageBox.Show("No matching record found for deletion", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Data Grid view
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView.Rows.Count)
                {
                    textAppointId.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    textcustomerName.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    comboBox1.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    Price.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Error: Invalid format in the selected row. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            textAppointId.Clear();
            textcustomerName.Clear();
            Price.Clear();
            textAppointId.Focus();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            homepage homepage = new homepage();
            homepage.Show();
        }
    }
}
