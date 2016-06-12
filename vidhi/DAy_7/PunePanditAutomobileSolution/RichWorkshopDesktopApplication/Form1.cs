using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkshopBLLLib;
using WorkshopClLib;

namespace RichWorkshopDesktopApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'panditAutomobileDBDataSet.Employees' table. You can move, or remove it, as needed.
                 List<Customer> customers = CustomerContext.GetALL();
            foreach (Customer cst in customers)
            {  
                string strCst=cst.FirstName+ " " + cst.Lastname;

                this.listView1.Items.Add(strCst);

            }

        }
    }
}
