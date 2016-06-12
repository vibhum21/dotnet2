using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void LnkBtnFavourite_Click(object sender, EventArgs e)
    {
        // Get the ID of the comic that's currently displayed
     string id = (DetailsView1.Rows[0].Cells[1].Text);

        //string id = this.Session["ProductID"].ToString();
        // Add or remove a comic
        if (LnkBtnFavourite.CommandName == "Add")
        {
            // Create a FavoriteComics object if it doesn't exist
            if (Profile.Favorites == null)
                Profile.Favorites = new FavoriteTitle();
            Profile.Favorites.AddTitle(id);
        }
        else
            Profile.Favorites.RemoveTitle(id);

    }



    protected override void OnLoadComplete(EventArgs e)
    {
        // Get the ID of the comic that's currently displayed
        string id = (DetailsView1.Rows[0].Cells[1].Text);
        // Initialize the LinkButton text
        if (Profile.Favorites == null || !Profile.Favorites.IsInFavoritesList(id))
        {
            LnkBtnFavourite.Text = "Add this comic to my Favorites list";
            LnkBtnFavourite.CommandName = "Add";
        }
        else
        {
            LnkBtnFavourite.Text = "Remove this comic from my Favorites list";
            LnkBtnFavourite.CommandName = "Remove";
        }
    }

}