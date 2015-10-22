using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ShapeDrawing
{
    public abstract class DrawTarget
    {
        public abstract void draw();
    }

    public class DrawCSharp
    {
        public void draw(Graphics canvas)
        {

        }
    }

    public class DrawSVG
    {
        public void draw()
        {

        }
    }
}
