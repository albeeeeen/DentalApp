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
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.IO;
using Novacode;
using PdfSharp.Pdf;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Globalization;
using System.Reflection;
using System.Security.Policy;

namespace WindowsFormsApplication2
{
    public partial class Reports : Form
    {
        
        public Reports()
        {
            InitializeComponent();

            for (int x = DateTime.Now.Year; x >= 1960; x--)
            {
                comboBox1.Items.Add(x);
                comboBox6.Items.Add(x);
                comboBox9.Items.Add(x);
                comboBox11.Items.Add(x);
                comboBox14.Items.Add(x);
                comboBox17.Items.Add(x);
            }

            for (int y = 5; y <= 75; y++)
            {
                comboBox25.Items.Add(y);
            }

            tabControl1.Show();
            tabControl4.Hide();

            comboBox2.SelectedIndex = 0;
            label4.Hide();
            comboBox3.Hide();
            button8.Hide();
            label3.Hide();
            comboBox1.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            label5.Hide();
            label6.Hide();
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();

            comboBox4.SelectedIndex = 0;
            label7.Hide();
            label8.Hide();
            dateTimePicker3.Hide();
            dateTimePicker4.Hide();
            button10.Hide();
            button11.Hide();
            button13.Hide();
            button12.Hide();
            button14.Hide();
            label9.Hide();
            label10.Hide();
            comboBox5.Hide();
            comboBox6.Hide();


            label12.Hide();
            dateTimePicker6.Hide();
            label11.Hide();
            dateTimePicker5.Hide();
            label13.Hide();
            comboBox8.Hide();
            label14.Hide();
            comboBox9.Hide();
            button16.Hide();
            button17.Hide();
            button18.Hide();
            button19.Hide();

            label16.Hide();
            dateTimePicker8.Hide();
            label15.Hide();
            dateTimePicker7.Hide();
            label17.Hide();
            comboBox10.Hide();
            label18.Hide();
            comboBox11.Hide();
            button21.Hide();
            button22.Hide();
            button23.Hide();
            button24.Hide();

            button27.Hide();
            button28.Hide();
            button29.Hide();
            button30.Hide();
            label20.Hide();
            dateTimePicker10.Hide();
            label19.Hide();
            dateTimePicker9.Hide();
            label21.Hide();
            comboBox13.Hide();
            label22.Hide();
            comboBox14.Hide();
            comboBox7.SelectedIndex = 0;
            comboBox12.SelectedIndex = 0;
            comboBox15.SelectedIndex = 0;
            comboBox18.SelectedIndex = 0;
            comboBox22.SelectedIndex = 0;

            tabControl1.Show();
            tabControl4.Hide();
        }
      
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(@"C:\Users\Public\Documents\Receipts"))
            {
                Process.Start(@"C:\Users\Public\Documents\Receipts");
            }
            else
            {
                MessageBox.Show("File not found");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(@"C:\Users\Public\Documents\Appointments"))
            {
                Process.Start(@"C:\Users\Public\Documents\Appointments");
            }
            else
            {
                MessageBox.Show("File not found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(@"C:\Users\Public\Documents\Prescripts"))
            {
                Process.Start(@"C:\Users\Public\Documents\Prescripts");
            }
            else
            {
                MessageBox.Show("File not found");
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
        }

        private void crystalReportViewer3_Load(object sender, EventArgs e)
        {
        }

        private void crystalReportViewer4_Load(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "Daily")
            {
               
                label4.Hide();
                comboBox3.Hide();
                button8.Hide();
                label3.Hide();
                comboBox1.Hide();
                button7.Hide();
                button8.Hide();
                button9.Hide();
                button10.Hide();
                label5.Hide();
                label6.Hide();
                dateTimePicker1.Hide();
                dateTimePicker2.Hide();
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"financial.rpt");

                ConnectionInfo crConnectionInfo = new ConnectionInfo();

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";

                crystalReportViewer5.ReportSource = cryRpt;
                crystalReportViewer5.Refresh();
            }
            else if(comboBox2.SelectedItem == "Weekly")
            {
                button15.Hide();
                label4.Hide();
                comboBox3.Hide();
                button8.Hide();
                label3.Hide();
                comboBox1.SelectedIndex = 0;
                comboBox1.Show();
                button7.Hide();
                button8.Hide();
                button9.Hide();
                label5.Hide();
                label6.Hide();
                dateTimePicker1.Hide();
                dateTimePicker2.Hide();
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"weeklyfinance.rpt");

                ConnectionInfo crConnectionInfo = new ConnectionInfo();

                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = DateTime.Today.Year;
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["yearparaminweek"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;
                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";

                crystalReportViewer5.ReportSource = cryRpt;
                crystalReportViewer5.Refresh();
            }
            else if (comboBox2.SelectedItem == "Monthly")
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"monthfinancial.rpt");
                ConnectionInfo crConnectionInfo = new ConnectionInfo();

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";

