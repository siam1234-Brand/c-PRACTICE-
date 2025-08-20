using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Service_Tracker
{
    public class Vehicle
    {
        protected string make;
        protected string model;
        protected int year;
        protected string registrationNumber;
        protected string[][] serviceRecords = new string[3][];

        //serviceRecords[0] = new string[] { "Oil Change", "Brake Inspection" };         // Year 1 services
       // serviceRecords[1] = new string[] { "Tire Rotation", "Battery Check" };         // Year 2 services
        //serviceRecords[2] = new string[] { "Engine Tune-up", "AC Maintenance" };       // Year 3 services

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            set { this.registrationNumber = value; }
        }

        public string[][] ServiceRecords
        {
            get { return this.serviceRecords; }
            set { this.serviceRecords = value; }
        }

        public Vehicle ()
        {
            Console.WriteLine("Empty constructor : vehicle");
        }
        public Vehicle(string make, string model, int year, string registrationNumber, string[][] serviceRecords)
        {
            Console.WriteLine("Paramiterized constructor : vehicle");
            this.make = make;
            this.model = model;
            this.year = year;
            this.registrationNumber = registrationNumber;
            this.serviceRecords = serviceRecords;
        }




    }
}
