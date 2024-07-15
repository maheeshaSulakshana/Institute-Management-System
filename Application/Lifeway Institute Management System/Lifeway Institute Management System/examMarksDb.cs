using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    public class examMarksDb: DbConnection
    {
        int studentID;
        int courseID;
        string exam;
        int marks;

        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader dr;

        public examMarksDb()
        {

        }

        public bool check(int studentid, int courseid, string exam)
        {
            con = getConnection();
            String query = "Select studentid from exam_marks where studentid = " + studentid + " and courseid = " + courseid + " and exam = '" + exam + "'";
            com = new MySqlCommand(query, con);

            con.Open();
            dr = com.ExecuteReader();

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

        public void insert(int studentid, int courseid, string exam, int marks)
        {
            con = getConnection();
            String query = "Insert into exam_marks values("+studentid+", "+courseid+", '"+exam+"', "+marks+")";
            com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public int getMarks(int studentid, int courseid, string exam)
        {
            con = getConnection();
            String query = "Select marks from exam_marks where studentid = " + studentid + " and courseid = " + courseid + " and exam = '" + exam + "'";
            com = new MySqlCommand(query, con);

            con.Open();
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                int marks = dr.GetInt32(0);
                con.Close();
                return marks;
            }
            else
            {
                con.Close();
                return 0;
            }
        }

        public void update(int studentID, int courseID, string exam, int marks)
        {
            con = getConnection();
            String query = "Update exam_marks set marks = " + marks + " where studentId = " + studentID + " and courseID = " + courseID + " and exam = '" + exam + "'";
            com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
