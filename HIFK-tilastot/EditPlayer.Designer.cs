namespace HIFK_tilastot
{
    partial class EditPlayer
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
            this.searchPlayerStats = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerNameText = new System.Windows.Forms.TextBox();
            this.PlayerBox = new System.Windows.Forms.ListBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.YearOfAccession = new System.Windows.Forms.TextBox();
            this.ContractEndDate = new System.Windows.Forms.TextBox();
            this.BirhDate = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the player you want to edit";
            // 
            // searchPlayerStats
            // 
            this.searchPlayerStats.Location = new System.Drawing.Point(147, 101);
            this.searchPlayerStats.Name = "searchPlayerStats";
            this.searchPlayerStats.Size = new System.Drawing.Size(126, 47);
            this.searchPlayerStats.TabIndex = 21;
            this.searchPlayerStats.Text = "Search player";
            this.searchPlayerStats.UseVisualStyleBackColor = true;
            this.searchPlayerStats.Click += new System.EventHandler(this.searchPlayerStats_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Player";
            // 
            // PlayerNameText
            // 
            this.PlayerNameText.Location = new System.Drawing.Point(115, 73);
            this.PlayerNameText.Name = "PlayerNameText";
            this.PlayerNameText.Size = new System.Drawing.Size(232, 22);
            this.PlayerNameText.TabIndex = 19;
            // 
            // PlayerBox
            // 
            this.PlayerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerBox.FormattingEnabled = true;
            this.PlayerBox.ItemHeight = 25;
            this.PlayerBox.Location = new System.Drawing.Point(75, 170);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(302, 254);
            this.PlayerBox.TabIndex = 18;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(157, 452);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(116, 51);
            this.EditButton.TabIndex = 22;
            this.EditButton.Text = "Edit player";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "First name:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Last name:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Number:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "year of acc.:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Contr. ends:";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Birthdate:";
            this.label8.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(157, 76);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(150, 22);
            this.FirstName.TabIndex = 29;
            this.FirstName.Visible = false;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(157, 116);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(150, 22);
            this.LastName.TabIndex = 30;
            this.LastName.Visible = false;
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(157, 156);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(150, 22);
            this.Number.TabIndex = 31;
            this.Number.Visible = false;
            // 
            // YearOfAccession
            // 
            this.YearOfAccession.Location = new System.Drawing.Point(157, 198);
            this.YearOfAccession.Name = "YearOfAccession";
            this.YearOfAccession.Size = new System.Drawing.Size(150, 22);
            this.YearOfAccession.TabIndex = 32;
            this.YearOfAccession.Visible = false;
            // 
            // ContractEndDate
            // 
            this.ContractEndDate.Location = new System.Drawing.Point(157, 238);
            this.ContractEndDate.Name = "ContractEndDate";
            this.ContractEndDate.Size = new System.Drawing.Size(150, 22);
            this.ContractEndDate.TabIndex = 33;
            this.ContractEndDate.Visible = false;
            // 
            // BirhDate
            // 
            this.BirhDate.Location = new System.Drawing.Point(157, 278);
            this.BirhDate.Name = "BirhDate";
            this.BirhDate.Size = new System.Drawing.Size(150, 22);
            this.BirhDate.TabIndex = 34;
            this.BirhDate.Visible = false;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(157, 325);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(116, 51);
            this.UpdateButton.TabIndex = 35;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Visible = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesButton.Location = new System.Drawing.Point(95, 89);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(87, 47);
            this.yesButton.TabIndex = 36;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Visible = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noButton.Location = new System.Drawing.Point(260, 89);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(87, 47);
            this.noButton.TabIndex = 37;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Visible = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // EditPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 523);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.BirhDate);
            this.Controls.Add(this.ContractEndDate);
            this.Controls.Add(this.YearOfAccession);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.searchPlayerStats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlayerNameText);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.label1);
            this.Name = "EditPlayer";
            this.Text = "EditPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchPlayerStats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PlayerNameText;
        private System.Windows.Forms.ListBox PlayerBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.TextBox YearOfAccession;
        private System.Windows.Forms.TextBox ContractEndDate;
        private System.Windows.Forms.TextBox BirhDate;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
    }
}