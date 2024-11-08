using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_TCA2023
{
    //an emum is a set of values
    //can be used like a class type to declare a field/propety/parameter/return type
    
    public enum CategoryType {Business =1,Economy=2, SuperEconomy=3 }
    public class Ticket
    {
        public string FlightNo { get; set; }
        public string Passport { get; set; }
        public string Row { get; set; }
        public string SeatNo { get; set; }
        public CategoryType Category { get; set; }

        public override bool Equals(object obj)
        {
            Ticket other = (Ticket)obj;
            if (SeatNo == other.SeatNo && Row == other.Row)
                return true;

            else return false;
        }

        public Passenger Passenger { get; set; }    
        public Ticket(Passenger passenger)
        {
            Passenger= passenger;
        }

    }
}
