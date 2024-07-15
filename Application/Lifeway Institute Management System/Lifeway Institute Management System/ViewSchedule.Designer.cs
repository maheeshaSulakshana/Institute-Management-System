namespace Lifeway_Institute_Management_System
{
    partial class frmViewSchedule
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
            label1 = new Label();
            label2 = new Label();
            cboTime = new ComboBox();
            label3 = new Label();
            btnGetSchedule = new Button();
            listbox = new ListBox();
            cboDate = new ComboBox();
            btnBack = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(100, 120);
            label1.Name = "label1";
            label1.Size = new Size(67, 35);
            label1.TabIndex = 0;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(526, 117);
            label2.Name = "label2";
            label2.Size = new Size(69, 35);
            label2.TabIndex = 0;
            label2.Text = "Time";
            // 
            // cboTime
            // 
            cboTime.Font = new Font("Segoe UI", 15F);
            cboTime.FormattingEnabled = true;
            cboTime.Items.AddRange(new object[] { "8 - 10", "10 - 12", "12 - 2", "3 - 5" });
            cboTime.Location = new Point(661, 114);
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(192, 43);
            cboTime.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(427, 23);
            label3.Name = "label3";
            label3.Size = new Size(277, 51);
            label3.TabIndex = 3;
            label3.Text = "View Schedule";
            // 
            // btnGetSchedule
            // 
            btnGetSchedule.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGetSchedule.Location = new Point(925, 112);
            btnGetSchedule.Name = "btnGetSchedule";
            btnGetSchedule.Size = new Size(182, 48);
            btnGetSchedule.TabIndex = 4;
            btnGetSchedule.Text = "Get Schedule";
            btnGetSchedule.UseVisualStyleBackColor = true;
            btnGetSchedule.Click += btnGetSchedule_Click;
            // 
            // listbox
            // 
            listbox.FormattingEnabled = true;
            listbox.Items.AddRange(new object[] { "Student ID\t Course ID\t Day \tTime" });
            listbox.Location = new Point(30, 181);
            listbox.Name = "listbox";
            listbox.Size = new Size(1089, 544);
            listbox.TabIndex = 5;
            // 
            // cboDate
            // 
            cboDate.Font = new Font("Segoe UI", 15F);
            cboDate.FormattingEnabled = true;
            cboDate.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" });
            cboDate.Location = new Point(247, 117);
            cboDate.Name = "cboDate";
            cboDate.Size = new Size(192, 43);
            cboDate.TabIndex = 6;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(323, 747);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(168, 61);
            btnBack.TabIndex = 7;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(593, 747);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(168, 61);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmViewSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1131, 820);
            Controls.Add(btnClear);
            Controls.Add(btnBack);
            Controls.Add(cboDate);
            Controls.Add(listbox);
            Controls.Add(btnGetSchedule);
            Controls.Add(label3);
            Controls.Add(cboTime);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmViewSchedule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Schedule";
            FormClosed += frmViewSchedule_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboTime;
        private Label label3;
        private Button btnGetSchedule;
        private ListBox listbox;
        private ComboBox cboDate;
        private Button btnBack;
        private Button btnClear;
    }
}