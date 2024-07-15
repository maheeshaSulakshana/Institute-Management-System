using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    public class StudentCourse
    {
        private int studentID;
        private int courseID;
        private String date;

        public StudentCourse()
        {
            this.studentID = 0;
            this.courseID = 0;
            this.date = "";
        }

        public int StudentID
        {
            get { return studentID; }
            set { this.studentID = value; }
        }

        public int CourseID
        {
            get { return courseID; }
            set { this.courseID = value; }
        }

        public String Date
        {
            get { return date; }
            set { this.date = value; }
        }
    }
}
