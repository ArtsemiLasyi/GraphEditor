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
    public class Line : Figure
    {
        new private Color SolidBrush;
        public Line(Color pen, Point point1, Point point2)
        {
            Points = new Point[2];
            FigurePen = pen;
            Points[0] = point1;
            Points[1] = point2;
            isDynamic = false;
        }

        public Line()
        {
            Points = new Point[2];
            FigurePen = Color.Black;
            SolidBrush = Color.White;
            Points[0] = new Point(0, 0);
            Points[1] = new Point(0, 0);
            isDynamic = false;
        }

        override public void Draw(Graphics graph)
        {
            graph.DrawLine(new Pen(FigurePen), Points[0], Points[1]);
        }


        public override object Clone()
        {
            return new Line(FigurePen, Points[0], Points[1]);
        }

        public void Draw(Graphics graph, bool withFill)
        {
            graph.DrawLine(new Pen(FigurePen), Points[0], Points[1]);
        }

    }
}
