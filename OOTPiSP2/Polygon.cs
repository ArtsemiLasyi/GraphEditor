using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Paint;

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

        public Polygon(Color solidbrush, Color pen, Point[] points)
        {
            Points = points;
            SolidBrush = solidbrush;
            FigurePen = pen;
            isDynamic = true;
        }

        override public void Draw(Graphics graph)
        {
            if (Points.Length > 1)
            {
                graph.FillPolygon(new SolidBrush(SolidBrush), Points);
                graph.DrawPolygon(new Pen(FigurePen), Points);
            }
        }

        public void Draw(Graphics graph, bool withFill)
        {
            if (Points.Length > 1)
            {
                if (withFill)
                {
                    graph.FillPolygon(new SolidBrush(SolidBrush), Points);
                }
                graph.DrawPolygon(new Pen(FigurePen), Points);
            }
        }

        public override object Clone()
        {
            return new Polygon(SolidBrush, FigurePen, Points);
        }
    }
}
