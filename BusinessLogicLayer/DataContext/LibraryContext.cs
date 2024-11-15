using CommonDataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DataContext
{
    //How do we execute a Code first approach

    //why>

    //because the LibraryContext class is the representation of our database i.e 
    //it is an abstraction of the database
    public class LibraryContext: DbContext
    {
        //These in here are lists....but when we generate the database
        //tables will be created mapped on these
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Member> Members { get; set; }

        //in order to be able to pass the connection string (which will allow us to connect
        //to sql server)...we need this constructor
        public LibraryContext(DbContextOptions<LibraryContext> options) 
            : base(options)
        {
        }
    }
}
