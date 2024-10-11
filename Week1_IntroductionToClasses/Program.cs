using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_IntroductionToClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //a class - a definition of some entity e.g Person, Item, Student, Transaction, Account, etc
            //an object/instance - object is needed to be able to personalize the classes above, i.e to be able to 
            //                     store the data in memory we need an object

            //intellisense
            Person p = new Person(); //this how an object is created
            Person p1 = new Person();


            Console.WriteLine("Input a name:"); //it shows text on screen
            p.Name = Console.ReadLine(); //it receives data from the screen

            Console.WriteLine("Input a surname:"); //it shows text on screen
            p.Surname = Console.ReadLine(); //it receives data from the screen

            Console.WriteLine("Input a mobile:"); //it shows text on screen
            p.Mobile = Console.ReadLine(); //it receives data from the screen

            Console.WriteLine("Input year you were born:"); //it shows text on screen
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input month you were born:"); //it shows text on screen
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input day you were born:"); //it shows text on screen
            int day = Convert.ToInt32(Console.ReadLine());

            p.DateOfBirth= new DateTime(year, month, day);



            Console.WriteLine($"Name: {p.Name}, Surname: {p.Surname}, Dob: {p.DateOfBirth.ToLongDateString()}" +
                $", Mobile: {p.Mobile}, Age: {p.FindAge()}");
            //Console.WriteLine("Name: "+p.Name + ", Surname: "+ p.Surname);

            Console.ReadKey();



        }
    }
}
