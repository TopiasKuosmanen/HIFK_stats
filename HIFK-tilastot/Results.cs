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
    public partial class Results : Form
    {
        List<Game> results = new List<Game>();
        public Results()
        {
            InitializeComponent();
            UpdateBindingResults();
        }

        private void UpdateBindingResults()
        {
            ResultsBox.Hide();
            ResultsBox1.DataSource = results;
            //ResultsBox.Columns.Add("Game", 20, HorizontalAlignment.Left);
            //ResultsBox.Columns.Add("Result", -2, HorizontalAlignment.Left);
            //ResultsBox.Columns.Add("Date", -2, HorizontalAlignment.Left);
            //ResultsBox.Columns.Add("League", -2, HorizontalAlignment.Left);
            //ResultsBox.Columns.Add("Stadium", -2, HorizontalAlignment.Left);
            //foreach (Game g in results)
            //{
            //    var a = new ListViewItem(new [] { g.SmallFixtureWithoutTheDate, g.Result, $"{g.DateTime}", g.Serie, g.Stadion});
            //    ResultsBox.Items.Add(a);
            //}

            //foreach (Game g in results)
            //{
            //    ResultsBox.Items.AddRange(new object[]{
            //        $"{g.SmallFixture}",
            //        $"{g.Result}",
            //        $"{g.Serie}",
            //        $"{g.Stadion}"
            //    });
            //}


            ResultsBox1.DisplayMember = "FullInfo";
        }

        private void SearchResultsButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            MustHaveLeague.Visible = false;
            MustHaveYear.Visible = false;

            if (SelectLeague.Text == "Select league")
            {
                MustHaveLeague.Visible = true;
            }
            if (SelectYear.Text == "Select year")
            {
                MustHaveYear.Visible = true;
            }
            if (MustHaveYear.Visible == false && MustHaveLeague.Visible == false)
            {
                if (SelectYear.Text == "All")
                {
                    results = db.GetResults(SelectLeague.Text, 0);
                }
                else
                {
                    results = db.GetResults(SelectLeague.Text, int.Parse(SelectYear.Text));
                }
            }
            UpdateBindingResults();
        }
    }
}
