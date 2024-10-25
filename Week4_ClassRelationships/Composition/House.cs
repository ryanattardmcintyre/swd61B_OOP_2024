using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ClassRelationships.Composition
{
    public class House
    {
        public double PlotArea { get; set; }
        public string Address { get; set; }

        public List<Room> RoomList { get; set; }

        //When the constructor (the only constructor we have) requires a parameter of Class B e.g. Room
        //means that the House instance cannot be created unless we give it a Room instance
        public House(Room room)
        {
            RoomList = new List<Room>();
            RoomList.Add(room);
        }
 

    }
}
