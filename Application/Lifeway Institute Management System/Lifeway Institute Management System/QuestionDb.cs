using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    public class QuestionDb: DbConnection
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader dr;

        public List<int> getQuestionIDs()
        {
            con = getConnection();
            String query = "Select questionID from Q_A";
            com = new MySqlCommand(query, con);

            con.Open();
            dr = com.ExecuteReader();

            List<int> questionIDs  = new List<int>();
            

            while (dr.Read())
            {
                questionIDs.Add(dr.GetInt32(0));
            }

            con.Close();

            return questionIDs;
        }

        public List<String> getQuestions()
        {
            con = getConnection();
            String query = "Select question from Q_A";
            com = new MySqlCommand(query, con);

            con.Open();
            dr = com.ExecuteReader();

            List<String> questions = new List<String>();
            
            while (dr.Read())
            {
                questions.Add(dr.GetString(0));
            }

            con.Close();

            return questions;
        }

        public List<String> getAnswers()
        {
            con = getConnection();
            String query = "Select answer from Q_A";
            com = new MySqlCommand(query, con);

            con.Open();
            dr = com.ExecuteReader();
            List<String> answers = new List<String>();

            while (dr.Read())
            {
                answers.Add(dr.GetString(0));
            }

            con.Close();

            return answers;
        }

        public List<int> getStudentIDs()
        {
            con = getConnection();
            String query = "Select studentID from Q_A";
            com = new MySqlCommand(query, con);

            con.Open();
            dr = com.ExecuteReader();
            List<int> studentIDs = new List<int>();

            while (dr.Read())
            {
                studentIDs.Add(dr.GetInt32(0));
            }

            con.Close();

            return studentIDs;
        }

        public void sendAnswer(String ans, int questionId)
        {

            con = getConnection();
            String query = "Update q_a set answer = '" + ans + "' where questionid = " + questionId + "";
            com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
