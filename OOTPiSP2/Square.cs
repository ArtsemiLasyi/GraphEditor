﻿using System;
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
        }

        public Square(Color _SolidBrush, Color _Pen, Point _Point1, int height)
        {
            SolidBrush = _SolidBrush;
            FigurePen = _Pen;
            Points[0] = _Point1;
            Width = height;
            Height = height;
            isDynamic = false;
        }

        public Square(Color _SolidBrush, Color _Pen, Point[] _Points)
        {
            SolidBrush = _SolidBrush;
            FigurePen = _Pen;
            Points[0] = _Points[0];
            Points[1] = _Points[1];
            isDynamic = false;
        }


        public override object Clone()
        {
            return new Square(SolidBrush, FigurePen, Points);
        }

        override public void Draw(Graphics graph)
        {
            graph.DrawRectangle(new Pen(FigurePen), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Height, Height);
            graph.FillRectangle(new SolidBrush(SolidBrush), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Height, Height);
        }

        new public void Draw(Graphics graph, bool withFill)
        {
            graph.DrawRectangle(new Pen(FigurePen), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Height, Height);
            if (withFill)
            {
                graph.FillRectangle(new SolidBrush(SolidBrush), Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y), Height, Height);
            }
        }
    }
}
