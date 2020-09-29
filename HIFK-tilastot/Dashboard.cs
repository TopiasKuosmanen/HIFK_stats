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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private void LinkToFixtures_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Fixtures form = new Fixtures();
            form.Show();
        }

        private void LinkToResults_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Results form = new Results();
            form.Show();
        }

        private void LinkToPlayersAndStats_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Players form = new Players();
            form.Show();
        }

        private void LinkToMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            More form = new More();
            form.Show();
        }

        private void LinkToGoals_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Goals form = new Goals();
            form.Show();
        }

        private void LinkToOpponentsGoals_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpponentsGoals form = new OpponentsGoals();
            form.Show();
        }
    }
}
