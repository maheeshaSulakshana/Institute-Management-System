namespace Lifeway_Institute_Management_System
{
    partial class frmBatch
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
            cbo_AgeGroup = new ComboBox();
            cbo_ClassType = new ComboBox();
            btnBack = new Button();
            btnClear = new Button();
            btnSave = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 143);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(373, 40);
            label1.Name = "label1";
            label1.Size = new Size(158, 41);
            label1.TabIndex = 0;
            label1.Text = "Add Batch";
            // 
            // cbo_AgeGroup
            // 
            cbo_AgeGroup.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbo_AgeGroup.FormattingEnabled = true;
            cbo_AgeGroup.Items.AddRange(new object[] { "Grade 9", "Grade 10", "Grade 11", "Grade 12", "Grade 13", "External" });
            cbo_AgeGroup.Location = new Point(493, 337);
            cbo_AgeGroup.Name = "cbo_AgeGroup";
            cbo_AgeGroup.Size = new Size(332, 49);
            cbo_AgeGroup.TabIndex = 20;
            // 
            // cbo_ClassType
            // 
            cbo_ClassType.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbo_ClassType.FormattingEnabled = true;
            cbo_ClassType.Items.AddRange(new object[] { "Individual", "Group" });
            cbo_ClassType.Location = new Point(493, 275);
            cbo_ClassType.Name = "cbo_ClassType";
            cbo_ClassType.Size = new Size(332, 49);
            cbo_ClassType.TabIndex = 21;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 18F);
            btnBack.Location = new Point(253, 434);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(138, 65);
            btnBack.TabIndex = 17;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 18F);
            btnClear.Location = new Point(606, 434);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 65);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 18F);
            btnSave.Location = new Point(432, 434);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 65);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(173, 340);
            label4.Name = "label4";
            label4.Size = new Size(166, 41);
            label4.TabIndex = 13;
            label4.Text = "Age Group";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(173, 283);
            label3.Name = "label3";
            label3.Size = new Size(159, 41);
            label3.TabIndex = 14;
            label3.Text = "Class Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(173, 220);
            label2.Name = "label2";
            label2.Size = new Size(184, 41);
            label2.TabIndex = 15;
            label2.Text = "Batch Name";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 18F);
            txtName.Location = new Point(493, 218);
            txtName.Name = "txtName";
            txtName.Size = new Size(332, 47);
            txtName.TabIndex = 16;
            // 
            // frmBatch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(960, 549);
            Controls.Add(cbo_AgeGroup);
            Controls.Add(cbo_ClassType);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "frmBatch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Save Batch";
            FormClosed += frmBatch_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox cbo_AgeGroup;
        private ComboBox cbo_ClassType;
        private Button btnBack;
        private Button btnClear;
        private Button btnSave;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtName;
    }
}