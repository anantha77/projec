using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class emiwoacc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btncalculate_Click(object sender, EventArgs e)
    {
        double principle = double.Parse(Txtbxprinciple.Text);
       float interest = float.Parse(Txtbxinterest.Text);
        double month = double.Parse(Txtbxmonths.Text);
        double totalemi, emi, Install;
        double value1, value2;
        if (interest < 100 && principle > 0)
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
            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script>alert('Interest or Principle Amount is Invalid')");
        }
    }

    protected void Txtbxprinciple_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Txtbxinterest_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Txtbxmonths_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Txtbxtotalcost_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Txtbxemi_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Txtbxmonthlyinstall_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnbackemi_Click(object sender, EventArgs e)
    {
        Response.Redirect("freeconversions.aspx");
    }
}