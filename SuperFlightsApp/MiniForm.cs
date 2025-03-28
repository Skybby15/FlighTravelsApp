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
    public partial class MiniForm : Form
    {
        private Timer dubaiPanelSlider;
        private string stare;

        public MiniForm()
        {
            InitializeComponent();
            dubaiPanelSlider = new Timer();
            dubaiPanelSlider.Tick += dubaiPanelSlide;
            dubaiPanelSlider.Interval = 10;
        }

        private void dubaiPanelSlide(object? sender, EventArgs args)
        {
            if (stare == "extend")
                dubaiPanelExtend();
            else if(stare == "shrink")
                dubaiPanelShrink();
        }

        private void dubaiPanelExtend()
        {

            dubaiLabel.Text = dubaiPic.Width.ToString();
            if (dubaiPic.Width >= 635)
            {
                dubaiPic.Width = 635;
                dubaiPanelSlider.Stop();
            }
            else
            {
                dubaiPic.Width = dubaiPic.Width + Math.Abs(dubaiPic.Width - 635) / 10 + 1;
            }
        }

        private void dubaiPanelShrink()
        {

            dubaiLabel.Text = dubaiPic.Width.ToString();
            if (dubaiPic.Width <= 400)
            {
                dubaiPic.Width = 400;
                dubaiPanelSlider.Stop();
            }
            else
            {
                dubaiPic.Width = dubaiPic.Width - Math.Abs(dubaiPic.Width - 400) / 10 - 1;
            }
        }

        private void dubaiPanel_MouseEnter(object sender, EventArgs e)
        {
            dubaiPanelSlider.Stop();
            stare = "extend";
            dubaiPanelSlider.Start();
        }

        private void dubaiPanel_MouseHover(object sender, EventArgs e)
        {

        }

        private void dubaiPanel_MouseLeave(object sender, EventArgs e)
        {
            dubaiPanelSlider.Stop();
            stare = "shrink";
            dubaiPanelSlider.Start();
        }
    }
}
