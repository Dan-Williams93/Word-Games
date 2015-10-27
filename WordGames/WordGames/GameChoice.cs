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
    public partial class frmGameChoice : Form
    {
        string playerName;

        public frmGameChoice(string name)
        {
            InitializeComponent();
            playerName = name;
        }

        private void frmGameChoice_Load(object sender, EventArgs e)
        {
            lblName.Text = "User: " + playerName;
            lblText.Text = "Please select an option";

            if (playerName == "admin" || playerName == "Admin")
            {
                radUpdateWords.Enabled = true;
            }
            else
            {
                radUpdateWords.Enabled = false;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            errorCheck();

            if(radConundrum.Checked == true)
            {
                frmConundrum conundrum = new frmConundrum(playerName);
                conundrum.Show();
                this.Hide();
            }

            if (radGuesstheWord.Checked == true)
            {
                frmGuesstheWord guess = new frmGuesstheWord(playerName);
                guess.Show();
                this.Hide();
            }

            if (radUpdateWords.Checked == true)
            {
                frmAdminLogin admin = new frmAdminLogin(playerName);
                admin.Show();
                this.Hide();
            }

            
        }

        public void errorCheck()
        {
            if (radConundrum.Checked == false && radGuesstheWord.Checked == false && radUpdateWords.Checked == false)
            {
                MessageBox.Show("Please select an option", "Error");
            }

            if ((radUpdateWords.Checked == true && radConundrum.Checked == true) || (radUpdateWords.Checked == true && radGuesstheWord.Checked == true))
            {
                MessageBox.Show("Please select one option", "Error");

                radConundrum.Checked = false;
                radGuesstheWord.Checked = false;
                radUpdateWords.Checked = false;
            }
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            frmExit exit = new frmExit();
            exit.Show();
            this.Hide();
        }
    }
}
