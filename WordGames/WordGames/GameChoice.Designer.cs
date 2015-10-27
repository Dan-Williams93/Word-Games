namespace WordGames
{
    partial class frmGameChoice
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radGuesstheWord = new System.Windows.Forms.RadioButton();
            this.radConundrum = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radUpdateWords = new System.Windows.Forms.RadioButton();
            this.lblText = new System.Windows.Forms.Label();
            this.txtExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(55, 215);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radGuesstheWord);
            this.groupBox1.Controls.Add(this.radConundrum);
            this.groupBox1.Location = new System.Drawing.Point(62, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Options";
            // 
            // radGuesstheWord
            // 
            this.radGuesstheWord.AutoSize = true;
            this.radGuesstheWord.Location = new System.Drawing.Point(6, 43);
            this.radGuesstheWord.Name = "radGuesstheWord";
            this.radGuesstheWord.Size = new System.Drawing.Size(102, 17);
            this.radGuesstheWord.TabIndex = 1;
            this.radGuesstheWord.TabStop = true;
            this.radGuesstheWord.Text = "Guess the Word";
            this.radGuesstheWord.UseVisualStyleBackColor = true;
            // 
            // radConundrum
            // 
            this.radConundrum.AutoSize = true;
            this.radConundrum.Location = new System.Drawing.Point(7, 20);
            this.radConundrum.Name = "radConundrum";
            this.radConundrum.Size = new System.Drawing.Size(79, 17);
            this.radConundrum.TabIndex = 0;
            this.radConundrum.TabStop = true;
            this.radConundrum.Text = "Conundrum";
            this.radConundrum.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radUpdateWords);
            this.groupBox2.Location = new System.Drawing.Point(62, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 67);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administrator Options";
            // 
            // radUpdateWords
            // 
            this.radUpdateWords.AutoSize = true;
            this.radUpdateWords.Location = new System.Drawing.Point(6, 19);
            this.radUpdateWords.Name = "radUpdateWords";
            this.radUpdateWords.Size = new System.Drawing.Size(94, 17);
            this.radUpdateWords.TabIndex = 2;
            this.radUpdateWords.TabStop = true;
            this.radUpdateWords.Text = "Update Words";
            this.radUpdateWords.UseVisualStyleBackColor = true;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(43, 36);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(51, 20);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "label1";
            // 
            // txtExit
            // 
            this.txtExit.Location = new System.Drawing.Point(147, 215);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(75, 23);
            this.txtExit.TabIndex = 5;
            this.txtExit.Text = "Exit";
            this.txtExit.UseVisualStyleBackColor = true;
            this.txtExit.Click += new System.EventHandler(this.txtExit_Click);
            // 
            // frmGameChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnEnter);
            this.Location = new System.Drawing.Point(500, 500);
            this.Name = "frmGameChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Choice";
            this.Load += new System.EventHandler(this.frmGameChoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radGuesstheWord;
        private System.Windows.Forms.RadioButton radConundrum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radUpdateWords;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button txtExit;
    }
}