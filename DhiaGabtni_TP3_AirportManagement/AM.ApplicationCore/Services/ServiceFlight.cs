using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        delegate void FlightDetailDel(Plane plane);
        delegate double DurationAverageDel(string text);
        public List<Flight> Flights { get; set; } = new List<Flight>();
        //public IEnumerable<DateTime> GetFlightDates(string Destination)
        //{
        //    foreach (var flight in Flights)
        //    {
        //        if (flight.Destination == Destination)
        //            yield return flight.FlightDate;
        //    }
        //}
        public IEnumerable<DateTime> GetFlightDates(string Destination)
        {
            IEnumerable<DateTime> dates = new List<DateTime>();
            dates = Flights.Where(x => x.Destination == Destination).Select(x => x.FlightDate).ToList();
            return dates;
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

        public void ShowFlightDetails(Plane plane)
        {
            var query = Flights.Where(f => f.plane.PlaneId == plane.PlaneId).Select(f => new { f.Destination, f.FlightDate });
            foreach (var f in query)
            {
                Console.WriteLine(f.Destination + " " + f.FlightDate);
            }

        }

        public int ProgramedFlightNumber (DateTime startDate)
        {
            var query = Flights.Where(f => f.FlightDate.CompareTo(startDate) > 0 && f.FlightDate.AddDays(7).CompareTo(startDate) < 0).Count();
            return query;
        }

        public double DurationAverage(string Destination)
        {
            var query = Flights.Where(f => f.Destination.Equals( Destination)).Average((f => f.EstimatedDuration));
            return query;
        }

        public IList<Flight> OrderedDurationFlights()
        {
            var query = from f in Flights
                        orderby f.EstimatedDuration descending
                        select f;
            return query.ToList();
        }

        public IEnumerable<Passenger> SeniorTraveler(Flight flight)
        {
            return (from f in flight.Passengers
                    where f is Traveller
                    orderby f.BirthDate
                    select f).Take(3);
        }
        public void DestinationGrouppedFlight()
        {
            var query = from f in Flights
                        group f by f.Destination;
            foreach (var group in query)
            {
                Console.WriteLine("Destination" + group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine("Decollage" + item.FlightDate);
                }
            }
        }

        public ServiceFlight()
        {
            FlightDetailDel flightDetailDel = ShowFlightDetails;
            DurationAverageDel durationAverageDel = DurationAverage;
        }
    }
    
}
