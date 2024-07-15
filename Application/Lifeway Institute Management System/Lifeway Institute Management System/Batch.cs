using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    public class Batch
    {
        private String id;
        private String name;
        private String classType;
        private String ageGroup;

        public Batch()
        {
            id = "";
            name = "";
            classType = "";
            ageGroup = "";
        }

        public String ID
        {
            get { return id; }
            set { this.id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String ClassType
        {
            get { return classType; }
            set { classType = value; }
        }

        public String AgeGroup
        {
            get { return ageGroup; }
            set { ageGroup = value; }
        }
    }
}
