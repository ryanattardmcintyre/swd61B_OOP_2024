using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//a namespace is a logical grouping which groups classes, enumerations, constants, etc.
namespace Week1_IntroductionToClasses
{
    //a class is a blueprint/template which describes a real-world entity/thing/object
    public class Person
    {

        //properties: are components which define or best describe what is a Person
        //            are also data containers that can be accessed to write and read the data
        //            they use get >> to read the data and set >> to write/assign the data
        //            data in a property is temporarily stored in memory

        //naming convention: all properties they should start with a capital letter (Pascal casing)
        //                   no symbols, numbers are to be used in the names
        //compiler ruler: names should not contain numbers in beginning, symbols in the beginning, spaces.
        //syntax: <access modifier><data type><name><get;set;>

        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        
        public DateTime DateOfBirth { get; set; }

        public string Mobile { get; set; }

        //methods: are the behaviours of the entity/class in question
        public int FindAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }


    }
}
