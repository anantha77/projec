using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using createuser;

public partial class signup : System.Web.UI.Page
{
    createuser1 cu = new createuser1();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlstate.Items.Clear();
        if(ddlcountry.SelectedItem.Text=="India")
        {
            ddlstate.Items.Add("TamilNadu");
            ddlstate.Items.Add("Andhra Pradesh");
            ddlstate.Items.Add("Arunachal Pradesh	");
            ddlstate.Items.Add("Assam");
            ddlstate.Items.Add("Bihar");
            ddlstate.Items.Add("Goa");
            ddlstate.Items.Add("Gujarat");
            ddlstate.Items.Add("Haryana");
            ddlstate.Items.Add("Himachal Pradesh	");
            ddlstate.Items.Add("Karnataka	");
            ddlstate.Items.Add("Kerala");
            ddlstate.Items.Add("Maharashtra");
            ddlstate.Items.Add("Punjab");
            ddlstate.Items.Add("Rajasthan");
        }
        if (ddlcountry.SelectedItem.Text == "America")
        {
            ddlstate.Items.Add("Alabama");
            ddlstate.Items.Add("Alaska");
            ddlstate.Items.Add("Arizona");
            ddlstate.Items.Add(" Arkansas");
            ddlstate.Items.Add("California");
            ddlstate.Items.Add("Florida");
            ddlstate.Items.Add("Georgia");
            ddlstate.Items.Add("New Mexico");

        }
        if(ddlcountry.SelectedItem.Text=="England")
        {
            ddlstate.Items.Add("London");
            ddlstate.Items.Add("Leicester");
            ddlstate.Items.Add("Portsmouth");
            ddlstate.Items.Add("Swindon");
            ddlstate.Items.Add("Bournemouth");
            ddlstate.Items.Add("Northumberland");
            ddlstate.Items.Add("Derby");
        }

    }

    protected void Btcreateaccount_Click(object sender, EventArgs e)
    {
        cu.getdata("insert into CCuser values ('"+Txtbxuser.Text+"','"+TxtBxpd.Text+"','"+Txtbxrepd.Text+"','"+Txtbxemail.Text+"','"+rblgender.SelectedItem+"','"+ddlcountry.SelectedItem+"','"+ddlstate.SelectedItem+"')");

        ClientScript.RegisterStartupScript(Page.GetType(),"validation", "<script>alert ('Account added Successfully')</Script>");
       // Response.Redirect("conversion.aspx");
    }
}