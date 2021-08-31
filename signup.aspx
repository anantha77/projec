<%@ Page Title="" Language="C#" MasterPageFile="~/log.master" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="signup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
    <p>
        <table style="width: 100%; height: 373px;">
            <tr>
                <td style="font-style: italic; background-color: #FFFFFF;">
                    <asp:Label ID="lblname" runat="server" Text="NAME"></asp:Label>
                </td>
                <td style="background-color: #CC99FF;">
                    <asp:TextBox ID="Txtbxuser" runat="server"></asp:TextBox>
                </td>
                <td style="background-color: #CC99FF; font-style: italic; color: #FFFFFF">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Txtbxuser" ErrorMessage="Please enter your Name" Font-Bold="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="font-style: italic; background-color: #FFFFFF;">
                    <asp:Label ID="lblpass" runat="server" Text="PASSWORD"></asp:Label>
                </td>
                <td style="background-color: #CC99FF;">
                    <asp:TextBox ID="TxtBxpd" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td style="background-color: #CC99FF; font-style: italic; color: #FFFFFF">&nbsp;</td>
            </tr>
            <tr>
                <td style="font-style: italic; background-color: #FFFFFF;">
                    <asp:Label ID="Label3" runat="server" Text="CONFIRM PASSWORD"></asp:Label>
                </td>
                <td style="background-color: #CC99FF;">
                    <asp:TextBox ID="Txtbxrepd" runat="server"></asp:TextBox>
                </td>
                <td style="background-color: #CC99FF; font-style: italic; color: #FFFFFF">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TxtBxpd" ControlToValidate="Txtbxrepd" ErrorMessage="Re-Type Password " Font-Bold="True"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td style="font-style: italic; background-color: #FFFFFF;">
                    <asp:Label ID="lblemail" runat="server" Text="EMAIL-ID"></asp:Label>
                </td>
                <td style="background-color: #CC99FF;">
                    <asp:TextBox ID="Txtbxemail" runat="server"></asp:TextBox>
                </td>
                <td style="background-color: #CC99FF; font-style: italic; color: #FFFFFF">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Txtbxemail" ErrorMessage="Invalid Email Expressions" Font-Bold="True" Font-Italic="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="font-style: italic; background-color: #FFFFFF;">
                    <asp:Label ID="lblgender" runat="server" Text="GENDER"></asp:Label>
                </td>
                <td style="background-color: #CC99FF;">
                    <asp:RadioButtonList ID="rblgender" runat="server">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td style="background-color: #CC99FF; font-style: italic; color: #FFFFFF">&nbsp;</td>
            </tr>
            <tr>
                <td style="font-style: italic; background-color: #FFFFFF;">
                    <asp:Label ID="lblcountry" runat="server" Text="COUNTRY"></asp:Label>
                </td>
                <td style="background-color: #CC99FF;">
                    <asp:DropDownList ID="ddlcountry" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>--Select--</asp:ListItem>
                        <asp:ListItem>India</asp:ListItem>
                        <asp:ListItem>America</asp:ListItem>
                        <asp:ListItem>England</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="background-color: #CC99FF; font-style: italic; color: #FFFFFF;">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlcountry" ErrorMessage="Select your Country" Font-Bold="True" ForeColor="White"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="font-style: italic; background-color: #FFFFFF;">
                    <asp:Label ID="lblstate" runat="server" Text="STATE"></asp:Label>
                </td>
                <td style="background-color: #CC99FF;">
                    <asp:DropDownList ID="ddlstate" runat="server" AutoPostBack="True">
                        <asp:ListItem>--select state--</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="background-color: #CC99FF; font-style: italic; color: #FFFFFF;">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlstate" ErrorMessage="Select your State" Font-Bold="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="font-style: italic; background-color: #FFFFFF;">&nbsp;</td>
                <td style="height: 33px; width: 255px; background-color: #CC99FF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Btcreateaccount" runat="server" OnClick="Btcreateaccount_Click" Text="Create account" BackColor="#FF6666" BorderColor="#66FFCC" BorderWidth="7px" Font-Italic="True" ForeColor="White" />
                </td>
                <td style="background-color: #CC99FF; font-style: italic; color: #FFFFFF;">&nbsp;</td>
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
</asp:Content>

