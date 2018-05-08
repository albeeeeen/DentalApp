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
    public partial class Logframe : Form
    {
        public Logframe()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            promptlbl.ResetText();
            string uname, pass,logpass="",stat="",user="",status="", stat2 = "in";
            uname = textBox1.Text;
            pass = textBox2.Text.ToLower();

            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string query1 = "SELECT username,password,stat1,stat from logintbl where username = '"+uname+"'";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    logpass = dataReader.GetString("password");
                    user = dataReader.GetString("username");
                    stat = dataReader.GetString("stat1");
                    status = dataReader.GetString("stat");
                }
            }
            catch (MySqlException) { }
            connection.Close();

            if (uname.Equals(user) && pass.Equals(logpass) && stat.Equals("approved") && status.Equals("out"))
            {
                
                    connection.Open();
                    string query2 = "UPDATE logintbl set stat = '"+stat2+"' where username = '"+uname+"'";
                    MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Logged in Successfully");
                    connection.Close();
                    
                    Menu menu = new Menu();
                    menu.label3.Text = uname;
                    menu.Show();
                    this.Hide();
                
            }

            else if(uname.Equals(user) == false || pass.Equals(logpass) == false)
            {
               promptlbl.Text = "Invalid username or password";
            }
            else if (stat.Equals("approved") == false)
            {
                promptlbl.Text = "The user needs to be approved by the Admin";
            }
            else if (status.Equals("in"))
            {
                promptlbl.Text = "The user is already logged in";
            }
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            promptlbl.ResetText();
            textBox1.Clear();
            textBox1.Font = new Font("Lucida Sans Unicode", 12, FontStyle.Regular);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            ChangePass cp = new ChangePass();
            cp.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup su = new Signup();
            su.Show();
            this.Hide();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            promptlbl.ResetText();
            textBox2.Clear();
            textBox2.UseSystemPasswordChar = true ;
            textBox2.Font = new Font("Lucida Sans Unicode", 12, FontStyle.Regular);
        }

        private void textBox1_TabIndexChanged(object sender, EventArgs e)
        {
            promptlbl.ResetText();
            textBox1.Clear();
            textBox1.Font = new Font("Lucida Sans Unicode", 12, FontStyle.Regular);
            textBox2.Clear();
            textBox2.UseSystemPasswordChar = true;
            textBox2.Font = new Font("Lucida Sans Unicode", 12, FontStyle.Regular);
        }

        private void textBox2_TabIndexChanged(object sender, EventArgs e)
        {
            promptlbl.ResetText();
            textBox2.Clear();
            textBox2.UseSystemPasswordChar = true;
            textBox2.Font = new Font("Lucida Sans Unicode", 12, FontStyle.Regular);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            promptlbl.ResetText();
            textBox2.UseSystemPasswordChar = true;
            textBox2.Font = new Font("Lucida Sans Unicode", 12, FontStyle.Regular);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            promptlbl.ResetText();
            textBox1.Font = new Font("Lucida Sans Unicode", 12, FontStyle.Regular);
        }
    }
}
