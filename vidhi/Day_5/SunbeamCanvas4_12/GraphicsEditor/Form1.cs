using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

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
            IShape shape = null;
            MainFrame parent = this.MdiParent as MainFrame;

            switch (parent.OptionShape)
            {
                case 1:
                    shape = new Line(startPoint, endPoint, 1, 2, Color.Red);
                break;
                case 2:
                    shape = new GraphicLib.Rectangle(startPoint, endPoint, 1, 2, Color.Red);
                break;
                case 3:
                    shape = new GraphicLib.Ellipse(startPoint, endPoint, 1, 2, Color.Red);
                 break;
           }

            Graphics g = this.CreateGraphics();
            if (shape != null)
            {
               
                MainFrame root = this.MdiParent as MainFrame;
                root.Shapes.Add(shape);
                shape.Draw(g);
            }

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            MainFrame root = this.MdiParent as MainFrame;

            foreach (IShape shape in root.Shapes)
            {
                shape.Draw(e.Graphics);
            }
        }
    }
}
