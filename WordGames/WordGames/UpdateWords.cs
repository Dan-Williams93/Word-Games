using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WordGames
{
    public partial class frmUpdateWords : Form
    {
        string username = "admin";
        string[] words;
        string updateFile;

        //create new object of text file
        TextFile tf = new TextFile();

        public frmUpdateWords()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
        }

        private void frmUpdateWords_Load(object sender, EventArgs e)
        {   
            tf.getTextFile();

            words = tf.text.Split(' ', '\n');

            //remove blank string and adds present string to list box            
            foreach (string w in words)
            {
                if (w == "")
                {
                }
                else
                {
                    listBox1.Items.Add(w);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //adds text to listbox
            listBox1.Items.Add(txtAdd.Text);

            txtAdd.Text = "";
            btnUpdate.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //removes selected item
            listBox1.Items.Remove(listBox1.SelectedItem);

            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //clear text file
            File.WriteAllText(tf.file, "");

            //clear update file string
            updateFile = "";

            //adds each item within list box to update string
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("No items in listbox");
            }
            else
            {
                foreach (object o in listBox1.Items)
                {
                    updateFile += o + " ";
                }
            }

            //label1.Text = updateFile;

            //writes update to text file
            File.WriteAllText(tf.file, updateFile);
            btnUpdate.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmGameChoice choice = new frmGameChoice(username);
            choice.Show();
            this.Hide();
        }
    }
}
