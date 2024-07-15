using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    public class Parent
    {
        private String name;
        private String address;
        private int tel;

        public Parent()
        {
            name = "";
            address = "";
            tel = 0;
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
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
