using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parlor
{
    public partial class viewAppoint : Form
    {
        public viewAppoint()
        {
            InitializeComponent();
        }

        // Add a method to receive data
        // parameterized Constructor 
        public void DisplayAppointmentData(string selectedService, DateTime selectedDate, DateTime selectedTime)
        {
            // Use the received data to update the UI elements in the viewAppoint form
            // For example, if you have labels to display the data:

            servicetxt.Text = selectedService;
            appointmentDate.Text = selectedDate.ToShortDateString();
            appointmentTime.Text = selectedTime.ToShortTimeString();
        }

        // Checkout button
        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to confirm this appointment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                invoice formin = new invoice();
                formin.Show();
            }
            else
            {
                this.Hide();
                viewAppoint view = new viewAppoint();
                view.Show();
            }
        }

        // Back Button
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookAppoint book = new bookAppoint();
            book.Show();
        }
    }
}
