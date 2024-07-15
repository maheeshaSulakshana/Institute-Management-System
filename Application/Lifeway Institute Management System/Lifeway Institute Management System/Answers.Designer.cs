namespace Lifeway_Institute_Management_System
{
    partial class frmAnswers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            table = new ListBox();
            btngetQuestion = new Button();
            txtQuestion = new TextBox();
            label3 = new Label();
            txtAnswer = new TextBox();
            btnSubmit = new Button();
            btnClear = new Button();
            btnBack = new Button();
            btnRefresh = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1709, 141);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(474, 24);
            label1.Name = "label1";
            label1.Size = new Size(569, 91);
            label1.TabIndex = 0;
            label1.Text = "Answer Questions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 156);
            label2.Name = "label2";
            label2.Size = new Size(202, 60);
            label2.TabIndex = 1;
            label2.Text = "Question";
            label2.Click += label2_Click;
            // 
            // table
            // 
            table.FormattingEnabled = true;
            table.Items.AddRange(new object[] { "QuestionID\tQuestion\t\t Answer\t\t StudentID" });
            table.Location = new Point(1032, 143);
            table.Name = "table";
            table.Size = new Size(659, 524);
            table.TabIndex = 2;
            table.SelectedIndexChanged += table_SelectedIndexChanged;
            // 
            // btngetQuestion
            // 
            btngetQuestion.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btngetQuestion.ForeColor = Color.FromArgb(128, 255, 128);
            btngetQuestion.Location = new Point(747, 343);
            btngetQuestion.Name = "btngetQuestion";
            btngetQuestion.Size = new Size(279, 102);
            btngetQuestion.TabIndex = 3;
            btngetQuestion.Text = "< Get Question";
            btngetQuestion.UseVisualStyleBackColor = true;
            btngetQuestion.Visible = false;
            btngetQuestion.Click += btngetQuestion_Click;
            // 
            // txtQuestion
            // 
            txtQuestion.BorderStyle = BorderStyle.FixedSingle;
            txtQuestion.Enabled = false;
            txtQuestion.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuestion.Location = new Point(268, 154);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(466, 65);
            txtQuestion.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 252);
            label3.Name = "label3";
            label3.Size = new Size(167, 60);
            label3.TabIndex = 1;
            label3.Text = "Answer";
            label3.Click += label2_Click;
            // 
            // txtAnswer
            // 
            txtAnswer.BorderStyle = BorderStyle.FixedSingle;
            txtAnswer.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnswer.Location = new Point(268, 252);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(466, 367);
            txtAnswer.TabIndex = 5;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.Black;
            btnSubmit.Location = new Point(788, 528);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(207, 91);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit Answer";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Visible = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 16.2F);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(32, 399);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(207, 91);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 16.2F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(32, 528);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(207, 91);
            btnBack.TabIndex = 3;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(833, 467);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 44);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Visible = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // frmAnswers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1703, 681);
            Controls.Add(btnRefresh);
            Controls.Add(txtAnswer);
            Controls.Add(txtQuestion);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(btngetQuestion);
            Controls.Add(table);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "frmAnswers";
            Text = "Answer Questions";
            FormClosed += frmAnswers_FormClosed;
            Load += frmAnswers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private ListBox table;
        private Button btngetQuestion;
        private TextBox txtQuestion;
        private Label label3;
        private TextBox txtAnswer;
        private Button btnSubmit;
        private Button btnClear;
        private Button btnBack;
        private Button btnRefresh;
    }
}