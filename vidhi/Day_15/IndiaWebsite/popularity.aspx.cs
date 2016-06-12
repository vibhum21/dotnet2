using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class popularity : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        int like = int.Parse(this.Application["like"].ToString());
        this.Label1.Text = "Product Poplularity =" + like.ToString();

    }
}