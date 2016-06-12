using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Products : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
     
    protected void Button1_Click(object sender, EventArgs e)
    {
        this.Response.Write("Clicked!");

    }
    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        this.Response.Redirect("ProductDetails.aspx?ProductID=" + GridView1.SelectedValue);

    }
}