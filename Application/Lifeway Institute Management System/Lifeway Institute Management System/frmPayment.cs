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
    public partial class frmPayment : Form
    {
        frmHome frmhome;
        Payment payment;
        PaymentDb paymentDb;
        StudentDb studentDb;
        StudentCourseDb student_courseDb;
        public frmPayment()
        {
            InitializeComponent();
        }

        public frmPayment(frmHome frmhome)
        {
            InitializeComponent();
            this.frmhome = frmhome;
        }

        private void clear()
        {
            cboStudentID.SelectedIndex = -1;
            cboStudentID.Text = "";
            cboCourseID.SelectedIndex = -1;
            cboCourseID.Text = "";
            txtBillNo.Text = "";
            cboType.SelectedIndex = -1;
            cboType.Text = "";
            txtAmount.Text = "";
            txtDate.Text = "";

            cboCourseID.Enabled = false;
            txtBillNo.Enabled = false;
            cboType.Enabled = false;
            txtAmount.Enabled = false;
            txtDate.Enabled = false;
        }

        private void populateStudentIDs()
        {
            cboStudentID.Items.Clear();

            studentDb = new StudentDb();

            List<int> IDs = studentDb.getIDs();

            foreach (int ID in IDs)
            {
                cboStudentID.Items.Add(ID);
            }
        }

        private void populateCourseIDs(int studentID)
        {
            cboCourseID.Items.Clear();

            student_courseDb = new StudentCourseDb();

            List<int> IDs = student_courseDb.getCourseIDs(studentID);

            foreach (int ID in IDs)
            {
                cboCourseID.Items.Add(ID);
            }
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            populateStudentIDs();
        }

        private void cboStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStudentID.SelectedIndex != -1)
            {
                int studentID = Convert.ToInt32(cboStudentID.SelectedItem.ToString());

                populateCourseIDs(studentID);

                cboCourseID.Enabled = true;
                txtBillNo.Enabled = true;
                cboType.Enabled = true;
                txtAmount.Enabled = true;

                txtDate.Text = System.DateTime.Today.Date.ToString("d");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //validations
            if (cboCourseID.SelectedIndex == -1)
            {
                MessageBox.Show("Must select course ID");
                return;
            }

            if (txtBillNo.Text == "")
            {
                MessageBox.Show("Must enter Bill No");
                return;
            }

            int billno;

            if (int.TryParse(txtBillNo.Text, out billno) == false)
            {
                MessageBox.Show("Bill no must be numeric");
                return;
            }

            if (cboType.SelectedIndex == -1)
            {
                MessageBox.Show("Must select Type(Registration/Monthly Payment)");
                return;
            }

            if (txtAmount.Text == "")
            {
                MessageBox.Show("Must enter Payment Amount");
                return;
            }

            double amount;

            if (double.TryParse(txtAmount.Text, out amount) == false)
            {
                MessageBox.Show("Amount must be numeric");
                return;
            }

            payment = new Payment();

            payment.StudentID = Convert.ToInt32(cboStudentID.SelectedItem.ToString());
            payment.CourseID = Convert.ToInt32(cboCourseID.SelectedItem.ToString());
            payment.Billno = billno;
            payment.Type = cboType.SelectedItem.ToString();
            payment.Amount = Convert.ToInt32(txtAmount.Text);
            payment.Date = txtDate.Text;

            paymentDb = new PaymentDb(payment);

            if (paymentDb.checkbilldetails()) {
                if (paymentDb.checkbillno())
                {
                    paymentDb.insert();
                    MessageBox.Show("Payment Details successfully recorded");
                }
                else
                {
                    MessageBox.Show("There is already payment stored in the database with the same Bill no: " + payment.Billno);
                }
            }
            else
            {
                MessageBox.Show("There is already a bill contained within the database have the same payment details\nStudent ID: " + payment.StudentID + " Course ID: " + payment.CourseID + "\nType: " + payment.Type);
            }

            clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmhome.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
