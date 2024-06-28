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
    public partial class parlorService : Form
    {
        public parlorService()
        {
            InitializeComponent();
        }

        //back home button
        private void backHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            homepage home = new homepage();
            home.Show();
        }

        // logout button
        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form formLog = new Login_Form();
            formLog.Show();
        }

        // Book Appointment button
        private void bookAppoint_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to book an appointment?", "Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                bookAppoint booking = new bookAppoint();
                booking.Show();
            }
            else
            {
                this.Hide();
                homepage home = new homepage();
                home.Show();

            }
        }

        // View Appointment button
        private void viewAppoint_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewAppoint appointment = new viewAppoint();
            appointment.Show();
        }
    }
}
