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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        // Login Button
        private void login_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Login Your Account", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            Login_Form formlog = new Login_Form();
            formlog.Show();
        }

        // Registration Button
        private void registration_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Create Your Account", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.Hide();
            registration formReg = new registration();
            formReg.Show();
        }

        // Service Button
        private void service_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you Have Account ?", "Create Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // login Interface
                this.Hide();
                Login_Form formlog = new Login_Form();
                formlog.Show();
            }
            else
            {
                // Create Account Interface
                this.Hide();
                registration formrg = new registration();
                formrg.Show();
            }
        }

        // Admin button
        private void admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            crudWindow crud = new crudWindow();
            crud.Show();
        }

        // about_us button
        private void about_Click(object sender, EventArgs e)
        {
            this.Hide();
            about_us about = new about_us();
            about.Show();
        }

        // combox button
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Choose one parlor", "Choose Parlor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
