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
    public partial class frmNotes : Form
    {
        frmHome frmhome;
        String sourcePath;
        String destinationPath;
        Note note;
        NotesDb notedb;
        public frmNotes()
        {
            InitializeComponent();
        }

        public frmNotes(frmHome frmhome)
        {
            InitializeComponent();
            this.frmhome = frmhome;
        }

        private void cboPath_MouseClick(object sender, MouseEventArgs e)
        {
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                sourcePath = FileDialog.FileName;

                txtFile.Text = Path.GetFileNameWithoutExtension(sourcePath);
                cboPath.Text = sourcePath;

                cboPath.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String filename = Path.GetFileName(sourcePath);

            destinationPath = "C:\\xampp_\\htdocs\\Student_Websites\\Notes\\" + filename + "";

            if (File.Exists(destinationPath) == false)
            {
                //copies the file to the notes folder which the students website access
                File.Copy(sourcePath, destinationPath);

                String relativePath = @"Notes\\" + filename + "";
                String notename = Path.GetFileNameWithoutExtension(destinationPath);

                note = new Note(notename, relativePath);

                //records note in the database to be refered by the students' webpage
                notedb = new NotesDb(note);

                notedb.insert();

                MessageBox.Show("File stored");
            }
            else if (MessageBox.Show("There is already a file stored in notes named: " + Path.GetFileNameWithoutExtension(destinationPath) + "\nDo you want to Override that file?", "Request to Override", MessageBoxButtons.YesNo) == DialogResult.Yes){
                File.Copy(sourcePath, destinationPath, true);
                MessageBox.Show("File stored");
            }
            else
            {
                MessageBox.Show("File was not overriden");
            }

            txtFile.Clear();
            cboPath.SelectedIndex = 0;
            cboPath.Text = "";
            cboPath.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFile.Clear();
            cboPath.SelectedIndex = 0;
            cboPath.Text = "";
            cboPath.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmhome.Show();
        }
    }
}
