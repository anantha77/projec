<%@ Page Title="" Language="C#" MasterPageFile="~/welcomecc.master" AutoEventWireup="true" CodeFile="conversion.aspx.cs" Inherits="conversion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="height: 95px; font-size: xx-large; color: #FF9933; font-style: italic; font-weight: bolder;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
</p>
    <p>
        <table style="width:100%;">
            <tr>
                <td style="width: 453px">&nbsp;</td>
                <td>
                    <asp:Button ID="btlogout" runat="server" OnClick="btlogout_Click" Text="Log Out" BackColor="#00CC00" BorderColor="White" />
                </td>
            </tr>
        </table>
</p>
<p>
    <asp:Button ID="Btmoney" runat="server" Text="Money Convertor" BackColor="#FF99FF" BorderColor="#66FF33" BorderWidth="10px" OnClick="Btmoney_Click" />
</p>
<p style="margin-left: 160px">
</p>
<p style="margin-left: 160px">
    <asp:Button ID="Btemi" runat="server" Text="EMI Conversion" BackColor="#FF0066" BorderColor="Blue" BorderWidth="10px" OnClick="Btemi_Click" />
</p>
<p>
</p>
<p style="margin-left: 320px">
    <asp:Button ID="Btunit" runat="server" OnClick="Button1_Click" Text="Unit Convertor" BackColor="#CC33FF" BorderColor="#00CC00" BorderWidth="10px" />
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

