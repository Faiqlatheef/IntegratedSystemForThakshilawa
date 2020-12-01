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
        public static string name;
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
            if (isValid())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from login where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", connect);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    session.getUserData = txtUsername.Text;
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
                                else if (dt.Rows[i]["usertype"].ToString() == "hr")
                                {
                                    this.Hide();
                                    routesForms.moveToHRPanel();
                                }
                                else if (dt.Rows[i]["usertype"].ToString() == "manager")
                                {
                                    this.Hide();
                                    routesForms.moveToManagerPanel();
                                }
                                else if (dt.Rows[i]["usertype"].ToString() == "cafeteria")
                                {
                                    this.Hide();
                                    routesForms.moveToCafeteriaPanel();
                                }
                                else if (dt.Rows[i]["usertype"].ToString() == "lacturer")
                                {
                                    this.Hide();
                                    routesForms.moveToLacturerPanel();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username or Password is not matched with the roll", "Invalid Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is not matched with the roll", "Invalid Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("You have an Error Contect Your Developer" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    connect.Close();
                }
            }
            return;
        }

        private bool isValid()
        {
            if(txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Field can not be empty", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (commonValitations.Valid_Name.IsMatch(txtUsername.Text) != true)
            {
                MessageBox.Show("Name only alphabetical characters", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (commonValitations.Valid_Name_Limit.IsMatch(txtUsername.Text) != true)
            {
                MessageBox.Show("Name should be upto 6 alphabetical characters", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }
            else if (commonValitations.Valid_Password.IsMatch(txtPassword.Text) != true)
            {
                MessageBox.Show("Password must be atleast 8 to 15 characters. It contains atleast one letter and numbers.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }
            else if (userType.SelectedItem == null)
            {
                MessageBox.Show("Please select a Roll", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userType.Focus();
                return false;
            }
            return true;
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetFormController();
        }

        private void ResetFormController()
        {
            txtUsername.Clear();
            txtPassword.Clear();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
