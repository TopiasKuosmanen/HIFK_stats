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
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerNameText = new System.Windows.Forms.TextBox();
            this.PlayerStats = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.PersonfoundlistBox = new System.Windows.Forms.ListBox();
            this.PlayersStatsView = new System.Windows.Forms.DataGridView();
            this.toExcel = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AllOpponents = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.birtdayDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersStatsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birtdayDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Player";
            // 
            // PlayerNameText
            // 
            this.PlayerNameText.Location = new System.Drawing.Point(386, 65);
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
            this.PlayerStats.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(419, 165);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(118, 47);
            this.searchButton.TabIndex = 21;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            // PlayersStatsView
            // 
            this.PlayersStatsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayersStatsView.Location = new System.Drawing.Point(25, 221);
            this.PlayersStatsView.Name = "PlayersStatsView";
            this.PlayersStatsView.RowTemplate.Height = 24;
            this.PlayersStatsView.Size = new System.Drawing.Size(1542, 300);
            this.PlayersStatsView.TabIndex = 24;
            // 
            // toExcel
            // 
            this.toExcel.Location = new System.Drawing.Point(1364, 527);
            this.toExcel.Name = "toExcel";
            this.toExcel.Size = new System.Drawing.Size(203, 55);
            this.toExcel.TabIndex = 27;
            this.toExcel.Text = "Export to Excel";
            this.toExcel.UseVisualStyleBackColor = true;
            this.toExcel.Click += new System.EventHandler(this.toExcel_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(25, 527);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1333, 53);
            this.progressBar.TabIndex = 28;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(573, 594);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(110, 17);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "Processing...0%";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "All"});
            this.listBox1.Location = new System.Drawing.Point(25, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(123, 148);
            this.listBox1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "League";
            // 
            // AllOpponents
            // 
            this.AllOpponents.AutoSize = true;
            this.AllOpponents.Location = new System.Drawing.Point(168, 8);
            this.AllOpponents.Name = "AllOpponents";
            this.AllOpponents.Size = new System.Drawing.Size(88, 21);
            this.AllOpponents.TabIndex = 33;
            this.AllOpponents.Text = "Select All";
            this.AllOpponents.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(656, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 34;
            // 
            // birtdayDataGridView
            // 
            this.birtdayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.birtdayDataGridView.Location = new System.Drawing.Point(644, 55);
            this.birtdayDataGridView.Name = "birtdayDataGridView";
            this.birtdayDataGridView.RowTemplate.Height = 24;
            this.birtdayDataGridView.Size = new System.Drawing.Size(923, 157);
            this.birtdayDataGridView.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(677, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Testi";
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 621);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.birtdayDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AllOpponents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.toExcel);
            this.Controls.Add(this.PlayersStatsView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.PersonfoundlistBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerNameText);
            this.Controls.Add(this.PlayerStats);
            this.Name = "Players";
            this.Text = "Players";
            ((System.ComponentModel.ISupportInitialize)(this.PlayersStatsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birtdayDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PlayerNameText;
        private System.Windows.Forms.ListBox PlayerStats;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox PersonfoundlistBox;
        private System.Windows.Forms.DataGridView PlayersStatsView;
        private System.Windows.Forms.Button toExcel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AllOpponents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView birtdayDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}