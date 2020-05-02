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
    public class Triangle : Polygon
    {

        public Triangle()
        {
            Points = new Point[3];
            SolidBrush = Color.White;
            FigurePen = Color.Black;
            isDynamic = false;
        }

        public Triangle(Color solidbrush, Color pen, Point point1, Point point2, Point point3)
        {
            Points = new Point[3] { point1, point2, point3};
            SolidBrush = solidbrush;
            FigurePen = pen;
            isDynamic = false;
        }

        public override object Clone()
        {
            return new Triangle(SolidBrush, FigurePen, Points[0], Points[1], Points[2]);
        }

        override public void Draw(Graphics graph)
        {
            if (!haveEmptyPoints())
            {
                graph.FillPolygon(new SolidBrush(SolidBrush), Points);
                graph.DrawPolygon(new Pen(FigurePen), Points);
            }
        }

        new public void Draw(Graphics graph, bool withFill)
        {
            if (!haveEmptyPoints())
            {
                if (withFill)
                {
                    graph.FillPolygon(new SolidBrush(SolidBrush), Points);
                }
                graph.DrawPolygon(new Pen(FigurePen), Points);
            }
        }

        private bool haveEmptyPoints()
        {
            for(int i = 0; i < Points.Length; i++)
            {
                if (Points[i].IsEmpty)
                    return true;
            }
            return false;
        }


    }

}
