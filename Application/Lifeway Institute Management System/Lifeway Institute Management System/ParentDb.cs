using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    public class ParentDb : DbConnection
    {
        Parent parent = new Parent();
        MySqlConnection con;
        MySqlCommand com;

        public ParentDb()
        {

        }

        public ParentDb(Parent parent)
        {
            this.parent = parent;
        }

        public bool check(String name)
        {
            con = getConnection();
            String query = "Select name from Parents where name = '" + name + "'";
            com = new MySqlCommand(query, con);

            con.Open();
            MySqlDataReader dr = com.ExecuteReader();

            if (!dr.Read())
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
        public void insert()
        {
            try
            {
                con = getConnection();
                String query = "Insert into Parents values('" + parent.Name + "', '" + parent.Address + "', " + parent.Tel + ")";
                com = new MySqlCommand(query, con);

                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                showErrorMessage(ex, this);
            }
        }

        public List<String> getNames()
        {
            con = getConnection();
            String query = "Select name from Parents";
            com = new MySqlCommand(query, con);

            con.Open();
            MySqlDataReader dr = com.ExecuteReader();
            List<String> names = new List<String>();

            while (dr.Read())
            {
                names.Add(dr.GetString(0));
            }

            con.Close();
            return names;
        }
    }
}
