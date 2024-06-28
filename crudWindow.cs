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
    public partial class crudWindow : Form
    {
        public crudWindow()
        {
            InitializeComponent();
        }

        // CRUD
        private void crudBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Crud crudSystem = new Crud();
            crudSystem.Show();
        }
    }
}
