using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class conversion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["uname"]==null)
        {
            Response.Redirect("home.aspx");
        }
        Label1.Text = " Welcome " + (string)Session["uname"] + " ...!!!";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("unitconvert.aspx");

    }

    protected void btlogout_Click(object sender, EventArgs e)
    {
        Session["uname"] = null;
        Response.Redirect("home.aspx");

    }

    protected void Btmoney_Click(object sender, EventArgs e)
    {
        Response.Redirect("moneyconvertor.aspx");
    }

    protected void Btemi_Click(object sender, EventArgs e)
    {
        Response.Redirect("emiconvert.aspx");
    }
}