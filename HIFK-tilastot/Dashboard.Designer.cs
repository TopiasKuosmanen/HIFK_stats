namespace HIFK_tilastot
{
    partial class Dashboard
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
            this.AddingGame = new System.Windows.Forms.LinkLabel();
            this.AddingPlayer = new System.Windows.Forms.LinkLabel();
            this.LinkToFixtures = new System.Windows.Forms.LinkLabel();
            this.LinkToResults = new System.Windows.Forms.LinkLabel();
            this.LinkToPlayersAndStats = new System.Windows.Forms.LinkLabel();
            this.LinkToMore = new System.Windows.Forms.LinkLabel();
            this.LinkToGoals = new System.Windows.Forms.LinkLabel();
            this.LinkToOpponentsGoals = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // AddingGame
            // 
            this.AddingGame.Location = new System.Drawing.Point(0, 0);
            this.AddingGame.Name = "AddingGame";
            this.AddingGame.Size = new System.Drawing.Size(100, 23);
            this.AddingGame.TabIndex = 1;
            // 
            // AddingPlayer
            // 
            this.AddingPlayer.Location = new System.Drawing.Point(0, 0);
            this.AddingPlayer.Name = "AddingPlayer";
            this.AddingPlayer.Size = new System.Drawing.Size(100, 23);
            this.AddingPlayer.TabIndex = 0;
            // 
            // LinkToFixtures
            // 
            this.LinkToFixtures.AutoSize = true;
            this.LinkToFixtures.Location = new System.Drawing.Point(36, 28);
            this.LinkToFixtures.Name = "LinkToFixtures";
            this.LinkToFixtures.Size = new System.Drawing.Size(116, 32);
            this.LinkToFixtures.TabIndex = 12;
            this.LinkToFixtures.TabStop = true;
            this.LinkToFixtures.Text = "Fixtures";
            this.LinkToFixtures.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToFixtures_LinkClicked);
            // 
            // LinkToResults
            // 
            this.LinkToResults.AutoSize = true;
            this.LinkToResults.Location = new System.Drawing.Point(36, 78);
            this.LinkToResults.Name = "LinkToResults";
            this.LinkToResults.Size = new System.Drawing.Size(110, 32);
            this.LinkToResults.TabIndex = 13;
            this.LinkToResults.TabStop = true;
            this.LinkToResults.Text = "Results";
            this.LinkToResults.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToResults_LinkClicked);
            // 
            // LinkToPlayersAndStats
            // 
            this.LinkToPlayersAndStats.AutoSize = true;
            this.LinkToPlayersAndStats.Location = new System.Drawing.Point(36, 128);
            this.LinkToPlayersAndStats.Name = "LinkToPlayersAndStats";
            this.LinkToPlayersAndStats.Size = new System.Drawing.Size(183, 32);
            this.LinkToPlayersAndStats.TabIndex = 14;
            this.LinkToPlayersAndStats.TabStop = true;
            this.LinkToPlayersAndStats.Text = "Players/Stats";
            this.LinkToPlayersAndStats.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToPlayersAndStats_LinkClicked);
            // 
            // LinkToMore
            // 
            this.LinkToMore.AutoSize = true;
            this.LinkToMore.Location = new System.Drawing.Point(36, 278);
            this.LinkToMore.Name = "LinkToMore";
            this.LinkToMore.Size = new System.Drawing.Size(79, 32);
            this.LinkToMore.TabIndex = 15;
            this.LinkToMore.TabStop = true;
            this.LinkToMore.Text = "More";
            this.LinkToMore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToMore_LinkClicked);
            // 
            // LinkToGoals
            // 
            this.LinkToGoals.AutoSize = true;
            this.LinkToGoals.Location = new System.Drawing.Point(36, 178);
            this.LinkToGoals.Name = "LinkToGoals";
            this.LinkToGoals.Size = new System.Drawing.Size(90, 32);
            this.LinkToGoals.TabIndex = 16;
            this.LinkToGoals.TabStop = true;
            this.LinkToGoals.Text = "Goals";
            this.LinkToGoals.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToGoals_LinkClicked);
            // 
            // LinkToOpponentsGoals
            // 
            this.LinkToOpponentsGoals.AutoSize = true;
            this.LinkToOpponentsGoals.Location = new System.Drawing.Point(36, 228);
            this.LinkToOpponentsGoals.Name = "LinkToOpponentsGoals";
            this.LinkToOpponentsGoals.Size = new System.Drawing.Size(231, 32);
            this.LinkToOpponentsGoals.TabIndex = 17;
            this.LinkToOpponentsGoals.TabStop = true;
            this.LinkToOpponentsGoals.Text = "Opponents goals";
            this.LinkToOpponentsGoals.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToOpponentsGoals_LinkClicked);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 322);
            this.Controls.Add(this.LinkToOpponentsGoals);
            this.Controls.Add(this.LinkToGoals);
            this.Controls.Add(this.LinkToMore);
            this.Controls.Add(this.LinkToPlayersAndStats);
            this.Controls.Add(this.LinkToResults);
            this.Controls.Add(this.LinkToFixtures);
            this.Controls.Add(this.AddingPlayer);
            this.Controls.Add(this.AddingGame);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "HIFK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel AddingGame;
        private System.Windows.Forms.LinkLabel AddingPlayer;
        private System.Windows.Forms.LinkLabel LinkToFixtures;
        private System.Windows.Forms.LinkLabel LinkToResults;
        private System.Windows.Forms.LinkLabel LinkToPlayersAndStats;
        private System.Windows.Forms.LinkLabel LinkToMore;
        private System.Windows.Forms.LinkLabel LinkToGoals;
        private System.Windows.Forms.LinkLabel LinkToOpponentsGoals;
    }
}

