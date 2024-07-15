namespace Lifeway_Institute_Management_System
{
    partial class frmViewAttendance
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
            dateTime = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            listbox = new ListBox();
            btnClear = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // dateTime
            // 
            dateTime.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTime.Format = DateTimePickerFormat.Short;
            dateTime.Location = new Point(453, 109);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(461, 47);
            dateTime.TabIndex = 0;
            dateTime.ValueChanged += dateTime_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 115);
            label1.Name = "label1";
            label1.Size = new Size(167, 41);
            label1.TabIndex = 1;
            label1.Text = "Select Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(410, 24);
            label2.Name = "label2";
            label2.Size = new Size(285, 47);
            label2.TabIndex = 2;
            label2.Text = "View Attendance";
            // 
            // listbox
            // 
            listbox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listbox.FormattingEnabled = true;
            listbox.ItemHeight = 25;
            listbox.Items.AddRange(new object[] { "StudentID\t CourseID \tDate\t\t Time" });
            listbox.Location = new Point(53, 188);
            listbox.Name = "listbox";
            listbox.Size = new Size(1011, 529);
            listbox.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(655, 741);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(188, 54);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(258, 741);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(188, 54);
            btnBack.TabIndex = 5;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmViewAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1098, 814);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(listbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTime);
            Name = "frmViewAttendance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Attendance";
            FormClosed += frmViewAttendance_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTime;
        private Label label1;
        private Label label2;
        private ListBox listbox;
        private Button btnClear;
        private Button btnBack;
    }
}