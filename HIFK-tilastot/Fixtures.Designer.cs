namespace HIFK_tilastot
{
    partial class Fixtures
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
            this.SelectLeague = new System.Windows.Forms.ComboBox();
            this.MustHaveLeague = new System.Windows.Forms.Label();
            this.SearchResultsButton = new System.Windows.Forms.Button();
            this.ResultsBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fixtures";
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
            this.SelectLeague.Location = new System.Drawing.Point(326, 82);
            this.SelectLeague.Name = "SelectLeague";
            this.SelectLeague.Size = new System.Drawing.Size(191, 39);
            this.SelectLeague.TabIndex = 14;
            this.SelectLeague.Text = "Select league";
            // 
            // MustHaveLeague
            // 
            this.MustHaveLeague.AutoSize = true;
            this.MustHaveLeague.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MustHaveLeague.ForeColor = System.Drawing.Color.Red;
            this.MustHaveLeague.Location = new System.Drawing.Point(288, 85);
            this.MustHaveLeague.Name = "MustHaveLeague";
            this.MustHaveLeague.Size = new System.Drawing.Size(23, 36);
            this.MustHaveLeague.TabIndex = 19;
            this.MustHaveLeague.Text = "!";
            this.MustHaveLeague.Visible = false;
            // 
            // SearchResultsButton
            // 
            this.SearchResultsButton.Location = new System.Drawing.Point(358, 127);
            this.SearchResultsButton.Name = "SearchResultsButton";
            this.SearchResultsButton.Size = new System.Drawing.Size(118, 58);
            this.SearchResultsButton.TabIndex = 21;
            this.SearchResultsButton.Text = "Search";
            this.SearchResultsButton.UseVisualStyleBackColor = true;
            this.SearchResultsButton.Click += new System.EventHandler(this.SearchResultsButton_Click);
            // 
            // ResultsBox
            // 
            this.ResultsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsBox.FormattingEnabled = true;
            this.ResultsBox.ItemHeight = 29;
            this.ResultsBox.Location = new System.Drawing.Point(33, 191);
            this.ResultsBox.Name = "ResultsBox";
            this.ResultsBox.Size = new System.Drawing.Size(824, 265);
            this.ResultsBox.TabIndex = 22;
            // 
            // Fixtures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 537);
            this.Controls.Add(this.ResultsBox);
            this.Controls.Add(this.SearchResultsButton);
            this.Controls.Add(this.MustHaveLeague);
            this.Controls.Add(this.SelectLeague);
            this.Controls.Add(this.label1);
            this.Name = "Fixtures";
            this.Text = "Fixtures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectLeague;
        private System.Windows.Forms.Label MustHaveLeague;
        private System.Windows.Forms.Button SearchResultsButton;
        private System.Windows.Forms.ListBox ResultsBox;
    }
}