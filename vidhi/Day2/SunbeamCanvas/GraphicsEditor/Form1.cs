using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphicLib;

namespace GraphicsEditor
{
    public partial class Form1 : Form
    {
        Point startPoint;
        Point endPoint;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
             startPoint = new Point(e.X, e.Y);

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
          
             endPoint = new Point(e.X, e.Y);
            IShape shape = new Line(startPoint, endPoint, 1, 2, Color.Red);
            Graphics g = this.CreateGraphics();
            shape.Draw(g);
        }
    }
}
