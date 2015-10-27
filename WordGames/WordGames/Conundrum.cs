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
    public partial class frmConundrum : Form
    {
        string playerName;

        public frmConundrum(string name)
        {
            InitializeComponent();
            playerName = name;
        }

        private void frmConundrum_Load(object sender, EventArgs e)
        {
            lblConundrum.Text = "Conundrum";
            lblPlayer.Text = "User: " + playerName;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmPlayConundrum play = new frmPlayConundrum(playerName);
            play.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmExit exit = new frmExit();
            exit.Show();
            this.Hide();
        }

        private void btnChangeGame_Click(object sender, EventArgs e)
        {
            frmGameChoice gc = new frmGameChoice(playerName);
            gc.Show();
            this.Hide();
        }
    }
}
