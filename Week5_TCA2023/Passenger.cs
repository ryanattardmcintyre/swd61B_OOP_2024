using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_TCA2023
{
    public class Passenger
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string PassportNo { get; set; }

        public string Nationality { get; set; }

        public string Photo { get; set; }
        public DateTime Dob { get; set; }


        public Ticket BuyTicket(Flight f, string seat, string row, CategoryType category )
        {

            Ticket t = new Ticket(this);
            t.FlightNo = f.Number;
            t.SeatNo = seat;
            t.Row = row;
            t.Passport = this.PassportNo;
            t.Category = category;

            return t;
        }
    }
}
