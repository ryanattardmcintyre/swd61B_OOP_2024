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

    public class Sphere : Circle
    {
        //by inheritance we're going to inherit x,y,radius, print(), findarea(), findperimeter()

        public int Z { get; set; }

        public override void Print()
        {
            Console.WriteLine($"X: {X}, Y: {Y}, z: {Z}, Radius: {Radius} ");
        }

        public override double FindArea()
        {
            return Math.PI * Radius * Radius * 4;
        }

        public virtual double FindVolume()
        {
            return (4 / 3) * (Math.PI * Math.Pow(Radius, 3));
        }
    }
}
