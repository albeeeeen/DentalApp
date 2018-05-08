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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void searchbox_Click(object sender, EventArgs e)
        {
            
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            txtage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtadd2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtbday2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtcno2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtpoccu2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtpname2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtgen2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtoccu2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            txtage2.ReadOnly = false;
            txtadd2.ReadOnly = false;
            txtbday2.ReadOnly = false;
            txtcno2.ReadOnly = false;
            txtoccu2.ReadOnly = false;
            txtpname2.ReadOnly = false;
            txtgen2.ReadOnly = false;
            txtpoccu2.ReadOnly = false;
        }
        private void pbackbtn_Click(object sender, EventArgs e)
        {
            Dispose();
            Maintenance main = new Maintenance();
            main.Show();
        }

        private void panel9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcno2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }
    }
}
