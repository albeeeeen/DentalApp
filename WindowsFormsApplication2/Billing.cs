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
    public partial class Billing : Form
    {
        static string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
         + ";" + "PASSWORD=password" + ";";
        MySqlConnection connection = new MySqlConnection(connectionString);
        public Billing()
        {
            InitializeComponent();
            int ctr = 0,dp = 0;
            string name = "", sname = "", mop = "",lname="",fname="",mi="";
           

                connection.Open();
                string query1 = "SELECT * from patienttbl where plname <> 'Null' and pfname <> 'Null'";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
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
                    name = lname + ", " + fname + " " + mi;
                    comboBox2.Items.Add(name);
                }
           
            connection.Close();
            try
            {

                connection.Open();
                string query2 = "SELECT * from servicestbl";
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                MySqlDataReader dataReader2 = cmd2.ExecuteReader();
                while (dataReader2.Read())
                {
                    sname = dataReader2.GetString("servicename");
                    comboBox1.Items.Add(sname);
                }
            }
            catch (MySqlException me)
            {
                MessageBox.Show(me.Message);
            }
            connection.Close();

            ctr = GenerateBillno();
            this.textBox3.Text = ctr.ToString();
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Show();
            button6.Hide();
            button8.Hide();
            label22.Hide();
            textBox2.Hide();
        }
        static int total1 = 0, ntooth, total2 = 0, down = 0, down1 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            label21.ResetText();
            label27.ResetText();
            label28.ResetText();
            int bno = 0, fee = 0, pno = 0, balno = 1, payno = 1, ctr = 0, ctr1 = 0;
            string date = "", service = "", mode = "", name = "";
            int numtooth = 0, total = 0, fee1 = 0, fee2 = 0, downpayment = 0;
            bool check = true, checker = true;

            string tooth1 = "";

            string connectionString = "datasource=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                 + ";" + "PASSWORD=password" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                total2 = Convert.ToInt32(textBox6.Text);
            }
            catch (FormatException) { }
            try
            {
                name = Convert.ToString(comboBox2.SelectedItem);
                if (string.IsNullOrWhiteSpace(name))
                {
                    label28.Text = "Please select patient name";
                    check = false;
                    checker = false;
                }
            }
            catch (NullReferenceException)
            {
                
            }
            bno = Convert.ToInt32(textBox3.Text);
            date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            try
            {
                service = Convert.ToString(comboBox1.SelectedItem);
                fee = Convert.ToInt32(textBox1.Text);
                numtooth = Convert.ToInt32(textBox4.Text);

            }
            catch (FormatException)
            {
                label27.Text = "Input service";
                checker = false;
            }

            try
            {
                ntooth = Convert.ToInt32(textBox7.Text);
                total = Convert.ToInt32(textBox1.Text) * ntooth;
            }
            catch (FormatException)
            {
                label21.Text = "Input number of teeth extracted";
                check = false;
            }
            if (comboBox3.SelectedItem != null)
            {
                mode = comboBox3.SelectedItem.ToString();
            }
            total1 = total + total2;

            if (check && checker)
            {
                string tooth = "";
                textBox6.Text = total1.ToString();

                try
                {

                    connection.Open();
                    string query = "SELECT pno from patienttbl where CONCAT(plname,', ',pfname,' ',pminitial) =  '" + name + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        pno = dataReader.GetInt32("pno");
                    }
                }
                catch (MySqlException me)
                {
                    MessageBox.Show(me.Message);
                }
                connection.Close();

                try
                {
                    connection.Open();
                    string query = "select * from servicestbl where servicename = '" + service + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        tooth = dataReader.GetString("toothno");
                    }
                }
                catch (MySqlException me) { MessageBox.Show(me.Message); }
                connection.Close();

                
                ctr = Convert.ToInt32(textBox3.Text);
                ctr++;
                if (mode == "Monthly Payment")
            {
                label22.Show();
                textBox2.Show();
                textBox2.Enabled = false;
                try
                {
                    connection.Open();
                    string query = "select * from servicestbl where servicename = '" + service + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        downpayment = dataReader.GetInt32("downpay");
                    }
                }
                catch (MySqlException me) { MessageBox.Show(me.Message); }
                connection.Close();
                down += downpayment;
                textBox2.Text = down.ToString();
            }
            else if (mode == "Partial Payment")
            {
                textBox2.Show();
                label22.Show();
                textBox2.Enabled = false;
                try
                {
                    connection.Open();
                    string query = "select * from servicestbl where servicename = '" + service + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        downpayment = dataReader.GetInt32("downpay");
                    }
                }
                catch (MySqlException me) { MessageBox.Show(me.Message); }
                connection.Close();

                down += downpayment;

                textBox2.Text = down.ToString();
            }
            else if (mode == "Full Payment")
            {
                try
                {
                    connection.Open();
                    string query = "select * from servicestbl where servicename = '" + service + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        fee1 = dataReader.GetInt32("servicefee");
                        downpayment = dataReader.GetInt32("downpay");
                    }
                }
                catch (MySqlException me) { MessageBox.Show(me.Message); }
                connection.Close();
                try
                {
                    fee2 = Convert.ToInt32(textBox5.Text);
                }
                catch (FormatException) { fee2 = 0; }
                down += downpayment;
                textBox2.Text = downpayment.ToString();
                fee1 += fee2;
                textBox5.Text = fee1.ToString();
                label22.Hide();
                textBox2.Hide();
                textBox2.Enabled = false;
            }
                down = 0;
                total = 0;
                total1 = 0;
                total2 = 0;
                down1 = 0;
                textBox3.Text = ctr.ToString();
                if (service == "Braces")
                {
                    comboBox1.Items.Remove("Braces");
                }
                if (tooth.Equals("Per Teeth"))
                {
                    dataGridView1.Rows.Add(pno, bno, date, service, ntooth, fee, mode);
                    comboBox1.ResetText();
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button8.Enabled = false;
                }
                else if (tooth.Equals("Whole Teeth"))
                {
                    dataGridView1.Rows.Add(pno, bno, date, service, numtooth, fee, mode);
                    comboBox1.ResetText();
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button8.Enabled = false;

                }
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }
        public int GenerateBillno()
        {
            int ctr = 1;
            try
            {
                connection.Open();
                string query2 = "SELECT * from billingtbl";
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                MySqlDataReader dataReader1 = cmd2.ExecuteReader();
                while (dataReader1.Read())
                {
                    ctr = dataReader1.GetInt32("billno");
                    ctr += 1;
                }
            }
            catch (MySqlException) { }
            connection.Close();
            textBox3.Text = ctr.ToString();
            return ctr;
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            Dispose();
            textBox6.ResetText();
            total1 = 0;
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Show();
            comboBox3.Items.Clear();
            string sname = "", mop = "", teeth = "";
            int fee = 0, sid = 0;

            if (comboBox1.SelectedItem != null)
            {
                sname = comboBox1.SelectedItem.ToString();
            }
            try
            {
                connection.Open();
                string query = "select * from servicestbl where servicename = '" + sname + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    sid = dataReader.GetInt32("serviceid");
                    fee = dataReader.GetInt32("servicefee");
                    teeth = dataReader.GetString("toothno");
                }
            }
            catch (NullReferenceException) { }
            connection.Close();
            if (teeth == "Whole Teeth")
            {
                textBox4.Clear();
                textBox7.Clear();
                textBox7.Hide();
                textBox4.Show();
                textBox4.Enabled = false;
                textBox7.Text = "1";
                textBox4.Text = "32";
            }
            else
            {
                textBox7.Clear();
                textBox4.Clear();
                textBox7.Show();
                textBox7.BringToFront();
                textBox4.ReadOnly = true;
                textBox4.Enabled = false;
                textBox4.SendToBack();
                textBox4.Text = "0";
            }
            textBox1.Text = fee.ToString();

            try
            {

                connection.Open();
                string query1 = "SELECT p.mopname,s.serviceid,p.mopid from servicestbl s, modeofpaymenttbl p, service_modetbl sm where sm.serviceid = '" + sid + "' and sm.serviceid = s.serviceid and sm.mopid = p.mopid order by serviceid,mopid";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    mop = dataReader.GetString("mopname");
                    comboBox3.Items.Add(mop);
                }
            }
            catch (MySqlException me)
            {
                MessageBox.Show(me.Message);
            }
            connection.Close();
            comboBox3.SelectedIndex = 0;
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            
            if (System.IO.Directory.Exists(@"C:\Users\Public\Documents\Receipts"))
            {
                Receipt rec = new Receipt();
                rec.Show();
                string services = "", fee = "", total = "", change = "", ntooth = "", date = "", name = "";
                int rows = 0, amtpd = 0, down = 0;
                rows = dataGridView1.Rows.Count;
                total = textBox6.Text;
                change = textBox8.Text;
                name = comboBox2.SelectedItem.ToString();
                date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                try
                {
                    amtpd = Convert.ToInt32(textBox5.Text);
                }
                catch (FormatException) { }
                try
                {
                    down = Convert.ToInt32(textBox2.Text);
                }
                catch (FormatException) { }
                amtpd += down;
                int y = 8;
                for (int x = 0; x < rows; x++)
                {
                    Label lblservice = new Label();
                    Label lblfee = new Label();
                    Label lblntooth = new Label();
                    lblservice.Margin = new Padding(7, y, 0, 0);
                    lblfee.Margin = new Padding(30, y, 0, 0);
                    lblntooth.Margin = new Padding(10, y, 0, 0);
                    services = Convert.ToString(dataGridView1.Rows[x].Cells[3].Value);
                    fee = Convert.ToString(dataGridView1.Rows[x].Cells[5].Value);
                    ntooth = Convert.ToString(dataGridView1.Rows[x].Cells[4].Value);
                    lblservice.Text = services;
                    lblfee.Text = fee;
                    lblntooth.Text = ntooth;
                    rec.flowLayoutPanel1.Controls.Add(lblservice);
                    rec.flowLayoutPanel1.Controls.Add(lblfee);
                    rec.flowLayoutPanel1.Controls.Add(lblntooth);
                    y += 8;
                }
                rec.label23.Text = total;
                rec.label24.Text = change;
                rec.label2.Text = date;
                rec.label4.Text = amtpd.ToString();
                rec.label5.Text = name;
                label22.Hide();
                textBox2.Hide();
                label25.Hide();
                textBox8.Hide();
                label9.Hide();
                textBox6.Hide();
                label11.Hide();
                textBox5.Hide();
                button4.Hide();
                button3.Enabled = false;
                button5.Enabled = true;
                button6.Enabled = true;
                button8.Enabled = true;
                rec.panel9.Show();
                button1.Hide();
                button2.Hide();
                button2.Hide();
                button1.Hide();
                button4.Hide();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No folder named 'Receipt' we're already processing it please click print again to generate the PDF file");
                System.IO.Directory.CreateDirectory(@"C:\Users\Public\Documents\Receipts");
            }
          
        }

        public void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {


        }

        public int Balno()
        {
            int ctr = 0;
            try
            {
                connection.Open();
                string query2 = "SELECT * from balancetbl";
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                MySqlDataReader dataReader1 = cmd2.ExecuteReader();
                while (dataReader1.Read())
                {
                    ctr = dataReader1.GetInt32("balno");
                }

            }
            catch (MySqlException) { }
            connection.Close();
            return ctr;
        }
        public int PaymentNo()
        {
            int ctr = 0;
            try
            {
                connection.Open();
                string query2 = "SELECT * from paymenttbl";
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                MySqlDataReader dataReader1 = cmd2.ExecuteReader();
                while (dataReader1.Read())
                {
                    ctr = dataReader1.GetInt32("paymentno");
                }

            }
            catch (MySqlException) { }
            connection.Close();
            return ctr;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label10.Text = " ";
            int payment = 0, tfee = 0, bal = 0, change = 0, pno = 0, ctr = 0, balno, payno, userid = 0;
            string name = "", status = "in", appointstatus = "done", mop = "", userlogged = "" ;
            int totalpay = 0, downpayment = 0;
            Form f = Application.OpenForms["Menu"];
            userid = (((Menu)f).User());
            string date, checkdate = "", date1 = "", service = "", mode = "",servicename="";
            int fee = 0, bno = 0, numtooth = 0, billno = 0,checkdp=0;
            bool b = true, check = true;
         
                name = comboBox2.SelectedItem.ToString();
                ctr = dataGridView1.Rows.Count;
                if (ctr <= 0)
                {
                    MessageBox.Show("There's no billing on the list");
                    b = false;
                }
            try
            {
                payment = Convert.ToInt32(textBox5.Text.Trim());
            }
            catch (FormatException) { payment = 0; }
            try
            {
                downpayment = Convert.ToInt32(textBox2.Text);
            }
            catch (FormatException) { downpayment = 0; }
            totalpay = payment + downpayment;
            tfee = Convert.ToInt32(textBox6.Text);
            if (payment > tfee)
                {
                    totalpay = payment; 
                }
            bal = tfee - totalpay;
            if (bal < 0)
            {
                bal = 0;
            }

            date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            mop = comboBox3.Text;
            if (downpayment <= 0 && mop == "Full Payment")
            {
                if (textBox5.Text.Trim().Length == 0)
                {
                    label10.Text = "No payment inputted";
                    b = false;
                }

                if (payment < tfee)
                {
                    label10.Text = "Insufficient payment!";
                    b = false;
                }
            }
            if (b == true)
            {
                
                change = payment - tfee;
                if (change < 0)
                {
                    change = 0;
                }
                textBox8.Text = change.ToString();
                
                try
                {

                    connection.Open();
                    string query = "SELECT pno from patienttbl where CONCAT(plname,', ',pfname,' ',pminitial) = '" + name + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        pno = dataReader.GetInt32("pno");
                    }
                }
                catch (MySqlException me)
                {
                    MessageBox.Show(me.Message);
                }
                connection.Close();
                try
                {

                    connection.Open();
                    string query1 = "INSERT INTO balancetbl(tbal,pno,baldate) values('" + bal + "','" + pno + "','" + date + "')";
                    MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                    cmd1.ExecuteNonQuery();

                    string query2 = "INSERT INTO paymenttbl(amtpd,sukli,pno,paydate,userid) values('" + totalpay + "','" + change + "','" + pno + "','" + date + "','" + userid + "')";
                    MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Done");
                }
                catch (MySqlException me)
                {
                    MessageBox.Show(me.Message);
                }
                connection.Close();

                
                balno = Balno();
                payno = PaymentNo();
                connection.Open();
                for (int x = 0; x < ctr; x++)
                {
                    bno = Convert.ToInt32(dataGridView1.Rows[x].Cells[1].Value);
                    date1 = Convert.ToString(dataGridView1.Rows[x].Cells[2].Value);
                    service = Convert.ToString(dataGridView1.Rows[x].Cells[3].Value);
                    numtooth = Convert.ToInt32(dataGridView1.Rows[x].Cells[4].Value);
                    fee = Convert.ToInt32(dataGridView1.Rows[x].Cells[5].Value);
                    mode = Convert.ToString(dataGridView1.Rows[x].Cells[6].Value);
                    try
                    {
                        string query3 = "INSERT INTO billingtbl values('" + bno + "','" + date1 + "','" + service + "','" + numtooth + "','" + fee + "','" + mode + "','" + pno + "','" + payno + "','" + balno + "')";
                        MySqlCommand cmd3 = new MySqlCommand(query3, connection);
                        cmd3.ExecuteNonQuery();
                    }
                    catch (MySqlException) { MessageBox.Show("Sorry Billing number already occupied!"); }
                }
                connection.Close();

                connection.Open();
                string query5 = "UPDATE appointmenttbl set appointstatus = '" + appointstatus + "' where appointdate = '" + date + "' and pname = '" + name + "'";
                MySqlCommand cmd5 = new MySqlCommand(query5, connection);
                cmd5.ExecuteNonQuery();
                connection.Close();
                button3.Enabled = true;
                button1.Enabled = false;
                button5.Enabled = false;
                button2.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int fee = 0, prevfee = 0, lastfee = 0, rows = 0, down = 0, down1 = 0;
            string service = "", tooth = "";
            rows = dataGridView1.CurrentCell.RowIndex;
            service = dataGridView1.Rows[rows].Cells[3].Value.ToString();
            prevfee = Convert.ToInt32(textBox6.Text);
            down = Convert.ToInt32(textBox2.Text);
            try
            {

                connection.Open();
                string query = "SELECT * from servicestbl where servicename = '" + service + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    tooth = dataReader.GetString("toothno");
                    down1 = dataReader.GetInt32("downpay");
                }
            }
            catch (MySqlException me)
            {
                MessageBox.Show(me.Message);
            }
            connection.Close();
            down = down - down1;
            if (down == 0)
            {
                label22.Hide();
                textBox2.Hide();
            }
            textBox2.Text = down.ToString();
            if (tooth.Equals("Whole Teeth"))
            {
                fee = Convert.ToInt32(dataGridView1.Rows[rows].Cells[5].Value);
            }
            else if (tooth.Equals("Per Teeth"))
            {
                fee = Convert.ToInt32(dataGridView1.Rows[rows].Cells[5].Value) * Convert.ToInt32(this.dataGridView1.Rows[rows].Cells[4].Value);
            }
            lastfee = prevfee - fee;
            textBox6.Text = lastfee.ToString();
            dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);

            
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string pname = comboBox2.Text;
            int pno = 0;
            Maintenance mainte = new Maintenance();
            connection.Open();
            string query = "SELECT pno from patienttbl where CONCAT(plname,', ',pfname,' ',pminitial) = '" + pname + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                pno = dataReader.GetInt32("pno");
            }
            connection.Close();
            
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
            this.Hide();
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            label28.ResetText();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }
        





    }
}