                crystalReportViewer5.ReportSource = cryRpt;
                crystalReportViewer5.Refresh();

                button15.Hide();
                label5.Hide();
                label6.Hide();
                dateTimePicker1.Hide();
                dateTimePicker2.Hide();
                button7.Hide();
                button9.Hide();
                label4.Show();
                comboBox3.SelectedIndex = 0;
                comboBox3.Show();
                button8.Show();
                label3.Show();
                comboBox1.SelectedIndex = 0;
                comboBox1.Show();
            }
            else if (comboBox2.SelectedItem == "Annually")
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"GenAnnualFinance.rpt");
                ConnectionInfo crConnectionInfo = new ConnectionInfo();

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";

                crystalReportViewer5.ReportSource = cryRpt;
                crystalReportViewer5.Refresh();

                button15.Hide();
                label5.Hide();
                label6.Hide();
                dateTimePicker1.Hide();
                dateTimePicker2.Hide();
                label4.Hide();
                comboBox3.Hide();
                button8.Hide();
                button9.Hide();
                label3.Show();
                comboBox1.SelectedIndex = 0;
                comboBox1.Show();
                button7.Show();
            }
            else if (comboBox2.SelectedItem == "Select Dates")
            {
                button15.Hide();
                label4.Hide();
                comboBox3.Hide();
                button8.Hide();
                label3.Hide();
                comboBox1.Hide();
                button7.Hide();
                label5.Show();
                label6.Show();
                dateTimePicker1.Show();
                dateTimePicker2.Show();
                button9.Show();
            }
        }
        private void crystalReportViewer5_Load(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"yearfinancial.rpt");

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = comboBox1.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";
            
            crystalReportViewer5.ReportSource = cryRpt;
            crystalReportViewer5.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"PerMonthFinance.rpt");

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();
            try
            {
                crParameterDiscreteValue.Value = comboBox3.SelectedItem.ToString();
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["monthparam"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;
                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            }
            catch (Exception) { }
            try
            {
            crParameterDiscreteValue.Value = comboBox1.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            }
            catch (Exception) { }

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";

            crystalReportViewer5.ReportSource = cryRpt;
            crystalReportViewer5.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"DateRange.rpt");

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["firstdate"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["seconddate"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";

            crystalReportViewer5.ReportSource = cryRpt;
            crystalReportViewer5.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"weeklyfinance.rpt");

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = comboBox1.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["yearparaminweek"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";

            crystalReportViewer5.ReportSource = cryRpt;
            crystalReportViewer5.Refresh();
        }

        private void comboBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem == "Daily")
            {
                todaybtn.Show();
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"DailyAppoint.rpt");

                ConnectionInfo crConnectionInfo = new ConnectionInfo();

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";

                crystalReportViewer6.ReportSource = cryRpt;
                crystalReportViewer6.Refresh();
            }
            else if (comboBox4.SelectedItem == "Weekly")
            {
                todaybtn.Hide();
                label10.Show();
                button12.Hide();
                button13.Hide();
                button14.Hide();
                comboBox6.SelectedIndex = 0;
                comboBox6.Show();
                button11.Show();
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"WeeklyAppoint.rpt");

                ConnectionInfo crConnectionInfo = new ConnectionInfo();

                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = DateTime.Today.Year;
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;
                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";

                crystalReportViewer6.ReportSource = cryRpt;
                crystalReportViewer6.Refresh();
            }
            else if (comboBox4.SelectedItem == "Monthly")
            {
                label7.Hide();
                label8.Hide();
                dateTimePicker3.Hide();
                dateTimePicker4.Hide();
                todaybtn.Hide();
                label10.Show();
                button13.Hide();
                button14.Hide();
                comboBox5.SelectedIndex = 0;
                comboBox6.SelectedIndex = 0;
                comboBox6.Show();
                button11.Hide();
                label9.Show();
                comboBox5.Show();
                button12.Show();

                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"MonthlyAppoint.rpt");

                ConnectionInfo crConnectionInfo = new ConnectionInfo();

                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = DateTime.Today.Year;
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;
                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";

                crystalReportViewer6.ReportSource = cryRpt;
                crystalReportViewer6.Refresh();
            }
            else if (comboBox4.SelectedItem == "Annually")
            {
                label10.Show();
                comboBox6.SelectedIndex = 0;
                comboBox6.Show();
                button13.Show();
                label7.Hide();
                label8.Hide();
                dateTimePicker3.Hide();
                dateTimePicker4.Hide();
                todaybtn.Hide();
                button10.Hide();
                button11.Hide();
                button12.Hide();
                button14.Hide();
                label9.Hide();
                comboBox5.Hide();

                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"AnnualAppoint.rpt");

                ConnectionInfo crConnectionInfo = new ConnectionInfo();

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";

                crystalReportViewer6.ReportSource = cryRpt;
                crystalReportViewer6.Refresh();
            }
            else if (comboBox4.SelectedItem == "Select Dates")
            {
                label8.Show();
                dateTimePicker4.Show();
                label7.Show();
                dateTimePicker3.Show();
                label10.Show();
                comboBox6.Hide();
                button13.Hide();
                todaybtn.Hide();
                button10.Hide();
                button11.Hide();
                button12.Hide();
                button14.Hide();
                label9.Hide();
                comboBox5.Hide();
                button14.Show();
            }
        }

        private void todaybtn_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"TodayAppoint.rpt");

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = DateTime.Today;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["dailyparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";

            crystalReportViewer6.ReportSource = cryRpt;
            crystalReportViewer6.Refresh();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"WeekAppointPerYear.rpt");

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = comboBox6.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["yearappparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";

            crystalReportViewer6.ReportSource = cryRpt;
            crystalReportViewer6.Refresh();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"MonthYearAppoint.rpt");

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = comboBox6.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["yearappparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = comboBox5.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["monthappparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";

            crystalReportViewer6.ReportSource = cryRpt;
            crystalReportViewer6.Refresh();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"TodayFinance.rpt");

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = DateTime.Today;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["todayparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";

            crystalReportViewer5.ReportSource = cryRpt;
            crystalReportViewer5.Refresh();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"AnnualAppointPerYear.rpt");

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = comboBox6.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";

            crystalReportViewer6.ReportSource = cryRpt;
            crystalReportViewer6.Refresh();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"AppSelectDate.rpt");

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = dateTimePicker4.Value.ToString("MM/dd/yyyy");
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["firstdateapp"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = dateTimePicker3.Value.ToString("MM/dd/yyyy");
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["seconddateapp"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";

            crystalReportViewer6.ReportSource = cryRpt;
            crystalReportViewer6.Refresh();
        }

        private void comboBox7_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox7.SelectedItem == "Daily")
            {
                label12.Hide();
                dateTimePicker6.Hide();
                label11.Hide();
                dateTimePicker5.Hide();
                label13.Hide();
                comboBox8.Hide();
                label14.Hide();
                comboBox9.Hide();
                button16.Hide();
                button17.Hide();
                button18.Hide();
                button19.Hide();
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"DailyService.rpt");

                ConnectionInfo crConnectionInfo = new ConnectionInfo();

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";

                crystalReportViewer7.ReportSource = cryRpt;
                crystalReportViewer7.Refresh();
            }
            else if (comboBox7.SelectedItem == "Weekly")
            {
                label12.Hide();
                dateTimePicker6.Hide();
                label11.Hide();
                dateTimePicker5.Hide();
                label13.Hide();
                comboBox8.Hide();
                label14.Show();
                comboBox9.Show();
                button16.Show();
                button17.Hide();
                button18.Hide();
                button19.Hide();
                button20.Hide();

                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"WeeklyService.rpt");

                ConnectionInfo crConnectionInfo = new ConnectionInfo();

                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = DateTime.Today.Year;
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["yearnow"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;
                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);


                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";

                crystalReportViewer7.ReportSource = cryRpt;
                crystalReportViewer7.Refresh();

            }
            else if (comboBox7.SelectedItem == "Monthly")
            {
                label12.Hide();
                dateTimePicker6.Hide();
                label11.Hide();
                dateTimePicker5.Hide();
                label13.Show();
                comboBox8.Show();
                label14.Show();
                comboBox9.Show();
                button16.Hide();
                button17.Show();
                button18.Hide();
                button19.Hide();
                button20.Hide();

                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"MonthlyService.rpt");

                ConnectionInfo crConnectionInfo = new ConnectionInfo();

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";

                crystalReportViewer7.ReportSource = cryRpt;
                crystalReportViewer7.Refresh();
            }
            else if (comboBox7.SelectedItem == "Annually")
            {
                label12.Hide();
                dateTimePicker6.Hide();
                label11.Hide();
                dateTimePicker5.Hide();
                label13.Hide();
                comboBox8.Hide();
                label14.Show();
                comboBox9.Show();
                button16.Hide();
                button17.Hide();
                button18.Show();
                button19.Hide();
                button20.Hide();

                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"AnnualService.rpt");

                ConnectionInfo crConnectionInfo = new ConnectionInfo();

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";

                crystalReportViewer7.ReportSource = cryRpt;
                crystalReportViewer7.Refresh();
            }
            else if (comboBox7.SelectedItem == "Select Dates")
            {
                label12.Show();
                dateTimePicker6.Show();
                label11.Show();
                dateTimePicker5.Show();
                label13.Hide();
                comboBox8.Hide();
                label14.Hide();
                comboBox9.Hide();
                button16.Hide();
                button17.Hide();
                button18.Hide();
                button19.Show();
                button20.Hide();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"TodayAppPerService.rpt");

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = DateTime.Today;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["datenow"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";

            crystalReportViewer7.ReportSource = cryRpt;
            crystalReportViewer7.Refresh();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"WeeklyServicePerYear.rpt");

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = comboBox9.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["yearparamserv"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";

            crystalReportViewer7.ReportSource = cryRpt;
            crystalReportViewer7.Refresh();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"MonthlyServicePerYear.rpt");

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = comboBox9.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = comboBox8.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["monthparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";

            crystalReportViewer7.ReportSource = cryRpt;
            crystalReportViewer7.Refresh();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"AnnualServicePerYear.rpt");

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = comboBox9.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";

            crystalReportViewer7.ReportSource = cryRpt;
            crystalReportViewer7.Refresh();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"ServiceSelectDate.rpt");

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = dateTimePicker6.Value.ToString("MM/dd/yyyy");
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["firstdate"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = dateTimePicker5.Value.ToString("MM/dd/yyyy");
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["seconddate"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";

            crystalReportViewer7.ReportSource = cryRpt;
            crystalReportViewer7.Refresh();
        }

        private void comboBox12_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBox12.SelectedItem == "Daily")
            {
                button25.Show();
                label16.Hide();
                dateTimePicker8.Hide();
                label15.Hide();
                dateTimePicker7.Hide();
                label17.Hide();
                comboBox10.Hide();
                label18.Hide();
                comboBox11.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();

                 ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"DailyVisits.rpt");

                ConnectionInfo crConnectionInfo = new ConnectionInfo();

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";

                crystalReportViewer8.ReportSource = cryRpt;
                crystalReportViewer8.Refresh();
            }
            
            else if(comboBox12.SelectedItem == "Weekly")
            {
                button25.Hide();
                label16.Hide();
                dateTimePicker8.Hide();
                label15.Hide();
                dateTimePicker7.Hide();
                label17.Hide();
                comboBox10.Hide();
                comboBox11.SelectedIndex = 0;
                label18.Show();
                comboBox11.Show();
                button21.Show();
                button22.Hide();
                button23.Hide();
                button24.Hide();

            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"WeeklyVisit.rpt");

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = DateTime.Today.Year;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";

            crystalReportViewer8.ReportSource = cryRpt;
            crystalReportViewer8.Refresh();
            }

            else if(comboBox12.SelectedItem == "Monthly")
            {
                button25.Hide();
                label16.Hide();
                dateTimePicker8.Hide();
                label15.Hide();
                dateTimePicker7.Hide();
                comboBox11.SelectedIndex = 0;
                comboBox10.SelectedIndex = 0;
                label17.Show();
                comboBox10.Show();
                label18.Show();
                comboBox11.Show();
                button21.Hide();
                button22.Show();
                button23.Hide();
                button24.Hide();

                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"MonthlyVisitsrpt.rpt");

                ConnectionInfo crConnectionInfo = new ConnectionInfo();

                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = DateTime.Today.Year;
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;
                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";

                crystalReportViewer8.ReportSource = cryRpt;
                crystalReportViewer8.Refresh();
            }

            else if(comboBox12.SelectedItem == "Annually")
            {
                button25.Hide();
                label16.Hide();
                dateTimePicker8.Hide();
                label15.Hide();
                dateTimePicker7.Hide();
                comboBox11.SelectedIndex = 0;
                label17.Hide();
                comboBox10.Hide();
                label18.Show();
                comboBox11.Show();
                button21.Hide();
                button22.Hide();
                button23.Show();
                button24.Hide();

                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"AnnualVisitsrpt.rpt");

                ConnectionInfo crConnectionInfo = new ConnectionInfo();

                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = DateTime.Today.Year;
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;
                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";

                crystalReportViewer8.ReportSource = cryRpt;
                crystalReportViewer8.Refresh();
            }

            else if(comboBox12.SelectedItem == "Select Dates")
            {
                button25.Hide();
                label16.Show();
                dateTimePicker8.Show();
                label15.Show();
                dateTimePicker7.Show();
                label17.Hide();
                comboBox10.Hide();
                label18.Hide();
                comboBox11.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Show();


            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"WeeklyVisit.rpt");

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = comboBox11.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";

            crystalReportViewer8.ReportSource = cryRpt;
            crystalReportViewer8.Refresh();
        
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"MonthlyVisitsPerYearrpt.rpt");

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = comboBox11.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = comboBox10.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["monthparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";

            crystalReportViewer8.ReportSource = cryRpt;
            crystalReportViewer8.Refresh();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"AnnualVisitsrpt.rpt");

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = comboBox11.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";

            crystalReportViewer8.ReportSource = cryRpt;
            crystalReportViewer8.Refresh();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"SelectDatesVisits.rpt");

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = dateTimePicker8.Value.ToString("MM/dd/yyyy");
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["firstdate"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = dateTimePicker7.Value.ToString("MM/dd/yyyy");
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["seconddate"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";

            crystalReportViewer8.ReportSource = cryRpt;
            crystalReportViewer8.Refresh();
        }

        private void crystalReportViewer9_Load(object sender, EventArgs e)
        {
            comboBox25.SelectedIndex = 0;
            comboBox26.SelectedIndex = 0;
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"PatientList.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";
            CrTables = cryRpt.Database.Tables;


            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            crystalReportViewer9.ReportSource = cryRpt;
            crystalReportViewer9.Refresh();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            String age = "";

            if (comboBox25.SelectedItem.ToString() != "All")
            {
                age = comboBox25.SelectedItem.ToString();
            }

            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"PatientListFiltered.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = textBox1.Text;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["name"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = age;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["age"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = comboBox26.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["gender"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";
            CrTables = cryRpt.Database.Tables;


            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            crystalReportViewer9.ReportSource = cryRpt;
            crystalReportViewer9.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.Show();
            tabControl4.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.Hide();
            tabControl4.Show();
        }

        private void tabControl4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox15_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox15.SelectedItem == "Daily")
            {
                button27.Hide();
                button28.Hide();
                button29.Hide();
                button30.Hide();
                label20.Hide();
                dateTimePicker10.Hide();
                label19.Hide();
                dateTimePicker9.Hide();
                label21.Hide();
                comboBox13.Hide();
                label22.Hide();
                comboBox14.Hide();

                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"DailyFinanceLists.rpt");

                TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                Tables CrTables;

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";
                CrTables = cryRpt.Database.Tables;


                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
                }

                crystalReportViewer13.ReportSource = cryRpt;
                crystalReportViewer13.Refresh();
            }

            else if (comboBox15.SelectedItem == "Weekly")
            {
                button26.Hide();
                button27.Show();
                button28.Hide();
                button29.Hide();
                button30.Hide();
                label20.Hide();
                dateTimePicker10.Hide();
                label19.Hide();
                dateTimePicker9.Hide();
                comboBox14.SelectedIndex = 0;
                label21.Hide();
                comboBox13.Hide();
                label22.Show();
                comboBox14.Show();

                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"WeeklyFinanceList.rpt");

                TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                Tables CrTables;
                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = DateTime.Today.Year;
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;
                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";
                CrTables = cryRpt.Database.Tables;


                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
                }

                crystalReportViewer13.ReportSource = cryRpt;
                crystalReportViewer13.Refresh();
            }

            else if (comboBox15.SelectedItem == "Monthly")
            {
                button26.Hide();
                button27.Hide();
                button28.Show();
                button29.Hide();
                button30.Hide();
                label20.Hide();
                dateTimePicker10.Hide();
                label19.Hide();
                dateTimePicker9.Hide();
                comboBox13.SelectedIndex = 0;
                comboBox14.SelectedIndex = 0;
                label21.Show();
                comboBox13.Show();
                label22.Show();
                comboBox14.Show();

                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"MonthlyFinanceList.rpt");

                TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                Tables CrTables;

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";
                CrTables = cryRpt.Database.Tables;


                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
                }

                crystalReportViewer13.ReportSource = cryRpt;
                crystalReportViewer13.Refresh();
            }

            else if (comboBox15.SelectedItem == "Annually")
            {
                button26.Hide();
                button27.Hide();
                button28.Hide();
                button29.Show();
                button30.Hide();
                label20.Hide();
                dateTimePicker10.Hide();
                comboBox14.SelectedIndex = 0;
                label19.Hide();
                dateTimePicker9.Hide();
                label21.Hide();
                comboBox13.Hide();
                label22.Show();
                comboBox14.Show();

                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"YearlyFinanceList.rpt");

                TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                Tables CrTables;
                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = DateTime.Today.Year;
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;
                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";
                CrTables = cryRpt.Database.Tables;


                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
                }

                crystalReportViewer13.ReportSource = cryRpt;
                crystalReportViewer13.Refresh();
            }

            else if (comboBox15.SelectedItem == "Select Dates")
            {
                button26.Hide();
                button27.Hide();
                button28.Hide();
                button29.Hide();
                button30.Show();
                label20.Show();
                dateTimePicker10.Show();
                label19.Show();
                dateTimePicker9.Show();
                label21.Hide();
                comboBox13.Hide();
                label22.Hide();
                comboBox14.Hide();

            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"TodayFinanceList.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = DateTime.Today;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["today"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";
            CrTables = cryRpt.Database.Tables;


            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            crystalReportViewer13.ReportSource = cryRpt;
            crystalReportViewer13.Refresh();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"WeeklyFinanceList.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = comboBox14.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";
            CrTables = cryRpt.Database.Tables;


            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            crystalReportViewer13.ReportSource = cryRpt;
            crystalReportViewer13.Refresh();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"MonthlyFinanceListperYear.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = comboBox13.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["monthparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = comboBox14.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";
            CrTables = cryRpt.Database.Tables;


            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            crystalReportViewer13.ReportSource = cryRpt;
            crystalReportViewer13.Refresh();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"YearlyFinanceList.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = comboBox14.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";
            CrTables = cryRpt.Database.Tables;


            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            crystalReportViewer13.ReportSource = cryRpt;
            crystalReportViewer13.Refresh();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"SelectDateFinance.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = dateTimePicker10.Value.ToString("MM/dd/yyyy");
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["firstdate"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = dateTimePicker9.Value.ToString("MM/dd/yyyy");
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["seconddate"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";
            CrTables = cryRpt.Database.Tables;


            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            crystalReportViewer13.ReportSource = cryRpt;
            crystalReportViewer13.Refresh();
        }

        private void comboBox18_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox18.SelectedItem == "Daily")
            {
                label24.Hide();
                dateTimePicker12.Hide();
                label23.Hide();
                dateTimePicker11.Hide();
                label25.Hide();
                comboBox16.Hide();
                label26.Hide();
                comboBox17.Hide();
                button31.Hide();
                button32.Hide();
                button33.Hide();
                button34.Hide();

                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"DailyAppointmentList.rpt");

                TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                Tables CrTables;
                
                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";
                CrTables = cryRpt.Database.Tables;


                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
                }

                crystalReportViewer10.ReportSource = cryRpt;
                crystalReportViewer10.Refresh();
            }

            else if (comboBox18.SelectedItem == "Weekly")
            {
                label24.Hide();
                dateTimePicker12.Hide();
                label23.Hide();
                dateTimePicker11.Hide();
                label25.Hide();
                comboBox16.Hide();
                comboBox17.SelectedIndex = 0;
                label26.Show();
                comboBox17.Show();
                button31.Show();
                button32.Hide();
                button33.Hide();
                button34.Hide();
                button35.Hide();

                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"WeeklyAppointmentList.rpt");

                TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                Tables CrTables;
                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = DateTime.Today.Year;
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;
                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";
                CrTables = cryRpt.Database.Tables;


                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
                }

                crystalReportViewer10.ReportSource = cryRpt;
                crystalReportViewer10.Refresh();
            }

            else if (comboBox18.SelectedItem == "Monthly")
            {
                label24.Hide();
                dateTimePicker12.Hide();
                label23.Hide();
                dateTimePicker11.Hide();
                comboBox16.SelectedIndex = 0;
                comboBox17.SelectedIndex = 0;
                label25.Show();
                comboBox16.Show();
                label26.Show();
                comboBox17.Show();
                button31.Hide();
                button32.Show();
                button33.Hide();
                button34.Hide();
                button35.Hide();

                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"MonthlyAppointmentList.rpt");

                TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                Tables CrTables;
                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = DateTime.Today.Year;
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["year"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;
                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";
                CrTables = cryRpt.Database.Tables;


                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
                }

                crystalReportViewer10.ReportSource = cryRpt;
                crystalReportViewer10.Refresh();
            }

            else if (comboBox18.SelectedItem == "Annually")
            {
                label24.Hide();
                dateTimePicker12.Hide();
                label23.Hide();
                dateTimePicker11.Hide();
                comboBox17.SelectedIndex = 0;
                label25.Hide();
                comboBox16.Hide();
                label26.Show();
                comboBox17.Show();
                button31.Hide();
                button32.Hide();
                button33.Show();
                button34.Hide();
                button35.Hide();

                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"AnnualAppointmentList.rpt");

                TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                Tables CrTables;
                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = DateTime.Today.Year;
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;
                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";
                CrTables = cryRpt.Database.Tables;


                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
                }

                crystalReportViewer10.ReportSource = cryRpt;
                crystalReportViewer10.Refresh();
            }

            else if (comboBox18.SelectedItem == "Select Dates")
            {
                label24.Show();
                dateTimePicker12.Show();
                label23.Show();
                dateTimePicker11.Show();
                label25.Hide();
                comboBox16.Hide();
                label26.Hide();
                comboBox17.Hide();
                button31.Hide();
                button32.Hide();
                button33.Hide();
                button34.Show();
                button35.Hide();
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"TodayAppointmentList.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = DateTime.Today;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["today"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";
            CrTables = cryRpt.Database.Tables;


            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            crystalReportViewer10.ReportSource = cryRpt;
            crystalReportViewer10.Refresh();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"WeeklyAppointmentList.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = comboBox17.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";
            CrTables = cryRpt.Database.Tables;


            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            crystalReportViewer10.ReportSource = cryRpt;
            crystalReportViewer10.Refresh();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"MonthlyAppointmentperYear.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = comboBox17.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = comboBox16.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["monthparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";
            CrTables = cryRpt.Database.Tables;


            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            crystalReportViewer10.ReportSource = cryRpt;
            crystalReportViewer10.Refresh();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"AnnualAppointmentList.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = comboBox17.SelectedItem.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["yearparam"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";
            CrTables = cryRpt.Database.Tables;


            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            crystalReportViewer10.ReportSource = cryRpt;
            crystalReportViewer10.Refresh();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"SelectDatesAppointment.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = dateTimePicker12.Value.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["firstdate"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = dateTimePicker11.Value.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["seconddate"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = "localhost";
            crConnectionInfo.DatabaseName = "dentaldb";
            crConnectionInfo.UserID = "root";
            crConnectionInfo.Password = "password";
            CrTables = cryRpt.Database.Tables;


            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            crystalReportViewer10.ReportSource = cryRpt;
            crystalReportViewer10.Refresh();
        }

        private void comboBox22_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox22.SelectedItem == "Daily")
            {
                label32.Hide();
                dateTimePicker16.Hide();
                label31.Hide();
                dateTimePicker15.Hide();
                
                button45.Hide();
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"DailyVisitList.rpt");

                TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                Tables CrTables;

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";
                CrTables = cryRpt.Database.Tables;


                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
                }

                crystalReportViewer10.ReportSource = cryRpt;
                crystalReportViewer10.Refresh();
            }
            else if (comboBox22.SelectedItem == "Weekly")
            {
                label32.Hide();
                dateTimePicker16.Hide();
                label31.Hide();
                dateTimePicker15.Hide();

                button45.Hide();
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"WeeklyVisitList.rpt");

                TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                Tables CrTables;

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";
                CrTables = cryRpt.Database.Tables;


                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
                }

                crystalReportViewer10.ReportSource = cryRpt;
                crystalReportViewer10.Refresh();
            }
            else if (comboBox22.SelectedItem == "Monthly")
            {
                label32.Hide();
                dateTimePicker16.Hide();
                label31.Hide();
                dateTimePicker15.Hide();

                button45.Hide();
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"MonthlyVisitList.rpt");

                TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                Tables CrTables;

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";
                CrTables = cryRpt.Database.Tables;


                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
                }

                crystalReportViewer10.ReportSource = cryRpt;
                crystalReportViewer10.Refresh();
            }

            else if (comboBox22.SelectedItem == "Annually")
            {
                label32.Hide();
                dateTimePicker16.Hide();
                label31.Hide();
                dateTimePicker15.Hide();

                button45.Hide();
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+"AnnualVisitList.rpt");

                TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                Tables CrTables;

                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "dentaldb";
                crConnectionInfo.UserID = "root";
                crConnectionInfo.Password = "password";
                CrTables = cryRpt.Database.Tables;


                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
                }

                crystalReportViewer10.ReportSource = cryRpt;
                crystalReportViewer10.Refresh();
            }
        }

    }
}
