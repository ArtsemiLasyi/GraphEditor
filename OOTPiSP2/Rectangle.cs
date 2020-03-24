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

        public Rectangle(Color _SolidBrush, Color _Pen, Point _Point1, Point _Point2)
        {
            Points = new Point[2];
            SolidBrush = _SolidBrush;
            FigurePen = _Pen;
            Points[0] = _Point1;
            Points[1] = _Point2;
        }

        public Rectangle(Color _SolidBrush, Color _Pen, Point[] _Points)
        {
            Points = new Point[2];
            SolidBrush = _SolidBrush;
            FigurePen = _Pen;
            Points[0] = _Points[0];
            Points[1] = _Points[1];
            isDynamic = false;
        }

        public Rectangle(Color _SolidBrush, Color _Pen, Point Point1, int width, int height)
        {
            Points = new Point[2];
            SolidBrush = _SolidBrush;
            FigurePen = _Pen;
            Points[0] = Point1;
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
            graph.DrawRectangle(new Pen(FigurePen), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Width, Height);
            graph.FillRectangle(new SolidBrush(SolidBrush), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Width, Height);
        }

        public void Draw(Graphics graph, bool withFill)
        {
            graph.DrawRectangle(new Pen(FigurePen), Math.Min(Points[0].X,Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Width, Height);
            if (withFill)
            {
                graph.FillRectangle(new SolidBrush(SolidBrush), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Width, Height);
            }
        }
    }
}
