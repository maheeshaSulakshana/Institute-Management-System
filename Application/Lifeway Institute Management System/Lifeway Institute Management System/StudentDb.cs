using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    internal class StudentDb : DbConnection, DbOperations
    {
        Student student = new Student();
        MySqlConnection con;
        MySqlCommand com;

        public StudentDb()
        {

        }
        public StudentDb(Student student)
        {
            this.student = student;
        }

        public void insert()
        {
            con = getConnection();
            String query = "Insert into Students(Fname, Surname, Title, Gender, DOB, NIC, Address, Tel, RegistrationDate, Parent) " +
                                                                     "values( '"+student.Fname+"'," + 
                                                                     "'"+student.Surname+"'," +
                                                                     "'"+student.Title+"'," +
                                                                     "'"+student.Gender+"'," +
                                                                     "'"+student.DOB+"'," +
                                                                     ""+student.NIC+"," +
                                                                     "'"+student.Address+"'," +
                                                                     ""+student.Tel+"," +
                                                                     "'"+student.Registrationdate+"'," +
                                                                     "'"+student.Parent+"')";
            com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void update()
        {
            con = getConnection();
            String query = "Update Students set Address = '" + student.Address + "', Tel = " + student.Tel + " " +
                                                "where StudentID = "+student.StudentID+"";
            com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void delete()
        {
            con = getConnection();
            String query = "Delete from students where StudentID = '" + student.StudentID + "'";
            com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        //gets the most recent studentID
        public int getID()
        {
            try
            {
                int ID = 0;

                con = getConnection();
                String query = "Select max(StudentID) from Students";
                com = new MySqlCommand(query, con);

                con.Open();
                MySqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    ID = dr.GetInt32(0);
                }

                con.Close();
                return ID;
            }
            catch (Exception ex)
            {
                showErrorMessage(ex, this);
                con.Close();
                return 0;
            }
        }

        //gets a list of stored IDs
        public List<int> getIDs()
        {
            con = getConnection();
            String query = "Select StudentID from Students";
            com = new MySqlCommand(query, con);

            con.Open();
            List<int> IDs = new List<int>();

            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                IDs.Add(dr.GetInt32(0));
            }
            con.Close();
            return IDs;
        }

        //gets a list of stored First Names
        public List<String> getFNames()
        {
            con = getConnection();
            String query = "Select Fname from Students";
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

        //gets a list of stored Last Names
        public List<String> getSNames()
        {
            con = getConnection();
            String query = "Select Surname from Students";
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

        //gets details of student whose ID is passed
        public Student getStudent(int ID)
        {
            Student student = new Student();

            con = getConnection();
            String query = "Select * from Students where StudentID = " + ID + "";
            com = new MySqlCommand(query, con);

            con.Open();
            MySqlDataReader dr = com.ExecuteReader();

            dr.Read();

            student.StudentID = dr.GetString(0);
            student.Fname = dr.GetString(1);
            student.Surname = dr.GetString(2);
            student.Title = dr.GetString(3);
            student.Gender = dr.GetString(4);
            student.DOB = dr.GetString(5);
            student.NIC = dr.GetInt32(6);
            student.Address = dr.GetString(7);
            student.Tel = dr.GetInt32(8);
            student.Registrationdate = dr.GetString(9);
            student.Parent = dr.GetString(10);

            con.Close();

            return student;
        }

        //gets detials of student whose first name and last name is passed
        public Student getStudent(String fname, String sname)
        {
            Student student = new Student();

            con = getConnection();
            String query = "Select * from Students where Fname = '"+fname+"' and Surname = '"+sname+"'";
            com = new MySqlCommand(query, con);

            con.Open();
            MySqlDataReader dr = com.ExecuteReader();

            dr.Read();

            student.StudentID = dr.GetString(0);
            student.Fname = dr.GetString(1);
            student.Surname = dr.GetString(2);
            student.Title = dr.GetString(3);
            student.Gender = dr.GetString(4);
            student.DOB = dr.GetString(5);
            student.NIC = dr.GetInt32(6);
            student.Address = dr.GetString(7);
            student.Tel = dr.GetInt32(8);
            student.Registrationdate = dr.GetString(9);
            student.Parent = dr.GetString(10);

            con.Close();

            return student;
        }
    }
}
