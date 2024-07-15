using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    public class Student
    {
        private String studentID;
        private String fname;
        private String surname;
        private String title;
        private String gender;
        private String dob;
        private int nic;
        private String address;
        private int tel;
        private String registrationDate;
        private String parent;

        public Student()
        {
            studentID = "";
            fname = "";
            surname = "";
            title = "";
            gender = "";
            dob = "";
            nic = 0;
            address = "";
            tel = 0;
            registrationDate = "";
            parent = "";
        }

        public String StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public String Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        public String Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        public String Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public String DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        public int NIC
        {
            get { return nic; }
            set { nic = value; }
        }

        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public String Registrationdate
        {
            get { return registrationDate; }
            set { registrationDate = value; }
        }

        public String Parent
        {
            get { return parent; }
            set { parent = value; }
        }
    }
}
