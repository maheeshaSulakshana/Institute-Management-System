using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    public class Payment
    {
        private int studentID;
        private int courseID;
        private int billno;
        private String type;
        private double amount;
        private String date;

        public Payment()
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

        public int Billno
        {
            get { return billno; }
            set { billno = value; }
        }

        public String Type
        {
            get { return type; }
            set { type = value; }
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public String Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
