namespace HIFK_tilastot
{
    partial class AddNewGame
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
            this.Result = new System.Windows.Forms.Label();
            this.MustHaveLeague = new System.Windows.Forms.Label();
            this.AddingGameButton = new System.Windows.Forms.Button();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HomeOrAway = new System.Windows.Forms.ComboBox();
            this.MustHaveOpponent = new System.Windows.Forms.Label();
            this.MustHaveHomeAway = new System.Windows.Forms.Label();
            this.TimeForm = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.extraTimeOrNot = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.penaltiesOrNot = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.Black;
            this.Result.Location = new System.Drawing.Point(107, 470);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 29);
            this.Result.TabIndex = 45;
            // 
            // MustHaveLeague
            // 
            this.MustHaveLeague.AutoSize = true;
            this.MustHaveLeague.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MustHaveLeague.ForeColor = System.Drawing.Color.Red;
            this.MustHaveLeague.Location = new System.Drawing.Point(501, 62);
            this.MustHaveLeague.Name = "MustHaveLeague";
            this.MustHaveLeague.Size = new System.Drawing.Size(23, 36);
            this.MustHaveLeague.TabIndex = 40;
            this.MustHaveLeague.Text = "!";
            this.MustHaveLeague.Visible = false;
            // 
            // AddingGameButton
            // 
            this.AddingGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddingGameButton.Location = new System.Drawing.Point(251, 387);
            this.AddingGameButton.Name = "AddingGameButton";
            this.AddingGameButton.Size = new System.Drawing.Size(168, 52);
            this.AddingGameButton.TabIndex = 39;
            this.AddingGameButton.Text = "Add new game";
            this.AddingGameButton.UseVisualStyleBackColor = true;
            this.AddingGameButton.Click += new System.EventHandler(this.AddingGameButton_Click);
            // 
            // TimeBox
            // 
            this.TimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeBox.Location = new System.Drawing.Point(319, 184);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(161, 30);
            this.TimeBox.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(195, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Home/away:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Stadion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Opponent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "League:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "Adding new game";
            // 
            // HomeOrAway
            // 
            this.HomeOrAway.FormattingEnabled = true;
            this.HomeOrAway.Items.AddRange(new object[] {
            "Home",
            "Away"});
            this.HomeOrAway.Location = new System.Drawing.Point(319, 229);
            this.HomeOrAway.Name = "HomeOrAway";
            this.HomeOrAway.Size = new System.Drawing.Size(161, 24);
            this.HomeOrAway.TabIndex = 46;
            this.HomeOrAway.SelectedIndexChanged += new System.EventHandler(this.HomeOrAway_SelectedIndexChanged);
            // 
            // MustHaveOpponent
            // 
            this.MustHaveOpponent.AutoSize = true;
            this.MustHaveOpponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MustHaveOpponent.ForeColor = System.Drawing.Color.Red;
            this.MustHaveOpponent.Location = new System.Drawing.Point(501, 101);
            this.MustHaveOpponent.Name = "MustHaveOpponent";
            this.MustHaveOpponent.Size = new System.Drawing.Size(23, 36);
            this.MustHaveOpponent.TabIndex = 47;
            this.MustHaveOpponent.Text = "!";
            this.MustHaveOpponent.Visible = false;
            // 
            // MustHaveHomeAway
            // 
            this.MustHaveHomeAway.AutoSize = true;
            this.MustHaveHomeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MustHaveHomeAway.ForeColor = System.Drawing.Color.Red;
            this.MustHaveHomeAway.Location = new System.Drawing.Point(501, 225);
            this.MustHaveHomeAway.Name = "MustHaveHomeAway";
            this.MustHaveHomeAway.Size = new System.Drawing.Size(23, 36);
            this.MustHaveHomeAway.TabIndex = 50;
            this.MustHaveHomeAway.Text = "!";
            this.MustHaveHomeAway.Visible = false;
            // 
            // TimeForm
            // 
            this.TimeForm.AutoSize = true;
            this.TimeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeForm.ForeColor = System.Drawing.Color.Red;
            this.TimeForm.Location = new System.Drawing.Point(486, 178);
            this.TimeForm.Name = "TimeForm";
            this.TimeForm.Size = new System.Drawing.Size(91, 36);
            this.TimeForm.TabIndex = 51;
            this.TimeForm.Text = "00:00";
            this.TimeForm.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(195, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 52;
            this.label8.Text = "Extra time:";
            // 
            // extraTimeOrNot
            // 
            this.extraTimeOrNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraTimeOrNot.FormattingEnabled = true;
            this.extraTimeOrNot.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.extraTimeOrNot.Location = new System.Drawing.Point(319, 296);
            this.extraTimeOrNot.Name = "extraTimeOrNot";
            this.extraTimeOrNot.Size = new System.Drawing.Size(161, 28);
            this.extraTimeOrNot.TabIndex = 53;
            this.extraTimeOrNot.SelectedIndexChanged += new System.EventHandler(this.extraTimeOrNot_SelectedIndexChanged_1);
            //this.OpponentBox.SelectedIndexChanged += new System.EventHandler(this.OpponentBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(195, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 25);
            this.label9.TabIndex = 54;
            this.label9.Text = "Penalties:";
            // 
            // penaltiesOrNot
            // 
            this.penaltiesOrNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penaltiesOrNot.FormattingEnabled = true;
            this.penaltiesOrNot.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.penaltiesOrNot.Location = new System.Drawing.Point(319, 334);
            this.penaltiesOrNot.Name = "penaltiesOrNot";
            this.penaltiesOrNot.Size = new System.Drawing.Size(161, 28);
            this.penaltiesOrNot.TabIndex = 55;
            this.penaltiesOrNot.SelectedIndexChanged += new System.EventHandler(this.penaltiesOrNot_SelectedIndexChanged_1);
            // 
            // AddNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 545);
            this.Controls.Add(this.penaltiesOrNot);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.extraTimeOrNot);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TimeForm);
            this.Controls.Add(this.MustHaveHomeAway);
            this.Controls.Add(this.MustHaveOpponent);
            this.Controls.Add(this.HomeOrAway);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.MustHaveLeague);
            this.Controls.Add(this.AddingGameButton);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewGame";
            this.Text = "AddNewGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label MustHaveLeague;
        private System.Windows.Forms.Button AddingGameButton;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HomeOrAway;
        private System.Windows.Forms.Label MustHaveOpponent;
        private System.Windows.Forms.Label MustHaveHomeAway;
        private System.Windows.Forms.Label TimeForm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox extraTimeOrNot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox penaltiesOrNot;
    }
}