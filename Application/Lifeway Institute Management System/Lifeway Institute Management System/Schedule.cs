using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    public class Schedule
    {
        private int studentID;
        private int courseID;
        private String day1;
        private String time1;
        private String day2;
        private String time2;
        private String day3;
        private String time3;

        public Schedule()
        {

        }

        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public int CourseID
        {
            get { return courseID; }
            set { courseID = value; }
        }

        public String Day1
        {
            get { return day1; }
            set { day1 = value; }
        }

        public String Time1
        {
            get { return time1; }
            set { time1 = value; }
        }

        public String Day2
        {
            get { return day2; }
            set { day2 = value; }
        }

        public String Time2
        {
            get { return time2; }
            set { time2 = value; }
        }

        public String Day3
        {
            get { return day3; }
            set { day3 = value; }
        }

        public String Time3
        {
            get { return time3; }
            set { time3 = value; }
        }
    }
}
