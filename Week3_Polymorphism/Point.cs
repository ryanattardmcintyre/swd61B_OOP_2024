using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Polymorphism
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"X: {X}, Y: {Y} ");
        }
    }
}
