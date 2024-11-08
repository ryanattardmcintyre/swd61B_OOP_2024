using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDataLayer
{
    //internal keeps the class accessible from within the same project
    //public allows the class to be accessible from external projects
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
