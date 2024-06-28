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
    public partial class bookAppoint : Form
    {
        // Assuming you have a connection string
        private readonly string connectionString = "Data Source=MUSTAKIM-JARIF\\SQLEXPRESS;Initial Catalog=AppointmentDB;Integrated Security=True";

        public bookAppoint()
        {
            InitializeComponent();
        }

        // Submit Button
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    DateTime selectedDate = dateTimePicker1.Value.Date;
                    DateTime selectedTime = dateTimePicker2.Value;

                    string query = "INSERT INTO [AppointmentDB].[dbo].[Table_AppointmentBooking] " +
                        "([selected_Service], [appointmentDate], [appointmentTime]) " +
                        "VALUES (@SelectedService, @SelectedDate, @SelectedTime)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SelectedService", serviceCombo.Text);
                        command.Parameters.AddWithValue("@SelectedDate", selectedDate);
                        command.Parameters.AddWithValue("@SelectedTime", selectedTime);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        // check the result
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully.", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();

                            viewAppoint appointView = new viewAppoint();
                            appointView.DisplayAppointmentData(serviceCombo.Text, selectedDate, selectedTime);
                            appointView.Show();
                        }
                        else
                        {
                            MessageBox.Show("Error inserting data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Back button
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            parlorService ps = new parlorService();
            ps.Show();
        }
    }
}
