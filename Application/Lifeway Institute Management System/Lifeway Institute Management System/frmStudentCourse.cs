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
    public partial class frmStudentCourse : Form
    {
        frmHome frmHome;
        StudentCourse studentcourse;
        StudentCourseDb studentCourseDb;
        public frmStudentCourse()
        {
            InitializeComponent();
        }

        public frmStudentCourse(frmHome frmhome)
        {
            InitializeComponent();
            this.frmHome = frmhome;
        }
        public frmStudentCourse(frmHome frmhome, int studentID)
        {
            InitializeComponent();
            this.frmHome = frmhome;
            cbo_StudentID.Text = studentID.ToString();
        }

        public void clear()
        {
            cbo_StudentID.Text = "";
            cbo_CourseID.Text = "";
            txt_Date.Text = "";
        }

        private void populateStudentIDs()
        {
            cbo_StudentID.Items.Clear();

            List<int> ids = new List<int>();

            StudentDb studentdb = new StudentDb();

            ids = studentdb.getIDs();

            foreach (int id in ids)
            {
                cbo_StudentID.Items.Add(id);
            }
        }

        private void populateCourseIDs()
        {
            cbo_CourseID.Items.Clear();

            List<int> ids = new List<int>();

            CourseDb coursedb = new CourseDb();

            ids = coursedb.getIDs();

            foreach (int id in ids)
            {
                cbo_CourseID.Items.Add(id);
            }
        }

        private void frmStudentCourse_Load(object sender, EventArgs e)
        {
            populateStudentIDs();
            populateCourseIDs();
            txt_Date.Text = System.DateTime.Now.ToShortDateString();
            frmHome.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStudentCourse_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmHome.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //validations
            if (cbo_StudentID.SelectedIndex == -1)
            {
                MessageBox.Show("Must select StudentID");
                return;
            }

            if (cbo_CourseID.SelectedIndex == -1)
            {
                MessageBox.Show("Must select CourseID");
                return;
            }

            studentcourse = new StudentCourse();

            studentcourse.StudentID = Convert.ToInt32(cbo_StudentID.SelectedItem.ToString());
            studentcourse.StudentID = Convert.ToInt32(cbo_StudentID.Text);
            studentcourse.CourseID = Convert.ToInt32(cbo_CourseID.SelectedItem.ToString());
            studentcourse.Date = txt_Date.Text;

            studentCourseDb = new StudentCourseDb(studentcourse);

            if (studentCourseDb.check())
            {
                studentCourseDb.insert();

                MessageBox.Show("Student successfully registered for course\nStudent ID: " + studentcourse.StudentID + " CourseID: " + studentcourse.CourseID);
            }
            else
            {
                MessageBox.Show("There is already a record stored in the database having the same\nStudentID: " + studentcourse.StudentID + " and CourseID: " + studentcourse.CourseID);
            }

            clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
