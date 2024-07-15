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
    public partial class frmSchedule : Form
    {
        private String type;

        Schedule old_schedule;
        Schedule schedule;
        ScheduleDb scheduleDb = new ScheduleDb();

        StudentDb studentDb;
        StudentCourseDb studentcourseDb;

        private String day1;
        private String day2;
        private String day3;

        private int old_a1;
        private int old_a2;
        private int old_a3;

        private int availability1;
        private int availability2;
        private int availability3;

        frmHome frmhome;
        public frmSchedule()
        {
            InitializeComponent();
        }

        public frmSchedule(frmHome frmhome)
        {
            InitializeComponent();
            this.frmhome = frmhome;
        }

        public void clear()
        {
            cboStudentID.SelectedIndex = -1;
            cboStudentID.Text = "";
            cboCourseID.SelectedIndex = -1;
            cboCourseID.Text = "";
            cboDay1.SelectedIndex = -1;
            cboDay1.Text = "";
            cboTime1.SelectedIndex = -1;
            cboTime1.Text = "";
            cboDay2.SelectedIndex = -1;
            cboDay2.Text = "";
            cboTime2.SelectedIndex = -1;
            cboTime2.Text = "";
            cboDay3.SelectedIndex = -1;
            cboDay3.Text = "";
            cboTime3.SelectedIndex = -1;
            cboTime3.Text = "";

            lblAvailability1.Text = "Availability:";
            lblAvailability2.Text = "Availability:";
            lblAvailability3.Text = "Availability:";

            switch (type)
            {
                case "insert":
                    setInsertEnvironment();
                    break;
                case "update":
                    setUpdateEnvironment();
                    break;
                case "delete":
                    setDeleteEnvironment();
                    break;
                case "select":
                    setSelectEnvironment();
                    break;
            }
        }

        public void populateStudentIDs()
        {
            cboStudentID.Items.Clear();

            studentDb = new StudentDb();

            List<int> IDs = studentDb.getIDs();

            foreach (int ID in IDs)
            {
                cboStudentID.Items.Add(ID);
            }
        }

        public void populateCourseIDs(int studentID)
        {
            cboCourseID.Items.Clear();

            studentcourseDb = new StudentCourseDb();

            List<int> IDs = studentcourseDb.getCourseIDs(studentID);

            foreach (int ID in IDs)
            {
                cboCourseID.Items.Add(ID);
            }
        }

        public void setInsertEnvironment()
        {
            cboStudentID.Enabled = true;
            cboCourseID.Enabled = true;
            cboDay1.Enabled = true;
            cboTime1.Enabled = true;
            cboDay2.Enabled = true;
            cboTime2.Enabled = true;
            cboDay3.Enabled = true;
            cboTime3.Enabled = true;

            btnSubmit.Visible = true;
            btnGetDetails.Visible = false;

            populateStudentIDs();
        }

        public void setUpdateEnvironment()
        {
            cboStudentID.Enabled = true;
            cboCourseID.Enabled = true;
            cboDay1.Enabled = false;
            cboTime1.Enabled = false;
            cboDay2.Enabled = false;
            cboTime2.Enabled = false;
            cboDay3.Enabled = false;
            cboTime3.Enabled = false;

            btnSubmit.Visible = false;
            btnGetDetails.Visible = true;

            populateStudentIDs();
        }

        public void setDeleteEnvironment()
        {
            cboStudentID.Enabled = true;
            cboCourseID.Enabled = true;
            cboDay1.Enabled = false;
            cboTime1.Enabled = false;
            cboDay2.Enabled = false;
            cboTime2.Enabled = false;
            cboDay3.Enabled = false;
            cboTime3.Enabled = false;

            btnSubmit.Visible = false;
            btnGetDetails.Visible = true;

            populateStudentIDs();
        }

        public void setSelectEnvironment()
        {
            cboStudentID.Enabled = true;
            cboCourseID.Enabled = true;
            cboDay1.Enabled = false;
            cboTime1.Enabled = false;
            cboDay2.Enabled = false;
            cboTime2.Enabled = false;
            cboDay3.Enabled = false;
            cboTime3.Enabled = false;

            btnSubmit.Visible = false;
            btnGetDetails.Visible = true;

            populateStudentIDs();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            type = "insert";
            clear();
        }

        private void cboStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStudentID.SelectedIndex != -1)
            {
                int ID = Convert.ToInt32(cboStudentID.SelectedItem.ToString());

                populateCourseIDs(ID);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (type == "insert")
            {
                //validations
                if (cboStudentID.SelectedIndex == -1)
                {
                    MessageBox.Show("Must select student ID");
                    return;
                }

                if (cboCourseID.SelectedIndex == -1)
                {
                    MessageBox.Show("Must select course ID");
                    return;
                }

                if (cboDay1.SelectedIndex == -1)
                {
                    MessageBox.Show("Must select Day 1");
                    return;
                }

                if (cboTime1.SelectedIndex == -1)
                {
                    MessageBox.Show("Must select Time 1");
                    return;
                }

                if (cboDay2.SelectedIndex == -1)
                {
                    MessageBox.Show("Must select Day 2");
                    return;
                }

                if (cboTime2.SelectedIndex == -1)
                {
                    MessageBox.Show("Must select Time 2");
                    return;
                }

                if (cboDay3.SelectedIndex == -1)
                {
                    MessageBox.Show("Must select Day 3");
                    return;
                }

                if (cboTime3.SelectedIndex == -1)
                {
                    MessageBox.Show("Must select Time 3");
                    return;
                }

                schedule = new Schedule();

                schedule.StudentID = Convert.ToInt32(cboStudentID.SelectedItem.ToString());
                schedule.CourseID = Convert.ToInt32(cboCourseID.SelectedItem.ToString());
                schedule.Day1 = cboDay1.SelectedItem.ToString();
                schedule.Time1 = cboTime1.SelectedItem.ToString();
                schedule.Day2 = cboDay2.SelectedItem.ToString();
                schedule.Time2 = cboTime2.SelectedItem.ToString();
                schedule.Day3 = cboDay3.SelectedItem.ToString();
                schedule.Time3 = cboTime3.SelectedItem.ToString();

                scheduleDb = new ScheduleDb(schedule);

                if (scheduleDb.check() == true)
                {
                    scheduleDb.insert(availability1, availability2, availability3);

                    MessageBox.Show("Student schedule successfully added");
                }
                else
                {
                    MessageBox.Show("There is already a schedule in the database for,\nStudentID: " + schedule.StudentID + " CourseID: " + schedule.CourseID);
                }
            }
            else if (type == "update")
            {
                //validations
                if (cboDay1.Text == "")
                {
                    MessageBox.Show("Must select Day 1");
                    return;
                }

                if (cboTime1.Text == "")
                {
                    MessageBox.Show("Must select Time 1");
                    return;
                }

                if (cboDay2.Text == "")
                {
                    MessageBox.Show("Must select Day 2");
                    return;
                }

                if (cboTime2.Text == "")
                {
                    MessageBox.Show("Must select Time 2");
                    return;
                }

                if (cboDay3.Text == "")
                {
                    MessageBox.Show("Must select Day 3");
                    return;
                }

                if (cboTime3.Text == "")
                {
                    MessageBox.Show("Must select Time 3");
                    return;
                }

                schedule = new Schedule();

                schedule.StudentID = Convert.ToInt32(cboStudentID.Text);
                schedule.CourseID = Convert.ToInt32(cboCourseID.Text);
                schedule.Day1 = cboDay1.Text;
                schedule.Time1 = cboTime1.Text;
                schedule.Day2 = cboDay2.Text;
                schedule.Time2 = cboTime2.Text;
                schedule.Day3 = cboDay3.Text;
                schedule.Time3 = cboTime3.Text;

                scheduleDb = new ScheduleDb();

                if (MessageBox.Show("Do you really want to update the record corresponding to\n Student ID: " + schedule.StudentID + " Course ID: " + schedule.CourseID, "Update Confirmation Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    scheduleDb.update(old_schedule, schedule,
                                      old_a1, old_a2, old_a3, availability1, availability2, availability3);
                    MessageBox.Show("Record successfully updated");
                }
                else
                {
                    MessageBox.Show("Schedule not updated");
                }
            }
            else if (type == "delete")
            {
                if (MessageBox.Show("Do you really want to delete the record corresponding to\n Student ID: " + old_schedule.StudentID + " Course ID: " + old_schedule.CourseID, "Delete Confirmation Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    scheduleDb = new ScheduleDb(old_schedule);

                    scheduleDb.delete(availability1, availability2, availability3);

                    MessageBox.Show("Record successfully deleted");
                }
                else
                {
                    MessageBox.Show("Schedule not deleted");
                }
            }

            clear();
        }

        private void cboTime1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDay1.SelectedIndex != -1 && cboTime1.SelectedIndex != -1)
            {
                String time = cboTime1.SelectedItem.ToString();

                availability1 = scheduleDb.getAvailability(day1, time);

                lblAvailability1.Text = "Availability:" + availability1;

                if (availability1 == 0)
                {
                    MessageBox.Show("There are no seats available for " + day1 + " at " + time);
                    cboDay1.SelectedIndex = -1;
                    cboTime1.SelectedIndex = -1;
                    cboDay1.Text = "";
                    cboTime1.Text = "";
                    lblAvailability1.Text = "Availability:";
                }
            }
        }

        private void cboTime2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDay2.SelectedIndex != -1 && cboTime2.SelectedIndex != -1)
            {
                string time = cboTime2.SelectedItem.ToString();

                availability2 = scheduleDb.getAvailability(day2, time);

                lblAvailability2.Text = "Availability:" + availability2;

                if (availability2 == 0)
                {
                    MessageBox.Show("There are no seats available for " + day2 + " at " + time);
                    cboDay2.SelectedIndex = -1;
                    cboTime2.SelectedIndex = -1;
                    cboDay2.Text = "";
                    cboTime2.Text = "";
                    lblAvailability2.Text = "Availability:";
                }
            }
        }

        private void cboTime3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDay3.SelectedIndex != -1 && cboTime3.SelectedIndex != -1)
            {
                string time = cboTime3.SelectedItem.ToString();

                availability3 = scheduleDb.getAvailability(day3, time);

                lblAvailability3.Text = "Availability:" + availability3;

                if (availability3 == 0)
                {
                    MessageBox.Show("There are no seats available for " + day3 + " at " + time);
                    cboDay3.SelectedIndex = -1;
                    cboTime3.SelectedIndex = -1;
                    cboDay3.Text = "";
                    cboTime3.Text = "";
                    lblAvailability3.Text = "Availability:";
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSchedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmhome.Show();
        }

        private void cboDay1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDay1.SelectedIndex != -1)
            {
                day1 = cboDay1.SelectedItem.ToString();

                if (day1 == day2 || day1 == day3)
                {
                    MessageBox.Show("Cannot select same day");
                    cboDay1.SelectedIndex = -1;
                    cboDay1.Text = "";
                    return;
                }
            }
        }

        private void cboDay2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDay2.SelectedIndex != -1)
            {
                day2 = cboDay2.SelectedItem.ToString();

                if (day2 == day1 || day2 == day3)
                {
                    MessageBox.Show("Cannot select same day");
                    cboDay2.SelectedIndex = -1;
                    cboDay2.Text = "";
                    return;
                }
            }
        }

        private void cboDay3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDay3.SelectedIndex != -1)
            {
                day3 = cboDay3.SelectedItem.ToString();

                if (day3 == day1 || day3 == day2)
                {
                    MessageBox.Show("Cannot select same day");
                    cboDay3.SelectedIndex = -1;
                    cboDay3.Text = "";
                    return;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            type = "update";
            clear();
        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            if (cboStudentID.SelectedIndex == -1)
            {
                MessageBox.Show("Must select StudentID");
                return;
            }

            if (cboCourseID.SelectedIndex == -1)
            {
                MessageBox.Show("Must select CourseID");
                return;
            }

            int studentID = Convert.ToInt32(cboStudentID.SelectedItem.ToString());
            int courseID = Convert.ToInt32(cboCourseID.SelectedItem.ToString());

            old_schedule = scheduleDb.getSchedule(studentID, courseID);

            if (old_schedule != null)
            {
                cboDay1.SelectedItem = old_schedule.Day1;
                cboDay2.SelectedItem = old_schedule.Day2;
                cboDay3.SelectedItem = old_schedule.Day3;
                cboTime1.SelectedItem = old_schedule.Time1;
                cboTime2.SelectedItem = old_schedule.Time2;
                cboTime3.SelectedItem = old_schedule.Time3;

                cboStudentID.Enabled = false;
                cboCourseID.Enabled = false;

                if (type == "update")
                {
                    cboDay1.Enabled = true;
                    cboDay2.Enabled = true;
                    cboDay3.Enabled = true;
                    cboTime1.Enabled = true;
                    cboTime2.Enabled = true;
                    cboTime3.Enabled = true;

                    old_a1 = availability1;
                    old_a2 = availability2;
                    old_a3 = availability3;
                }

                if (type == "update" || type == "delete")
                {
                    btnGetDetails.Visible = false;
                    btnSubmit.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Schedule doesn't exist for StudentID: " + studentID + " and CourseID: " + courseID);
                clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            type = "delete";
            clear();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            type = "select";
            clear();
        }
    }
}
