using System.Data;
using MySql.Data.MySqlClient;

namespace StreetCRUD.Helper
{
    public class ConnectionHelper
    {
        private static string _server = "localhost";
        private static string _database = "qlduongbo";
        private static string _uid = "root";
        private static string _password = "";
        public static MySqlConnection _connection;

        public static MySqlConnection GetConnection()
        {
            if (_connection==null|| _connection.State==ConnectionState.Closed)
            {
                string connectionString;
                connectionString = "SERVER=" + _server + ";" + "DATABASE=" + 
                                   _database + ";" + "UID=" + _uid + ";" + "PASSWORD=" + _password + ";";
                _connection = new MySqlConnection(connectionString);
            }
            return _connection;
        }
    }
}