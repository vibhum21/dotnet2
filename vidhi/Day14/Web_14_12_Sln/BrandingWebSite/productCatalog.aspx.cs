using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class productCatalog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string productId = this.ListBox1.SelectedValue.ToString();
        this.Response.Redirect("productdetails.aspx?product=" + productId);
    }
}