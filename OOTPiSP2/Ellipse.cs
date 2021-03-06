﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Paint;

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

        public Ellipse(Color solidbrush, Color pen, Point point1, Point point2)
        {
            Points = new Point[2];
            SolidBrush = solidbrush;
            FigurePen = pen;
            Points[0] = point1;
            Points[1] = point2;
            isDynamic = false;
        }

        public Ellipse(Color solidbrush, Color pen, Point[] points)
        {
            Points = new Point[2];
            SolidBrush = solidbrush;
            FigurePen = pen;
            Points[0] = points[0];
            Points[1] = points[1];
            isDynamic = false;
        }

        public Ellipse(Color solidbrush, Color pen, Point point1, int width, int height)
        {
            Points = new Point[2];
            SolidBrush = solidbrush;
            FigurePen = pen;
            Points[0] = point1;
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
            graph.FillEllipse(new SolidBrush(SolidBrush), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Rad1, Rad2);
            graph.DrawEllipse(new Pen(FigurePen), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Rad1, Rad2);
        }

        public void Draw(Graphics graph, bool withFill)
        {
            if (withFill)
            {
                graph.FillEllipse(new SolidBrush(SolidBrush), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Rad1, Rad2);
            }
            graph.DrawEllipse(new Pen(FigurePen), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Rad1, Rad2);
        }
    }
}
