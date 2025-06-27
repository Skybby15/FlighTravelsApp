using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SuperFlightsApp.MiniForms;

namespace SuperFlightsApp
{
    public partial class FlightsForm : Form
    {
        public FlightsForm()
        {
            InitializeComponent();

            Form flight = new LongFlight();
            flight.TopLevel = false;

            flight.Click += (s, args) => 
            {
                MainForm.OnFlightSelection(); // here a flight should be given
            };

            Form flight2 = new LongFlight();
            flight2.TopLevel = false;

            flightsFlowPanel.Controls.Add(flight);
            flightsFlowPanel.Controls.Add(flight2);

            flight.Show();
            flight2.Show();

        }

        private void am()
        {
        }
    }
}
