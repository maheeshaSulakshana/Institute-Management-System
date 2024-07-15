using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    public class LecturerDb: DbConnection, DbOperations
    {
        Lecturer lecturer;
        MySqlConnection con;
        MySqlCommand com;

        public LecturerDb()
        {

        }

        public LecturerDb(Lecturer lecturer)
        {
            this.lecturer = lecturer;
        }

        public void insert()
        {
            con = getConnection();
            String query = "insert into Lecturers(Title, Name, dob, NIC, Address, Tel) " +
                                                         "values ('" + lecturer.Title + "'," +
                                                         "'" + lecturer.Name + "'," +
                                                         "'" + lecturer.DOB + "'," +
                                                         "" + lecturer.NIC + "," +
                                                         "'" + lecturer.Address + "'," +
                                                         "" + lecturer.Tel + ")";
            com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void update()
        {
            con = getConnection();
            String query = "update Lecturers set Address = '" + lecturer.Address + "', Tel = " + lecturer.Tel + " " +
                                                                        "where LecturerID = '" + lecturer.ID + "'"; ;
            com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void delete()
        {
            con = getConnection();
            String query = "delete from lecturers where lecturerID = '" + lecturer.ID + "'";
            com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        //checks if there is already a NIC stored like the newly enetered NIC
        public bool check(int NIC)
        {
            con = getConnection();
            String query = "Select NIC from lecturers where NIC = " + NIC + "";
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
        //gets the most recently added lecturer's ID
        public int getID()
        {
            con = getConnection();
            String query = "Select max(lecturerID) from Lecturers";
            com = new MySqlCommand(query, con);

            con.Open();
            MySqlDataReader dr = com.ExecuteReader();

            dr.Read();

            int id = dr.GetInt32(0);

            con.Close();

            return id;
        }
        //gets a list of IDs that is in the database
        public List<int> getIDs()
        {
            con = getConnection();
            String query = "Select LecturerID from Lecturers";
            com = new MySqlCommand(query, con);

            con.Open();
            MySqlDataReader dr = com.ExecuteReader();
            List<int> ids = new List<int>();

            while (dr.Read())
            {
                ids.Add(dr.GetInt32(0));
            }

            con.Close();

            return ids;
        }
        //gets a list of lecturer names that is already stored
        public List<String> getNames()
        {
            con = getConnection();
            String query = "Select name from lecturers";
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

        //gets lecturer details for the given lecturerID
        public Lecturer getLecturer(int ID)
        {
            con = getConnection();
            String query = "Select * from Lecturers where LecturerID = " + ID + "";
            com = new MySqlCommand(query, con);

            con.Open();
            MySqlDataReader dr = com.ExecuteReader();

            Lecturer lecturer = new Lecturer();

            dr.Read();

            lecturer.ID = dr.GetInt32(0);
            lecturer.Title = dr.GetString(1);
            lecturer.Name = dr.GetString(2);
            lecturer.DOB = dr.GetString(3);
            lecturer.NIC = dr.GetInt32(4);
            lecturer.Address = dr.GetString(5);
            lecturer.Tel = dr.GetInt32(6);

            con.Close();
            return lecturer;
        }

        //gets lecturer details for the given name
        public Lecturer getLecturer(String name)
        {
            con = getConnection();
            String query = "Select * from Lecturers where Name = '" + name + "'";
            com = new MySqlCommand(query, con);

            con.Open();
            MySqlDataReader dr = com.ExecuteReader();

            dr.Read();

            lecturer = new Lecturer();

            lecturer.ID = dr.GetInt32(0);
            lecturer.Title = dr.GetString(1);
            lecturer.Name = dr.GetString(2);
            lecturer.DOB = dr.GetString(3);
            lecturer.NIC = dr.GetInt32(4);
            lecturer.Address = dr.GetString(5);
            lecturer.Tel = dr.GetInt32(6);

            con.Close();

            return lecturer;
        }
    }
}
