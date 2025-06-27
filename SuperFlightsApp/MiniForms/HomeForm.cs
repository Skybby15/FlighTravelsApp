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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();


            LoadPopularFlights();
            LoadNextFlights();
            LoadPastFlights();


        }

        private void LoadPopularFlights() 
        {
            MediumFlight flight = new MediumFlight();

            flight.TopLevel = false;
            popularFlightsPanel.Controls.Add(flight);
            flight.Show();
        }

        private void LoadNextFlights()
        { 
            SmallFlight flight = new SmallFlight();
            flight.TopLevel = false;

            nextFlightsPanel.Controls.Add(flight);
            flight.Show();
        }

        private void LoadPastFlights()
        {
            SmallFlight flight = new SmallFlight();
            flight.TopLevel = false;

            pastFlightsPanel.Controls.Add(flight);
            flight.Show();
        }
    }
}
