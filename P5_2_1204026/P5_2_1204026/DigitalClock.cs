using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_2_1204025
{
    public partial class DigitalClock : UserControl
    {
        public DigitalClock()
        {
            InitializeComponent();
        }

        public bool Timer1_Enabled
        {
            get { return Timer1.Enabled; }
            set
            {
                Timer1.Enabled = value;
            }
        }

        public Color LocalTimerLabel_BackColor
        {
            get { return LocalTimeLabel.BackColor; }
            set
            {
                LocalTimeLabel.BackColor = value;
            }
        }

        public event System.EventHandler RaiseTimer1_Tick;

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            LocalTimeLabel.Text = System.DateTime.Now.ToString();
            if (RaiseTimer1_Tick != null)
            {
                RaiseTimer1_Tick(sender, e);
            }
        }
    }
}
