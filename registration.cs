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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        // address of SQL server and database and established connection
        SqlConnection connect = new SqlConnection("Data Source=MUSTAKIM-JARIF\\SQLEXPRESS;Initial Catalog=regProject;Integrated Security=True");
        SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();


        // Register Button
        private void register_Click(object sender, EventArgs e)
        {
            if (textuser.Text == "" && address.Text == "" && mobileNum.Text == "" && email.Text == "" && password.Text == "" && repeatPass.Text == "")
            {
                MessageBox.Show("Please Fill up this Fields", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (password.Text == repeatPass.Text)
            {
                connect.Open();
                string Query = "insert into Table_RegProject(username,address,number,email,password) VALUES ('" + textuser.Text + "', '" + address.Text + "', '" + mobileNum.Text + "', '" + email.Text + "', '" + password.Text + "')";
                sqlcmd = new SqlCommand(Query, connect);
                sqlcmd.ExecuteNonQuery();

                connect.Close();

                textuser.Text = "";
                address.Text = "";
                mobileNum.Text = "";
                email.Text = "";
                password.Text = "";
                repeatPass.Text = "";

                MessageBox.Show("Your account has been successfully Created", "Registration Successfull", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // open login window 
                this.Hide();
                Login_Form formlog = new Login_Form();
                formlog.Show();

            }

            else
            {
                MessageBox.Show("Password does not match", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                password.Text = "";
                repeatPass.Text = "";
                password.Focus();
            }

            //MessageBox.Show("Successfully Registered Your Account", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        // Sign In Button
        private void signIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form logForm = new Login_Form();
            logForm.Show();

        }

        // Show password Checkbox
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                password.PasswordChar = '\0';
                repeatPass.PasswordChar = '\0';
            }

            else
            {
                password.PasswordChar = '*';
                repeatPass.PasswordChar = '*';
            }

        }
    }
}
