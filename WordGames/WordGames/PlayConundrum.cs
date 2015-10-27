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
    public partial class frmPlayConundrum : Form 
    {
        static string file = @"../../Words.txt";
        string text = File.ReadAllText(file);

        string playerName;
        string[] words;
        string guess;        
        string hiddenWord;

        int indexNum = 0;
        int score = 0;
        
        int time = 30;
        int shuffleTimes = 10;

        public frmPlayConundrum(string name)
        {
            InitializeComponent();
            playerName = name;
        }

        private void PlayConundrum_Load(object sender, EventArgs e)
        {
            TextFile tf = new TextFile();
            tf.getTextFile();

            words = tf.text.Split(' ', '\n');

            lblPlayer.Text = "User: " + playerName;
            lblTime.Text = time.ToString();
            lblScore.Text = "Score: " + score.ToString();

            if (words.ElementAt(indexNum) == "")
            {
                indexNum++;
            }

            hiddenWord = words.ElementAt(indexNum);

            lblWord.Text = shuffle(hiddenWord.ToCharArray(), shuffleTimes);

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            guess = txtGuess.Text;
            setNewWord();
        }

        public void setNewWord()
        {
            if (guess == words.ElementAt(indexNum))
            {
                timer1.Enabled = false;

                MessageBox.Show("Correct");
                indexNum++;
                txtGuess.Text = "";
                score++;
                time = 30;
                hiddenWord = words.ElementAt(indexNum);

                #region
                if (indexNum == words.LongLength -1)
                {
                    var userChoice = MessageBox.Show("You have completed Conundrum\nThere are no more words", "Congratulations", MessageBoxButtons.OK);

                    if (userChoice == DialogResult.OK)
                    {
                        var exitOption = MessageBox.Show("Congratulations " + playerName + " you scored " + score + "\nYou will be returned to the menu", "Congratulations", MessageBoxButtons.OK);

                        if (exitOption == DialogResult.OK)
                        {
                            frmConundrum con = new frmConundrum(playerName);
                            con.Show();
                            this.Hide();
                        }
                    }
                }
                #endregion
                else
                {
                    lblWord.Text = shuffle(hiddenWord.ToCharArray(), shuffleTimes);
                    timer1.Enabled = true;
                    lblScore.Text = score.ToString();
                }
            }
            else
            {
                MessageBox.Show("Incorrect");
                txtGuess.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time - 1;
            lblTime.Text = time.ToString();

            if (time <= 10)
            {
                lblTime.ForeColor = System.Drawing.Color.Red;
            }

            if (time == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("You have run out of time", "Game Over");

                var playerChoice = MessageBox.Show("Congratulations " + playerName + " you scored " + score + "\nWould you like to play again?", "Game Over", MessageBoxButtons.YesNo);

                if (playerChoice == DialogResult.Yes)
                {
                    frmPlayConundrum pCon = new frmPlayConundrum(playerName);
                    pCon.Show();
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

        static public string shuffle(char[] unshuffled, int amount)
        {
            Random randomNumber = new Random();

            char[] shuffled = unshuffled;
            char tempChar;
            int sourceChar = 0;
            int destChar = 0;

            for (int numShuffles = 0; numShuffles < amount; numShuffles++)
            {
                destChar = randomNumber.Next(0, shuffled.Length);
                sourceChar = randomNumber.Next(0, unshuffled.Length);
                tempChar = shuffled[destChar];
                shuffled[destChar] = unshuffled[sourceChar];
                unshuffled[sourceChar] = tempChar;
            }

            return new string(shuffled);
        }

    }
}
