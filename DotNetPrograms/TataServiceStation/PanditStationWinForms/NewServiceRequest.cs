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
    public partial class NewServiceRequest : Form
    {
        List<Customer> list = null;
        List<Vehicle> lists = null;
        List<Oil> olist = null;
        string vehicle = null;
        List<SparePart> splist = null;
        public NewServiceRequest()
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
                    lists = new List<Vehicle>();
                    lists = VehicleCL.GetALL();
                    foreach (Vehicle veh in lists)
                        if (cust.customerId.Equals(veh.customerId))
                        {
                            this.VehicleList.Items.Add(veh.vehicleNumber);
                            vehicle = veh.vehicleNumber;
                        }
                }
            }
        }

        private void NewServiceRequest_Load(object sender, EventArgs e)
        {
            list = new List<Customer>();
            list = CustomerCL.GetAll();
            foreach (Customer cust in list)
            {
                this.CustomerList.Items.Add(cust.name);
            }
        }

        private void VehicleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServicePanel.Visible = true;
        }
        private void OilingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string oilname = this.OilingComboBox.SelectedItem.ToString();
            OilQuantityPanel.Visible = true;

        }
        private void MaintenanceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sparepartname = this.MaintenanceComboBox.SelectedItem.ToString();
            MaintenQtyPanel.Visible = true;
            
        }

        private void OilingRadio_CheckedChanged(object sender, EventArgs e)
        {
            OilingPanel.Visible = true;
            olist = new List<Oil>();
            olist = OilCL.GetAll();
            foreach (Oil oil in olist)
                this.OilingComboBox.Items.Add(oil.Title);
        }

        private void MaintenanceRadio_CheckedChanged(object sender, EventArgs e)
        {
            MaintenancePanel.Visible = true;
            splist = new List<SparePart>();
            splist = SparePartCL.GetAll();
            foreach (SparePart sp in splist)
                this.MaintenanceComboBox.Items.Add(sp.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(OilQtyTextBox.Text);
            Job job = new Job(4, "Oiling", "Oiling Car", DateTime.Now, vehicle, 450, quantity, 3);
            JobCL.Insert(job);
            OilCL.Update();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(SPQtyTextBox.Text);
            Job job = new Job(5, "Maintenance", "Washing Car", DateTime.Now, vehicle, quantity,300, 1);
            JobCL.Insert(job);
            OilCL.Update();
            this.Close();
        }
    }
}
