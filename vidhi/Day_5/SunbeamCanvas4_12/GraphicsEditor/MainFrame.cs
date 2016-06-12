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


namespace GraphicsEditor
{
    public partial class MainFrame : Form
    {

        ArrayList shapes = new ArrayList();
        int optionShape = 1;

        public int OptionShape
        {
            get { return optionShape; }
            set { optionShape = value; }
        }
        public ArrayList Shapes
        {
            get { return shapes; }
            set { shapes = value; }
        }

        public MainFrame()
        {
            InitializeComponent();
        }

        private void OnViewCanvasSelected(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();

        }

        private void OnViewGridSelected(object sender, EventArgs e)
        {
            ListForm frm = new ListForm();
            frm.MdiParent = this;
            frm.Show();

        }

        private void OnViewChartSelected(object sender, EventArgs e)
        {
            ChartForm frm = new ChartForm();
            frm.MdiParent = this;
            frm.Show();

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

      
    }
}
