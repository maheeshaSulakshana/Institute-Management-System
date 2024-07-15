using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    public interface DbOperations
    {
        public void insert();

        public void update();

        public void delete();
    }
}
