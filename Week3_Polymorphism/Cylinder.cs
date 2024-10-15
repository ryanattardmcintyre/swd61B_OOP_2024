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
    public class Cylinder: Sphere
    {
        public double Height { get; set; }

        public override void Print()
        {
            base.Print(); Console.Write($"Height: {Height}"); //difference between Write and WriteLine...
                                                                //WriteLine will start a new line
                                                                //Write continues writing in the console on the same line
        }

        public override double FindArea()
        {
            return (Math.PI * Radius * Radius) + (2 * Math.PI * Radius * Height);
        }

        public override double FindPerimeter()
        {
            //4r + 2h
            return (4 * Radius) + (2 * Height);
        }

        public override double FindVolume()
        {
            return (Math.PI * Radius * Radius) * Height;
        }
    }
}
