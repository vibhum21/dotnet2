using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eCommerceBOL;
using eCommerceDAL;
public partial class RegisterCtrl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string firstname = this.TextBox1.Text;
        string lastname = this.TextBox2.Text;
        string address = this.DropDownList1.Text;
        string email = this.TextBox4.Text;
        string mobile = this.TextBox6.Text;
        string password = this.TextBox3.Text;
        string role = this.Label12.Text;
        Customer cust = new Customer(7, firstname, lastname, address, email, mobile, password, role);
        CustomerDAL.Insert(cust);
        this.Response.Redirect("login.aspx");
    }
}