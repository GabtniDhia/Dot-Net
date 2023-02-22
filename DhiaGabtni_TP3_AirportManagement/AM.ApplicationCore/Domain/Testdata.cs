using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        static Plane p1 = new Plane() { Planetype = 0, Capacity = 150, ManufactureDate = new DateTime(03 / 02 / 2015) };
        static Plane p2 = new Plane() { Planetype = PlaneType.Airbus, Capacity = 250, ManufactureDate = new DateTime(11 / 11 / 2020) };

        static IList<Plane> Planes = new List<Plane>() { p1, p2 };

        static Staff s1 = new Staff() { FirstName = "captain", LastName = "captain", EmailAddress = "captain.captain@gmail.com", BirthDate = new DateTime(01 / 01 / 1965), EmployementDate = new DateTime(01 / 01 / 1999), Salary = 9999 };
        static Staff s2 = new Staff() { FirstName = "hostess1", LastName = "hostess1", EmailAddress = "hostess1.hostess1@gmail.com", BirthDate = new DateTime(01 / 01 / 1999), EmployementDate = new DateTime(01 / 01 / 2020), Salary = 999 };

        static IList<Staff> Staffs = new List<Staff>() { s1, s2 };

        static Traveller t1 = new Traveller() { FirstName = "traveller1", LastName = "traveller1", EmailAddress = "traveller1.traveller1@gmail.com", BirthDate = new DateTime(01 / 01 / 1965), HealthInformation = "No Troubles", Nationality = "American" };
        static Traveller t2 = new Traveller() { FirstName = "traveller2", LastName = "traveller2", EmailAddress = "traveller2.traveller2@gmail.com", BirthDate = new DateTime(01 / 01 / 1965), HealthInformation = "Some Troubles", Nationality = "French" };

        static IList<Traveller> travellers = new List<Traveller>() { t1, t2 };
        private static readonly IList<Traveller> travellers1 = travellers;
        static Flight f1 = new Flight()
        {
            FlightDate = new DateTime(2022,01,01,15,10,10),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 01, 02, 15, 10, 10),
            plane = p2,
            EstimatedDuration = 110,
            Passengers = new List<Passenger> { t1,t2 }
        };
        public static List<Flight> flights = new List<Flight>() { f1 };
    }

}
