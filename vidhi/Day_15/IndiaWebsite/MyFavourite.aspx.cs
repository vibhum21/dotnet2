using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyFavourite : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ArrayList ds = Profile.Favorites.GetFavorites();
        this.GridView1.DataSource = ds;
        this.GridView1.DataBind();
    }
}