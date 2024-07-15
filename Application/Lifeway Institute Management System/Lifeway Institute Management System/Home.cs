using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lifeway_Institute_Management_System
{
    public partial class frmHome : Form
    {
        frmLogin frmlogin;
        public frmHome()
        {
            InitializeComponent();
        }

        public frmHome(frmLogin frmlogin)
        {
            InitializeComponent();
            this.frmlogin = frmlogin;
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudent frmStudent = new frmStudent(this);
            frmStudent.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManageLecturer_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLecturer frmLecturer = new frmLecturer(this);
            frmLecturer.Show();
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmlogin.Show();
        }

        private void btnManageCourses_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCourse frmcourse = new frmCourse(this);
            frmcourse.Show();
        }

        private void btnManageBatches_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBatch frmbatch = new frmBatch(this);
            frmbatch.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPayment frmpayment = new frmPayment(this);
            frmpayment.Show();
        }

        private void btnStudentCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentCourse frmstudentcourse = new frmStudentCourse(this);
            frmstudentcourse.Show();
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNotes frmnotes = new frmNotes(this);
            frmnotes.Show();
        }

        private void btnManageSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSchedule frmSchedule = new frmSchedule(this);
            frmSchedule.Show();
        }

        private void btnAnswerQuestions_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnswers frmAnswers = new frmAnswers(this);
            frmAnswers.Show();
        }

        private void btnExamMarks_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmexamMarks frmexammarks = new frmexamMarks(this);
            frmexammarks.Show();
        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewSchedule frmViewSchedule = new frmViewSchedule(this);
            frmViewSchedule.Show();
        }

        private void btnViewAttendance_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewAttendance frmviewAttendance = new frmViewAttendance(this);
            frmviewAttendance.Show();
        }
    }
}
