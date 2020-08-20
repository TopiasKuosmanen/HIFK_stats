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
        List<Game> onthisday = new List<Game>();
        DateTimePicker DateTimeBox1 = new DateTimePicker();
        DateTimePicker DateTimeBox2 = new DateTimePicker();
        public Results()
        {
            InitializeComponent();
            UpdateBindingResults();
            DoDateTimeBox1();
            DoDateTimeBox2();
            Onthisday();
        }

        private void Onthisday()
        {
            DataAccess db = new DataAccess();
            onthisday = db.GetOnThisDayGames();
            if (onthisday.Count == 0)
            {
                onthisdaylabel.Text = "";
                OnThisDayDataGridView.Hide();
            }
            else
            {
                onthisdaylabel.Text = "Games on this day:";
                OnThisDayDataGridView.Show();
                OnThisDayDataGridView.DataSource = onthisday;
            }
        }

        private void UpdateBindingResults()
        {
            //ResultsBox.Hide();
           // ResultsBox1.DataSource = results;
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


          //  ResultsBox1.DisplayMember = "FullInfo";
        }

        private void DoDateTimeBox1()
        {
            DateTimeBox1.Location = new Point(64, 88);
            DateTimeBox1.Size = new Size(141, 50);
            DateTimeBox1.Text = DateTime.Now.Date.ToShortDateString();
            DateTimeBox1.Format = DateTimePickerFormat.Custom;
            DateTimeBox1.CustomFormat = "dd.MM.yyyy";
            DateTimeBox1.Name = "DateTimeBox";

            this.Controls.Add(DateTimeBox1);
        }
        private void DoDateTimeBox2()
        {
            DateTimeBox2.Location = new Point(64, 110);
            DateTimeBox2.Size = new Size(141, 50);
            DateTimeBox2.Text = DateTime.Now.Date.ToShortDateString();
            DateTimeBox2.Format = DateTimePickerFormat.Custom;
            DateTimeBox2.CustomFormat = "dd.MM.yyyy";
            DateTimeBox2.Name = "DateTimeBox";

            this.Controls.Add(DateTimeBox2);
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
                results = db.GetResults(SelectLeague.Text, Convert.ToDateTime(DateTimeBox1.Text.ToString()), Convert.ToDateTime(DateTimeBox2.Text.ToString()));
            }
            ResultsDataGridView.DataSource = results;
           // UpdateBindingResults();
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
                sb.AppendLine("Id,Opponent,DateTime,Serie,Result,ResultCode,Stadion,Home_match,HomeMatchInfo,FullInfo,Referee");
                foreach (Game g in list)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process);
                        sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}",
                            g.Id,
                            g.Opponent,
                            g.DateTime,
                            g.Serie,
                            g.Result,
                            g.ResultCode,
                            g.Stadion,
                            g.Home_match,
                            g.HomeMatchInfo,
                            g.FullInfo,
                            g.Referee));
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
