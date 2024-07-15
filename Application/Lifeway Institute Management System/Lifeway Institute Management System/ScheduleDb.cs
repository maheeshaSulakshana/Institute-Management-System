using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    public class ScheduleDb: DbConnection
    {
        Schedule schedule;
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader dr;

        public ScheduleDb()
        {

        }
        public ScheduleDb(Schedule schedule)
        {
            this.schedule = schedule;
        }

        public void insert(int a1, int a2, int a3)
        {
            con = getConnection();
            String query = "insert into schedule " +
                                        "values(" + schedule.StudentID + ", " + schedule.CourseID + ", " +
                                                "'" + schedule.Day1 + "', '" + schedule.Time1 + "'," +
                                                "'" + schedule.Day2 + "', '" + schedule.Time2 + "'," +
                                                "'" + schedule.Day3 + "', '" + schedule.Time3 + "')";
            com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();

            a1--;
            a2--;
            a3--;
            updateAvailability(a1, schedule.Day1, schedule.Time1);
            updateAvailability(a2, schedule.Day2, schedule.Time2);
            updateAvailability(a3, schedule.Day3, schedule.Time3);
        }

        public void update(Schedule old_schedule, Schedule new_schedule , int o_a1, int o_a2, int o_a3, int a1, int a2, int a3)
        {
            if (old_schedule.Day1 != new_schedule.Day1 || old_schedule.Time1 != new_schedule.Time1)
            {
                o_a1++;
                updateAvailability(o_a1, old_schedule.Day1, old_schedule.Time1);
                a1--;
                updateAvailability(a1, new_schedule.Day1, new_schedule.Time1);
            }

            if (old_schedule.Day2 != new_schedule.Day2 || old_schedule.Time2 != new_schedule.Time2)
            {
                o_a2++;
                updateAvailability(o_a2, old_schedule.Day2, old_schedule.Time2);
                a2--;
                updateAvailability(a2, new_schedule.Day2, new_schedule.Time2);
            }

            if (old_schedule.Day3 != new_schedule.Day3 || old_schedule.Time3 != new_schedule.Time3)
            {
                o_a3++;
                updateAvailability(o_a3, old_schedule.Day3, old_schedule.Time3);
                a3--;
                updateAvailability(a3, new_schedule.Day3, new_schedule.Time3);
            }

            con = getConnection();
            String query = "Update schedule set Day1 = '" + new_schedule.Day1 + "', Time1 = '" + new_schedule.Time1 + "'," +
                                               "Day2 = '" + new_schedule.Day2 + "', Time2 = '" + new_schedule.Time2 + "'," +
                                               "Day3 = '" + new_schedule.Day3 + "', Time3 = '" + new_schedule.Time3 + "'" +
                                               "where studentID = " + new_schedule.StudentID + " and courseID = " + new_schedule.CourseID + "";
            com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void delete(int a1, int a2, int a3)
        {
            con = getConnection();
            String query = "Delete from Schedule where studentID = " + schedule.StudentID + " and courseID = " + schedule.CourseID + "";
            com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();

            a1++;
            a2++;
            a3++;
            updateAvailability(a1, schedule.Day1, schedule.Time1);
            updateAvailability(a2, schedule.Day2, schedule.Time2);
            updateAvailability(a3, schedule.Day3, schedule.Time3);
        }

        public void updateAvailability(int a, String d, String t)
        {
            con = getConnection();
            String query = "Update Availability set Availableseats=" + a + " " +
                                                    "where Date = '" + d + "' and Time = '" + t + "'";
            com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public bool check()
        {
            con = getConnection();
            String query = "Select studentID from schedule where studentID = " + schedule.StudentID + " and courseID = " + schedule.CourseID + "";
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

        public int getAvailability(String date, String time)
        {
            con = getConnection();
            String query = "Select AvailableSeats from availability where date = '" + date + "' and time = '" + time + "'";
            com = new MySqlCommand(query, con);

            con.Open();
            dr = com.ExecuteReader();

            dr.Read();

            int availability = dr.GetInt32(0);

            con.Close();

            return availability;
        }

        public Schedule getSchedule(int studentID, int courseID)
        {
            con = getConnection();
            String query = "Select * from schedule where " +
                                          "studentID = " + studentID + " and courseID = " + courseID + "";
            com = new MySqlCommand(query, con);

            con.Open();
            dr = com.ExecuteReader();
            schedule = new Schedule();

            if (dr.Read())
            {
                schedule.StudentID = dr.GetInt32(0);
                schedule.CourseID = dr.GetInt32(1);
                schedule.Day1 = dr.GetString(2);
                schedule.Time1 = dr.GetString(3);
                schedule.Day2 = dr.GetString(4);
                schedule.Time2 = dr.GetString(5);
                schedule.Day3 = dr.GetString(6);
                schedule.Time3 = dr.GetString(7);

                con.Close();
                return schedule;
            }
            else
            {
                con.Close();
                return null;
            }
        }
    }
}
