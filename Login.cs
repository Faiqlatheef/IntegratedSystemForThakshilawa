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

namespace IntegratedSystemThakshilawa
{
    public partial class Login : Form
    {
        static SqlConnection connect = connection.db;        
        public Login()
        {
            InitializeComponent();
        }

        private void btnBacktoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            routesForms.moveToIndex();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from login where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", connect);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string cmbItemValue = userType.SelectedItem.ToString();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        if (dt.Rows[i]["usertype"].ToString() == cmbItemValue) //you can use 2 instead of usertype in that index because usertype column is in 2 index
                        {

                            if (dt.Rows[i]["usertype"].ToString() == "admin")
                            {

                                this.Hide();
                                routesForms.moveToAdminPanel();
                                MessageBox.Show("you are login as " + dt.Rows[i][1]);


                            }
                            else if (dt.Rows[i]["usertype"].ToString() == "clerk")
                            {

                                this.Hide();
                                routesForms.moveToClerkPanel();

                            }
                            else if (dt.Rows[i]["usertype"].ToString() == "owner")
                            {

                                this.Hide();
                                routesForms.moveToOwnerPanel();
                            }                        
                        }

                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("You have an Error Contect Your Developer" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }
    }
}
