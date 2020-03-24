using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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

        public Triangle(Color _SolidBrush, Color _Pen, Point Point1, Point Point2, Point Point3)
        {
            Points = new Point[3] { Point1, Point2, Point3};
            SolidBrush = _SolidBrush;
            FigurePen = _Pen;
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
                graph.DrawPolygon(new Pen(FigurePen), Points);
                graph.FillPolygon(new SolidBrush(SolidBrush), Points);
            }
        }

        new public void Draw(Graphics graph, bool withFill)
        {
            if (!haveEmptyPoints())
            {
                graph.DrawPolygon(new Pen(FigurePen), Points);
                if (withFill)
                {
                    graph.FillPolygon(new SolidBrush(SolidBrush), Points);
                }
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
