using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ClassRelationships.Composition
{
    public class Room
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }

    }

    public class Kitchen : Room { 
        
        public int NoOfWindows { get; set; }
        public int NoOfDoors { get; set; }

        public List<string> Appliances { get; set; }
    }

    public class Bedroom : Room
    {
        public int NoOfWindows { get; set; }
        public int NoOfDoors { get; set; }
        public bool Ensuit { get; set; }
        public int NoOfBeds { get; set; }
        public bool Tv { get; set; }

    }


}
