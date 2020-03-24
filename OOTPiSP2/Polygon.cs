﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOTPiSP2
{
    [Serializable]
    public class Polygon : Figure
    {

        public Polygon()
        {
            Points = new Point[1];
            SolidBrush = Color.White;
            FigurePen = Color.Black;
            isDynamic = true;
        }

        public Polygon(Color _SolidBrush, Color _Pen, Point[] _Points)
        {
            Points = _Points;
            SolidBrush = _SolidBrush;
            FigurePen = _Pen;
            isDynamic = true;
        }

        override public void Draw(Graphics graph)
        {
            if (Points.Length > 1)
            {
                graph.DrawPolygon(new Pen(FigurePen), Points);
                graph.FillPolygon(new SolidBrush(SolidBrush), Points);
            }
        }

        public void Draw(Graphics graph, bool withFill)
        {
            if (Points.Length > 1)
            {
                graph.DrawPolygon(new Pen(FigurePen), Points);
                if (withFill)
                {
                    graph.FillPolygon(new SolidBrush(SolidBrush), Points);
                }
            }
        }

        public override object Clone()
        {
            return new Polygon(SolidBrush, FigurePen, Points);
        }
    }
}