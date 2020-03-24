using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOTPiSP2
{
    [Serializable]
    abstract public class Figure : ICloneable
    {
        protected bool isDynamic;

        public Color FigurePen { set; get; }
        public Color SolidBrush { set; get; }
        public Point[] Points;
        public bool IsDynamic { get { return isDynamic; } }

        abstract public object Clone(); 

        abstract public void Draw(Graphics graph);
    }
}
