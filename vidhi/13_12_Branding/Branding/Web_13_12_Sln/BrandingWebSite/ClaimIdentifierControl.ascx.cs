using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ClaimIdentifierControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSignIn_Click(object sender, EventArgs e)
    {
        string userName = this.txtUserName.Text;
        string password = this.txtPassword.Text;
        CredentialContext ctx = new CredentialContext();
        if (ctx.Authenticate(userName, password))
        {
            this.Response.Redirect("default.aspx");

        }
        else    

        {
            this.lblStatus.Text = "Invalid User , Please try again !";
        }
    }
}