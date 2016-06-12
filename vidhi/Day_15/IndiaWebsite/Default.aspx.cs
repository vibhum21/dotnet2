using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

       // Response.Redirect("login.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string productName = this.TextBox1.Text;
        //preserver the state of username inside session Variable
        this.Session.Add("product", productName);

        Response.Redirect("order.aspx");


    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string str_like = this.Application["like"].ToString();
       int like=int.Parse(str_like);
        like++;
        this.Application["like"]=like;
        Object productCatalog = GetDataFromDatabase();

        Cache.Insert("MyData", productCatalog, null, // Expire in 1 hour
        DateTime.Now.AddHours(1), TimeSpan.Zero);
       
   }

    public DataSet GetDataFromDatabase()
    {
        DataSet ds = new DataSet();
        //ADo.NET Code
        return ds;
    }
}