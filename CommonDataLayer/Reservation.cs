using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDataLayer
{
    public class Reservation
    {
        public int Id { get; set; }


        [ForeignKey("Member")]
        public string UsernameFK { get; set; }
        public Member Member { get; set; }

        [ForeignKey("Book")]
        public int BookFK { get; set; }
        public virtual Book Book { get; set; }
        public DateTime From { get; set; }
        public int Days { get; set; }

    }
}
