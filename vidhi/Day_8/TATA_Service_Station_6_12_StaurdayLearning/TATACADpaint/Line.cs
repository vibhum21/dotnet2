using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TATACADpaint
{
    [Serializable]
  public   class Line:Shape
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public int Width { get; set; }
        public Color LineColor { get; set; }

        public Line()
        {
            StartPoint = new Point(0, 0);
            EndPoint = new Point(0, 0);
            Width = 0;
            LineColor = Color.Red;
        }
 
        public Line(Point ptst,Point ptend,int w,Color c)
        {
            StartPoint = ptst;
            EndPoint = ptend;
            Width = w;
            LineColor = c;
        }

        public override  void Draw(Graphics g)
        {
            Pen linePen = new Pen(LineColor, Width);
            g.DrawLine(linePen,StartPoint, EndPoint);

        }
    }
}
