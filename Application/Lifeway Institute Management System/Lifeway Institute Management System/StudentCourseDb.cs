using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    public class StudentCourseDb: DbConnection
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader dr;
        StudentCourse studentCourse;

        public StudentCourseDb()
        {

        }

        public StudentCourseDb(StudentCourse studentcourse)
        {
            this.studentCourse = studentcourse;
        }

        public void insert()
        {
            con = getConnection();
            String query = "Insert into student_courses values(" + studentCourse.StudentID + ", " + studentCourse.CourseID + ", '" + studentCourse.Date + "')";
            com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public bool check()
        {
            con = getConnection();
            String query = "Select StudentID from student_courses where StudentID = " + studentCourse.StudentID + " and CourseID = " + studentCourse.CourseID + "";
            com = new MySqlCommand(query, con);

            con.Open();
            MySqlDataReader dr = com.ExecuteReader();

            if (!dr.HasRows)
            {
                con.Close();
                return true;
            }

            con.Close();
            return false;
        }

        public List<int> getCourseIDs(int studentID)
        {
            con = getConnection();
            String query = "Select courseID from student_courses where studentID = " + studentID + "";
            com = new MySqlCommand(query, con);

            con.Open();
            dr = com.ExecuteReader();
            List<int> IDs = new List<int>();

            while (dr.Read())
            {
                IDs.Add(dr.GetInt32(0));
            }

            con.Close();
            return IDs;
        }

        public List<int> getStudentIDs()
        {
            con = getConnection();
            String query = "select distinct studentID from student_courses";
            com = new MySqlCommand(query, con);

            con.Open();
            List<int> studentIDs = new List<int>();
            dr = com.ExecuteReader();

            while (dr.Read())
            {
                studentIDs.Add(dr.GetInt32(0));
            }

            con.Close();

            return studentIDs;
        }
    }
}
