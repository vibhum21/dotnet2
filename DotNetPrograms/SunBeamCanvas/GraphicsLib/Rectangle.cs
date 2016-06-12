using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace GraphicsLib
{
    [Serializable]
   public class Rectangle1:IShape
    {
        Color color;

        public Color PenColor
        {
            get { return color; }
            set { color = value; }
        }
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
        int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public Rectangle1()
        {
            this.PenColor = Color.Red;
            this.Width = 30;
            this.Height = 40;
            this.Style = 1;
            this.PtStartPoint = new Point(10, 10);
            this.PtEndPoint = new Point(100, 100);
        }
        public Rectangle1(Point ptst, Point ptend, int style, int width, int height, Color color)
        {
            this.PtStartPoint = ptst;
            this.PtEndPoint = ptend;
            this.Style = style;
          
            this.Width = width;
            this.Height = height;
            this.PenColor = color; 
        }
        public void Draw(Graphics g)
        {
            Pen drawPen = new Pen(Color.Red, 1);
            Width = PtStartPoint.X - PtEndPoint.X;
            Height = PtStartPoint.Y - PtEndPoint.Y;
            g.DrawRectangle(drawPen, PtStartPoint.X, PtEndPoint.Y,Width,Height);
        }
    }
}
