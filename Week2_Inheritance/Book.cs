using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance
{

    //enumeration - is a predefined set of values which cannot be changed when the application is running
    public enum GenreTypes { Fiction=1, SciFi=2, Academic=3 }
    public class Book
    {
        public string Isbn { get;set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }   
        public GenreTypes Genre { get; set; } //that means that the value it will contain will have to be one of Fiction/SciFi/Academic


        //dynamic polymorphism
        //primary function: allows me to postpone any change in the implementation to a later stage
        //virtual keyword enables this
        public virtual void Print()
        {
            Console.WriteLine($"Name: {Title}, Isbn: {Isbn}");
        }

    }



}
