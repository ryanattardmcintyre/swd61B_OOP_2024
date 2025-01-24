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
		g.Draw(new )

	}

}

public class Dimension
{
	public double Width { get; set; }
	public double Height { get; set; }
}
