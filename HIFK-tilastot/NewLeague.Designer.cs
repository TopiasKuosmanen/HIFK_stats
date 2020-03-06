namespace HIFK_tilastot
{
    partial class NewLeague
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
            this.label2 = new System.Windows.Forms.Label();
            this.LeagueName = new System.Windows.Forms.TextBox();
            this.AddLeagueButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new league";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "League name:";
            // 
            // LeagueName
            // 
            this.LeagueName.Location = new System.Drawing.Point(117, 84);
            this.LeagueName.Name = "LeagueName";
            this.LeagueName.Size = new System.Drawing.Size(157, 22);
            this.LeagueName.TabIndex = 2;
            // 
            // AddLeagueButton
            // 
            this.AddLeagueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLeagueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLeagueButton.Location = new System.Drawing.Point(102, 127);
            this.AddLeagueButton.Name = "AddLeagueButton";
            this.AddLeagueButton.Size = new System.Drawing.Size(100, 39);
            this.AddLeagueButton.TabIndex = 3;
            this.AddLeagueButton.Text = "Add";
            this.AddLeagueButton.UseVisualStyleBackColor = true;
            this.AddLeagueButton.Click += new System.EventHandler(this.AddLeagueButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 4;
            // 
            // NewLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 364);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddLeagueButton);
            this.Controls.Add(this.LeagueName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewLeague";
            this.Text = "Add New League";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LeagueName;
        private System.Windows.Forms.Button AddLeagueButton;
        private System.Windows.Forms.Label label3;
    }
}