namespace HIFK_tilastot
{
    partial class AddNewReferee
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
            this.MustHaveLastName = new System.Windows.Forms.Label();
            this.BirthDay = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddingRefereeButton = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MustHaveLastName
            // 
            this.MustHaveLastName.AutoSize = true;
            this.MustHaveLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MustHaveLastName.ForeColor = System.Drawing.Color.Red;
            this.MustHaveLastName.Location = new System.Drawing.Point(354, 124);
            this.MustHaveLastName.Name = "MustHaveLastName";
            this.MustHaveLastName.Size = new System.Drawing.Size(23, 36);
            this.MustHaveLastName.TabIndex = 28;
            this.MustHaveLastName.Text = "!";
            this.MustHaveLastName.Visible = false;
            // 
            // BirthDay
            // 
            this.BirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDay.Location = new System.Drawing.Point(207, 160);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Size = new System.Drawing.Size(141, 30);
            this.BirthDay.TabIndex = 27;
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(207, 124);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(141, 30);
            this.LastName.TabIndex = 26;
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(207, 87);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(141, 30);
            this.FirstName.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Birthday:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Last name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "First name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Adding new referee";
            // 
            // AddingRefereeButton
            // 
            this.AddingRefereeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddingRefereeButton.Location = new System.Drawing.Point(142, 205);
            this.AddingRefereeButton.Name = "AddingRefereeButton";
            this.AddingRefereeButton.Size = new System.Drawing.Size(190, 52);
            this.AddingRefereeButton.TabIndex = 29;
            this.AddingRefereeButton.Text = "Add new referee";
            this.AddingRefereeButton.UseVisualStyleBackColor = true;
            this.AddingRefereeButton.Click += new System.EventHandler(this.AddingRefereeButton_Click);
            // 
            // confirm
            // 
            this.confirm.AutoSize = true;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.ForeColor = System.Drawing.Color.Green;
            this.confirm.Location = new System.Drawing.Point(70, 279);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(278, 25);
            this.confirm.TabIndex = 30;
            this.confirm.Text = "New referee added succesfully";
            this.confirm.Visible = false;
            // 
            // AddNewReferee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 333);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.AddingRefereeButton);
            this.Controls.Add(this.MustHaveLastName);
            this.Controls.Add(this.BirthDay);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewReferee";
            this.Text = "AddNewReferee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MustHaveLastName;
        private System.Windows.Forms.TextBox BirthDay;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddingRefereeButton;
        private System.Windows.Forms.Label confirm;
    }
}