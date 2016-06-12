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
    public partial class NewBill : Form
    {
        List<Bill> blist = null;
        List<Customer> list = null;
        List<Vehicle> lists = null;
        List<Job> jlist = null;
        Oil oil=null;
        SparePart sp=null;
        public NewBill()
        {
            InitializeComponent();
        }

        private void JobListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
                    lists = new List<Vehicle>();
                    lists = VehicleCL.GetALL();
                    foreach (Vehicle veh in lists)
                        if (cust.customerId.Equals(veh.customerId))
                            this.VehicleList.Items.Add(veh.vehicleNumber);
                }

            }
        }

        private void VehicleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            BillingPanel.Visible = true;
            string vehnum = this.VehicleList.SelectedItem.ToString();
            jlist = new List<Job>();
            jlist = JobCL.GetAll();
            
            foreach (Job job in jlist)
            {
                if (vehnum.Equals(job.VehicleNumber))
                {
                    ListViewItem lstvwi = new ListViewItem(job.JobId.ToString());
                    lstvwi.SubItems.Add(job.JobType.ToString());
                    lstvwi.SubItems.Add(job.JobDate.ToString());
                    lstvwi.SubItems.Add(job.ServiceCharge.ToString());
                    lstvwi.SubItems.Add(job.Quantity.ToString());
                    
                    if (JobType.Text == "Oiling")

                        lstvwi.SubItems.Add(oil.Price.ToString());
                    else
                    {
                        sp = SparePartCL.Get(job.SparePartId);
                        lstvwi.SubItems.Add(sp.UnitPrice.ToString());
                    }
                    JobListView.Items.Add(lstvwi);   
                }
                
            }
        }

        private void NewBill_Load(object sender, EventArgs e)
        {
            list = new List<Customer>();
            list = CustomerCL.GetAll();
            foreach (Customer cust in list)
            {
                this.CustomerList.Items.Add(cust.name);
            }
        }
    }
}
