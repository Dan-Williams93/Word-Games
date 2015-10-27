using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordGames
{
    public partial class frmAdminLogin : Form
    {
        string username;

        public frmAdminLogin(string name)
        {
            InitializeComponent();
            username = name;
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            txtUser.Text = username;
            lblText.Text = "Please enter your login details";
            lblUser.Text = "Username";
            lblPass.Text = "Password";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUser.Text == "admin" || txtUser.Text == "Admin") && (txtPass.Text == "password" || txtPass.Text == "Password"))
            {
                frmUpdateWords update = new frmUpdateWords();
                update.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid log in\nPLease try again", "Invalid Log In");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmGameChoice choice = new frmGameChoice(username);
            choice.Show();
            this.Hide();
        }
    }
}
