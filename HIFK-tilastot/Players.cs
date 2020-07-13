using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIFK_tilastot
{
    public partial class Players : Form
    {
        List<Person> persons = new List<Person>();
        List<STATS> stats = new List<STATS>();
        List<STATS> allStats = new List<STATS>();

        public Players()
        {
            InitializeComponent();
            UpdateBindingPlayerStats();
            UpdateBindingPerson();
        }
        private void UpdateBindingPerson()
        {
            PersonfoundlistBox.DataSource = persons;
            //PersonfoundlistBox.DisplayMember = "FullInfo";
        }
        private void UpdateBindingPlayerStats()
        {
            PlayerStats.DataSource = stats;
            //PlayerStats.DisplayMember = "FullInfo";
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
            if (SelectYear.Text != "Select year" && SelectLeague.Text != "Select league")
            {
                noYear.Visible = false;
                noLeague.Visible = false;
                if (SelectYear.Text == "All")
                {
                    allStats = db.GetAllStats(SelectLeague.Text, 0);
                }
                else
                {
                    allStats = db.GetAllStats(SelectLeague.Text, int.Parse(SelectYear.Text));
                }
                PlayersStatsView.DataSource = allStats;

                foreach (DataGridViewColumn column in PlayersStatsView.Columns)
                {
                    // ei toimi:
                    // https://stackoverflow.com/questions/5553100/how-to-enable-datagridview-sorting-when-user-clicks-on-the-column-header
                    // https://timvw.be/2007/02/22/presenting-the-sortablebindinglistt/
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }

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
            else
            {
                if (SelectYear.Text == "Select year")
                {
                    noYear.Visible = true;
                }
                if (SelectLeague.Text == "Select league")
                {
                    noLeague.Visible = true;
                }
            }
            

        }
        private void TopScorers_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        // Export to Excel
        private void toExcel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
                return;
            using(SaveFileDialog sfd=new SaveFileDialog() { Filter="CSV|*.csv",ValidateNames=true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    _inputParameter.StatsList = PlayersStatsView.DataSource as List<STATS>;
                    _inputParameter.FileName = sfd.FileName;
                    progressBar.Minimum = 0;
                    progressBar.Value = 0;
                    backgroundWorker.RunWorkerAsync(_inputParameter);
                }
            }
        }
        struct DataParameter
        {
            public List<STATS> StatsList;
            public string FileName { get; set; }
        }
        DataParameter _inputParameter;

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<STATS> list = ((DataParameter)e.Argument).StatsList;
            string filename = ((DataParameter)e.Argument).FileName;
            int index = 1;
            int process = list.Count;
            using(StreamWriter sw = new StreamWriter(new FileStream(filename, FileMode.Create), Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("FirstName,LastName,Games,Goals,Assists,YellowCards,RedCards,PlayedMinutes,StartingXI,SubstitutedIn,OnTheBench");
                foreach (STATS s in list)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process);
                        sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}",
                            s.FirstName, s.LastName, s.Games, s.Goals, s.Assists, s.YellowCards, s.RedCards,
                            s.PlayedMinutes, s.StartingXI, s.SubstitutedIn, s.OnTheBench));
                    }
                }
                sw.Write(sb.ToString());
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            lblStatus.Text = string.Format("Processing...{0}%", e.ProgressPercentage);
            progressBar.Update();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Thread.Sleep(100);
            lblStatus.Text = "Your data has been succefully exported.";
        }
    }
}
