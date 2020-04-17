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
    public partial class NewLeague : Form
    {
        
        public NewLeague()
        {
            InitializeComponent();

        }

        private void AddLeagueButton_Click(object sender, EventArgs e)
        {
            bool already = false;
            DataAccess db = new DataAccess();
            List<League> leaguesAlready = new List<League>();
            leaguesAlready = db.GetLeagues();

            foreach (var l in leaguesAlready)
            {
                if (LeagueName.Text == l.LeagueName)
                {
                    noLeague.Visible = true;
                    label3.ForeColor = System.Drawing.Color.Red;
                    label3.Text = $"There is already league named {l.LeagueName}";
                    already = true;
                }
            }
            if (LeagueName.Text == "")
            {
                noLeague.Visible = true;
                label3.ForeColor = System.Drawing.Color.Red;
                label3.Text = $"Empty";
            }
            if (already == false && LeagueName.Text != "")
            {
                noLeague.Visible = false;
                db.AddLeague(LeagueName.Text);
                label3.ForeColor = System.Drawing.Color.Green;
                label3.Text = $"League {LeagueName.Text} added succesfully";
            }
            

        }
    }
}
