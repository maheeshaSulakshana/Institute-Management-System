namespace Lifeway_Institute_Management_System
{
    partial class frmStudentCourse
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
            btnBack = new Button();
            btnClear = new Button();
            btnSave = new Button();
            label4 = new Label();
            txt_Date = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cbo_StudentID = new ComboBox();
            cbo_CourseID = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 143);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(273, 38);
            label1.Name = "label1";
            label1.Size = new Size(394, 41);
            label1.TabIndex = 0;
            label1.Text = "Register Student for Course";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 18F);
            btnBack.Location = new Point(253, 421);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(138, 65);
            btnBack.TabIndex = 9;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 18F);
            btnClear.Location = new Point(606, 421);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 65);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 18F);
            btnSave.Location = new Point(432, 421);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 65);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(173, 327);
            label4.Name = "label4";
            label4.Size = new Size(83, 41);
            label4.TabIndex = 3;
            label4.Text = "Date";
            // 
            // txt_Date
            // 
            txt_Date.BorderStyle = BorderStyle.FixedSingle;
            txt_Date.Enabled = false;
            txt_Date.Font = new Font("Segoe UI", 18F);
            txt_Date.Location = new Point(493, 324);
            txt_Date.Name = "txt_Date";
            txt_Date.Size = new Size(332, 47);
            txt_Date.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(173, 270);
            label3.Name = "label3";
            label3.Size = new Size(152, 41);
            label3.TabIndex = 4;
            label3.Text = "Course ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(173, 207);
            label2.Name = "label2";
            label2.Size = new Size(164, 41);
            label2.TabIndex = 5;
            label2.Text = "Student ID";
            // 
            // cbo_StudentID
            // 
            cbo_StudentID.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbo_StudentID.FormattingEnabled = true;
            cbo_StudentID.Location = new Point(493, 204);
            cbo_StudentID.Name = "cbo_StudentID";
            cbo_StudentID.Size = new Size(332, 49);
            cbo_StudentID.TabIndex = 12;
            // 
            // cbo_CourseID
            // 
            cbo_CourseID.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbo_CourseID.FormattingEnabled = true;
            cbo_CourseID.Location = new Point(493, 263);
            cbo_CourseID.Name = "cbo_CourseID";
            cbo_CourseID.Size = new Size(332, 49);
            cbo_CourseID.TabIndex = 12;
            // 
            // frmStudentCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(960, 549);
            Controls.Add(cbo_CourseID);
            Controls.Add(cbo_StudentID);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(txt_Date);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "frmStudentCourse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Student for Course";
            FormClosed += frmStudentCourse_FormClosed;
            Load += frmStudentCourse_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnBack;
        private Button btnClear;
        private Button btnSave;
        private Label label4;
        private TextBox txt_Date;
        private Label label3;
        private Label label2;
        private ComboBox cbo_StudentID;
        private ComboBox cbo_CourseID;
    }
}