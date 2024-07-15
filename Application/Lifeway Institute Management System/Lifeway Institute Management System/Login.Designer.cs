namespace Lifeway_Institute_Management_System
{
    partial class frmLogin
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
            txtusername = new TextBox();
            txtpassword = new TextBox();
            btnLogin = new Button();
            btnClear = new Button();
            btnExit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 129);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 38);
            label1.Name = "label1";
            label1.Size = new Size(161, 38);
            label1.TabIndex = 0;
            label1.Text = "Login Page";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(194, 178);
            label2.Name = "label2";
            label2.Size = new Size(117, 31);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(194, 243);
            label3.Name = "label3";
            label3.Size = new Size(110, 31);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI", 13.8F);
            txtusername.Location = new Point(354, 175);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(209, 38);
            txtusername.TabIndex = 3;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 13.8F);
            txtpassword.Location = new Point(354, 240);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(209, 38);
            txtpassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 13.8F);
            btnLogin.Location = new Point(337, 343);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(119, 53);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 13.8F);
            btnClear.Location = new Point(491, 343);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 53);
            btnClear.TabIndex = 6;
            btnClear.Text = "clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 13.8F);
            btnExit.Location = new Point(170, 343);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(119, 53);
            btnExit.TabIndex = 7;
            btnExit.Text = "close";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 444);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Page";
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
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button btnLogin;
        private Button btnClear;
        private Button btnExit;
    }
}