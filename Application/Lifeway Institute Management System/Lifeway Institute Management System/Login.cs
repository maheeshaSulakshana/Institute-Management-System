using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lifeway_Institute_Management_System
{
    public partial class frmLogin : Form
    {
        private String username;
        private String password;
        private LoginDb logindb;
        public frmLogin()
        {
            InitializeComponent();
            this.username = "";
            this.password = "";
            logindb = new LoginDb();
        }
        public void clear()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                MessageBox.Show("Must enter username");
                return;
            }

            username = txtusername.Text;

            if (txtpassword.Text == "")
            {
                MessageBox.Show("Must enter password");
                return;
            }

            password = txtpassword.Text;

            if (logindb.check(username, password))
            {
                MessageBox.Show("Login Successfull");
                this.Hide();
                clear();
                frmHome frmHome = new frmHome(this);
                frmHome.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is invalid please try again");
                clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
