using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Lifeway_Institute_Management_System
{
    public class LoginDb : DbConnection
    {
        private String stored_password;

        private MySqlCommand com;
        private MySqlDataReader rs;

        public LoginDb():base()
        {
            this.stored_password = "";
        }

        public bool check(String username, String password)
        {
            try
            {
                MySqlConnection con = base.getConnection();
                String query = "Select password from users where username = '" + username + "'";
                com = new MySqlCommand(query, con);
                con.Open();
                rs = com.ExecuteReader();

                if (rs.HasRows)
                {
                    rs.Read();

                    stored_password = rs.GetString(0);

                    if (password == stored_password)
                    {
                        con.Close();
                        return true;
                    }
                    else
                    {
                        con.Close();
                        return false;
                    }
                }
                else
                {
                    con.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                showErrorMessage(ex, this);
                return false;
            }
        }
    }
}
