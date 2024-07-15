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
    public partial class frmexamMarks : Form
    {
        String type;

        int studentID;
        int courseID;
        string exam;
        int marks;

        frmHome frmhome;
        StudentCourseDb studentcourseDb;
        examMarksDb examMarksDb = new examMarksDb();
        public frmexamMarks()
        {
            InitializeComponent();
        }

        public frmexamMarks(frmHome frmhome)
        {
            InitializeComponent();
            this.frmhome = frmhome;
        }

        public void clear()
        {
            cboStudentID.Text = "";
            cboStudentID.SelectedIndex = -1;
            cboCourseID.Text = "";
            cboCourseID.SelectedIndex = -1;
            cboExam.Text = "";
            cboExam.SelectedIndex = -1;
            txtMarks.Text = "";

            switch (type)
            {
                case "insert":
                    setInsertEnvironment();
                    break;
                case "update":
                    setUpdateEnvironment();
                    break;
                case "select":
                    setSelectEnvironment();
                    break;
            }
        }

        public void setInsertEnvironment()
        {
            cboStudentID.Enabled = true;
            cboCourseID.Enabled = true;
            cboExam.Enabled = true;
            txtMarks.Enabled = true;

            btnSubmit.Visible = true;
            btnGetDetails.Visible = false;
            populateStudentIDs();
        }

        public void setUpdateEnvironment()
        {
            cboStudentID.Enabled = true;
            cboCourseID.Enabled = true;
            cboExam.Enabled = true;
            txtMarks.Enabled = false;

            btnSubmit.Visible = false;
            btnGetDetails.Visible = false;

            populateStudentIDs();
        }

        public void setSelectEnvironment()
        {
            cboStudentID.Enabled = true;
            cboCourseID.Enabled = true;
            cboExam.Enabled = true;
            txtMarks.Enabled = false;

            btnSubmit.Visible = false;
            btnGetDetails.Visible = false;
            populateStudentIDs();
        }

        public void populateStudentIDs()
        {
            cboStudentID.Items.Clear();

            studentcourseDb = new StudentCourseDb();

            List<int> studentIDs = studentcourseDb.getStudentIDs();

            foreach (int ID in studentIDs)
            {
                cboStudentID.Items.Add(ID);
            }
        }

        public void populateCourseIDs()
        {
            cboCourseID.Items.Clear();

            int studentID = Convert.ToInt32(cboStudentID.SelectedItem.ToString());

            studentcourseDb = new StudentCourseDb();

            List<int> courseIDs = studentcourseDb.getCourseIDs(studentID);

            foreach (int Id in courseIDs)
            {
                cboCourseID.Items.Add(Id);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            type = "insert";
            clear();
        }

        private void cboCourseID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStudentID.SelectedIndex != -1)
            {
                populateCourseIDs();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (type == "insert")
            {
                //validations
                if (cboStudentID.SelectedIndex == -1)
                {
                    MessageBox.Show("Must select Student ID");
                    return;
                }

                if (cboCourseID.SelectedIndex == -1)
                {
                    MessageBox.Show("Must select Course ID");
                    return;
                }

                if (cboExam.SelectedIndex == -1)
                {
                    MessageBox.Show("Must select Exam Type");
                    return;
                }

                if (txtMarks.Text == "")
                {
                    MessageBox.Show("Must enter exam marks");
                    return;
                }

                int marks;

                if (int.TryParse(txtMarks.Text, out marks) == false)
                {
                    MessageBox.Show("Marks must be numeric");
                    return;
                }

                if (marks < 0 || marks > 100)
                {
                    MessageBox.Show("Marks must be between 0 and 100");
                    return;
                }

                studentID = Convert.ToInt32(cboStudentID.SelectedItem.ToString());
                courseID = Convert.ToInt32(cboCourseID.SelectedItem.ToString());
                exam = cboExam.SelectedItem.ToString();
                marks = Convert.ToInt32(txtMarks.Text);

                if (examMarksDb.check(studentID, courseID, exam))
                {
                    examMarksDb.insert(studentID, courseID, exam, marks);

                    MessageBox.Show("Student marks successfully recorded");

                    clear();
                }
                else
                {
                    MessageBox.Show("There is alread a mark enetered for the selected Student ID, Course Id and Exam");

                    clear();
                }
            }
            else if (type == "update")
            {
                //validations
                if (txtMarks.Text == "")
                {
                    MessageBox.Show("Must enter exam marks");
                    return;
                }

                int marks;

                if (int.TryParse(txtMarks.Text, out marks) == false)
                {
                    MessageBox.Show("Marks must be numeric");
                    return;
                }

                if (marks < 0 || marks > 100)
                {
                    MessageBox.Show("Marks must be between 0 and 100");
                    return;
                }

                marks = Convert.ToInt32(txtMarks.Text);

                if (MessageBox.Show("Do you really want to update the record", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    examMarksDb.update(studentID, courseID, exam, marks);

                    MessageBox.Show("Marks successfully updated");
                }
                else
                {
                    MessageBox.Show("Marks was not updated");
                }

                clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            type = "update";
            clear();
        }

        private void cboExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type == "update" || type == "select")
            {
                btnGetDetails.Visible = true;
            }
        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            //validations
            if (cboStudentID.SelectedIndex == -1)
            {
                MessageBox.Show("Must select Student ID");
                return;
            }

            if (cboCourseID.SelectedIndex == -1)
            {
                MessageBox.Show("Must select Course ID");
                return;
            }

            if (cboExam.SelectedIndex == -1)
            {
                MessageBox.Show("Must select Exam Type");
                return;
            }

            studentID = Convert.ToInt32(cboStudentID.SelectedItem.ToString());
            courseID = Convert.ToInt32(cboCourseID.SelectedItem.ToString());
            exam = cboExam.SelectedItem.ToString();

            if (!examMarksDb.check(studentID, courseID, exam) == true)
            {
                int marks = examMarksDb.getMarks(studentID, courseID, exam);

                txtMarks.Text = marks.ToString();
            }

            cboStudentID.Enabled = false;
            cboCourseID.Enabled = false;
            cboExam.Enabled = false;

            if (type == "update")
            {
                txtMarks.Enabled = true;
                btnSubmit.Visible = true;
            }
            else if (type == "select")
            {
                txtMarks.Enabled = false;
            }

            btnGetDetails.Visible = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            type = "select";
            clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmexamMarks_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmhome.Show();
        }
    }
}
