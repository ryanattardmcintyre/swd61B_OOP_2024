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
                //in every respository instance im always passing same database instance
                //...this will promote consistency with the data throughout these service classes
                //...e.g there is no risk in adding a book via the BooksRepository and its not visible in the ReservationsRepository

                BooksRepository myBooksRepository = new BooksRepository(context);
                MembersRepository myMembersRepository = new MembersRepository(context);
                ReservationsRepository myReservationsRepository = new ReservationsRepository(context);

                //store a global variable showing who is logged in
                string username_global = ""; //empty string means that no one is logged in


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

                        case 2: //Reservations
                            break;

                        case 3: //Members
                            Console.Clear();
                            Console.WriteLine("1. Log in");
                            Console.WriteLine("2. Register new member");
                            Console.WriteLine("3. Get Reservations For Member");
                            Console.WriteLine("4. Get No. Of Reservations For Member, Grouped By Category, sorted by the highest one");
                            Console.WriteLine("5. Get Reservations Per Month For a member");
                            Console.WriteLine("6. Borrow a book");
                            
                            int case3MenuChoice = Convert.ToInt32(Console.ReadLine());
                            switch (case3MenuChoice)
                            {
                                case 1: //Login 
                                    Console.Clear();
                                    Console.WriteLine("Input username: ");
                                    string username_local = Console.ReadLine();

                                    Console.WriteLine("Input password: ");
                                    string password = ReadPassword();

                                    bool check = myMembersRepository.Login(username_local, password);
                                    if (check)
                                    {
                                        //user has been validated
                                        Console.WriteLine("Login successful");
                                        //after logging successfully, we will store in a global variable/field the username who successfully
                                        //logged in
                                        //consequently in the other cases where authentication is required, we first check this global variable
                                        username_global = username_local;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Login unsuccessful");
                                    }
                                    Console.WriteLine("Press a key to continue...");
                                    Console.ReadKey();
                                    break;
                                case 2: //Register new user
                                    
                                    Console.Clear();
                                    Member myNewMember = new Member();

                                    Console.WriteLine("Input first name:");
                                    myNewMember.Name = Console.ReadLine();
                                    Console.WriteLine("Input last name:");
                                    myNewMember.Surname = Console.ReadLine();
                                    Console.WriteLine("Input username:");
                                    myNewMember.Username = Console.ReadLine();
                                    Console.WriteLine("Input password:");
                                    myNewMember.Password = ReadPassword();

                                    bool success= myMembersRepository.Register(myNewMember);
                                    if (success)
                                        Console.WriteLine("You were registered successfully. Proceed to login");
                                    else
                                        Console.WriteLine("Username is taken. Re register by using another username");
                                   
                                    Console.WriteLine("Press a key to continue...");
                                    Console.ReadKey();

                                    break;
                                case 3:  
                                    Console.Clear();
                                    if (username_global == "") //means that the user hasn't logged in yet
                                    {
                                        Console.WriteLine("Access denied");
                                    }
                                    else
                                    {
                                        var reservations = myReservationsRepository.GetReservations(username_global);

                                        //Timestamp | Book Isbn | Book Name | Duration
                                        foreach (var reservation in reservations)
                                        { //26/11/2024 11:20:50:34567
                                            Console.WriteLine($"{reservation.From.ToString("dd/MM/yyyy")} " +
                                                $"\t{reservation.BookFK}\t{reservation.Book.Title}\t{reservation.Days} days");
                                        }
                                    }
                                   
                                    Console.WriteLine("Press a key to continue...");
                                    Console.ReadKey();
                                    break;

                                case 4: break;
                                case 5: break;
                                case 6: //borrowing a book
                                    Console.Clear();

                                    if (username_global == "") //means that the user hasn't logged in yet
                                    {
                                        Console.WriteLine("Access denied");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Input isbn of Book to reserve");
                                        int isbnToBorrow = Convert.ToInt32(Console.ReadLine());

                                        //check whether that current book is actually at the moment reserved already
                                        var currentActiveReservations = myReservationsRepository.GetActiveReservations();
                                        bool isReserved = (currentActiveReservations.Count(x => x.BookFK == isbnToBorrow) > 0);

                                        //if check returns false we can reserve the book
                                        if (isReserved)
                                        {
                                            Console.WriteLine("Unfortunately book is reserved at the moment");
                                        }
                                        else
                                        {
                                            Reservation myReservation = new Reservation();
                                            myReservation.BookFK = isbnToBorrow;
                                            myReservation.UsernameFK = username_global;
                                            myReservation.Days = 7;
                                            myReservation.From = DateTime.Now;

                                            myReservationsRepository.AddReservation(myReservation);

                                            Console.WriteLine("Book reserved. you may collect the book");
                                        }

                                    }
                                   
                                    Console.WriteLine("Press a key to continue...");
                                    Console.ReadKey();

                                    break;
                            }

                            break;
                    }
                
                } while (choice != 4);
               

            }
        }

        static string ReadPassword()
        {
            string password = string.Empty;
            ConsoleKey key;

            do
            {
                var keyInfo = Console.ReadKey(intercept: true); // Do not display the key
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && password.Length > 0)
                {
                    // Remove the last character from password and from console
                    password = password[0..^1];
                    Console.Write("\b \b");
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    // Add the character to the password and display a masking character
                    password += keyInfo.KeyChar;
                    Console.Write("*");
                }
            }
            while (key != ConsoleKey.Enter); // End when Enter is pressed

            return password;
        }
    }
}