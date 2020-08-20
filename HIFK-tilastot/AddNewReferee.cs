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
    public partial class AddNewReferee : Form
    {
        public AddNewReferee()
        {
            InitializeComponent();
        }

        private void AddingRefereeButton_Click(object sender, EventArgs e)
        {
            if (LastName.Text == "")
            {
                MustHaveLastName.Show();
            }
            else
            {
                MustHaveLastName.Hide();
                AreYouSure form = new AreYouSure($"Are you sure you want to add referee {FirstName.Text} {LastName.Text}");
                form.ShowDialog();
                Confirmation(form);
            }
        }
        private void Confirmation(AreYouSure areYouSure)
        {
            if (areYouSure.trueorfalse == true)
            {
                DataAccess db = new DataAccess();
                db.AddNewReferee(FirstName.Text, LastName.Text, DateTime.Parse(BirthDay.Text));

                confirm.Visible = true;
                confirm.Text = $"Referee {FirstName.Text} {LastName.Text} was successfully added";
                confirm.ForeColor = System.Drawing.Color.Green;
            }
            if (areYouSure.trueorfalse == false)
            {
                confirm.Visible = true;
                confirm.Text = "Adding referee has been canceled.";
                confirm.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
