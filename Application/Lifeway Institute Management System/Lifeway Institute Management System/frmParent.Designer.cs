namespace Lifeway_Institute_Management_System
{
    partial class frmParent
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
            txtname = new TextBox();
            label2 = new Label();
            txtaddress = new TextBox();
            label3 = new Label();
            txt_tel = new TextBox();
            label4 = new Label();
            btnSave = new Button();
            btnBack = new Button();
            btnClear = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 143);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(377, 40);
            label1.Name = "label1";
            label1.Size = new Size(209, 41);
            label1.TabIndex = 0;
            label1.Text = "Parent Details";
            // 
            // txtname
            // 
            txtname.BorderStyle = BorderStyle.FixedSingle;
            txtname.Location = new Point(493, 204);
            txtname.Name = "txtname";
            txtname.Size = new Size(332, 47);
            txtname.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(173, 207);
            label2.Name = "label2";
            label2.Size = new Size(197, 41);
            label2.TabIndex = 0;
            label2.Text = "Parent Name";
            // 
            // txtaddress
            // 
            txtaddress.BorderStyle = BorderStyle.FixedSingle;
            txtaddress.Location = new Point(493, 263);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(332, 47);
            txtaddress.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(173, 266);
            label3.Name = "label3";
            label3.Size = new Size(127, 41);
            label3.TabIndex = 0;
            label3.Text = "Address";
            // 
            // txt_tel
            // 
            txt_tel.BorderStyle = BorderStyle.FixedSingle;
            txt_tel.Location = new Point(493, 324);
            txt_tel.Name = "txt_tel";
            txt_tel.Size = new Size(332, 47);
            txt_tel.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(173, 327);
            label4.Name = "label4";
            label4.Size = new Size(208, 41);
            label4.TabIndex = 0;
            label4.Text = "Telephone No";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(432, 421);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 65);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(253, 421);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(138, 65);
            btnBack.TabIndex = 2;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(606, 421);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 65);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            btnClear.MouseClick += btnClear_MouseClick;
            // 
            // frmParent
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(960, 549);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(txt_tel);
            Controls.Add(label3);
            Controls.Add(txtaddress);
            Controls.Add(label2);
            Controls.Add(txtname);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "frmParent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parent Details";
            FormClosed += frmParent_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtname;
        private Label label2;
        private TextBox txtaddress;
        private Label label3;
        private TextBox txt_tel;
        private Label label4;
        private Button btnSave;
        private Button btnBack;
        private Button btnClear;
    }
}