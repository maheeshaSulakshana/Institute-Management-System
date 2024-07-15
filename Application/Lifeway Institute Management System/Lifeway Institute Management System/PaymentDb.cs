using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    public class PaymentDb: DbConnection
    {
        private Payment payment;
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader dr;

        public PaymentDb()
        {

        }

        public PaymentDb(Payment payment)
        {
            this.payment = payment;
        }

        public void insert()
        {
            con = getConnection();
            String query = "Insert into Payments " +
                                        "values(" + payment.StudentID + ", " +
                                                "" + payment.CourseID + ", " +
                                                "" + payment.Billno + ", " +
                                                "'" + payment.Type + "', " +
                                                "" + payment.Amount + ", " +
                                                "'" + payment.Date + "')";
            com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public bool checkbilldetails()
        {
            if (payment.Type == "Registration")
            {
                con = getConnection();
                String query = "Select billno from payments " +
                                "where studentID = " + payment.StudentID + " and " +
                                "courseID = " + payment.CourseID + " and type = '" + payment.Type + "'";
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
            else
            {
                return true;
            }
        }

        public bool checkbillno()
        {
            con = getConnection();
            String query = "Select billno from payments where billno = " + payment.Billno + "";
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
    }
}
