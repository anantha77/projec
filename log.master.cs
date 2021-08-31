using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class log : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void AdRotator1_AdCreated(object sender, AdCreatedEventArgs e)
    {
        //System.Threading.Thread.Sleep(5000);
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {

    }

    protected void lblcnt_Click(object sender, EventArgs e)
    {
        Response.Redirect("terms.aspx");
    }

    protected void lblfeedback_Click(object sender, EventArgs e)
    {
        Response.Redirect("overview.aspx");
          
    }

    protected void lblabtus_Click(object sender, EventArgs e)
    {
        Response.Redirect("aboutus.aspx");
    }
}
