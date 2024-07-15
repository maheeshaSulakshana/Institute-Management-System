using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    public class Lecturer
    {
        private int Id;
        private String name;
        private String title;
        private String dob;
        private int nic;
        private String address;
        private int tel;

        public Lecturer()
        {

        }

        public int ID
        {
            get { return Id; }
            set { this.Id = value; }
        }

        public String Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public String Title
        {
            get { return title; }
            set { this.title = value; }
        }

        public String DOB {
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
            set { this.tel = value; }
        }
    }
}
