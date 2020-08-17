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
        DateTimePicker DateTimeBox1 = new DateTimePicker();
        DateTimePicker DateTimeBox2 = new DateTimePicker();
        ListBox OpponentBox = new ListBox();

        public Players()
        {
            InitializeComponent();
            UpdateBindingPlayerStats();
            UpdateBindingPerson();
            DoDateTimeBox1();
            DoDateTimeBox2();
            DoOpponentBox();
        }
        private void DoDateTimeBox1()
        {
            DateTimeBox1.Location = new Point(280, 88);
            DateTimeBox1.Size = new Size(141, 50);
            DateTimeBox1.Text = DateTime.Now.Date.ToShortDateString();
            DateTimeBox1.Format = DateTimePickerFormat.Custom;
            DateTimeBox1.CustomFormat = "dd.MM.yyyy";
            DateTimeBox1.Name = "DateTimeBox";

            this.Controls.Add(DateTimeBox1);
        }
        private void DoDateTimeBox2()
        {
            DateTimeBox2.Location = new Point(280, 110);
            DateTimeBox2.Size = new Size(141, 50);
            DateTimeBox2.Text = DateTime.Now.Date.ToShortDateString();
            DateTimeBox2.Format = DateTimePickerFormat.Custom;
            DateTimeBox2.CustomFormat = "dd.MM.yyyy";
            DateTimeBox2.Name = "DateTimeBox";

            this.Controls.Add(DateTimeBox2);
        }
        private void DoOpponentBox()
        {
            DataAccess db = new DataAccess();
            List<Opponent> opponents = new List<Opponent>();

            opponents = db.GetOpponents();
            OpponentBox.Location = new Point(130, 28);
            OpponentBox.Size = new Size(141, 150);
            OpponentBox.Name = "OpponentBox";
            OpponentBox.SelectionMode = SelectionMode.One;
            foreach (Opponent o in opponents)
            {
                OpponentBox.Items.Add(o.Team);
            }
            this.Controls.Add(OpponentBox);
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
            stats = db.GetAllStats(listBox1.SelectedItem.ToString(), OpponentBox.SelectedItem.ToString(), Convert.ToDateTime(DateTimeBox1.Text.ToString()), Convert.ToDateTime(DateTimeBox2.Text.ToString()), PlayerNameText.Text);
           // UpdateBindingPerson();
            PlayersStatsView.DataSource = stats;
        }
        
        private void searchPlayerStats_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            PlayersStatsView.DataSource = allStats;

            foreach (DataGridViewColumn column in PlayersStatsView.Columns)
            {
                // ei toimi:
                // https://stackoverflow.com/questions/5553100/how-to-enable-datagridview-sorting-when-user-clicks-on-the-column-header
                // https://timvw.be/2007/02/22/presenting-the-sortablebindinglistt/
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

                
            stats = db.GetPlayerStats(PlayerNameText.Text);
            UpdateBindingPlayerStats();
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
