using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paint;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace OOTPiSP2
{
    [Serializable]
    public class Trapezium : Figure
    {

        public Trapezium()
        {
            Points = new Point[2];
            SolidBrush = Color.White;
            FigurePen = Color.Black;
            isDynamic = false;
        }

        public Trapezium(Color solidbrush, Color pen, Point point1, Point point2)
        {
            Points = new Point[2] { point1, point2 };
            SolidBrush = solidbrush;
            FigurePen = pen;
            isDynamic = false;
        }

        public Trapezium(Color solidbrush, Color pen, Point[] points)
        {
            Points = new Point[2] { points[0], points[1] };
            SolidBrush = solidbrush;
            FigurePen = pen;
            isDynamic = false;
        }

        override public object Clone()
        {
            return new Trapezium(SolidBrush, FigurePen, Points);
        }

        override public void Draw(Graphics graph)
        {
            if (!haveEmptyPoints())
            {
                Point[] drawPoints = new Point[4];
                drawPoints = getDrawPoints(Points);

                graph.FillPolygon(new SolidBrush(SolidBrush), drawPoints);
                graph.DrawPolygon(new Pen(FigurePen), drawPoints);
            }
        }

        public void Draw(Graphics graph, bool withFill)
        {
            if (!haveEmptyPoints())
            {
                Point[] drawPoints = new Point[4];
                drawPoints = getDrawPoints(Points);

                if (withFill)
                {
                    graph.FillPolygon(new SolidBrush(SolidBrush), drawPoints);
                }
                graph.DrawPolygon(new Pen(FigurePen), drawPoints);
            }
        }


        private bool haveEmptyPoints()
        {
            for (int i = 0; i < Points.Length; i++)
            {
                if (Points[i].IsEmpty)
                    return true;
            }
            return false;
        }

        private Point[] getDrawPoints(Point[] Points)
        {
            Point[] drawPoints = new Point[4];
            drawPoints[0] = Points[0];
            drawPoints[2] = Points[1];
            drawPoints[1] = new Point(Points[0].X + (Math.Abs(Points[1].X - Points[0].X) / 2), Points[0].Y);
            drawPoints[3] = new Point(Points[1].X - (Math.Abs(Points[1].X - Points[0].X) * 3 / 2), Points[1].Y);
            return drawPoints;
        }
    }
}

