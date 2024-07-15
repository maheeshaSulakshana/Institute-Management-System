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
    public partial class frmViewSchedule : Form
    {
        DbConnection dbconnection = new DbConnection();

        String day;
        String time;

        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader dr;

        frmHome frmhome;

        public frmViewSchedule()
        {
            InitializeComponent();
        }

        public frmViewSchedule(frmHome frmhome)
        {
            InitializeComponent();
            this.frmhome = frmhome;
        }

        private void btnGetSchedule_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            listbox.Items.Add("StudentID          CourseID           Day            Time");

            //validations
            if (cboDate.SelectedIndex == -1)
            {
                MessageBox.Show("Must select Day");
                return;
            }

            if (cboTime.SelectedIndex == -1)
            {
                MessageBox.Show("Must select Time");
                return;
            }

            day = cboDate.SelectedItem.ToString();
            time = cboTime.SelectedItem.ToString();

            con = dbconnection.getConnection();
            String query = "select * from schedule where day1 = '" + day + "' and time1 = '" + time + "' " +
                                                     "or day2 = '" + day + "' and time2 = '" + time + "'" +
                                                     "or day3 = '" + day + "' and time3 = '" + time + "'";
            com = new MySqlCommand(query, con);

            con.Open();
            dr = com.ExecuteReader();

            while (dr.Read())
            {
                int studentID = dr.GetInt32(0);
                int courseID = dr.GetInt32(1);

                string record = studentID + "               " + courseID + "               " + day + "               " + time;

                listbox.Items.Add(record);
            }

            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmViewSchedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmhome.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            listbox.Items.Add("StudentID    CourseID    Day     Time");
        }
    }
}
