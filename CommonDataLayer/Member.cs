using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDataLayer
{
    public class Member
    {
        public string Name { get; set; }    
        public string Surname { get; set; }

        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
