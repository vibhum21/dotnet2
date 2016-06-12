using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WheelsInCloud
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string dateTime = DateTime.Now.ToShortTimeString();
            //  this.Response.Write("<h3>" + "Time is " + dateTime + "</h3>");
            this.Label1.Text = dateTime;
            if (this.IsPostBack == false)
            {
                //string name=  this.Request.QueryString["username"];
                // string name = this.Request.Cookies["username"].Value;
                User usr = this.Session["username"] as User;
                this.Label1.Text = usr.FirstName;
            }
        }
            protected override void OnInit(EventArgs e)
{
 	 base.OnInit(e);
} 
        protected override void OnPreInit(EventArgs e)
{
 	 base.OnPreInit(e);
}
        protected override void OnPreLoad(EventArgs e)
{
 	 base.OnPreLoad(e);
}
        }
    }
}