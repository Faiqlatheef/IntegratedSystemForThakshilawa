using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IntegratedSystemThakshilawa
{
    class enumFunction
    {
        static SqlConnection connect = connection.db;

        public enum _enumtype
        {
            insert, update, delete
        }
        public static void DBFunction(String Sql, _enumtype Functiontype)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(Sql, connect);
                connect.Open();
                int count = cmd.ExecuteNonQuery();

                String mymessage = "";
                String errormessage = "contact your developer";
                String titleMessage = "";

                switch (Functiontype)
                {
                    case _enumtype.insert:
                        mymessage = "Insert Successfully";
                        titleMessage = "Insert Message";

                        break;

                    case _enumtype.update:
                        mymessage = "Update Successfully";
                        titleMessage = "Update Message";

                        break;

                    case _enumtype.delete:
                        mymessage = "Delete Successfully";
                        titleMessage = "Delete Message";
                        break;


                    default:
                        break;
                }


                if (count > 0)
                {
                    MessageBox.Show(mymessage, titleMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(errormessage, titleMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
    }
}
