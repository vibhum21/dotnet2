using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PanditBOLLib;
using PanditCLLib;
using PanditDALLib;
namespace PanditStationWinForms
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int customerId = int.Parse(CustomerID.Text);
            string customerName = CustomerName.Text;
            string customerAddress = CustAddress.Text;
            string mobile = CustMobile.Text;
            double creditAmt = double.Parse(CustCreditAmt.Text);
            Customer cust = new Customer(customerId,customerName, customerAddress, mobile, creditAmt);
            CustomerCL.Insert(cust);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int customerID =int.Parse(CustIDBox.Text);
           
            string vehicleNumber = VehicleNumberBox.Text;
            string company = CompanyBox.Text;
            string model = ModelBox.Text;
            Vehicle veh = new Vehicle(customerID, vehicleNumber, company, model);
            VehicleCL.Insert(veh);
        } 
    }
}
