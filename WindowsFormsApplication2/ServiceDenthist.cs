using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class ServiceDenthist : Form
    {
            static string connectionString = "SERVER=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                 + ";" + "PASSWORD=password" + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
        public ServiceDenthist()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ServiceDenthist_Load(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            //Maintenance mainte = new Maintenance();
            //int pno, servicefee = 0;
            //string date = "", servicename = "", status = "";
            //pno = Convert.ToInt32(mainte.txtpno2.Text);
            //connection.Open();
            //string query = "SELECT a.appointdate,a.service,a.appointstatus,s.servicefee from appointmenttbl a, servicestbl s where a.pno = '" + pno + "' and a.service = s.servicename";
            //MySqlCommand cmd = new MySqlCommand(query, connection);
            //MySqlDataReader dataReader = cmd.ExecuteReader();
            //while (dataReader.Read())
            //{
            //    date = dataReader.GetString("appointdate");
            //    servicename = dataReader.GetString("service");
            //    status = dataReader.GetString("appointstatus");
            //    servicefee = dataReader.GetInt32("servicefee");
            //    dataGridView1.Rows.Add(date, servicename, servicefee, status);
            //}
        }
    }
}
