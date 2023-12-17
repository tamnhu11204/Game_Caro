using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Caro
{
    public class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = "Data Source=LAPTOP-3J19JUTN\\TAMNHU;Initial Catalog=PLAYERMANAGEMENT;Integrated Security=True";
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
