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
    public partial class frmGuesstheWord : Form
    {
        string playerName;

        public frmGuesstheWord(string name)
        {
            InitializeComponent();
            playerName = name;
        }

        private void frmGuesstheWord_Load(object sender, EventArgs e)
        {
            lblName.Text = playerName;
            lblTitle.Text = "Guess the Word";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmPlayGuesstheWord guess = new frmPlayGuesstheWord(playerName);
            guess.Show();
            this.Hide();
        }

        private void btnChangeGame_Click(object sender, EventArgs e)
        {
            frmGameChoice game = new frmGameChoice(playerName);
            game.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmExit exit = new frmExit();
            exit.Show();
            this.Hide();
        }
    }
}
