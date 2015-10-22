using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

public class DrawCSharp : DrawTarget
{
    public DrawCSharp()
    {
    }

    public override void drawLines(Point[] points, Graphics canvas)
    {
        Pen pen = new Pen(Color.Black);
        for (int i = 0; i < points.Length; i++)
        {
            canvas.DrawLine(pen, points[i].X,
                                points[i].Y,
                                points[(i + 1) % points.Length].X,
                                points[(i + 1) % points.Length].Y);
        }
    }

    public override void drawEllipse(Point location, int diameter, Graphics canvas)
    {
        Pen pen = new Pen(Color.Black);
        canvas.DrawEllipse(pen, location.X, location.Y, diameter, diameter);
    }

}