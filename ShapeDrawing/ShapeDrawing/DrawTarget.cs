using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

public abstract class DrawTarget
{
    public DrawTarget()
    {
    }

    public abstract void drawLines(Point[] points, Graphics canvas);

    public abstract void drawEllipse(Point location, int diameter, Graphics canvas);
}
