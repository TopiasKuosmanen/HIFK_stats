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
    public partial class EditPlayer : Form
    {
        List<Label> labels = new List<Label>();
        List<TextBox> textBoxes = new List<TextBox>();
        List<Person> players = new List<Person>();
        int playerid;

        public EditPlayer()
        {
            InitializeComponent();
            UpdateBindingPlayerStats();
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);
            labels.Add(label6);
            labels.Add(label7);
            labels.Add(label8);
            textBoxes.Add(FirstName);
            textBoxes.Add(LastName);
            textBoxes.Add(Number);
            textBoxes.Add(YearOfAccession);
            textBoxes.Add(ContractEndDate);
            textBoxes.Add(BirhDate);
        }

        private void searchPlayerStats_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            players = db.GetPlayersToEdit(PlayerNameText.Text);
            UpdateBindingPlayerStats();
        }

        private void UpdateBindingPlayerStats()
        {
            PlayerBox.DataSource = players;
            PlayerBox.DisplayMember = "EditPlayerInfo";
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Hide();
            PlayerNameText.Hide();
            searchPlayerStats.Hide();
            PlayerBox.Hide();
            EditButton.Hide();
            foreach (Label l in labels)
            {
                l.Show();
            }
            foreach (TextBox t in textBoxes)
            {
                t.Show();
            }
            UpdateButton.Show();
            foreach (Person p in PlayerBox.SelectedItems)
            {
                FirstName.Text = p.FirstName;
                LastName.Text = p.LastName;
                Number.Text = p.Number.ToString();
                YearOfAccession.Text = p.YearOfAccession.ToString();
                ContractEndDate.Text = p.ContractEndDate.ToString();
                BirhDate.Text = p.BirthDate.ToString();
                playerid = p.Id;
            }


        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            label1.Text = "New information updated.\nDo you want to edit another player?";
            yesButton.Show();
            noButton.Show();
            UpdateButton.Hide();
            foreach (Label l in labels)
            {
                l.Hide();
            }
            foreach (TextBox t in textBoxes)
            {
                t.Hide();
            }

            DataAccess db = new DataAccess();
            db.UpdatePlayerInformation(playerid, FirstName.Text, LastName.Text, int.Parse(Number.Text), int.Parse(YearOfAccession.Text), 
            Convert.ToDateTime(ContractEndDate.Text), Convert.ToDateTime(BirhDate.Text));

        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            this.Close();
            EditPlayer form = new EditPlayer();
            form.Show();
        }
    }
}
