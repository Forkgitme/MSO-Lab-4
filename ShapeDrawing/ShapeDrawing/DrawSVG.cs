using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

class DrawSVG : DrawTarget
{
    public string useShape;

    public override void drawLines(Point[] points, Graphics canvas)
    {
        string stringPoints = "";
        for (int i = 0; i < points.Length; i++)
        {
            stringPoints += points[i].X + "," + points[i].Y + " ";
        }

        stringPoints += points[0].X + "," + points[0].Y;

        useShape = @"<polyline points=""" + stringPoints + @""" style=""fill:none;stroke:black;stroke-width:1"" />";
    }

    public override void drawEllipse(Point location, int diameter, Graphics canvas)
    {
        useShape = @"<circle cx+""" + location.X + @""" cy=""" + location.Y + @""" r=""" + diameter/2 + @""" stroke-width=""1"" fill=""none"" stroke=""black"" />";
    }
}
