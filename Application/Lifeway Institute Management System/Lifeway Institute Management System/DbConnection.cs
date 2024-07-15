using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MySql.Data.MySqlClient;

namespace Lifeway_Institute_Management_System
{
    public class DbConnection
    {
        private MySqlConnection connection;

        private String host = "localhost";
        private String username = "root";
        private String pwd = "";
        private String database = "Lifeway";
        private String str;

        public DbConnection() {
            //sets the connection string to connect with the database
            this.str = "server=" + host + ";user=" + username + ";pwd=" + pwd + ";database=" + database + "";

            //create the connection to the database
            try
            {
                connection = new MySqlConnection(str);
            }
            catch (Exception ex)
            {
                showErrorMessage(ex, this);
            }
        }
        public void showErrorMessage(Exception ex, Object from)
        {
            MessageBox.Show("Something went wrong please contact developer \nError Details\nError generated : " +from.GetType()+ "\nError code: " +ex.Message);
        }

        public MySqlConnection getConnection()
        {
            return this.connection;
        }
    }
}
