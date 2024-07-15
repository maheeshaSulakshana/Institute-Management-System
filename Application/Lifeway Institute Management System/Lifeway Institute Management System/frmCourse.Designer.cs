namespace Lifeway_Institute_Management_System
{
    partial class frmCourse
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
            cboDuration = new ComboBox();
            cboName = new ComboBox();
            txtFee = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblID = new Label();
            btnGetDetails = new Button();
            btnClear = new Button();
            btnBack = new Button();
            btnSubmit = new Button();
            cboBatchID = new ComboBox();
            cboLecturerID = new ComboBox();
            cboID = new ComboBox();
            btnrefresh = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Ivory;
            panel1.Controls.Add(btnSelect);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnInsert);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1900, 239);
            panel1.TabIndex = 2;
            // 
            // btnSelect
            // 
            btnSelect.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelect.Location = new Point(1570, 122);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(194, 73);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Search";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1118, 122);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(194, 73);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(645, 122);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(194, 73);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(220, 122);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(194, 73);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(801, 30);
            label1.Name = "label1";
            label1.Size = new Size(335, 41);
            label1.TabIndex = 0;
            label1.Text = "Manage Course Details";
            // 
            // cboDuration
            // 
            cboDuration.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDuration.FormattingEnabled = true;
            cboDuration.Items.AddRange(new object[] { "3 Months", "6 Months", "12 Months" });
            cboDuration.Location = new Point(824, 467);
            cboDuration.Name = "cboDuration";
            cboDuration.Size = new Size(441, 49);
            cboDuration.TabIndex = 29;
            // 
            // cboName
            // 
            cboName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboName.FormattingEnabled = true;
            cboName.Location = new Point(824, 410);
            cboName.Name = "cboName";
            cboName.Size = new Size(441, 49);
            cboName.TabIndex = 27;
            // 
            // txtFee
            // 
            txtFee.BorderStyle = BorderStyle.FixedSingle;
            txtFee.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFee.Location = new Point(824, 528);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(441, 47);
            txtFee.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(517, 648);
            label7.Name = "label7";
            label7.Size = new Size(169, 41);
            label7.TabIndex = 18;
            label7.Text = "Lecturer ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(517, 591);
            label6.Name = "label6";
            label6.Size = new Size(133, 41);
            label6.TabIndex = 19;
            label6.Text = "Batch ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(517, 530);
            label5.Name = "label5";
            label5.Size = new Size(65, 41);
            label5.TabIndex = 20;
            label5.Text = "Fee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(517, 470);
            label4.Name = "label4";
            label4.Size = new Size(140, 41);
            label4.TabIndex = 21;
            label4.Text = "Duration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(517, 413);
            label3.Name = "label3";
            label3.Size = new Size(100, 41);
            label3.TabIndex = 22;
            label3.Text = "Name";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(517, 353);
            lblID.Name = "lblID";
            lblID.Size = new Size(152, 41);
            lblID.TabIndex = 23;
            lblID.Text = "Course ID";
            // 
            // btnGetDetails
            // 
            btnGetDetails.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGetDetails.Location = new Point(1662, 320);
            btnGetDetails.Name = "btnGetDetails";
            btnGetDetails.Size = new Size(212, 107);
            btnGetDetails.TabIndex = 33;
            btnGetDetails.Text = "Get Details";
            btnGetDetails.UseVisualStyleBackColor = true;
            btnGetDetails.Click += btnGetDetails_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(1662, 682);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(212, 107);
            btnClear.TabIndex = 30;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(79, 802);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(212, 107);
            btnBack.TabIndex = 31;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(1662, 802);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(212, 107);
            btnSubmit.TabIndex = 32;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // cboBatchID
            // 
            cboBatchID.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboBatchID.FormattingEnabled = true;
            cboBatchID.Location = new Point(824, 588);
            cboBatchID.Name = "cboBatchID";
            cboBatchID.Size = new Size(441, 49);
            cboBatchID.TabIndex = 35;
            cboBatchID.SelectedIndexChanged += cboBatchID_SelectedIndexChanged;
            // 
            // cboLecturerID
            // 
            cboLecturerID.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLecturerID.FormattingEnabled = true;
            cboLecturerID.Location = new Point(824, 648);
            cboLecturerID.Name = "cboLecturerID";
            cboLecturerID.Size = new Size(441, 49);
            cboLecturerID.TabIndex = 36;
            // 
            // cboID
            // 
            cboID.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboID.FormattingEnabled = true;
            cboID.Location = new Point(824, 345);
            cboID.Name = "cboID";
            cboID.Size = new Size(441, 49);
            cboID.TabIndex = 37;
            cboID.SelectedIndexChanged += cboID_SelectedIndexChanged;
            // 
            // btnrefresh
            // 
            btnrefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnrefresh.ForeColor = Color.FromArgb(128, 255, 128);
            btnrefresh.Location = new Point(1311, 588);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(86, 49);
            btnrefresh.TabIndex = 38;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Visible = false;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // frmCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnrefresh);
            Controls.Add(cboID);
            Controls.Add(cboLecturerID);
            Controls.Add(cboBatchID);
            Controls.Add(btnGetDetails);
            Controls.Add(btnClear);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(cboDuration);
            Controls.Add(cboName);
            Controls.Add(txtFee);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblID);
            Controls.Add(panel1);
            Name = "frmCourse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Course Details";
            WindowState = FormWindowState.Maximized;
            FormClosed += frmCourse_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnSelect;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Label label1;
        private ComboBox cboDuration;
        private ComboBox cboName;
        private TextBox txtFee;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblID;
        private Button btnGetDetails;
        private Button btnClear;
        private Button btnBack;
        private Button btnSubmit;
        private ComboBox cboBatchID;
        private ComboBox cboLecturerID;
        private ComboBox cboID;
        private Button btnrefresh;
    }
}