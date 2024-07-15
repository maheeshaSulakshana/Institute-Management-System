using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lifeway_Institute_Management_System
{
    public partial class frmViewAttendance : Form
    {
        DbConnection Dbconnection = new DbConnection();

        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader dr;

        frmHome frmhome;
        public frmViewAttendance()
        {
            InitializeComponent();
        }

        public frmViewAttendance(frmHome frmhome)
        {
            InitializeComponent();
            this.frmhome = frmhome;
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            listbox.Items.Add("StudentID  CourseID   Date           Time");

            string date = dateTime.Value.ToShortDateString();

            int StudentID;
            int CourseID;
            String Date;
            String Time;
            String record;

            con = Dbconnection.getConnection();
            String query = "select * from attendance where date = '" + date + "'";
            com = new MySqlCommand(query, con);

            con.Open();
            dr = com.ExecuteReader();

            while (dr.Read())
            {
                StudentID = dr.GetInt32(0);
                CourseID = dr.GetInt32(1);
                Date = dr.GetString(2);
                Time = dr.GetString(3);

                record = StudentID + "               " + CourseID + "                " + Date + "                " + Time;

                listbox.Items.Add(record);
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            listbox.Items.Add("StudentID  CourseID   Date         Time");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmViewAttendance_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmhome.Show();
        }
    }
}
