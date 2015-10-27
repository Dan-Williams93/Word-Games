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
    public partial class frmPlayerName : Form
    {
        public frmPlayerName()
        {
            InitializeComponent();
        }


        string playerUsername;

        private void btnEnter_Click(object sender, EventArgs e)
        {
            playerUsername = txtName.Text;

            if (playerUsername == "" || txtName.Text.Length > 8)
            {
                MessageBox.Show("Invalid user name!\n\nPlease enter a username no more than 8 characters long", "Error!");
            }
            else
            {
                frmGameChoice game = new frmGameChoice(playerUsername);
                game.Show();
                this.Hide();
            }
        }

        private void frmPlayerName_Load(object sender, EventArgs e)
        {
            lblText.Text = "Please input your name";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmExit exit = new frmExit();
            exit.Show();
            this.Hide();
        }
    }
}
