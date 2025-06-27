using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace SuperFlightsApp
{
    public partial class LongFlight : Form
    {
        private Timer colorChangeTimer;
        private string colorState;

        public LongFlight()
        {
            InitializeComponent();

            blackPanel.Width = 0;
            colorState = "white";
            colorChangeTimer = new Timer();
            colorChangeTimer.Tick += ChangeColor;
            colorChangeTimer.Interval = 10;
        }

        private void ChangeColor(object? sender, EventArgs args)
        {
            if (colorState == "white")
            {
                blackPanelShrink();
            }
            else if (colorState == "black")
            {
                blackPanelExtend();
            }
        }

        private void blackPanelExtend()
        {

            if (blackPanel.Width >= 526)
            {
                blackPanel.Width = 526;
                colorChangeTimer.Stop();
            }
            else
            {
                blackPanel.Width = blackPanel.Width + Math.Abs(blackPanel.Width - 526) / 15 + 1;
            }
        }

        private void blackPanelShrink()
        {

            if (blackPanel.Width <= 0)
            {
                blackPanel.Width = 0;
                colorChangeTimer.Stop();
            }
            else
            {
                blackPanel.Width = blackPanel.Width - Math.Abs(blackPanel.Width) / 15 - 1;
            }
        }

        private void LongFlight_MouseEnter(object sender, EventArgs e)
        {
            colorChangeTimer.Stop();
            colorState = "black";
            colorChangeTimer.Start();
        }

        private void LongFlight_MouseLeave(object sender, EventArgs e)
        {
            colorChangeTimer.Stop();
            colorState = "white";
            colorChangeTimer.Start();
        }

        private void LongFlight_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
