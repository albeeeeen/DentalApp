using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class DbConnect
    {
        public MySqlConnection connection;
        
        public DbConnect()
        {
            Initialize();
        }
        public void Initialize()
        {
            string connectionString = "SERVER=localhost" + ";" + "DATABASE=dentaldb" + ";" + "UID=root"
                  + ";" + "PASSWORD=09983609153" + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
        }
    
    }

}
