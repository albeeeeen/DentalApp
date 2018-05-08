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
    public partial class PatientInfo : Form
    {
        public PatientInfo()
        {
            InitializeComponent();
        }


        
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
            Menu menu = new Menu();
            menu.Show();
        }

        private void namebox_Click(object sender, EventArgs e)
        {
            
        }


    }
}
