using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    public class CourseDb: DbConnection, DbOperations
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader dr;
        private Course course;

        public CourseDb()
        {

        }

        public CourseDb(Course course)
        {
            this.course = course;
        }

        public void insert()
        {
            con = getConnection();
            String query = "insert into Courses(name, duration, fee, batchID, lecturerID)" +
                                                " values('" + course.Name + "', " +
                                                         "" + course.Duration + ", " +
                                                         "" + course.Fee + ", " +
                                                         "" + course.BatchID + ", " +
                                                         "" + course.LecturerID + ")";
            com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void update()
        {
            con = getConnection();
            String query = "update courses set duration = " + course.Duration + ", fee = "+course.Fee+" where courseID = " + course.CourseID + "";
            com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void delete()
        {
            con = getConnection();
            String query = "delete from Courses where CourseID = " + course.CourseID + "";
            com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        //get a list of course IDs
        public List<int> getIDs()
        {
            con = getConnection();
            String query = "Select CourseID from Courses";
            com = new MySqlCommand(query, con);

            con.Open();
            dr = com.ExecuteReader();
            List<int> CourseIDs = new List<int>();

            while (dr.Read())
            {
                CourseIDs.Add(dr.GetInt32(0));
            }

            con.Close();

            return CourseIDs;
        }

        //get course by ID
        public Course getCourse(int ID)
        {
            con = getConnection();
            String query = "Select * from courses where courseID = " + ID + "";
            com = new MySqlCommand(query, con);

            con.Open();
            dr = com.ExecuteReader();
            Course course = new Course();

            while (dr.Read())
            {
                course.CourseID = dr.GetInt32(0);
                course.Name = dr.GetString(1);
                course.Duration = dr.GetInt32(2);
                course.Fee = dr.GetDouble(3);
                course.BatchID = dr.GetInt32(4);
                course.LecturerID = dr.GetInt32(5);
            }

            con.Close();
            return course;
        }
    }
}
