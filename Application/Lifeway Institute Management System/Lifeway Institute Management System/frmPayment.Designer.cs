namespace Lifeway_Institute_Management_System
{
    partial class frmPayment
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            cboStudentID = new ComboBox();
            cboCourseID = new ComboBox();
            txtBillNo = new TextBox();
            cboType = new ComboBox();
            txtAmount = new TextBox();
            txtDate = new TextBox();
            btnSave = new Button();
            btnBack = new Button();
            btnClear = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 140);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 39);
            label1.Name = "label1";
            label1.Size = new Size(352, 51);
            label1.TabIndex = 0;
            label1.Text = "Record Payments";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(179, 170);
            label2.Name = "label2";
            label2.Size = new Size(226, 51);
            label2.TabIndex = 1;
            label2.Text = "Student ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(179, 231);
            label3.Name = "label3";
            label3.Size = new Size(216, 51);
            label3.TabIndex = 1;
            label3.Text = "Course ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(179, 294);
            label4.Name = "label4";
            label4.Size = new Size(153, 51);
            label4.TabIndex = 1;
            label4.Text = "Bill No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(179, 359);
            label5.Name = "label5";
            label5.Size = new Size(114, 51);
            label5.TabIndex = 1;
            label5.Text = "Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(179, 426);
            label7.Name = "label7";
            label7.Size = new Size(173, 51);
            label7.TabIndex = 1;
            label7.Text = "Amount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(182, 494);
            label8.Name = "label8";
            label8.Size = new Size(111, 51);
            label8.TabIndex = 1;
            label8.Text = "Date";
            // 
            // cboStudentID
            // 
            cboStudentID.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            cboStudentID.FormattingEnabled = true;
            cboStudentID.Location = new Point(512, 168);
            cboStudentID.Name = "cboStudentID";
            cboStudentID.Size = new Size(411, 53);
            cboStudentID.TabIndex = 2;
            cboStudentID.SelectedIndexChanged += cboStudentID_SelectedIndexChanged;
            // 
            // cboCourseID
            // 
            cboCourseID.Enabled = false;
            cboCourseID.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            cboCourseID.FormattingEnabled = true;
            cboCourseID.Location = new Point(512, 231);
            cboCourseID.Name = "cboCourseID";
            cboCourseID.Size = new Size(411, 53);
            cboCourseID.TabIndex = 2;
            // 
            // txtBillNo
            // 
            txtBillNo.BorderStyle = BorderStyle.FixedSingle;
            txtBillNo.Enabled = false;
            txtBillNo.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBillNo.Location = new Point(512, 293);
            txtBillNo.Name = "txtBillNo";
            txtBillNo.Size = new Size(411, 53);
            txtBillNo.TabIndex = 3;
            // 
            // cboType
            // 
            cboType.Enabled = false;
            cboType.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "Registration", "Monthly" });
            cboType.Location = new Point(512, 355);
            cboType.Name = "cboType";
            cboType.Size = new Size(411, 53);
            cboType.TabIndex = 2;
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Enabled = false;
            txtAmount.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(512, 418);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(411, 53);
            txtAmount.TabIndex = 3;
            // 
            // txtDate
            // 
            txtDate.BorderStyle = BorderStyle.FixedSingle;
            txtDate.Enabled = false;
            txtDate.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDate.Location = new Point(512, 481);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(411, 53);
            txtDate.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(493, 630);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 71);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(298, 630);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(144, 71);
            btnBack.TabIndex = 4;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(691, 630);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(144, 71);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1096, 738);
            Controls.Add(btnClear);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(txtDate);
            Controls.Add(txtAmount);
            Controls.Add(txtBillNo);
            Controls.Add(cboType);
            Controls.Add(cboCourseID);
            Controls.Add(cboStudentID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "frmPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Record Payment Details";
            FormClosed += frmPayment_FormClosed;
            Load += frmPayment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private ComboBox cboStudentID;
        private ComboBox cboCourseID;
        private TextBox txtBillNo;
        private ComboBox cboType;
        private TextBox txtAmount;
        private TextBox txtDate;
        private Button btnSave;
        private Button btnBack;
        private Button btnClear;
    }
}