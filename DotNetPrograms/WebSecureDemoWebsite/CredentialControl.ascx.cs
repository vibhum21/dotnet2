using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
public partial class CredentialControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        string username=this.TextBox1.Text;
        string password=this.TextBox2.Text;
        
        if (Membership.ValidateUser(username, password))
            this.Response.Redirect("Default.aspx");
    }
}