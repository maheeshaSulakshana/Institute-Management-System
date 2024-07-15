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
    public partial class frmStudent : Form
    {
        String type = "";
        Student student = new Student();
        StudentDb studentdb = new StudentDb();
        frmHome frmHome = new frmHome();
        public frmStudent()
        {
            InitializeComponent();
        }

        public frmStudent(frmHome frmHome)
        {
            InitializeComponent();
            this.frmHome = frmHome;
        }

        //clears the text fields
        public void clear()
        {
            cboID.Text = "";
            cbo_firstname.Text = "";
            cbo_firstname.Items.Clear();
            cbo_surname.Text = "";
            cbo_surname.Items.Clear();
            txttitle.Clear();
            cbogender.SelectedIndex = -1;
            txtdob.Clear();
            txt_NIC.Clear();
            txt_address.Clear();
            txt_tel.Clear();
            txtRegistrationDate.Clear();
            cbo_Parent.SelectedIndex = -1;
            cbo_Parent.Text = "";

            if (type == "insert")
            {
                setInsertEnvironment();
            }
            else if (type == "update")
            {
                setUpdateEnvironment();
            }
            else if (type == "delete")
            {
                setDeleteEnvironment();
            }
            else if (type == "select")
            {
                setSelectEnvironment();
            }
        }
        public void populateIDs()
        {
            cboID.Items.Clear();
            List<int> IDs = studentdb.getIDs();

            foreach (int ID in IDs)
            {
                cboID.Items.Add(ID);
            }
        }

        public void populateNames()
        {
            cbo_firstname.Items.Clear();
            cbo_surname.Items.Clear();

            List<String> fnames = new List<String>();
            List<String> snames = new List<String>();

            fnames = studentdb.getFNames();
            snames = studentdb.getSNames();

            foreach (String name in fnames)
            {
                cbo_firstname.Items.Add(name);
            }

            foreach (String name in snames)
            {
                cbo_surname.Items.Add(name);
            }
        }

        public void populateParentNames()
        {
            cbo_Parent.Items.Clear();

            ParentDb parentdb = new ParentDb();

            List<String> names = parentdb.getNames();

            foreach (String name in names)
            {
                cbo_Parent.Items.Add(name);
            }

            cbo_Parent.Items.Add("Add New...");
        }

        public void setInsertEnvironment()
        {
            lblID.Visible = false;
            cboID.Visible = false;
            cbo_firstname.Enabled = true;
            cbo_surname.Enabled = true;
            txttitle.Enabled = true;
            cbogender.Enabled = true;
            txtdob.Enabled = true;
            txt_address.Enabled = true;
            txt_NIC.Enabled = true;
            txt_tel.Enabled = true;
            txtRegistrationDate.Enabled = true;
            cbo_Parent.Enabled = true;

            btnGetDetails.Visible = false;
            btnSubmit.Visible = true;
            cbo_firstname.Items.Clear();
            cbo_surname.Items.Clear();
            txtRegistrationDate.Text = System.DateTime.Now.Date.ToShortDateString();
            populateParentNames();
        }

        public void setUpdateEnvironment()
        {
            lblID.Visible = true;
            cboID.Visible = true;
            cboID.Enabled = true;
            cbo_firstname.Enabled = false;
            cbo_surname.Enabled = false;
            txttitle.Enabled = false;
            cbogender.Enabled = false;
            txtdob.Enabled = false;
            txt_address.Enabled = false;
            txt_NIC.Enabled = false;
            txt_tel.Enabled = false;
            txtRegistrationDate.Enabled = false;
            cbo_Parent.Enabled = false;

            cbo_firstname.Items.Clear();
            cbo_surname.Items.Clear();
            btnGetDetails.Visible = false;
            btnSubmit.Visible = false;
            populateIDs();
        }

        public void setDeleteEnvironment()
        {
            lblID.Visible = false;
            cboID.Visible = false;
            cbo_firstname.Enabled = true;
            cbo_surname.Enabled = true;
            txttitle.Enabled = false;
            cbogender.Enabled = false;
            txtdob.Enabled = false;
            txt_address.Enabled = false;
            txt_NIC.Enabled = false;
            txt_tel.Enabled = false;
            txtRegistrationDate.Enabled = false;
            cbo_Parent.Enabled = false;

            btnSubmit.Visible = false;
            btnGetDetails.Visible = false;
            populateNames();
        }

        public void setSelectEnvironment()
        {
            lblID.Visible = false;
            cboID.Visible = false;
            cbo_firstname.Enabled = true;
            cbo_surname.Enabled = true;
            txttitle.Enabled = false;
            cbogender.Enabled = false;
            txtdob.Enabled = false;
            txt_address.Enabled = false;
            txt_NIC.Enabled = false;
            txt_tel.Enabled = false;
            txtRegistrationDate.Enabled = false;
            cbo_Parent.Enabled = false;

            btnSubmit.Visible = false;
            btnGetDetails.Visible = false;
            populateNames();
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
                if (cbo_firstname.Text == "")
                {
                    MessageBox.Show("Must Enter Student First Name");
                    return;
                }

                if (cbo_surname.Text == "")
                {
                    MessageBox.Show("Must Enter Student Sur Name");
                    return;
                }

                if (cbogender.SelectedIndex == -1)
                {
                    MessageBox.Show("Must select gender");
                    return;
                }

                if (txtdob.Text == "")
                {
                    MessageBox.Show("Must select student Date of Birth");
                    return;
                }

                if (txt_NIC.Text == "")
                {
                    MessageBox.Show("Must enter student NIC");
                    return;
                }

                if (txt_NIC.Text.Length != 10)
                {
                    MessageBox.Show("Must enter valid NIC number");
                    return;
                }

                if (txt_address.Text == "")
                {
                    MessageBox.Show("Must enter address of student");
                    return;
                }

                if (txt_tel.Text == "")
                {
                    MessageBox.Show("Must enter student contact number");
                    return;
                }

                if (txt_tel.Text.Length < 10)
                {
                    MessageBox.Show("Must enter a valid Telephone No");
                    return;
                }

                if (cbo_Parent.SelectedIndex == -1)
                {
                    MessageBox.Show("Must select Parent Name");
                    return;
                }

                Student student = new Student();

                student.Fname = cbo_firstname.Text;
                student.Surname = cbo_surname.Text;
                student.Title = txttitle.Text;
                student.Gender = cbogender.SelectedItem.ToString();
                student.DOB = txtdob.Text;
                student.NIC = Convert.ToInt32(txt_NIC.Text);
                student.Address = txt_address.Text;
                student.Tel = Convert.ToInt32(txt_tel.Text);
                student.Registrationdate = txtRegistrationDate.Text;
                student.Parent = cbo_Parent.SelectedItem.ToString();

                studentdb = new StudentDb(student);

                studentdb.insert();

                int studentID = studentdb.getID();

                if (studentID != 0)
                {
                    MessageBox.Show("Student successfully registered\nStudentID: " + studentID);
                }

                clear();

                if (MessageBox.Show("Do you want to continue to register the student with a course?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                    frmStudentCourse frmstudentcourse = new frmStudentCourse(frmHome, studentID);
                    frmstudentcourse.Show();
                }
            }
            else if (type == "update")
            {
                student.Address = txt_address.Text;
                student.Tel = Convert.ToInt32(txt_tel.Text);

                if (MessageBox.Show("Do you really want to update the details of " + student.Fname + " " + student.Surname, "Update Confirmation Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    studentdb = new StudentDb(student);
                    studentdb.update();
                    MessageBox.Show("Reccord successfully updated", "Updated Message");
                    clear();
                }
                else
                {
                    MessageBox.Show("Student Details not updated");
                }
            }
            else if (type == "delete")
            {
                if (MessageBox.Show("Do you really want to delete the details of " + student.Fname + " " + student.Surname, "Delete Confirmation Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    studentdb = new StudentDb(student);
                    studentdb.delete();
                    MessageBox.Show("Reccord successfully deleted", "Deleted Message");
                    clear();
                }
                else
                {
                    MessageBox.Show("Student Details not deleted");
                }
            }
        }

        private void cbogender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbogender.SelectedIndex != -1)
            {
                if (cbogender.SelectedItem.ToString() == "Male")
                {
                    txttitle.Text = "Mr.";
                }
                else
                {
                    txttitle.Text = "Miss.";
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void cboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboID.SelectedIndex != -1)
            {
                btnGetDetails.Visible = true;
            }
        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            if (type == "update")
            {
                int ID = Convert.ToInt32(cboID.SelectedItem.ToString());

                student = studentdb.getStudent(ID);

                cboID.Enabled = false;
                txt_address.Enabled = true;
                txt_tel.Enabled = true;
                btnSubmit.Visible = true;
            }
            else if (type == "delete" || type == "select")
            {
                String fname = cbo_firstname.SelectedItem.ToString();
                String sname = cbo_surname.SelectedItem.ToString();

                student = studentdb.getStudent(fname, sname);

                cbo_firstname.Enabled = false;
                cbo_surname.Enabled = false;
            }
            
            if (type == "delete")
            {
                btnSubmit.Visible = true;
            }

            cbo_firstname.Text = student.Fname;
            cbo_surname.Text = student.Surname;
            txttitle.Text = student.Title;
            cbogender.Text = student.Gender;
            txtdob.Text = student.DOB;
            txt_NIC.Text = student.NIC.ToString();
            txt_address.Text = student.Address;
            txt_tel.Text = student.Tel.ToString();
            txtRegistrationDate.Text = student.Registrationdate;
            cbo_Parent.Text = student.Parent;

            btnGetDetails.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            type = "update";
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            type = "delete";
            clear();
        }

        private void cbo_firstname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type == "delete" || type == "select")
            {
                if (cbo_firstname.SelectedIndex != -1 && cbo_surname.SelectedIndex != -1)
                {
                    btnGetDetails.Visible = true;
                }
            }
        }

        private void cbo_surname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type == "delete" || type == "select")
            {
                if (cbo_firstname.SelectedIndex != -1 && cbo_surname.SelectedIndex != -1)
                {
                    btnGetDetails.Visible = true;
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            type = "select";
            clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_Parent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_Parent.Text != "")
            {
                if (cbo_Parent.SelectedItem.ToString() == "Add New...")
                {
                    cbo_Parent.SelectedIndex = -1;
                    this.Hide();
                    btnrefresh.Visible = true;

                    frmParent frmParent = new frmParent(this);
                    frmParent.Show();
                }
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {

            populateParentNames();
            btnrefresh.Visible = false;
        }

        private void frmStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmHome.Show();
        }
    }
}
