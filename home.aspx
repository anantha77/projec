<%@ Page Title="" Language="C#" MasterPageFile="~/log.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="log" %>

<%-- Add content controls here --%>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <p>
        <br />
        <table style="width: 100%; height: 155px; ">
            <tr>
                <td style="width: 213px">
                    <asp:Label ID="lbluser" runat="server" Text="USERNAME" BackColor="#FF66FF" BorderColor="#FF66FF" BorderWidth="5px" Font-Bold="False"></asp:Label>
                </td>
                <td colspan="3">
                    <asp:TextBox ID="txtbxuser" runat="server" BackColor="White" EnableViewState="False"></asp:TextBox>
                </td>
                <td style="width: 268435264px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 213px">
                    <asp:Label ID="lblpd" runat="server" Text="PASSWORD" BackColor="#FF66FF" BorderColor="#FF66FF" BorderWidth="5px"></asp:Label>
                </td>
                <td colspan="3">
                    <asp:TextBox ID="Txtbxpd" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td style="width: 268435264px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 213px">&nbsp;</td>
                <td style="width: 112px">
                    <asp:Button ID="Btlogin" runat="server" BackColor="#003366" Font-Bold="True" Font-Italic="True" Font-Overline="False" Font-Strikeout="False" ForeColor="#FF66FF" OnClick="Btlogin_Click" Text="LOGIN" />
                </td>
                <td style="width: 160px">
                    <asp:Button ID="Btnewuser" runat="server" BackColor="#003366" Font-Bold="True" Font-Italic="True" ForeColor="#FF6699" OnClick="Btnewuser_Click" Text="NEW USER" />
                </td>
                <td style="width: 143px">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Btfree" runat="server" OnClick="Btfree_Click" Text="Free Trials" BackColor="#3366CC" Font-Bold="True" Font-Italic="True" ForeColor="#FF66CC" />
&nbsp;&nbsp;</td>
                <td>
                    &nbsp;</td>
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
    <p>
    </p>
    <p>
    </p>
</asp:Content>

