using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System
{
    class FlightTicket : Ticket
    {
        private string seatClass;
        private double luggageWeight;

        public string SeatClass
        {
            get { return this.seatClass; }
            set { this.seatClass = value; }
        }

        public double LuggageWeight
        {
            get { return this.luggageWeight; }
            set { this.luggageWeight = value; }
        }

        public FlightTicket() : base()
        {
            this.seatClass = "";
            this.luggageWeight = 0.0;
        }

        public FlightTicket(int ticketId, string passengerName, string seatClass, double luggageWeight)
            : base(ticketId, passengerName)
        {
            this.seatClass = seatClass;
            this.luggageWeight = luggageWeight;
        }

        public void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Seat Class: " + this.seatClass);
            Console.WriteLine("Luggage Weight: " + this.luggageWeight);
        }

        public bool IsExcessLuggage()
        {
            return this.luggageWeight > 20;
        }

        public bool IsPrioritySeat()
        {
            return this.seatClass == "Business";
        }

        public bool IsPrioritySeat(bool isFrequentFlyer)
        {
            return isFrequentFlyer && this.seatClass == "Business";
        }
    }
}
