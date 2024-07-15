using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    public class Course
    {
        private int courseID;
        private String name;
        private int duration;
        private double fee;
        private int batchID;
        private int lecturerID;

        public Course()
        {

        }

        public int CourseID
        {
            get { return courseID; }
            set { courseID = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public double Fee
        {
            get { return fee; }
            set { fee = value; }
        }

        public int BatchID
        {
            get { return batchID; }
            set { batchID = value; }
        }

        public int LecturerID
        {
            get { return lecturerID; }
            set { lecturerID = value; }
        }
    }
}
