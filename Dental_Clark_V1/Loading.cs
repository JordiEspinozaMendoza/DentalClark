using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clark_V1
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.1;
            circularProgressBar2.Value += 1;
            circularProgressBar2.Text = circularProgressBar2.Value.ToString();
            if (circularProgressBar2.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }

        }

        private void Loading_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            circularProgressBar2.Value = 0;
            circularProgressBar2.Minimum = 0;
            circularProgressBar2.Maximum = 100;

            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity==0)
            {
                timer2.Stop();
                this.Close();
            }
        }
    }
}
