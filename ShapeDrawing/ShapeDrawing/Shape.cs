using System;
using System.Drawing;

public abstract class Shape
{
    public DrawTarget drawTarget = new DrawCSharp();

	public Shape()
	{
	}

    public abstract void Draw(Graphics Canvas);
	
}