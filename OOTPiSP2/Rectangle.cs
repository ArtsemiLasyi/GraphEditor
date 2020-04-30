using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOTPiSP2
{
    [Serializable]
    public class Rectangle : Figure
    {
        public int Width
        {
            get
            {
                return Math.Abs(Points[1].X - Points[0].X);
            }

            set
            {
                Points[1].X = Math.Abs(value + Points[0].X);
            }
        }
        public int Height
        {
            get
            {
                return Math.Abs(Points[1].Y - Points[0].Y);
            }

            set
            {
                Points[1].Y = Math.Abs(value + Points[0].Y);
            }
        }

        public Rectangle(Color solidbrush, Color pen, Point point1, Point point2)
        {
            Points = new Point[2];
            SolidBrush = solidbrush;
            FigurePen = pen;
            Points[0] = point1;
            Points[1] = point2;
        }

        public Rectangle(Color solidbrush, Color pen, Point[] points)
        {
            Points = new Point[2];
            SolidBrush = solidbrush;
            FigurePen = pen;
            Points[0] = points[0];
            Points[1] = points[1];
            isDynamic = false;
        }

        public Rectangle(Color solidbrush, Color pen, Point point1, int width, int height)
        {
            Points = new Point[2];
            SolidBrush = solidbrush;
            FigurePen = pen;
            Points[0] = point1;
            Width = width;
            Height = height;
            isDynamic = false;
        }

        public Rectangle()
        {
            Points = new Point[2];
            SolidBrush = Color.White;
            FigurePen = Color.Black;
            Points[0] = new Point(0, 0);
            Points[1] = new Point(0, 0);
            Width = 0;
            Height = 0;
            isDynamic = false;
        }

        public override object Clone()
        {
            return new Rectangle(SolidBrush, FigurePen, Points);
        }

        override public void Draw(Graphics graph)
        {
            graph.FillRectangle(new SolidBrush(SolidBrush), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Width, Height);
            graph.DrawRectangle(new Pen(FigurePen), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Width, Height);
        }

        public void Draw(Graphics graph, bool withFill)
        {
            if (withFill)
            {
                graph.FillRectangle(new SolidBrush(SolidBrush), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Width, Height);
            }
            graph.DrawRectangle(new Pen(FigurePen), Math.Min(Points[0].X,Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Width, Height);
        }
    }
}
