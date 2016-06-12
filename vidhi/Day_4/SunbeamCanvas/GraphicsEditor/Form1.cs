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
        int optionShape = 1;
        ArrayList shapes = new ArrayList();

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

            switch (optionShape)
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
                this.shapes.Add(shape);
                shape.Draw(g);
            }

        }

        private void OnShapeLineSelected(object sender, EventArgs e)
        {
            optionShape = 1;
        }

        private void OnShapeRectangleSelected(object sender, EventArgs e)
        {
            optionShape = 2;

        }

        private void OnShapeEllipseSelected(object sender, EventArgs e)
        {
            optionShape = 3;

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filename = dlg.FileName;
                FileStream fStream = new FileStream(filename, FileMode.OpenOrCreate);
              
                BinaryFormatter bf = new BinaryFormatter();
               
                this.shapes=bf.Deserialize(fStream) as ArrayList;
                fStream.Close();


            }
            this.Invalidate();

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filename = dlg.FileName;
                FileStream fStream = new FileStream(filename, FileMode.OpenOrCreate);
                SoapFormatter bf = new SoapFormatter();
                bf.Serialize(fStream, shapes);
                fStream.Close();


 
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (IShape shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
        }
    }
}