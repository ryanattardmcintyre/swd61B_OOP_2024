
using Week2_Inheritance;

Book myBook;
int choice = 1;

do
{
    Console.Clear(); //clear the screeen
    Console.WriteLine("Choose among 1.Book / 2.Journal / 3.Scientific Journal");
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            myBook = new Book();
            break;

        case 2:
            Console.WriteLine("Write issue no for journal: ");
            int issueNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write the month which was issued in");
            int month = Convert.ToInt32(Console.ReadLine());


            myBook = new Journal(issueNo, month); //this is ok because Journal is a Book
            break;

        case 3:

            Console.WriteLine("Write issue no for journal: ");
            int issueNo2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write the month which was issued in");
            int month2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Write the field of study for the scientific journal: ");
            string fieldOfStudy =Console.ReadLine();


            //it is important when you have methods/constructors with parameters
            //that parameter values are passed in the right order
            myBook = new ScientificJournal(issueNo2, month2, fieldOfStudy);
            break;

        default:
            myBook = new Book();

            Console.WriteLine("Input is out of range. Choose between 1 and 3");
            Console.WriteLine("Hit any key to continue....");
            Console.ReadKey(); //purpose: to wait for the user to read the message
            break;
    }
} while (choice < 1 && choice > 3);


Console.WriteLine("Name of book: ");
myBook.Title = Console.ReadLine();

Console.WriteLine("Isbn of book: ");
myBook.Isbn = Console.ReadLine();

Console.WriteLine("Published in: ");
myBook.Year = Convert.ToInt32(Console.ReadLine());




Console.WriteLine("----------------------------------------------");
Console.WriteLine($"You have input:\n");
myBook.Print(); //this method will work on all types of Books


Console.WriteLine("Hit any key to terminate....");
Console.ReadKey(); //purpose: to wait for the user to read the message
