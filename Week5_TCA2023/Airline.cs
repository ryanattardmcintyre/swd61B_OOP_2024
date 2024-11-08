using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_TCA2023
{
    public class Airline
    {
        public string Name { get; set; }
        public List<Flight> Flights { get; } = new List<Flight>();
        public void AddFlight(Flight flight) { Flights.Add(flight); }
    }
}
