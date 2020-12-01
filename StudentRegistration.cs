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
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            routesForms.moveToClerkPanel();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            enumFunction.DBFunction("insert into students(name, nic, phoneno, address, email, subject)values('" + txtName.Text + "', '" + txtNIC.Text + "', '" + txtPhoneNo.Text + "', '" + txtAddress.Text + "', '" + txtEmail.Text + "', '" + Subject.SelectedItem + "')", enumFunction._enumtype.insert);
            ResetFormController();
            txtName.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFormController();
            txtName.Focus();
        }

        private void ResetFormController()
        {
            txtstudentID.Clear();
            txtName.Clear();
            txtNIC.Clear();
            txtAddress.Clear();
            txtPhoneNo.Clear();
            txtEmail.Clear();
            Subject.SelectedItem = null;
        }
    }
}
