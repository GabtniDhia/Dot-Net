// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore;
using AM.ApplicationCore.Domain;
using static AM.ApplicationCore.Domain.Plane;

Plane p1= new Plane();

p1.Capacity = 200;
p1.ManufactureDate = new DateOnly(2015, 01, 16);
p1.PlaneType = PlaneType.Boing;
p1.PlaneId= 2;

Console.WriteLine(p1);

Plane p2 = new Plane(10, new DateOnly(2015, 01, 16), PlaneType.Airbus);

Console.WriteLine(p2);

Passenger passenger= new Passenger();
passenger.PassengerType();

Staff staff= new Staff();
staff.PassengerType();

Traveller traveller= new Traveller();
traveller.PassengerType();

Console.WriteLine("Hello, World!");
