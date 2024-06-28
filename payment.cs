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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void paybillBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for your appointment", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBkash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Coming Soon", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNagad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Coming Soon", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void visaBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Fill up your Billing Address", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnpaypal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Fill up your Billing Address", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Fill up your Billing Address", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            invoice invoice = new invoice();
            invoice.Show();
        }
    }
}
