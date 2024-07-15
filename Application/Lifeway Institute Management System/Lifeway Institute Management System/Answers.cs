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
    public partial class frmAnswers : Form
    {
        QuestionDb questionDb;
        frmHome frmhome;

        List<int> questionIDs;
        List<String> questions;
        List<String> answers;
        List<int> studentIDs;

        int index;
        public frmAnswers()
        {
            InitializeComponent();
        }

        public frmAnswers(frmHome frmhome)
        {
            InitializeComponent();
            this.frmhome = frmhome;
        }

        private void frmAnswers_Load(object sender, EventArgs e)
        {
            questionDb = new QuestionDb();

            questionIDs = questionDb.getQuestionIDs();
            questions = questionDb.getQuestions();
            answers = questionDb.getAnswers();
            studentIDs = questionDb.getStudentIDs();

            int c = 0;

            while (c < questionIDs.Count)
            {
                String row = questionIDs[c] + "                                     " + questions[c] + "                   " + answers[c] + "                                  " + studentIDs[c];
                table.Items.Add(row);

                c++;
            }
        }

        private void table_SelectedIndexChanged(object sender, EventArgs e)
        {
            btngetQuestion.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "")
            {
                MessageBox.Show("Must type answer");
                return;
            }

            int questionID = questionIDs[index];
            String answer = txtAnswer.Text;

            questionDb.sendAnswer(answer, questionID);

            MessageBox.Show("Question successfully answered");

            txtQuestion.Clear();
            txtAnswer.Clear();

            btnSubmit.Visible = false;
            btnRefresh.Visible = true;
        }

        private void btngetQuestion_Click(object sender, EventArgs e)
        {
            if (table.SelectedIndex == -1)
            {
                MessageBox.Show("Must select question");
                btngetQuestion.Visible = false;
                return;
            }

            index = table.SelectedIndex;
            index--;

            txtQuestion.Text = questions[index];

            btnSubmit.Visible = true;
            btngetQuestion.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuestion.Clear();
            txtAnswer.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAnswers_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmhome.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int lastrow = table.Items.Count;
            lastrow = lastrow - 1;

            while (lastrow > 0)
            {
                table.Items.RemoveAt(lastrow);
                lastrow--;
            }

            questionDb = new QuestionDb();

            questionIDs = questionDb.getQuestionIDs();
            questions = questionDb.getQuestions();
            answers = questionDb.getAnswers();
            studentIDs = questionDb.getStudentIDs();

            int c = 0;

            while (c < questionIDs.Count)
            {
                String row = questionIDs[c] + "                                     " + questions[c] + "                   " + answers[c] + "                                  " + studentIDs[c];
                table.Items.Add(row);

                c++;
            }

            btnRefresh.Visible = false;
        }
    }
}
