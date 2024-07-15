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
    public partial class frmParent : Form
    {
        Parent parent;
        ParentDb parentdb;
        frmStudent frmstudent;
        public frmParent()
        {
            InitializeComponent();
        }

        public frmParent(frmStudent frmstudent)
        {
            InitializeComponent();
            this.frmstudent = frmstudent;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //validations
            if (txtname.Text == "")
            {
                MessageBox.Show("Must enter parent name");
                return;
            }

            if (txtaddress.Text == "")
            {
                MessageBox.Show("Must enter address");
                return;
            }

            if (txt_tel.Text == "")
            {
                MessageBox.Show("Must enter Telephone No");
                return;
            }

            if (txt_tel.Text.Length < 10)
            {
                MessageBox.Show("Must enter valid Telephone No");
                return;
            }

            parent = new Parent();

            parent.Name = txtname.Text;
            parent.Address = txtaddress.Text;
            parent.Tel = Convert.ToInt32(txt_tel.Text);

            parentdb = new ParentDb(parent);

            if (parentdb.check(parent.Name))
            {
                parentdb.insert();

                MessageBox.Show("Parent details successfully recorded");

                txtname.Clear();
                txtaddress.Clear();
                txt_tel.Clear();

                this.Close();
                frmstudent.Show();
            }
            else
            {
                MessageBox.Show("Parent already available with name: " + parent.Name);
                txtname.Clear();
                txtaddress.Clear();
                txt_tel.Clear();
            }
        }

        private void btnClear_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtaddress.Clear();
            txt_tel.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmParent_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmstudent.Show();
        }
    }
}
