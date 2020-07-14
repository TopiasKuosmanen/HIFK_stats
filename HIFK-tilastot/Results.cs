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
            ResultsDataGridView.DataSource = results;
            UpdateBindingResults();
        }
        // Export to Excel
        struct DataParameter
        {
            public List<Game> ResultsList;
            public string FileName { get; set; }
        }
        DataParameter _inputParameter;

        private void toExcel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
                return;
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    _inputParameter.ResultsList = ResultsDataGridView.DataSource as List<Game>;
                    _inputParameter.FileName = sfd.FileName;
                    progressBar.Minimum = 0;
                    progressBar.Value = 0;
                    backgroundWorker.RunWorkerAsync(_inputParameter);
                }
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Game> list = ((DataParameter)e.Argument).ResultsList;
            string filename = ((DataParameter)e.Argument).FileName;
            int index = 1;
            int process = list.Count;
            using (StreamWriter sw = new StreamWriter(new FileStream(filename, FileMode.Create), Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Id,Opponent,DateTime,Serie,Result,ResultCode,Stadion,Home_match,HomeMatchInfo,FullInfo");
                foreach (Game g in list)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process);
                        sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                            g.Id,
                            g.Opponent,
                            g.DateTime,
                            g.Serie,
                            g.Result,
                            g.ResultCode,
                            g.Stadion,
                            g.Home_match,
                            g.HomeMatchInfo,
                            g.FullInfo));
                    }
                }
                sw.Write(sb.ToString());
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Thread.Sleep(100);
            lblStatus.Text = "Your data has been succefully exported.";
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            lblStatus.Text = string.Format("Processing...{0}%", e.ProgressPercentage);
            progressBar.Update();
        }
    }
}
