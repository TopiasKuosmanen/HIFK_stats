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
    public partial class AddNewplayer : Form
    {
        ListBox NBox = new ListBox();
        ListBox PBox = new ListBox();

        public AddNewplayer()
        {
            DoNationalityBox();
            DoPositionsBox();
            InitializeComponent();

        }

        private void DoPositionsBox()
        {
            DataAccess db = new DataAccess();
            List<PlayerPosition> positions = new List<PlayerPosition>();
            positions = db.GetPositions();
            PBox.Location = new Point(299, 331);
            PBox.Size = new Size(141, 50);
            PBox.Name = "PositionBox";
            PBox.SelectionMode = SelectionMode.MultiSimple;
            foreach (PlayerPosition n in positions)
            {
                PBox.Items.Add(n.Position);
            }
            this.Controls.Add(PBox);
        }

        private void DoNationalityBox()
        {
            DataAccess db = new DataAccess();
            List<PlayerNationality> nationalities = new List<PlayerNationality>();
            nationalities = db.GetNationalities();
            NBox.Location = new Point(299, 292);
            NBox.Size = new Size(141, 50);
            NBox.Name = "NationalityBox";
            NBox.SelectionMode = SelectionMode.MultiSimple;
            foreach (PlayerNationality n in nationalities)
            {
                NBox.Items.Add(n.Nationality);
            }
            this.Controls.Add(NBox);

        }

        private void AddingPlayerButton_Click(object sender, EventArgs e)
        {
            MustHaveLastName.Visible = false;
            MustHaveContractEnds.Visible = false;
            MustHaveBirthday.Visible = false;

            if (MustHaveLastName.Text == "")
            {
                MustHaveLastName.Visible = true;
            }
            if (MustHaveContractEnds.Text == "")
            {
                MustHaveContractEnds.Visible = true;
            }
            if (MustHaveBirthday.Text == "")
            {
                MustHaveBirthday.Visible = true;
            }
            if (MustHaveLastName.Visible == false && MustHaveContractEnds.Visible == false && MustHaveBirthday.Visible == false)
            {
                AreYouSure form = new AreYouSure($"Are you sure you want to add player {FirstName.Text} {LastName.Text}");
                form.ShowDialog();
                Confirmation(form);
            }

        }

        private void Confirmation(AreYouSure areYouSure)
        {
            if (areYouSure.trueorfalse == true)
            {
                DataAccess db = new DataAccess();
                List<Person> persons = new List<Person>();
                db.AddNewPlayer(FirstName.Text, LastName.Text, int.Parse(ShirtNumber.Text), int.Parse(StartingYear.Text), DateTime.Parse(ContractEnds.Text), DateTime.Parse(Birthday.Text), PBox.Text, NBox.Text);

                persons = db.GetPersonId(FirstName.Text, LastName.Text, DateTime.Parse(Birthday.Text));
                
                foreach (Person p in persons)
                {

                    foreach (string nationality in NBox.SelectedItems)
                    {
                        db.AddNationalities(p.Id, nationality);
                        db.AddPlayerToStatsTables(p.Id);
                    }
                    foreach (string position in PBox.SelectedItems)
                    {
                        db.AddPositions(p.Id, position);
                    }
                    
                }

                Result.Text = $"Player {FirstName.Text} {LastName.Text} was successfully added";
                Result.ForeColor = System.Drawing.Color.Green;
            }
            if (areYouSure.trueorfalse == false)
            {
                Result.Text = "Adding player has been canceled.";
                Result.ForeColor = System.Drawing.Color.Red;
            }
        }

        
    }
}
