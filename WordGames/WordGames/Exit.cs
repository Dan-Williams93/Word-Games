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
    public partial class frmExit : Form
    {
        public frmExit()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Exit_Load(object sender, EventArgs e)
        {
            lblExit.Text = "Thank you for playing\nWord Games";
        }
    }
}
