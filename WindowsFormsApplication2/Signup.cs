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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Logframe lf = new Logframe();
            lf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.ResetText();
            string user = "", pass = "", cpass = "",status = "out",username="",userlvl="",status1="";
            bool check = true,checker = true,checking = true;
            int ctr = 1,ctr1=0;
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);

            user = textBox1.Text;
            pass = textBox2.Text;
            cpass = textBox3.Text;
           
            try
            {
                connection.Open();
                string query1 = "SELECT username from logintbl";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    username = dataReader.GetString("username");
                    ctr += 1;
                    ctr1 = 1;
                    if (user.Equals(username))
                    {
                        label4.Text = "Username already exists!";
                        check = true;
                        checker = true;
                        break;
                    }
                    else
                    {
                        check = false;
                    }
                    
                }
                if (ctr1 == 0)
                {
                    if (radioButton1.Checked == true)
                    {
                        userlvl = "Admin";
                        status1 = "approved";
                    }
                    else
                    {
                        userlvl = "User";
                        status1 = "not approved";
                    }
                    check = false;
                }
                else
                {
                    if (radioButton1.Checked == true)
                    {
                        userlvl = "Admin";
                        status1 = "not approved";
                    }
                    else
                    {
                        userlvl = "User";
                        status1 = "not approved";
                    }
                    checker= false;
                }
               
            }
            catch (MySqlException) { }
            connection.Close();
            
            if (cpass.Equals(pass) == false)
            {
                label4.Text = "Password doesn't match";
                checker = true;
            }
            else
            {
                checker = false;
            }
            if (check == false && checker == false)
            {
                try
                {
                    connection.Open();
                    string query1 = "INSERT into logintbl values('"+ctr+"','" + user + "','" + pass + "','" + status + "','"+userlvl+"','"+status1+"')";
                    MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Sign up successfully");
                }
                catch (MySqlException) { }
                connection.Close();
                this.Hide();
                Logframe lf = new Logframe();
                lf.Show();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label4.ResetText();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.ResetText();
            label4.ResetText();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.ResetText();
            label4.ResetText();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            string cpass = textBox3.Text;
            string pass = textBox2.Text;
            if (cpass.Equals(pass) == false)
            {
                label4.Text = "Password doesn't match";
                textBox3.Text = "";
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label4.Text = "";
        }
    }
}
