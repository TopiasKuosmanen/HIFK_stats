using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIFK_tilastot
{
    public partial class AddNewOpponent : Form
    {
        


        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private TextBox TeamName;
        private TextBox NewStadiumName;
        private TextBox Capacity;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox TurfYesOrNo;
        private Label label1;
        private CheckBox checkBox2;
        private Button AddOpponentButton;
        private Button AddStadiumButton;
        ComboBox StadiumBox = new ComboBox();

        public AddNewOpponent()
        {
            InitializeComponent();
            DoStadiumBox();
        }

        private void DoStadiumBox()
        {
            DataAccess db = new DataAccess();
            List<Stadium> stadiums = new List<Stadium>();

            stadiums = db.GetStadiums();
            StadiumBox.Location = new Point(152, 132);
            StadiumBox.Size = new Size(141, 50);
            StadiumBox.DropDownStyle = ComboBoxStyle.DropDown;
            StadiumBox.Name = "StadiumBox";
            foreach (Stadium s in stadiums)
            {
                StadiumBox.Items.Add(s.Name);
            }
            this.Controls.Add(StadiumBox);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TeamName = new System.Windows.Forms.TextBox();
            this.NewStadiumName = new System.Windows.Forms.TextBox();
            this.Capacity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TurfYesOrNo = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.AddOpponentButton = new System.Windows.Forms.Button();
            this.AddStadiumButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new opponent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Team:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stadium:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 168);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "New stadium?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TeamName
            // 
            this.TeamName.Location = new System.Drawing.Point(152, 94);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(100, 22);
            this.TeamName.TabIndex = 4;
            // 
            // NewStadiumName
            // 
            this.NewStadiumName.Location = new System.Drawing.Point(152, 192);
            this.NewStadiumName.Name = "NewStadiumName";
            this.NewStadiumName.Size = new System.Drawing.Size(100, 22);
            this.NewStadiumName.TabIndex = 5;
            this.NewStadiumName.Visible = false;
            // 
            // Capacity
            // 
            this.Capacity.Location = new System.Drawing.Point(152, 220);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(100, 22);
            this.Capacity.TabIndex = 6;
            this.Capacity.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stadium name:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Capacity:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Turf? ";
            this.label6.Visible = false;
            // 
            // TurfYesOrNo
            // 
            this.TurfYesOrNo.FormattingEnabled = true;
            this.TurfYesOrNo.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.TurfYesOrNo.Location = new System.Drawing.Point(152, 259);
            this.TurfYesOrNo.Name = "TurfYesOrNo";
            this.TurfYesOrNo.Size = new System.Drawing.Size(100, 24);
            this.TurfYesOrNo.TabIndex = 10;
            this.TurfYesOrNo.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 60);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(438, 21);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Select this, if you want to only add stadium without new opponent";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // AddOpponentButton
            // 
            this.AddOpponentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOpponentButton.Location = new System.Drawing.Point(152, 168);
            this.AddOpponentButton.Name = "AddOpponentButton";
            this.AddOpponentButton.Size = new System.Drawing.Size(108, 39);
            this.AddOpponentButton.TabIndex = 12;
            this.AddOpponentButton.Text = "Add";
            this.AddOpponentButton.UseVisualStyleBackColor = true;
            this.AddOpponentButton.Click += new System.EventHandler(this.AddOpponentButton_Click);
            // 
            // AddStadiumButton
            // 
            this.AddStadiumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStadiumButton.Location = new System.Drawing.Point(152, 203);
            this.AddStadiumButton.Name = "AddStadiumButton";
            this.AddStadiumButton.Size = new System.Drawing.Size(108, 39);
            this.AddStadiumButton.TabIndex = 13;
            this.AddStadiumButton.Text = "Add";
            this.AddStadiumButton.UseVisualStyleBackColor = true;
            this.AddStadiumButton.Visible = false;
            this.AddStadiumButton.Click += new System.EventHandler(this.AddStadiumButton_Click);
            // 
            // AddNewOpponent
            // 
            this.ClientSize = new System.Drawing.Size(452, 341);
            this.Controls.Add(this.AddStadiumButton);
            this.Controls.Add(this.AddOpponentButton);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.TurfYesOrNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Capacity);
            this.Controls.Add(this.NewStadiumName);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewOpponent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            NewStadiumName.Show();
            Capacity.Show();
            TurfYesOrNo.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label3.Hide();
            StadiumBox.Hide();
            AddOpponentButton.Location = new Point(152, 289);
            if (checkBox1.Checked == false)
            {
                NewStadiumName.Hide();
                Capacity.Hide();
                TurfYesOrNo.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label3.Show();
                StadiumBox.Show();
                AddOpponentButton.Location = new Point(152, 168);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            NewStadiumName.Show();
            NewStadiumName.Location = new Point(152, 92);
            Capacity.Show();
            Capacity.Location = new Point(152, 120);
            TurfYesOrNo.Show();
            TurfYesOrNo.Location = new Point(152, 159);
            label4.Show();
            label4.Location = new Point(9, 92);
            label5.Show();
            label5.Location = new Point(9, 120);
            label6.Show();
            label6.Location = new Point(9, 159);
            AddStadiumButton.Show();

            AddOpponentButton.Hide();
            TeamName.Hide();
            StadiumBox.Hide();
            label2.Hide();
            label3.Hide();
            checkBox1.Hide();
            label1.Text =  "Add new stadium:";
            if (checkBox2.Checked == false)
            {
                NewStadiumName.Hide();
                Capacity.Hide();
                TurfYesOrNo.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                TeamName.Show();
                StadiumBox.Show();
                label2.Show();
                label3.Show();
                checkBox1.Show();
                label1.Text = "Add new opponent:";
                AddOpponentButton.Show();
                AddStadiumButton.Hide();
                NewStadiumName.Location = new Point(152, 192);
                Capacity.Location = new Point(152, 220);
                TurfYesOrNo.Location = new Point(152, 259);
                label4.Location = new Point(9, 192);
                label5.Location = new Point(9, 220);
                label6.Location = new Point(9, 259);
            }
        }

        private void AddOpponentButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            if (checkBox1.Checked == true)
            {
                db.AddNewStadium(NewStadiumName.Text, int.Parse(Capacity.Text), TurfYesOrNo.Text);
                db.AddNewOpponent(TeamName.Text, NewStadiumName.Text);
            }
            else
            {
                db.AddNewOpponent(TeamName.Text, StadiumBox.SelectedItem.ToString());
            }

        }

        private void AddStadiumButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            // Lisätään uusi stadikka.
            db.AddNewStadium(NewStadiumName.Text, int.Parse(Capacity.Text), TurfYesOrNo.Text);
        }
    }
}
