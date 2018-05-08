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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.ResetText();
            label5.ResetText();
            label7.ResetText();
            string pass = "",oldpass="",newp="",confp="",user="",checkuser="";
            bool check = true,checker = true,boolcheck = false;
            int ctr = 0;
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                 + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            user = textBox1.Text;
            try
            {
                oldpass = textBox2.Text.Trim();
                if (oldpass.Length == 0)
                {
                    label4.Text = "Current password is required";
                    boolcheck = true;
                }
                
            }
            catch (FormatException) {
                
            }
            try
            {
                newp =  textBox3.Text.Trim();
                if (newp.Length == 0)
                {
                    label5.Text = "New password is required";
                    boolcheck = true;
                }
                confp = textBox4.Text;
            }
            catch (FormatException)
            {
                
            }
            try
            {
                connection.Open();
                string query1 = "SELECT username, password from logintbl where username = '"+user+"'";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    checkuser = dataReader.GetString("username");
                    pass = dataReader.GetString("password");
                    ctr = 1;
                }
            }
            catch (MySqlException) { }
            connection.Close();
            if (ctr == 0)
            {
                label7.Text = "Username not found!";
                check = true;
                checker = true;
            }
            else
            {
                if (oldpass.Equals(pass))
                {
                    check = false;
                }
                else
                {
                    check = true;
                    label4.Text = "Incorrect current password";
                }
                
            }

            if (newp.Equals(confp))
            {
                
                if (newp.Equals(pass) && confp.Equals(pass))
                {
                    checker = true;
                    label5.Text = "New password is already your current password";
                }
                else
                {
                    checker = false;
                }
            }
            else
            {
                label5.Text = "New Password doesn't match";
                check = true;
                checker = true;
            }
            
            if (check == false && checker ==false && boolcheck == false)
            {
                try
                {
                    connection.Open();
                    string query2 = "UPDATE logintbl set password = '"+newp+"' where username='"+user+"'";
                    MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Password successfully changed");
                    this.Hide();
                    Logframe lf = new Logframe();
                    lf.Show();
                }
                catch (MySqlException) { }
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logframe lf = new Logframe();
            lf.Show();
        }

       

        private void textBox2_Leave(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                 + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string oldpass = textBox2.Text, pass = "",newp = textBox3.Text,confp=textBox4.Text;
            string user = textBox1.Text;
            try
            {
                connection.Open();
                string query1 = "SELECT username, password from logintbl where username = '" + user + "'";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    pass = dataReader.GetString("password");
                }
            }
            catch (MySqlException) { }
            connection.Close();
            if (oldpass.Equals(pass) == false)
            {
                label4.Text = "Incorrect current password";
                textBox2.Text = "";
            }
            else
            {
                label4.Text = "";
            }
            if (newp.Equals(pass))
            {
                label5.Text = "New password is already your current password";
                textBox3.Text = "";
            }
            else
            {
                label5.Text = "";
            }
            if (confp.Equals(newp) == false)
            {
                label5.Text = "Password doesn't match";
                textBox4.Text = "";
            }
            else
            {
                label5.Text = "";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                 + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string pass = "", newp = textBox3.Text, confp = textBox4.Text;
            string user = textBox1.Text;
            try
            {
                connection.Open();
                string query1 = "SELECT username, password from logintbl where username = '" + user + "'";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    pass = dataReader.GetString("password");
                }
            }
            catch (MySqlException) { }
            connection.Close();
            if (newp.Equals(pass))
            {
                label5.Text = "New password is already your current password";
                textBox3.Text = "";
            }
            else
            {
                label5.Text = "";
            }
            if (confp.Equals(newp) == false)
            {
                label5.Text = "Password doesn't match";
                textBox4.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string user = "";
            bool check = true, checker = true;
            int ctr = 0;
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                 + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            user = textBox1.Text;
            try
            {
                connection.Open();
                string query1 = "SELECT username, password from logintbl where username = '" + user + "'";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    ctr = 1;
                }
            }
            catch (MySqlException) { }
            connection.Close();
            if (ctr == 0)
            {
                label7.Text = "Username not found!";
                textBox1.Text = "";
            }
            else
            {
                label7.Text = "";
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label5.Text = "";
            label4.Text = "";
            label7.Text = "";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label7.ResetText();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            label4.ResetText();
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            label5.ResetText();
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            label5.ResetText();
        }






    }
}
