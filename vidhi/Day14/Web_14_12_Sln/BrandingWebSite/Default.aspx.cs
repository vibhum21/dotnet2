using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
//using System.Net.Mail;
using System.Web.Mail;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //MailMessage msg = new MailMessage();
        //msg.To = "ravi.tambade@transflower.in";
        //msg.From = "nitin.kudale@sunbeaminfo.com";
        //msg.Subject = "Page load event is occured";
        //msg.Body = "<h1>Hey help me ! </h1>";
        
        //SmtpMail.SmtpServer = "";

        //SmtpMail.Send(msg);

       
        //EventLog log = new EventLog();
        //log.WriteEntry("My asp.net Website default Page load event is occured");


       // this.Trace.Write("Page load event of Home is called");


    }

    protected void DDLstCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        string category = this.DDLstCategory.SelectedValue;

        this.Response.Redirect("details.aspx?category="+category);
    }
}