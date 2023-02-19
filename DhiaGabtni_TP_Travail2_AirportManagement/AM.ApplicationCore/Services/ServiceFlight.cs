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
        public Action<Plane> FlightsDetailsDel; 
        public Func<String,double> DurationAverageDel{ }
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
        //Question 10
        public void ShowFlightDates(Plane plane)
        {
            var query = from f in Flights
                        where f.plane.PlaneId == plane.PlaneId
                        select new { f.Destination, f.FlightDate };
            foreach (var f in query)
            {
                Console.WriteLine(f.Destination + " " + f.FlightDate);
            }

            //Methode Syntax
            //var query = Flights.Where(f=>f.plane.PlaneId == plane.PlaneId).Select(f => new { f.Destination,f.FlightDate});
        }

        // Question 11 
        public int ProgrammedFlightNumber(DateTime startdate)
        {
            var query = from f in Flights
                        where DateTime.Compare(f.FlightDate, startdate) > 0
                        && (f.FlightDate - startdate).TotalDays <= 7
                        select f;
            return query.Count();
        }

        //Question 12
        public double DurationAverage(string Destination)
        {
            var query = from f in Flights
                        where f.Destination.Equals(Destination)
                        select f.EstimatedDuration;
            return query.Average();
        }

        //Question 13
        public IList<Flight> OrderedDurationFlights()
        {
            var query = from f in Flights
                        orderby f.EstimatedDuration descending
                        select f;
            return query.ToList();
        }
            // var query = Flights.OrderedbyDescending (f => f.EstimatedDuration);
            //return query.ToList();


        //Question 14
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
    }


}
