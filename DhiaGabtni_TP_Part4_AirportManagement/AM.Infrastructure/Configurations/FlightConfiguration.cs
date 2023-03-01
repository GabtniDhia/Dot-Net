using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasKey(f => f.FlightId);
            builder.ToTable("MyFlights");

            // ManyToMany # FlightsToPassengers
            builder.HasMany(p => p.Passengers)
                .WithMany(f => f.Flights)
                .UsingEntity(p => p.ToTable("PassengerReservation"));

            // ManyToOne # FlightsToPlane
            //builder.HasOne(p => p.Plane)
            //    .WithMany(f => f.Flights)
            //    .HasForeignKey(f => f.FlightId);

        }
    }
}
