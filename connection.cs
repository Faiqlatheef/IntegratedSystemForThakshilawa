using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IntegratedSystemThakshilawa
{
    class connection
    {
        static string conn = @"Data Source=SAJAS;Initial Catalog=intergratedsystem;Integrated Security=True";
        public static SqlConnection db = new SqlConnection(conn);
    }
}
