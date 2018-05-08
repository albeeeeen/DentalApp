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
    public partial class AdSearch : Form
    {
        public AdSearch()
        {
            InitializeComponent();
            comboBox210.Items.Add("");
            int yearnow = Convert.ToInt32(DateTime.Now.Year);
            for (int x = yearnow; x >= 1950; x--)
            {
                comboBox210.Items.Add(x);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Maintenance mainte = new Maintenance();
            mainte.dataGridView1.Rows.Clear();
            string connectionString = "datasource=dayto" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
               + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sname = "";
            string name = "", add = "", gender = "", month = "", year = "";
            int pno, age = 0;
            long cno = 0;
            try
            {
                sname = searchbox.Text;
            }
            catch (NullReferenceException) { }
            try
            {
                year = comboBox210.SelectedItem.ToString();
            }
            catch (NullReferenceException) { }
            try
            {
                if (radioButton10.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
            }
            catch (NullReferenceException) { }
            try
            {
                if (comboBox209.SelectedItem == "January")
                {
                    month = "01";
                }
                if (comboBox209.SelectedItem == "February")
                {
                    month = "02";
                }
                if (comboBox209.SelectedItem == "March")
                {
                    month = "03";
                }
                if (comboBox209.SelectedItem == "April")
                {
                    month = "04";
                }
                if (comboBox209.SelectedItem == "May")
                {
                    month = "05";
                }
                if (comboBox209.SelectedItem == "June")
                {
                    month = "06";
                }
                if (comboBox209.SelectedItem == "July")
                {
                    month = "07";
                }
                if (comboBox209.SelectedItem == "August")
                {
                    month = "08";
                }
                if (comboBox209.SelectedItem == "September")
                {
                    month = "09";
                }
                if (comboBox209.SelectedItem == "October")
                {
                    month = "10";
                }
                if (comboBox209.SelectedItem == "November")
                {
                    month = "11";
                }
                if (comboBox209.SelectedItem == "December")
                {
                    month = "12";
                }
            }
            catch (NullReferenceException) { }

            if (string.IsNullOrWhiteSpace(name) == false)
            {
                try
                {
                    connection.Open();
                    string query = "select pno,pname,pcno,paddress from patienttbl where (pname like '%" + sname + "%' or pname is null) and (pgender = '" + gender + "' or pgender is null) and (month(pbday) = '" + month + "' or month(pbday) is null) and (year(pbday) = '" + year + "' or year(pbday) is null)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        pno = dataReader.GetInt32("pno");
                        name = dataReader.GetString("pname");
                        cno = dataReader.GetInt64("pcno");
                        add = dataReader.GetString("paddress");
                        mainte.dataGridView1.Rows.Add(pno, name, cno, add);
                    }
                }
                catch (MySqlException me) { MessageBox.Show(me.Message); }
                connection.Close();
            }
            else if (radioButton10.Checked || radioButton11.Checked)
            {
                try
                {
                    connection.Open();
                    string query = "select pno,pname,pcno,paddress from patienttbl where (pname like '%" + sname + "%' or pname is null) and (pgender = '" + gender + "' or pgender is null) and (month(pbday) = '" + month + "' or month(pbday) is null) and (year(pbday) = '" + year + "' or year(pbday) is null)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        pno = dataReader.GetInt32("pno");
                        name = dataReader.GetString("pname");
                        cno = dataReader.GetInt64("pcno");
                        add = dataReader.GetString("paddress");
                        mainte.dataGridView1.Rows.Add(pno, name, cno, add);
                    }
                }
                catch (MySqlException me) { MessageBox.Show(me.Message); }
                connection.Close();
            }
            else if (string.IsNullOrWhiteSpace(month) == false)
            {
                try
                {
                    connection.Open();
                    string query = "select pno,pname,pcno,paddress from patienttbl where (pname like '%" + sname + "%' or pname is null) and (pgender = '" + gender + "' or pgender is null) and (month(pbday) = '" + month + "' or month(pbday) is null) and (year(pbday) = '" + year + "' or year(pbday) is null)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        pno = dataReader.GetInt32("pno");
                        name = dataReader.GetString("pname");
                        cno = dataReader.GetInt64("pcno");
                        add = dataReader.GetString("paddress");
                        mainte.dataGridView1.Rows.Add(pno, name, cno, add);
                    }
                }
                catch (MySqlException me) { MessageBox.Show(me.Message); }
                connection.Close();
            }
            else if (string.IsNullOrWhiteSpace(year) == false)
            {
                try
                {
                    connection.Open();
                    string query = "select pno,pname,pcno,paddress from patienttbl where (pname like '%" + sname + "%' or pname is null) and (pgender = '" + gender + "' or pgender is null) and (month(pbday) = '" + month + "' or month(pbday) is null) and (year(pbday) = '" + year + "' or year(pbday) is null)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        pno = dataReader.GetInt32("pno");
                        name = dataReader.GetString("pname");
                        cno = dataReader.GetInt64("pcno");
                        add = dataReader.GetString("paddress");
                        mainte.dataGridView1.Rows.Add(pno, name, cno, add);
                    }
                }
                catch (MySqlException me) { MessageBox.Show(me.Message); }
                connection.Close();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
