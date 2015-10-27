namespace WordGames
{
    partial class frmPlayGuesstheWord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblNumGuess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(122, 64);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(0, 24);
            this.lblWord.TabIndex = 1;
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(93, 114);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 20);
            this.txtGuess.TabIndex = 2;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(106, 165);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(228, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "label1";
            // 
            // lblNumGuess
            // 
            this.lblNumGuess.AutoSize = true;
            this.lblNumGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumGuess.Location = new System.Drawing.Point(123, 13);
            this.lblNumGuess.Name = "lblNumGuess";
            this.lblNumGuess.Size = new System.Drawing.Size(46, 17);
            this.lblNumGuess.TabIndex = 5;
            this.lblNumGuess.Text = "label1";
            // 
            // frmPlayGuesstheWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.lblNumGuess);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblName);
            this.Name = "frmPlayGuesstheWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayGuesstheWord";
            this.Load += new System.EventHandler(this.frmPlayGuesstheWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblNumGuess;
    }
}