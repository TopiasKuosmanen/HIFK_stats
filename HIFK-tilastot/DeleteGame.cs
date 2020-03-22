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
    public partial class DeleteGameButton : Form
    {
        ListBox GameBox = new ListBox();
        List<Game> selectedgames = new List<Game>();
        List<Game> games = new List<Game>();
        public DeleteGameButton()
        {
            InitializeComponent();
            DoGameBox();
        }

        private void DoGameBox()
        {
            DataAccess db = new DataAccess();
            

            games = db.GetGamesToDelete();
            GameBox1.DataSource = games;
            GameBox1.DisplayMember = "FullInfo";
            GameBox1.SelectionMode = SelectionMode.MultiSimple;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Game game in GameBox1.SelectedItems)
            {
                selectedgames.Add(game);
            }
            if (selectedgames.Count == 1)
            {
                foreach (Game game in selectedgames)
                {
                    AreYouSure form = new AreYouSure($"Are you sure you want to delete game {game.SmallFixtureWithoutTheDate}");
                    form.ShowDialog();
                    Confirmation(form);
                }
            }
            if (selectedgames.Count > 1)
            {
                AreYouSure form = new AreYouSure($"Are you sure you want to delete selected games?");
                form.ShowDialog();
                Confirmation(form);
            }
            
        }

        private void Confirmation(AreYouSure areYouSure)
        {
            GameBox1.Update();
            if (areYouSure.trueorfalse == true)
            {
                DataAccess db = new DataAccess();
                foreach (Game g in selectedgames)
                {
                    db.DeleteGame(g.Serie, g.Id, g.Result);

                }
                

                Result.Text = $"Game or games was successfully deleted";
                Result.ForeColor = System.Drawing.Color.Green;
                games = db.GetGamesToDelete();
                GameBox1.DataSource = games;
            }
            if (areYouSure.trueorfalse == false)
            {
                Result.Text = "The game removal has been canceled.";
                Result.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
    
}
