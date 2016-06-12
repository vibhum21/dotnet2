using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register : System.Web.UI.Page
{
 //   protected override void OnPreInit(EventArgs e)
 //{
 //       string themeName = this.Request.QueryString["Theme"];
 //       switch (themeName)
 //       {
 //           case "BasicBlue":
 //               {
 //                   this.Theme = "BasicBlue";
 //                   this.MasterPageFile="BasicBlue.master";
 //               }
 //               break;
 //           case "SilverGold":
 //               {
 //                   this.Theme = "SilverGold";
 //               }
 //               break;
 //           case "Corporate":
 //               {
 //                   this.Theme = "Corporate";
 //               }
 //               break;
 
 //       }
 //       base.OnPreInit(e);
 //   }
    protected void Page_Load(object sender, EventArgs e)
    {

        //this.Trace.Write("PagelifeCycle", "Register Event is invoked");
        this.Trace.Warn("PagelifeCycle", "Warning :Register Event is invoked");


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        this.Trace.Warn("Button event is invoked !");
        //this.Trace.Write("PagelifeCycle", "Button click Event is invoked");

    }
}