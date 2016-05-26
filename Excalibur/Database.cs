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
        private NpgsqlCommand _cmd;
        private NpgsqlDataReader _dr;

        public Database()
        {
            //_conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["db_connection"].ConnectionString);
            _conn = new NpgsqlConnection("Server = 81.25.82.40; Port = 5432; User id = dbmanager; Password = miun4EVER; Database = excalibur");
            _conn.Open();
        }

        public void Insert(string data)
        {
            try
            {
                _cmd = new NpgsqlCommand(data, _conn);
                _cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }

        public List<Person> Select(string data)
        {
            try
            {
                _cmd = new NpgsqlCommand(data, _conn);
                _dr = _cmd.ExecuteReader();

                Person person = new Person();
                List<Person> pLista = new List<Person>();

                while (_dr.Read())
                {
                    person = new Person()
                    {
                        Firstname = _dr["firstname"].ToString(),
                        Lastname = _dr["lastname"].ToString()
                    };
                    pLista.Add(person);
                }

                return pLista;
            }
            catch (NpgsqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
