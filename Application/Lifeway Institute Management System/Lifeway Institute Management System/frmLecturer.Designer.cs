namespace Lifeway_Institute_Management_System
{
    partial class frmLecturer
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
            btnGetDetails = new Button();
            btnClear = new Button();
            btnSubmit = new Button();
            btnBack = new Button();
            lblID = new Label();
            cboID = new ComboBox();
            label3 = new Label();
            cboTitle = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txtdob = new TextBox();
            label6 = new Label();
            txtNIC = new TextBox();
            label7 = new Label();
            txtaddress = new TextBox();
            label8 = new Label();
            txt_tel = new TextBox();
            cboName = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Pink;
            panel1.Controls.Add(btnSelect);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnInsert);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1900, 239);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
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
            label1.Size = new Size(352, 41);
            label1.TabIndex = 0;
            label1.Text = "Manage Lecturer Details";
            // 
            // btnGetDetails
            // 
            btnGetDetails.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGetDetails.Location = new Point(1662, 320);
            btnGetDetails.Name = "btnGetDetails";
            btnGetDetails.Size = new Size(212, 107);
            btnGetDetails.TabIndex = 12;
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
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(1662, 802);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(212, 107);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(79, 802);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(212, 107);
            btnBack.TabIndex = 11;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(517, 353);
            lblID.Name = "lblID";
            lblID.Size = new Size(169, 41);
            lblID.TabIndex = 14;
            lblID.Text = "Lecturer ID";
            // 
            // cboID
            // 
            cboID.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboID.FormattingEnabled = true;
            cboID.Location = new Point(824, 350);
            cboID.Name = "cboID";
            cboID.Size = new Size(441, 49);
            cboID.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(517, 413);
            label3.Name = "label3";
            label3.Size = new Size(78, 41);
            label3.TabIndex = 14;
            label3.Text = "Title";
            // 
            // cboTitle
            // 
            cboTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTitle.FormattingEnabled = true;
            cboTitle.Items.AddRange(new object[] { "Mr.", "Miss.", "Mrs." });
            cboTitle.Location = new Point(824, 410);
            cboTitle.Name = "cboTitle";
            cboTitle.Size = new Size(441, 49);
            cboTitle.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(517, 470);
            label4.Name = "label4";
            label4.Size = new Size(100, 41);
            label4.TabIndex = 14;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(517, 530);
            label5.Name = "label5";
            label5.Size = new Size(81, 41);
            label5.TabIndex = 14;
            label5.Text = "DOB";
            // 
            // txtdob
            // 
            txtdob.BorderStyle = BorderStyle.FixedSingle;
            txtdob.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdob.Location = new Point(824, 528);
            txtdob.Name = "txtdob";
            txtdob.Size = new Size(441, 47);
            txtdob.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(517, 591);
            label6.Name = "label6";
            label6.Size = new Size(69, 41);
            label6.TabIndex = 14;
            label6.Text = "NIC";
            // 
            // txtNIC
            // 
            txtNIC.BorderStyle = BorderStyle.FixedSingle;
            txtNIC.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNIC.Location = new Point(824, 589);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(441, 47);
            txtNIC.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(517, 648);
            label7.Name = "label7";
            label7.Size = new Size(127, 41);
            label7.TabIndex = 14;
            label7.Text = "Address";
            // 
            // txtaddress
            // 
            txtaddress.BorderStyle = BorderStyle.FixedSingle;
            txtaddress.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtaddress.Location = new Point(824, 646);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(441, 47);
            txtaddress.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(517, 705);
            label8.Name = "label8";
            label8.Size = new Size(208, 41);
            label8.TabIndex = 14;
            label8.Text = "Telephone No";
            // 
            // txt_tel
            // 
            txt_tel.BorderStyle = BorderStyle.FixedSingle;
            txt_tel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_tel.Location = new Point(824, 703);
            txt_tel.Name = "txt_tel";
            txt_tel.Size = new Size(441, 47);
            txt_tel.TabIndex = 15;
            // 
            // cboName
            // 
            cboName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboName.FormattingEnabled = true;
            cboName.Items.AddRange(new object[] { "Mr.", "Miss.", "Mrs." });
            cboName.Location = new Point(824, 467);
            cboName.Name = "cboName";
            cboName.Size = new Size(441, 49);
            cboName.TabIndex = 17;
            // 
            // frmLecturer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1055);
            Controls.Add(cboName);
            Controls.Add(cboTitle);
            Controls.Add(cboID);
            Controls.Add(txt_tel);
            Controls.Add(txtaddress);
            Controls.Add(txtNIC);
            Controls.Add(txtdob);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblID);
            Controls.Add(btnGetDetails);
            Controls.Add(btnClear);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(panel1);
            Name = "frmLecturer";
            Text = "Manage Lecturer Details";
            WindowState = FormWindowState.Maximized;
            FormClosed += frmLecturer_FormClosed;
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
        private Button btnGetDetails;
        private Button btnClear;
        private Button btnSubmit;
        private Button btnBack;
        private Label lblID;
        private ComboBox cboID;
        private Label label3;
        private ComboBox cboTitle;
        private Label label4;
        private Label label5;
        private TextBox txtdob;
        private Label label6;
        private TextBox txtNIC;
        private Label label7;
        private TextBox txtaddress;
        private Label label8;
        private TextBox txt_tel;
        private ComboBox cboName;
    }
}