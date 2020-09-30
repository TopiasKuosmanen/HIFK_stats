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
    public partial class OpponentsGoals : Form
    {
        DateTimePicker DateTimeBox1 = new DateTimePicker();
        DateTimePicker DateTimeBox2 = new DateTimePicker();
        ListBox OpponentBox = new ListBox();
        List<League> leagues = new List<League>();
        List<OpponentGoal> goals = new List<OpponentGoal>();
        public OpponentsGoals()
        {
            InitializeComponent();
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
            OpponentBox.Items.Add("All");
            foreach (Opponent o in opponents)
            {
                OpponentBox.Items.Add(o.Team);
            }
            OpponentBox.SelectedIndex = 0;
            this.Controls.Add(OpponentBox);

            leagues = db.GetLeagues();

            foreach (League l in leagues)
            {
                listBox1.Items.Add(l.LeagueName);
            }
            listBox1.SelectedIndex = 0;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            bool winners;
            bool penalties;
            int? minmin;
            int? maxmin;
            if (MinMinute.Text == "")
            {
                minmin = null;
            }
            else
            {
                minmin = int.Parse(MinMinute.Text);
            }
            if (MaxMinute.Text == "")
            {
                maxmin = null;
            }
            else
            {
                maxmin = int.Parse(MaxMinute.Text);
            }
            if (WinnerBox.Checked)
            {
                winners = true;
            }
            else
            {
                winners = false;
            }
            if (PenBox.Checked)
            {
                penalties = true;
            }
            else
            {
                penalties = false;
            }

            DataAccess db = new DataAccess();
            goals = db.GetOpponentGoals(listBox1.SelectedItem.ToString(), OpponentBox.SelectedItem.ToString(), Convert.ToDateTime(DateTimeBox1.Text.ToString()), Convert.ToDateTime(DateTimeBox2.Text.ToString()), winners, penalties, minmin, maxmin);
            GoalsDataView.DataSource = goals;
        }

        private void toExcel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
                return;
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    _inputParameter.GoalsList = GoalsDataView.DataSource as List<OpponentGoal>;
                    _inputParameter.FileName = sfd.FileName;
                    progressBar.Minimum = 0;
                    progressBar.Value = 0;
                    backgroundWorker.RunWorkerAsync(_inputParameter);
                }
            }
        }
        struct DataParameter
        {
            public List<OpponentGoal> GoalsList;
            public string FileName { get; set; }
        }
        DataParameter _inputParameter;

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<OpponentGoal> list = ((DataParameter)e.Argument).GoalsList;
            string filename = ((DataParameter)e.Argument).FileName;
            int index = 1;
            int process = list.Count;
            using (StreamWriter sw = new StreamWriter(new FileStream(filename, FileMode.Create), Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Id,GameId,Score,Winner,Penalty,Minute");
                foreach (OpponentGoal s in list)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process);
                        sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5}",
                            s.Id, s.GameId, s.Score, s.Winner, s.Penalty, s.Minute));
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
