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
    public partial class More : Form
    {
        public More()
        {
            InitializeComponent();
        }

        private void LinkToNewGame_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewGame form = new AddNewGame();
            form.Show();
        }

        private void LinkToNewResult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewResult form = new AddNewResult();
            form.Show();
        }

        private void LinkToDeleteGame_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteGameButton form = new DeleteGameButton();
            form.Show();
        }

        private void LinkToEditGame_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditGame form = new EditGame();
            form.Show();
        }

        private void LinkToAddNewPlayer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewplayer form = new AddNewplayer();
            form.Show();
        }

        private void LinkToAddNewOpponent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewOpponent form = new AddNewOpponent();
            form.Show();
        }

        private void LinkToEditPlayer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditPlayer form = new EditPlayer();
            form.Show();
        }
    }

}
