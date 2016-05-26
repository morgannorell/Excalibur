using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excalibur
{
    class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public void AddPerson()
        {
            Database addPs = new Database();

            string sql;
            sql = "INSERT INTO person " +
                "(firstname, lastname) " +
                "VALUES ('" + Firstname + "', '" + Lastname + "');";

            addPs.Insert(sql);
        }

        public List<Person> SelectPerson()
        {
            Database getP = new Database();
            List<Person> pList = new List<Person>();

            string sql;
            sql = "SELECT firstname, lastname FROM person";

            pList = getP.Select(sql);

            return pList;
        }
    }
}
