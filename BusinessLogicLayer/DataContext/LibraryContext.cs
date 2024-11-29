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


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //lazy loading is a setting we are activating so that when you'd like to access data in other tables connected via 
            //a foreign key (in C# terms: a naviational property), you need not code inner join statements, but you can simply
            //access the property and its values as if you are dealing with normal classes

            optionsBuilder.UseLazyLoadingProxies();
        }


        //to do: LazyLoading ....it loads the data you need in the navigational properties automatically

    }
}
