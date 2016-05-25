using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Configuration;

namespace Excalibur
{
    class Database
    {
        private NpgsqlConnection _conn;
        public Database()
        {
            _conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["db_connection"].ConnectionString);
            _conn.Open();
        }

        public void Insert(string data)
        {
          
        }
    }
}
