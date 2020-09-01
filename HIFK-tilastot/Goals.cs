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
    public partial class Goals : Form
    {
        DateTimePicker DateTimeBox1 = new DateTimePicker();
        DateTimePicker DateTimeBox2 = new DateTimePicker();
        ListBox OpponentBox = new ListBox();
        List<League> leagues = new List<League>();
        List<GOAL> goals = new List<GOAL>();
        public Goals()
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
            foreach (Opponent o in opponents)
            {
                OpponentBox.Items.Add(o.Team);
            }
            this.Controls.Add(OpponentBox);

            leagues = db.GetLeagues();

            foreach (League l in leagues)
            {
                listBox1.Items.Add(l.LeagueName);
            }
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
            if (AllOpponents.Checked)
            {
                goals = db.GetGoals(listBox1.SelectedItem.ToString(), "All", Convert.ToDateTime(DateTimeBox1.Text.ToString()), Convert.ToDateTime(DateTimeBox2.Text.ToString()), PlayerNameText.Text, winners, penalties, AssistBox.Text, minmin, maxmin);
            }
            else
            {
                goals = db.GetGoals(listBox1.SelectedItem.ToString(), OpponentBox.SelectedItem.ToString(), Convert.ToDateTime(DateTimeBox1.Text.ToString()), Convert.ToDateTime(DateTimeBox2.Text.ToString()), PlayerNameText.Text, winners, penalties, AssistBox.Text, minmin, maxmin);
            }

            GoalsDataView.DataSource = goals;
        }
    }
}
