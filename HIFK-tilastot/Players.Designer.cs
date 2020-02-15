namespace HIFK_tilastot
{
    partial class Players
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
            this.SelectLeague = new System.Windows.Forms.ComboBox();
            this.TopScorers = new System.Windows.Forms.CheckBox();
            this.searchPlayerStats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerNameText = new System.Windows.Forms.TextBox();
            this.PlayerStats = new System.Windows.Forms.ListBox();
            this.NoPlayers = new System.Windows.Forms.CheckBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.PersonfoundlistBox = new System.Windows.Forms.ListBox();
            this.SelectYear = new System.Windows.Forms.ComboBox();
            this.PlayersStatsView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersStatsView)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectLeague
            // 
            this.SelectLeague.FormattingEnabled = true;
            this.SelectLeague.Items.AddRange(new object[] {
            "All",
            "Veikkausliiga",
            "Suomen Cup",
            "Friendly"});
            this.SelectLeague.Location = new System.Drawing.Point(45, 22);
            this.SelectLeague.Name = "SelectLeague";
            this.SelectLeague.Size = new System.Drawing.Size(191, 24);
            this.SelectLeague.TabIndex = 17;
            this.SelectLeague.Text = "Select league";
            // 
            // TopScorers
            // 
            this.TopScorers.AutoSize = true;
            this.TopScorers.Location = new System.Drawing.Point(341, 145);
            this.TopScorers.Name = "TopScorers";
            this.TopScorers.Size = new System.Drawing.Size(106, 21);
            this.TopScorers.TabIndex = 16;
            this.TopScorers.Text = "Top scorers";
            this.TopScorers.UseVisualStyleBackColor = true;
            this.TopScorers.CheckedChanged += new System.EventHandler(this.TopScorers_CheckedChanged);
            // 
            // searchPlayerStats
            // 
            this.searchPlayerStats.Location = new System.Drawing.Point(166, 131);
            this.searchPlayerStats.Name = "searchPlayerStats";
            this.searchPlayerStats.Size = new System.Drawing.Size(126, 47);
            this.searchPlayerStats.TabIndex = 15;
            this.searchPlayerStats.Text = "Search player";
            this.searchPlayerStats.UseVisualStyleBackColor = true;
            this.searchPlayerStats.Click += new System.EventHandler(this.searchPlayerStats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Player";
            // 
            // PlayerNameText
            // 
            this.PlayerNameText.Location = new System.Drawing.Point(166, 90);
            this.PlayerNameText.Name = "PlayerNameText";
            this.PlayerNameText.Size = new System.Drawing.Size(232, 22);
            this.PlayerNameText.TabIndex = 13;
            // 
            // PlayerStats
            // 
            this.PlayerStats.FormattingEnabled = true;
            this.PlayerStats.ItemHeight = 16;
            this.PlayerStats.Location = new System.Drawing.Point(12, 218);
            this.PlayerStats.Name = "PlayerStats";
            this.PlayerStats.Size = new System.Drawing.Size(525, 276);
            this.PlayerStats.TabIndex = 12;
            // 
            // NoPlayers
            // 
            this.NoPlayers.AutoSize = true;
            this.NoPlayers.Location = new System.Drawing.Point(330, 171);
            this.NoPlayers.Name = "NoPlayers";
            this.NoPlayers.Size = new System.Drawing.Size(98, 21);
            this.NoPlayers.TabIndex = 22;
            this.NoPlayers.Text = "No players";
            this.NoPlayers.UseVisualStyleBackColor = true;
            this.NoPlayers.Visible = false;
            this.NoPlayers.CheckedChanged += new System.EventHandler(this.NoPlayers_CheckedChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(176, 165);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(118, 47);
            this.searchButton.TabIndex = 21;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Visible = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(72, 107);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(45, 17);
            this.LastNameLabel.TabIndex = 20;
            this.LastNameLabel.Text = "Name";
            this.LastNameLabel.Visible = false;
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(176, 107);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(232, 22);
            this.LastNameText.TabIndex = 19;
            this.LastNameText.Visible = false;
            // 
            // PersonfoundlistBox
            // 
            this.PersonfoundlistBox.FormattingEnabled = true;
            this.PersonfoundlistBox.ItemHeight = 16;
            this.PersonfoundlistBox.Location = new System.Drawing.Point(78, 230);
            this.PersonfoundlistBox.Name = "PersonfoundlistBox";
            this.PersonfoundlistBox.Size = new System.Drawing.Size(395, 276);
            this.PersonfoundlistBox.TabIndex = 18;
            this.PersonfoundlistBox.Visible = false;
            // 
            // SelectYear
            // 
            this.SelectYear.FormattingEnabled = true;
            this.SelectYear.Items.AddRange(new object[] {
            "All",
            "2019",
            "2020"});
            this.SelectYear.Location = new System.Drawing.Point(45, 52);
            this.SelectYear.Name = "SelectYear";
            this.SelectYear.Size = new System.Drawing.Size(191, 24);
            this.SelectYear.TabIndex = 23;
            this.SelectYear.Text = "Select year";
            // 
            // PlayersStatsView
            // 
            this.PlayersStatsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayersStatsView.Location = new System.Drawing.Point(587, 221);
            this.PlayersStatsView.Name = "PlayersStatsView";
            this.PlayersStatsView.RowTemplate.Height = 24;
            this.PlayersStatsView.Size = new System.Drawing.Size(488, 273);
            this.PlayersStatsView.TabIndex = 24;
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 655);
            this.Controls.Add(this.PlayersStatsView);
            this.Controls.Add(this.SelectYear);
            this.Controls.Add(this.NoPlayers);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.PersonfoundlistBox);
            this.Controls.Add(this.SelectLeague);
            this.Controls.Add(this.TopScorers);
            this.Controls.Add(this.searchPlayerStats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerNameText);
            this.Controls.Add(this.PlayerStats);
            this.Name = "Players";
            this.Text = "Players";
            ((System.ComponentModel.ISupportInitialize)(this.PlayersStatsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectLeague;
        private System.Windows.Forms.CheckBox TopScorers;
        private System.Windows.Forms.Button searchPlayerStats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PlayerNameText;
        private System.Windows.Forms.ListBox PlayerStats;
        private System.Windows.Forms.CheckBox NoPlayers;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.ListBox PersonfoundlistBox;
        private System.Windows.Forms.ComboBox SelectYear;
        private System.Windows.Forms.DataGridView PlayersStatsView;
    }
}