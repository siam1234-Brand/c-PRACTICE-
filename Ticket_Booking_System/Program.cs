using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Train Tickets ===");

            TrainTicket train1 = new TrainTicket();
            train1.TicketId = 101;
            train1.PassengerName = "Alice";
            train1.CoachType = "AC";
            train1.Fare = 1200.00;
            train1.ShowDetails();
            Console.WriteLine("Is AC Coach? " + train1.IsAccCoach());
            Console.WriteLine("Tax Amount: " + train1.GetTaxAmount());
            Console.WriteLine();

            TrainTicket train2 = new TrainTicket(102, "Bob", "Sleeper", 800.00);
            train2.ShowDetails();
            Console.WriteLine("Is AC Coach? " + train2.IsAccCoach());
            Console.WriteLine("Tax Amount: " + train2.GetTaxAmount());
            Console.WriteLine();

            Console.WriteLine("=== Flight Tickets ===");

            FlightTicket flight1 = new FlightTicket();
            flight1.TicketId = 201;
            flight1.PassengerName = "Charlie";
            flight1.SeatClass = "Business";
            flight1.LuggageWeight = 25.5;
            flight1.ShowDetails();
            Console.WriteLine("Excess Luggage? " + flight1.IsExcessLuggage());
            Console.WriteLine("Priority Seat? " + flight1.IsPrioritySeat());
            Console.WriteLine("Priority for Frequent Flyer? " + flight1.IsPrioritySeat(true));
            Console.WriteLine();

            FlightTicket flight2 = new FlightTicket(202, "Diana", "Economy", 18.0);
            flight2.ShowDetails();
            Console.WriteLine("Excess Luggage? " + flight2.IsExcessLuggage());
            Console.WriteLine("Priority Seat? " + flight2.IsPrioritySeat());
            Console.WriteLine("Priority for Frequent Flyer? " + flight2.IsPrioritySeat(true));
            Console.WriteLine();

            Console.WriteLine("Total Bookings: " + Ticket.TotalBookings);
        }
    }
}
