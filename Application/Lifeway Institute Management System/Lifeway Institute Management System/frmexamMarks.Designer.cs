namespace Lifeway_Institute_Management_System
{
    partial class frmexamMarks
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
            btnSelect = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cboStudentID = new ComboBox();
            cboCourseID = new ComboBox();
            cboExam = new ComboBox();
            txtMarks = new TextBox();
            btnSubmit = new Button();
            btnBack = new Button();
            btnClear = new Button();
            btnGetDetails = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(btnSelect);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnInsert);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 140);
            panel1.TabIndex = 0;
            // 
            // btnSelect
            // 
            btnSelect.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnSelect.Location = new Point(836, 81);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(131, 43);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Search";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnUpdate.Location = new Point(442, 81);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 43);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnInsert.Location = new Point(74, 81);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(131, 43);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(368, 22);
            label1.Name = "label1";
            label1.Size = new Size(323, 46);
            label1.TabIndex = 0;
            label1.Text = "Record Exam Marks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(122, 185);
            label2.Name = "label2";
            label2.Size = new Size(183, 46);
            label2.TabIndex = 1;
            label2.Text = "Student ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(122, 252);
            label3.Name = "label3";
            label3.Size = new Size(170, 46);
            label3.TabIndex = 1;
            label3.Text = "Course ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(122, 323);
            label4.Name = "label4";
            label4.Size = new Size(103, 46);
            label4.TabIndex = 1;
            label4.Text = "Exam";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(122, 393);
            label5.Name = "label5";
            label5.Size = new Size(207, 46);
            label5.TabIndex = 1;
            label5.Text = "Exam Marks";
            // 
            // cboStudentID
            // 
            cboStudentID.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboStudentID.FormattingEnabled = true;
            cboStudentID.Location = new Point(467, 182);
            cboStudentID.Name = "cboStudentID";
            cboStudentID.Size = new Size(394, 49);
            cboStudentID.TabIndex = 2;
            cboStudentID.SelectedIndexChanged += cboStudentID_SelectedIndexChanged;
            // 
            // cboCourseID
            // 
            cboCourseID.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCourseID.FormattingEnabled = true;
            cboCourseID.Location = new Point(467, 249);
            cboCourseID.Name = "cboCourseID";
            cboCourseID.Size = new Size(394, 49);
            cboCourseID.TabIndex = 2;
            cboCourseID.SelectedIndexChanged += cboCourseID_SelectedIndexChanged;
            // 
            // cboExam
            // 
            cboExam.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboExam.FormattingEnabled = true;
            cboExam.Items.AddRange(new object[] { "Theory", "Practical" });
            cboExam.Location = new Point(467, 320);
            cboExam.Name = "cboExam";
            cboExam.Size = new Size(394, 49);
            cboExam.TabIndex = 2;
            cboExam.SelectedIndexChanged += cboExam_SelectedIndexChanged;
            // 
            // txtMarks
            // 
            txtMarks.BorderStyle = BorderStyle.FixedSingle;
            txtMarks.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMarks.Location = new Point(467, 392);
            txtMarks.Name = "txtMarks";
            txtMarks.Size = new Size(394, 47);
            txtMarks.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 15F);
            btnSubmit.Location = new Point(430, 486);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(137, 63);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 15F);
            btnBack.Location = new Point(168, 486);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(137, 63);
            btnBack.TabIndex = 4;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 15F);
            btnClear.Location = new Point(679, 486);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(137, 63);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnGetDetails
            // 
            btnGetDetails.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGetDetails.Location = new Point(884, 182);
            btnGetDetails.Name = "btnGetDetails";
            btnGetDetails.Size = new Size(152, 63);
            btnGetDetails.TabIndex = 4;
            btnGetDetails.Text = "Get Details";
            btnGetDetails.UseVisualStyleBackColor = true;
            btnGetDetails.Visible = false;
            btnGetDetails.Click += btnGetDetails_Click;
            // 
            // frmexamMarks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1048, 595);
            Controls.Add(btnClear);
            Controls.Add(btnBack);
            Controls.Add(btnGetDetails);
            Controls.Add(btnSubmit);
            Controls.Add(txtMarks);
            Controls.Add(cboExam);
            Controls.Add(cboCourseID);
            Controls.Add(cboStudentID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "frmexamMarks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Record Exam Marks";
            FormClosed += frmexamMarks_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnSelect;
        private Button btnUpdate;
        private Button btnInsert;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboStudentID;
        private ComboBox cboCourseID;
        private ComboBox cboExam;
        private TextBox txtMarks;
        private Button btnSubmit;
        private Button btnBack;
        private Button btnClear;
        private Button btnGetDetails;
    }
}