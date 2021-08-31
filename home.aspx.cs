using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using datacheck;
public partial class log : System.Web.UI.Page
{
    success dc = new success();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Btnewuser_Click(object sender, EventArgs e)
    {
        Response.Redirect("signup.aspx");
    }

    protected void Btlogin_Click(object sender, EventArgs e)
    {
        SqlDataReader rd = dc.display("select * from CCuser where name ='"+txtbxuser.Text+"' and password='"+Txtbxpd.Text+"'");
        if(rd.HasRows)
        {
            Session["uname"] = txtbxuser.Text;
            Response.Redirect("conversion.aspx");
        }
        else
        {
            RegisterStartupScript("s", "<script>alert('Invalid Username & Password')</script>");
        }
        
    }


    protected void Btfree_Click(object sender, EventArgs e)
    {
        Response.Redirect("freeconversions.aspx");
    }
}