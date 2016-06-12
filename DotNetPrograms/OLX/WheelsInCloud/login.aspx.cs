using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TATAIdentityLib;
using TATABOLLib;
using TATADALLib;
namespace WheelsInCloud
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
                this.Response.Write("Page Load is called due to Get");
            else
                this.Response.Write("Page Load is called due to Post");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TATABOLLib.Credential user = new Credential();
            user.LoginName = this.TextBox2.Text;
            user.Password = this.TextBox3.Text;
            bool status=CredentialManager.Validate(user.LoginName, user.Password);
            if (status == true)
                Response.Redirect("home.aspx");

            string name = this.TextBox2.Text;
            string password = this.TextBox3.Text;
            if (CredentialManager.Validate(user.LoginName, user.Password))
            {
                HttpCookie ck = new HttpCookie("username", name);
                User usr = new User { FirstName = name };
                // UserDAL.GetUser(name)
                // this.Response.Cookies.Add(ck);
                this.Session.Add("username", usr);
                this.Response.Redirect("home.aspx");
                //this.Response.Redirect("home.aspx?username="+name);
            }
            else
                this.Label4.Text = "Try again";
        }
    }
}