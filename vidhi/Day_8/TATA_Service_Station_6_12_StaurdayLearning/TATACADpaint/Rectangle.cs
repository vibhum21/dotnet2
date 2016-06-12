using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TATACADpaint
{

    [Serializable]
    public class Rectangle:Shape
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public int Width { get; set; }
        public Color RectangleColor { get; set; }

        public Rectangle()
        {
            StartPoint = new Point(0, 0);
            EndPoint = new Point(0, 0);
            Width = 0;
            RectangleColor = Color.Red;
        }

        public Rectangle(Point ptst, Point ptend, int w, Color c)
        {
            StartPoint = ptst;
            EndPoint = ptend;
            Width = w;
            RectangleColor = c;
        }

        public override void Draw(Graphics g)
        {
            Pen rectPen = new Pen(RectangleColor, Width);
             int rectWidth=EndPoint.X-StartPoint.X;
            int rectHeight=EndPoint.Y-StartPoint.Y;
            g.DrawRectangle(rectPen, StartPoint.X, StartPoint.Y, rectWidth, rectHeight);

        }
    }
}
