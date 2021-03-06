﻿using System;
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

    // Next thing to do: 
    // I want to add property where I can choose if game has an extra time or not. Usually not of course.
    // If I choose that there was an extra time on the game, application asks if there was penalties on the game.
    // If there was penalties, you have to set shooters and succesful and unsuccesful penalties. 
    // I have to think if winning pen will give a goal to players stats or not. 
    public partial class AddNewGame : Form
    {
        string team;
        ComboBox OpponentBox = new ComboBox();
        ComboBox LeagueBox = new ComboBox();
        ComboBox StadiumBox = new ComboBox();
        DateTimePicker DateTimeBox = new DateTimePicker();
        Boolean homegame;
        Boolean extratime = false;
        Boolean penalties = false;

        public AddNewGame()
        {
            InitializeComponent();
            DoOpponentBox();
            DoLeagueBox();
            DoStadiumBox();
            DoDateTimeBox();
            extraTimeOrNot.Text = "No";
            penaltiesOrNot.Text = "No";
        }

        private void DoDateTimeBox()
        {
            DateTimeBox.Location = new Point(240, 126);
            DateTimeBox.Size = new Size(141, 50);
            DateTimeBox.Text = DateTime.Now.Date.ToShortDateString();
            DateTimeBox.Format = DateTimePickerFormat.Custom;
            DateTimeBox.CustomFormat = "dd.MM.yyyy";
            DateTimeBox.Name = "DateTimeBox";
            
            this.Controls.Add(DateTimeBox);
        }

        private void DoLeagueBox()
        {
            DataAccess db = new DataAccess();
            List<League> leagues = new List<League>();

            leagues = db.GetLeagues();
            LeagueBox.Location = new Point(240, 54);
            LeagueBox.Size = new Size(141, 50);
            LeagueBox.DropDownStyle = ComboBoxStyle.DropDown;
            LeagueBox.Name = "LeagueBox";
            foreach (League l in leagues)
            {
                LeagueBox.Items.Add(l.LeagueName);
            }
            this.Controls.Add(LeagueBox);
        }

        private void DoOpponentBox()
        {
            DataAccess db = new DataAccess();
            List<Opponent> opponents = new List<Opponent>();

            opponents = db.GetOpponents();
            OpponentBox.Location = new Point(240, 90);
            OpponentBox.Size = new Size(141, 50);
            OpponentBox.DropDownStyle = ComboBoxStyle.DropDown;
            OpponentBox.Name = "OpponentBox";
            foreach (Opponent o in opponents)
            {
                OpponentBox.Items.Add(o.Team);
            }
            this.Controls.Add(OpponentBox);
        }

        private void DoStadiumBox()
        {
            DataAccess db = new DataAccess();
            List<Stadium> stadiums = new List<Stadium>();

            stadiums = db.GetStadiums();
            StadiumBox.Location = new Point(240, 210);
            StadiumBox.Size = new Size(141, 50);
            StadiumBox.DropDownStyle = ComboBoxStyle.DropDown;
            StadiumBox.Name = "StadiumBox";
            foreach (Stadium s in stadiums)
            {
                StadiumBox.Items.Add(s.Name);
            }
            this.Controls.Add(StadiumBox);
        }
        private void HomeOrAway_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HomeOrAway.SelectedItem.ToString() == "Home")
            {
                StadiumBox.Text = "Bolt Arena";
                StadiumBox.Update();
                homegame = true;
            }
            if (HomeOrAway.SelectedItem.ToString() == "Away")
            {
                DataAccess db = new DataAccess();
                List<Stadium> stadium = new List<Stadium>();
                team = OpponentBox.SelectedItem.ToString();
                stadium = db.GetStadiumByTeam(team);

                foreach (Stadium s in stadium)
                {
                    StadiumBox.Text = s.Name;
                }

                StadiumBox.Update();
                homegame = false;
            }
            
        }

        // Same thing with changing opponent: (NOT WORKING YET)

        //private void OpponentBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (HomeOrAway.SelectedItem.ToString() == "Home" || HomeOrAway.SelectedItem.ToString() == "")
        //    {
        //        StadiumBox.Text = "Bolt Arena";
        //        StadiumBox.Update();
        //        homegame = true;
        //    }
        //    if (HomeOrAway.SelectedItem.ToString() == "Away")
        //    {
        //        DataAccess db = new DataAccess();
        //        List<Stadium> stadium = new List<Stadium>();
        //        team = OpponentBox.SelectedItem.ToString();
        //        stadium = db.GetStadiumByTeam(team);

        //        foreach (Stadium s in stadium)
        //        {
        //            StadiumBox.Text = s.Name;
        //        }

        //        StadiumBox.Update();
        //        homegame = false;
        //    }
        //}



        private void AddingGameButton_Click(object sender, EventArgs e)
        {
            MustHaveHomeAway.Visible = false;
            MustHaveLeague.Visible = false;
            MustHaveOpponent.Visible = false;
            TimeForm.Visible = false;

            if (HomeOrAway.Text == "")
            {
                MustHaveHomeAway.Visible = true;
            }
            if (LeagueBox.Text == "")
            {
                MustHaveLeague.Visible = true;
            }
            if (OpponentBox.Text == "")
            {
                MustHaveOpponent.Visible = true;
            }
            if (TimeBox.Text == "" || TimeBox.Text.Length > 5 )
            {
                TimeForm.Visible = true;
            }
            if (MustHaveHomeAway.Visible == false && MustHaveLeague.Visible == false && MustHaveOpponent.Visible == false && TimeForm.Visible == false)
            { 
                AreYouSure form = new AreYouSure($"Are you sure you want to add {LeagueBox.SelectedItem.ToString()} game against {OpponentBox.SelectedItem.ToString()}");
                form.ShowDialog();
                Confirmation(form);
            }
        }

        private void Confirmation(AreYouSure areyousure)
        {
            if (areyousure.trueorfalse == true)
            {
                DataAccess db = new DataAccess();
                List<Game> games = new List<Game>();
                DateTime datetime;
                datetime = Convert.ToDateTime(DateTimeBox.Text.ToString() + " " + TimeBox.Text.ToString());

                db.AddNewGame(LeagueBox.SelectedItem.ToString(), OpponentBox.SelectedItem.ToString(), datetime, homegame, StadiumBox.SelectedItem.ToString(), extratime, penalties);

                Result.Text = $"Game against {OpponentBox.SelectedItem} was successfully added";
                Result.ForeColor = System.Drawing.Color.Green;
            }
            if (areyousure.trueorfalse == false)
            {
                Result.Text = "Adding game has been canceled.";
                Result.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void penaltiesOrNot_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (penaltiesOrNot.SelectedItem.ToString() == "No")
            {
                penalties = false;
            }
            if (penaltiesOrNot.SelectedItem.ToString() == "Yes")
            {
                penalties = true;
            }
        }

        private void extraTimeOrNot_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (extraTimeOrNot.SelectedItem.ToString() == "No")
            {
                extratime = false;
            }
            if (extraTimeOrNot.SelectedItem.ToString() == "Yes")
            {
                extratime = true;
            }
        }
    }
}
