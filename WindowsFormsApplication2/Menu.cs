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
    public partial class Menu : Form
    {
        string log;
        static string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
               + ";" + "PASSWORD=password" + ";";
        MySqlConnection connection = new MySqlConnection(connectionString);
        public Menu()
        {
            InitializeComponent();
            initTime();
            
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            Maintenance main = new Maintenance();
            main.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reports rep = new Reports();
            rep.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Billing trans = new Billing();
            trans.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Appointment app = new Appointment();
            app.Show();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        public int User()
        {
            comboBox1.SelectedIndex = 0;
            int uid = 0;
            string uname = "";
            uname = comboBox1.Text;
            MessageBox.Show(uname);
            try
            {
                connection.Open();
                string query = "SELECT userid from logintbl where username = '" + uname + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    uid = dataReader.GetInt32("userid");
                }
                connection.Close();
            }
            catch (MySqlException) { }
            return uid;
            
        }
        public string User1()
        {
            string userlvl = "";
            string uname = "";
            uname = comboBox1.Text;
            try
            {
                connection.Open();
                string query = "SELECT user_lvl from logintbl where username = '" + uname + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    userlvl = dataReader.GetString("user_lvl");
                }
                connection.Close();
            }
            catch (MySqlException) { }
            return userlvl;
            
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {

        }

        private void initTime()
        {
            Timer t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }

        void t_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToLongDateString();
            label7.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

          public void button5_Click(object sender, EventArgs e)
          {
              int notifno = Convert.ToInt32(label2.Text);
              bool check = true;
              try
              {
                  connection.Open();
                  string query = "SELECT * FROM logintbl where stat1 = 'not approved'";
                  MySqlCommand cmd = new MySqlCommand(query, connection);
                  MySqlDataReader dataReader = cmd.ExecuteReader();
                  while (dataReader.Read())
                  {
                      check = false;
                  }
              }
              catch (MySqlException) { }
              connection.Close();
              if (notifno !=0)
              {
                 
                  Notification notif = new Notification();
                  notif.Show();
              }
              else if (notifno == 0)
              {
                  MessageBox.Show("No notifications");
              }
              
          }

          private void button7_Click(object sender, EventArgs e)
          {
              
          }

          private void button6_Click(object sender, EventArgs e)
          {
              
          }

          private void button4_Click_1(object sender, EventArgs e)
          {
              string stat = "out";
              int uid=0;
              log = label3.Text;
              try
              {
                  connection.Open();
                  string query1 = "SELECT * from logintbl where stat = 'in' and username ='"+log+"'";
                  MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                  MySqlDataReader dataReader = cmd1.ExecuteReader();
                  while (dataReader.Read())
                  {
                      uid = dataReader.GetInt32("userid");
                  }
              }
              catch (MySqlException) { }
              connection.Close();
              try
              {
                  connection.Open();
                  string query = "UPDATE logintbl set stat = '"+stat+"' where userid = '"+uid+"'";
                  MySqlCommand cmd = new MySqlCommand(query, connection);
                  cmd.ExecuteNonQuery();
              }
              catch (MySqlException) { }
              connection.Close();
              MessageBox.Show("Successfully logged out");
              Logframe lf = new Logframe();
              lf.Show();
             
          }

          private void panel9_Paint(object sender, PaintEventArgs e)
          {

          }

          private void panel4_Paint(object sender, PaintEventArgs e)
          {

          }

          private void label4_Click(object sender, EventArgs e)
          {

          }

          private void label21_Click(object sender, EventArgs e)
          {

          }

          private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
          {
              if(comboBox1.SelectedItem.Equals("Logout")){
                  string loguser = "";
                  loguser = label3.Text;
                  string stat = "out";
                  int uid=0;
                  try
                  {
                      connection.Open();
                      string query1 = "SELECT * from logintbl where stat = 'in' and username = '"+loguser+"'";
                      MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                      MySqlDataReader dataReader = cmd1.ExecuteReader();
                      while (dataReader.Read())
                      {
                          uid = dataReader.GetInt32("userid");
                      }
                  }
                  catch (MySqlException) { }
                  connection.Close();
                  try
                  {
                      connection.Open();
                      string query = "UPDATE logintbl set stat = '" + stat + "' where userid = '" + uid + "'";
                      MySqlCommand cmd = new MySqlCommand(query, connection);
                      cmd.ExecuteNonQuery();
                  }
                  catch (MySqlException) { }
                  connection.Close();
                  MessageBox.Show("Successfully logged out");
                  Logframe lf = new Logframe();
                  lf.Show();
                  this.Hide();
              }
              if(comboBox1.SelectedItem.Equals("Add User"))
              {
                  AddUser au = new AddUser();
                  au.Show();
                  comboBox1.SelectedIndex = 0;
              }
              if(comboBox1.SelectedItem.Equals("Add Admin"))
              {
                  AddAdmin aa = new AddAdmin();
                  aa.Show();
                  comboBox1.SelectedIndex = 0;
              }
          }

          private void button4_Click_2(object sender, EventArgs e)
          {
              Reports rep = new Reports();
              rep.Show();
              
          }

          private void button6_Click_1(object sender, EventArgs e)
          {
              Samplee se = new Samplee();
              se.Show();
              
          }

          private void Menu_Load(object sender, EventArgs e)
          {
              string user = "", userlvl = "", datenow = "", upcomingdate = "";
              int uid = 0, count = 0, count1 = 0, totalcount = 0, count2 = 0;
              log = label3.Text;
              datenow = DateTime.Today.ToString("yyyy-MM-dd");
              upcomingdate = DateTime.Today.AddDays(5).ToString("yyyy-MM-dd");

              try
              {
                  connection.Open();
                  string query3 = "SELECT COUNT(userid) from logintbl where stat1 = 'not approved'";
                  MySqlCommand cmd3 = new MySqlCommand(query3, connection);
                  MySqlDataReader dataReader3 = cmd3.ExecuteReader();
                  while (dataReader3.Read())
                  {
                      count = dataReader3.GetInt32("COUNT(userid)");
                  }
              }
              catch (MySqlException) { }
              connection.Close();

              try
              {
                  connection.Open();
                  string query2 = "SELECT COUNT(DISTINCT(pno)),SUM(tbal) from balancetbl" +
                  " where balno IN (SELECT MAX(balno) from balancetbl ba,billingtbl b where ba.balno = b.balanceno group by ba.pno,b.servicename)" +
                  " and baldate IN (SELECT MAX(baldate) from balancetbl ba,billingtbl b where ba.balno = b.balanceno group by ba.pno,b.servicename)" +
                  " group by pno having SUM(tbal) > 0";
                  MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                  MySqlDataReader dataReader2 = cmd2.ExecuteReader();
                  while (dataReader2.Read())
                  {
                      count1 += dataReader2.GetInt32("COUNT(DISTINCT(pno))");
                  }
              }
              catch (MySqlException me) { MessageBox.Show(me.Message); }
              connection.Close();

              connection.Open();
              string query4 = "SELECT COUNT(*) from appointmenttbl where appointdate between '" + datenow + "' and '" + upcomingdate + "'";
              MySqlCommand cmd4 = new MySqlCommand(query4, connection);
              MySqlDataReader dataReader4 = cmd4.ExecuteReader();
              while (dataReader4.Read())
              {
                  count2 = dataReader4.GetInt32("COUNT(*)");
              }
              connection.Close();
              totalcount = count + count1 + count2;

              if (totalcount == 0 || userlvl == "User")
              {
                  label2.Hide();
              }
              else
              {
                  label2.Show();
              }

              label2.Text = totalcount.ToString();

              connection.Open();
              string query1 = "SELECT * from logintbl where  username = '" + log + "' and stat = 'in'";
              MySqlCommand cmd1 = new MySqlCommand(query1, connection);
              MySqlDataReader dataReader1 = cmd1.ExecuteReader();
              while (dataReader1.Read())
              {
                  uid = dataReader1.GetInt32("userid");
                  user = dataReader1.GetString("username");
                  userlvl = dataReader1.GetString("user_lvl");
              }
              connection.Close();
              comboBox1.Items.Add(user);
              comboBox1.Text = user;
              if (userlvl == "User")
              {
                  button5.Hide();
                  label2.Hide();
                  comboBox1.Items.Add("Logout");
              }
              else if (userlvl == "Admin")
              {
                  button5.Show();
                  label2.Show();
                  comboBox1.Items.Add("Add Admin");
                  comboBox1.Items.Add("Add User");
                  comboBox1.Items.Add("Logout");
              }
          }
    }
}
