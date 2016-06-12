using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLib
{
    [Serializable]
    public class Line:IShape
    {
        Point ptStartPoint;

        public Point PtStartPoint
        {
            get { return ptStartPoint; }
            set { ptStartPoint = value; }
        }
        Point ptEndPoint;

        public Point PtEndPoint
        {
            get { return ptEndPoint; }
            set { ptEndPoint = value; }
        }
        int style;

        public int Style
        {
            get { return style; }
            set { style = value; }
        }
        int width;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        Color color;

        public Color PenColor
        {
            get { return color; }
            set { color = value; }
        }
        public Line()
        {
            this.PenColor = Color.Azure;
            this.Width = 3;
            this.Style = 1;
            this.PtStartPoint = new Point(10, 10);
            this.PtEndPoint = new Point(100, 100);
        }
        public Line(Point ptst, Point ptend, int style, int width, Color color)
        {
            this.PenColor = color;
            this.Width = width;
            this.Style = style;
            this.PtStartPoint = ptst;
            this.PtEndPoint = ptend;
        }
        public void Draw(Graphics g)
        {
            Pen drawPen = new Pen(PenColor, Width);
            g.DrawLine(drawPen, PtStartPoint, PtEndPoint);
        }
    }
}
