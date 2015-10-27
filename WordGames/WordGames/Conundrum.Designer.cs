namespace WordGames
{
    partial class frmConundrum
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnChangeGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblConundrum = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(85, 83);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(105, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnChangeGame
            // 
            this.btnChangeGame.Location = new System.Drawing.Point(85, 112);
            this.btnChangeGame.Name = "btnChangeGame";
            this.btnChangeGame.Size = new System.Drawing.Size(105, 23);
            this.btnChangeGame.TabIndex = 1;
            this.btnChangeGame.Text = "Change Game";
            this.btnChangeGame.UseVisualStyleBackColor = true;
            this.btnChangeGame.Click += new System.EventHandler(this.btnChangeGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(85, 141);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblConundrum
            // 
            this.lblConundrum.AutoSize = true;
            this.lblConundrum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConundrum.Location = new System.Drawing.Point(80, 43);
            this.lblConundrum.Name = "lblConundrum";
            this.lblConundrum.Size = new System.Drawing.Size(60, 24);
            this.lblConundrum.TabIndex = 3;
            this.lblConundrum.Text = "label1";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(12, 9);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(35, 13);
            this.lblPlayer.TabIndex = 4;
            this.lblPlayer.Text = "label1";
            // 
            // frmConundrum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblConundrum);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangeGame);
            this.Controls.Add(this.btnPlay);
            this.Name = "frmConundrum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conundrum";
            this.Load += new System.EventHandler(this.frmConundrum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnChangeGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblConundrum;
        private System.Windows.Forms.Label lblPlayer;
    }
}