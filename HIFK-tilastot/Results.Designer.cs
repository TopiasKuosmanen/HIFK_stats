namespace HIFK_tilastot
{
    partial class Results
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
            this.SearchResultsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultsBox1 = new System.Windows.Forms.ListBox();
            this.MustHaveLeague = new System.Windows.Forms.Label();
            this.ResultsBox = new System.Windows.Forms.ListView();
            this.ResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.toExcel = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectLeague
            // 
            this.SelectLeague.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectLeague.FormattingEnabled = true;
            this.SelectLeague.Items.AddRange(new object[] {
            "All",
            "Veikkausliiga",
            "Suomen Cup",
            "Friendly"});
            this.SelectLeague.Location = new System.Drawing.Point(372, 60);
            this.SelectLeague.Name = "SelectLeague";
            this.SelectLeague.Size = new System.Drawing.Size(191, 39);
            this.SelectLeague.TabIndex = 12;
            this.SelectLeague.Text = "Select league";
            // 
            // SearchResultsButton
            // 
            this.SearchResultsButton.Location = new System.Drawing.Point(393, 180);
            this.SearchResultsButton.Name = "SearchResultsButton";
            this.SearchResultsButton.Size = new System.Drawing.Size(118, 58);
            this.SearchResultsButton.TabIndex = 14;
            this.SearchResultsButton.Text = "Search";
            this.SearchResultsButton.UseVisualStyleBackColor = true;
            this.SearchResultsButton.Click += new System.EventHandler(this.SearchResultsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Search results by league and year";
            // 
            // ResultsBox1
            // 
            this.ResultsBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsBox1.FormattingEnabled = true;
            this.ResultsBox1.ItemHeight = 29;
            this.ResultsBox1.Location = new System.Drawing.Point(70, 268);
            this.ResultsBox1.Name = "ResultsBox1";
            this.ResultsBox1.Size = new System.Drawing.Size(824, 265);
            this.ResultsBox1.TabIndex = 16;
            // 
            // MustHaveLeague
            // 
            this.MustHaveLeague.AutoSize = true;
            this.MustHaveLeague.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MustHaveLeague.ForeColor = System.Drawing.Color.Red;
            this.MustHaveLeague.Location = new System.Drawing.Point(343, 75);
            this.MustHaveLeague.Name = "MustHaveLeague";
            this.MustHaveLeague.Size = new System.Drawing.Size(23, 36);
            this.MustHaveLeague.TabIndex = 17;
            this.MustHaveLeague.Text = "!";
            this.MustHaveLeague.Visible = false;
            // 
            // ResultsBox
            // 
            this.ResultsBox.HideSelection = false;
            this.ResultsBox.Location = new System.Drawing.Point(70, 268);
            this.ResultsBox.Name = "ResultsBox";
            this.ResultsBox.Size = new System.Drawing.Size(824, 265);
            this.ResultsBox.TabIndex = 19;
            this.ResultsBox.UseCompatibleStateImageBehavior = false;
            // 
            // ResultsDataGridView
            // 
            this.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsDataGridView.Location = new System.Drawing.Point(12, 259);
            this.ResultsDataGridView.Name = "ResultsDataGridView";
            this.ResultsDataGridView.RowTemplate.Height = 24;
            this.ResultsDataGridView.Size = new System.Drawing.Size(1542, 300);
            this.ResultsDataGridView.TabIndex = 20;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(560, 632);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(110, 17);
            this.lblStatus.TabIndex = 32;
            this.lblStatus.Text = "Processing...0%";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 565);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1333, 53);
            this.progressBar.TabIndex = 31;
            // 
            // toExcel
            // 
            this.toExcel.Location = new System.Drawing.Point(1351, 565);
            this.toExcel.Name = "toExcel";
            this.toExcel.Size = new System.Drawing.Size(203, 55);
            this.toExcel.TabIndex = 30;
            this.toExcel.Text = "Export to Excel";
            this.toExcel.UseVisualStyleBackColor = true;
            this.toExcel.Click += new System.EventHandler(this.toExcel_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 655);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.toExcel);
            this.Controls.Add(this.ResultsDataGridView);
            this.Controls.Add(this.ResultsBox);
            this.Controls.Add(this.MustHaveLeague);
            this.Controls.Add(this.ResultsBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchResultsButton);
            this.Controls.Add(this.SelectLeague);
            this.Name = "Results";
            this.Text = "Results";
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectLeague;
        private System.Windows.Forms.Button SearchResultsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ResultsBox1;
        private System.Windows.Forms.Label MustHaveLeague;
        private System.Windows.Forms.ListView ResultsBox;
        private System.Windows.Forms.DataGridView ResultsDataGridView;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button toExcel;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}