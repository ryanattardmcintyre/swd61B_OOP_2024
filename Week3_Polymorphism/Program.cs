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
     * Class Name 2: Circle, Properties: x,y; radius; Methods: Print(), FindArea(), FindPerimeter()
     * Class Name 3: Sphere, Properties: x,y,z, radius; Methods: Print(), FindArea(), FindPerimeter(), FindVolume()
     * Class Name 4: Cylinder, Properties: x,y,z, radius, height; Methods: Print(), FindArea(), FindPerimeter(), FindVolume()
     * 
     * 
     * Code these classes, while evaluating where there is the need to apply inheritance and polymorphism
     */




    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to select a shape/FindArea/FindPermieter/FindVolume
            //input the properties related to the selected shape
            //add the shape into a list
            //the user can choose to compute the area/perimeter/volume


            List<Circle> shapes = new List<Circle>();

            int choice = 0;
            while (choice != 6)
            {
                Console.Clear();
                Console.WriteLine("1. Select a shape");
                Console.WriteLine("2. Find the area of all shapes input");
                Console.WriteLine("3. Find the perimeter of all shapes input");
                Console.WriteLine("4. Find the volume of all shapes input");
                Console.WriteLine("5. Print all shapes input");
                Console.WriteLine("6. Quit");
                choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Select a shape to input");
                        Console.WriteLine("1. Circle");
                        Console.WriteLine("2. Sphere");
                        Console.WriteLine("3. Cylinder");
                        int choice2 = Convert.ToInt32(Console.ReadLine());

                        switch(choice2)
                        {
                            case 1:
                                Circle myCircle = new Circle();
                                Console.WriteLine("Input x: ");
                                myCircle.X = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Input y: ");
                                myCircle.Y = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Input radius: ");
                                myCircle.Radius = Convert.ToDouble(Console.ReadLine());

                                shapes.Add(myCircle);

                                break; //end of case 1 of the switch for the sub menu

                            case 2:
                                //ask the user to input the details for a sphere...
                                break;

                            case 3:
                                
                                Cylinder myCylinder = new Cylinder();
                                //ask the user to input the details for a cylinder...
                                shapes.Add(myCylinder); //to the list of Circles i can add a Cylinder because a Cylinder is a circle

                                break;
                        }

                        break; //end of case 1 of the switch catering for the main menu

                    case 2:

                        //shapes: C1, C2, S1, Cy1, S2 .....

                        foreach(var s in shapes)
                        {
                            Console.WriteLine($"Area of {s.GetType().Name} with radius {s.Radius}: {s.FindArea()}");
                            Console.WriteLine();
                        }

                        Console.WriteLine();
                        Console.WriteLine("Hit any key to continue back to the main menu");
                        Console.ReadKey();

                        break; //end of case 2 of the switch catering for the main menu


                        case 3:
                        break;

                        case 4:
                        //calculate the volume for all the shapes

                        //Circle has no FindVolume()
                        //Sphere & cylinder they both have FindVolume()


                        //List >>>> c1, c2, s1, s2, cy1
                        foreach (var s in shapes)
                        {
                            if (s.GetType() == typeof(Circle))
                            {
                                Console.WriteLine($"{s.GetType().Name} doesn't have a Volume");
                            }
                            else
                            {
                                if (s.GetType() == typeof(Sphere))
                                {
                                    Sphere sp = (Sphere)s;
                                    Console.WriteLine($"Volume of {sp.GetType().Name} with radius {sp.Radius}: {sp.FindVolume()}");
                                }
                                else
                                {
                                    Cylinder cy = (Cylinder)s; 
                                    Console.WriteLine($"Volume of {cy.GetType().Name} with radius {cy.Radius} and height {cy.Height}: {cy.FindVolume()}");
                                }
                                 //typecasting //a different type of conversion 
                                                        //We cannot apply Convert.ToSphere because it does not exist
                            }

                           
                            Console.WriteLine();
                        }

                        Console.WriteLine();
                        Console.WriteLine("Hit any key to continue back to the main menu");
                        Console.ReadKey();




                        break;

                         case 5:
                        break;

                }




            }

            Console.WriteLine("Hit any key to terminate the application");
            Console.ReadKey();






        }
    }
}
