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
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    public partial class Maintenance : Form
    {
        public Maintenance()
        {
            InitializeComponent();
            string connectionString;
            string userlvl = "";
            connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                 + ";" + "PASSWORD=password" + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            int ctr = 1;
            Form f = Application.OpenForms["Menu"];
            userlvl = (((Menu)f).User1());
            if (userlvl.Equals("User"))
            {
                panel3.Enabled = false;
                panel6.Enabled = false;
                panel8.Enabled = false;
                tabPage3.Enabled = false;
                updatebtn.Hide();
                button11.Hide();
                button12.Hide();
                button13.Hide();
                button5.Hide();
                button9.Hide();
            }
            else
            {
                updatebtn.Show();
                button5.Show();
                button9.Hide();
            }
            try
            {
                connection.Open();
                string query1 = "SELECT pno from patienttbl";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    ctr = dataReader.GetInt32("pno");
                    ctr += 1;
                }
                textBox2.Hide();
                textBox3.Hide();
                textBox7.Hide();
                textBox6.Hide();
            }
            catch (MySqlException) { }
            connection.Close();
            this.label144.Text = ctr.ToString();
            button3.Show();
            panel5.Show();
            TextCnum.Text = "09*********";
            panel65.Hide();

            groupBox8.Hide();
            int yearnow = Convert.ToInt32(DateTime.Now.Year);
            for (int x = yearnow; x >= 1950; x--)
            {
                comboBox210.Items.Add(x);
            }
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int max = DateTime.Now.Year - 5;
            dateTimePicker1.MaxDate = new DateTime(max, month, day);
            dateTimePicker1.Value = new DateTime(max, month, day);
            button2.Hide();
            pbackbtn.Show();

            button27.Hide();
            button28.Hide();
            label179.Hide();
            textBox17.Hide();
            button1.Show();
            button29.Hide();
            dataGridView4.Hide();
            button31.Hide();
            button20.Hide();
            dateTimePicker4.Hide();
            label164.Hide();
            button18.Hide();
            button10.Hide();

            comboBox208.Enabled = false;
            comboBox198.Enabled = false;
            comboBox207.Enabled = false;
            comboBox197.Enabled = false;
            comboBox206.Enabled = false;
            comboBox196.Enabled = false;
            comboBox205.Enabled = false;
            comboBox195.Enabled = false;
            comboBox204.Enabled = false;
            comboBox194.Enabled = false;
            comboBox203.Enabled = false;
            comboBox193.Enabled = false;
            comboBox202.Enabled = false;
            comboBox192.Enabled = false;
            comboBox201.Enabled = false;
            comboBox191.Enabled = false;
            comboBox200.Enabled = false;
            comboBox190.Enabled = false;
            comboBox199.Enabled = false;
            comboBox189.Enabled = false;
            comboBox184.Enabled = false;
            comboBox174.Enabled = false;
            comboBox185.Enabled = false;
            comboBox175.Enabled = false;
            comboBox186.Enabled = false;
            comboBox176.Enabled = false;
            comboBox187.Enabled = false;
            comboBox177.Enabled = false;
            comboBox188.Enabled = false;
            comboBox178.Enabled = false;
            comboBox166.Enabled = false;
            comboBox163.Enabled = false;
            comboBox167.Enabled = false;
            comboBox164.Enabled = false;
            comboBox168.Enabled = false;
            comboBox165.Enabled = false;
            comboBox183.Enabled = false;
            comboBox173.Enabled = false;
            comboBox182.Enabled = false;
            comboBox172.Enabled = false;
            comboBox181.Enabled = false;
            comboBox171.Enabled = false;
            comboBox180.Enabled = false;
            comboBox170.Enabled = false;
            comboBox179.Enabled = false;
            comboBox169.Enabled = false;
            comboBox162.Enabled = false;
            comboBox159.Enabled = false;
            comboBox161.Enabled = false;
            comboBox158.Enabled = false;
            comboBox160.Enabled = false;
            comboBox157.Enabled = false;
            comboBox152.Enabled = false;
            comboBox142.Enabled = false;
            comboBox153.Enabled = false;
            comboBox143.Enabled = false;
            comboBox154.Enabled = false;
            comboBox144.Enabled = false;
            comboBox155.Enabled = false;
            comboBox145.Enabled = false;
            comboBox156.Enabled = false;
            comboBox146.Enabled = false;
            comboBox134.Enabled = false;
            comboBox131.Enabled = false;
            comboBox136.Enabled = false;
            comboBox132.Enabled = false;
            comboBox135.Enabled = false;
            comboBox133.Enabled = false;
            comboBox151.Enabled = false;
            comboBox141.Enabled = false;
            comboBox150.Enabled = false;
            comboBox140.Enabled = false;
            comboBox149.Enabled = false;
            comboBox139.Enabled = false;
            comboBox148.Enabled = false;
            comboBox138.Enabled = false;
            comboBox147.Enabled = false;
            comboBox137.Enabled = false;
            comboBox130.Enabled = false;
            comboBox129.Enabled = false;
            comboBox128.Enabled = false;
            comboBox127.Enabled = false;
            comboBox126.Enabled = false;
            comboBox125.Enabled = false;
            comboBox120.Enabled = false;
            comboBox110.Enabled = false;
            comboBox121.Enabled = false;
            comboBox111.Enabled = false;
            comboBox122.Enabled = false;
            comboBox112.Enabled = false;
            comboBox123.Enabled = false;
            comboBox113.Enabled = false;
            comboBox124.Enabled = false;
            comboBox114.Enabled = false;
            comboBox119.Enabled = false;
            comboBox109.Enabled = false;
            comboBox118.Enabled = false;
            comboBox108.Enabled = false;
            comboBox117.Enabled = false;
            comboBox107.Enabled = false;
            comboBox116.Enabled = false;
            comboBox106.Enabled = false;
            comboBox115.Enabled = false;
            comboBox105.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Appointment mh = new Appointment();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            namebox.Clear();
        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void namebox_Click(object sender, EventArgs e)
        {
            promptlbl.ResetText();
        }

        private void TextAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TextPName_TextChanged(object sender, EventArgs e)
        {

        }




        private void searchbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dhbtn_Click(object sender, EventArgs e)
        {
            tabPage3.Show();
            tabControl2.SelectTab("tabPage3");
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        public void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            search();
        }

        public void search()
        {
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                  + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sname = textBox9.Text;
            string lname = "",fname="",mi="", add = "",city="",fulladd="",fullname="";
            int pno, uid = 0;
            string cno = "";
            Form f = Application.OpenForms["Menu"];
            uid = (((Menu)f).User());
           

                connection.Open();
                string query1 = "SELECT * from patienttbl";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    pno = dataReader.GetInt16("pno");
                    lname = dataReader.GetString("plname");
                    fname = dataReader.GetString("pfname");
                    try
                    {
                        mi = dataReader.GetString("pminitial");
                    }
                    catch (Exception)
                    {
                        mi = "";
                    }
                    cno = dataReader.GetString("pcno");
                    add = dataReader.GetString("paddress");
                    city = dataReader.GetString("city");
                    fulladd = add + "," + city;
                    fullname = lname + ", " + fname + " " + mi;
                    dataGridView1.Rows.Add(pno, fullname, cno, fulladd);
                
            }
                connection.Close();
           
        }

        private void pbackbtn_Click(object sender, EventArgs e)
        {
            panel66.Hide();
            label72.Hide();
            label20.Show();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int age1 = DateTime.Now.Year - dateTimePicker3.Value.Year;
            if (dateTimePicker3.Value.AddYears(age1) > DateTime.Now)
            {
                age1--;
            }
            txtage2.Text = age1.ToString();
            button10.Show();
            txtadd2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtcity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtcno2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtoccu2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtpoccu2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtpname2.BorderStyle = BorderStyle.Fixed3D;
            txtname2.BorderStyle = BorderStyle.Fixed3D;
            textBox18.BorderStyle = BorderStyle.Fixed3D;
            textBox19.BorderStyle = BorderStyle.Fixed3D;

            txtcity.ReadOnly = false;
            txtname2.ReadOnly = false;
            txtpname2.ReadOnly = false;
            txtpoccu2.ReadOnly = false;
            txtadd2.ReadOnly = false;
            txtcno2.ReadOnly = false;
            txtoccu2.ReadOnly = false;
            textBox18.ReadOnly = false;
            textBox19.ReadOnly = false;
            updatebtn.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int age = 0;
            long cno = 0;
            string num = "";
            bool check = true;
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
             + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                age = Convert.ToInt32(txtage2.Text);
                cno = Convert.ToInt64(txtcno2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input");
                check = false;
            }
            string add = txtadd2.Text;
            string occu = txtoccu2.Text;
            string poccu = txtpoccu2.Text;
            string parent = txtpname2.Text;
            string city = txtcity.Text;
            string lname = txtname2.Text.Trim(),fname = textBox18.Text.Trim(),mi = textBox19.Text.Trim();
            if (lname.Length == 0)
            {
                MessageBox.Show("Last Name should be filled-up");
                check = false;
            }
            else if (fname.Length == 0)
            {
                MessageBox.Show("First name should be filled-up");
                check = false;
            }
            int pnum = Convert.ToInt32(txtpno2.Text);
            if (check)
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE patienttbl set  plname = '"+lname+"',pfname='"+fname+"',pminitial='"+mi+"',page = '" + age + "',pcno = '" + cno + "',paddress = '" + add + "',city = '"+city+"',poccu='" + occu + "',gname = '"+parent+"',goccu = '" + poccu + "' where pno = '" + pnum + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Information were updated");
                }

                catch (MySqlException ee)
                {
                    MessageBox.Show(ee.Message);
                }
                connection.Close();
                panel66.Hide();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string date;
            date = dateTimePicker2.Value.ToString("MM-dd-yyyy");
            prescriptionview.Rows.Add(date, "");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string date = "", prescript = "";
            date = prescriptionview.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker2.Value.ToString(date);
            prescript = prescriptionview.CurrentRow.Cells[1].Value.ToString();
            richTextBox1.Text = prescript;
            label143.Show();
            button15.Hide();
            button17.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string date, pres;
            int rows, pno;
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                 + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);

            pno = Convert.ToInt32(txtpno2.Text);
            date = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            pres = richTextBox1.Text;
            try
            {
                connection.Open();
                string query = "INSERT INTO prescripttbl values ('" + date + "','" + pres + "','" + pno + "')";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Information addedd");
                richTextBox1.ResetText();
            }
            catch (MySqlException ee)
            {
                MessageBox.Show(ee.Message);
            }
            connection.Close();
            GeneratePrescript();
        }

        private void tabControl3_Click(object sender, EventArgs e)
        {
            button17.Hide();
            GeneratePrescript();
        }
        public void GeneratePrescript()
        {
            prescriptionview.Rows.Clear();
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                 + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            int pno = Convert.ToInt32(txtpno2.Text);
            string date, pres;
            try
            {

                connection.Open();
                string query1 = "SELECT *,DATE_FORMAT(presdate,'%Y-%m-%d') from prescripttbl where pno = '" + pno + "'";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    date = dataReader.GetString("DATE_FORMAT(presdate,'%Y-%m-%d')");
                    pres = dataReader.GetString("presdesc");
                    prescriptionview.Rows.Add(date, pres);
                }
            }
            catch (MySqlException me)
            {
                MessageBox.Show(me.Message);
            }
            connection.Close();
        }
        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string date, pres;
            int rows, pno;
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                 + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);

            pno = Convert.ToInt32(txtpno2.Text);

            date = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            pres = richTextBox1.Text;
            try
            {
                connection.Open();
                string query = "UPDATE prescripttbl set presdesc = '" + pres + "' where pno = '" + pno + "' and presdate = '" + date + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Information updated");
                richTextBox1.ResetText();
            }
            catch (MySqlException ee)
            {
                MessageBox.Show(ee.Message);
            }
            connection.Close();
            GeneratePrescript();
        }

        private void tabControl2_Selected(object sender, TabControlEventArgs e)
        {




        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox114_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox112_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl3_SelectedIndexChanged(object sender, EventArgs e)
        {
            transactionview.Rows.Clear();
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
              + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            int pno = Convert.ToInt32(txtpno2.Text);
            int ctr = 0, bno = 0, ntooth = 0, tfee = 0, amtpd = 0, bal = 0, tbal = 0, bal1 = 0;
            string date = "", proc = "", mop = "";
            try
            {

                connection.Open();
                string query1 = "SELECT b.numoftooth,b.billno,b.pnum,b.billdate,b.servicename,b.servicefee,b.mop,DATE_FORMAT(billdate,'%Y-%m-%d'),p.amtpd,ba.tbal" +
                " from billingtbl b, paymenttbl p,balancetbl ba" +
                " where b.pnum = '" + pno + "' and b.pnum = p.pno and p.pno = ba.pno and b.balanceno = ba.balno and b.payno = p.paymentno and b.billdate IN (SELECT MAX(billdate) from billingtbl b,paymenttbl p, balancetbl ba where pnum = '" + pno + "' and b.payno = p.paymentno and b.balanceno = ba.balno group by b.servicename,b.billdate) and b.billdate = p.paydate and p.paydate = ba.baldate" +
                " group by b.servicename,b.billdate" +
                " order by b.billdate desc";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    bno = dataReader.GetInt32("billno");
                    date = dataReader.GetString("DATE_FORMAT(billdate,'%Y-%m-%d')");
                    ntooth = dataReader.GetInt32("numoftooth");
                    proc = dataReader.GetString("servicename");
                    tfee = dataReader.GetInt32("servicefee");
                    amtpd = dataReader.GetInt32("amtpd");
                    bal = dataReader.GetInt32("tbal");
                    mop = dataReader.GetString("mop");
                    ctr = 1;
                    transactionview.Rows.Add(bno, date, ntooth, proc, tfee, amtpd, bal, mop);
                }

                if (ctr == 0)
                {
                    label174.Text = "This patient doesn't have any billing record";
                }
                else
                {
                    label174.ResetText();
                }
            }
            catch (MySqlException) { }
            connection.Close();

            try
            {
                connection.Open();
                string query = "SELECT ba.tbal from billingtbl b, balancetbl ba where pno = '" + pno + "' and b.balanceno = ba.balno and baldate IN (SELECT MAX(baldate) from billingtbl b,paymenttbl p, balancetbl ba where pnum = '" + pno + "' and b.payno = p.paymentno and b.balanceno = ba.balno group by b.servicename)" +
                    " group by b.billdate";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader1 = cmd.ExecuteReader();
                while (dataReader1.Read())
                {
                    bal1 = dataReader1.GetInt16("tbal");
                    tbal = tbal + bal1;
                }
                connection.Close();
            }
            catch (MySqlException) { }
            textBox8.Text = tbal.ToString();
        }

        private void tabControl3_Selected(object sender, TabControlEventArgs e)
        {
            button18.Hide();
            textBox112.ReadOnly = true;
            textBox113.ReadOnly = true;
            textBox114.ReadOnly = true;
            textBox115.ReadOnly = true;
            textBox116.ReadOnly = true;
            textBox117.ReadOnly = true;
            textBox222.ReadOnly = true;
            int pno = Convert.ToInt32(txtpno2.Text);
            string operation = "", meds = "", allergy = "", btime = "", btype = "", bpressure = "", illness = "";
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
              + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {

                connection.Open();
                string query1 = "SELECT * from medhisttbl where pno = '" + pno + "'";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    operation = dataReader.GetString("operation");
                    meds = dataReader.GetString("meds");
                    allergy = dataReader.GetString("allergy");
                    btime = dataReader.GetString("btime");
                    btype = dataReader.GetString("btype");
                    bpressure = dataReader.GetString("bpressure");
                    illness = dataReader.GetString("illness");
                }
                textBox112.Text = operation;
                textBox113.Text = meds;
                textBox114.Text = allergy;
                textBox115.Text = btime;
                textBox116.Text = btype;
                textBox117.Text = bpressure;
                textBox222.Text = illness;
            }
            catch (MySqlException me)
            {
                MessageBox.Show(me.Message);
            }
            connection.Close();

            dataGridView4.Rows.Clear();
            int servicefee = 0;
            string date = "", servicename = "", status = "";
            connection.Open();
            string query2 = "SELECT DATE_FORMAT(appointdate,'%Y-%m-%d'),a.service,a.appointstatus,s.servicefee from appointmenttbl a, servicestbl s where a.pno = '" + pno + "' and a.service = s.servicename order by a.appointdate desc";
            MySqlCommand cmd2 = new MySqlCommand(query2, connection);
            MySqlDataReader dataReader2 = cmd2.ExecuteReader();
            while (dataReader2.Read())
            {
                date = dataReader2.GetString("DATE_FORMAT(appointdate,'%Y-%m-%d')");
                servicename = dataReader2.GetString("service");
                status = dataReader2.GetString("appointstatus");
                servicefee = dataReader2.GetInt32("servicefee");
                dataGridView4.Rows.Add(date, servicename, servicefee, status);
            }
            connection.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Hide();
            button18.Show();
            textBox112.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            textBox113.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            textBox114.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            textBox115.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            textBox116.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            textBox117.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            textBox222.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            textBox112.ReadOnly = false;
            textBox113.ReadOnly = false;
            textBox114.ReadOnly = false;
            textBox115.ReadOnly = false;
            textBox116.ReadOnly = false;
            textBox117.ReadOnly = false;
            textBox222.ReadOnly = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
             + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string operation = "", meds = "", allergy = "", btime = "", btype = "", bpressure = "", illness = "";
            int pno = Convert.ToInt32(txtpno2.Text);
            operation = textBox112.Text;
            meds = textBox113.Text;
            allergy = textBox114.Text;
            btime = textBox115.Text;
            btype = textBox116.Text;
            bpressure = textBox117.Text;
            illness = textBox222.Text;

            try
            {
                connection.Open();
                string query = "UPDATE medhisttbl set operation = '" + operation + "',meds = '" + meds + "',allergy='" + allergy + "',btime='" + btime + "',btype='" + btype + "',bpressure='" + bpressure + "',illness='" + illness + "' where pno = '" + pno + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Information updated");
            }
            catch (MySqlException ee)
            {
                MessageBox.Show(ee.Message);
            }
            connection.Close();
            textBox112.ReadOnly = true;
            textBox113.ReadOnly = true;
            textBox114.ReadOnly = true;
            textBox115.ReadOnly = true;
            textBox116.ReadOnly = true;
            textBox117.ReadOnly = true;
            textBox222.ReadOnly = true;
            textBox112.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox113.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox114.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox115.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox116.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox117.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox222.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }



        private void tabControl2_Click(object sender, EventArgs e)
        {


        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void tabControl3_MouseClick(object sender, MouseEventArgs e)
        {
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
              + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            int pno = 0;
            int tno = 0;
            string t1 = "", t2 = "";
            int ctr = 0;
            bool check = true;
            label164.Hide();
            dateTimePicker4.Hide();
            panel65.Hide();
            button20.Hide();

            pno = Convert.ToInt32(txtpno2.Text);
            try
            {

                connection.Open();
                string query1 = "SELECT * from denthisttbl where pno = '" + pno + "' and adddate = (SELECT max(adddate) from denthisttbl where pno = '" + pno + "')";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {

                    tno = dataReader.GetInt32("toothno");
                    t1 = dataReader.GetString("tooth1");
                    t2 = dataReader.GetString("tooth2");

                    if (tno == 55)
                    {
                        comboBox198.Text = t1;
                        comboBox208.Text = t2;
                    }
                    if (tno == 54)
                    {
                        comboBox197.Text = t1;
                        comboBox207.Text = t2;
                    }
                    if (tno == 53)
                    {
                        comboBox196.Text = t1;
                        comboBox206.Text = t2;
                    }
                    if (tno == 52)
                    {
                        comboBox195.Text = t1;
                        comboBox205.Text = t2;
                    }
                    if (tno == 51)
                    {
                        comboBox194.Text = t1;
                        comboBox204.Text = t2;
                    }
                    if (tno == 65)
                    {
                        comboBox189.Text = t1;
                        comboBox199.Text = t2;
                    }
                    if (tno == 64)
                    {
                        comboBox190.Text = t1;
                        comboBox200.Text = t2;
                    }
                    if (tno == 63)
                    {
                        comboBox191.Text = t1;
                        comboBox201.Text = t2;
                    }
                    if (tno == 62)
                    {
                        comboBox192.Text = t1;
                        comboBox202.Text = t2;
                    }
                    if (tno == 61)
                    {
                        comboBox193.Text = t1;
                        comboBox203.Text = t2;
                    }
                    if (tno == 11)
                    {
                        comboBox174.Text = t1;
                        comboBox184.Text = t2;
                    }
                    if (tno == 12)
                    {
                        comboBox175.Text = t1;
                        comboBox185.Text = t2;
                    }
                    if (tno == 13)
                    {
                        comboBox176.Text = t1;
                        comboBox186.Text = t2;
                    }
                    if (tno == 14)
                    {
                        comboBox177.Text = t1;
                        comboBox187.Text = t2;
                    }
                    if (tno == 15)
                    {
                        comboBox178.Text = t1;
                        comboBox188.Text = t2;
                    }
                    if (tno == 16)
                    {
                        comboBox163.Text = t1;
                        comboBox166.Text = t2;
                    }
                    if (tno == 17)
                    {
                        comboBox164.Text = t1;
                        comboBox167.Text = t2;
                    }
                    if (tno == 18)
                    {
                        comboBox165.Text = t1;
                        comboBox168.Text = t2;
                    }
                    if (tno == 21)
                    {
                        comboBox173.Text = t1;
                        comboBox183.Text = t2;
                    }
                    if (tno == 22)
                    {
                        comboBox172.Text = t1;
                        comboBox182.Text = t2;
                    }
                    if (tno == 23)
                    {
                        comboBox171.Text = t1;
                        comboBox181.Text = t2;
                    }
                    if (tno == 24)
                    {
                        comboBox170.Text = t1;
                        comboBox180.Text = t2;
                    }
                    if (tno == 25)
                    {
                        comboBox169.Text = t1;
                        comboBox179.Text = t2;
                    }
                    if (tno == 26)
                    {
                        comboBox159.Text = t1;
                        comboBox162.Text = t2;
                    }
                    if (tno == 27)
                    {
                        comboBox158.Text = t1;
                        comboBox161.Text = t2;
                    }
                    if (tno == 28)
                    {
                        comboBox157.Text = t1;
                        comboBox160.Text = t2;
                    }
                    if (tno == 31)
                    {
                        comboBox141.Text = t1;
                        comboBox151.Text = t2;
                    }
                    if (tno == 32)
                    {
                        comboBox140.Text = t1;
                        comboBox150.Text = t2;
                    }
                    if (tno == 33)
                    {
                        comboBox139.Text = t1;
                        comboBox149.Text = t2;
                    }
                    if (tno == 34)
                    {
                        comboBox138.Text = t1;
                        comboBox148.Text = t2;
                    }
                    if (tno == 35)
                    {
                        comboBox137.Text = t1;
                        comboBox147.Text = t2;
                    }
                    if (tno == 36)
                    {
                        comboBox130.Text = t1;
                        comboBox127.Text = t2;
                    }
                    if (tno == 37)
                    {
                        comboBox129.Text = t1;
                        comboBox126.Text = t2;
                    }
                    if (tno == 38)
                    {
                        comboBox128.Text = t1;
                        comboBox125.Text = t2;
                    }
                    if (tno == 41)
                    {
                        comboBox152.Text = t1;
                        comboBox142.Text = t2;
                    }
                    if (tno == 42)
                    {
                        comboBox153.Text = t1;
                        comboBox143.Text = t2;
                    }
                    if (tno == 43)
                    {
                        comboBox154.Text = t1;
                        comboBox144.Text = t2;
                    }
                    if (tno == 44)
                    {
                        comboBox155.Text = t1;
                        comboBox145.Text = t2;
                    }
                    if (tno == 45)
                    {
                        comboBox156.Text = t1;
                        comboBox146.Text = t2;
                    }
                    if (tno == 46)
                    {
                        comboBox134.Text = t1;
                        comboBox131.Text = t2;
                    }
                    if (tno == 47)
                    {
                        comboBox135.Text = t1;
                        comboBox132.Text = t2;
                    }
                    if (tno == 48)
                    {
                        comboBox136.Text = t1;
                        comboBox133.Text = t2;
                    }
                    if (tno == 71)
                    {
                        comboBox119.Text = t1;
                        comboBox109.Text = t2;
                    }
                    if (tno == 72)
                    {
                        comboBox118.Text = t1;
                        comboBox108.Text = t2;
                    }
                    if (tno == 73)
                    {
                        comboBox117.Text = t1;
                        comboBox107.Text = t2;
                    }
                    if (tno == 74)
                    {
                        comboBox116.Text = t1;
                        comboBox106.Text = t2;
                    }
                    if (tno == 75)
                    {
                        comboBox115.Text = t1;
                        comboBox105.Text = t2;
                    }
                    if (tno == 81)
                    {
                        comboBox120.Text = t1;
                        comboBox110.Text = t2;
                    }
                    if (tno == 82)
                    {
                        comboBox121.Text = t1;
                        comboBox111.Text = t2;
                    }
                    if (tno == 83)
                    {
                        comboBox122.Text = t1;
                        comboBox112.Text = t2;
                    }
                    if (tno == 84)
                    {
                        comboBox123.Text = t1;
                        comboBox113.Text = t2;
                    }
                    if (tno == 85)
                    {
                        comboBox124.Text = t1;
                        comboBox114.Text = t2;
                    }
                }

            }
            catch (MySqlException me)
            {
                MessageBox.Show(me.Message);
            }
            connection.Close();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            label164.Hide();
            dateTimePicker4.Hide();
            panel65.Hide();
            panel66.Show();
            button12.Hide();
            button20.Show();

            comboBox208.Enabled = true;
            comboBox198.Enabled = true;
            comboBox207.Enabled = true;
            comboBox197.Enabled = true;
            comboBox206.Enabled = true;
            comboBox196.Enabled = true;
            comboBox205.Enabled = true;
            comboBox195.Enabled = true;
            comboBox204.Enabled = true;
            comboBox194.Enabled = true;
            comboBox203.Enabled = true;
            comboBox193.Enabled = true;
            comboBox202.Enabled = true;
            comboBox192.Enabled = true;
            comboBox201.Enabled = true;
            comboBox191.Enabled = true;
            comboBox200.Enabled = true;
            comboBox190.Enabled = true;
            comboBox199.Enabled = true;
            comboBox189.Enabled = true;
            comboBox184.Enabled = true;
            comboBox174.Enabled = true;
            comboBox185.Enabled = true;
            comboBox175.Enabled = true;
            comboBox186.Enabled = true;
            comboBox176.Enabled = true;
            comboBox187.Enabled = true;
            comboBox177.Enabled = true;
            comboBox188.Enabled = true;
            comboBox178.Enabled = true;
            comboBox166.Enabled = true;
            comboBox163.Enabled = true;
            comboBox167.Enabled = true;
            comboBox164.Enabled = true;
            comboBox168.Enabled = true;
            comboBox165.Enabled = true;
            comboBox183.Enabled = true;
            comboBox173.Enabled = true;
            comboBox182.Enabled = true;
            comboBox172.Enabled = true;
            comboBox181.Enabled = true;
            comboBox171.Enabled = true;
            comboBox180.Enabled = true;
            comboBox170.Enabled = true;
            comboBox179.Enabled = true;
            comboBox169.Enabled = true;
            comboBox162.Enabled = true;
            comboBox159.Enabled = true;
            comboBox161.Enabled = true;
            comboBox158.Enabled = true;
            comboBox160.Enabled = true;
            comboBox157.Enabled = true;
            comboBox152.Enabled = true;
            comboBox142.Enabled = true;
            comboBox153.Enabled = true;
            comboBox143.Enabled = true;
            comboBox154.Enabled = true;
            comboBox144.Enabled = true;
            comboBox155.Enabled = true;
            comboBox145.Enabled = true;
            comboBox156.Enabled = true;
            comboBox146.Enabled = true;
            comboBox134.Enabled = true;
            comboBox131.Enabled = true;
            comboBox136.Enabled = true;
            comboBox132.Enabled = true;
            comboBox135.Enabled = true;
            comboBox133.Enabled = true;
            comboBox151.Enabled = true;
            comboBox141.Enabled = true;
            comboBox150.Enabled = true;
            comboBox140.Enabled = true;
            comboBox149.Enabled = true;
            comboBox139.Enabled = true;
            comboBox148.Enabled = true;
            comboBox138.Enabled = true;
            comboBox147.Enabled = true;
            comboBox137.Enabled = true;
            comboBox130.Enabled = true;
            comboBox129.Enabled = true;
            comboBox128.Enabled = true;
            comboBox127.Enabled = true;
            comboBox126.Enabled = true;
            comboBox125.Enabled = true;
            comboBox120.Enabled = true;
            comboBox110.Enabled = true;
            comboBox121.Enabled = true;
            comboBox111.Enabled = true;
            comboBox122.Enabled = true;
            comboBox112.Enabled = true;
            comboBox123.Enabled = true;
            comboBox113.Enabled = true;
            comboBox124.Enabled = true;
            comboBox114.Enabled = true;
            comboBox119.Enabled = true;
            comboBox109.Enabled = true;
            comboBox118.Enabled = true;
            comboBox108.Enabled = true;
            comboBox117.Enabled = true;
            comboBox107.Enabled = true;
            comboBox116.Enabled = true;
            comboBox106.Enabled = true;
            comboBox115.Enabled = true;
            comboBox105.Enabled = true;
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            promptlbl.Text = " ";
            string fname = "", lname = "", mi = "", name = "", lno = "", street = "", brgy = "", city = "", address = "", bday = "", gender = "", occu = "", lpname = "", fpname = "", mip = "", pname = "", poccu = "", num = "";
            int age = 0;
            string cno = "",slname="",sfname="",smi="",lname1="",fname1="",mi1="";
            int counter = 0, ctr = 0, ctr1 = 0;
            int uid = 0;
            string sname = "";
            bool check = true, checker = true;
            int pno = 0;
            string cno1 = "";
            string name1 = "", add1 = "";
            string connectionString;
            connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                 + ";" + "PASSWORD=password" + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                age = Convert.ToInt16(label149.Text);
                if (age < 18)
                {
                    try
                    {
                        lpname = textBox12.Text.Trim();
                        if (lpname.Length == 0)
                        {
                            label152.Text = "This field is required";
                            counter = 1;
                        }
                        fpname = textBox13.Text.Trim();
                        if (fpname.Length == 0)
                        {
                            label152.Text = "This field is required";
                            counter = 1;
                        }
                    }
                    catch (FormatException) { }
                }
            }
            catch (FormatException)
            {
                label151.Text = "No Age! You need to input birthdate";
                counter = 1;
            }
            try
            {
                cno = TextCnum.Text;
            }
            catch (FormatException nfe)
            {
                promptlbl.Text = "Invalid contact number!";
                counter = 1;
            }
            if (rboMale.Checked)
            {
                gender = rboMale.Text;
            }
            else
            {
                gender = radioButton9.Text;
            }
            lname = namebox.Text.Trim();
            fname = namebox1.Text.Trim();
            mi = namebox2.Text.Trim();
            name = lname + ", " + fname + " " + mi;
            bday = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            lno = addno.Text.Trim();
            street = streettext.Text.Trim();
            brgy = brgytxt.Text.Trim();
            city = textBox11.Text.Trim();
            address = lno + " " + street + " " + brgy;
            occu = TextOccu.Text;
            
            mip = textBox14.Text.Trim();
            pname = lpname + ", " + fpname + " " + mip;
            poccu = textBox15.Text;
            if (lno.Length == 0 || street.Length == 0 || brgy.Length == 0 || city.Length == 0)
            {
                label155.Text = "Incomplete Requirement for address";
                counter = 1;
            }
            if (fname.Length == 0 || lname.Length == 0)
            {
                label159.Text = "Last and First name field is required";
                counter = 1;
            }

            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(namebox1.Text)))
            {
                label159.Text = "Character Only for First Name";
                counter = 1;
            }
            else if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(namebox.Text)))
            {
                label159.Text = "Character Only for Last Name";
                counter = 1;
            }
            else if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(namebox2.Text)))
            {
                label159.Text = "Character Only for Middle Initial";
                counter = 1;
            }
            else if (!(new Regex(@"^[0-9]*$").IsMatch(TextCnum.Text)))
            {
                promptlbl.Text = "Number only for contact number";
                counter = 1;
            }
            else if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(textBox11.Text)))
            {
                label155.Text = "Character only for City name";
                counter = 1;
            }
            else if (!(new Regex(@"^[a-z A-Z.]*$").IsMatch(streettext.Text)))
            {
                label155.Text = "Character only for Street name";
                counter = 1;
            }
            else if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(textBox12.Text)))
            {
                label152.Text = "Character Only for Last Name";
                counter = 1;
            }
            else if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(textBox13.Text)))
            {
                label152.Text = "Character Only for First Name";
                counter = 1;
            }
            else if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(textBox14.Text)))
            {
                label152.Text = "Character Only for Middle Initial";
                counter = 1;
            }

            if (counter == 0)
            {
                Form f = Application.OpenForms["Menu"];
                promptlbl.ResetText();
                ctr++;
                uid = (((Menu)f).User());
                try
                {

                    connection.Open();
                    string query1 = "SELECT * from patienttbl";
                    MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                    MySqlDataReader dataReader = cmd1.ExecuteReader();
                    while (dataReader.Read())
                    {
                        ctr = dataReader.GetInt32("pno");
                        ctr = ctr + 1;
                    }
                }
                catch (MySqlException ee)
                {
                    MessageBox.Show(ee.Message);
                }
                connection.Close();

                try
                {
                    connection.Open();
                    string query3 = "SELECT * from patienttbl";
                    MySqlCommand cmd3 = new MySqlCommand(query3, connection);
                    MySqlDataReader dataReader = cmd3.ExecuteReader();
                    while (dataReader.Read())
                    {
                        slname = dataReader.GetString("plname");
                        sfname = dataReader.GetString("pfname");
                        smi = dataReader.GetString(3);
                        sname = slname + ", " + sfname + " " + smi;
                        if (name.Equals(sname))
                        {
                            check = false;
                            break;
                        }
                        ctr1 = 1;
                    }
                }
                catch (Exception) { }
                connection.Close();




                if (check == false)
                {
                    var choose = MessageBox.Show("You have a matching name in our record!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    tabPage2.Show();
                    tabControl1.SelectTab("tabPage2");
                    button3.Show();
                    panel5.Show();
                    panel8.Enabled = false;
                    dataGridView1.Rows.Clear();
                    try
                    {
                        connection.Open();
                        string query4 = "SELECT * from patienttbl where CONCAT(plname,', ',pfname,' ',pminitial) = '" + name + "'";
                        MySqlCommand cmd4 = new MySqlCommand(query4, connection);
                        MySqlDataReader dataReader4 = cmd4.ExecuteReader();
                        while (dataReader4.Read())
                        {
                            pno = dataReader4.GetInt16("pno");
                            lname1 = dataReader4.GetString("plname");
                            fname1 = dataReader4.GetString("pfname");
                            mi1 = dataReader4.GetString("pminitial");
                            name1 = lname1 + ", " + fname1 + " " + mi1;
                            cno1 = dataReader4.GetString("pcno");
                            add1 = dataReader4.GetString("paddress");
                            dataGridView1.Rows.Add(pno, name1, cno1, add1);
                        }
                    }
                    catch (MySqlException me)
                    {
                        MessageBox.Show(me.Message);
                    }
                    connection.Close();
                    var choose1 = MessageBox.Show("Do you want to proceed?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (choose1 == DialogResult.Yes)
                    {
                        try
                        {
                            connection.Open();
                            string query7 = "INSERT INTO patienttbl values ('" + ctr + "','" + lname + "' ,'"+fname+"','"+mi+"', '" + bday + "' ,'" + age + "','" + address + "','" + city + "','" + gender + "','" + cno + "','" + occu + "','" + pname + "','" + poccu + "','" + uid + "')";
                            MySqlCommand cmd7 = new MySqlCommand(query7, connection);
                            cmd7.ExecuteNonQuery();
                            MessageBox.Show("Information were added to the database");
                            tabPage4.Show();
                            tabControl2.SelectTab("tabPage4");
                            button3.Hide();
                            panel5.Hide();
                            textBox2.Hide();
                            textBox3.Hide();
                            textBox6.Hide();
                            textBox7.Hide();
                            panel6.Enabled = true;
                            panel3.Enabled = false; 
                        }
                        catch (Exception) { MessageBox.Show("Sorry! Patient number already occupied"); }
                        connection.Close();
                    }
                    else
                    {
                        tabPage1.Show();
                        tabControl1.SelectTab("tabPage1");
                        tabPage3.Show();
                        tabControl2.SelectTab("tabPage3");
                    }
                }
                else if (check == true || ctr == 0)
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO patienttbl values ('" + ctr + "','" + lname + "' ,'" + fname + "','" + mi + "' , '" + bday + "' ,'" + age + "','" + address + "','" + city + "','" + gender + "','" + cno + "','" + occu + "','" + pname + "','" + poccu + "','" + uid + "')";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Information were added to the database");
                        tabPage4.Show();
                        tabControl2.SelectTab("tabPage4");
                        button3.Hide();
                        panel5.Hide();
                        textBox2.Hide();
                        textBox3.Hide();
                        textBox6.Hide();
                        textBox7.Hide();
                        panel6.Enabled = true;
                        panel3.Enabled = false;
                    }
                    catch (MySqlException me) { MessageBox.Show(me.Message); }
                    connection.Close();
                }

                if (checkBox35.Checked.Equals(true))
                {
                    textBox3.Show();
                }
                if (checkBox6.Checked.Equals(true))
                {
                    textBox7.Show();
                }
                if (checkBox16.Checked.Equals(true))
                {
                    textBox6.Show();
                }
            }
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                  + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);

            string illness = "", meds = "", allergy = "", btime = "", btype = "", bpressure = "", operation = "";
            int pno = Convert.ToInt32(label144.Text);
            operation = textBox2.Text;
            meds = textBox3.Text;
            if (checkBox1.Checked)
            {
                allergy += checkBox1.Text + ",";
            }
            if (checkBox2.Checked)
            {
                allergy += checkBox2.Text + ",";
            }
            if (checkBox3.Checked)
            {
                allergy += checkBox3.Text + ",";
            }
            if (checkBox4.Checked)
            {
                allergy += checkBox4.Text + ",";
            }
            if (checkBox5.Checked)
            {
                allergy += checkBox5.Text + ",";
            }

            btime = textBox4.Text;

            if (radioButton1.Checked)
            {
                btype = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                btype = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                btype = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                btype = radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                btype = radioButton5.Text;
            }
            else if (radioButton6.Checked)
            {
                btype = radioButton6.Text;
            }
            else if (radioButton7.Checked)
            {
                btype = radioButton7.Text;
            }
            else if (radioButton8.Checked)
            {
                btype = radioButton8.Text;
            }

            bpressure = textBox5.Text;

            if (checkBox7.Checked)
            {
                illness += checkBox7.Text + ",";
            }
            if (checkBox8.Checked)
            {
                illness += checkBox8.Text + ",";
            }
            if (checkBox9.Checked)
            {
                illness += checkBox9.Text + ",";
            }
            if (checkBox10.Checked)
            {
                illness += checkBox10.Text + ",";
            }
            if (checkBox11.Checked)
            {
                illness += checkBox11.Text + ",";
            }
            if (checkBox12.Checked)
            {
                illness += checkBox12.Text + ",";
            }
            if (checkBox13.Checked)
            {
                illness += checkBox13.Text + ",";
            }
            if (checkBox14.Checked)
            {
                illness += checkBox14.Text + ",";
            }
            if (checkBox15.Checked)
            {
                illness += checkBox15.Text + ",";
            }

            try
            {
                connection.Open();
                string query = "INSERT INTO medhisttbl values ('" + operation + "','" + meds + "','" + allergy + "','" + btime + "','" + btype + "','" + bpressure + "','" + illness + "','" + pno + "')";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medical Information addedd");
            }
            catch (MySqlException ee)
            {
                MessageBox.Show(ee.Message);
            }
            connection.Close();
            tabPage5.Show();
            tabControl2.SelectTab("tabPage5");
            comboBox20.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox19.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox18.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox17.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox16.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox15.SelectedIndex = 0;
            comboBox10.SelectedIndex = 0;
            comboBox14.SelectedIndex = 0;
            comboBox9.SelectedIndex = 0;
            comboBox13.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox12.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox11.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox26.SelectedIndex = 0;
            comboBox36.SelectedIndex = 0;
            comboBox27.SelectedIndex = 0;
            comboBox37.SelectedIndex = 0;
            comboBox28.SelectedIndex = 0;
            comboBox38.SelectedIndex = 0;
            comboBox29.SelectedIndex = 0;
            comboBox39.SelectedIndex = 0;
            comboBox30.SelectedIndex = 0;
            comboBox40.SelectedIndex = 0;
            comboBox41.SelectedIndex = 0;
            comboBox44.SelectedIndex = 0;
            comboBox42.SelectedIndex = 0;
            comboBox45.SelectedIndex = 0;
            comboBox43.SelectedIndex = 0;
            comboBox46.SelectedIndex = 0;
            comboBox25.SelectedIndex = 0;
            comboBox35.SelectedIndex = 0;
            comboBox24.SelectedIndex = 0;
            comboBox34.SelectedIndex = 0;
            comboBox23.SelectedIndex = 0;
            comboBox33.SelectedIndex = 0;
            comboBox22.SelectedIndex = 0;
            comboBox32.SelectedIndex = 0;
            comboBox21.SelectedIndex = 0;
            comboBox31.SelectedIndex = 0;
            comboBox49.SelectedIndex = 0;
            comboBox52.SelectedIndex = 0;
            comboBox48.SelectedIndex = 0;
            comboBox51.SelectedIndex = 0;
            comboBox47.SelectedIndex = 0;
            comboBox50.SelectedIndex = 0;
            comboBox80.SelectedIndex = 0;
            comboBox70.SelectedIndex = 0;
            comboBox81.SelectedIndex = 0;
            comboBox71.SelectedIndex = 0;
            comboBox82.SelectedIndex = 0;
            comboBox72.SelectedIndex = 0;
            comboBox83.SelectedIndex = 0;
            comboBox73.SelectedIndex = 0;
            comboBox84.SelectedIndex = 0;
            comboBox74.SelectedIndex = 0;
            comboBox62.SelectedIndex = 0;
            comboBox59.SelectedIndex = 0;
            comboBox63.SelectedIndex = 0;
            comboBox60.SelectedIndex = 0;
            comboBox64.SelectedIndex = 0;
            comboBox61.SelectedIndex = 0;
            comboBox79.SelectedIndex = 0;
            comboBox69.SelectedIndex = 0;
            comboBox78.SelectedIndex = 0;
            comboBox68.SelectedIndex = 0;
            comboBox77.SelectedIndex = 0;
            comboBox67.SelectedIndex = 0;
            comboBox76.SelectedIndex = 0;
            comboBox66.SelectedIndex = 0;
            comboBox75.SelectedIndex = 0;
            comboBox65.SelectedIndex = 0;
            comboBox58.SelectedIndex = 0;
            comboBox55.SelectedIndex = 0;
            comboBox57.SelectedIndex = 0;
            comboBox54.SelectedIndex = 0;
            comboBox56.SelectedIndex = 0;
            comboBox53.SelectedIndex = 0;
            comboBox100.SelectedIndex = 0;
            comboBox90.SelectedIndex = 0;
            comboBox101.SelectedIndex = 0;
            comboBox91.SelectedIndex = 0;
            comboBox102.SelectedIndex = 0;
            comboBox92.SelectedIndex = 0;
            comboBox103.SelectedIndex = 0;
            comboBox93.SelectedIndex = 0;
            comboBox104.SelectedIndex = 0;
            comboBox94.SelectedIndex = 0;
            comboBox99.SelectedIndex = 0;
            comboBox89.SelectedIndex = 0;
            comboBox98.SelectedIndex = 0;
            comboBox88.SelectedIndex = 0;
            comboBox97.SelectedIndex = 0;
            comboBox87.SelectedIndex = 0;
            comboBox96.SelectedIndex = 0;
            comboBox86.SelectedIndex = 0;
            comboBox95.SelectedIndex = 0;
            comboBox85.SelectedIndex = 0;
            panel8.Enabled = true;
            panel6.Enabled = false;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string t551 = "", t552 = "", t541 = "", t542 = "", t531 = "", t532 = "", t521 = "", t522 = "", t511 = "", t512 = "",
               t611 = "", t612 = "", t621 = "", t622 = "", t631 = "", t632 = "", t641 = "", t642 = "", t651 = "", t652 = "",
                t111 = "", t112 = "", t121 = "", t122 = "", t131 = "", t132 = "", t141 = "", t142 = "", t151 = "", t152 = "",
                t161 = "", t162 = "", t171 = "", t172 = "", t181 = "", t182 = "", t211 = "", t212 = "", t221 = "", t222 = "",
                t231 = "", t232 = "", t241 = "", t242 = "", t251 = "", t252 = "", t261 = "", t262 = "", t271 = "", t272 = "",
                t281 = "", t282 = "", t311 = "", t312 = "", t321 = "", t322 = "", t331 = "", t332 = "", t341 = "", t342 = "",
                t351 = "", t352 = "", t361 = "", t362 = "", t371 = "", t372 = "", t381 = "", t382 = "", t411 = "", t412 = "",
                t421 = "", t422 = "", t431 = "", t432 = "", t441 = "", t442 = "", t451 = "", t452 = "", t461 = "", t462 = "",
                t471 = "", t472 = "", t481 = "", t482 = "", t711 = "", t712 = "", t721 = "", t722 = "", t731 = "", t732 = "",
                t741 = "", t742 = "", t751 = "", t752 = "", t811 = "", t812 = "", t821 = "", t822 = "", t831 = "", t832 = "",
                t841 = "", t842 = "", t851 = "", t852 = "";
            int t55 = 55, t54 = 54, t53 = 53, t52 = 52, t51 = 51, t61 = 61, t62 = 62, t63 = 63, t64 = 64, t65 = 65, t11 = 11, t12 = 12, t13 = 13,
                t14 = 14, t15 = 15, t16 = 16, t17 = 17, t18 = 18, t21 = 21, t22 = 22, t23 = 23, t24 = 24, t25 = 25, t26 = 26, t27 = 27, t28 = 28, t31 = 31, t32 = 32, t33 = 33,
                t34 = 34, t35 = 35, t36 = 36, t37 = 37, t38 = 38, t41 = 41, t42 = 42, t43 = 43, t44 = 44, t45 = 45, t46 = 46, t47 = 47, t48 = 48, t71 = 71, t72 = 72, t73 = 73, t74 = 74,
                t75 = 75, t81 = 81, t82 = 82, t83 = 83, t84 = 84, t85 = 85;
            int pno = Convert.ToInt32(label144.Text);
            string date1 = "";
            DateTime date = DateTime.Now;
            date1 = date.ToString("yyyy-MM-dd");
            t551 = comboBox20.SelectedItem.ToString();
            t552 = comboBox1.SelectedItem.ToString();
            t541 = comboBox19.SelectedItem.ToString();
            t542 = comboBox2.SelectedItem.ToString();
            t531 = comboBox18.SelectedItem.ToString();
            t532 = comboBox3.SelectedItem.ToString();
            t521 = comboBox17.SelectedItem.ToString();
            t522 = comboBox4.SelectedItem.ToString();
            t511 = comboBox16.SelectedItem.ToString();
            t512 = comboBox5.SelectedItem.ToString();
            t611 = comboBox15.SelectedItem.ToString();
            t612 = comboBox10.SelectedItem.ToString();
            t621 = comboBox14.SelectedItem.ToString();
            t622 = comboBox9.SelectedItem.ToString();
            t631 = comboBox13.SelectedItem.ToString();
            t632 = comboBox8.SelectedItem.ToString();
            t641 = comboBox12.SelectedItem.ToString();
            t642 = comboBox7.SelectedItem.ToString();
            t651 = comboBox11.SelectedItem.ToString();
            t652 = comboBox6.SelectedItem.ToString();
            t111 = comboBox26.SelectedItem.ToString();
            t112 = comboBox36.SelectedItem.ToString();
            t121 = comboBox27.SelectedItem.ToString();
            t122 = comboBox37.SelectedItem.ToString();
            t131 = comboBox28.SelectedItem.ToString();
            t132 = comboBox38.SelectedItem.ToString();
            t141 = comboBox29.SelectedItem.ToString();
            t142 = comboBox39.SelectedItem.ToString();
            t151 = comboBox30.SelectedItem.ToString();
            t152 = comboBox40.SelectedItem.ToString();
            t161 = comboBox41.SelectedItem.ToString();
            t162 = comboBox44.SelectedItem.ToString();
            t171 = comboBox42.SelectedItem.ToString();
            t172 = comboBox45.SelectedItem.ToString();
            t181 = comboBox43.SelectedItem.ToString();
            t182 = comboBox46.SelectedItem.ToString();
            t211 = comboBox25.SelectedItem.ToString();
            t212 = comboBox35.SelectedItem.ToString();
            t221 = comboBox24.SelectedItem.ToString();
            t222 = comboBox34.SelectedItem.ToString();
            t231 = comboBox23.SelectedItem.ToString();
            t232 = comboBox33.SelectedItem.ToString();
            t241 = comboBox22.SelectedItem.ToString();
            t242 = comboBox32.SelectedItem.ToString();
            t251 = comboBox21.SelectedItem.ToString();
            t252 = comboBox31.SelectedItem.ToString();
            t261 = comboBox49.SelectedItem.ToString();
            t262 = comboBox52.SelectedItem.ToString();
            t271 = comboBox48.SelectedItem.ToString();
            t272 = comboBox51.SelectedItem.ToString();
            t281 = comboBox47.SelectedItem.ToString();
            t282 = comboBox50.SelectedItem.ToString();
            t411 = comboBox80.SelectedItem.ToString();
            t412 = comboBox70.SelectedItem.ToString();
            t421 = comboBox81.SelectedItem.ToString();
            t422 = comboBox71.SelectedItem.ToString();
            t431 = comboBox82.SelectedItem.ToString();
            t432 = comboBox72.SelectedItem.ToString();
            t441 = comboBox83.SelectedItem.ToString();
            t442 = comboBox73.SelectedItem.ToString();
            t451 = comboBox84.SelectedItem.ToString();
            t452 = comboBox74.SelectedItem.ToString();
            t461 = comboBox62.SelectedItem.ToString();
            t462 = comboBox59.SelectedItem.ToString();
            t471 = comboBox63.SelectedItem.ToString();
            t472 = comboBox60.SelectedItem.ToString();
            t481 = comboBox64.SelectedItem.ToString();
            t482 = comboBox61.SelectedItem.ToString();
            t311 = comboBox79.SelectedItem.ToString();
            t312 = comboBox69.SelectedItem.ToString();
            t321 = comboBox78.SelectedItem.ToString();
            t322 = comboBox68.SelectedItem.ToString();
            t331 = comboBox77.SelectedItem.ToString();
            t332 = comboBox67.SelectedItem.ToString();
            t341 = comboBox76.SelectedItem.ToString();
            t342 = comboBox66.SelectedItem.ToString();
            t351 = comboBox75.SelectedItem.ToString();
            t352 = comboBox65.SelectedItem.ToString();
            t361 = comboBox58.SelectedItem.ToString();
            t362 = comboBox55.SelectedItem.ToString();
            t371 = comboBox57.SelectedItem.ToString();
            t372 = comboBox54.SelectedItem.ToString();
            t381 = comboBox56.SelectedItem.ToString();
            t382 = comboBox53.SelectedItem.ToString();
            t811 = comboBox100.SelectedItem.ToString();
            t812 = comboBox90.SelectedItem.ToString();
            t821 = comboBox101.SelectedItem.ToString();
            t822 = comboBox91.SelectedItem.ToString();
            t831 = comboBox102.SelectedItem.ToString();
            t832 = comboBox92.SelectedItem.ToString();
            t841 = comboBox103.SelectedItem.ToString();
            t842 = comboBox93.SelectedItem.ToString();
            t851 = comboBox104.SelectedItem.ToString();
            t852 = comboBox94.SelectedItem.ToString();
            t711 = comboBox99.SelectedItem.ToString();
            t712 = comboBox89.SelectedItem.ToString();
            t721 = comboBox98.SelectedItem.ToString();
            t722 = comboBox88.SelectedItem.ToString();
            t731 = comboBox97.SelectedItem.ToString();
            t732 = comboBox87.SelectedItem.ToString();
            t741 = comboBox96.SelectedItem.ToString();
            t742 = comboBox86.SelectedItem.ToString();
            t751 = comboBox95.SelectedItem.ToString();
            t752 = comboBox85.SelectedItem.ToString();

            string connectionString;
            connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                 + ";" + "PASSWORD=password" + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "INSERT INTO denthisttbl values ('" + t55 + "','" + t551 + "','" + t552 + "','" + pno + "','" + date1 + "')";
                string query1 = "INSERT INTO denthisttbl values ('" + t54 + "','" + t541 + "','" + t542 + "','" + pno + "','" + date1 + "')";
                string query2 = "INSERT INTO denthisttbl values ('" + t53 + "','" + t531 + "','" + t532 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                string query3 = "INSERT INTO denthisttbl values ('" + t52 + "','" + t521 + "','" + t522 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd3 = new MySqlCommand(query3, connection);
                cmd3.ExecuteNonQuery();
                string query4 = "INSERT INTO denthisttbl values ('" + t51 + "','" + t511 + "','" + t512 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd4 = new MySqlCommand(query4, connection);
                cmd4.ExecuteNonQuery();
                string query5 = "INSERT INTO denthisttbl values ('" + t61 + "','" + t611 + "','" + t612 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd5 = new MySqlCommand(query5, connection);
                cmd5.ExecuteNonQuery();
                string query6 = "INSERT INTO denthisttbl values ('" + t62 + "','" + t621 + "','" + t622 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd6 = new MySqlCommand(query6, connection);
                cmd6.ExecuteNonQuery();
                string query7 = "INSERT INTO denthisttbl values ('" + t63 + "','" + t631 + "','" + t632 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd7 = new MySqlCommand(query7, connection);
                cmd7.ExecuteNonQuery();
                string query8 = "INSERT INTO denthisttbl values ('" + t64 + "','" + t641 + "','" + t642 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd8 = new MySqlCommand(query8, connection);
                cmd8.ExecuteNonQuery();
                string query9 = "INSERT INTO denthisttbl values ('" + t65 + "','" + t651 + "','" + t652 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd9 = new MySqlCommand(query9, connection);
                cmd9.ExecuteNonQuery();
                string query10 = "INSERT INTO denthisttbl values ('" + t11 + "','" + t111 + "','" + t112 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd10 = new MySqlCommand(query10, connection);
                cmd10.ExecuteNonQuery();
                string query11 = "INSERT INTO denthisttbl values ('" + t12 + "','" + t121 + "','" + t122 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd11 = new MySqlCommand(query11, connection);
                cmd11.ExecuteNonQuery();
                string query12 = "INSERT INTO denthisttbl values ('" + t13 + "','" + t131 + "','" + t132 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd12 = new MySqlCommand(query12, connection);
                cmd12.ExecuteNonQuery();
                string query13 = "INSERT INTO denthisttbl values ('" + t14 + "','" + t141 + "','" + t142 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd13 = new MySqlCommand(query13, connection);
                cmd13.ExecuteNonQuery();
                string query14 = "INSERT INTO denthisttbl values ('" + t15 + "','" + t151 + "','" + t152 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd14 = new MySqlCommand(query14, connection);
                cmd14.ExecuteNonQuery();
                string query15 = "INSERT INTO denthisttbl values ('" + t16 + "','" + t161 + "','" + t162 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd15 = new MySqlCommand(query15, connection);
                cmd15.ExecuteNonQuery();
                string query16 = "INSERT INTO denthisttbl values ('" + t17 + "','" + t171 + "','" + t172 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd16 = new MySqlCommand(query16, connection);
                cmd16.ExecuteNonQuery();
                string query17 = "INSERT INTO denthisttbl values ('" + t18 + "','" + t181 + "','" + t182 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd17 = new MySqlCommand(query17, connection);
                cmd17.ExecuteNonQuery();
                string query18 = "INSERT INTO denthisttbl values ('" + t21 + "','" + t211 + "','" + t212 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd18 = new MySqlCommand(query18, connection);
                cmd18.ExecuteNonQuery();
                string query19 = "INSERT INTO denthisttbl values ('" + t22 + "','" + t221 + "','" + t222 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd19 = new MySqlCommand(query19, connection);
                cmd19.ExecuteNonQuery();
                string query20 = "INSERT INTO denthisttbl values ('" + t23 + "','" + t231 + "','" + t232 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd20 = new MySqlCommand(query20, connection);
                cmd20.ExecuteNonQuery();
                string query21 = "INSERT INTO denthisttbl values ('" + t24 + "','" + t241 + "','" + t242 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd21 = new MySqlCommand(query21, connection);
                cmd21.ExecuteNonQuery();
                string query22 = "INSERT INTO denthisttbl values ('" + t25 + "','" + t251 + "','" + t252 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd22 = new MySqlCommand(query22, connection);
                cmd22.ExecuteNonQuery();
                string query23 = "INSERT INTO denthisttbl values ('" + t26 + "','" + t261 + "','" + t262 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd23 = new MySqlCommand(query23, connection);
                cmd23.ExecuteNonQuery();
                string query24 = "INSERT INTO denthisttbl values ('" + t27 + "','" + t271 + "','" + t272 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd24 = new MySqlCommand(query24, connection);
                cmd24.ExecuteNonQuery();
                string query25 = "INSERT INTO denthisttbl values ('" + t28 + "','" + t281 + "','" + t282 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd25 = new MySqlCommand(query25, connection);
                cmd25.ExecuteNonQuery();
                string query26 = "INSERT INTO denthisttbl values ('" + t31 + "','" + t311 + "','" + t312 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd26 = new MySqlCommand(query26, connection);
                cmd26.ExecuteNonQuery();
                string query27 = "INSERT INTO denthisttbl values ('" + t32 + "','" + t321 + "','" + t322 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd27 = new MySqlCommand(query27, connection);
                cmd27.ExecuteNonQuery();
                string query28 = "INSERT INTO denthisttbl values ('" + t33 + "','" + t331 + "','" + t332 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd28 = new MySqlCommand(query27, connection);
                cmd28.ExecuteNonQuery();
                string query29 = "INSERT INTO denthisttbl values ('" + t34 + "','" + t341 + "','" + t342 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd29 = new MySqlCommand(query29, connection);
                cmd29.ExecuteNonQuery();
                string query30 = "INSERT INTO denthisttbl values ('" + t35 + "','" + t351 + "','" + t352 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd30 = new MySqlCommand(query30, connection);
                string query31 = "INSERT INTO denthisttbl values ('" + t36 + "','" + t361 + "','" + t362 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd31 = new MySqlCommand(query31, connection);
                cmd31.ExecuteNonQuery();
                cmd30.ExecuteNonQuery();
                string query32 = "INSERT INTO denthisttbl values ('" + t37 + "','" + t371 + "','" + t372 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd32 = new MySqlCommand(query32, connection);
                cmd32.ExecuteNonQuery();
                string query33 = "INSERT INTO denthisttbl values ('" + t38 + "','" + t381 + "','" + t382 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd33 = new MySqlCommand(query33, connection);
                cmd33.ExecuteNonQuery();
                string query34 = "INSERT INTO denthisttbl values ('" + t41 + "','" + t411 + "','" + t412 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd34 = new MySqlCommand(query34, connection);
                cmd34.ExecuteNonQuery();
                string query35 = "INSERT INTO denthisttbl values ('" + t42 + "','" + t421 + "','" + t422 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd35 = new MySqlCommand(query35, connection);
                cmd35.ExecuteNonQuery();
                string query36 = "INSERT INTO denthisttbl values ('" + t43 + "','" + t431 + "','" + t432 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd36 = new MySqlCommand(query36, connection);
                cmd36.ExecuteNonQuery();
                string query37 = "INSERT INTO denthisttbl values ('" + t44 + "','" + t441 + "','" + t442 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd37 = new MySqlCommand(query37, connection);
                cmd37.ExecuteNonQuery();
                string query38 = "INSERT INTO denthisttbl values ('" + t45 + "','" + t451 + "','" + t452 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd38 = new MySqlCommand(query38, connection);
                cmd38.ExecuteNonQuery();
                string query39 = "INSERT INTO denthisttbl values ('" + t46 + "','" + t461 + "','" + t462 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd39 = new MySqlCommand(query39, connection);
                cmd39.ExecuteNonQuery();
                string query40 = "INSERT INTO denthisttbl values ('" + t47 + "','" + t471 + "','" + t472 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd40 = new MySqlCommand(query40, connection);
                cmd40.ExecuteNonQuery();
                string query41 = "INSERT INTO denthisttbl values ('" + t48 + "','" + t481 + "','" + t482 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd41 = new MySqlCommand(query41, connection);
                cmd41.ExecuteNonQuery();
                string query42 = "INSERT INTO denthisttbl values ('" + t71 + "','" + t711 + "','" + t712 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd42 = new MySqlCommand(query42, connection);
                cmd42.ExecuteNonQuery();
                string query43 = "INSERT INTO denthisttbl values ('" + t72 + "','" + t721 + "','" + t722 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd43 = new MySqlCommand(query43, connection);
                cmd43.ExecuteNonQuery();
                string query44 = "INSERT INTO denthisttbl values ('" + t73 + "','" + t731 + "','" + t732 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd44 = new MySqlCommand(query44, connection);
                cmd44.ExecuteNonQuery();
                string query45 = "INSERT INTO denthisttbl values ('" + t74 + "','" + t741 + "','" + t742 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd45 = new MySqlCommand(query45, connection);
                cmd45.ExecuteNonQuery();
                string query46 = "INSERT INTO denthisttbl values ('" + t75 + "','" + t751 + "','" + t752 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd46 = new MySqlCommand(query46, connection);
                cmd46.ExecuteNonQuery();
                string query47 = "INSERT INTO denthisttbl values ('" + t81 + "','" + t811 + "','" + t812 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd47 = new MySqlCommand(query47, connection);
                cmd47.ExecuteNonQuery();
                string query48 = "INSERT INTO denthisttbl values ('" + t82 + "','" + t821 + "','" + t822 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd48 = new MySqlCommand(query48, connection);
                cmd48.ExecuteNonQuery();
                string query49 = "INSERT INTO denthisttbl values ('" + t83 + "','" + t831 + "','" + t832 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd49 = new MySqlCommand(query49, connection);
                cmd49.ExecuteNonQuery();
                string query50 = "INSERT INTO denthisttbl values ('" + t84 + "','" + t841 + "','" + t842 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd50 = new MySqlCommand(query50, connection);
                cmd50.ExecuteNonQuery();
                string query51 = "INSERT INTO denthisttbl values ('" + t85 + "','" + t851 + "','" + t852 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd51 = new MySqlCommand(query51, connection);
                cmd51.ExecuteNonQuery();
                MessageBox.Show("Dental Information addedd");
            }
            catch (MySqlException ee)
            {
                MessageBox.Show(ee.Message);
            }
            connection.Close();
            panel10.Enabled = true;
            tabPage2.Show();
            tabControl1.SelectTab("tabPage2");
            button3.Show();
            panel5.Show();
            panel8.Enabled = false;
            dataGridView1.Rows.Clear();
            fastsearch();

        }

        public void fastsearch()
        {
            string connectionString1 = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection1 = new MySqlConnection(connectionString1);
            string pno2 = label144.Text;
            string name = "", add = "",lname="",fname="",mi="";
            int pno1;
            string cno = "";

           

                connection1.Open();
                string query1 = "SELECT * from patienttbl where pno = '" + pno2 + "'";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection1);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    pno1 = dataReader.GetInt16("pno");
                    lname = dataReader.GetString("plname");
                    fname = dataReader.GetString("pfname");
                    try
                    {
                        mi = dataReader.GetString("pminitial");
                    }
                    catch (Exception)
                    {
                        mi = "";
                    }
                    cno = dataReader.GetString("pcno");
                    add = dataReader.GetString("paddress");
                    name = lname + ", " + fname + " " + mi;
                    dataGridView1.Rows.Add(pno1, name, cno, add);
                }
           
            connection1.Close();
        }
        private void button7_Click_1(object sender, EventArgs e)
        {

            tabPage6.Show();
            tabControl3.SelectTab("tabPage6");
            label72.Show();
            label20.Hide();
            panel66.Show();
            button10.Hide();
            colPrescription.ReadOnly = true;
            colDate.ReadOnly = true;
            txtage2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtadd2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtcno2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtpoccu2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtcity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtname2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtgen2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtoccu2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtcity.ReadOnly = true;
            txtpno2.ReadOnly = true;
            txtname2.ReadOnly = true;
            txtage2.ReadOnly = true;
            txtgen2.ReadOnly = true;
            txtadd2.ReadOnly = true;
            txtcno2.ReadOnly = true;
            txtoccu2.ReadOnly = true;
            txtpoccu2.ReadOnly = true;
            textBox18.ReadOnly = true;
            textBox19.ReadOnly = true;
            dateTimePicker3.Enabled = false;



            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
               + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string name = "", add = "", gender = "", bday = "", occu = "", goccu = "", gname = "",city="";
            int age, pno, rows = dataGridView1.CurrentCell.RowIndex;
            string cno = "",lname = "",fname="",mi="";
            int pno2 = Convert.ToInt16(dataGridView1.Rows[rows].Cells[0].Value.ToString());
            try
            {

                connection.Open();
                string query1 = "SELECT *,DATE_FORMAT(pbday,'%m-%d-%Y') from patienttbl where pno = '" + pno2 + "'";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    pno = dataReader.GetInt16("pno");

                    lname = dataReader.GetString("plname");
                    fname = dataReader.GetString("pfname");
                    mi = dataReader.GetString("pminitial");
                    cno = dataReader.GetString("pcno");
                    add = dataReader.GetString("paddress");
                    city = dataReader.GetString("city");
                    gender = dataReader.GetString("pgender");
                    age = dataReader.GetInt16("page");
                    bday = dataReader.GetString("DATE_FORMAT(pbday,'%m-%d-%Y')");
                    occu = dataReader.GetString("poccu");
                    gname = dataReader.GetString("gname");
                    goccu = dataReader.GetString("goccu");

                    txtpno2.Text = pno.ToString();
                    txtname2.Text = lname;
                    textBox18.Text = fname;
                    textBox19.Text = mi;
                    txtgen2.Text = gender;
                    txtage2.Text = age.ToString();
                    dateTimePicker3.Value = DateTime.Parse(bday);
                    txtadd2.Text = add;
                    txtcity.Text = city;
                    txtcno2.Text = cno.ToString();
                    txtoccu2.Text = occu;
                    txtpname2.Text = gname;
                    txtpoccu2.Text = goccu;

                }
                connection.Close();
            }
            catch (MySqlException me)
            {
                MessageBox.Show(me.Message);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {


        }

        private void searchbox_Click(object sender, EventArgs e)
        {
        }



        private void button20_Click(object sender, EventArgs e)
        {
            string t551 = "", t552 = "", t541 = "", t542 = "", t531 = "", t532 = "", t521 = "", t522 = "", t511 = "", t512 = "",
                t611 = "", t612 = "", t621 = "", t622 = "", t631 = "", t632 = "", t641 = "", t642 = "", t651 = "", t652 = "",
                 t111 = "", t112 = "", t121 = "", t122 = "", t131 = "", t132 = "", t141 = "", t142 = "", t151 = "", t152 = "",
                 t161 = "", t162 = "", t171 = "", t172 = "", t181 = "", t182 = "", t211 = "", t212 = "", t221 = "", t222 = "",
                 t231 = "", t232 = "", t241 = "", t242 = "", t251 = "", t252 = "", t261 = "", t262 = "", t271 = "", t272 = "",
                 t281 = "", t282 = "", t311 = "", t312 = "", t321 = "", t322 = "", t331 = "", t332 = "", t341 = "", t342 = "",
                 t351 = "", t352 = "", t361 = "", t362 = "", t371 = "", t372 = "", t381 = "", t382 = "", t411 = "", t412 = "",
                 t421 = "", t422 = "", t431 = "", t432 = "", t441 = "", t442 = "", t451 = "", t452 = "", t461 = "", t462 = "",
                 t471 = "", t472 = "", t481 = "", t482 = "", t711 = "", t712 = "", t721 = "", t722 = "", t731 = "", t732 = "",
                 t741 = "", t742 = "", t751 = "", t752 = "", t811 = "", t812 = "", t821 = "", t822 = "", t831 = "", t832 = "",
                 t841 = "", t842 = "", t851 = "", t852 = "";
            int t55 = 55, t54 = 54, t53 = 53, t52 = 52, t51 = 51, t61 = 61, t62 = 62, t63 = 63, t64 = 64, t65 = 65, t11 = 11, t12 = 12, t13 = 13,
                t14 = 14, t15 = 15, t16 = 16, t17 = 17, t18 = 18, t21 = 21, t22 = 22, t23 = 23, t24 = 24, t25 = 25, t26 = 26, t27 = 27, t28 = 28, t31 = 31, t32 = 32, t33 = 33,
                t34 = 34, t35 = 35, t36 = 36, t37 = 37, t38 = 38, t41 = 41, t42 = 42, t43 = 43, t44 = 44, t45 = 45, t46 = 46, t47 = 47, t48 = 48, t71 = 71, t72 = 72, t73 = 73, t74 = 74,
                t75 = 75, t81 = 81, t82 = 82, t83 = 83, t84 = 84, t85 = 85;
            int pno = Convert.ToInt32(txtpno2.Text);
            String date1 = "";
            DateTime date = DateTime.Now;
            date1 = date.ToString("yyyy-MM-dd");
            t551 = comboBox198.SelectedItem.ToString();
            t552 = comboBox208.SelectedItem.ToString();
            t541 = comboBox197.SelectedItem.ToString();
            t542 = comboBox207.SelectedItem.ToString();
            t531 = comboBox196.SelectedItem.ToString();
            t532 = comboBox206.SelectedItem.ToString();
            t521 = comboBox195.SelectedItem.ToString();
            t522 = comboBox205.SelectedItem.ToString();
            t511 = comboBox194.SelectedItem.ToString();
            t512 = comboBox204.SelectedItem.ToString();
            t611 = comboBox193.SelectedItem.ToString();
            t612 = comboBox203.SelectedItem.ToString();
            t621 = comboBox192.SelectedItem.ToString();
            t622 = comboBox202.SelectedItem.ToString();
            t631 = comboBox191.SelectedItem.ToString();
            t632 = comboBox201.SelectedItem.ToString();
            t641 = comboBox190.SelectedItem.ToString();
            t642 = comboBox200.SelectedItem.ToString();
            t651 = comboBox189.SelectedItem.ToString();
            t652 = comboBox199.SelectedItem.ToString();
            t111 = comboBox174.SelectedItem.ToString();
            t112 = comboBox184.SelectedItem.ToString();
            t121 = comboBox175.SelectedItem.ToString();
            t122 = comboBox185.SelectedItem.ToString();
            t131 = comboBox176.SelectedItem.ToString();
            t132 = comboBox186.SelectedItem.ToString();
            t141 = comboBox177.SelectedItem.ToString();
            t142 = comboBox187.SelectedItem.ToString();
            t151 = comboBox178.SelectedItem.ToString();
            t152 = comboBox188.SelectedItem.ToString();
            t161 = comboBox163.SelectedItem.ToString();
            t162 = comboBox166.SelectedItem.ToString();
            t171 = comboBox164.SelectedItem.ToString();
            t172 = comboBox167.SelectedItem.ToString();
            t181 = comboBox165.SelectedItem.ToString();
            t182 = comboBox168.SelectedItem.ToString();
            t211 = comboBox173.SelectedItem.ToString();
            t212 = comboBox183.SelectedItem.ToString();
            t221 = comboBox172.SelectedItem.ToString();
            t222 = comboBox182.SelectedItem.ToString();
            t231 = comboBox171.SelectedItem.ToString();
            t232 = comboBox181.SelectedItem.ToString();
            t241 = comboBox170.SelectedItem.ToString();
            t242 = comboBox180.SelectedItem.ToString();
            t251 = comboBox169.SelectedItem.ToString();
            t252 = comboBox179.SelectedItem.ToString();
            t261 = comboBox159.SelectedItem.ToString();
            t262 = comboBox162.SelectedItem.ToString();
            t271 = comboBox158.SelectedItem.ToString();
            t272 = comboBox161.SelectedItem.ToString();
            t281 = comboBox157.SelectedItem.ToString();
            t282 = comboBox160.SelectedItem.ToString();
            t411 = comboBox152.SelectedItem.ToString();
            t412 = comboBox142.SelectedItem.ToString();
            t421 = comboBox153.SelectedItem.ToString();
            t422 = comboBox143.SelectedItem.ToString();
            t431 = comboBox154.SelectedItem.ToString();
            t432 = comboBox144.SelectedItem.ToString();
            t441 = comboBox155.SelectedItem.ToString();
            t442 = comboBox145.SelectedItem.ToString();
            t451 = comboBox156.SelectedItem.ToString();
            t452 = comboBox146.SelectedItem.ToString();
            t461 = comboBox134.SelectedItem.ToString();
            t462 = comboBox131.SelectedItem.ToString();
            t471 = comboBox135.SelectedItem.ToString();
            t472 = comboBox132.SelectedItem.ToString();
            t481 = comboBox136.SelectedItem.ToString();
            t482 = comboBox133.SelectedItem.ToString();
            t311 = comboBox151.SelectedItem.ToString();
            t312 = comboBox141.SelectedItem.ToString();
            t321 = comboBox150.SelectedItem.ToString();
            t322 = comboBox140.SelectedItem.ToString();
            t331 = comboBox149.SelectedItem.ToString();
            t332 = comboBox139.SelectedItem.ToString();
            t341 = comboBox148.SelectedItem.ToString();
            t342 = comboBox138.SelectedItem.ToString();
            t351 = comboBox147.SelectedItem.ToString();
            t352 = comboBox137.SelectedItem.ToString();
            t361 = comboBox130.SelectedItem.ToString();
            t362 = comboBox127.SelectedItem.ToString();
            t371 = comboBox129.SelectedItem.ToString();
            t372 = comboBox126.SelectedItem.ToString();
            t381 = comboBox128.SelectedItem.ToString();
            t382 = comboBox125.SelectedItem.ToString();
            t811 = comboBox120.SelectedItem.ToString();
            t812 = comboBox110.SelectedItem.ToString();
            t821 = comboBox121.SelectedItem.ToString();
            t822 = comboBox111.SelectedItem.ToString();
            t831 = comboBox122.SelectedItem.ToString();
            t832 = comboBox112.SelectedItem.ToString();
            t841 = comboBox123.SelectedItem.ToString();
            t842 = comboBox113.SelectedItem.ToString();
            t851 = comboBox124.SelectedItem.ToString();
            t852 = comboBox114.SelectedItem.ToString();
            t711 = comboBox119.SelectedItem.ToString();
            t712 = comboBox109.SelectedItem.ToString();
            t721 = comboBox118.SelectedItem.ToString();
            t722 = comboBox108.SelectedItem.ToString();
            t731 = comboBox117.SelectedItem.ToString();
            t732 = comboBox107.SelectedItem.ToString();
            t741 = comboBox116.SelectedItem.ToString();
            t742 = comboBox106.SelectedItem.ToString();
            t751 = comboBox115.SelectedItem.ToString();
            t752 = comboBox105.SelectedItem.ToString();

            string connectionString;
            connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                 + ";" + "PASSWORD=password" + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "INSERT INTO denthisttbl values ('" + t55 + "','" + t551 + "','" + t552 + "','" + pno + "','" + date1 + "')";
                string query1 = "INSERT INTO denthisttbl values ('" + t54 + "','" + t541 + "','" + t542 + "','" + pno + "','" + date1 + "')";
                string query2 = "INSERT INTO denthisttbl values ('" + t53 + "','" + t531 + "','" + t532 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                string query3 = "INSERT INTO denthisttbl values ('" + t52 + "','" + t521 + "','" + t522 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd3 = new MySqlCommand(query3, connection);
                cmd3.ExecuteNonQuery();
                string query4 = "INSERT INTO denthisttbl values ('" + t51 + "','" + t511 + "','" + t512 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd4 = new MySqlCommand(query4, connection);
                cmd4.ExecuteNonQuery();
                string query5 = "INSERT INTO denthisttbl values ('" + t61 + "','" + t611 + "','" + t612 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd5 = new MySqlCommand(query5, connection);
                cmd5.ExecuteNonQuery();
                string query6 = "INSERT INTO denthisttbl values ('" + t62 + "','" + t621 + "','" + t622 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd6 = new MySqlCommand(query6, connection);
                cmd6.ExecuteNonQuery();
                string query7 = "INSERT INTO denthisttbl values ('" + t63 + "','" + t631 + "','" + t632 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd7 = new MySqlCommand(query7, connection);
                cmd7.ExecuteNonQuery();
                string query8 = "INSERT INTO denthisttbl values ('" + t64 + "','" + t641 + "','" + t642 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd8 = new MySqlCommand(query8, connection);
                cmd8.ExecuteNonQuery();
                string query9 = "INSERT INTO denthisttbl values ('" + t65 + "','" + t651 + "','" + t652 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd9 = new MySqlCommand(query9, connection);
                cmd9.ExecuteNonQuery();
                string query10 = "INSERT INTO denthisttbl values ('" + t11 + "','" + t111 + "','" + t112 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd10 = new MySqlCommand(query10, connection);
                cmd10.ExecuteNonQuery();
                string query11 = "INSERT INTO denthisttbl values ('" + t12 + "','" + t121 + "','" + t122 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd11 = new MySqlCommand(query11, connection);
                cmd11.ExecuteNonQuery();
                string query12 = "INSERT INTO denthisttbl values ('" + t13 + "','" + t131 + "','" + t132 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd12 = new MySqlCommand(query12, connection);
                cmd12.ExecuteNonQuery();
                string query13 = "INSERT INTO denthisttbl values ('" + t14 + "','" + t141 + "','" + t142 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd13 = new MySqlCommand(query13, connection);
                cmd13.ExecuteNonQuery();
                string query14 = "INSERT INTO denthisttbl values ('" + t15 + "','" + t151 + "','" + t152 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd14 = new MySqlCommand(query14, connection);
                cmd14.ExecuteNonQuery();
                string query15 = "INSERT INTO denthisttbl values ('" + t16 + "','" + t161 + "','" + t162 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd15 = new MySqlCommand(query15, connection);
                cmd15.ExecuteNonQuery();
                string query16 = "INSERT INTO denthisttbl values ('" + t17 + "','" + t171 + "','" + t172 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd16 = new MySqlCommand(query16, connection);
                cmd16.ExecuteNonQuery();
                string query17 = "INSERT INTO denthisttbl values ('" + t18 + "','" + t181 + "','" + t182 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd17 = new MySqlCommand(query17, connection);
                cmd17.ExecuteNonQuery();
                string query18 = "INSERT INTO denthisttbl values ('" + t21 + "','" + t211 + "','" + t212 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd18 = new MySqlCommand(query18, connection);
                cmd18.ExecuteNonQuery();
                string query19 = "INSERT INTO denthisttbl values ('" + t22 + "','" + t221 + "','" + t222 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd19 = new MySqlCommand(query19, connection);
                cmd19.ExecuteNonQuery();
                string query20 = "INSERT INTO denthisttbl values ('" + t23 + "','" + t231 + "','" + t232 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd20 = new MySqlCommand(query20, connection);
                cmd20.ExecuteNonQuery();
                string query21 = "INSERT INTO denthisttbl values ('" + t24 + "','" + t241 + "','" + t242 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd21 = new MySqlCommand(query21, connection);
                cmd21.ExecuteNonQuery();
                string query22 = "INSERT INTO denthisttbl values ('" + t25 + "','" + t251 + "','" + t252 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd22 = new MySqlCommand(query22, connection);
                cmd22.ExecuteNonQuery();
                string query23 = "INSERT INTO denthisttbl values ('" + t26 + "','" + t261 + "','" + t262 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd23 = new MySqlCommand(query23, connection);
                cmd23.ExecuteNonQuery();
                string query24 = "INSERT INTO denthisttbl values ('" + t27 + "','" + t271 + "','" + t272 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd24 = new MySqlCommand(query24, connection);
                cmd24.ExecuteNonQuery();
                string query25 = "INSERT INTO denthisttbl values ('" + t28 + "','" + t281 + "','" + t282 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd25 = new MySqlCommand(query25, connection);
                cmd25.ExecuteNonQuery();
                string query26 = "INSERT INTO denthisttbl values ('" + t31 + "','" + t311 + "','" + t312 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd26 = new MySqlCommand(query26, connection);
                cmd26.ExecuteNonQuery();
                string query27 = "INSERT INTO denthisttbl values ('" + t32 + "','" + t321 + "','" + t322 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd27 = new MySqlCommand(query27, connection);
                cmd27.ExecuteNonQuery();
                string query28 = "INSERT INTO denthisttbl values ('" + t33 + "','" + t331 + "','" + t332 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd28 = new MySqlCommand(query27, connection);
                cmd28.ExecuteNonQuery();
                string query29 = "INSERT INTO denthisttbl values ('" + t34 + "','" + t341 + "','" + t342 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd29 = new MySqlCommand(query29, connection);
                cmd29.ExecuteNonQuery();
                string query30 = "INSERT INTO denthisttbl values ('" + t35 + "','" + t351 + "','" + t352 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd30 = new MySqlCommand(query30, connection);
                string query31 = "INSERT INTO denthisttbl values ('" + t36 + "','" + t361 + "','" + t362 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd31 = new MySqlCommand(query31, connection);
                cmd31.ExecuteNonQuery();
                cmd30.ExecuteNonQuery();
                string query32 = "INSERT INTO denthisttbl values ('" + t37 + "','" + t371 + "','" + t372 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd32 = new MySqlCommand(query32, connection);
                cmd32.ExecuteNonQuery();
                string query33 = "INSERT INTO denthisttbl values ('" + t38 + "','" + t381 + "','" + t382 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd33 = new MySqlCommand(query33, connection);
                cmd33.ExecuteNonQuery();
                string query34 = "INSERT INTO denthisttbl values ('" + t41 + "','" + t411 + "','" + t412 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd34 = new MySqlCommand(query34, connection);
                cmd34.ExecuteNonQuery();
                string query35 = "INSERT INTO denthisttbl values ('" + t42 + "','" + t421 + "','" + t422 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd35 = new MySqlCommand(query35, connection);
                cmd35.ExecuteNonQuery();
                string query36 = "INSERT INTO denthisttbl values ('" + t43 + "','" + t431 + "','" + t432 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd36 = new MySqlCommand(query36, connection);
                cmd36.ExecuteNonQuery();
                string query37 = "INSERT INTO denthisttbl values ('" + t44 + "','" + t441 + "','" + t442 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd37 = new MySqlCommand(query37, connection);
                cmd37.ExecuteNonQuery();
                string query38 = "INSERT INTO denthisttbl values ('" + t45 + "','" + t451 + "','" + t452 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd38 = new MySqlCommand(query38, connection);
                cmd38.ExecuteNonQuery();
                string query39 = "INSERT INTO denthisttbl values ('" + t46 + "','" + t461 + "','" + t462 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd39 = new MySqlCommand(query39, connection);
                cmd39.ExecuteNonQuery();
                string query40 = "INSERT INTO denthisttbl values ('" + t47 + "','" + t471 + "','" + t472 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd40 = new MySqlCommand(query40, connection);
                cmd40.ExecuteNonQuery();
                string query41 = "INSERT INTO denthisttbl values ('" + t48 + "','" + t481 + "','" + t482 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd41 = new MySqlCommand(query41, connection);
                cmd41.ExecuteNonQuery();
                string query42 = "INSERT INTO denthisttbl values ('" + t71 + "','" + t711 + "','" + t712 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd42 = new MySqlCommand(query42, connection);
                cmd42.ExecuteNonQuery();
                string query43 = "INSERT INTO denthisttbl values ('" + t72 + "','" + t721 + "','" + t722 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd43 = new MySqlCommand(query43, connection);
                cmd43.ExecuteNonQuery();
                string query44 = "INSERT INTO denthisttbl values ('" + t73 + "','" + t731 + "','" + t732 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd44 = new MySqlCommand(query44, connection);
                cmd44.ExecuteNonQuery();
                string query45 = "INSERT INTO denthisttbl values ('" + t74 + "','" + t741 + "','" + t742 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd45 = new MySqlCommand(query45, connection);
                cmd45.ExecuteNonQuery();
                string query46 = "INSERT INTO denthisttbl values ('" + t75 + "','" + t751 + "','" + t752 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd46 = new MySqlCommand(query46, connection);
                cmd46.ExecuteNonQuery();
                string query47 = "INSERT INTO denthisttbl values ('" + t81 + "','" + t811 + "','" + t812 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd47 = new MySqlCommand(query47, connection);
                cmd47.ExecuteNonQuery();
                string query48 = "INSERT INTO denthisttbl values ('" + t82 + "','" + t821 + "','" + t822 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd48 = new MySqlCommand(query48, connection);
                cmd48.ExecuteNonQuery();
                string query49 = "INSERT INTO denthisttbl values ('" + t83 + "','" + t831 + "','" + t832 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd49 = new MySqlCommand(query49, connection);
                cmd49.ExecuteNonQuery();
                string query50 = "INSERT INTO denthisttbl values ('" + t84 + "','" + t841 + "','" + t842 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd50 = new MySqlCommand(query50, connection);
                cmd50.ExecuteNonQuery();
                string query51 = "INSERT INTO denthisttbl values ('" + t85 + "','" + t851 + "','" + t852 + "','" + pno + "','" + date1 + "')";
                MySqlCommand cmd51 = new MySqlCommand(query51, connection);
                cmd51.ExecuteNonQuery();
                MessageBox.Show("Done!");
                button20.Hide();
                button12.Show();
            }
            catch (MySqlException ee)
            {
                MessageBox.Show(ee.Message);
            }
            connection.Close();
            comboBox208.Enabled = false;
            comboBox198.Enabled = false;
            comboBox207.Enabled = false;
            comboBox197.Enabled = false;
            comboBox206.Enabled = false;
            comboBox196.Enabled = false;
            comboBox205.Enabled = false;
            comboBox195.Enabled = false;
            comboBox204.Enabled = false;
            comboBox194.Enabled = false;
            comboBox203.Enabled = false;
            comboBox193.Enabled = false;
            comboBox202.Enabled = false;
            comboBox192.Enabled = false;
            comboBox201.Enabled = false;
            comboBox191.Enabled = false;
            comboBox200.Enabled = false;
            comboBox190.Enabled = false;
            comboBox199.Enabled = false;
            comboBox189.Enabled = false;
            comboBox184.Enabled = false;
            comboBox174.Enabled = false;
            comboBox185.Enabled = false;
            comboBox175.Enabled = false;
            comboBox186.Enabled = false;
            comboBox176.Enabled = false;
            comboBox187.Enabled = false;
            comboBox177.Enabled = false;
            comboBox188.Enabled = false;
            comboBox178.Enabled = false;
            comboBox166.Enabled = false;
            comboBox163.Enabled = false;
            comboBox167.Enabled = false;
            comboBox164.Enabled = false;
            comboBox168.Enabled = false;
            comboBox165.Enabled = false;
            comboBox183.Enabled = false;
            comboBox173.Enabled = false;
            comboBox182.Enabled = false;
            comboBox172.Enabled = false;
            comboBox181.Enabled = false;
            comboBox171.Enabled = false;
            comboBox180.Enabled = false;
            comboBox170.Enabled = false;
            comboBox179.Enabled = false;
            comboBox169.Enabled = false;
            comboBox162.Enabled = false;
            comboBox159.Enabled = false;
            comboBox161.Enabled = false;
            comboBox158.Enabled = false;
            comboBox160.Enabled = false;
            comboBox157.Enabled = false;
            comboBox152.Enabled = false;
            comboBox142.Enabled = false;
            comboBox153.Enabled = false;
            comboBox143.Enabled = false;
            comboBox154.Enabled = false;
            comboBox144.Enabled = false;
            comboBox155.Enabled = false;
            comboBox145.Enabled = false;
            comboBox156.Enabled = false;
            comboBox146.Enabled = false;
            comboBox134.Enabled = false;
            comboBox131.Enabled = false;
            comboBox136.Enabled = false;
            comboBox132.Enabled = false;
            comboBox135.Enabled = false;
            comboBox133.Enabled = false;
            comboBox151.Enabled = false;
            comboBox141.Enabled = false;
            comboBox150.Enabled = false;
            comboBox140.Enabled = false;
            comboBox149.Enabled = false;
            comboBox139.Enabled = false;
            comboBox148.Enabled = false;
            comboBox138.Enabled = false;
            comboBox147.Enabled = false;
            comboBox137.Enabled = false;
            comboBox130.Enabled = false;
            comboBox129.Enabled = false;
            comboBox128.Enabled = false;
            comboBox127.Enabled = false;
            comboBox126.Enabled = false;
            comboBox125.Enabled = false;
            comboBox120.Enabled = false;
            comboBox110.Enabled = false;
            comboBox121.Enabled = false;
            comboBox111.Enabled = false;
            comboBox122.Enabled = false;
            comboBox112.Enabled = false;
            comboBox123.Enabled = false;
            comboBox113.Enabled = false;
            comboBox124.Enabled = false;
            comboBox114.Enabled = false;
            comboBox119.Enabled = false;
            comboBox109.Enabled = false;
            comboBox118.Enabled = false;
            comboBox108.Enabled = false;
            comboBox117.Enabled = false;
            comboBox107.Enabled = false;
            comboBox116.Enabled = false;
            comboBox106.Enabled = false;
            comboBox115.Enabled = false;
            comboBox105.Enabled = false;
            button12.Show();
            button20.Hide();
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            label151.ResetText();
            int age1 = 0;
            int age = DateTime.Now.Year - dateTimePicker1.Value.Year;
            if (dateTimePicker1.Value.AddYears(age) > DateTime.Now)
            {
                age--;
            }
            label149.Text = age.ToString();
            age1 = Convert.ToInt32(label149.Text);
            if (age1 < 2)
            {
                label151.Text = "Invalid age, it's too young";
            }
        }

        private void tabControl3_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            transactionview.Rows.Clear();
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
              + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            int pno = Convert.ToInt32(txtpno2.Text);
            int ctr = 0, bno = 0, ntooth = 0, tfee = 0, amtpd = 0, bal = 0, tbal = 0, bal1 = 0;
            string date = "", proc = "", mop = "";
            try
            {

                connection.Open();
                string query1 = "SELECT b.numoftooth,b.billno,b.pnum,b.billdate,b.servicename,b.servicefee,b.mop,DATE_FORMAT(billdate,'%Y-%m-%d'),p.amtpd,ba.tbal" +
                " from billingtbl b, paymenttbl p,balancetbl ba" +
                " where b.pnum = '" + pno + "' and b.pnum = p.pno and p.pno = ba.pno and b.balanceno = ba.balno and b.payno = p.paymentno and b.billdate IN (SELECT MAX(billdate) from billingtbl b,paymenttbl p, balancetbl ba where pnum = '" + pno + "' and b.payno = p.paymentno and b.balanceno = ba.balno group by b.servicename,b.billdate) and b.billdate = p.paydate and p.paydate = ba.baldate" +
                " group by b.servicename,b.billdate" +
                " order by b.billno";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    bno = dataReader.GetInt32("billno");
                    date = dataReader.GetString("DATE_FORMAT(billdate,'%Y-%m-%d')");
                    ntooth = dataReader.GetInt32("numoftooth");
                    proc = dataReader.GetString("servicename");
                    tfee = dataReader.GetInt32("servicefee");
                    amtpd = dataReader.GetInt32("amtpd");
                    bal = dataReader.GetInt32("tbal");
                    mop = dataReader.GetString("mop");
                    ctr = 1;
                    transactionview.Rows.Add(bno, date, ntooth, proc, tfee, amtpd, bal, mop);
                }

                if (ctr == 0)
                {
                    MessageBox.Show("This patient doesn't have any billing record");
                }
            }
            catch (MySqlException) { }
            connection.Close();

            try
            {
                connection.Open();
                string query = "SELECT * from balancetbl where pno = '" + pno + "' and baldate IN (SELECT MAX(baldate) from billingtbl b,paymenttbl p, balancetbl ba where pnum = '" + pno + "' and b.payno = p.paymentno and b.balanceno = ba.balno group by b.servicename,b.billdate)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader1 = cmd.ExecuteReader();
                while (dataReader1.Read())
                {
                    bal1 = dataReader1.GetInt16("tbal");
                    tbal += bal1;
                }
                connection.Close();
            }
            catch (MySqlException) { }
            textBox8.Text = tbal.ToString();
        }

        private void tabPage8_Enter(object sender, EventArgs e)
        {
        }

        private void tabPage10_Enter(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            search();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void namebox_TextChanged_1(object sender, EventArgs e)
        {

            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(namebox.Text)))
            {
                label159.Text = "Character Only for Last Name";
            }
            else if (new Regex(@"^[a-z A-Z]*$").IsMatch(namebox2.Text) && new Regex(@"^[a-z A-Z]*$").IsMatch(namebox1.Text) && new Regex(@"^[a-z A-Z]*$").IsMatch(namebox.Text))
            {
                label159.ResetText();
            }
            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(namebox1.Text)))
            {
                label159.Text = "Character Only for First Name";
            }
            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(namebox2.Text)))
            {
                label159.Text = "Character Only for Middle Initial";
            }
        }

        private void namebox1_TextChanged(object sender, EventArgs e)
        {

            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(namebox1.Text)))
            {
                label159.Text = "Character Only for First Name";
            }
            else if (new Regex(@"^[a-z A-Z]*$").IsMatch(namebox2.Text) && new Regex(@"^[a-z A-Z]*$").IsMatch(namebox1.Text) && new Regex(@"^[a-z A-Z]*$").IsMatch(namebox.Text))
            {
                label159.ResetText();
            }
            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(namebox.Text)))
            {
                label159.Text = "Character Only for Last Name";
            }
            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(namebox2.Text)))
            {
                label159.Text = "Character Only for Middle Initial";
            }
        }

        private void namebox2_TextChanged(object sender, EventArgs e)
        {

            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(namebox2.Text)))
            {
                label159.Text = "Character Only for Middle Initial";
            }
            else if (new Regex(@"^[a-z A-Z]*$").IsMatch(namebox2.Text) && new Regex(@"^[a-z A-Z]*$").IsMatch(namebox1.Text) && new Regex(@"^[a-z A-Z]*$").IsMatch(namebox.Text))
            {
                label159.ResetText();
            }
            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(namebox.Text)))
            {
                label159.Text = "Character Only for Last Name";
            }
            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(namebox1.Text)))
            {
                label159.Text = "Character Only for First Name";
            }
        }

        private void TextAdd_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void TextPName_TextChanged_1(object sender, EventArgs e)
        {
            label152.ResetText();
        }

        private void TextCnum_TextChanged(object sender, EventArgs e)
        {
            promptlbl.ResetText();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tabPage6.Show();
            tabControl3.SelectTab("tabPage6");
            label72.Show();
            label20.Hide();
            panel66.Show();
            button10.Hide();
            colPrescription.ReadOnly = true;
            colDate.ReadOnly = true;
            txtage2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtadd2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtcity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtcno2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtpoccu2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtpname2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtgen2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtoccu2.BorderStyle = System.Windows.Forms.BorderStyle.None;

            txtcity.ReadOnly = true;
            txtpno2.ReadOnly = true;
            txtname2.ReadOnly = true;
            txtage2.ReadOnly = true;
            txtgen2.ReadOnly = true;
            txtadd2.ReadOnly = true;
            txtcno2.ReadOnly = true;
            txtoccu2.ReadOnly = true;
            txtpname2.ReadOnly = true;
            txtpoccu2.ReadOnly = true;
            dateTimePicker3.Enabled = false;

            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
               + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string name = "", add = "", gender = "", bday = "", occu = "", goccu = "", gname = "",city="",fname="",lname="",mi="";
            int age, pno, rows = dataGridView1.CurrentRow.Index;
            string cno = "";
            int pno2 = Convert.ToInt16(dataGridView1.Rows[rows].Cells[0].Value.ToString());
          
                connection.Open();
                string query1 = "SELECT *,DATE_FORMAT(pbday,'%m-%d-%Y') from patienttbl where pno = '" + pno2 + "'";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    pno = dataReader.GetInt16("pno");
                    lname = dataReader.GetString("plname");
                    fname = dataReader.GetString("pfname");
                    try{
                    mi = dataReader.GetString("pminitial");
                    }
                    catch (Exception)
                    {
                        mi = "";
                    }
                    cno = dataReader.GetString("pcno");
                    add = dataReader.GetString("paddress");
                    city = dataReader.GetString("city");
                    gender = dataReader.GetString("pgender");
                    age = dataReader.GetInt16("page");
                    bday = dataReader.GetString("DATE_FORMAT(pbday,'%m-%d-%Y')");
                    occu = dataReader.GetString("poccu");
                    gname = dataReader.GetString("gname");
                    goccu = dataReader.GetString("goccu");
                    name = lname + ", " + fname + " " + mi;

                    txtcity.Text = city;
                    txtpno2.Text = pno.ToString();
                    txtname2.Text = lname;
                    textBox18.Text = fname;
                    textBox19.Text = mi;
                    txtgen2.Text = gender;
                    txtage2.Text = age.ToString();
                    txtadd2.Text = add;
                    dateTimePicker3.Value = DateTime.Parse(bday);
                    txtcno2.Text = cno.ToString();
                    txtoccu2.Text = occu;
                    txtpname2.Text = gname;
                    txtpoccu2.Text = goccu;

                }
                connection.Close();
            
        }

        private void addno_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox10_Enter(object sender, EventArgs e)
        {


        }

        private void textBox11_Enter(object sender, EventArgs e)
        {

        }

        private void pbackbtn_MouseHover(object sender, EventArgs e)
        {
            pbackbtn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void updatebtn_MouseHover(object sender, EventArgs e)
        {
            updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            button10.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox33.Checked == true)
            {
                textBox2.Show();
            }
            else
            {
                textBox2.Hide();
            }
            checkBox35.CheckState = CheckState.Unchecked;
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox34.Checked == true)
            {
                textBox2.Hide();
            }
            checkBox33.CheckState = CheckState.Unchecked;
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox35.Checked == true)
            {
                textBox3.Show();
            }
            else
            {
                textBox3.Hide();
            }
            checkBox36.CheckState = CheckState.Unchecked;
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox36.Checked == true)
            {
                textBox3.Hide();
            }
            checkBox35.CheckState = CheckState.Unchecked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox7.Show();
            }
            else
            {
                textBox7.Hide();
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                textBox6.Show();
            }
            else
            {
                textBox6.Hide();
            }
        }

        private void TextCnum_Enter(object sender, EventArgs e)
        {
            TextCnum.ResetText();
        }

        private void textBox12_Enter(object sender, EventArgs e)
        {

        }

        private void textBox13_Enter(object sender, EventArgs e)
        {

        }

        private void textBox14_Enter(object sender, EventArgs e)
        {

        }

        private void namebox_Enter(object sender, EventArgs e)
        {

        }

        private void namebox1_Enter(object sender, EventArgs e)
        {

        }

        private void namebox2_Enter(object sender, EventArgs e)
        {

        }

        private void label78_Click(object sender, EventArgs e)
        {

        }

        private void txtcno2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label113_Click(object sender, EventArgs e)
        {

        }

        private void label90_Click(object sender, EventArgs e)
        {

        }

        private void panel64_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(textBox11.Text)))
            {
                label155.Text = "Character only for City name";

            }
            else if (new Regex(@"^[a-z A-Z]*$").IsMatch(textBox11.Text) && new Regex(@"^[a-z A-Z.]*$").IsMatch(streettext.Text))
            {
                label155.ResetText();


            }
            if (!(new Regex(@"^[a-z A-Z.]*$").IsMatch(streettext.Text)))
            {
                label155.Text = "Character only for Street name";


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-z A-Z.]*$").IsMatch(streettext.Text)))
            {
                label155.Text = "Character only for Street name";


            }
            else if (new Regex(@"^[a-z A-Z]*$").IsMatch(textBox11.Text) && new Regex(@"^[a-z A-Z.]*$").IsMatch(streettext.Text))
            {
                label155.ResetText();


            }
            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(textBox11.Text)))
            {
                label155.Text = "Character only for City name";

            }
        }

        private void TextOccu_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-z A-Z']*$").IsMatch(TextOccu.Text)))
            {

            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-z A-Z']*$").IsMatch(addno.Text)))
            {

            }
        }
        private void comboBox209_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(textBox12.Text)))
            {
                label152.Text = "Character Only for Last Name";

            }
            else if (new Regex(@"^[a-z A-Z]*$").IsMatch(textBox12.Text) && new Regex(@"^[a-z A-Z]*$").IsMatch(textBox13.Text) && new Regex(@"^[a-z A-Z]*$").IsMatch(textBox14.Text))
            {
                label152.ResetText();

            }
            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(textBox13.Text)))
            {
                label152.Text = "Character Only for First Name";
            }
            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(textBox14.Text)))
            {
                label152.Text = "Character Only for Middle Initial";

            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(textBox13.Text)))
            {
                label152.Text = "Character Only for First Name";
            }
            else if (new Regex(@"^[a-z A-Z]*$").IsMatch(textBox12.Text) && new Regex(@"^[a-z A-Z]*$").IsMatch(textBox13.Text) && new Regex(@"^[a-z A-Z]*$").IsMatch(textBox14.Text))
            {
                label152.ResetText();

            }
            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(textBox12.Text)))
            {
                label152.Text = "Character Only for Last Name";

            }
            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(textBox14.Text)))
            {
                label152.Text = "Character Only for Middle Initial";

            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(textBox14.Text)))
            {
                label152.Text = "Character Only for Middle Initial";

            }
            else if (new Regex(@"^[a-z A-Z]*$").IsMatch(textBox12.Text) && new Regex(@"^[a-z A-Z]*$").IsMatch(textBox13.Text) && new Regex(@"^[a-z A-Z]*$").IsMatch(textBox14.Text))
            {
                label152.ResetText();

            }
            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(textBox13.Text)))
            {
                label152.Text = "Character Only for First Name";
            }
            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(textBox12.Text)))
            {
                label152.Text = "Character Only for Last Name";

            }
        }

        private void TextCnum_TextChanged_1(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[0-9]*$").IsMatch(TextCnum.Text)))
            {
                promptlbl.Text = "Number only for contact number";
            }
            else
            {
                promptlbl.ResetText();

            }
        }
        private void linkLabel1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox211_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            label164.Show();
            panel65.Show();
            dateTimePicker4.Show();
            dataGridView2.Show();
            button32.Show();
            dataGridView4.Hide();
            button31.Hide();
           
            dataGridView2.Rows.Clear();
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
              + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            int pno = Convert.ToInt32(txtpno2.Text), pno1 = 0;
            int tno = 0;
            string t1 = "", t2 = "", date = "";
            DateTime date1 = new DateTime();
            try
            {

                connection.Open();
                string query1 = "SELECT *,DATE_FORMAT(adddate,'%Y-%m-%d') from denthisttbl where pno = '" + pno + "'";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    pno1 = dataReader.GetInt32("pno");
                    tno = dataReader.GetInt32("toothno");
                    t1 = dataReader.GetString("tooth1");
                    t2 = dataReader.GetString("tooth2");
                    date = dataReader.GetString("DATE_FORMAT(adddate,'%Y-%m-%d')");
                    dataGridView2.Rows.Add(pno1, tno, t1, t2, date);
                }
                connection.Close();
            }
            catch (MySqlException) { }
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
              + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            int pno = Convert.ToInt32(txtpno2.Text), pno1 = 0;
            int tno = 0;
            string t1 = "", t2 = "", date = "", date1 = "";
            date1 = dateTimePicker4.Value.ToString("yyyy-MM-dd");
            try
            {
                connection.Open();
                string query1 = "SELECT *,DATE_FORMAT(adddate,'%Y-%m-%d') from denthisttbl where pno = '" + pno + "' and adddate = '" + date1 + "'";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    pno1 = dataReader.GetInt32("pno");
                    tno = dataReader.GetInt32("toothno");
                    t1 = dataReader.GetString("tooth1");
                    t2 = dataReader.GetString("tooth2");
                    date = dataReader.GetString("DATE_FORMAT(adddate,'%Y-%m-%d')");
                    dataGridView2.Rows.Add(pno1, tno, t1, t2, date);
                }
                connection.Close();
            }
            catch (MySqlException) { }
        }

        private void searchbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }
        int clickctr = 0;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clickctr++;
            if (clickctr % 2 == 1)
            {
                groupBox8.Show();
                dataGridView1.Height = 224;
                dataGridView1.Width = 802;
                dataGridView1.Location = new Point(45, 201);
            }
            else
            {
                groupBox8.Hide();
                dataGridView1.Height = 378;
                dataGridView1.Width = 802;
                dataGridView1.Location = new Point(45, 47);
            }
        }

        private void transactionview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rows = 0, y = 0,amtpd=0;
            rows = transactionview.Rows.Count;
            string date = "";
            date = Convert.ToString(transactionview.SelectedCells[1].Value);
            amtpd = Convert.ToInt32(transactionview.SelectedCells[5].Value);
            for (int x = 0; x < rows; x++)
            {
                if (Convert.ToString(transactionview.Rows[x].Cells[1].Value).Equals(date) && Convert.ToInt32(transactionview.Rows[x].Cells[5].Value) == amtpd)
                {
                    transactionview.Rows[x].Selected = true;
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int bno = 0, pno = 0, tfee = 0, ntooth = 0, ntooth1 = 0, bal = 0, rows = 0, index;
            int install = 0;
            string service = "", date = "", mop = "", checkservice="",checkmop="";
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
               + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);

            Billing bill = new Billing();
            bool check = true;
            bill.dataGridView1.Rows.Clear();
            pno = Convert.ToInt32(txtpno2.Text);
            rows = transactionview.SelectedRows.Count;
            index = transactionview.CurrentRow.Index;
            bno = bill.GenerateBillno();

            checkservice = Convert.ToString(transactionview.Rows[index].Cells[3].Value);
            checkmop = Convert.ToString(transactionview.Rows[index].Cells[7].Value);

            for (int x = 0; x < rows; x++)
            {
                bno = Convert.ToInt32(transactionview.Rows[index].Cells[0].Value);
                date = Convert.ToString(transactionview.Rows[index].Cells[1].Value);
                ntooth = Convert.ToInt32(transactionview.Rows[index].Cells[2].Value);
                service = Convert.ToString(transactionview.Rows[index].Cells[3].Value);
                tfee = Convert.ToInt32(transactionview.Rows[index].Cells[4].Value);
                bal = Convert.ToInt32(transactionview.Rows[index].Cells[6].Value);
                mop = Convert.ToString(transactionview.Rows[index].Cells[7].Value);
                index++;
                bill.dataGridView1.Rows.Add(pno, bno, date, service, ntooth, tfee, mop);

                connection.Open();
                string query = "SELECT sm.installment from servicestbl s, modeofpaymenttbl m, service_modetbl sm where s.servicename = '" + checkservice + "' and m.mopname = '" + checkmop + "' and s.serviceid = sm.serviceid and m.mopid = sm.mopid";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    install += dataReader.GetInt32("installment");
                }
                connection.Close();
            }
            if (bal == 0)
            {
                MessageBox.Show("This doesn't have any balance you can't update it");
                check = false;
            }
            if (check == true)
            {
                bill.Show();
                bill.textBox6.Text = bal.ToString();
                bill.comboBox2.SelectedIndex = pno - 1;
                bill.textBox3.Text = bno.ToString();
                bill.dateTimePicker1.Text = date;
                bill.comboBox1.Text = service;
                bill.comboBox3.Text = mop;
                bill.textBox4.Text = ntooth.ToString();
                bill.textBox7.Text = ntooth1.ToString();
                bill.textBox1.Text = tfee.ToString();
                bill.textBox5.Text = install.ToString();
                bill.textBox2.Text = 0.ToString();

                bill.textBox3.Enabled = false;
                bill.comboBox2.Enabled = false;
                bill.comboBox1.Enabled = false;
                bill.textBox1.Enabled = false;
                bill.textBox4.Enabled = false;
                bill.textBox7.Enabled = false;
                bill.button1.Enabled = false;
                bill.button2.Enabled = false;
                bill.textBox2.Show();
                bill.button5.Hide();
                bill.button6.Show();
                bill.button4.Enabled = true;
                bill.button3.Enabled = true;
            }

        }

        private void button21_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
               + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sname = "";

            string name = "", add = "", gender = "", month = "", year = "";
            int pno, age = 0;
            string cno = "",lname="",fname="",mi="";
            sname = textBox9.Text;
            bool check = false;
            dataGridView1.Rows.Clear();
            if (textBox9.TextLength == 0)
            {
                MessageBox.Show("Search box must be filled-up");
                check = false;
            }
            else
            {
                check = true;
            }
            if (check)
            {
                try
                {
                    connection.Open();
                    string query1 = "SELECT * from patienttbl where CONCAT(plname,', ',pfname,' ',pminitial) LIKE '%" + sname + "%'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                    MySqlDataReader dataReader = cmd1.ExecuteReader();
                    while (dataReader.Read())
                    {
                        pno = dataReader.GetInt16("pno");
                        lname = dataReader.GetString("plname");
                        fname = dataReader.GetString("pfname");
                        mi = dataReader.GetString("pminitial");
                        name = lname + ", " + fname + " " + mi;
                        cno = dataReader.GetString("pcno");
                        add = dataReader.GetString("paddress");
                        dataGridView1.Rows.Add(pno, name, cno, add);

                    }
                    connection.Close();
                }
                catch (MySqlException me)
                {
                    MessageBox.Show(me.Message);
                }
            }
        }

        private void label149_TextChanged(object sender, EventArgs e)
        {
            int age = 0;
            age = Convert.ToInt32(label149.Text);
            if (age >= 18)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void tabPage12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
               + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sname = "", teeth = "",checksname="";
            int sfee = 0, ctr = 0, dp = 0;
            string sname1 = "", teeth1 = "";
            int sfee1 = 0, ctr1 = 1, ctr2 = 0,ctr3 = 0,down=0;
            bool check = false, checker = false ;
            dataGridView3.Rows.Clear();
              try
            {
                sname = textBox1.Text.Trim();
               
            }
              catch (FormatException)
              {
                  label180.Text = "Service name must be filled-up";
                  check = true;
              }
              if (sname.Length == 0)
              {
                  label180.Text = "Service name must be filled-up";
                  check = true;
              }
              try
              {
                  sfee = Convert.ToInt32(textBox16.Text);
              }
              catch (FormatException) {
                  label166.Text = "Service fee must be filled-up";
                  check = true;              
              }
            try
            {
                connection.Open();
                string query = "SELECT * from servicestbl";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    ctr = dataReader.GetInt32("serviceid");
                    checksname = dataReader.GetString("servicename");
                     if (checksname.Equals(sname))
                     {
                         label180.Text ="Service name already exists";
                         ctr3 = 1;
                     }
                }

            }
            catch (MySqlException) { }
            connection.Close();
            ctr = ctr + 1;
            try
            {
                dp = Convert.ToInt32(textBox17.Text);
            }
            catch (FormatException) { dp = 0; }
            label173.Text = ctr.ToString();
            ctr = Convert.ToInt32(label173.Text);
            if (radioButton10.Checked)
            {
                teeth = "Whole Teeth";
            }
            else if (radioButton11.Checked)
            {
                teeth = "Per Teeth";
            }

            if (radioButton10.Checked == false && radioButton11.Checked == false)
            {
                label181.Text = "Please choose";
                check = true;
            }
            if (checkBox17.Checked == false && checkBox18.Checked == false && checkBox19.Checked == false)
            {
                label171.Text = "Please choose for mode of payment";
                check = true;
            }


            if (check == false && ctr3 == 0)
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO servicestbl values('" + ctr + "','" + sname + "','" + sfee + "','" + teeth + "','" + dp + "')";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Service Added");
                }
                catch (MySqlException me) { MessageBox.Show(me.Message); }
                connection.Close();

                if (checkBox17.Checked == true)
                {
                    int sid = 0,installment=0;
                    sid = Convert.ToInt32(label173.Text);
                    int mopid = 1;
                    try
                    {
                        connection.Open();
                        string query1 = "INSERT INTO service_modetbl values('" + sid + "','" + mopid + "','"+installment+"')";
                        MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                        cmd1.ExecuteNonQuery();
                    }
                    catch (MySqlException me) { MessageBox.Show(me.Message); }
                    connection.Close();
                }
                if (checkBox18.Checked == true)
                {
                    int sid = 0,installment=0;
                    installment = (sfee - dp) / 2;
                    sid = Convert.ToInt32(label173.Text);
                    int mopid = 2;
                    try
                    {
                        connection.Open();
                        string query2 = "INSERT INTO service_modetbl values('" + sid + "','" + mopid + "','"+installment+"')";
                        MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                        cmd2.ExecuteNonQuery();
                    }
                    catch (MySqlException me) { MessageBox.Show(me.Message); }
                    connection.Close();
                }
                if (checkBox19.Checked == true)
                {
                    int sid = 0, installment = 0;
                    installment = (sfee - dp) / 12;
                    sid = Convert.ToInt32(label173.Text);
                    int mopid = 3;
                    try
                    {
                        connection.Open();
                        string query3 = "INSERT INTO service_modetbl values('" + sid + "','" + mopid + "','"+installment+"')";
                        MySqlCommand cmd3 = new MySqlCommand(query3, connection);
                        cmd3.ExecuteNonQuery();
                    }
                    catch (MySqlException me) { MessageBox.Show(me.Message); }
                    connection.Close();
                }
                textBox1.ResetText();
                textBox16.ResetText();
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
                checkBox19.Checked = false;
                dataGridView3.Rows.Clear();
                
            }
            try
            {
                connection.Open();
                string query4 = "SELECT * from servicestbl";
                MySqlCommand cmd4 = new MySqlCommand(query4, connection);
                MySqlDataReader dataReader4 = cmd4.ExecuteReader();
                while (dataReader4.Read())
                {
                    sname1 = dataReader4.GetString("servicename");
                    sfee1 = dataReader4.GetInt32("servicefee");
                    teeth1 = dataReader4.GetString("toothno");
                    down = dataReader4.GetInt32("downpay");
                    ctr1 = ctr1 + 1;
                    dataGridView3.Rows.Add(sname1, sfee1, teeth1,down);
                    ctr2 = 1;
                }

            }
            catch (MySqlException) { }
            connection.Close();
            if (ctr2 > 0)
            {
                label167.ResetText();
            }
            label173.Text = ctr1.ToString();
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
              + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);

            string sname = "", teeth = "";
            int sfee = 0, ctr1 = 1, ctr = 0,down=0;
            dataGridView3.Rows.Clear();
            try
            {
                connection.Open();
                string query = "SELECT * from servicestbl";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    sname = dataReader.GetString("servicename");
                    sfee = dataReader.GetInt32("servicefee");
                    teeth = dataReader.GetString("toothno");
                    down = dataReader.GetInt32("downpay");
                    ctr1 = ctr1 + 1;
                    ctr = 1;
                    dataGridView3.Rows.Add(sname, sfee, teeth,down);
                }

            }
            catch (MySqlException) { }
            connection.Close();
            label173.Text = ctr1.ToString();
            if (ctr == 0)
            {
                label167.Text = "No Services Yet!";
            }
            else
            {
                label167.ResetText();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
               + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sname = null;
            string name = "", add = "", gender = null, month = null, year = null;
            string query = "",lname="",fname="",mi="";
            int pno, age = 0;
            string cno = "";

            if (searchbox != null)
            {
                sname = searchbox.Text;
                query = "select * from patienttbl where CONCAT(plname,', ',pfname,' ',pminitial) like '%" + sname + "%'";
            }

            if (comboBox210.SelectedItem != null)
            {
                year = comboBox210.SelectedItem.ToString();
                query = query + " and year(pbday) = '" + year + "'";
            }

            if (comboBox211.SelectedItem != null)
            {
                gender = comboBox211.SelectedItem.ToString();
                query = query + " and pgender = '" + gender + "'";
            }

            if (comboBox209.SelectedItem == null)
            {
                month = null;
            }
            if (comboBox209.SelectedItem == "January")
            {
                month = "01";
                query = query + " and month(pbday) = '" + month + "'";
            }
            if (comboBox209.SelectedItem == "February")
            {
                month = "02";
                query = query + " and month(pbday) = '" + month + "'";
            }
            if (comboBox209.SelectedItem == "March")
            {
                month = "03";
                query = query + " and month(pbday) = '" + month + "'";
            }
            if (comboBox209.SelectedItem == "April")
            {
                month = "04";
                query = query + " and month(pbday) = '" + month + "'";
            }
            if (comboBox209.SelectedItem == "May")
            {
                month = "05";
                query = query + " and month(pbday) = '" + month + "'";
            }
            if (comboBox209.SelectedItem == "June")
            {
                month = "06";
                query = query + " and month(pbday) = '" + month + "'";
            }
            if (comboBox209.SelectedItem == "July")
            {
                month = "07";
                query = query + " and month(pbday) = '" + month + "'";
            }
            if (comboBox209.SelectedItem == "August")
            {
                month = "08";
                query = query + " and month(pbday) = '" + month + "'";
            }
            if (comboBox209.SelectedItem == "September")
            {
                month = "09";
                query = query + " and month(pbday) = '" + month + "'";
            }
            if (comboBox209.SelectedItem == "October")
            {
                month = "10";
                query = query + " and month(pbday) = '" + month + "'";
            }
            if (comboBox209.SelectedItem == "November")
            {
                month = "11";
                query = query + " and month(pbday) = '" + month + "'";
            }
            if (comboBox209.SelectedItem == "December")
            {
                month = "12";
                query = query + " and month(pbday) = '" + month + "'";
            }
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    pno = dataReader.GetInt32("pno");
                    lname = dataReader.GetString("plname");
                    fname = dataReader.GetString("pfname");
                    mi = dataReader.GetString("pminitial");
                    name = lname + ", " + fname + " " + mi;
                    cno = dataReader.GetString("pcno");
                    add = dataReader.GetString("paddress");
                    dataGridView1.Rows.Add(pno, name, cno, add);
                }
            }
            catch (MySqlException me) { MessageBox.Show(me.Message); }
            connection.Close();
        }

        private void panel66_Paint(object sender, PaintEventArgs e)
        {

        }

        private void transactionview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Notification notif = new Notification();
            notif.Show();
            notif.tabPage2.Show();
            notif.tabControl1.SelectTab("tabPage2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button9.Show();
            button5.Hide();
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox17.Enabled = false;
            checkBox18.Enabled = false;
            checkBox19.Enabled = false;
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
               + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            int currindex = dataGridView3.CurrentRow.Index;
            int sid = 0, sfee = 0;
            string ntooth = "", sname = "", servicename = "", mop = "";

            sname = Convert.ToString(dataGridView3.Rows[currindex].Cells[0].Value);

            connection.Open();
            string query = "SELECT * from servicestbl s, modeofpaymenttbl m, service_modetbl sm where s.serviceid = sm.serviceid and m.mopid = sm.mopid and servicename = '" + sname + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                sid = dataReader.GetInt32("serviceid");
                servicename = dataReader.GetString("servicename");
                sfee = dataReader.GetInt32("servicefee");
                ntooth = dataReader.GetString("toothno");
                mop = dataReader.GetString("mopname");
                if (mop.Equals("Full Payment"))
                {
                    checkBox17.Checked = true;
                }
                else if (mop.Equals("Partial Payment"))
                {
                    checkBox18.Checked = true;
                }
                else if (mop.Equals("Monthly Payment"))
                {
                    checkBox19.Checked = true;
                }
            }
            connection.Close();
            label173.Text = sid.ToString();
            textBox1.Text = servicename;
            textBox16.Text = sfee.ToString();
            if (ntooth.Equals("Whole Teeth"))
            {
                radioButton10.Checked = true;
            }
            else
            {
                radioButton11.Checked = true;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
               + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sname = "", teeth = "";
            int sfee = 0, ctr = 0;
            dataGridView3.Rows.Clear();

            ctr = Convert.ToInt32(label173.Text);
            bool check = false;
            try
            {
                sname = textBox1.Text.Trim();
                sfee = Convert.ToInt32(textBox16.Text);
            }
            catch (MySqlException) { }

            if (radioButton10.Checked)
            {
                teeth = "Whole Teeth";
            }
            else if (radioButton11.Checked)
            {
                teeth = "Per Teeth";
            }
            if (sname.Length == 0)
            {
                label180.Text = "Service name must be filled-up";
                check = true;
            }
            if (textBox16.Text.Trim().Length == 0)
            {
                label166.Text = "Service fee must be filled-up";
                check = true;
            }



            if (check == false)
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE servicestbl set serviceid = '" + ctr + "', servicename = '" + sname + "', servicefee = '" + sfee + "', toothno = '" + teeth + "' where serviceid = '" + ctr + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Service Updated");
                }
                catch (MySqlException me) { MessageBox.Show(me.Message); }
                connection.Close();
            }
            button5.Show();
            button9.Hide();
            textBox1.ResetText();
            textBox16.ResetText();
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox17.Enabled = true;
            checkBox18.Enabled = true;
            checkBox19.Enabled = true;
            string sname1 = "", teeth1 = "";
            int sfee1 = 0, ctr1 = 1;
            dataGridView3.Rows.Clear();
            try
            {
                connection.Open();
                string query1 = "SELECT * from servicestbl";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader1 = cmd1.ExecuteReader();
                while (dataReader1.Read())
                {
                    sname1 = dataReader1.GetString("servicename");
                    sfee1 = dataReader1.GetInt32("servicefee");
                    teeth1 = dataReader1.GetString("toothno");
                    ctr1 = ctr1 + 1;
                    dataGridView3.Rows.Add(sname1, sfee1, teeth1);
                }

            }
            catch (MySqlException) { }
            connection.Close();
            label173.Text = ctr1.ToString();
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox19_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true || checkBox19.Checked == true)
            {
                label179.Show();
                textBox17.Show();
                label171.ResetText();
                button9.Location = new Point(158, 352);
                button5.Location = new Point(158, 352);
            }
            else
            {
                button9.Location = new Point(157, 324);
                button5.Location = new Point(157, 324);
                label179.Hide();
                textBox17.Hide();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appointment appoint = new Appointment();
            appoint.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appointment appoint = new Appointment();
            appoint.Show();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true || checkBox19.Checked == true)
            {
                label171.ResetText();
                label179.Show();
                textBox17.Show();
                button9.Location = new Point(158, 352);
                button5.Location = new Point(158, 352);
            }
            else
            {
                button9.Location = new Point(157, 324);
                button5.Location = new Point(157, 324);
                label179.Hide();
                textBox17.Hide();
            }
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            label180.ResetText();
        }

        private void radioButton10_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                label181.ResetText();
            }
        }

        private void radioButton11_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                label181.ResetText();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            promptlbl.Text = " ";
            string fname = "", lname = "", mi = "", name = "", lno = "", street = "", brgy = "", city = "", address = "", bday = "", gender = "", occu = "", lpname = "", fpname = "", mip = "", pname = "", poccu = "", num = "";
            int age = 0;
            string cno = "";
            int counter = 0, ctr = 0, ctr1 = 0;
            int uid = 0;
            string sname = "";
            bool check = true, checker = true;
            int pno = 0;
            string cno1 = "";
            string name1 = "", add1 = "";
            string connectionString;
            connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                 + ";" + "PASSWORD=password" + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                age = Convert.ToInt16(label149.Text);
                if (age < 5)
                {
                    label151.Text = "Invalid age! It's too young";
                    counter = 1;
                }
            }
            catch (FormatException)
            {
                label151.Text = "No Age! You need to input birthdate";
                counter = 1;
            }
            try
            {
                cno = TextCnum.Text;
            }
            catch (FormatException nfe)
            {
                promptlbl.Text = "Invalid contact number!";
                counter = 1;
            }
            if (rboMale.Checked)
            {
                gender = rboMale.Text;
            }
            else
            {
                gender = radioButton9.Text;
            }
            lname = namebox.Text.Trim();
            fname = namebox1.Text.Trim();
            mi = namebox2.Text.Trim();

            bday = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            lno = addno.Text.Trim();
            street = streettext.Text.Trim();
            brgy = brgytxt.Text.Trim();
            city = textBox11.Text.Trim();
            address = lno + " " + street + " " + brgy + ", " + city;
            occu = TextOccu.Text;
            lpname = textBox12.Text.Trim();
            fpname = textBox13.Text.Trim();
            mip = textBox14.Text.Trim();
            pname = lpname + ", " + fpname + " " + mip;
            poccu = textBox15.Text;
            ctr = Convert.ToInt32(label144.Text);
            if (lno.Length == 0 || street.Length == 0 || brgy.Length == 0 || city.Length == 0)
            {
                label155.Text = "Incomplete Requirement for address";
                counter = 1;
            }
            if (fname.Length == 0 || lname.Length == 0)
            {
                label159.Text = "Last and First name field is required";
                counter = 1;
            }

            if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(namebox.Text)))
            {
                label159.Text = "Character Only for First Name";
                counter = 1;
            }
            else if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(namebox1.Text)))
            {
                label159.Text = "Character Only for Last Name";
                counter = 1;
            }
            else if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(namebox2.Text)))
            {
                label159.Text = "Character Only for Middle Initial";
                counter = 1;
            }
            else if (!(new Regex(@"^[0-9]*$").IsMatch(TextCnum.Text)))
            {
                promptlbl.Text = "Number only for contact number";
                counter = 1;
            }
            else if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(textBox11.Text)))
            {
                label155.Text = "Character only for City name";
                counter = 1;
            }
            else if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(streettext.Text)))
            {
                label155.Text = "Character only for Street name";
                counter = 1;
            }
            else if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(textBox12.Text)))
            {
                label152.Text = "Character Only for Last Name";
                counter = 1;
            }
            else if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(textBox13.Text)))
            {
                label152.Text = "Character Only for First Name";
                counter = 1;
            }
            else if (!(new Regex(@"^[a-z A-Z]*$").IsMatch(textBox14.Text)))
            {
                label152.Text = "Character Only for Middle Initial";
                counter = 1;
            }

            if (counter == 0)
            {
                Form f = Application.OpenForms["Menu"];
                promptlbl.ResetText();
                uid =(((Menu)f).User());
                        try
                        {
                            connection.Open();
                            string query7 = "UPDATE patienttbl set plname = '" + lname + "' , pfname = '"+fname+"',pminitial = '"+mi+"', pbday = '" + bday + "' , page = '" + age + "',paddress = '" + address + "',pgender = '" + gender + "',pcno = '" + cno + "',poccu = '" + occu + "',gname = '" + pname + "',goccu = '" + poccu + "',uid = '" + uid + "' where pno = '"+ctr+"'";
                            MySqlCommand cmd7 = new MySqlCommand(query7, connection);
                            cmd7.ExecuteNonQuery();
                            MessageBox.Show("Information were added to the database");
                            tabPage4.Show();
                            tabControl2.SelectTab("tabPage4");
                            button3.Hide();
                            panel5.Hide();
                            textBox2.Hide();
                            textBox3.Hide();
                            textBox6.Hide();
                            textBox7.Hide();
                            panel6.Enabled = true;
                            panel3.Enabled = false;
                        }
                        catch (MySqlException me) { MessageBox.Show(me.Message); }
                        connection.Close();
                }
               

                if (checkBox35.Checked.Equals(true))
                {
                    textBox3.Show();
                }
                if (checkBox6.Checked.Equals(true))
                {
                    textBox7.Show();
                }
                if (checkBox16.Checked.Equals(true))
                {
                    textBox6.Show();
                }
            }

        private void checkBox17_CheckStateChanged(object sender, EventArgs e)
        {
            label171.ResetText();
        }

        private void textBox16_Enter(object sender, EventArgs e)
        {
            label166.ResetText();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(@"C:\Users\Public\Documents\Appointments"))
            {
                Prescript pres = new Prescript();
                pres.Show();
                string date = "", name = "", prescript = "";
                int pno = 0;

                name = txtname2.Text + ", " + textBox18.Text + " " + textBox19.Text;
                pno = Convert.ToInt32(txtpno2.Text);
                date = prescriptionview.CurrentRow.Cells[0].Value.ToString();
                prescript = prescriptionview.CurrentRow.Cells[1].Value.ToString();

                pres.label2.Text = date;
                pres.label5.Text = name;
                Label lbltxt = new Label();
                lbltxt.Text = prescript;
                lbltxt.AutoSize = true;
                lbltxt.Margin = new Padding(45, 50, 0, 0);
                pres.flowLayoutPanel1.Controls.Add(lbltxt);
            }
            else
            {
                MessageBox.Show("Please create a folder for Prescriptions named 'Prescripts' in public documents to have a copy of pdf");
            }
            
        }

        private void button30_Click(object sender, EventArgs e)
        {
            panel65.Show();
            dataGridView4.Show();
            button31.Show();
            dataGridView2.Hide();
            button32.Hide();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            panel65.Hide();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            panel65.Hide();
        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            string pname = "", date = "", servicename = "", status = "";
            bool check = false;
            Billing bill = new Billing();
            pname = txtname2.Text + ", " + textBox18.Text + " " + textBox19.Text;
            date = label185.Text;
            servicename = label184.Text;

            if (servicename.Equals(" ") && date.Equals(" "))
            {
                MessageBox.Show("No current service");
                check = true;
            }
            if (check == false)
            {
                bill.Show();
                bill.button5.Hide();
                bill.button6.Hide();
                bill.button8.Show();
                bill.comboBox2.Text = pname;
                bill.dateTimePicker1.Text = date;
                bill.comboBox1.Text = servicename;
                bill.comboBox2.Enabled = false;
                bill.dateTimePicker1.Enabled = false;
                bill.comboBox1.Enabled = false;
                this.Hide();
            }
            
        }
    }
}
