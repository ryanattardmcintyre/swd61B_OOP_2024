using BusinessLogicLayer.DataContext;
using BusinessLogicLayer.Repositories;
using CommonDataLayer;
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
                BooksRepository myBooksRepository = new BooksRepository(context);

                int choice = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Books");
                    Console.WriteLine("2. Reservations");
                    Console.WriteLine("3. Members");
                    Console.WriteLine("4. Quit");
                    Console.WriteLine("Input choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: //of the main menu
                            int menu1_choice = 0;
                            Console.Clear();
                            Console.WriteLine("1. Add");
                            Console.WriteLine("2. Search By Name");
                            Console.WriteLine("3. Search By Category");
                            Console.WriteLine("4. Search By Year");
                            Console.WriteLine("5. Update");
                            Console.WriteLine("6. Delete");
                            Console.WriteLine("Input choice: ");
                            menu1_choice = Convert.ToInt32(Console.ReadLine());

                            switch (menu1_choice)
                            {
                                case 1: //Adding of a new book
                                    Console.Clear();
                                    Book b = new Book();
                                    Console.WriteLine("Input isbn");
                                    b.Isbn = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Input title");
                                    b.Title = (Console.ReadLine());

                                    Console.WriteLine("Input author");
                                    b.Author = (Console.ReadLine());

                                    Console.WriteLine("Input year it was published");
                                    b.Year = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Input Category (1. Fiction / 2. Science)");
                                    b.CategoryFK = Convert.ToInt32(Console.ReadLine());

                                    //adding the book to the database
                                    myBooksRepository.AddBook(b);
                                    Console.WriteLine("Book has been added");
                                    Console.WriteLine("Press a key to continue back to the previous menu");

                                    break;

                                case 2: //Search by name
                                    Console.Clear();
                                    Console.WriteLine("Input name for the book:");
                                    string keyword = Console.ReadLine();

                                    var result = myBooksRepository.GetBooks(keyword);

                                    if (result.Count() > 0)
                                    {
                                        foreach (var book in result)
                                        {
                                            Console.WriteLine($"Isbn: {book.Isbn}, Name: {book.Title}, Year: {book.Year}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("No Books found");
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine("Press a key to continue back to the previous menu");
                                    Console.ReadKey();
                                    break;

                                case 3: //search by category
                                    Console.Clear();
                                    Console.WriteLine("Input category for the book: (1. Fiction/ 2. Science)");
                                    int categoryId =Convert.ToInt32( Console.ReadLine());

                                    var resultForSearchByCategory = myBooksRepository.GetBooks(categoryId);

                                    if (resultForSearchByCategory.Count() > 0)
                                    {
                                        foreach (var book in resultForSearchByCategory)
                                        {
                                            Console.WriteLine($"Isbn: {book.Isbn}, Name: {book.Title}, Year: {book.Year}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("No Books found");
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine("Press a key to continue back to the previous menu");
                                    Console.ReadKey();
                                    break;

                                case 4: //search by year

                                    Console.Clear();
                                    Console.WriteLine("Input year from");
                                    int yearFrom = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Input year to");
                                    int yearTo = Convert.ToInt32(Console.ReadLine());

                                    var resultForSearchByYear = myBooksRepository.GetBooks(yearFrom, yearTo);

                                    if (resultForSearchByYear.Count() > 0)
                                    {
                                        foreach (var book in resultForSearchByYear)
                                        {
                                            Console.WriteLine($"Isbn: {book.Isbn}, Name: {book.Title}, Year: {book.Year}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("No Books found");
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine("Press a key to continue back to the previous menu");
                                    Console.ReadKey();

                                    break;


                                case 5: //Update

                                    Console.Clear();
                                    Book bookToUpdate = new Book();
                                    Console.WriteLine("Input isbn");
                                    bookToUpdate.Isbn = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Input title");
                                    bookToUpdate.Title = (Console.ReadLine());

                                    Console.WriteLine("Input author");
                                    bookToUpdate.Author = (Console.ReadLine());

                                    Console.WriteLine("Input year it was published");
                                    bookToUpdate.Year = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Input Category (1. Fiction / 2. Science)");
                                    bookToUpdate.CategoryFK = Convert.ToInt32(Console.ReadLine());

                                    //adding the book to the database
                                    myBooksRepository.UpdateBook(bookToUpdate);
                                    Console.WriteLine("Book has been updated");
                                    Console.WriteLine("Press a key to continue back to the previous menu");
                                    Console.ReadKey();
                                    break;

                                case 6: //Delete

                                    Console.WriteLine("Input book isbn to delete");
                                    int isbn = Convert.ToInt32(Console.ReadLine());

                                    myBooksRepository.DeleteBook(isbn);

                                    Console.WriteLine("Book has been deleted");

                                    Console.WriteLine("Press a key to continue back to the previous menu");
                                    Console.ReadKey();
                                    break;

                            }

                            break;

                        case 2:
                            break;

                        case 3:
                            break;
                    }
                
                } while (choice != 4);
               

            }
        }
    }
}