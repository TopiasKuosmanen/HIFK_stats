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
    public partial class Fixtures : Form
    {
        List<Game> fixtures = new List<Game>();
        public Fixtures()
        {
            InitializeComponent();
            UpdateBindingFixtures();
        }

        private void UpdateBindingFixtures()
        {
            ResultsBox.DataSource = fixtures;
            ResultsBox.DisplayMember = "Fixture";
        }

        private void SearchResultsButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            MustHaveLeague.Visible = false;

            if (SelectLeague.Text == "Select league")
            {
                MustHaveLeague.Visible = true;
            }
            if (MustHaveLeague.Visible == false)
            {
                fixtures = db.GetFixtures(SelectLeague.Text);
            }
            UpdateBindingFixtures();
        }
    }
}
