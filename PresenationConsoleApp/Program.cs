using BusinessLogicLayer.DataContext;
using BusinessLogicLayer.Repositories;
using CommonDataLayer;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PresenationConsoleApp.ViewModels;

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

                                    try //inside the try clause you place code that might throw an error
                                    {
                                        int isbn = Convert.ToInt32(Console.ReadLine());
                                        //format exception e.g. inputting a letter instead of numbers
                                        //outofrange exception e.g. if we input a number so big that it doesnt fit in to the range of Int32

                                        myBooksRepository.DeleteBook(isbn);
                                        //SqlException e.g. losing connection to the database
                                        //SqlException e.g. it tries to delete a book which doesnt exist
                                        
                                        Console.WriteLine("Book has been deleted");
                                    }
                                    catch(SqlException ex)
                                    {
                                        Console.WriteLine("Isbn doesn't exist or connection might have been lost. try again");
                                        Console.WriteLine(ex.Message); //even though this is not ideal; ideally we log only the errors
                                    }
                                    catch(FormatException ex)
                                    {
                                        Console.WriteLine("Do not input letters. Only integers are accepted");
                                        Console.WriteLine(ex.Message);
                                    }
                                    catch //handle the exception in the catch
                                    {
                                        Console.WriteLine("input unacceptable. Please retry by going back to the main menu");
                                    }
                                    finally //this is executed always error and no error
                                    {
                                        Console.WriteLine("Your inputs have been logged. if there was a problem we're working on it");
                                    }

                                    Console.WriteLine("Press a key to continue back to the previous menu");
                                    Console.ReadKey();
                                    break;

                            }

                            break;

                        case 2: //Reservations
                            //to do:
                            Console.Clear();
                            Console.WriteLine("1. Get No. Of Reservations For all Members, Grouped By Category, sorted by the highest one");
                            Console.WriteLine("2. Get No. Of Reservations For All members Per Month  ");
                            Console.WriteLine("3. Get Avg. No Of Reservations Per Month/ Per Year");
                            Console.WriteLine("4. Get No Of Reservations by book, displaying the most borrowed book first");
                            Console.WriteLine("5. Get Top 5 Books Borrowed the most showing No Of Reservations per book");
                            Console.WriteLine("select one of the above");
                            int case2_Choice = Convert.ToInt32(Console.ReadLine());

                            switch(case2_Choice)
                            {
                                case 1: //1.  Get No. Of Reservations For all Members, Grouped By Category, sorted by the highest one
                                    //a) get all reservations
                                    var case2_list = myReservationsRepository.GetReservations();

                                    //b) execute the following code
                                    // No. Of Reseravations | Category name
                                    var output = case2_list.GroupBy(x => new
                                    {
                                        CategoryId = x.Book.CategoryFK, //grouping by the Category
                                        CategoryTitle = x.Book.Category.Name
                                    }) 
                                             .Select(x => new //Select is used to specify what to return
                                             {
                                                 CategoryId = x.Key.CategoryId,
                                                 CategoryName = x.Key.CategoryTitle,
                                                 Total = x.Count() //no of reservations per category for the logged in user
                                             }).OrderByDescending(x => x.Total) //sorting it in descending mode by the count
                                             .ToList();

                                    //c) show the grouped by data on screen
                                    Console.WriteLine("Category Id\t\t\tCategory Title\t\t\t No. Of Reservations");
                                    Console.WriteLine();
                                    foreach (var item in output) //is of type List of Case4_CategoriesTotalViewModel
                                    {
                                        Console.WriteLine($"{item.CategoryId}\t\t\t{item.CategoryName}\t\t\t{item.Total}");
                                    }

                                    Console.WriteLine("Press a key to continue...");
                                    Console.ReadKey();
                                break;
                                case 2: //2.  Get No. Of Reservations For All members Per Month  

                                    //a) get all reservations
                                    List<Reservation> case2_reservations = myReservationsRepository.GetReservations();

                                   //b) remains the same however change the list name to refer to the one in a)
                                    var myList = case2_reservations.GroupBy(x => x.From.ToString("MMMM")).Select(x =>
                                            new //without a type i.e. an anonymous type
                                            {
                                                MonthName = x.Key, //these are properties declared on the fly
                                                Total = x.Count()
                                            }
                                    );
                                    //c) remains the same
                                    Console.WriteLine("Month\t\t\t\tTotal Reservations");
                                    foreach (var item in myList)
                                    {
                                        Console.WriteLine($"{item.MonthName}\t\t\t\t{item.Total}");
                                    }
 
                                    Console.WriteLine("Press a key to continue...");
                                    Console.ReadKey();

                            break;
                                case 3:// Get Avg. No Of Reservations Per Month/ Per Year (hint: use Average() instead of Count()
                                    //a) get all reservations
                                    var case3_list = myReservationsRepository.GetReservations();

                                    //b) group by per month & find avg based on the year
                                    var case3_output = case3_list.GroupBy(x => x.From.ToString("MMMM")).Select(x =>
                                            new //without a type i.e. an anonymous type
                                            {
                                                MonthName = x.Key, //these are properties declared on the fly
                                                Average = x.Average(y=>y.From.Year)
                                            }
                                    );

                                    //December 2023 -> 5 reservations
                                    //December 2024 -> 10 reservations
                                    //December 2022 -> 15 reservations

                                    //Month name | Avg Reservations
                                    //December   | 10 reservations


                                    //c) display the results
                                    Console.WriteLine("Month\t\t\t\t Avg Reservations");
                                    foreach (var item in case3_output)
                                    {
                                        Console.WriteLine($"{item.MonthName}\t\t\t\t{item.Average}");
                                    }

                                    Console.WriteLine("Press a key to continue...");
                                    Console.ReadKey();


                                    break;
                                case 4:
                                    break;
                                case 5:
                                    break;
                            }



                            //1.  Get No. Of Reservations For all Members, Grouped By Category, sorted by the highest one
                            //2.  Get No. Of Reservations For All members Per Month  
                            //3.  Get Avg. No Of Reservations Per Month/ Per Year (hint: use Average() instead of Count()
                            //4.  Get No Of Reservations by book, displaying the most borrowed book first
                            //5.  Get Top 5 Books Borrowed the most showing No Of Reservations per book

                            break;

                        case 3: //Members
                            Console.Clear();
                            Console.WriteLine("1. Log in");
                            Console.WriteLine("2. Register new member");
                            Console.WriteLine("3. Get Reservations For Member");
                            Console.WriteLine("4. Get No. Of Reservations For Member, Grouped By Category, sorted by the highest one");
                            Console.WriteLine("5. Get No. Of Reservations Per Month For a member");
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
                                        Console.WriteLine($"Date\t\tIsbn\tBook Name\t\tDuration");
                                        Console.WriteLine("=========================================================");
                                        Console.WriteLine();
                                        foreach (var reservation in reservations)
                                        { //26/11/2024 11:20:50:34567
                                            Console.WriteLine($"{reservation.From.ToString("dd/MM/yyyy")} " +
                                                $"\t\t{reservation.BookFK}\t{reservation.Book.Title}\t\t{reservation.Days} days");
                                        }
                                    }
                                   
                                    Console.WriteLine("Press a key to continue...");
                                    Console.ReadKey();
                                    break;

                                case 4:
                                    Console.Clear();

                                    if (username_global == "")
                                    {
                                        Console.WriteLine("Access denied");
                                    }
                                    else
                                    {
                                        //Get No. Of Reservations For Member, Grouped By Category, sorted by the highest one

                                        //1. first we get a list of reservations and filtered by username
                                        List<Reservation> reservations = myReservationsRepository.GetReservations(username_global);
                                        //output of reservations list = Id	UsernameFK	BookFK	From	Days
                                        //4   ryana   10001   2024 - 01 - 02 00:00:00.0000000 5
                                        //5   ryana   10003   2024 - 01 - 10 00:00:00.0000000 7

                                        //2. since we needed to group category to output the occurrences for each category, a
                                        //   a GroupBy has to be called.
                                        //   In the GroupBy you need to specify the columns by which 
                                        //  - to group i.e. CategoryFk
                                        //  - to show on screen i.e. CategoryTitle

                                        //e.g. of output data
                                        // Categoryid | Category Title | Reservations Count
                                        // 10 | Fiction | 3


                                        //note:
                                        //1 in order to be able to traverse the list and display all the records one by one, of something which doesn't exist yet
                                        //  e.g. a class which includes CategoryId, CategoryTitle, Total
                                        //2. these kind of classes serve only to display the data clearly on the UI (the screen)
                                        //-> we call them ViewModels

                                        var output = reservations.GroupBy(x => new
                                        {
                                            CategoryId = x.Book.CategoryFK, //grouping by the Category
                                            CategoryTitle = x.Book.Category.Name
                                        }) //Select is used to specify what to return
                                               .Select(x => new Case4_CategoriesTotalViewModel
                                               {
                                                   CategoryId = x.Key.CategoryId,
                                                   CategoryName = x.Key.CategoryTitle,
                                                   Total = x.Count() //no of reservations per category for the logged in user
                                               }).OrderByDescending(x => x.Total) //sorting it in descending mode by the count
                                               .ToList();


                                        Console.WriteLine("Category Id\t\t\tCategory Title\t\t\t No. Of Reservations");
                                        Console.WriteLine();
                                        foreach (var item in output) //is of type List of Case4_CategoriesTotalViewModel
                                        {
                                            Console.WriteLine($"{item.CategoryId}\t\t\t{item.CategoryName}\t\t\t{item.Total}");
                                        }
                                    }

                                    Console.WriteLine("Press a key to continue...");
                                    Console.ReadKey();
                                    break;
                                case 5:

                                    // Get No. Of Reservations Per Month For a member

                                    //a) get the reservations in a list for the logged in member
                                    //b) groupby by month
                                    //c) see how to display on screen

                                    if (username_global == "")
                                    {
                                        Console.WriteLine("Access denied");
                                    }
                                    else
                                    {
                                        //a)
                                        List<Reservation> reservations = myReservationsRepository.GetReservations(username_global);

                                        //b)
                                        var myList = reservations.GroupBy(x => x.From.ToString("MMMM")).Select(x =>
                                                new //without a type i.e. an anonymous type
                                                {
                                                    MonthName = x.Key, //these are properties declared on the fly
                                                    Total = x.Count()
                                                }
                                        );

                                        Console.WriteLine("Month\t\t\t\tTotal Reservations");
                                        foreach (var item in myList)
                                        {
                                            Console.WriteLine($"{item.MonthName}\t\t\t\t{item.Total}");
                                        }


                                    }
                                    Console.WriteLine("Press a key to continue...");
                                    Console.ReadKey();
                                    break;
                                
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