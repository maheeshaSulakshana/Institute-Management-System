namespace Lifeway_Institute_Management_System
{
    partial class frmStudent
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
            lblID = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txttitle = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txt_NIC = new TextBox();
            txt_address = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txt_tel = new TextBox();
            btnSubmit = new Button();
            btnClear = new Button();
            btnBack = new Button();
            cbogender = new ComboBox();
            cbo_Parent = new ComboBox();
            txtdob = new TextBox();
            txtRegistrationDate = new TextBox();
            btnGetDetails = new Button();
            cboID = new ComboBox();
            cbo_firstname = new ComboBox();
            cbo_surname = new ComboBox();
            btnrefresh = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(btnSelect);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnInsert);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1900, 239);
            panel1.TabIndex = 0;
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
            label1.Size = new Size(347, 41);
            label1.TabIndex = 0;
            label1.Text = "Manage Student Details";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(610, 317);
            lblID.Name = "lblID";
            lblID.Size = new Size(164, 41);
            lblID.TabIndex = 1;
            lblID.Text = "Student ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(610, 377);
            label3.Name = "label3";
            label3.Size = new Size(166, 41);
            label3.TabIndex = 1;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(610, 437);
            label4.Name = "label4";
            label4.Size = new Size(153, 41);
            label4.TabIndex = 1;
            label4.Text = "Sur Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(610, 497);
            label5.Name = "label5";
            label5.Size = new Size(78, 41);
            label5.TabIndex = 1;
            label5.Text = "Title";
            // 
            // txttitle
            // 
            txttitle.BorderStyle = BorderStyle.FixedSingle;
            txttitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttitle.Location = new Point(929, 491);
            txttitle.Name = "txttitle";
            txttitle.Size = new Size(434, 47);
            txttitle.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(610, 557);
            label6.Name = "label6";
            label6.Size = new Size(118, 41);
            label6.TabIndex = 1;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(610, 617);
            label7.Name = "label7";
            label7.Size = new Size(81, 41);
            label7.TabIndex = 1;
            label7.Text = "DOB";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(610, 677);
            label8.Name = "label8";
            label8.Size = new Size(69, 41);
            label8.TabIndex = 1;
            label8.Text = "NIC";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(610, 737);
            label9.Name = "label9";
            label9.Size = new Size(127, 41);
            label9.TabIndex = 1;
            label9.Text = "Address";
            // 
            // txt_NIC
            // 
            txt_NIC.BorderStyle = BorderStyle.FixedSingle;
            txt_NIC.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_NIC.Location = new Point(929, 671);
            txt_NIC.Name = "txt_NIC";
            txt_NIC.Size = new Size(434, 47);
            txt_NIC.TabIndex = 2;
            // 
            // txt_address
            // 
            txt_address.BorderStyle = BorderStyle.FixedSingle;
            txt_address.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_address.Location = new Point(929, 731);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(434, 47);
            txt_address.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(610, 797);
            label10.Name = "label10";
            label10.Size = new Size(208, 41);
            label10.TabIndex = 1;
            label10.Text = "Telephone No";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(610, 857);
            label11.Name = "label11";
            label11.Size = new Size(257, 41);
            label11.TabIndex = 1;
            label11.Text = "Registration Date";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(610, 917);
            label12.Name = "label12";
            label12.Size = new Size(197, 41);
            label12.TabIndex = 1;
            label12.Text = "Parent Name";
            // 
            // txt_tel
            // 
            txt_tel.BorderStyle = BorderStyle.FixedSingle;
            txt_tel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_tel.Location = new Point(929, 791);
            txt_tel.Name = "txt_tel";
            txt_tel.Size = new Size(434, 47);
            txt_tel.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(1662, 851);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(212, 107);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(1662, 731);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(212, 107);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(56, 851);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(212, 107);
            btnBack.TabIndex = 3;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // cbogender
            // 
            cbogender.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbogender.FormattingEnabled = true;
            cbogender.Items.AddRange(new object[] { "Male", "Female" });
            cbogender.Location = new Point(929, 554);
            cbogender.Name = "cbogender";
            cbogender.Size = new Size(434, 49);
            cbogender.TabIndex = 4;
            cbogender.SelectedIndexChanged += cbogender_SelectedIndexChanged;
            // 
            // cbo_Parent
            // 
            cbo_Parent.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbo_Parent.FormattingEnabled = true;
            cbo_Parent.Items.AddRange(new object[] { "Jimmy" });
            cbo_Parent.Location = new Point(929, 914);
            cbo_Parent.Name = "cbo_Parent";
            cbo_Parent.Size = new Size(434, 49);
            cbo_Parent.TabIndex = 5;
            cbo_Parent.SelectedIndexChanged += cbo_Parent_SelectedIndexChanged;
            // 
            // txtdob
            // 
            txtdob.BorderStyle = BorderStyle.FixedSingle;
            txtdob.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdob.Location = new Point(929, 614);
            txtdob.Name = "txtdob";
            txtdob.Size = new Size(434, 47);
            txtdob.TabIndex = 2;
            // 
            // txtRegistrationDate
            // 
            txtRegistrationDate.BorderStyle = BorderStyle.FixedSingle;
            txtRegistrationDate.Enabled = false;
            txtRegistrationDate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegistrationDate.Location = new Point(929, 851);
            txtRegistrationDate.Name = "txtRegistrationDate";
            txtRegistrationDate.Size = new Size(434, 47);
            txtRegistrationDate.TabIndex = 2;
            // 
            // btnGetDetails
            // 
            btnGetDetails.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGetDetails.Location = new Point(1662, 369);
            btnGetDetails.Name = "btnGetDetails";
            btnGetDetails.Size = new Size(212, 107);
            btnGetDetails.TabIndex = 6;
            btnGetDetails.Text = "Get Details";
            btnGetDetails.UseVisualStyleBackColor = true;
            btnGetDetails.Click += btnGetDetails_Click;
            // 
            // cboID
            // 
            cboID.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboID.FormattingEnabled = true;
            cboID.Items.AddRange(new object[] { "Jimmy" });
            cboID.Location = new Point(929, 309);
            cboID.Name = "cboID";
            cboID.Size = new Size(434, 49);
            cboID.TabIndex = 7;
            cboID.SelectedIndexChanged += cboID_SelectedIndexChanged;
            // 
            // cbo_firstname
            // 
            cbo_firstname.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbo_firstname.FormattingEnabled = true;
            cbo_firstname.Items.AddRange(new object[] { "Jimmy" });
            cbo_firstname.Location = new Point(929, 369);
            cbo_firstname.Name = "cbo_firstname";
            cbo_firstname.Size = new Size(434, 49);
            cbo_firstname.TabIndex = 8;
            cbo_firstname.SelectedIndexChanged += cbo_firstname_SelectedIndexChanged;
            // 
            // cbo_surname
            // 
            cbo_surname.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbo_surname.FormattingEnabled = true;
            cbo_surname.Items.AddRange(new object[] { "Jimmy" });
            cbo_surname.Location = new Point(929, 429);
            cbo_surname.Name = "cbo_surname";
            cbo_surname.Size = new Size(434, 49);
            cbo_surname.TabIndex = 8;
            cbo_surname.SelectedIndexChanged += cbo_surname_SelectedIndexChanged;
            // 
            // btnrefresh
            // 
            btnrefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnrefresh.ForeColor = Color.FromArgb(128, 255, 128);
            btnrefresh.Location = new Point(1396, 914);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(86, 49);
            btnrefresh.TabIndex = 9;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Visible = false;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // frmStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnrefresh);
            Controls.Add(cbo_surname);
            Controls.Add(cbo_firstname);
            Controls.Add(cboID);
            Controls.Add(btnGetDetails);
            Controls.Add(cbo_Parent);
            Controls.Add(cbogender);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(txt_address);
            Controls.Add(txttitle);
            Controls.Add(txt_NIC);
            Controls.Add(txtRegistrationDate);
            Controls.Add(txt_tel);
            Controls.Add(txtdob);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(lblID);
            Controls.Add(panel1);
            Name = "frmStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Student Details";
            WindowState = FormWindowState.Maximized;
            FormClosed += frmStudent_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnInsert;
        private Label label1;
        private Button btnSelect;
        private Button btnDelete;
        private Button btnUpdate;
        private Label lblID;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txttitle;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txt_NIC;
        private TextBox txt_address;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txt_tel;
        private Button btnSubmit;
        private Button btnClear;
        private Button btnBack;
        private ComboBox cbogender;
        private ComboBox cbo_Parent;
        private TextBox txtdob;
        private TextBox txtRegistrationDate;
        private Button btnGetDetails;
        private ComboBox cboID;
        private ComboBox cbo_firstname;
        private ComboBox cbo_surname;
        private Button btnrefresh;
    }
}