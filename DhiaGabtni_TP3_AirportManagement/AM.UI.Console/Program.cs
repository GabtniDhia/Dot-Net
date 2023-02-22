using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
//using AM.ApplicationCore.Services;

Plane Boaing = new Plane();
Boaing.Capacity= 0;
Boaing.PlaneId=0;
Boaing.Planetype=0;

Console.WriteLine(Boaing.ToString());

ServiceFlight sf = new AM.ApplicationCore.Services.ServiceFlight();

sf.Flights = TestData.flights;

Console.Write(sf.Flights[0].Destination);