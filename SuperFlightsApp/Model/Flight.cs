using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFlightsApp.Model
{
    public class Flight : Entity<long>
    {
        private string _from;
        private string _to;
        private DateTime _departureTime;
        private DateTime _arrivalTime;
        private int _economySeats;
        private int _businessSeats;
        private int _firstClassSeats;
        private float _price;

        public Flight(long id,
                    string from,
                    string to,
                    DateTime departureTime,
                    DateTime arrivalTime,
                    int economySeats,
                    int businessSeats,
                    int firstClassSeats,
                    float price) : base(id)
        {
            _from = from;
            _to = to;
            _departureTime = departureTime;
            _arrivalTime = arrivalTime;
            _economySeats = economySeats;
            _businessSeats = businessSeats;
            _firstClassSeats = firstClassSeats;
            _price = price;
        }

        public string From 
        {
            get { return _from; }
            set { _from = value; }
        }

        public string To
        {
            get { return _to; }
            set { _to = value; }
        }

        public DateTime DepartureTime
        {
            get { return _departureTime; }
            set { _departureTime = value; }
        }

        public DateTime ArrivalTime
        {
            get { return _arrivalTime; }
            set { _arrivalTime = value; }
        }

        public int EconomySeats
        {
            get { return _economySeats; }
            set { _economySeats = value; }
        }

        public int BusinessSeats 
        {
            get { return _businessSeats; }
            set { _businessSeats = value; }
        }

        public int FirstClassSeats
        {
            get { return _firstClassSeats; }
            set { _firstClassSeats = value; }

        }

        public float Price 
        {
            get { return _price; }
            set { _price = value; }
        }

    }
}
