using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOTPiSP2
{
    [Serializable]
    public class Figures
    {
        public List<Figure> figureList;

        public Figures(params Figure[] figures)
        {
            figureList = new List<Figure>();
            for (int i = 0; i < figures.Length; i++)
            {
                figureList.Add(figures[i]);
            }
        }

        public void Add(Figure fig)
        {
            figureList.Add(fig);
        }

        public void Clear()
        {
            figureList.Clear();
        }

        public void Draw(Graphics graph)
        {
            foreach (Figure f in figureList)
            {
                f.Draw(graph);
            }
        }
    }
}
