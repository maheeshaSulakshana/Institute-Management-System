namespace Lifeway_Institute_Management_System
{
    partial class frmNotes
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
            txtFile = new TextBox();
            cboPath = new ComboBox();
            btnSave = new Button();
            btnBack = new Button();
            btnClear = new Button();
            FileDialog = new OpenFileDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 143);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(355, 35);
            label1.Name = "label1";
            label1.Size = new Size(396, 51);
            label1.TabIndex = 0;
            label1.Text = "Store Lecture Notes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 198);
            label2.Name = "label2";
            label2.Size = new Size(389, 51);
            label2.TabIndex = 2;
            label2.Text = "Lecture Note Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 294);
            label3.Name = "label3";
            label3.Size = new Size(365, 51);
            label3.TabIndex = 2;
            label3.Text = "Lecture Note Path";
            // 
            // txtFile
            // 
            txtFile.BorderStyle = BorderStyle.FixedSingle;
            txtFile.Enabled = false;
            txtFile.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFile.Location = new Point(633, 202);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(349, 47);
            txtFile.TabIndex = 3;
            // 
            // cboPath
            // 
            cboPath.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboPath.FormattingEnabled = true;
            cboPath.Items.AddRange(new object[] { "Please select the note to store" });
            cboPath.Location = new Point(483, 298);
            cboPath.Name = "cboPath";
            cboPath.Size = new Size(499, 49);
            cboPath.TabIndex = 4;
            cboPath.Text = "Please select the note to store";
            cboPath.MouseClick += cboPath_MouseClick;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(467, 414);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(185, 84);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(219, 414);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(185, 84);
            btnBack.TabIndex = 5;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(704, 414);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(185, 84);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmNotes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1111, 549);
            Controls.Add(btnClear);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(cboPath);
            Controls.Add(txtFile);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "frmNotes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Store Lecture Notes";
            FormClosed += frmNotes_FormClosed;
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
        private TextBox txtFile;
        private ComboBox cboPath;
        private Button btnSave;
        private Button btnBack;
        private Button btnClear;
        private OpenFileDialog FileDialog;
    }
}