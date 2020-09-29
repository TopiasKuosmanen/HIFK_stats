namespace HIFK_tilastot
{
    partial class OpponentsGoals
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
            this.PersonfoundlistBox = new System.Windows.Forms.ListBox();
            this.GoalsDataView = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AllOpponents = new System.Windows.Forms.CheckBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.toExcel = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WinnerBox = new System.Windows.Forms.CheckBox();
            this.PenBox = new System.Windows.Forms.CheckBox();
            this.MinMinute = new System.Windows.Forms.TextBox();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.MaxMinute = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GoalsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonfoundlistBox
            // 
            this.PersonfoundlistBox.FormattingEnabled = true;
            this.PersonfoundlistBox.ItemHeight = 16;
            this.PersonfoundlistBox.Location = new System.Drawing.Point(71, 231);
            this.PersonfoundlistBox.Name = "PersonfoundlistBox";
            this.PersonfoundlistBox.Size = new System.Drawing.Size(395, 276);
            this.PersonfoundlistBox.TabIndex = 61;
            this.PersonfoundlistBox.Visible = false;
            // 
            // GoalsDataView
            // 
            this.GoalsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GoalsDataView.Location = new System.Drawing.Point(18, 222);
            this.GoalsDataView.Name = "GoalsDataView";
            this.GoalsDataView.RowTemplate.Height = 24;
            this.GoalsDataView.Size = new System.Drawing.Size(1542, 300);
            this.GoalsDataView.TabIndex = 63;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "All"});
            this.listBox1.Location = new System.Drawing.Point(18, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(123, 148);
            this.listBox1.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "League";
            // 
            // AllOpponents
            // 
            this.AllOpponents.AutoSize = true;
            this.AllOpponents.Location = new System.Drawing.Point(161, 9);
            this.AllOpponents.Name = "AllOpponents";
            this.AllOpponents.Size = new System.Drawing.Size(88, 21);
            this.AllOpponents.TabIndex = 69;
            this.AllOpponents.Text = "Select All";
            this.AllOpponents.UseVisualStyleBackColor = true;
            this.AllOpponents.Visible = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 78;
            this.label4.Text = "TO";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(412, 166);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(118, 47);
            this.searchButton.TabIndex = 62;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // toExcel
            // 
            this.toExcel.Location = new System.Drawing.Point(1357, 528);
            this.toExcel.Name = "toExcel";
            this.toExcel.Size = new System.Drawing.Size(203, 55);
            this.toExcel.TabIndex = 64;
            this.toExcel.Text = "Export to Excel";
            this.toExcel.UseVisualStyleBackColor = true;
            this.toExcel.Click += new System.EventHandler(this.toExcel_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(18, 528);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1333, 53);
            this.progressBar.TabIndex = 65;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(566, 595);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(110, 17);
            this.lblStatus.TabIndex = 66;
            this.lblStatus.Text = "Processing...0%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 70;
            // 
            // WinnerBox
            // 
            this.WinnerBox.AutoSize = true;
            this.WinnerBox.Location = new System.Drawing.Point(378, 12);
            this.WinnerBox.Name = "WinnerBox";
            this.WinnerBox.Size = new System.Drawing.Size(111, 21);
            this.WinnerBox.TabIndex = 71;
            this.WinnerBox.Text = "Only winners";
            this.WinnerBox.UseVisualStyleBackColor = true;
            // 
            // PenBox
            // 
            this.PenBox.AutoSize = true;
            this.PenBox.Location = new System.Drawing.Point(378, 39);
            this.PenBox.Name = "PenBox";
            this.PenBox.Size = new System.Drawing.Size(110, 21);
            this.PenBox.TabIndex = 72;
            this.PenBox.Text = "No Penalties";
            this.PenBox.UseVisualStyleBackColor = true;
            // 
            // MinMinute
            // 
            this.MinMinute.Location = new System.Drawing.Point(464, 66);
            this.MinMinute.Name = "MinMinute";
            this.MinMinute.Size = new System.Drawing.Size(34, 22);
            this.MinMinute.TabIndex = 75;
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.AutoSize = true;
            this.MinuteLabel.Location = new System.Drawing.Point(375, 66);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(50, 17);
            this.MinuteLabel.TabIndex = 76;
            this.MinuteLabel.Text = "Minute";
            // 
            // MaxMinute
            // 
            this.MaxMinute.Location = new System.Drawing.Point(538, 66);
            this.MaxMinute.Name = "MaxMinute";
            this.MaxMinute.Size = new System.Drawing.Size(34, 22);
            this.MaxMinute.TabIndex = 77;
            // 
            // OpponentsGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 621);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaxMinute);
            this.Controls.Add(this.MinuteLabel);
            this.Controls.Add(this.MinMinute);
            this.Controls.Add(this.PenBox);
            this.Controls.Add(this.WinnerBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.toExcel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.AllOpponents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.GoalsDataView);
            this.Controls.Add(this.PersonfoundlistBox);
            this.Name = "OpponentsGoals";
            this.Text = "OpponentsGoals";
            ((System.ComponentModel.ISupportInitialize)(this.GoalsDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PersonfoundlistBox;
        private System.Windows.Forms.DataGridView GoalsDataView;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AllOpponents;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button toExcel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox WinnerBox;
        private System.Windows.Forms.CheckBox PenBox;
        private System.Windows.Forms.TextBox MinMinute;
        private System.Windows.Forms.Label MinuteLabel;
        private System.Windows.Forms.TextBox MaxMinute;
    }
}