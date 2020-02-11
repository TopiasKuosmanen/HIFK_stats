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
    public partial class AreYouSure : Form
    {
        public bool trueorfalse { get; set; }
        public bool button1WasClicked = false;
        public bool button2WasClicked = false;
        public AreYouSure(string text)
        {
            InitializeComponent();
            TextLabel.Text = text;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            trueorfalse = true;
            button1WasClicked = true;
            this.Hide();
        }
        public void button2_Click(object sender, EventArgs e)
        {
            trueorfalse = false;
            button2WasClicked = true;
            //TextLabel.Text = "testi";
            this.Hide();
        }



    }
}
