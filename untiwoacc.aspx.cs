using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class untiwoacc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Btconvert_Click(object sender, EventArgs e)
    {
        if (Txtbxselect1.Text == " ")
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "s", "<script> alert('Please enter some values')");
        }
        else
        {
            double n = Convert.ToDouble(Txtbxselect1.Text);
            double ml, yd, km, m, ft, inch, milli, micro, nano;
            if (ddlunit1.SelectedItem.Text == "Mile")
            {
                ml = n * 1;
                yd = n * 1760;
                km = n * 1.609;
                m = n * 1609;
                ft = n * 5280;
                inch = n * 63360;
                milli = n * 1.609e+6;
                micro = n * 1.609e+9;
                nano = n * 1.609e+12;
                Txtbxmile1.Text = ml.ToString();
                Txtbxyard1.Text = yd.ToString();
                Txtbxkilometer1.Text = km.ToString();
                Txtbxmeter1.Text = m.ToString();
                Txtbxfoot1.Text = ft.ToString();
                Txtbxinch1.Text = inch.ToString();
                Txtbxmilli1.Text = milli.ToString();
                Txtbxmicro1.Text = micro.ToString();
                Txtbxnano1.Text = nano.ToString();
            }
            if (ddlunit1.SelectedItem.Text == "Yard")
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
                Txtbxmile1.Text = ml.ToString();
                Txtbxyard1.Text = yd.ToString();
                Txtbxkilometer1.Text = km.ToString();
                Txtbxmeter1.Text = m.ToString();
                Txtbxfoot1.Text = ft.ToString();
                Txtbxinch1.Text = inch.ToString();
                Txtbxmilli1.Text = milli.ToString();
                Txtbxmicro1.Text = micro.ToString();
                Txtbxnano1.Text = nano.ToString();
            }
            if (ddlunit1.SelectedItem.Text == "Kilometer")
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
                Txtbxmile1.Text = ml.ToString();
                Txtbxyard1.Text = yd.ToString();
                Txtbxkilometer1.Text = km.ToString();
                Txtbxmeter1.Text = m.ToString();
                Txtbxfoot1.Text = ft.ToString();
                Txtbxinch1.Text = inch.ToString();
                Txtbxmilli1.Text = milli.ToString();
                Txtbxmicro1.Text = micro.ToString();
                Txtbxnano1.Text = nano.ToString();
            }
            if (ddlunit1.SelectedItem.Text == "Meter")
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
                Txtbxmile1.Text = ml.ToString();
                Txtbxyard1.Text = yd.ToString();
                Txtbxkilometer1.Text = km.ToString();
                Txtbxmeter1.Text = m.ToString();
                Txtbxfoot1.Text = ft.ToString();
                Txtbxinch1.Text = inch.ToString();
                Txtbxmilli1.Text = milli.ToString();
                Txtbxmicro1.Text = micro.ToString();
                Txtbxnano1.Text = nano.ToString();
            }
            if (ddlunit1.SelectedItem.Text == "Foot")
            {
                ml = n / 5280;
                yd = n / 3;
                km = n / 3281;
                m = n * 3.281;
                ft = n * 1;
                inch = n * 12;
                milli = n * 305;
                micro = n * 304800;
                nano = n * 3.048e+8;
                Txtbxmile1.Text = ml.ToString();
                Txtbxyard1.Text = yd.ToString();
                Txtbxkilometer1.Text = km.ToString();
                Txtbxmeter1.Text = m.ToString();
                Txtbxfoot1.Text = ft.ToString();
                Txtbxinch1.Text = inch.ToString();
                Txtbxmilli1.Text = milli.ToString();
                Txtbxmicro1.Text = micro.ToString();
                Txtbxnano1.Text = nano.ToString();
            }
            if (ddlunit1.SelectedItem.Text == "Inch")
            {
                ml = n / 63360;
                yd = n / 36;
                km = n / 39370;
                m = n / 39.37;
                ft = n / 12;
                inch = n * 1;
                milli = n * 25.4;
                micro = n * 25400;
                nano = n * 2.54e+7;
                Txtbxmile1.Text = ml.ToString();
                Txtbxyard1.Text = yd.ToString();
                Txtbxkilometer1.Text = km.ToString();
                Txtbxmeter1.Text = m.ToString();
                Txtbxfoot1.Text = ft.ToString();
                Txtbxinch1.Text = inch.ToString();
                Txtbxmilli1.Text = milli.ToString();
                Txtbxmicro1.Text = micro.ToString();
                Txtbxnano1.Text = nano.ToString();
            }
            if (ddlunit1.SelectedItem.Text == "Millimeter")
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
                Txtbxmile1.Text = ml.ToString();
                Txtbxyard1.Text = yd.ToString();
                Txtbxkilometer1.Text = km.ToString();
                Txtbxmeter1.Text = m.ToString();
                Txtbxfoot1.Text = ft.ToString();
                Txtbxinch1.Text = inch.ToString();
                Txtbxmilli1.Text = milli.ToString();
                Txtbxmicro1.Text = micro.ToString();
                Txtbxnano1.Text = nano.ToString();
            }
            if (ddlunit1.SelectedItem.Text == "Micrometer")
            {
                ml = n / 1.609e+9;
                yd = n / 914400;
                km = n / 1e+9;
                m = n / 1e+6;
                ft = n / 304800;
                inch = n / 25400;
                milli = n / 1000;
                micro = n * 1;
                nano = n * 1000;
                Txtbxmile1.Text = ml.ToString();
                Txtbxyard1.Text = yd.ToString();
                Txtbxkilometer1.Text = km.ToString();
                Txtbxmeter1.Text = m.ToString();
                Txtbxfoot1.Text = ft.ToString();
                Txtbxinch1.Text = inch.ToString();
                Txtbxmilli1.Text = milli.ToString();
                Txtbxmicro1.Text = micro.ToString();
                Txtbxnano1.Text = nano.ToString();
            }
            if (ddlunit1.SelectedItem.Text == "Nanometer")
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
                Txtbxmile1.Text = ml.ToString();
                Txtbxyard1.Text = yd.ToString();
                Txtbxkilometer1.Text = km.ToString();
                Txtbxmeter1.Text = m.ToString();
                Txtbxfoot1.Text = ft.ToString();
                Txtbxinch1.Text = inch.ToString();
                Txtbxmilli1.Text = milli.ToString();
                Txtbxmicro1.Text = micro.ToString();
                Txtbxnano1.Text = nano.ToString();
            }
        }
    }

    protected void Btback_Click(object sender, EventArgs e)
    {
        Response.Redirect("freeconversions.aspx");
    }
}
