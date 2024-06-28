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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        // address of SQL server and database and established connection
        SqlConnection connect = new SqlConnection("Data Source=MUSTAKIM-JARIF\\SQLEXPRESS;Initial Catalog=regProject;Integrated Security=True");
        SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        // login Button
        private void login_Click(object sender, EventArgs e)
        {
            connect.Open();
            string login = "SELECT * FROM Table_RegProject WHERE username = '" + textuser.Text + "' and password = '" + password.Text + "'";

            sqlcmd = new SqlCommand(login, connect);
            SqlDataReader dr = sqlcmd.ExecuteReader();

            if (dr.Read() == true)
            {
                MessageBox.Show("Login Successfull", "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Hide();
                parlorService service = new parlorService();
                service.Show();
            }
            else
            {
                MessageBox.Show("Invalid username and password , please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textuser.Text = "";
                password.Text = "";
                textuser.Focus();
            }          
        }

        // Create Account Button
        private void signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            registration rg = new registration();
            rg.Show();
        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
            }

        }
    }
}
