using BusinessLogicLayer.DataContext;
using Microsoft.EntityFrameworkCore;

namespace PresentationDesktopApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string connectionString = @"Server=LAPTOP-O0I9A16V\SQLEXPRESS;Database=LibraryDbSwd61b2024;Trusted_Connection=True;TrustServerCertificate=True;";


            var optionsBuilder = new DbContextOptionsBuilder<LibraryContext>();
            optionsBuilder.UseSqlServer(connectionString);

            using var context = new LibraryContext(optionsBuilder.Options);
            

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin(context));
        }
    }
}