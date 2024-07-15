namespace Lifeway_Institute_Management_System
{
    partial class frmSchedule
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
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            label1 = new Label();
            label2 = new Label();
            cboStudentID = new ComboBox();
            label3 = new Label();
            cboCourseID = new ComboBox();
            label4 = new Label();
            cboDay1 = new ComboBox();
            label5 = new Label();
            cboTime1 = new ComboBox();
            label6 = new Label();
            cboDay2 = new ComboBox();
            label7 = new Label();
            cboTime2 = new ComboBox();
            label8 = new Label();
            cboDay3 = new ComboBox();
            label9 = new Label();
            cboTime3 = new ComboBox();
            lblAvailability1 = new Label();
            lblAvailability2 = new Label();
            lblAvailability3 = new Label();
            btnSubmit = new Button();
            btnClear = new Button();
            btnBack = new Button();
            btnGetDetails = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(btnSelect);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnInsert);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1537, 173);
            panel1.TabIndex = 1;
            // 
            // btnSelect
            // 
            btnSelect.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelect.Location = new Point(1230, 98);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(156, 54);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Search";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(879, 98);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(156, 54);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(494, 98);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(156, 54);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(110, 98);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(156, 54);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(573, 19);
            label1.Name = "label1";
            label1.Size = new Size(382, 60);
            label1.TabIndex = 0;
            label1.Text = "Manage Schedule";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(328, 216);
            label2.Name = "label2";
            label2.Size = new Size(164, 41);
            label2.TabIndex = 2;
            label2.Text = "Student ID";
            // 
            // cboStudentID
            // 
            cboStudentID.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboStudentID.FormattingEnabled = true;
            cboStudentID.Location = new Point(617, 208);
            cboStudentID.Name = "cboStudentID";
            cboStudentID.Size = new Size(406, 49);
            cboStudentID.TabIndex = 3;
            cboStudentID.SelectedIndexChanged += cboStudentID_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(328, 279);
            label3.Name = "label3";
            label3.Size = new Size(152, 41);
            label3.TabIndex = 2;
            label3.Text = "Course ID";
            // 
            // cboCourseID
            // 
            cboCourseID.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCourseID.FormattingEnabled = true;
            cboCourseID.Location = new Point(617, 271);
            cboCourseID.Name = "cboCourseID";
            cboCourseID.Size = new Size(406, 49);
            cboCourseID.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(328, 342);
            label4.Name = "label4";
            label4.Size = new Size(91, 41);
            label4.TabIndex = 2;
            label4.Text = "Day 1";
            // 
            // cboDay1
            // 
            cboDay1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDay1.FormattingEnabled = true;
            cboDay1.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" });
            cboDay1.Location = new Point(617, 334);
            cboDay1.Name = "cboDay1";
            cboDay1.Size = new Size(406, 49);
            cboDay1.TabIndex = 3;
            cboDay1.SelectedIndexChanged += cboDay1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(328, 406);
            label5.Name = "label5";
            label5.Size = new Size(106, 41);
            label5.TabIndex = 2;
            label5.Text = "Time 1";
            // 
            // cboTime1
            // 
            cboTime1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTime1.FormattingEnabled = true;
            cboTime1.Items.AddRange(new object[] { "8 - 10", "10 - 12", "12 - 2", "3 - 5" });
            cboTime1.Location = new Point(617, 398);
            cboTime1.Name = "cboTime1";
            cboTime1.Size = new Size(406, 49);
            cboTime1.TabIndex = 3;
            cboTime1.SelectedIndexChanged += cboTime1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(328, 467);
            label6.Name = "label6";
            label6.Size = new Size(96, 41);
            label6.TabIndex = 2;
            label6.Text = "Day 2";
            // 
            // cboDay2
            // 
            cboDay2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDay2.FormattingEnabled = true;
            cboDay2.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" });
            cboDay2.Location = new Point(617, 459);
            cboDay2.Name = "cboDay2";
            cboDay2.Size = new Size(406, 49);
            cboDay2.TabIndex = 3;
            cboDay2.SelectedIndexChanged += cboDay2_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(328, 530);
            label7.Name = "label7";
            label7.Size = new Size(111, 41);
            label7.TabIndex = 2;
            label7.Text = "Time 2";
            // 
            // cboTime2
            // 
            cboTime2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTime2.FormattingEnabled = true;
            cboTime2.Items.AddRange(new object[] { "8 - 10", "10 - 12", "12 - 2", "3 - 5" });
            cboTime2.Location = new Point(617, 522);
            cboTime2.Name = "cboTime2";
            cboTime2.Size = new Size(406, 49);
            cboTime2.TabIndex = 3;
            cboTime2.SelectedIndexChanged += cboTime2_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(328, 594);
            label8.Name = "label8";
            label8.Size = new Size(96, 41);
            label8.TabIndex = 2;
            label8.Text = "Day 3";
            // 
            // cboDay3
            // 
            cboDay3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDay3.FormattingEnabled = true;
            cboDay3.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" });
            cboDay3.Location = new Point(617, 586);
            cboDay3.Name = "cboDay3";
            cboDay3.Size = new Size(406, 49);
            cboDay3.TabIndex = 3;
            cboDay3.SelectedIndexChanged += cboDay3_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(328, 656);
            label9.Name = "label9";
            label9.Size = new Size(111, 41);
            label9.TabIndex = 2;
            label9.Text = "Time 3";
            // 
            // cboTime3
            // 
            cboTime3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTime3.FormattingEnabled = true;
            cboTime3.Items.AddRange(new object[] { "8 - 10", "10 - 12", "12 - 2", "3 - 5" });
            cboTime3.Location = new Point(617, 648);
            cboTime3.Name = "cboTime3";
            cboTime3.Size = new Size(406, 49);
            cboTime3.TabIndex = 3;
            cboTime3.SelectedIndexChanged += cboTime3_SelectedIndexChanged;
            // 
            // lblAvailability1
            // 
            lblAvailability1.AutoSize = true;
            lblAvailability1.Font = new Font("Segoe UI", 18F);
            lblAvailability1.ForeColor = Color.FromArgb(0, 0, 192);
            lblAvailability1.Location = new Point(1050, 406);
            lblAvailability1.Name = "lblAvailability1";
            lblAvailability1.Size = new Size(173, 41);
            lblAvailability1.TabIndex = 4;
            lblAvailability1.Text = "Availability: ";
            // 
            // lblAvailability2
            // 
            lblAvailability2.AutoSize = true;
            lblAvailability2.Font = new Font("Segoe UI", 18F);
            lblAvailability2.ForeColor = Color.FromArgb(0, 0, 192);
            lblAvailability2.Location = new Point(1050, 530);
            lblAvailability2.Name = "lblAvailability2";
            lblAvailability2.Size = new Size(173, 41);
            lblAvailability2.TabIndex = 4;
            lblAvailability2.Text = "Availability: ";
            // 
            // lblAvailability3
            // 
            lblAvailability3.AutoSize = true;
            lblAvailability3.Font = new Font("Segoe UI", 18F);
            lblAvailability3.ForeColor = Color.FromArgb(0, 0, 192);
            lblAvailability3.Location = new Point(1050, 656);
            lblAvailability3.Name = "lblAvailability3";
            lblAvailability3.Size = new Size(173, 41);
            lblAvailability3.TabIndex = 4;
            lblAvailability3.Text = "Availability: ";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(1306, 778);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(198, 109);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(1306, 636);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(198, 109);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(49, 778);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(198, 109);
            btnBack.TabIndex = 5;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnGetDetails
            // 
            btnGetDetails.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGetDetails.Location = new Point(1306, 208);
            btnGetDetails.Name = "btnGetDetails";
            btnGetDetails.Size = new Size(198, 109);
            btnGetDetails.TabIndex = 5;
            btnGetDetails.Text = "Get Details";
            btnGetDetails.UseVisualStyleBackColor = true;
            btnGetDetails.Click += btnGetDetails_Click;
            // 
            // frmSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1532, 942);
            Controls.Add(btnBack);
            Controls.Add(btnGetDetails);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(lblAvailability3);
            Controls.Add(lblAvailability2);
            Controls.Add(lblAvailability1);
            Controls.Add(cboTime3);
            Controls.Add(cboDay3);
            Controls.Add(cboTime2);
            Controls.Add(cboDay2);
            Controls.Add(cboTime1);
            Controls.Add(cboDay1);
            Controls.Add(cboCourseID);
            Controls.Add(cboStudentID);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "frmSchedule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Schedule";
            FormClosed += frmSchedule_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnSelect;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Label label2;
        private ComboBox cboStudentID;
        private Label label3;
        private ComboBox cboCourseID;
        private Label label4;
        private ComboBox cboDay1;
        private Label label5;
        private ComboBox cboTime1;
        private Label label6;
        private ComboBox cboDay2;
        private Label label7;
        private ComboBox cboTime2;
        private Label label8;
        private ComboBox cboDay3;
        private Label label9;
        private ComboBox cboTime3;
        private Label lblAvailability1;
        private Label lblAvailability2;
        private Label lblAvailability3;
        private Button btnSubmit;
        private Button btnClear;
        private Button btnBack;
        private Button btnGetDetails;
    }
}