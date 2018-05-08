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
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();

            string username = "", userlvl = "", status = "",pname="",lname="",fname="",mi="",upcomingdate="";
            int tbal = 0,pno=0,patientno=0;
            string datenow="",patientname="",service="",time="",date="";
            datenow = DateTime.Now.ToString("yyyy-MM-dd");
            upcomingdate = DateTime.Today.AddDays(5).ToString("yyyy-MM-dd");
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "SELECT * from logintbl where stat1= 'not approved'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader1 = cmd.ExecuteReader();
                while (dataReader1.Read())
                {
                    username = dataReader1.GetString("username");
                    userlvl = dataReader1.GetString("user_lvl");
                    status = dataReader1.GetString("stat1");

                    dataGridView1.Rows.Add(username, userlvl, status);
                }
            }
            catch (MySqlException) { }
            connection.Close();
            try
            {
                connection.Open();
                string query2 = "SELECT p.pno,p.plname,p.pfname,p.pminitial,SUM(ba.tbal),ba.balno,ba.baldate from balancetbl ba,patienttbl p"+
				" where ba.pno=p.pno and ba.tbal > 0 and ba.balno in (SELECT MAX(balno) from balancetbl ba,billingtbl b where ba.balno = b.balanceno group by ba.pno,b.servicename)"+
                " and ba.baldate IN (SELECT MAX(baldate) from balancetbl ba,billingtbl b where ba.balno = b.balanceno group by ba.pno,b.servicename)"+
                " group by p.pno"+
                " order by ba.balno;";
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                MySqlDataReader dataReader2 = cmd2.ExecuteReader();
                while (dataReader2.Read())
                {
                    pno = dataReader2.GetInt32("pno");
                    lname = dataReader2.GetString("plname");
                    fname = dataReader2.GetString("pfname");
                    try
                    {
                        mi = dataReader2.GetString("pminitial");
                    }
                    catch (Exception)
                    {
                        mi = "";
                    }
                    pname = lname+", "+fname+" "+mi;
                    tbal = dataReader2.GetInt32("SUM(ba.tbal)");

                    dataGridView2.Rows.Add(pno, pname, tbal);
                }
            }
            catch (MySqlException) { }
            connection.Close();

            connection.Open();
            string query3 = "SELECT DATE_FORMAT(appointdate,'%Y-%m-%d'),pno,pname,service,appointtime from appointmenttbl where appointdate between '" + datenow + "' and '"+upcomingdate+"'";
            MySqlCommand cmd3 = new MySqlCommand(query3, connection);
            MySqlDataReader dataReader3 = cmd3.ExecuteReader();
            while (dataReader3.Read())
            {
                patientno = dataReader3.GetInt32("pno");
                date = dataReader3.GetString("DATE_FORMAT(appointdate,'%Y-%m-%d')");
                patientname = dataReader3.GetString("pname");
                service = dataReader3.GetString("service");
                time = dataReader3.GetString("appointtime");
                dataGridView3.Rows.Add(patientno, date,patientname, service, time);  
            }
            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Menu menu = new Menu();
            menu.label2.ResetText();
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            int count = 0,count1=0,count2=0,totalcount=0;
            string datenow="",upcomingdate="";
            datenow = DateTime.Now.ToString("yyyy-MM-dd");
            upcomingdate = DateTime.Today.AddDays(5).ToString("yyyy-MM-dd");
            try
            {
                connection.Open();
                string query1 = "SELECT COUNT(userid) from logintbl where stat1 = 'not approved'";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    count = dataReader.GetInt32("COUNT(userid)");
                }
            }
            catch (MySqlException) { }
            connection.Close();
            try
            {
                connection.Open();
                string query2 = "SELECT COUNT(DISTINCT(pno)),SUM(tbal) from balancetbl"+
                " where balno in (SELECT MAX(balno) from balancetbl ba,billingtbl b where ba.balno = b.balanceno group by ba.pno,b.servicename)"+
                " and baldate IN (SELECT MAX(baldate) from balancetbl ba,billingtbl b where ba.balno = b.balanceno group by ba.pno,b.servicename)"+
                " group by pno having SUM(tbal) > 0";
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                MySqlDataReader dataReader2 = cmd2.ExecuteReader();
                while (dataReader2.Read())
                {
                    count1 += dataReader2.GetInt32("COUNT(DISTINCT(pno))");
                }
            }
            catch (MySqlException) { }
            connection.Close();

            connection.Open();
            string query3 = "SELECT COUNT(*) from appointmenttbl where appointdate between '" + datenow + "' and '"+upcomingdate+"'";
            MySqlCommand cmd3 = new MySqlCommand(query3, connection);
            MySqlDataReader dataReader3 = cmd3.ExecuteReader();
            while (dataReader3.Read())
            {
                count2 = dataReader3.GetInt32("COUNT(*)");
            }
            connection.Close();
            totalcount = count + count1 + count2;

            if (totalcount == 0)
            {
                menu.label2.Hide();
            }
            else
            {
                menu.label2.Show();
            }

            menu.label2.Text = totalcount.ToString();
         
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string username = "",status = "approved";
            bool check = true;
            try
            {
                username = Convert.ToString(dataGridView1.SelectedCells[0].Value);
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("No selected"); check = false; }
            if (check == true)
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE logintbl set stat1 = '" + status + "' where username = '" + username + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User's request approved");
                }
                catch (MySqlException) { }
                connection.Close();
                dataGridView1.Rows.Clear();

                string username1 = "", userlvl1 = "", status1 = "";
                try
                {
                    connection.Open();
                    string query = "SELECT * from logintbl where stat1= 'not approved'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader1 = cmd.ExecuteReader();
                    while (dataReader1.Read())
                    {
                        username1 = dataReader1.GetString("username");
                        userlvl1 = dataReader1.GetString("user_lvl");
                        status1 = dataReader1.GetString("stat1");

                        dataGridView1.Rows.Add(username1, userlvl1, status1);
                    }
                }
                catch (MySqlException) { }
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
               + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string username = "";
            bool check = true;
            try
            {
                username = Convert.ToString(dataGridView1.SelectedCells[0].Value);
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("No selected"); check = false; }
            if (check == true)
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM logintbl where username = '" + username + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User's request denied");
                }
                catch (MySqlException) { }
                connection.Close();
                dataGridView1.Rows.Clear();
                string username1 = "", userlvl1 = "", status1 = "";
                try
                {
                    connection.Open();
                    string query = "SELECT * from logintbl where stat1= 'not approved'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader1 = cmd.ExecuteReader();
                    while (dataReader1.Read())
                    {
                        username1 = dataReader1.GetString("username");
                        userlvl1 = dataReader1.GetString("user_lvl");
                        status1 = dataReader1.GetString("stat1");

                        dataGridView1.Rows.Add(username1, userlvl1, status1);
                    }
                }
                catch (MySqlException) { }
                connection.Close();
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int uid = 0;
            string uname = "";
            uid = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            uname = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            Maintenance mainte = new Maintenance();
            mainte.Show();
            mainte.panel66.Show();
            mainte.txtpno2.Text = uid.ToString();
            mainte.txtname2.Text = uname;
            mainte.tabPage10.Show();
            mainte.tabControl3.SelectTab("tabPage10");
            mainte.button2.Show();
            mainte.pbackbtn.Hide();
            this.Hide();
        }
    }
}
