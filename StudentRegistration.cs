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
    public partial class StudentRegistration : Form
    {
        static SqlConnection connect = connection.db;
        public int studentID;
        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            _dataGridView();
        }
        

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                enumFunction.DBFunction("insert into students(name, nic, phoneno, address, email, subject)values('" + txtName.Text + "', '" + txtNIC.Text + "', '" + txtPhoneNo.Text + "', '" + txtAddress.Text + "', '" + txtEmail.Text + "', '" + Subject.SelectedItem + "')", enumFunction._enumtype.insert);
                ResetFormController();
                _dataGridView();
                txtName.Focus();
            }
            return; 
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                if (studentID > 0)
                {
                    enumFunction.DBFunction("update students SET name='" + txtName.Text + "', nic='" + txtNIC.Text + "', phoneno='" + txtPhoneNo.Text + "', address='" + txtAddress.Text + "', email='" + txtEmail.Text + "', subject='" + Subject.SelectedItem + "' WHERE rowID ='" + studentID + "'", enumFunction._enumtype.update);
                    _dataGridView();
                    ResetFormController();
                }
                else
                {
                    MessageBox.Show("No Data Found", "Select Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (studentID > 0)
            {
                enumFunction.DBFunction("DELETE  FROM students WHERE rowID = '" + txtstudentID.Text + "' ", enumFunction._enumtype.delete);

                _dataGridView();
                ResetFormController();
            }
            else
            {
                MessageBox.Show("No Data Found", "Select Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }


        private void studentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridViewProperty();
        }

        private void _dataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from students", connect);
                DataTable dt = new DataTable();
                connect.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                studentDataGridView.DataSource = dt;
            }
            catch(Exception e)
            {
                MessageBox.Show("Error" + e, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }
        private void gridViewProperty()
        {
            studentID = Convert.ToInt32(studentDataGridView.SelectedRows[0].Cells[0].Value);
            txtstudentID.Text = studentDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = studentDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtNIC.Text = studentDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtPhoneNo.Text = studentDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtAddress.Text = studentDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            txtEmail.Text = studentDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            Subject.SelectedItem = studentDataGridView.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFormController();
            txtName.Focus();
        }

        private bool isValid()
        {
            if(txtName.Text == string.Empty || txtNIC.Text == string.Empty || txtPhoneNo.Text == string.Empty || txtEmail.Text == string.Empty || txtAddress.Text == string.Empty || Subject.SelectedItem == null)
            {
                MessageBox.Show("Fileds canot be Empty", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            if(commonValitations.Valid_Name.IsMatch(txtName.Text) != true)
            {
                MessageBox.Show("Name accepts only alphabetical characters", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            else if(commonValitations.Valid_Name_Limit.IsMatch(txtName.Text) != true)
            {
                MessageBox.Show("Name should be upto 6 alphabetical characters", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            else if (commonValitations.Valid_Nic.IsMatch(txtNIC.Text) != true)
            {
                MessageBox.Show("Please enter valid Nic format ex: 970130675v", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNIC.Focus();
                return false;
            }
            else if (commonValitations.Valid_Phoeno.IsMatch(txtPhoneNo.Text) != true)
            {
                MessageBox.Show("Please enter valid Nic format ex: 77XXXXXXX", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNo.Focus();
                return false;
            }
            else if (commonValitations.Valid_Email.IsMatch(txtEmail.Text) != true)
            {
                MessageBox.Show("Please enter valid email format ex: sajasam97@gmail.com", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            else if (commonValitations.Valid_Email.IsMatch(txtEmail.Text) != true)
            {
                MessageBox.Show("Please enter valid email format ex: sajasam97@gmail.com", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            return true;
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            routesForms.moveToClerkPanel();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            studentDataGridView.Sort(studentDataGridView.Columns[0], ListSortDirection.Ascending);
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from students where rowID='" + txtSearchID.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                studentDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            _dataGridView();
        }
    }
}
