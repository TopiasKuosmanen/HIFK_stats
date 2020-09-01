namespace HIFK_tilastot
{
    partial class Goals
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
            this.label3 = new System.Windows.Forms.Label();
            this.AllOpponents = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.toExcel = new System.Windows.Forms.Button();
            this.GoalsDataView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.PersonfoundlistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerNameText = new System.Windows.Forms.TextBox();
            this.WinnerBox = new System.Windows.Forms.CheckBox();
            this.PenBox = new System.Windows.Forms.CheckBox();
            this.AssistBox = new System.Windows.Forms.TextBox();
            this.AssistLabel = new System.Windows.Forms.Label();
            this.MinMinute = new System.Windows.Forms.TextBox();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.MaxMinute = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GoalsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(656, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 50;
            // 
            // AllOpponents
            // 
            this.AllOpponents.AutoSize = true;
            this.AllOpponents.Location = new System.Drawing.Point(168, 9);
            this.AllOpponents.Name = "AllOpponents";
            this.AllOpponents.Size = new System.Drawing.Size(88, 21);
            this.AllOpponents.TabIndex = 49;
            this.AllOpponents.Text = "Select All";
            this.AllOpponents.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "League";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "All"});
            this.listBox1.Location = new System.Drawing.Point(25, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(123, 148);
            this.listBox1.TabIndex = 47;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(573, 595);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(110, 17);
            this.lblStatus.TabIndex = 46;
            this.lblStatus.Text = "Processing...0%";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(25, 528);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1333, 53);
            this.progressBar.TabIndex = 45;
            // 
            // toExcel
            // 
            this.toExcel.Location = new System.Drawing.Point(1364, 528);
            this.toExcel.Name = "toExcel";
            this.toExcel.Size = new System.Drawing.Size(203, 55);
            this.toExcel.TabIndex = 44;
            this.toExcel.Text = "Export to Excel";
            this.toExcel.UseVisualStyleBackColor = true;
            // 
            // GoalsDataView
            // 
            this.GoalsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GoalsDataView.Location = new System.Drawing.Point(25, 222);
            this.GoalsDataView.Name = "GoalsDataView";
            this.GoalsDataView.RowTemplate.Height = 24;
            this.GoalsDataView.Size = new System.Drawing.Size(1542, 300);
            this.GoalsDataView.TabIndex = 43;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(419, 166);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(118, 47);
            this.searchButton.TabIndex = 42;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // PersonfoundlistBox
            // 
            this.PersonfoundlistBox.FormattingEnabled = true;
            this.PersonfoundlistBox.ItemHeight = 16;
            this.PersonfoundlistBox.Location = new System.Drawing.Point(78, 231);
            this.PersonfoundlistBox.Name = "PersonfoundlistBox";
            this.PersonfoundlistBox.Size = new System.Drawing.Size(395, 276);
            this.PersonfoundlistBox.TabIndex = 41;
            this.PersonfoundlistBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Player";
            // 
            // PlayerNameText
            // 
            this.PlayerNameText.Location = new System.Drawing.Point(386, 66);
            this.PlayerNameText.Name = "PlayerNameText";
            this.PlayerNameText.Size = new System.Drawing.Size(232, 22);
            this.PlayerNameText.TabIndex = 39;
            // 
            // WinnerBox
            // 
            this.WinnerBox.AutoSize = true;
            this.WinnerBox.Location = new System.Drawing.Point(652, 24);
            this.WinnerBox.Name = "WinnerBox";
            this.WinnerBox.Size = new System.Drawing.Size(111, 21);
            this.WinnerBox.TabIndex = 51;
            this.WinnerBox.Text = "Only winners";
            this.WinnerBox.UseVisualStyleBackColor = true;
            // 
            // PenBox
            // 
            this.PenBox.AutoSize = true;
            this.PenBox.Location = new System.Drawing.Point(652, 56);
            this.PenBox.Name = "PenBox";
            this.PenBox.Size = new System.Drawing.Size(110, 21);
            this.PenBox.TabIndex = 52;
            this.PenBox.Text = "No Penalties";
            this.PenBox.UseVisualStyleBackColor = true;
            // 
            // AssistBox
            // 
            this.AssistBox.Location = new System.Drawing.Point(747, 89);
            this.AssistBox.Name = "AssistBox";
            this.AssistBox.Size = new System.Drawing.Size(232, 22);
            this.AssistBox.TabIndex = 53;
            // 
            // AssistLabel
            // 
            this.AssistLabel.AutoSize = true;
            this.AssistLabel.Location = new System.Drawing.Point(658, 92);
            this.AssistLabel.Name = "AssistLabel";
            this.AssistLabel.Size = new System.Drawing.Size(45, 17);
            this.AssistLabel.TabIndex = 54;
            this.AssistLabel.Text = "Assist";
            // 
            // MinMinute
            // 
            this.MinMinute.Location = new System.Drawing.Point(747, 129);
            this.MinMinute.Name = "MinMinute";
            this.MinMinute.Size = new System.Drawing.Size(34, 22);
            this.MinMinute.TabIndex = 55;
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.AutoSize = true;
            this.MinuteLabel.Location = new System.Drawing.Point(658, 129);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(50, 17);
            this.MinuteLabel.TabIndex = 56;
            this.MinuteLabel.Text = "Minute";
            // 
            // MaxMinute
            // 
            this.MaxMinute.Location = new System.Drawing.Point(821, 129);
            this.MaxMinute.Name = "MaxMinute";
            this.MaxMinute.Size = new System.Drawing.Size(34, 22);
            this.MaxMinute.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(787, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "TO";
            // 
            // Goals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 621);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaxMinute);
            this.Controls.Add(this.MinuteLabel);
            this.Controls.Add(this.MinMinute);
            this.Controls.Add(this.AssistLabel);
            this.Controls.Add(this.AssistBox);
            this.Controls.Add(this.PenBox);
            this.Controls.Add(this.WinnerBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AllOpponents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.toExcel);
            this.Controls.Add(this.GoalsDataView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.PersonfoundlistBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerNameText);
            this.Name = "Goals";
            this.Text = "Goals";
            ((System.ComponentModel.ISupportInitialize)(this.GoalsDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox AllOpponents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button toExcel;
        private System.Windows.Forms.DataGridView GoalsDataView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox PersonfoundlistBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PlayerNameText;
        private System.Windows.Forms.CheckBox WinnerBox;
        private System.Windows.Forms.CheckBox PenBox;
        private System.Windows.Forms.TextBox AssistBox;
        private System.Windows.Forms.Label AssistLabel;
        private System.Windows.Forms.TextBox MinMinute;
        private System.Windows.Forms.Label MinuteLabel;
        private System.Windows.Forms.TextBox MaxMinute;
        private System.Windows.Forms.Label label4;
    }
}