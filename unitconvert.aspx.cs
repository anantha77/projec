using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using unitconvertor;

public partial class unitconvert : System.Web.UI.Page
{
    convertor cv = new convertor();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Txtbxmile_TextChanged(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Btsave_Click(object sender, EventArgs e)
    {
        cv.getdata("insert into unit_convertor values ( '" + Txtname.Text + "','"+ddlunit.SelectedValue+"','" + Txtbxselect.Text + "','" + Txtbxmile.Text + "','" + Txtbxyard.Text + "','" + Txtbxkilometer.Text + "','" + Txtbxmeter.Text + "','" + Txtbxfoot.Text + "','" + Txtbxinch.Text + "','" + Txtbxmilli.Text + "','" + Txtbxmicro.Text + "','" + Txtbxnano.Text + "')");
        RegisterStartupScript("s", "<script> alert('Added successfully...')</script>");
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Btconvert_Click(object sender, EventArgs e)
    {
        if(Txtbxselect.Text==" ")
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "s", "<script> alert('Please enter some values')");
        }
        else
        {
            double n = Convert.ToDouble(Txtbxselect.Text);
            double ml, yd, km, m, ft, inch, milli, micro, nano;
            if(ddlunit.SelectedItem.Text=="Mile")
            {
                ml = n *1;
                yd = n * 1760;
                km =n*1.609;
                m = n * 1609;
                ft =n*5280;
                inch =n*63360;
                milli =n*1.609e+6;
                micro =n*1.609e+9;
                nano =n*1.609e+12;
                Txtbxmile.Text = ml.ToString();
                Txtbxyard.Text = yd.ToString();
                Txtbxkilometer.Text = km.ToString();
                Txtbxmeter.Text = m.ToString();
                Txtbxfoot.Text = ft.ToString();
                Txtbxinch.Text = inch.ToString();
                Txtbxmilli.Text = milli.ToString();
                Txtbxmicro.Text = micro.ToString();
                Txtbxnano.Text = nano.ToString();
            }
            if (ddlunit.SelectedItem.Text == "Yard")
            {
                ml = n / 1760;
                yd = n * 1;
                km = n / 1094;
                m = n / 1.094;
                ft = n * 3;
                inch = n * 36;
                milli = n * 914;
                micro = n * 914400;
                nano = n * 9.144e+8;
                Txtbxmile.Text = ml.ToString();
                Txtbxyard.Text = yd.ToString();
                Txtbxkilometer.Text = km.ToString();
                Txtbxmeter.Text = m.ToString();
                Txtbxfoot.Text = ft.ToString();
                Txtbxinch.Text = inch.ToString();
                Txtbxmilli.Text = milli.ToString();
                Txtbxmicro.Text = micro.ToString();
                Txtbxnano.Text = nano.ToString();
            }
            if (ddlunit.SelectedItem.Text == "Kilometer")
            {
                ml = n / 1.609;
                yd = n * 1094;
                km = n * 1;
                m = n * 1000;
                ft = n * 3281;
                inch = n * 39370;
                milli = n * 1e+6;
                micro = n * 1e+9;
                nano = n * 1e+12;
                Txtbxmile.Text = ml.ToString();
                Txtbxyard.Text = yd.ToString();
                Txtbxkilometer.Text = km.ToString();
                Txtbxmeter.Text = m.ToString();
                Txtbxfoot.Text = ft.ToString();
                Txtbxinch.Text = inch.ToString();
                Txtbxmilli.Text = milli.ToString();
                Txtbxmicro.Text = micro.ToString();
                Txtbxnano.Text = nano.ToString();
            }
            if (ddlunit.SelectedItem.Text == "Meter")
            {
                ml = n / 1609;
                yd = n * 1.094;
                km = n / 1000;
                m = n * 1;
                ft = n * 3.281;
                inch = n * 39.37;
                milli = n * 1000;
                micro = n * 1e+6;
                nano = n * 1e+9;
                Txtbxmile.Text = ml.ToString();
                Txtbxyard.Text = yd.ToString();
                Txtbxkilometer.Text = km.ToString();
                Txtbxmeter.Text = m.ToString();
                Txtbxfoot.Text = ft.ToString();
                Txtbxinch.Text = inch.ToString();
                Txtbxmilli.Text = milli.ToString();
                Txtbxmicro.Text = micro.ToString();
                Txtbxnano.Text = nano.ToString();
            }
            if (ddlunit.SelectedItem.Text == "Foot")
            {
                ml = n / 5280;
                yd = n /3;
                km = n / 3281;
                m = n * 3.281;
                ft = n * 1;
                inch = n * 12;
                milli = n * 305;
                micro = n * 304800;
                nano = n * 3.048e+8;
                Txtbxmile.Text = ml.ToString();
                Txtbxyard.Text = yd.ToString();
                Txtbxkilometer.Text = km.ToString();
                Txtbxmeter.Text = m.ToString();
                Txtbxfoot.Text = ft.ToString();
                Txtbxinch.Text = inch.ToString();
                Txtbxmilli.Text = milli.ToString();
                Txtbxmicro.Text = micro.ToString();
                Txtbxnano.Text = nano.ToString();
            }
            if (ddlunit.SelectedItem.Text == "Inch")
            {
                ml = n / 63360;
                yd = n /36;
                km = n / 39370;
                m = n /39.37;
                ft = n /12;
                inch = n * 1;
                milli = n * 25.4;
                micro = n * 25400;
                nano = n * 2.54e+7;
                Txtbxmile.Text = ml.ToString();
                Txtbxyard.Text = yd.ToString();
                Txtbxkilometer.Text = km.ToString();
                Txtbxmeter.Text = m.ToString();
                Txtbxfoot.Text = ft.ToString();
                Txtbxinch.Text = inch.ToString();
                Txtbxmilli.Text = milli.ToString();
                Txtbxmicro.Text = micro.ToString();
                Txtbxnano.Text = nano.ToString();
            }
            if (ddlunit.SelectedItem.Text == "Millimeter")
            {
                ml = n / 1.609e+6;
                yd = n / 914;
                km = n / 1e+6;
                m = n / 1000;
                ft = n / 305;
                inch = n / 25.4;
                milli = n * 1;
                micro = n * 1000;
                nano = n * 1e+6;
                Txtbxmile.Text = ml.ToString();
                Txtbxyard.Text = yd.ToString();
                Txtbxkilometer.Text = km.ToString();
                Txtbxmeter.Text = m.ToString();
                Txtbxfoot.Text = ft.ToString();
                Txtbxinch.Text = inch.ToString();
                Txtbxmilli.Text = milli.ToString();
                Txtbxmicro.Text = micro.ToString();
                Txtbxnano.Text = nano.ToString();
            }
            if (ddlunit.SelectedItem.Text == "Micrometer")
            {
                ml = n / 1.609e+9;
                yd = n /914400;
                km = n / 1e+9;
                m = n / 1e+6;
                ft = n / 304800;
                inch = n /25400;
                milli = n / 1000;
                micro = n * 1;
                nano = n * 1000;
                Txtbxmile.Text = ml.ToString();
                Txtbxyard.Text = yd.ToString();
                Txtbxkilometer.Text = km.ToString();
                Txtbxmeter.Text = m.ToString();
                Txtbxfoot.Text = ft.ToString();
                Txtbxinch.Text = inch.ToString();
                Txtbxmilli.Text = milli.ToString();
                Txtbxmicro.Text = micro.ToString();
                Txtbxnano.Text = nano.ToString();
            }
            if (ddlunit.SelectedItem.Text == "Nanometer")
            {
                ml = n / 1.609e+12;
                yd = n / 9.144e+8;
                km = n / 1e+12;
                m = n / 1e+9;
                ft = n / 3.048e+8;
                inch = n / 2.54e+7;
                milli = n / 1e+6;
                micro = n / 1000;
                nano = n * 1;
                Txtbxmile.Text = ml.ToString();
                Txtbxyard.Text = yd.ToString();
                Txtbxkilometer.Text = km.ToString();
                Txtbxmeter.Text = m.ToString();
                Txtbxfoot.Text = ft.ToString();
                Txtbxinch.Text = inch.ToString();
                Txtbxmilli.Text = milli.ToString();
                Txtbxmicro.Text = micro.ToString();
                Txtbxnano.Text = nano.ToString();
            }
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Bthistory_Click(object sender, EventArgs e)
    {
        Response.Redirect("unithistory.aspx");
    }

    protected void Btback_Click(object sender, EventArgs e)
    {
        Response.Redirect("conversion.aspx");
    }
}