using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOTPiSP2
{
    public partial class fmMain : Form
    {
        const string LINE = "Линия";
        const string RECTANGLE = "Прямоугольник";
        const string SQUARE = "Квадрат";
        const string TRIANGLE = "Треугольник";
        const string POLYGON = "Многоугольник";
        const string ELLIPSE = "Эллипс";

        Figures figuresList;
        Figure activeFigure;

        Dictionary<string, Figure> Tools = new Dictionary<string, Figure>
        {
            [LINE] = new Line(),
            [RECTANGLE] = new Rectangle(),
            [SQUARE] = new Square(),
            [TRIANGLE] = new Triangle(),
            [POLYGON] = new Polygon(),
            [ELLIPSE] = new Ellipse()
        };

        Color brushColor = Color.Black;        //Дефолтный цвет заливки фигуры
        Color penColor = Color.Black;          //Дефолтный цвет контура фигуры

        Bitmap bmp;

        int pointsDrawed = 0;                  //Количество отрисованных точек
        Point lastClick = new Point(-1, -1);   //Координаты последнего клика мышью

        public fmMain()
        {
            InitializeComponent();
            figuresList = new Figures();
            bmp = new Bitmap(pbDraw.Width, pbDraw.Height);
            cbTool.Items.Clear();
            foreach (string key in Tools.Keys)
            {
                cbTool.Items.Add(key);
            }
        }

        private void bbPen_Click(object sender, EventArgs e)
        {
            if (cdChoosePen.ShowDialog() == DialogResult.Cancel)
                return;
            penColor = cdChoosePen.Color;
        }

        private void bbBrush_Click(object sender, EventArgs e)
        {
            if (cdChoosePen.ShowDialog() == DialogResult.Cancel)
                return;
            brushColor = cdChoosePen.Color;
        }

        private void pbDraw_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cbTool.Text.Equals(""))
            {
                if (e.Button == MouseButtons.Left)
                {
                    activeFigure.Points[pointsDrawed] = new Point(e.X, e.Y);
                    lastClick = activeFigure.Points[pointsDrawed];
                    pointsDrawed++;

                    if (activeFigure.IsDynamic)
                    {
                        Array.Resize(ref activeFigure.Points, pointsDrawed + 1);
                    }

                    if (pointsDrawed >= activeFigure.Points.Length)
                    {
                        DrawBMP(bmp, activeFigure);

                        figuresList.Add((Figure)activeFigure.Clone());
                        activeFigure = (Figure)Tools[cbTool.Text].Clone();
                        pointsDrawed = 0;
                        lastClick = new Point(-1, -1);
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    if (activeFigure.IsDynamic && activeFigure.Points.Length > 1)
                    {
                        figuresList.Add((Figure)activeFigure.Clone());
                    }
                    pointsDrawed = 0;
                    activeFigure = (Figure)Tools[cbTool.Text].Clone();
                    lastClick = new Point(-1, -1);

                    Graphics graph = Graphics.FromImage(bmp);
                    graph.Clear(pbDraw.BackColor);
                    figuresList.Draw(graph);
                    pbDraw.Image = bmp;
                }
            }
        }

        private void cbTool_TextChanged(object sender, EventArgs e)
        {
            pointsDrawed = 0;
            activeFigure = (Figure)Tools[cbTool.Text].Clone();
            lastClick = new Point(-1, -1);
        }

        private void pbDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if ((lastClick.X >= 0) && (lastClick.Y >= 0))
            {
                Bitmap tempBmp = bmp;

                activeFigure.Points[pointsDrawed] = new Point(e.X, e.Y);

                //Инициализация поверхности, пера и кисти
                Graphics graph = Graphics.FromImage(tempBmp);
                graph.Clear(pbDraw.BackColor);
                figuresList.Draw(graph);
                activeFigure.FigurePen = penColor;
                activeFigure.SolidBrush = brushColor;

                activeFigure.Draw(graph);
                pbDraw.Image = tempBmp;

            }
        }

        private void bbClear_Click(object sender, EventArgs e)
        {
            figuresList.figureList.Clear();
            Graphics graph = Graphics.FromImage(bmp);
            graph.Clear(pbDraw.BackColor);
            pbDraw.Image = bmp;
        }

        private void bbOpen_Click(object sender, EventArgs e)
        {
            if (odOpenFile.ShowDialog() == DialogResult.Cancel)
                return;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(odOpenFile.FileName, FileMode.Open))
            {
                figuresList = (Figures)formatter.Deserialize(fs);
            }
            Graphics graph = Graphics.FromImage(bmp);
            graph.Clear(pbDraw.BackColor);
            figuresList.Draw(graph);
            pbDraw.Image = bmp;
        }

        private void bbSave_Click(object sender, EventArgs e)
        {
            if (sdSaveFile.ShowDialog() == DialogResult.Cancel)
                return;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(sdSaveFile.FileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, figuresList);
            }
        }

        private void bbCancel_Click(object sender, EventArgs e)
        {
            if (figuresList.figureList.Count > 0)
            {
                figuresList.figureList.RemoveAt(figuresList.figureList.Count - 1);
                Graphics graph = Graphics.FromImage(bmp);
                graph.Clear(pbDraw.BackColor);
                figuresList.Draw(graph);
                pbDraw.Image = bmp;
            }
        }

        private void DrawBMP(Bitmap _bmp, Figure _activeFigure)
        {
            //Инициализация поверхности, пера и кисти
            Graphics graph = Graphics.FromImage(_bmp);
            _activeFigure.FigurePen = penColor;
            activeFigure.SolidBrush = brushColor;

            _activeFigure.Draw(graph);
            pbDraw.Image = _bmp;
            graph.Dispose();
        }
    }
}
