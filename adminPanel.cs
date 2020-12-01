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
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }

        private void btnBacktoHome_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void adminPanel_Load(object sender, EventArgs e)
        {
            labelUsername.Text = session.getUserData;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            routesForms.moveToLogin();
        }
    }
}
