using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Configuration;
using System.Data;

namespace Excalibur
{
    class Database:ErrorHandler
    {
        private NpgsqlConnection _conn;
        private NpgsqlCommand _cmd;
        private NpgsqlDataReader _dr;
        private DataTable _table;

        public Database()
        {
            _conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["db_connection"].ConnectionString);            
            _conn.Open();
            _table = new DataTable();
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

        private DataTable Querry(string SqlQuerry)
        {
            try
            {
                _cmd = new NpgsqlCommand(SqlQuerry, _conn);
                _dr = _cmd.ExecuteReader();
                _table.Load(_dr);

                return _table;
            }
            catch (PostgresException ex)
            {
                DataColumn c1 = new DataColumn("Error");
                DataColumn c2 = new DataColumn("ErrorMessage");

                c1.DataType = Type.GetType("System.Boolean");
                c2.DataType = Type.GetType("System.String");

                _table.Columns.Add(c1);
                _table.Columns.Add(c2);

                DataRow row = _table.NewRow();
                row[c1] = true;
                row[c2] = ex.Message;
                _table.Rows.Add(row);

                return _table;
            }
        }

        public List<Person> Select(string data)
        {
            try
            {
                _table = Querry(data);

                List<Person> pLista = new List<Person>();

                if (_table.Columns[0].ColumnName.Equals("Error"))
                {
                    Person ps = new Person();
                    ps.Error = true;
                    ps.ErrorMessage = _table.Rows[0][1].ToString();

                    pLista.Add(ps);
                }

                Person person;

                //while (_dr.Read())
                //{
                //    person = new Person()
                //    {
                //        Firstname = _dr["firstname"].ToString(),
                //        Lastname = _dr["lastname"].ToString()
                //    };
                //    pLista.Add(person);
                //}

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
