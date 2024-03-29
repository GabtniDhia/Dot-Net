﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        public Plane()
        {
        }

        public Plane(int capacity, DateTime manufactureDate, PlaneType planetype)
        {
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            Planetype = planetype;
        }
        [Range(1,int.MaxValue)]
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType Planetype { get; set;}


       




        public List<Flight>? Flights { get; set; }

        public override string? ToString()
        {
            return ( Capacity + " " + PlaneType.Boing + "ID: " + PlaneId);
        }
    }

}


public enum PlaneType{
Boing,Airbus

}