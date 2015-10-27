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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            frmPlayerName name = new frmPlayerName();
            name.Show();
            this.Hide();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome to Word Games";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
