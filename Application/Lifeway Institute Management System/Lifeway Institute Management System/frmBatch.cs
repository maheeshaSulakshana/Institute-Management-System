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
    public partial class frmBatch : Form
    {
        Batch batch;
        BatchDb batchdb;
        frmHome frmHome;
        frmCourse frmCourse;
        public frmBatch()
        {
            InitializeComponent();
        }

        public frmBatch(frmHome frmhome)
        {
            InitializeComponent();
            this.frmHome = frmhome;
        }

        public frmBatch(frmCourse frmCourse)
        {
            InitializeComponent();
            this.frmCourse = frmCourse;
        }

        private void clear()
        {
            txtName.Text = "";
            cbo_ClassType.Text = "";
            cbo_AgeGroup.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //validations
            if (txtName.Text == "")
            {
                MessageBox.Show("Must enter Batch name");
                return;
            }

            if (cbo_ClassType.SelectedIndex == -1)
            {
                MessageBox.Show("Must select Class Type");
                return;
            }

            if (cbo_AgeGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Must select Age Type");
                return;
            }

            batch = new Batch();

            batch.Name = txtName.Text;
            batch.ClassType = cbo_ClassType.SelectedItem.ToString();
            batch.AgeGroup = cbo_AgeGroup.SelectedItem.ToString();

            batchdb = new BatchDb();

            if (batchdb.check(batch.Name, batch.ClassType, batch.AgeGroup))
            {
                batchdb = new BatchDb(batch);

                batchdb.insert();

                MessageBox.Show("Batch successfully added");
            }
            else
            {
                MessageBox.Show("There is already a batch stored having the same name, class type, and age group\n" + batch.Name + " " + batch.ClassType + " " + batch.AgeGroup);
            }

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

        private void frmBatch_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmHome == null)
            {
                frmCourse.Show();
            }
            else
            {
                frmHome.Show();
            }
        }
    }
}
