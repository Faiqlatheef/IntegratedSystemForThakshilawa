﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegratedSystemThakshilawa
{
    public partial class clerkPanel : Form
    {
        public clerkPanel()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {

        }

        private void buttonStdRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            routesForms.moveToStudentRegistration();
        }

        private void buttonStdPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            routesForms.moveToStudentPayment();
        }
    }
}
