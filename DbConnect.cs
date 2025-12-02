using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IdealHome
{
    internal class DbConnect
    {
        private string _connectionString = "Server=localhost;database=IdealHome;uid=root;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
