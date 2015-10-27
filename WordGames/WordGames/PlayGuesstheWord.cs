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
    public partial class frmPlayGuesstheWord : Form 
    {
        string playerName;
        string[] words;
        string guess;
        string hiddenWord;

        int score = 0;
        int indexNum = 0;

        int numGuess = 10;

        public frmPlayGuesstheWord(string name)
        {
            InitializeComponent();
            playerName = name;

        }

        private void frmPlayGuesstheWord_Load(object sender, EventArgs e)
        {
            TextFile tf = new TextFile();
            tf.getTextFile();

            words = tf.text.Split(' ', '\n');
            
            lblName.Text = "User: " + playerName;
            lblNumGuess.Text = numGuess.ToString();
            lblScore.Text = "Score: " + score.ToString();

            if (words.ElementAt(indexNum) == "")
            {
                indexNum++;
            }

            hiddenWord = words.ElementAt(indexNum);
           
            writeNewWord(hiddenWord);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            guess = txtGuess.Text;
            setNewWord();

            if (numGuess == 0)
            {
                MessageBox.Show("You have run out of guesses", "Game Over");

                var playerChoice = MessageBox.Show("Congratulations " + playerName + " you scored " + score + "\nWould you like to play again?", "Game Over", MessageBoxButtons.YesNo);

                if (playerChoice == DialogResult.Yes)
                {
                    frmPlayGuesstheWord gw = new frmPlayGuesstheWord(playerName);
                    gw.Show();
                    this.Hide();
                }
                else
                {
                    frmGameChoice gameC = new frmGameChoice(playerName);
                    gameC.Show();
                    this.Hide();
                }
            }
        }

        public void setNewWord()
        {
            if (guess == words.ElementAt(indexNum))
            {            
                MessageBox.Show("Correct");
                indexNum++;
                txtGuess.Text = "";
                score++;
                lblWord.Text = "";
                               
                #region
                if (indexNum == words.LongLength -1)
                {
                    var userChoice = MessageBox.Show("You have completed Conundrum\nThere are no more words", "Congratulations", MessageBoxButtons.OK);

                    if (userChoice == DialogResult.OK)
                    {
                        var exitOption = MessageBox.Show("Congratulations " + playerName + " you scored " + score + "\nYou will be returned to the menu", "Congratulations", MessageBoxButtons.OK);

                        if (exitOption == DialogResult.OK)
                        {
                            frmGuesstheWord gtw = new frmGuesstheWord(playerName);
                            gtw.Show();
                            this.Hide();
                        }
                    }
                }
                #endregion
                else
                {
                    hiddenWord = words.ElementAt(indexNum);
                    writeNewWord(hiddenWord);
                    lblScore.Text = score.ToString();
                }
            }
            else
            {
                MessageBox.Show("Incorrect");
                txtGuess.Text = "";
                numGuess--;
                lblNumGuess.Text = numGuess.ToString();
            }
        }

        private void writeNewWord(string inString)
        {
            char[] chararray;
            string newString = "";
            int strLength;

            chararray = inString.ToCharArray();

            for (int i = 0; i < chararray.LongLength; i++)
            {
                if (i % 2 == 0)
                {
                    newString = newString + chararray[i] + " ";
                }
            }

            strLength = inString.Length;

            newString = newString.Replace(" ", "_");

            if (strLength % 2 == 1)
            {
                newString = newString.Remove(newString.Length - 1);
            }

            lblWord.Text = newString;
        }
    }
}
