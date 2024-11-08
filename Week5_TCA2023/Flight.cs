using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_TCA2023
{
    public class Flight
    {
        public string Number { get; set; }
        public string AirportDeparture { get; set; }
        public string AirportDestination { get; set; }
        public int Capacity { get; set; }
        public DateTime Departure { get; set; }
        public DateTime EstimatedArrival { get; set; }


        public List<Ticket> Tickets { get; set; }
        public bool AddTicket(Ticket ticket)
        {
            //check that the ticket being added is not duplicate
            //to do: check that the ticket SeatNo + Row does not match any of the
            //       tickets inside Tickets

            //hint: you may use foreach loop

            //approach 1

          /*   foreach(Ticket t in Tickets)
            {
                if(t.SeatNo == ticket.SeatNo && t.Row == ticket.Row)
                {
                    //there will be an overbooking
                    //throw new Exception("Ticket is not available");
                    return false;
                }
            }
          
            Tickets.Add(ticket);
            return true;
          */

            //approach 2 //lambda expression

            if(Tickets.Count(t => t.SeatNo == ticket.SeatNo && t.Row == ticket.Row) > 0)
            {
                return false;
            }
            else
            {
                Tickets.Add(ticket);
                return true;
            }

            
        }


    }
}
