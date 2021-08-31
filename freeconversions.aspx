<%@ Page Title="" Language="C#" MasterPageFile="~/welcomecc.master" AutoEventWireup="true" CodeFile="freeconversions.aspx.cs" Inherits="freeconversions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="font-size: x-large; color: #FF0000; font-style: italic">
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; START YOUR CONVERSIONS...!!!</p>
    <p>
        &nbsp;</p>
    <p>
        <table style="width: 100%; height: 113px;">
            <tr>
                <td style="width: 171px">
    <asp:Button ID="Btmoney" runat="server" Text="Money Convertor" BackColor="#FF99FF" BorderColor="#66FF33" BorderWidth="10px" OnClick="Btmoney_Click" />
                </td>
                <td style="width: 156px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 171px">&nbsp;</td>
                <td style="width: 156px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 171px">&nbsp;</td>
                <td style="width: 156px">
    <asp:Button ID="Btemi" runat="server" Text="EMI Conversion" BackColor="#FF0066" BorderColor="Blue" BorderWidth="10px" OnClick="Btemi_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 171px">&nbsp;</td>
                <td style="width: 156px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 171px">&nbsp;</td>
                <td style="width: 156px">&nbsp;</td>
                <td>
    <asp:Button ID="Btunit" runat="server" OnClick="Button1_Click" Text="Unit Convertor" BackColor="#CC33FF" BorderColor="#00CC00" BorderWidth="10px" />
                </td>
            </tr>
        </table>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

