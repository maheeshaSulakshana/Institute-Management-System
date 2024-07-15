using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    public class Note
    {
        private String name;
        private String destination;

        public Note()
        {

        }

        public Note(String name, String destination)
        {
            this.name = name;
            this.destination = destination;
        }

        public String Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public String Destination
        {
            get { return destination; }
            set { this.destination = value; }
        }
    }
}
