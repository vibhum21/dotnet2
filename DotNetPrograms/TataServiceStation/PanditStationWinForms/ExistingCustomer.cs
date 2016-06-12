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
namespace PanditStationWinForms
{
    public partial class ExistingCustomer : Form
    {
        List<Customer> list = null;
        List<Vehicle> lists = null;
       
        public ExistingCustomer()
        {
            InitializeComponent();
        }

        private void CustomerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string custname = this.CustomerList.SelectedItem.ToString();
            list = new List<Customer>();
            list = CustomerCL.GetAll();
            foreach (Customer cust in list)
            {
                if (custname.Equals(cust.name))
                {
                    this.CustIDLabel.Text = cust.customerId.ToString();
                    this.NameLabel.Text = cust.name.ToString();
                    this.AddressLabel.Text = cust.address.ToString();
                    this.MobileLabel.Text = cust.mobile.ToString();
                    this.CreditAmtLabel.Text = cust.creditAmount.ToString();
                    lists = new List<Vehicle>();
                    lists = VehicleCL.GetALL();
                    foreach (Vehicle veh in lists)
                        if(cust.customerId.Equals(veh.customerId))
                            this.VehicleList.Items.Add(veh.vehicleNumber);
                }

            }
        }

        private void ExistingCustomer_Load(object sender, EventArgs e)
        {
            list = new List<Customer>();
            list = CustomerCL.GetAll();
            foreach(Customer cust in list)
            {
                this.CustomerList.Items.Add(cust.name);
            }

        }

        private void VehicleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string vehNumber = this.VehicleList.SelectedItem.ToString();
            lists = new List<Vehicle>();
            lists = VehicleCL.GetALL();
            foreach (Vehicle veh in lists)
                if (vehNumber.Equals(veh.vehicleNumber))
                {
                    this.CustIDLabel2.Text = veh.customerId.ToString();
                    this.VehNumLabel.Text = veh.vehicleNumber.ToString();
                    this.CompNameLabel.Text = veh.company.ToString();
                    this.ModelNameLabel.Text = veh.model.ToString();
                }
            
        }

        private void CustAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustCredit_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerListView_Selected(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

       

       

       

       

       
    }
}
