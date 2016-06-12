using System;
using System.Collections.Generic;

using System.Collections;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CRM;

namespace WorkshopDesktop
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        ArrayList customers = new ArrayList();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int age = int.Parse(txtAge.Text);
            string lNumber = this.txtLNumber.Text;
            DateTime bDate = Convert.ToDateTime(txtBirthdate.Text);
            Customer cst = new Customer(firstName, lastName, age, bDate, lNumber);
            customers.Add(cst);
      
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            foreach (Customer cst in customers)
            {
                MessageBox.Show(cst.ToString());
            }

        }
    }
}
