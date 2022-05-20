using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace electronic_register
{
    internal class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "RegisterDB";
            string username = "root";
            string password = "PassRootInDEv1234";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
