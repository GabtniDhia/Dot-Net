// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;


ServiceFlight sf = new AM.ApplicationCore.Services.ServiceFlight();

sf.Flights = TestData.flights;

Console.Write(sf.Flights);
Console.WriteLine("Hello World");
sf.GetFlights("Destination","Paris");



