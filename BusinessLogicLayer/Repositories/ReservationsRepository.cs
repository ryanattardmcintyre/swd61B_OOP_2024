using BusinessLogicLayer.DataContext;
using CommonDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repositories
{
    public class ReservationsRepository
    {
        private LibraryContext _context;
        public ReservationsRepository(LibraryContext context) { _context = context; }

        public void AddReservation(Reservation r)
        {
              _context.Reservations.Add(r);
              _context.SaveChanges();
        }

        public List<Reservation> GetReservations() {
            return _context.Reservations.ToList();
        }

        public List<Reservation> GetReservations(string username) {

            //var list = from r in _context.Reservations
            //           join b in _context.Books
            //           on r.BookFK equals b.Isbn
            //           where r.UsernameFK == username
            //           select new {
            //            Reservation = r,
            //            BookTitle = b.Title
            //             };

           return _context.Reservations.Where(x=>x.UsernameFK== username).ToList();
        }


        public List<Reservation> GetActiveReservations()
        {
            //25/11/2024 Duration 7 days
            //26/11/2024 <= 3/12/2024

            return _context.Reservations.Where(x => DateTime.Now <= x.From.AddDays(Convert.ToDouble(x.Days))).ToList();
        }


    }
}
