using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Polymorphism
{
    /*
   * Create these class with the following requirements:
   * 
   * Class Name 1: Point, Properties: x,y; Methods: Print()
   * Class Name 2: Circle, Properties: x,y; radius; Methods: Print(), double FindArea(), double FindPerimeter()
   * Class Name 3: Sphere, Properties: x,y,z, radius; Methods: Print(), FindArea(), FindPerimeter(), FindVolume()
   * Class Name 4: Cylinder, Properties: x,y,z, radius, height; Methods: Print(), FindArea(), FindPerimeter(), FindVolume()
   * 
   * 
   * Code these classes, while evaluating where there is the need to apply inheritance and polymorphism
   */

    public class Circle: Point
    {
        public double Radius { get; set; }

        public override void Print()
        {
            base.Print(); //Point.Print() ....X = 10, Y = 10
            Console.WriteLine($"Radius: {Radius} ");
        }

        public virtual double FindArea()
        {
            return Math.PI * Radius * Radius;
        }
        public virtual double FindPerimeter() //virtual doesn't force you to override
        {
            return Math.PI * 2 * Radius;
        }

    }
}
