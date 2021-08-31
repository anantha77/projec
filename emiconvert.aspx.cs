using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using unitconvertor;

public partial class emiconvert : System.Web.UI.Page
{
    convertor cv = new convertor();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnbackemi_Click(object sender, EventArgs e)
    {
        Response.Redirect("conversion.aspx");

    }

    protected void btnsaveemi_Click(object sender, EventArgs e)
    {
        cv.getemi("insert into emiconvert values ('" + Txtbxfilename.Text + "','" + Txtbxprinciple.Text + "','" + Txtbxinterest.Text + "','" + Txtbxmonths.Text + "','" + Txtbxtotalcost.Text + "','" + Txtbxemi.Text + "','" + Txtbxmonthlyinstall.Text + "')");
        RegisterStartupScript("s", "<script> alert('Added successfully...')</script>");
    }

    protected void bthistoryemi_Click(object sender, EventArgs e)
    {
        Response.Redirect("emihistory.aspx");
    }

    protected void btncalculate_Click(object sender, EventArgs e)
    {
        double principle = double.Parse(Txtbxprinciple.Text);
        double interest = double.Parse(Txtbxinterest.Text);
        double month = double.Parse(Txtbxmonths.Text);
        double totalemi, emi, Install;
        double value1, value2;
        if(interest<100 && principle>0)
        {
            value2 = interest / 12;
            emi = (principle * (value2 / 100) * Math.Pow((1 + value2 / 100), month) / (Math.Pow((1 + value2 / 100), (month - 1))));
            totalemi = emi * month;
            int TotalEMI = Convert.ToInt32(totalemi);
            value1 = principle + totalemi;
            int value = Convert.ToInt32(value1);
            Install = value1 / month;
            int monthly = Convert.ToInt32(Install);
            Txtbxtotalcost.Text = value.ToString();
            Txtbxemi.Text = TotalEMI.ToString();
            Txtbxmonthlyinstall.Text = monthly.ToString();
        }
        else
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "s", "<script>alert('Interest or Principle Amount is Invalid')");
        }
    }

    protected void Txtbxmonthlyinstall_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Txtbxemi_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Txtbxtotalcost_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Txtbxfilename_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Txtbxmonths_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Txtbxinterest_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Txtbxprinciple_TextChanged(object sender, EventArgs e)
    {

    }
}