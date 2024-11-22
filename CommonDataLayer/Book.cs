using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Models - Book, Category, Member, Reservation
//are classes which will hold data only (data containers)
//later on we're going to use these classes to model the database
//e.g. Book -> Books

//purpose: to shape/design/plan/execute a database


namespace CommonDataLayer
{
    public class Book
    {
        //when you declare a property with the name Id, this is taken eventually 
        //automatically as the primary key

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Isbn { get; set; }
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
