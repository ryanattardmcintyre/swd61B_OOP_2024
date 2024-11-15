using BusinessLogicLayer.DataContext;
using Microsoft.EntityFrameworkCore;

namespace PresenationConsoleApp
{
    //Console application its an executable applicatin which normally its like a command-line tool
    //Class library its a type of project is non-executable meaning the only purpose is to produce a dll which holds
    //              any developed classes and promotes reusabilty of those classes


    internal class Program
    {
        static void Main(string[] args)
        {
            //connectionString is like the address of the database
            //Server name is the server name you need to connect to. it can also be an ip address
            //Database is the name of database you will try to connect to because a server can contain many databases
            //Trusted_Connection means that you're connecting with the server using your Windows account; if it is not trusted connection
            //                   you have to connect using a User Id and password

            string connectionString = @"Server=LAPTOP-O0I9A16V\SQLEXPRESS;Database=LibraryDbSwd61b2024;Trusted_Connection=True;TrustServerCertificate=True;";

            var optionsBuilder = new DbContextOptionsBuilder<LibraryContext>();
            optionsBuilder.UseSqlServer(connectionString);

            using (var context = new LibraryContext(optionsBuilder.Options))
            {
                // Ensure the database is created
                context.Database.EnsureCreated();

                // Perform operations (e.g., add a new book, query data, etc.)
            }
        }
    }
}