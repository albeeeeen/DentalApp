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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string user = "", pass = "", cpass = "", status = "out", username = "", userlvl = "User",stat1="approved";
            bool check = true, checker = true, checking = false;
            int ctr = 1, ctr1 = 0;
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                user = textBox1.Text.Trim();
                if (user.Length == 0)
                {
                    label1.Text = "Please input username";
                    checking = true;
                }
            }
            catch (FormatException)
            {
         
            }
            try
            {
                pass = textBox2.Text.Trim();
                if (pass.Length == 0)
                {
                    label9.Text = "No password inputted";
                    checking = true;
                }
                cpass = textBox3.Text;
            }
            catch (FormatException)
            {
                
            }
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
                        label9.Text = "User already exists";
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
                    check = false;
                }
                else
                {
                    checker = false;
                }

            }
            catch (MySqlException) { }
            connection.Close();

            if (pass.Equals(cpass) == false)
            {
                label9.Text = "Password doesn't match";
                checker = true;
            }
            else
            {
                checker = false;
            }
            if (check == false && checker == false && checking == false)
            {
                try
                {
                    connection.Open();
                    string query1 = "INSERT into logintbl values('" + ctr + "','" + user + "','" + pass + "','" + status + "','" + userlvl + "','"+stat1+"')";
                    MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added User");
                }
                catch (MySqlException) { MessageBox.Show("User id already occupied please try again!"); }
                connection.Close();
                this.Hide();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            string pass = textBox2.Text, cpass = textBox3.Text;
            if (cpass.Equals(pass) == false)
            {
                label9.Text = "Password doesn't match";
                
            }
            else
            {
                label9.Text = "";
            }
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            label9.Text = "";
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            label9.ResetText();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label1.ResetText();
        }
    }
}
