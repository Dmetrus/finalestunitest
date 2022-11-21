using System;
using System.Collections.Generic;
using System.Linq;
using bibl.models;

namespace bibl
{
    public class Class1
    {
        public IList<Flights> Flights = new List<Flights>();
        public IList<Flights> GetFlights() { return Flights; }
        public Flights Add(Flights flights) { Flights.Add(flights); return flights; }
        public Flights Remove(Flights flights) { Flights.Remove(flights); return flights; }
        public void Change(Flights id, Flights arg)
        {
            var index = Flights.IndexOf(id);
            Flights[index] = arg;
        }

    }
}