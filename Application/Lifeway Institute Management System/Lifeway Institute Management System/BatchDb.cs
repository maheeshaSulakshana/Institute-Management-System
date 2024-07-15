using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    public class BatchDb: DbConnection
    {
        Batch batch;
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader dr;
        public BatchDb()
        {

        }

        public BatchDb(Batch batch)
        {
            this.batch = batch;
        }

        public bool check(String name, String classtype, String agegroup)
        {
            con = getConnection();
            String query = "Select name from batches where name = '" + name + "' and classType = '" + classtype + "' and AgeGroup = '" + agegroup + "'";
            com = new MySqlCommand(query, con);

            con.Open();
            MySqlDataReader dr = com.ExecuteReader();

            if (!dr.Read())
            {
                con.Close();
                return true;
            }

            con.Close();
            return false;
        }

        public void insert()
        {
            con = getConnection();
            String query = "insert into batches(Name, classType, ageGroup) " +
                                            "values('" + batch.Name + "', '" + batch.ClassType + "', '" + batch.AgeGroup + "')";
            com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteReader();
            con.Close();
        }

        public List<int> getBatchIDs()
        {
            con = getConnection();
            String query = "Select BatchID from Batches";
            com = new MySqlCommand(query, con);

            con.Open();
            dr = com.ExecuteReader();
            List<int> BatchIDs = new List<int>();

            while (dr.Read())
            {
                BatchIDs.Add(dr.GetInt32(0));
            }

            con.Close();

            return BatchIDs;
        }
    }
}
