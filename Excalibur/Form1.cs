using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excalibur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstname.Text;
            string lastname = txtLastname.Text;

            Person ps = new Person()
            {
                Firstname = firstname,
                Lastname = lastname
            };

            ps.AddPerson();
            UpdateList();   
        }

        private void UpdateList()
        {
            Person ps = new Person();
            List<Person> pList = new List<Person>();

            pList = ps.SelectPerson();

            lbxPersons.DataSource = pList;
        }
    }
}
