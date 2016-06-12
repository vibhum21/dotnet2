using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eCommerceBOL;
using eCommerceDAL;
public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        this.Response.Redirect("register.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        string username = this.TextBox2.Text;
        string password = this.TextBox3.Text;
        List<Customer> cust = CustomerDAL.GetAll();
        foreach(Customer cust1 in cust)
        {
            if (username.Equals(cust1.EmailId) && password.Equals(cust1.Password))
                this.Response.Redirect("ProductCatalog.aspx");
        }
        
    }
   
}