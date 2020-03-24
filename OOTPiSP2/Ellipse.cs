using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOTPiSP2
{
    [Serializable]
    public class Ellipse : Figure
    {
        public int Rad1
        {
            get
            {
                return Math.Abs(Points[1].X - Points[0].X);
            }

            set
            {
                Points[1].X = Math.Abs(value*2 + Points[0].X);
            }
        }
        public int Rad2
        {
            get
            {
                return Math.Abs(Points[1].Y - Points[0].Y);
            }

            set
            {
                Points[1].Y = Math.Abs(value*2 + Points[0].Y);
            }
        }

        public Ellipse(Color _SolidBrush, Color _Pen, Point _Point1, Point _Point2)
        {
            Points = new Point[2];
            SolidBrush = _SolidBrush;
            FigurePen = _Pen;
            Points[0] = _Point1;
            Points[1] = _Point2;
        }

        public Ellipse(Color _SolidBrush, Color _Pen, Point[] _Points)
        {
            Points = new Point[2];
            SolidBrush = _SolidBrush;
            FigurePen = _Pen;
            Points[0] = _Points[0];
            Points[1] = _Points[1];
            isDynamic = false;
        }

        public Ellipse(Color _SolidBrush, Color _Pen, Point Point1, int width, int height)
        {
            Points = new Point[2];
            SolidBrush = _SolidBrush;
            FigurePen = _Pen;
            Points[0] = Point1;
            Rad1 = width;
            Rad2 = height;
            isDynamic = false;
        }

        public Ellipse()
        {
            Points = new Point[2];
            SolidBrush = Color.White;
            FigurePen = Color.Black;
            Points[0] = new Point(0, 0);
            Points[1] = new Point(0, 0);
            Rad1 = 0;
            Rad2 = 0;
            isDynamic = false;
        }

        public override object Clone()
        {
            return new Ellipse(SolidBrush, FigurePen, Points[0], Points[1]);
        }

        override public void Draw(Graphics graph)
        {
            graph.DrawEllipse(new Pen(FigurePen), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Rad1, Rad2);
            graph.FillEllipse(new SolidBrush(SolidBrush), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Rad1, Rad2);
        }

        public void Draw(Graphics graph, bool withFill)
        {
            graph.DrawEllipse(new Pen(FigurePen), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Rad1, Rad2);
            if (withFill)
            {
                graph.FillEllipse(new SolidBrush(SolidBrush), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Rad1, Rad2);
            }
        }
    }
}
