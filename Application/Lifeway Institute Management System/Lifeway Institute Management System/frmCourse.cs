using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lifeway_Institute_Management_System
{
    public partial class frmCourse : Form
    {
        String type;
        frmHome frmhome;
        Course course;
        CourseDb courseDb;
        BatchDb batchdb;
        LecturerDb lecturerdb;
        public frmCourse()
        {
            InitializeComponent();
        }

        public frmCourse(frmHome frmhome)
        {
            InitializeComponent();
            this.frmhome = frmhome;
        }

        private void clear()
        {
            cboID.Text = "";
            cboName.Text = "";
            cboDuration.Text = "";
            txtFee.Text = "";
            cboBatchID.Text = "";
            cboLecturerID.Text = "";

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
                default:
                    break;
            }
        }

        private void setInsertEnvironment()
        {
            lblID.Visible = false;
            cboID.Visible = false;
            cboName.Enabled = true;
            cboDuration.Enabled = true;
            txtFee.Enabled = true;
            cboBatchID.Enabled = true;
            cboLecturerID.Enabled = true;

            btnSubmit.Visible = true;
            btnGetDetails.Visible = false;

            populateBatchIDs();
            populateLecturerIDs();
        }

        private void setUpdateEnvironment()
        {
            lblID.Visible = true;
            cboID.Visible = true;
            cboID.Enabled = true;
            cboName.Enabled = false;
            cboDuration.Enabled = false;
            txtFee.Enabled = false;
            cboBatchID.Enabled = false;
            cboLecturerID.Enabled = false;

            btnSubmit.Visible = false;
            btnGetDetails.Visible = false;

            populateCourseIDs();
        }

        private void setDeleteEnvironment()
        {
            lblID.Visible = true;
            cboID.Visible = true;
            cboID.Enabled = true;
            cboName.Enabled = false;
            cboDuration.Enabled = false;
            txtFee.Enabled = false;
            cboBatchID.Enabled = false;
            cboLecturerID.Enabled = false;

            btnSubmit.Visible = false;
            btnGetDetails.Visible = false;

            populateCourseIDs();
        }

        private void setSelectEnvironment()
        {
            lblID.Visible = true;
            cboID.Visible = true;
            cboID.Enabled = true;
            cboName.Enabled = false;
            cboDuration.Enabled = false;
            txtFee.Enabled = false;
            cboBatchID.Enabled = false;
            cboLecturerID.Enabled = false;

            btnSubmit.Visible = false;
            btnGetDetails.Visible = false;

            populateCourseIDs();
        }

        private void populateBatchIDs()
        {
            cboBatchID.Items.Clear();

            batchdb = new BatchDb();

            List<int> IDs = batchdb.getBatchIDs();

            foreach (int ID in IDs)
            {
                cboBatchID.Items.Add(ID);
            }

            cboBatchID.Items.Add("Add New...");
        }

        private void populateLecturerIDs()
        {
            cboLecturerID.Items.Clear();

            lecturerdb = new LecturerDb();

            List<int> IDs = lecturerdb.getIDs();

            foreach (int ID in IDs)
            {
                cboLecturerID.Items.Add(ID);
            }
        }

        private void populateCourseIDs()
        {
            cboID.Items.Clear();

            courseDb = new CourseDb();

            List<int> IDs = courseDb.getIDs();

            foreach (int ID in IDs)
            {
                cboID.Items.Add(ID);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            type = "insert";
            clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (type == "insert")
            {
                //validations
                if (cboName.Text == "")
                {
                    MessageBox.Show("Must enter course name");
                    return;
                }

                if (cboDuration.SelectedIndex == -1)
                {
                    MessageBox.Show("Must select duration");
                    return;
                }

                if (txtFee.Text == "")
                {
                    MessageBox.Show("Must enter fee");
                    return;
                }

                double num;

                if ((double.TryParse(txtFee.Text, out num)) == false)
                {
                    MessageBox.Show("Fee must be numeric");
                    return;
                }

                if (cboBatchID.SelectedIndex == -1)
                {
                    MessageBox.Show("Must select Batch ID");
                    return;
                }

                if (cboLecturerID.SelectedIndex == -1)
                {
                    MessageBox.Show("Must select Lecturer ID");
                    return;
                }

                course = new Course();

                course.Name = cboName.Text;

                switch (cboDuration.SelectedItem)
                {
                    case "3 Months":
                        course.Duration = 3;
                        break;
                    case "6 Months":
                        course.Duration = 6;
                        break;
                    case "12 Months":
                        course.Duration = 12;
                        break;
                }

                course.Fee = Convert.ToDouble(txtFee.Text);
                course.BatchID = Convert.ToInt32(cboBatchID.SelectedItem.ToString());
                course.LecturerID = Convert.ToInt32(cboLecturerID.SelectedItem.ToString());

                courseDb = new CourseDb(course);

                courseDb.insert();

                MessageBox.Show("Course Details successfully stored");

                clear();
            }
            else if (type == "update")
            {
                switch (cboDuration.SelectedItem)
                {
                    case "3 Months":
                        course.Duration = 3;
                        break;
                    case "6 Months":
                        course.Duration = 6;
                        break;
                    case "12 Months":
                        course.Duration = 12;
                        break;
                }

                course.Fee = Convert.ToDouble(txtFee.Text);

                if (MessageBox.Show("Do you really want to update the details of course: " + course.Name, "Update Confirmation Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    courseDb = new CourseDb(course);

                    courseDb.update();

                    MessageBox.Show("Reccord Successfully Updated");
                }
                else
                {
                    MessageBox.Show("Course details not updated");
                }
                clear();
            }
            else if (type == "delete")
            {
                if (MessageBox.Show("Do you really want to delete the details of course: " + course.Name, "Delete Confirmation Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    courseDb = new CourseDb(course);

                    courseDb.delete();

                    MessageBox.Show("Reccord Successfully Deleted");
                }
                else
                {
                    MessageBox.Show("Course details not deleted");
                }
                clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            type = "update";
            clear();
        }

        private void cboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGetDetails.Visible = true;
        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            if (cboID.SelectedIndex != -1)
            {
                if (type == "update" || type == "delete" || type == "select")
                {
                    int ID = Convert.ToInt32(cboID.SelectedItem.ToString());

                    course = courseDb.getCourse(ID);

                    cboName.Text = course.Name;

                    switch (course.Duration)
                    {
                        case 3:
                            cboDuration.SelectedIndex = 0;
                            cboDuration.Text = "3 Months";
                            break;
                        case 6:
                            cboDuration.SelectedIndex = 1;
                            cboDuration.Text = "6 Months";
                            break;
                        case 12:
                            cboDuration.SelectedIndex = 2;
                            cboDuration.Text = "12 Months";
                            break;
                    }

                    txtFee.Text = course.Fee.ToString();
                    cboBatchID.Text = course.BatchID.ToString();
                    cboLecturerID.Text = course.LecturerID.ToString();

                    cboID.Enabled = false;
                    btnGetDetails.Visible = false;

                    if (type == "update" || type == "delete")
                    {
                        btnSubmit.Visible = true;
                    }

                    if (type == "update")
                    {
                        cboDuration.Enabled = true;
                        txtFee.Enabled = true;
                    }
                }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCourse_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmhome.Show();
        }

        private void cboBatchID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBatchID.SelectedItem.ToString() == "Add New...")
            {
                btnrefresh.Visible = true;
                this.Hide();
                frmBatch frmbatch = new frmBatch(this);
                frmbatch.Show();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            populateBatchIDs();
            cboBatchID.SelectedIndex = -1;
            cboBatchID.Text = "";
            btnrefresh.Visible = false;
        }
    }
}
