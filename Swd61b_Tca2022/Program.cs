namespace Swd61b_Tca2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department d = new Department();

        }
    }


    class Department
    {
        public Person Dean { get; set; }
        List<Person> persons;

        public void AddToDepartment(Person p)
        { persons.Add(p); }

        
    }

    class Person
    {

    }


    /*
     * •	A class Canvas 
o	has two fields [1]
	components which is a list of type Element
	name  of type string
o	A behaviour in the same class called AddComponent should allow the addition of new elements to the list above; [1]
o	An object of type Canvas must have width and height set via an object of type Dimension and a given name; [1]

•	 A class Element has two properties [1]
o	X of type int
o	Y of type int
and a behaviour called Draw(System.Drawing.Graphics g) which should draw a pixel on screen using the g parameter; [2]

•	A class Dimension has two properties [1]
o	Width of type double
o	Height of type double

     */
    class Canvas
    {
        List<Element> components;
        Dimension dimension;
        public void AddComponent(Element e)
        { components.Add(e); }
        public Canvas(Dimension d)
        { dimension = d; }
    }
    class Element
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void Draw(System.Drawing.Graphics g) {
            //g.DrawLine(new Pen(Brushes.Black), new Point(X,Y), new Point(X,Y));
        }
    }
    class Dimension
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }




}