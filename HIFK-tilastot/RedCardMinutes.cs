using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIFK_tilastot
{
    public partial class RedCardMinutes : Form
    {
        private Label TextLabel;
        private Button button1;
        private TextBox MinuteBox;
        public int Minute;

        public RedCardMinutes(string text, Person player)
        {
            InitializeComponent();
            TextLabel.Text = $"{text}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Minute = int.Parse(MinuteBox.Text);
            this.Hide();
        }





        private void InitializeComponent()
        {
            this.TextLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MinuteBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel.Location = new System.Drawing.Point(78, 9);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(169, 25);
            this.TextLabel.TabIndex = 0;
            this.TextLabel.Text = "Red cards minute:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(114, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MinuteBox
            // 
            this.MinuteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuteBox.Location = new System.Drawing.Point(136, 51);
            this.MinuteBox.Name = "MinuteBox";
            this.MinuteBox.Size = new System.Drawing.Size(65, 30);
            this.MinuteBox.TabIndex = 2;
            // 
            // RedCardMinutes
            // 
            this.ClientSize = new System.Drawing.Size(352, 156);
            this.Controls.Add(this.MinuteBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextLabel);
            this.Name = "RedCardMinutes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
