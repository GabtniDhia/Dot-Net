﻿using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class PassengerConfiguration:IEntityTypeConfiguration<Passenger>
    {

        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.Property(p => p.FirstName)
                .IsRequired().HasMaxLength(100)
                .HasColumnName("FirstNamePassenger")
                .HasColumnType("nchar")
                .HasDefaultValue("FirstName");
        }
    }
}
