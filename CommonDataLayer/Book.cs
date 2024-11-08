using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDataLayer
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }   
        public string Author { get; set; }
        public int Year { get; set; }


        //a foreign key
        [ForeignKey("Category")]
        public int CategoryFK { get; set; }
        //a navigational property which is bound to the foreign key
        public virtual Category Category { get; set; }


    }
 
}
