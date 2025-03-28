using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperFlightsApp
{
    public partial class FlightsForm: Form
    {
        public FlightsForm()
        {
            InitializeComponent();

            Form flight = new Flight();
            flight.TopLevel = false;

            Form flight2 = new Flight();
            flight2.TopLevel = false;

            flightsFlowPanel.Controls.Add(flight);
            flightsFlowPanel.Controls.Add(flight2);
            //flightsFlowPanel.Controls.Add(flight);

            flight.Show();
            flight2.Show();

        }
    }
}
