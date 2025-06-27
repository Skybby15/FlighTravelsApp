using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFlightsApp.Model
{
    public enum SeatType 
    { 
        Economy,Business,FirstClass    
    }

    public class Ticket : Entity<long>
    {
        private Flight _flight;
        private User _user;
        private SeatType _seatType;


        public Ticket(long id,Flight flight, User user, SeatType seatType): base(id)
        {
            _flight = flight;
            _user = user;
            _seatType = seatType;
        }

        public Flight Flight
        {
            get { return _flight; }
            set { _flight = value; }
        }

        public User User
        { 
            get { return _user; }
            set { _user = value; }
        }

        public SeatType SeatType
        { 
            get { return _seatType; }
            set { _seatType = value; }
        }
    }
}
