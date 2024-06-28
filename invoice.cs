﻿using System;
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
    public partial class invoice : Form
    {
        public invoice()
        {
            InitializeComponent();
        }

        // confirm appointment button
        private void conAppointBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            payment pay = new payment();
            pay.Show();
        }

        //back button
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewAppoint vAP = new viewAppoint();
            vAP.Show();
        }
    }
}
