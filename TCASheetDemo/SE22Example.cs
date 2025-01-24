using System;
using System.Collections.Generic;

public class Canvas
{
	string name;
	List<Element> components;

	public void AddComponent(Element element)
	{
		components.Add(element);
	}
	Dimension Dimension;
}

public class Element
{
	public int X { get; set; }
	public int Y { get; set; }

	public void Draw(System.Drawing.Graphics g)
	{
		g.DrawLine(new Pen(Brushes.Black), new Point(X,Y), new Point(X,Y));
	}

}

public class Dimension
{
	public double Width { get; set; }
	public double Height { get; set; }
}

public abstract class Point
{
	public int X { get; set; }
	public int Y { get; set; }

	public abstract void Draw(System.Drawing.Graphics g);

}

public class Circle : Point
{
	public int Radius { get; set; }

	public Circle (int x, int y, int radius)
	{
		Radius = radius;
		X = x; Y = y;
	}

    public override void Draw(Graphics g)
    {
		g.DrawEllipse(new Pen(Brushes.Black), X, Y, Radius * 2, Radius * 2);
    }
}
public class Sphere: Circle
{
	public int Z { get; set; }
	public Sphere (int radius, int x, int y, int z): base(x,y,radius)
	{
		Z = z;
	}
}

public class Cylinder : Sphere
{
	public int Length { get; set; }
	public Cylinder (int radius, int x, int y, int z, int length): base(radius, x,y,z)
	{
		Length = length;
	}
}