using System;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonStdRegistration_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            routesForms.moveToStudentRegistration();
        }

        private void buttonStdPayment_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            routesForms.moveToStudentPayment();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            routesForms.moveToLogin();
        }

        private void clerkPanel_Load(object sender, EventArgs e)
        {
            lableUsername.Text = session.getUserData; 
        }
    }
}
