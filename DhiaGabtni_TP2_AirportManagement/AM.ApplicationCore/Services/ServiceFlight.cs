using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight 
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public IEnumerable<DateTime> GetFlightDates(string destination)
        {
            foreach (var flight in Flights)
            {
                if (flight.Destination == destination)
                    yield return flight.FlightDate;
            }
        }

        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (var flight in Flights)
                    {
                        if (flight.Destination == filterValue)
                            Console.Write(flight.ToString());
                    }
                    break;
                case "Departure":
                    foreach (var flight in Flights)
                    {
                        if (flight.Departure == filterValue)
                            Console.Write(flight.ToString());
                    }
                    break;
                case "FlightDate":
                    foreach (var flight in Flights)
                    {
                        if (flight.FlightDate.ToString() == filterValue)
                            Console.Write(flight.ToString());
                    }
                    break;
                case "EstimatedDuration":
                    foreach (var flight in Flights)
                    {
                        if (flight.EstimatedDuration.ToString() == filterValue)
                            Console.Write(flight.ToString());
                    }
                    break;
            }
        }
    }


}
