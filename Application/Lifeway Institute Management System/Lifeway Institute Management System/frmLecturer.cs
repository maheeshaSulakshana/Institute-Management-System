using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lifeway_Institute_Management_System
{
    public partial class frmLecturer : Form
    {
        String type = "";
        Lecturer lecturer;
        LecturerDb lecturerdb;
        frmHome frmhome;
        public frmLecturer()
        {
            InitializeComponent();
        }

        public frmLecturer(frmHome frmHome)
        {
            InitializeComponent();
            this.frmhome = frmHome;
        }

        private void clear()
        {
            cboID.Text = "";
            cboTitle.Text = "";
            cboName.Text = "";
            txtdob.Text = "";
            txtNIC.Text = "";
            txtaddress.Text = "";
            txt_tel.Text = "";

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
            cboID.Enabled = true;
            cboTitle.Enabled = true;
            cboName.Enabled = true;
            txtdob.Enabled = true;
            txtNIC.Enabled = true;
            txtaddress.Enabled = true;
            txt_tel.Enabled = true;

            cboName.Items.Clear();
            btnSubmit.Visible = true;
            btnGetDetails.Visible = false;
        }

        private void setUpdateEnvironment()
        {
            lblID.Visible = true;
            cboID.Visible = true;
            cboTitle.Enabled = false;
            cboName.Enabled = false;
            txtdob.Enabled = false;
            txtNIC.Enabled = false;
            txtaddress.Enabled = true;
            txt_tel.Enabled = true;

            cboName.Items.Clear();
            btnSubmit.Visible = false;
            btnGetDetails.Visible = true;

            populateIDs();
        }

        private void setDeleteEnvironment()
        {
            lblID.Visible = true;
            cboID.Visible = true;
            cboID.Enabled = true;
            cboTitle.Enabled = false;
            cboName.Enabled = false;
            txtdob.Enabled = false;
            txtNIC.Enabled = false;
            txtaddress.Enabled = false;
            txt_tel.Enabled = false;

            cboName.Items.Clear();
            btnSubmit.Visible = false;
            btnGetDetails.Visible = true;
            populateIDs();
        }

        private void setSelectEnvironment()
        {
            lblID.Visible = true;
            cboID.Visible = true;
            cboID.Enabled = false;
            cboTitle.Enabled = false;
            cboName.Enabled = true;
            txtdob.Enabled = false;
            txtNIC.Enabled = false;
            txtaddress.Enabled = false;
            txt_tel.Enabled = false;

            btnSubmit.Visible = false;
            btnGetDetails.Visible = true;
            populateNames();
        }

        private void populateIDs()
        {
            cboID.Items.Clear();

            List<int> Ids = new List<int>();

            lecturerdb = new LecturerDb();

            Ids = lecturerdb.getIDs();

            foreach (int id in Ids)
            {
                cboID.Items.Add(id);
            }
        }

        private void populateNames()
        {
            cboName.Items.Clear();

            lecturerdb = new LecturerDb();

            List<String> names = lecturerdb.getNames();

            foreach (String name in names)
            {
                cboName.Items.Add(name);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
                if (cboTitle.SelectedIndex == -1)
                {
                    MessageBox.Show("Must select Title");
                    return;
                }

                if (cboName.Text == "")
                {
                    MessageBox.Show("Must enter name");
                    return;
                }

                if (txtdob.Text == "")
                {
                    MessageBox.Show("Must enter DOB");
                    return;
                }

                if (txtNIC.Text == "")
                {
                    MessageBox.Show("Must enter NIC");
                    return;
                }

                if (txtNIC.Text.Length < 10)
                {
                    MessageBox.Show("Must enter valid NIC");
                    return;
                }

                if (txtaddress.Text == "")
                {
                    MessageBox.Show("Must enter Address");
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

                int nic = Convert.ToInt32(txtNIC.Text);

                lecturerdb = new LecturerDb();

                if (lecturerdb.check(nic))
                {
                    lecturer = new Lecturer();

                    lecturer.Title = cboTitle.Text;
                    lecturer.Name = cboName.Text;
                    lecturer.DOB = txtdob.Text;
                    lecturer.NIC = nic;
                    lecturer.Address = txtaddress.Text;
                    lecturer.Tel = Convert.ToInt32(txt_tel.Text);

                    lecturerdb = new LecturerDb(lecturer);

                    lecturerdb.insert();

                    int id = lecturerdb.getID();

                    MessageBox.Show("Lecturer details successfully stored\nLecturer ID: " + id);

                    clear();
                }
                else
                {
                    MessageBox.Show("There is already a lecturer having the same NIC");
                    txtNIC.Clear();
                }
            }
            else if (type == "update")
            {
                //validations
                if (txtaddress.Text == "")
                {
                    MessageBox.Show("Must enter Address");
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

                lecturer.NIC = Convert.ToInt32(txtNIC.Text);
                lecturer.Address = txtaddress.Text;

                if (MessageBox.Show("Do you really want to update the details of " + lecturer.Name, "Update Confirmation Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    lecturerdb = new LecturerDb(lecturer);

                    lecturerdb.update();
                    MessageBox.Show("Reccord successfully updated", "Updated Message");
                    clear();
                }
                else
                {
                    MessageBox.Show("Lecturer Details not updated");
                }
            }
            else if (type == "delete")
            {
                if (MessageBox.Show("Do you really want to delete the details of " + lecturer.Name, "Delete Confirmation Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    lecturerdb = new LecturerDb(lecturer);

                    lecturerdb.delete();
                    MessageBox.Show("Reccord successfully deleted", "Deleted Message");
                    clear();
                }
                else
                {
                    MessageBox.Show("Lecturer Details not deleted");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            type = "update";
            clear();
        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            if (type == "update" || type == "delete")
            {
                if (cboID.SelectedIndex != -1)
                {
                    int ID = Convert.ToInt32(cboID.SelectedItem.ToString());
                    lecturer = lecturerdb.getLecturer(ID);

                    cboTitle.Text = lecturer.Title;
                    cboName.Text = lecturer.Name;
                    txtdob.Text = lecturer.DOB;
                    txtNIC.Text = lecturer.NIC.ToString();
                    txtaddress.Text = lecturer.Address;
                    txt_tel.Text = lecturer.Tel.ToString();

                    if (type == "update")
                    {
                        txtaddress.Enabled = true;
                        txt_tel.Enabled = true;
                        btnSubmit.Visible = true;
                    }
                    else if (type == "delete")
                    {
                        cboName.Enabled = false;
                    }

                    btnGetDetails.Visible = false;
                    btnSubmit.Visible = true;
                }
                else
                {
                    MessageBox.Show("Must select Lecturer ID to get details");
                }
            }
            else if (type == "select")
            {
                //validations
                if (cboName.SelectedIndex == -1)
                {
                    MessageBox.Show("Must select name to search for lecturer");
                    return;
                }

                String name = cboName.Text;

                lecturerdb = new LecturerDb();

                lecturer = lecturerdb.getLecturer(name);

                cboID.Text = lecturer.ID.ToString();
                cboTitle.Text = lecturer.Title;
                cboName.Text = lecturer.Name;
                txtdob.Text = lecturer.DOB;
                txtNIC.Text = lecturer.NIC.ToString();
                txtaddress.Text = lecturer.Address;
                txt_tel.Text = lecturer.Tel.ToString();

                cboName.Enabled = false;
                btnGetDetails.Visible = false;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void frmLecturer_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmhome.Show();
        }
    }
}
