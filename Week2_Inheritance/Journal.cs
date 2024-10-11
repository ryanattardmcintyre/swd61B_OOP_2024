using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance
{
    //inheritance: journal is inheriting a book
    //             journal is a book with extra properties
    public class Journal: Book
    {

        public Journal() { }

        public Journal(int issueNo, int month) {
            IssueNo = issueNo; //assigning the parameter into the property
            Month = month;
        }

        public int IssueNo { get; set; }
        public int Month { get; set; }

        public string GetMonthInFull()
        {
            //Year is not visible here but it was declared in Book and 
            //since there is inheritance, we can make use of Year.

            DateTime dt = new DateTime(Year, Month, 1);
            return dt.ToString("MMMM");

        }

        public override void Print()
        {
            base.Print(); //will run the base class's Print method i.e the Book's print method
            //...concatenated with what was already printed on screen, i'm printing other details...
            Console.Write($"Author: {Author}, Issue No: {IssueNo}, Month: {GetMonthInFull()}");
        }


    }
}
