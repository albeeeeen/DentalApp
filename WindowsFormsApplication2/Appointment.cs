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
    public partial class Appointment : Form
    {
        static string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
              + ";" + "PASSWORD=password" + ";";
        MySqlConnection connection = new MySqlConnection(connectionString);
        public Appointment()
        {
            InitializeComponent();
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "hh:mm tt";
            string pname = "", sname = "";
            
            int ctr = 0;

            dateTimePicker1.MinDate = DateTime.Now;

            connection.Open();
            string query1 = "select servicename from servicestbl";
            MySqlCommand cmd1 = new MySqlCommand(query1, connection);
            MySqlDataReader dataReader1 = cmd1.ExecuteReader();
            while (dataReader1.Read())
            {
                sname = dataReader1.GetString("servicename");
                comboBox2.Items.Add(sname);
            }
            connection.Close();
            monthCalendar1.Show();
            dataGridView1.Hide();
            button3.Hide();
            listBox1.Hide();
            listBox2.Hide();
            ctr = GenerateAppointNo();
            label10.Text = ctr.ToString();
            BoldDate();
            button2.Hide();
        }
        public void BoldDate()
        {
            DateTime day;
            List<DateTime> date = new List<DateTime>();
            connection.Open();
            string query2 = "SELECT DATE_FORMAT(appointdate,'%Y-%m-%d') from appointmenttbl";
            MySqlCommand cmd2 = new MySqlCommand(query2, connection);
            MySqlDataReader dataReader2 = cmd2.ExecuteReader();
            while (dataReader2.Read())
            {
                day = dataReader2.GetDateTime("DATE_FORMAT(appointdate,'%Y-%m-%d')");
                date.Add(day);
            }
            connection.Close();
            DateTime[] adate = date.ToArray();
            this.monthCalendar1.BoldedDates = adate;
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbackbtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

            int ctr1 = GenerateAppointment();
            if (ctr1 == 0)
            {
                MessageBox.Show("No appointment on this date");
            }
            else
            {
                button3.Show();
                dataGridView1.Show();
                button2.Show();
                monthCalendar1.Hide();
            }
        }
        public int GenerateAppointment()
        {
            dataGridView1.Rows.Clear();
            string date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            int pno = 0, bal = 0, ctr = 0, appno = 0, ctr1 = 0;
            string pname = "", date1 = "", time = "", service = "", status = "";

            connection.Open();
            string query1 = "SELECT appointno,pno,pname,DATE_FORMAT(appointdate,'%Y-%m-%d'),appointtime,service,appointstatus" +
                " from appointmenttbl" +
                " where appointdate = '" + date + "'";
            MySqlCommand cmd1 = new MySqlCommand(query1, connection);
            MySqlDataReader dataReader1 = cmd1.ExecuteReader();
            while (dataReader1.Read())
            {
                ctr = 1;
                pname = dataReader1.GetString("pname");
                date1 = dataReader1.GetString("DATE_FORMAT(appointdate,'%Y-%m-%d')");
                time = dataReader1.GetString("appointtime");
                service = dataReader1.GetString("service");
                appno = dataReader1.GetInt32("appointno");
                status = dataReader1.GetString("appointstatus");
                dataGridView1.Rows.Add(appno, pname, date1, time, service, status);
            }
            connection.Close();
            return ctr;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            button3.Hide();
            dataGridView1.Hide();
            button2.Hide();
            monthCalendar1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label11.ResetText();
            int ctr = 0;
            string lname = "",lname2="",mi="",fname2="";
            lname = textBox1.Text;

            connection.Open();
            string query = "select plname from patienttbl where plname LIKE '%" + lname + "%'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                lname = dataReader.GetString("plname");
                listBox1.Items.Add(lname);
                ctr = 1;
            }
            connection.Close();
            if (textBox1.Text.Trim().Length == 0 || ctr == 0)
            {
                listBox1.Hide();
            }
            else if (ctr == 1 && (textBox1.Text.Trim().Length > 0 && textBox1.Text.Length <= 5))
            {
                listBox1.Show();
            }
            lname2 = textBox1.Text;
            fname2 = textBox2.Text;
            connection.Open();
            string query1 = "select pminitial from patienttbl where plname = '" + lname2 + "' and pfname = '" + fname2 + "'";
            MySqlCommand cmd1 = new MySqlCommand(query1, connection);
            MySqlDataReader dataReader1 = cmd1.ExecuteReader();
            while (dataReader1.Read())
            {
                mi = dataReader1.GetString("pminitial");
            }
            connection.Close();
            textBox3.Text = mi;
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox1.Hide();
            
            string pname = "";
            int maxday = 0, maxmonth = 0, maxyear = 0,daynow=0,monthnow=0,yearnow=0,ctr=0;

            daynow = DateTime.Today.Day;
            monthnow = DateTime.Today.Month;
            yearnow = DateTime.Today.Year;

            try
            {
                pname = listBox1.SelectedItem.ToString();
            }
            catch (NullReferenceException) { }
            textBox1.ResetText();
            listBox1.Items.Clear();
            textBox1.Text = pname;
            
            connection.Open();
            string query1 = "SELECT DATE_FORMAT(MAX(appointdate),'%Y'),DATE_FORMAT(MAX(appointdate),'%m'),DATE_FORMAT(MAX(appointdate),'%d') from appointmenttbl where pname LIKE '%" + pname + "%'";
            MySqlCommand cmd1 = new MySqlCommand(query1, connection);
            MySqlDataReader dataReader1 = cmd1.ExecuteReader();
            while (dataReader1.Read())
            {
                    ctr = 1;
                    try
                    {
                        maxday = dataReader1.GetInt32("DATE_FORMAT(MAX(appointdate),'%d')");
                        maxmonth = dataReader1.GetInt32("DATE_FORMAT(MAX(appointdate),'%m')");
                        maxyear = dataReader1.GetInt32("DATE_FORMAT(MAX(appointdate),'%Y')");
                    }
                    catch (Exception)
                    {
                        maxyear = yearnow;
                        maxmonth = monthnow;
                        maxday = daynow;
                    }
                    
            }
            connection.Close();
            if (ctr == 1)
            {
                dateTimePicker1.MinDate = new DateTime(maxyear, maxmonth, maxday);
                dateTimePicker1.Value = new DateTime(maxyear, maxmonth, maxday);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string lname = "", fname = "", mi = "", pname = "", date = "", time = "", service = "", checkdate = "", checktime = "", status = "pending";
                int appointno = 0, pno = 0, ctr = 0, ctr1 = 0, uid = 0;
                bool checker = true, check = true;
                lname = textBox1.Text.Trim();
                fname = textBox2.Text.Trim();
                mi = textBox3.Text;
                pname = lname + ", " + fname + " " + mi;
                if (lname.Length == 0)
                {
                    label11.Text = "*Required";
                    check = false;
                    checker = false;
                }
                if (fname.Length == 0)
                {
                    label1.Text = "*Required";
                    check = false;
                    checker = false;
                }
                date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                try
                {
                    service = comboBox2.SelectedItem.ToString();
                }
                catch (NullReferenceException)
                {
                    label12.Text = "Please select service";
                    check = false;
                    checker = false;
                }

                time = dateTimePicker2.Value.ToShortTimeString();
                appointno = Convert.ToInt32(label10.Text);

                connection.Open();
                string query = "SELECT pno from patienttbl where CONCAT(plname,', ',pfname,' ',pminitial) = '" + pname + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    pno = dataReader.GetInt32("pno");
                    ctr = 1;
                }
                connection.Close();
                connection.Open();
                string query5 = "SELECT * from logintbl where stat = 'in'";
                MySqlCommand cmd5 = new MySqlCommand(query5, connection);
                MySqlDataReader dataReader5 = cmd5.ExecuteReader();
                while (dataReader5.Read())
                {
                    uid = dataReader5.GetInt32("userid");
                }
                connection.Close();
                if (ctr == 0)
                {
                    connection.Open();
                    string query2 = "SELECT * from patienttbl";
                    MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                    MySqlDataReader dataReader2 = cmd2.ExecuteReader();
                    while (dataReader2.Read())
                    {
                        pno = dataReader2.GetInt32("pno");
                        ctr1 = 1;
                    }
                    pno = pno + 1;
                    connection.Close();
                    if (check == true)
                    {
                        connection.Open();
                        string query4 = "INSERT INTO patienttbl(pno,uid) values('" + pno + "','" + uid + "')";
                        MySqlCommand cmd4 = new MySqlCommand(query4, connection);
                        cmd4.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                connection.Open();
                string query3 = "SELECT DATE_FORMAT(appointdate,'%Y-%m-%d'), appointtime from appointmenttbl";
                MySqlCommand cmd3 = new MySqlCommand(query3, connection);
                MySqlDataReader dataReader3 = cmd3.ExecuteReader();
                while (dataReader3.Read())
                {
                    checkdate = dataReader3.GetString("DATE_FORMAT(appointdate,'%Y-%m-%d')");
                    checktime = dataReader3.GetString("appointtime");
                    if (checkdate.Equals(date) && checktime.Equals(time))
                    {
                        MessageBox.Show("There's already patient appointed on this date and time");
                        checker = false;
                    }
                }
                connection.Close();
                if ((ctr == 1 || ctr1 == 1) && checker == true)
                {
                    if (System.IO.Directory.Exists(@"C:\Users\Public\Documents\Appointments"))
                    {
                        connection.Open();
                        string query1 = "INSERT INTO appointmenttbl values ('" + appointno + "','" + date + "','" + pno + "','" + pname + "','" + service + "','" + time + "','" + status + "')";
                        MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Appointment Added");
                        connection.Close();
                        Appoint appoint = new Appoint();
                        appoint.Show();
                        appoint.label1.Text = pname;
                        appoint.label2.Text = service;
                        appoint.label3.Text = date;
                        appoint.label4.Text = time;
                        textBox1.ResetText();
                        textBox2.ResetText();
                        comboBox2.ResetText();
                        BoldDate();
                    }
                    else
                    {
                        MessageBox.Show("No folder for Appointments. Please create a folder named 'Appointments' in public documents to have a copy of pdf");
                    }
                }
            }
            catch (Exception) { MessageBox.Show("Sorry! Appointment number already occupied"); }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        public int GenerateAppointNo()
        {
            int ctr = 1;
            try
            {
                connection.Open();
                string query2 = "SELECT * from appointmenttbl";
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                MySqlDataReader dataReader1 = cmd2.ExecuteReader();
                while (dataReader1.Read())
                {
                    ctr = dataReader1.GetInt32("appointno");
                    ctr += 1;
                }
            }
            catch (MySqlException) { }
            connection.Close();
            return ctr;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string pname = "",service="",date="",status="";
            int ctr = 0, pno = 0, ctr1 = 0,age=0,appno=0;
            bool check = true;

            pname = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            service = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            date = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            appno = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Maintenance mainte = new Maintenance();
            Billing bill = new Billing();

            connection.Open();
            string query2 = "SELECT * from appointmenttbl where appointno = '" + appno + "'";
            MySqlCommand cmd2 = new MySqlCommand(query2, connection);
            MySqlDataReader dataReader2 = cmd2.ExecuteReader();
            while (dataReader2.Read())
            {
                pno = dataReader2.GetInt32("pno");
                status = dataReader2.GetString("appointstatus");
            }
            connection.Close();
            if (status.Equals("cancelled"))
            {
                MessageBox.Show("This appointment was already cancelled");
                check = false;
            }
            else if (status.Equals("done"))
            {
                MessageBox.Show("This appointment was already done");
                check = false;
            }
            connection.Open();
            string query = "SELECT * from patienttbl where CONCAT(plname,', ',pfname,' ',pminitial) = '" + pname + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                ctr = 1;
                
            }
            connection.Close();
            
            connection.Open();
            string query1 = "SELECT * FROM billingtbl b,patienttbl p,balancetbl ba where CONCAT(p.plname,', ',p.pfname,' ',p.pminitial) = '" + pname + "' and b.servicename = '" + service + "' and p.pno = b.pnum and b.pnum = ba.pno and ba.tbal > 0";
            MySqlCommand cmd1 = new MySqlCommand(query1, connection);
            MySqlDataReader dataReader1 = cmd1.ExecuteReader();
            while (dataReader1.Read())
            {
                ctr1 = 1;
            }
            connection.Close();

            if (check == true)
            {
                if (ctr == 0)
                {
                    MessageBox.Show("The patient were added through call only, Please make a record immediately");
                    this.Hide();
                    mainte.Show();
                    mainte.panel1.BringToFront();
                    mainte.panel66.SendToBack();
                    mainte.button1.Hide();
                    mainte.button29.Show();
                    mainte.label144.Text = pno.ToString();
                    mainte.button27.Show();
                    mainte.button23.Hide();
                }
                if (ctr == 1 && ctr1 == 1)
                {
                    this.Hide();
                    mainte.Show();
                    mainte.panel66.Show();
                    mainte.panel1.SendToBack();
                    mainte.pbackbtn.Hide();
                    mainte.button2.Hide();
                    mainte.button28.Show();
                    mainte.txtname2.Text = pname;
                    mainte.txtpno2.Text = pno.ToString();
                    mainte.tabPage10.Show();
                    mainte.tabControl3.SelectTab("tabPage10");
                    for (int x = 0; x < mainte.transactionview.Rows.Count; x++)
                    {
                        if (service == mainte.transactionview.Rows[x].Cells[3].Value.ToString())
                        {
                            mainte.transactionview.Rows[x].Cells[1].Value = date;
                        }

                    }

                }
                else if (ctr == 1 && ctr1 == 0)
                {
                    
                    mainte.Show();
                    mainte.panel66.Show();
                    mainte.panel1.SendToBack();
                    mainte.pbackbtn.Hide();
                    mainte.button2.Hide();
                    mainte.button28.Show();
                    mainte.txtname2.Text = pname;
                    mainte.txtpno2.Text = pno.ToString();
                    mainte.tabPage8.Show();
                    mainte.tabControl3.SelectTab("tabPage8");
                    mainte.label184.Text = service;
                    mainte.label185.Text = date;
                    this.Hide();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            label12.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string status = "cancelled";
            int appno = 0;
            appno = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            try
            {
                connection.Open();
                string query = "UPDATE appointmenttbl set appointstatus = '" + status + "' where appointno = '" + appno + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment Cancelled");
                connection.Close();
                GenerateAppointment();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            label1.ResetText();
            int ctr = 0;
            string fname = "",lname="",mi="",fname2="";
            fname = textBox2.Text;
            lname = textBox1.Text;
            connection.Open();
            string query = "select pfname from patienttbl where plname = '"+lname+"' and pfname LIKE '%" + fname + "%'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                fname = dataReader.GetString("pfname");
                listBox2.Items.Add(fname);
                ctr = 1;
            }
            connection.Close();
            if (textBox2.Text.Trim().Length == 0 || ctr == 0)
            {
                listBox2.Hide();
            }
            else if (ctr == 1 && (textBox2.Text.Trim().Length > 0 && textBox2.Text.Length <= 4))
            {
                listBox2.Show();
            }
            fname2 = textBox2.Text;
            connection.Open();
            string query1 = "select pminitial from patienttbl where plname = '" + lname + "' and pfname = '" + fname2 + "'";
            MySqlCommand cmd1 = new MySqlCommand(query1, connection);
            MySqlDataReader dataReader1 = cmd1.ExecuteReader();
            while (dataReader1.Read())
            {
                mi = dataReader1.GetString("pminitial");
            }
            connection.Close();
            textBox3.Text = mi;
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox2.Hide();
            string fname = "";
            try
            {
                fname = listBox2.SelectedItem.ToString();
            }
            catch (NullReferenceException) { }
            textBox2.ResetText();
            listBox2.Items.Clear();
            textBox2.Text = fname;

            
        }

        private void listBox3_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }


    }
}
