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
namespace PanditStationWinForms
{
    public partial class MainForm : Form
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

        public MainForm()
        {
            InitializeComponent();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCustomer frm = new NewCustomer();
            
            frm.Show();
        }

        private void existingCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExistingCustomer ec = new ExistingCustomer();
            ec.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void serviceRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewServiceRequest nsr = new NewServiceRequest();
            nsr.Show();
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBill nb = new NewBill();
            nb.Show();
        }
    }
}
