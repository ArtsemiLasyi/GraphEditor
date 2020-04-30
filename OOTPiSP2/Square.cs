using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOTPiSP2
{
    [Serializable]
    public class Square : Rectangle
    {
        new private int Width {set; get;}

        public Square()
        {
            SolidBrush = Color.White;
            FigurePen = Color.Black;
            Points[0] = new Point(0, 0);
            Width = 0;
            Height = 0;
            isDynamic = false;
        }

        public Square(Color solidbrush, Color pen, Point point1, int height)
        {
            SolidBrush = solidbrush;
            FigurePen = pen;
            Points[0] = point1;
            Width = height;
            Height = height;
            isDynamic = false;
        }

        public Square(Color solidbrush, Color pen, Point[] points)
        {
            SolidBrush = solidbrush;
            FigurePen = pen;
            Points[0] = points[0];
            Points[1] = points[1];
            isDynamic = false;
        }


        public override object Clone()
        {
            return new Square(SolidBrush, FigurePen, Points);
        }

        override public void Draw(Graphics graph)
        {
            graph.FillRectangle(new SolidBrush(SolidBrush), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Height, Height);
            graph.DrawRectangle(new Pen(FigurePen), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Height, Height);
        }

        new public void Draw(Graphics graph, bool withFill)
        {
            if (withFill)
            {
                graph.FillRectangle(new SolidBrush(SolidBrush), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Height, Height);
            }
            graph.DrawRectangle(new Pen(FigurePen), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Height, Height);
        }
    }
}
