<%@ Page Title="" Language="C#" MasterPageFile="~/welcomecc.master" AutoEventWireup="true" CodeFile="unitconvert.aspx.cs" Inherits="unitconvert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="height: 36px; background-color: #6699FF;">
    <asp:DropDownList ID="ddlunit" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem>--Select--</asp:ListItem>
        <asp:ListItem>Mile</asp:ListItem>
        <asp:ListItem>Yard</asp:ListItem>
        <asp:ListItem>Kilometer</asp:ListItem>
        <asp:ListItem>Meter</asp:ListItem>
        <asp:ListItem>Foot</asp:ListItem>
        <asp:ListItem>Inch</asp:ListItem>
        <asp:ListItem>Millimeter</asp:ListItem>
        <asp:ListItem>Micrometer</asp:ListItem>
        <asp:ListItem>Nanometer</asp:ListItem>
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Txtbxselect" runat="server"></asp:TextBox>
    <br />
</p>
    <p style="height: 36px; background-color: #6699FF;">
        <table style="width: 100%; height: 30px;">
            <tr>
                <td style="width: 171px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlunit" ErrorMessage="Select Type"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Txtbxselect" ErrorMessage="Enter Values"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
</p>
<p>
    <table style="width: 100%; height: 227px;">
        <tr>
            <td style="background-color: #99CCFF;">
                <asp:Label ID="lblmile" runat="server" Text="Mile"></asp:Label>
            </td>
            <td style="background-color: #99CCFF;">
                <asp:TextBox ID="Txtbxmile" runat="server" OnTextChanged="Txtbxmile_TextChanged"></asp:TextBox>
            </td>
            <td rowspan="5" style="background-color: #99CCFF">
                <asp:TextBox ID="Txtname" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                <asp:Label ID="Txtbxname" runat="server" Text="Name "></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="background-color: #99CCFF;">
                <asp:Label ID="lblyard" runat="server" Text="Yard"></asp:Label>
            </td>
            <td style="background-color: #99CCFF;">
                <asp:TextBox ID="Txtbxyard" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="background-color: #99CCFF;">
                <asp:Label ID="lblkilometer" runat="server" Text="kilometer"></asp:Label>
            </td>
            <td style="background-color: #99CCFF;">
                <asp:TextBox ID="Txtbxkilometer" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="background-color: #99CCFF;">
                <asp:Label ID="lblmeter" runat="server" Text="Meter"></asp:Label>
            </td>
            <td style="background-color: #99CCFF;">
                <asp:TextBox ID="Txtbxmeter" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="background-color: #99CCFF;">
                <asp:Label ID="lblfoot" runat="server" Text="Foot"></asp:Label>
            </td>
            <td style="background-color: #99CCFF;">
                <asp:TextBox ID="Txtbxfoot" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="background-color: #99CCFF;">
                <asp:Label ID="lblinch" runat="server" Text="Inch"></asp:Label>
            </td>
            <td style="background-color: #99CCFF;">
                <asp:TextBox ID="Txtbxinch" runat="server"></asp:TextBox>
            </td>
            <td rowspan="4" style="background-color: #99CCFF">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="background-color: #99CCFF;">
                <asp:Label ID="lblmiilimeter" runat="server" Text="Millimeter"></asp:Label>
            </td>
            <td style="background-color: #99CCFF;">
                <asp:TextBox ID="Txtbxmilli" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="background-color: #99CCFF;">
                <asp:Label ID="lblmicro" runat="server" Text="Micrometer"></asp:Label>
            </td>
            <td style="background-color: #99CCFF;">
                <asp:TextBox ID="Txtbxmicro" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="background-color: #99CCFF;">
                <asp:Label ID="lblnano" runat="server" Text="Nanometer"></asp:Label>
            </td>
            <td style="background-color: #99CCFF;">
                <asp:TextBox ID="Txtbxnano" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
</p>
<p style="margin-left: 80px; background-color: #FFFFFF; font-style: italic;">
    <asp:Button ID="Btconvert" runat="server" Text="Convert" OnClick="Btconvert_Click" BackColor="#FFFFCC" BorderColor="Aqua" BorderWidth="7px" Font-Italic="True" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Bthistory" runat="server" Text="History" OnClick="Bthistory_Click" BackColor="#FFFFCC" BorderColor="Aqua" BorderWidth="7px" Font-Italic="True" />
</p>
<p style="margin-left: 160px">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Btsave" runat="server" Text="Save" OnClick="Btsave_Click" BackColor="#FFFFCC" BorderColor="Aqua" BorderWidth="7px" Font-Italic="True" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Btback" runat="server" OnClick="Btback_Click" Text="Back" BackColor="#FFFFCC" BorderColor="Aqua" BorderWidth="7px" Font-Italic="True" />
</p>
<p>
</p>
</asp:Content>

