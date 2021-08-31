using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class freeconversions : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Btmoney_Click(object sender, EventArgs e)
    {
        Response.Redirect("moneywoacc.aspx");
    }

    protected void Btemi_Click(object sender, EventArgs e)
    {
        Response.Redirect("emiwoacc.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("untiwoacc.aspx");
    }
}