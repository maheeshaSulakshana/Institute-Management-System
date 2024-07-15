using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeway_Institute_Management_System
{
    public class NotesDb : DbConnection
    {
        private Note note;
        MySqlConnection con;
        MySqlCommand com;

        public NotesDb(Note note)
        {
            this.note = note;
        }

        public void insert()
        {
            con = getConnection();
            String query = "Insert into Notes values('" + note.Name + "', '" + note.Destination + "')";
            com = new MySqlCommand(query, con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
