using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphicsLib;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
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

         private void Form1_Load(object sender, EventArgs e)
         {

         }
        
         private void mouseUp(object sender, MouseEventArgs e)
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
                     shape = new GraphicsLib.Rectangle1(startPoint, endPoint, 1, 1, 2, Color.Red);
                     break;
                 case 3:
                     shape = new GraphicsLib.Eclipse(startPoint, endPoint, 1, 1, 2, Color.Red);
                     break;
             }
             Graphics g = this.CreateGraphics();
             if(shape!=null)
             {
                 MainFrame root = this.MdiParent as MainFrame;
                 root.Shapes.Add(shape);
                 //this.shapes.Add(shape);
                 shape.Draw(g);
             }
         }

         private void mouseDown(object sender, MouseEventArgs e)
         {
             startPoint = new Point(e.X, e.Y);
         }

         private void openToolStripMenuItem_Click(object sender, EventArgs e)
         {
             OpenFileDialog ofg = new OpenFileDialog();
             if(ofg.ShowDialog() == DialogResult.OK)
             {
                 string fileName = ofg.FileName;
                 FileStream fStream = new FileStream(fileName, FileMode.OpenOrCreate);
                 BinaryFormatter bf = new BinaryFormatter();
                 this.shapes = bf.Deserialize(fStream) as ArrayList;
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
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fStream, shapes);
                fStream.Close();
            }
         }

         private void lineToolStripMenuItem_Click(object sender, EventArgs e)
         {
             optionShape = 1;
         }

         private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
         {
             optionShape = 2;
         }

         private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
         {
             optionShape = 3;
         }

         private void Form1_Paint(object sender, PaintEventArgs e)
         {
             MainFrame root = this.MdiParent as MainFrame;
             foreach(IShape shape in root.Shapes)
             {
                 shape.Draw(e.Graphics);
             }
         }
    }
}
