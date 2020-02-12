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
    public partial class Players : Form
    {
        List<Person> persons = new List<Person>();
        List<STATS> stats = new List<STATS>();
        public Players()
        {
            InitializeComponent();
            UpdateBindingPlayerStats();
            UpdateBindingPerson();
        }
        private void UpdateBindingPerson()
        {
            PersonfoundlistBox.DataSource = persons;
            PersonfoundlistBox.DisplayMember = "FullInfo";
        }
        private void UpdateBindingPlayerStats()
        {
            PlayerStats.DataSource = stats;
            PlayerStats.DisplayMember = "FullInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            persons = db.GetPersons(LastNameText.Text);
            UpdateBindingPerson();
        }
        private void NoPlayers_CheckedChanged(object sender, EventArgs e)
        {
            if (NoPlayers.Checked)
            {
                DataAccess db = new DataAccess();
                persons = db.GetPersonsWithoutPlayers(LastNameText.Text);
                UpdateBindingPerson();
            }
            else
            {
                DataAccess db = new DataAccess();
                persons = db.GetPersons(LastNameText.Text);
                UpdateBindingPerson();
            }
        }
        private void searchPlayerStats_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            

            if (TopScorers.Checked)
            {
                SelectLeague.Visible = true;
                stats = db.GetTopScorers(SelectLeague.Text);
                UpdateBindingPlayerStats();
                PlayerStats.DisplayMember = "TopScore";
            }
            else
            {
                stats = db.GetPlayerStats(PlayerNameText.Text);
                UpdateBindingPlayerStats();
            }

        }
        private void TopScorers_CheckedChanged(object sender, EventArgs e)
        {
            //    if (TopScorers.Checked)
            //    {
            //        SelectLeague.Visible = true;
            //        DataAccess db = new DataAccess();
            //        stats = db.GetTopScorers(SelectLeague.Text);
            //        UpdateBindingPlayerStats();
            //        PlayerStats.DisplayMember = "TopScore";
            //    }
            //    else
            //    {
            //        SelectLeague.Visible = false;
            //        DataAccess db = new DataAccess();
            //        stats = db.GetPlayerStats(PlayerNameText.Text);
            //        UpdateBindingPlayerStats();
            //    }
            }
        }
}
