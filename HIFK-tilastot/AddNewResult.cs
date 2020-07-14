using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIFK_tilastot
{
    public partial class AddNewResult : Form
    {
        
        ListBox GameBox = new ListBox();
        Game SelectedGame;
        NumericUpDown ResultBox1 = new NumericUpDown();
        NumericUpDown ResultBox2 = new NumericUpDown();
        ListBox StartingPlayerBox = new ListBox();
        ListBox PlayersOnTheBenchBox = new ListBox();
        TextBox sub1in = new TextBox();
        TextBox sub2in = new TextBox();
        TextBox sub3in = new TextBox();
        TextBox sub4in = new TextBox();
        TextBox sub5in = new TextBox();
        TextBox sub6in = new TextBox();
        TextBox sub7in = new TextBox();
        TextBox sub8in = new TextBox();
        TextBox sub9in = new TextBox();
        TextBox sub10in = new TextBox();
        TextBox sub11in = new TextBox();
        TextBox sub1out = new TextBox();
        TextBox sub2out = new TextBox();
        TextBox sub3out = new TextBox();
        TextBox sub4out = new TextBox();
        TextBox sub5out = new TextBox();
        TextBox sub6out = new TextBox();
        TextBox sub7out = new TextBox();
        TextBox sub8out = new TextBox();
        TextBox sub9out = new TextBox();
        TextBox sub10out = new TextBox();
        TextBox sub11out = new TextBox();
        TextBox min1 = new TextBox();
        TextBox min2 = new TextBox();
        TextBox min3 = new TextBox();
        TextBox min4 = new TextBox();
        TextBox min5 = new TextBox();
        TextBox min6 = new TextBox();
        TextBox min7 = new TextBox();
        TextBox min8 = new TextBox();
        TextBox min9 = new TextBox();
        TextBox min10 = new TextBox();
        TextBox min11 = new TextBox();

        List<ComboBox> goalboxes = new List<ComboBox>();
        List<Label> goallabels = new List<Label>();
        List<ComboBox> assistboxes = new List<ComboBox>();
        List<Label> assistlabels = new List<Label>();

        List<Person> players = new List<Person>();
        List<Person> starting = new List<Person>();
        List<Person> onthebench = new List<Person>();
        List<Person> SubstitutedInPlayers = new List<Person>();
        List<Person> SubstitutedOutPlayers = new List<Person>();
        List<Person> StartedPlayers = new List<Person>();
        List<Person> PlayedPlayers = new List<Person>();
        List<Person> SubstitutePlayers = new List<Person>();

        DataTable playertable = new DataTable();
        

        int subs;
        NumericUpDown subscount = new NumericUpDown();
        List<TextBox> Subinboxes = new List<TextBox>();
        List<TextBox> Suboutboxes = new List<TextBox>();
        List<TextBox> Subminboxes = new List<TextBox>();
        List<Substitution> SubsList = new List<Substitution>();


        public AddNewResult()
        {
            InitializeComponent();
            DoGameBox();
            DoResultBox();
            DoPlayerboxes();
            DoSubBoxes();
            DoGoalBoxes();
        }

        private void DoGoalBoxes()
        {
            goalboxes.Add(Goal1);
            goalboxes.Add(Goal2);
            goalboxes.Add(Goal3);
            goalboxes.Add(Goal4);
            goalboxes.Add(Goal5);
            goalboxes.Add(Goal6);
            goalboxes.Add(Goal7);
            goalboxes.Add(Goal8);
            goalboxes.Add(Goal9);
            goalboxes.Add(Goal10);
            goalboxes.Add(Goal11);
            goalboxes.Add(Goal12);
            goallabels.Add(GoalLabel1);
            goallabels.Add(GoalLabel2);
            goallabels.Add(GoalLabel3);
            goallabels.Add(GoalLabel4);
            goallabels.Add(GoalLabel5);
            goallabels.Add(GoalLabel6);
            goallabels.Add(GoalLabel7);
            goallabels.Add(GoalLabel8);
            goallabels.Add(GoalLabel9);
            goallabels.Add(GoalLabel10);
            goallabels.Add(GoalLabel11);
            goallabels.Add(GoalLabel12);
            assistboxes.Add(Assist1);
            assistboxes.Add(Assist2);
            assistboxes.Add(Assist3);
            assistboxes.Add(Assist4);
            assistboxes.Add(Assist5);
            assistboxes.Add(Assist6);
            assistboxes.Add(Assist7);
            assistboxes.Add(Assist8);
            assistboxes.Add(Assist9);
            assistboxes.Add(Assist10);
            assistboxes.Add(Assist11);
            assistboxes.Add(Assist12);
            assistlabels.Add(AssistLabel1);
            assistlabels.Add(AssistLabel2);
            assistlabels.Add(AssistLabel3);
            assistlabels.Add(AssistLabel4);
            assistlabels.Add(AssistLabel5);
            assistlabels.Add(AssistLabel6);
            assistlabels.Add(AssistLabel7);
            assistlabels.Add(AssistLabel8);
            assistlabels.Add(AssistLabel9);
            assistlabels.Add(AssistLabel10);
            assistlabels.Add(AssistLabel11);
            assistlabels.Add(AssistLabel12);


            foreach (ComboBox assist in assistboxes)
            {
                assist.Hide();
                assist.SelectedItem = "";
            }
            foreach (Label label in assistlabels)
            {
                label.Hide();
            }
            foreach (ComboBox goal in goalboxes)
            {
                goal.Hide();
                goal.SelectedItem = "";
            }
            foreach (Label item in goallabels)
            {
                item.Hide();
            }
        }

        private void DoGameBox()
        {
            DataAccess db = new DataAccess();
            List<Game> games = new List<Game>();

            games = db.GetAllGames();
            GameBox.Location = new Point(200, 54);
            GameBox.Size = new Size(200, 200);
            GameBox.Name = "GameBox";
            GameBox.DataSource = games;
            GameBox.DisplayMember = "SmallFixture";
            Controls.Add(GameBox);
            
        }
        private void DoSubBoxes()
        {
            min1.Location = new Point(330, 60);
            min1.Size = new Size(25, 60);
            min1.MaxLength = 3;
            min1.Font = new Font(ResultBox1.Font.FontFamily, 12);
            min1.TextAlign = HorizontalAlignment.Center;

            min2.Location = new Point(330, 90);
            min2.Size = new Size(25, 60);
            min2.MaxLength = 3;
            min2.Font = new Font(ResultBox1.Font.FontFamily, 12);
            min2.TextAlign = HorizontalAlignment.Center;

            min3.Location = new Point(330, 120);
            min3.Size = new Size(25, 60);
            min3.MaxLength = 3;
            min3.Font = new Font(ResultBox1.Font.FontFamily, 12);
            min3.TextAlign = HorizontalAlignment.Center;

            min4.Location = new Point(330, 150);
            min4.Size = new Size(25, 60);
            min4.MaxLength = 3;
            min4.Font = new Font(ResultBox1.Font.FontFamily, 12);
            min4.TextAlign = HorizontalAlignment.Center;

            min5.Location = new Point(330, 180);
            min5.Size = new Size(25, 60);
            min5.MaxLength = 3;
            min5.Font = new Font(ResultBox1.Font.FontFamily, 12);
            min5.TextAlign = HorizontalAlignment.Center;

            min6.Location = new Point(330, 210);
            min6.Size = new Size(25, 60);
            min6.MaxLength = 3;
            min6.Font = new Font(ResultBox1.Font.FontFamily, 12);
            min6.TextAlign = HorizontalAlignment.Center;

            min7.Location = new Point(330, 240);
            min7.Size = new Size(25, 60);
            min7.MaxLength = 3;
            min7.Font = new Font(ResultBox1.Font.FontFamily, 12);
            min7.TextAlign = HorizontalAlignment.Center;

            min8.Location = new Point(330, 270);
            min8.Size = new Size(25, 60);
            min8.MaxLength = 3;
            min8.Font = new Font(ResultBox1.Font.FontFamily, 12);
            min8.TextAlign = HorizontalAlignment.Center;

            min9.Location = new Point(330, 300);
            min9.Size = new Size(25, 60);
            min9.MaxLength = 3;
            min9.Font = new Font(ResultBox1.Font.FontFamily, 12);
            min9.TextAlign = HorizontalAlignment.Center;

            min10.Location = new Point(330, 330);
            min10.Size = new Size(25, 60);
            min10.MaxLength = 3;
            min10.Font = new Font(ResultBox1.Font.FontFamily, 12);
            min10.TextAlign = HorizontalAlignment.Center;

            min11.Location = new Point(330, 360);
            min11.Size = new Size(25, 60);
            min11.MaxLength = 3;
            min11.Font = new Font(ResultBox1.Font.FontFamily, 12);
            min11.TextAlign = HorizontalAlignment.Center;

            sub1in.Location = new Point(240, 60);
            sub1in.Size = new Size(25, 60);
            sub1in.MaxLength = 2;
            sub1in.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub1in.TextAlign = HorizontalAlignment.Center;

            sub1out.Location = new Point(285, 60);
            sub1out.Size = new Size(25, 60);
            sub1out.MaxLength = 2;
            sub1out.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub1out.TextAlign = HorizontalAlignment.Center;

            sub2in.Location = new Point(240, 90);
            sub2in.Size = new Size(25, 60);
            sub2in.MaxLength = 2;
            sub2in.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub2in.TextAlign = HorizontalAlignment.Center;

            sub2out.Location = new Point(285, 90);
            sub2out.Size = new Size(25, 60);
            sub2out.MaxLength = 2;
            sub2out.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub2out.TextAlign = HorizontalAlignment.Center;

            sub3in.Location = new Point(240, 120);
            sub3in.Size = new Size(25, 60);
            sub3in.MaxLength = 2;
            sub3in.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub3in.TextAlign = HorizontalAlignment.Center;

            sub3out.Location = new Point(285, 120);
            sub3out.Size = new Size(25, 60);
            sub3out.MaxLength = 2;
            sub3out.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub3out.TextAlign = HorizontalAlignment.Center;

            sub4in.Location = new Point(240, 150);
            sub4in.Size = new Size(25, 60);
            sub4in.MaxLength = 2;
            sub4in.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub4in.TextAlign = HorizontalAlignment.Center;

            sub4out.Location = new Point(285, 150);
            sub4out.Size = new Size(25, 60);
            sub4out.MaxLength = 2;
            sub4out.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub4out.TextAlign = HorizontalAlignment.Center;

            sub5in.Location = new Point(240, 180);
            sub5in.Size = new Size(25, 60);
            sub5in.MaxLength = 2;
            sub5in.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub5in.TextAlign = HorizontalAlignment.Center;

            sub5out.Location = new Point(285, 180);
            sub5out.Size = new Size(25, 60);
            sub5out.MaxLength = 2;
            sub5out.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub5out.TextAlign = HorizontalAlignment.Center;
        
            sub6in.Location = new Point(240, 210);
            sub6in.Size = new Size(25, 60);
            sub6in.MaxLength = 2;
            sub6in.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub6in.TextAlign = HorizontalAlignment.Center;

            sub6out.Location = new Point(285, 210);
            sub6out.Size = new Size(25, 60);
            sub6out.MaxLength = 2;
            sub6out.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub6out.TextAlign = HorizontalAlignment.Center;

            sub7in.Location = new Point(240, 240);
            sub7in.Size = new Size(25, 60);
            sub7in.MaxLength = 2;
            sub7in.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub7in.TextAlign = HorizontalAlignment.Center;

            sub7out.Location = new Point(285, 240);
            sub7out.Size = new Size(25, 60);
            sub7out.MaxLength = 2;
            sub7out.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub7out.TextAlign = HorizontalAlignment.Center;

            sub8in.Location = new Point(240, 270);
            sub8in.Size = new Size(25, 60);
            sub8in.MaxLength = 2;
            sub8in.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub8in.TextAlign = HorizontalAlignment.Center;

            sub8out.Location = new Point(285, 270);
            sub8out.Size = new Size(25, 60);
            sub8out.MaxLength = 2;
            sub8out.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub8out.TextAlign = HorizontalAlignment.Center;

            sub9in.Location = new Point(240, 300);
            sub9in.Size = new Size(25, 60);
            sub9in.MaxLength = 2;
            sub9in.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub9in.TextAlign = HorizontalAlignment.Center;

            sub9out.Location = new Point(285, 300);
            sub9out.Size = new Size(25, 60);
            sub9out.MaxLength = 2;
            sub9out.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub9out.TextAlign = HorizontalAlignment.Center;

            sub10in.Location = new Point(240, 330);
            sub10in.Size = new Size(25, 60);
            sub10in.MaxLength = 2;
            sub10in.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub10in.TextAlign = HorizontalAlignment.Center;

            sub10out.Location = new Point(285, 330);
            sub10out.Size = new Size(25, 60);
            sub10out.MaxLength = 2;
            sub10out.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub10out.TextAlign = HorizontalAlignment.Center;

            sub11in.Location = new Point(240, 360);
            sub11in.Size = new Size(25, 60);
            sub11in.MaxLength = 2;
            sub11in.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub11in.TextAlign = HorizontalAlignment.Center;

            sub11out.Location = new Point(285, 360);
            sub11out.Size = new Size(25, 60);
            sub11out.MaxLength = 2;
            sub11out.Font = new Font(ResultBox1.Font.FontFamily, 12);
            sub11out.TextAlign = HorizontalAlignment.Center;

            Subinboxes.Add(sub1in);
            Suboutboxes.Add(sub1out);
            Subminboxes.Add(min1);
            Subinboxes.Add(sub2in);
            Suboutboxes.Add(sub2out);
            Subminboxes.Add(min2);
            Subinboxes.Add(sub3in);
            Suboutboxes.Add(sub3out);
            Subminboxes.Add(min3);
            Subinboxes.Add(sub4in);
            Suboutboxes.Add(sub4out);
            Subminboxes.Add(min4);
            Subinboxes.Add(sub5in);
            Suboutboxes.Add(sub5out);
            Subminboxes.Add(min5);
            Subinboxes.Add(sub6in);
            Suboutboxes.Add(sub6out);
            Subminboxes.Add(min6);
            Subinboxes.Add(sub7in);
            Suboutboxes.Add(sub7out);
            Subminboxes.Add(min7);
            Subinboxes.Add(sub8in);
            Suboutboxes.Add(sub8out);
            Subminboxes.Add(min8);
            Subinboxes.Add(sub9in);
            Suboutboxes.Add(sub9out);
            Subminboxes.Add(min9);
            Subinboxes.Add(sub10in);
            Suboutboxes.Add(sub10out);
            Subminboxes.Add(min10);
            Subinboxes.Add(sub11in);
            Suboutboxes.Add(sub11out);
            Subminboxes.Add(min11);

            In.Hide();
            Out.Hide();
            MinutesLabel.Hide();

            foreach (TextBox item in Subinboxes)
            {
                Controls.Add(item);
                item.Hide();
            }
            foreach (TextBox item in Suboutboxes)
            {
                Controls.Add(item);
                item.Hide();
            }
            foreach (TextBox item in Subminboxes)
            {
                Controls.Add(item);
                item.Hide();
            }


        }
        private void DoResultBox()
        {

            ResultBox1.Location = new Point(230, 54);
            ResultBox1.Size = new Size(35, 90);
            ResultBox1.Name = "ResultBox1";
            ResultBox1.Maximum = 20;
            ResultBox1.Font = new Font(ResultBox1.Font.FontFamily, 12);
            ResultBox1.TextAlign = HorizontalAlignment.Center;

            ResultBox2.Location = new Point(285, 54);
            ResultBox2.Size = new Size(35, 90);
            ResultBox2.Name = "ResultBox2";
            ResultBox2.Maximum = 20;
            ResultBox2.Font = new Font(ResultBox2.Font.FontFamily, 12);
            ResultBox2.TextAlign = HorizontalAlignment.Center;

            this.Controls.Add(ResultBox1);
            this.Controls.Add(ResultBox2);
            ResultBox1.Hide();
            ResultBox2.Hide();
            line.Hide();
        }
        private void DoPlayerboxes()
        {
            ContinueButton2.Hide();
            ContinueButton3.Hide();
            ContinueButton4.Hide();
            ContinueButton5.Hide();
            ContinueButton6.Hide();
            ContinueButton7.Hide();

            StartingPlayerBox.Location = new Point(240, 54);
            StartingPlayerBox.Size = new Size(200, 260);
            StartingPlayerBox.Name = "StartingPlayerBox";
            StartingPlayerBox.SelectionMode = SelectionMode.MultiSimple;

            // On the bench

            PlayersOnTheBenchBox.Location = new Point(240, 54);
            PlayersOnTheBenchBox.Size = new Size(200, 260);
            PlayersOnTheBenchBox.Name = "PlayersOnTheBenchBox";
            PlayersOnTheBenchBox.SelectionMode = SelectionMode.MultiSimple;

            this.Controls.Add(PlayersOnTheBenchBox);
            StartingPlayerBox.Hide();
            PlayersOnTheBenchBox.Hide();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            GoBackButton.Show();
            GameBox.Hide();
            ResultBox1.Show();
            ResultBox2.Show();
            line.Show();
            HeadLabel.Text = "Add result:";
            ContinueButton.Hide();
            ContinueButton2.Show();
            foreach (Game g in GameBox.SelectedItems)
            {
                SelectedGame = g;
            }
        }

        private void ContinueButton2_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            ResultBox1.Hide();
            ResultBox2.Hide();
            line.Hide();
            HeadLabel.Text = "Select started players:";
            StartingPlayerBox.Show();
            ContinueButton2.Hide();
            ContinueButton3.Show();
            players = db.GetAllPlayers(SelectedGame.DateTime);
            foreach (Person p in players)
            {
                StartingPlayerBox.Items.Add(p);
            }
            StartingPlayerBox.DataSource = players;
            StartingPlayerBox.DisplayMember = "PlayerInfo";
            this.Controls.Add(StartingPlayerBox);
        }

        private void ContinueButton3_Click(object sender, EventArgs e)
        {
            if (StartingPlayerBox.SelectedItems.Count != 11)
            {
                HeadLabel.ForeColor = Color.Red;
                HeadLabel.Text = $"You have to select 11 starting players! \nNow selected {StartingPlayerBox.SelectedItems.Count} players";
            }
            else
            {
                HeadLabel.ForeColor = Color.Black;
                StartingPlayerBox.Hide();
                StartingPlayerBox.Update();
                foreach (Person p in players)
                {
                    if (!StartingPlayerBox.SelectedItems.Contains(p))
                    {
                        onthebench.Add(p);
                    }
                    else
                    {
                        PlayedPlayers.Add(p);
                        StartedPlayers.Add(p);
                    }
                }
                PlayersOnTheBenchBox.DisplayMember = "PlayerInfo";
                PlayersOnTheBenchBox.DataSource = onthebench;
                PlayersOnTheBenchBox.Update();
                PlayersOnTheBenchBox.Show();
                HeadLabel.Text = "Select substitutes:";
                ContinueButton3.Hide();
                ContinueButton4.Show();
            }
        }

        private void ContinueButton4_Click(object sender, EventArgs e)
        {
            bool foul = false;
            foreach (Person p in PlayersOnTheBenchBox.SelectedItems)
            {
                SubstitutePlayers.Add(p);
                PlayedPlayers.Add(p);
            }
            List<int> numbers = new List<int>();
            foreach (Person item in PlayedPlayers)
            {
                if (numbers.Contains(item.Number))
                {
                    foul = true;
                }
                numbers.Add(item.Number);
            }
            if (foul == true)
            {
                HeadLabel.ForeColor = Color.Red;
                HeadLabel.Text = $"!!!!! You have players with same number on this game!!!!";
            }
            else
            {
                playertable.Columns.Add("Id", typeof (int));
                playertable.Columns.Add("FirstName", typeof(string));
                playertable.Columns.Add("LastName", typeof(string));
                playertable.Columns.Add("Number", typeof(int));
                playertable.Columns.Add("PlayerInfo2", typeof(string));

                foreach (Person p in PlayedPlayers)
                {
                    DataRow row = playertable.NewRow();
                    playertable.Rows.Add(p.Id, p.FirstName, p.LastName, p.Number, p.PlayerInfo2);
                }

                PlayersOnTheBenchBox.Hide();
                ContinueButton4.Hide();
                ContinueButton5.Show();
                HeadLabel.Text = "How many subs? (0-11)";
                subscount.Location = new Point(240, 60);
                subscount.Size = new Size(60, 100);
                subscount.Name = "subscount";
                subscount.Maximum = 11;
                subscount.Font = new Font(ResultBox1.Font.FontFamily, 12);
                subscount.TextAlign = HorizontalAlignment.Center;
                this.Controls.Add(subscount);
            }
        }



        private void ContinueButton5_Click(object sender, EventArgs e)
        {
            subs = int.Parse(subscount.Text);
            HeadLabel.Text = $"Add {subs} substitutions:";
            subscount.Hide();
            In.Show();
            Out.Show();
            MinutesLabel.Show();

            int count = 0;
            int count1 = 0;
            int count2 = 0;
            foreach (TextBox sub in Subinboxes)
            {
                count++;
                if (count <= (subs))
                {
                    sub.Show();
                }
            }
            foreach (TextBox sub in Suboutboxes)
            {
                count1++;
                if (count1 <= (subs))
                {
                    sub.Show();
                }
            }
            foreach (TextBox sub in Subminboxes)
            {
                count2++;
                if (count2 <= (subs))
                {
                    sub.Show();
                }
            }

            ContinueButton6.Location = new Point(243, (148 + (subs * 24)));

            foreach (ComboBox goal in goalboxes)
            {
                DataTable playertablecopy = playertable.Copy();
                goal.DataSource = playertablecopy;
                goal.DisplayMember = "PlayerInfo2";
                goal.SelectedIndex = -1;
                
            }
            foreach (ComboBox assist in assistboxes)
            {
                DataTable playertablecopy = playertable.Copy();
                assist.DataSource = playertablecopy;
                assist.DisplayMember = "PlayerInfo2";
                assist.SelectedIndex = -1;
            }

            ContinueButton5.Hide();
            ContinueButton6.Show();
        }
        private void ContinueButton6_Click(object sender, EventArgs e)
        {
            if (sub1in.Text != "")
            {
                SubsList.Add(new Substitution(int.Parse(sub1in.Text), int.Parse(sub1out.Text), int.Parse(min1.Text)));
            }
            if (sub2in.Text != "")
            {
                SubsList.Add(new Substitution(int.Parse(sub2in.Text), int.Parse(sub2out.Text), int.Parse(min2.Text)));
            }
            if (sub3in.Text != "")
            {
                SubsList.Add(new Substitution(int.Parse(sub3in.Text), int.Parse(sub3out.Text), int.Parse(min3.Text)));
            }
            if (sub4in.Text != "")
            {
                SubsList.Add(new Substitution(int.Parse(sub4in.Text), int.Parse(sub4out.Text), int.Parse(min4.Text)));
            }
            if (sub5in.Text != "")
            {
                SubsList.Add(new Substitution(int.Parse(sub5in.Text), int.Parse(sub5out.Text), int.Parse(min5.Text)));
            }
            if (sub6in.Text != "")
            {
                SubsList.Add(new Substitution(int.Parse(sub6in.Text), int.Parse(sub6out.Text), int.Parse(min6.Text)));
            }
            if (sub7in.Text != "")
            {
                SubsList.Add(new Substitution(int.Parse(sub7in.Text), int.Parse(sub7out.Text), int.Parse(min7.Text)));
            }
            if (sub8in.Text != "")
            {
                SubsList.Add(new Substitution(int.Parse(sub8in.Text), int.Parse(sub8out.Text), int.Parse(min8.Text)));
            }
            if (sub9in.Text != "")
            {
                SubsList.Add(new Substitution(int.Parse(sub9in.Text), int.Parse(sub9out.Text), int.Parse(min9.Text)));
            }
            if (sub10in.Text != "")
            {
                SubsList.Add(new Substitution(int.Parse(sub10in.Text), int.Parse(sub10out.Text), int.Parse(min10.Text)));
            }
            if (sub11in.Text != "")
            {
                SubsList.Add(new Substitution(int.Parse(sub11in.Text), int.Parse(sub11out.Text), int.Parse(min11.Text)));
            }


            HeadLabel.Text = "Add goals and assists";
            In.Hide();
            Out.Hide();
            MinutesLabel.Hide();
            foreach (TextBox sub in Subinboxes)
            {
                sub.Hide();
            }
            foreach (TextBox sub in Subminboxes)
            {
                sub.Hide();
            }
            foreach (TextBox sub in Suboutboxes)
            {
                sub.Hide();
            }

            foreach (Game g in GameBox.SelectedItems)
            {
                if (g.Home_match == false)
                {
                    AddStats(int.Parse(ResultBox2.Text));
                    SelectedGame = g;
                }
                if (g.Home_match == true)
                {
                    AddStats(int.Parse(ResultBox1.Text));
                    SelectedGame = g;
                }
            }
            ContinueButton6.Hide();
            ContinueButton7.Show();
        }

        private void AddStats(int i)
        {
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            
            foreach (ComboBox goal in goalboxes)
            {
                counter1++;
                if (counter1 <= i)
                {
                    goal.Show();
                }
            }
            foreach (Label label in goallabels)
            {
                counter2++;
                if (counter2 <= i)
                {
                    label.Show();
                }
            }
            foreach (ComboBox assist in assistboxes)
            {
                counter3++;
                if (counter3 <= i)
                {
                    assist.Show();
                }
            }
            foreach (Label label in assistlabels)
            {
                counter4++;
                if (counter4 <= i)
                {
                    label.Show();
                }
            }
        }

        private void ContinueButton7_Click(object sender, EventArgs e)
        {
            RedCardsLabel.Show();
            BookedLabel.Show();
            HeadLabel.Text = "Add bookings and red cards";

            foreach (ComboBox goal in goalboxes)
            {
                    goal.Hide();
            }
            foreach (Label label in goallabels)
            {
                    label.Hide();
            }
            foreach (ComboBox assist in assistboxes)
            {
                    assist.Hide();
            }
            foreach (Label label in assistlabels)
            {
                    label.Hide();
            }

            foreach(Person p in PlayedPlayers)
            {
                RedCardBox.Items.Add(p);
                RedCardBox.DisplayMember = "PlayerInfo";
                BookingBox.Items.Add(p);
                BookingBox.DisplayMember = "PlayerInfo";
            }

            RedCardBox.Show();
            BookingBox.Show();
            ContinueButton7.Hide();
            ContinueButton8.Show();
        }
        List<Person> redCardPlayers = new List<Person>();
        private void ContinueButton8_Click(object sender, EventArgs e)
        {



            // Showing all the information to user

            ContinueButton8.Hide();
            RedCardsLabel.Hide();
            BookedLabel.Hide();
            RedCardBox.Hide();
            BookingBox.Hide();
            HeadLabel.Text = $"Check the information on game {SelectedGame.SmallFixtureWithoutTheDate}:";

            StartedPlayersLabel.Text = "Started players: \n";
            foreach (Person p in StartedPlayers)
            {
                StartedPlayersLabel.Text += (p.FirstName + " " + p.LastName + "\n").ToString();
            }
            SubstitutesLabel.Text = "Bench:\n";
            SubstitutesLabel.Text += $"{PlayersOnTheBenchBox.SelectedItems.Count} players:\n";
            foreach (Person p in SubstitutePlayers)
            {
                SubstitutesLabel.Text += (p.FirstName + " " + p.LastName + "\n").ToString();
            }
            SubsLabel.Text = "Subs in: \n";
            foreach (TextBox sub in Subinboxes)
            {
                if (sub.Text != "")
                {
                    SubsLabel.Text += $"{sub.Text}\n";
                }
            }
            SubsLabel.Text += "Subs out: \n";
            foreach (TextBox sub in Suboutboxes)
            {
                if (sub.Text != "")
                {
                    SubsLabel.Text += $"{sub.Text}\n";
                }
            }
            ResultLabel.Text = $"Result: {ResultBox1.Value} - {ResultBox2.Value}";
            GoalsLabel.Text = "Goals: \n";
            foreach (ComboBox goal in goalboxes)
            {
                if (goal.Text != "")
                {
                    GoalsLabel.Text += $"{goal.Text}\n";
                }
            }
            AssistsLabel.Text = "Assists: \n";
            foreach (ComboBox assist in assistboxes)
            {
                if (assist.Text != "")
                {
                    AssistsLabel.Text += $"{assist.Text}\n";
                }
            }
            YellowsLabel.Text = "Bookings: \n";
            foreach (Person p in BookingBox.SelectedItems)
            {
                YellowsLabel.Text += $"{p.FirstName} {p.LastName}\n";
            }
            RedsLabel.Text = "Red cards: \n";
            foreach (Person p in RedCardBox.SelectedItems)
            {
                RedsLabel.Text += $"{p.FirstName} {p.LastName}\n";
            }

            AddResultButton.Show();
        }

        private void AddResultButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            // Adding result 
            if (SelectedGame.Home_match == true)
            {
                if (ResultBox1.Value > ResultBox2.Value)
                {
                    db.AddResult(SelectedGame.Id, $"{ResultBox1.Value}-{ResultBox2.Value}",1);
                }
                if (ResultBox1.Value < ResultBox2.Value)
                {
                    db.AddResult(SelectedGame.Id, $"{ResultBox1.Value}-{ResultBox2.Value}", 2);
                }
                if (ResultBox1.Value == ResultBox2.Value)
                {
                    db.AddResult(SelectedGame.Id, $"{ResultBox1.Value}-{ResultBox2.Value}", 0);
                }
            }
            else if(SelectedGame.Home_match == false)
            {
                if (ResultBox1.Value < ResultBox2.Value)
                {
                    db.AddResult(SelectedGame.Id, $"{ResultBox1.Value}-{ResultBox2.Value}", 1);
                }
                if (ResultBox1.Value > ResultBox2.Value)
                {
                    db.AddResult(SelectedGame.Id, $"{ResultBox1.Value}-{ResultBox2.Value}", 2);
                }
                if (ResultBox1.Value == ResultBox2.Value)
                {
                    db.AddResult(SelectedGame.Id, $"{ResultBox1.Value}-{ResultBox2.Value}", 0);
                }
            }

            // Adding player id and game id to stats table
            foreach (Person p in PlayedPlayers)
            {
                db.AddStats(SelectedGame.Serie, p.Id, SelectedGame.Id);
            }
            // Adding other stats
            foreach (Person p in PlayedPlayers)
            {
                int goals = 0;
                int assists = 0;
                int bookings = 0;
                int redcards = 0;
                int starting = 0;
                int onthebench = 0;
                int minutes = 0;
                int substitutedin = 0;

                foreach (ComboBox goal in goalboxes)
                {
                    if (goal.Text.Split(' ').Last() == p.Id.ToString())
                    {
                        goals++;
                    }
                }
                foreach (ComboBox assist in assistboxes)
                {
                    if (assist.Text.Split(' ').Last() == p.Id.ToString())
                    {
                        assists++;
                    }
                }
                foreach (Person player in BookingBox.SelectedItems)
                {
                    if (player.Id == p.Id)
                    {
                        bookings++;
                    }
                }
                foreach (Person player in RedCardBox.SelectedItems)
                {
                    RedCardMinutes form = new RedCardMinutes($"When {player.LastName} took red card:", player);
                 
                    if (player.Id == p.Id)
                    {
                        form.ShowDialog();
                        redcards++;
                        minutes -= (90-form.Minute);

                    }
                    
                }
                if (StartedPlayers.Contains(p))
                {
                    starting++;
                    minutes += 90;                    
                }
                if (SubstitutePlayers.Contains(p))
                {
                    onthebench++;
                }

                foreach (Substitution sub in SubsList)
                {
                    if (p.Number == sub.PlayerIn)
                    {
                        minutes += sub.PlayerInMinutes;
                        substitutedin++;
                    }
                    if (p.Number == sub.PlayerOut)
                    {
                        minutes -= sub.PlayerOutMinutes;
                    }
                }

                db.AddStatsByGameId(SelectedGame.Serie, p.Id, SelectedGame.Id, goals, assists, bookings,
                                    redcards, minutes, starting, substitutedin, onthebench);
            }
            GameAddedLabel.Show();
            GameAddedLabel.Text = $"Result against {SelectedGame.Opponent} added.";
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            if (ResultBox1.Visible == true) // Wrong game
            {
                GoBackButton.Hide();
                GameBox.Show();
                ResultBox1.Hide();
                ResultBox2.Hide();
                line.Hide();
                HeadLabel.Text = "Select game:";
                ContinueButton.Show();
                ContinueButton2.Hide();
            }
            if (StartingPlayerBox.Visible == true) // Wrong result
            {
                ResultBox1.Show();
                ResultBox2.Show();
                line.Show();
                HeadLabel.Text = "Add result:";
                StartingPlayerBox.Hide();
                ContinueButton2.Show();
                ContinueButton3.Hide();
                StartingPlayerBox.DataSource = null;
            }
            if (PlayersOnTheBenchBox.Visible == true) // If started players wrong
            {
                StartingPlayerBox.Show();
                StartingPlayerBox.Update();
                PlayersOnTheBenchBox.DataSource = null;
                PlayersOnTheBenchBox.Hide();
                HeadLabel.Text = "Select started players:";
                ContinueButton3.Show();
                ContinueButton4.Hide();

                foreach (Person p in players)
                {
                    if (!StartingPlayerBox.SelectedItems.Contains(p))
                    {
                        onthebench.Remove(p);
                    }
                    else
                    {
                        PlayedPlayers.Remove(p);
                        StartedPlayers.Remove(p);
                    }
                }
            }
            if (ContinueButton5.Visible == true) // If subs wrong 
            {
                HeadLabel.Text = "Select substitutes:";
                foreach (Person p in PlayersOnTheBenchBox.SelectedItems)
                {
                    SubstitutePlayers.Remove(p);
                    PlayedPlayers.Remove(p);
                }
                playertable.Columns.Remove("Id");
                playertable.Columns.Remove("FirstName");
                playertable.Columns.Remove("LastName");
                playertable.Columns.Remove("Number");
                playertable.Columns.Remove("PlayerInfo2");
                PlayersOnTheBenchBox.Show();
                ContinueButton4.Show();
                ContinueButton5.Hide();
                this.Controls.Remove(subscount);
            }
            if (ContinueButton6.Visible == true) // If subs count wrong
            {
                HeadLabel.Text = "How many subs? (0-11)";
                subscount.Show();
                In.Hide();
                Out.Hide();
                MinutesLabel.Hide();
                ContinueButton5.Show();
                ContinueButton6.Hide();
                foreach (TextBox sub in Subinboxes)
                {
                        sub.Hide();
                }
                foreach (TextBox sub in Suboutboxes)
                {
                        sub.Hide();
                }
                foreach (TextBox sub in Subminboxes)
                {
                        sub.Hide();
                }
            }
            // Seuraavaksi back-nappula myös vaihtojen korjaamiseen
            if (ContinueButton7.Visible == true)
            {
                
            }
        }
    }

  
}
