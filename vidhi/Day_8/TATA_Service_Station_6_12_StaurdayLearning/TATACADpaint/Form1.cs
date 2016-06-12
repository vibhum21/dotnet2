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
using System.Runtime.Serialization.Formatters.Soap;



 namespace TATACADpaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Member variables to Form for collecting 
        //data from menuItems, Dialog

        int width = 1;
        Color penColor = Color.Blue;
        Point ptStart = new Point();
        Point ptEnd = new Point();
        List<Shape> shapes = new List<Shape>();

       

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            width = 2;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            width = 3;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            width = 4;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            width = 5;

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            width = 7;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            width = 10;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                penColor = dlg.Color;
            }
        }


        private void OntflFrmMouseDown(object sender, MouseEventArgs e)
        {
            ptStart.X = e.X;
            ptStart.Y = e.Y;
        }
        private void OntflFrmMouseUp(object sender, MouseEventArgs e)
        {
            Point ptEnd = new Point();
            ptEnd.X = e.X;
            ptEnd.Y = e.Y;
            Graphics g = this.CreateGraphics();
            Line shape = new Line(ptStart, ptEnd, width, penColor);
            shapes.Add(shape);
            shape.Draw(g); 
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {   SaveFileDialog dlg = new SaveFileDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                string path=dlg.FileName;
                FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                // BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream,shapes);
                stream.Close();            
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string path = dlg.FileName;
                FileStream stream = new FileStream(path, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                shapes=bf.Deserialize(stream) as List<Shape>;
                stream.Close();
            }
            Invalidate();
        }
        
    }
}
