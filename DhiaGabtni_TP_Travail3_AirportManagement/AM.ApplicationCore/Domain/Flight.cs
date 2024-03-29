﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public String Destination { get; set; }
        public String Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public float EstimatedDuration { get; set; }
        public DateTime EffectiveArrival { get; set; }


        public List<Passenger>? Passengers { get; set; }
        public Plane? plane { get; set; }
        public override string? ToString()
        {
            return base.ToString();
        }
    }





}

