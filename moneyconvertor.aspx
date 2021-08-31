<%@ Page Title="" Language="C#" MasterPageFile="~/welcomecc.master" AutoEventWireup="true" CodeFile="moneyconvertor.aspx.cs" Inherits="moneyconvertor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <p>
        <table style="width: 100%; height: 134px;">
            <tr>
                <td colspan="5" style="background-color: #66FFFF; font-style: italic; font-weight: bolder;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ( :&nbsp; &nbsp;MONEY CONVERSIONS : )</td>
            </tr>
            <tr>
                <td style="background-color: #66FFFF">
                    <asp:DropDownList ID="FromDDbox" runat="server" AutoPostBack="True" OnSelectedIndexChanged="FromDDbox_SelectedIndexChanged">
                        <asp:ListItem>--Select--</asp:ListItem>
                        <asp:ListItem>Indian Rupee</asp:ListItem>
                        <asp:ListItem>United States Doller</asp:ListItem>
                        <asp:ListItem>Pakistani Rupee</asp:ListItem>
                        <asp:ListItem>Bangladesh Taka</asp:ListItem>
                        <asp:ListItem>Central African</asp:ListItem>
                        <asp:ListItem>Chinese Yuan</asp:ListItem>
                        <asp:ListItem>Cuban Peso</asp:ListItem>
                        <asp:ListItem>East Caribbean Doller</asp:ListItem>
                        <asp:ListItem>Euro</asp:ListItem>
                        <asp:ListItem>Malaysian Ringgit</asp:ListItem>
                        <asp:ListItem>Maldivian Rufiyaa</asp:ListItem>
                        <asp:ListItem>Australian Doller</asp:ListItem>
                        <asp:ListItem>Nepalese Rupee</asp:ListItem>
                        <asp:ListItem>Sri Lankan</asp:ListItem>
                        <asp:ListItem>Russian Ruble</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td colspan="3" style="background-color: #66FFFF">
                    <asp:TextBox ID="FromtextBox" runat="server" OnTextChanged="Fromtextbox_TextChanged"></asp:TextBox>
                </td>
                <td style="background-color: #66FFFF">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FromtextBox" ErrorMessage="Enter Some Values"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="background-color: #66FFFF">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="FromDDbox" ErrorMessage="Select Country 1"></asp:RequiredFieldValidator>
                </td>
                <td colspan="2" style="background-color: #66FFFF">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td style="background-color: #66FFFF; width: 141px;">
                    <asp:Label ID="Label1" runat="server" Text="File Name :"></asp:Label>
                </td>
                <td style="background-color: #66FFFF">
                    <asp:TextBox ID="Txtboxfilename" runat="server" OnTextChanged="Txtboxfilename_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="background-color: #66FFFF">
                    <asp:DropDownList ID="ToDDbox" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ToDDbox_SelectedIndexChanged">
                        <asp:ListItem>--Select--</asp:ListItem>
                        <asp:ListItem>Pakistani Rupee</asp:ListItem>
                        <asp:ListItem>United States Doller</asp:ListItem>
                        <asp:ListItem>Bangladesh Taka</asp:ListItem>
                        <asp:ListItem>Central African</asp:ListItem>
                        <asp:ListItem>Chinese Yuan</asp:ListItem>
                        <asp:ListItem>Cuban Peso</asp:ListItem>
                        <asp:ListItem>East Caribbean Doller</asp:ListItem>
                        <asp:ListItem>Euro</asp:ListItem>
                        <asp:ListItem>Malaysian Ringgit</asp:ListItem>
                        <asp:ListItem>Maldivian Rufiyaa</asp:ListItem>
                        <asp:ListItem>Australian Doller</asp:ListItem>
                        <asp:ListItem>Nepalese Rupee</asp:ListItem>
                        <asp:ListItem>Sri Lankan</asp:ListItem>
                        <asp:ListItem>Russian Ruble</asp:ListItem>
                        <asp:ListItem>Indian Rupee</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td colspan="3" style="background-color: #66FFFF">
                    <asp:TextBox ID="toTextBox" runat="server" OnTextChanged="toTextBox_TextChanged"></asp:TextBox>
                </td>
                <td style="background-color: #66FFFF">&nbsp;</td>
            </tr>
            <tr>
                <td style="background-color: #66FFFF; height: 39px;">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ToDDbox" ErrorMessage="Select Country 2"></asp:RequiredFieldValidator>
                </td>
                <td colspan="3" style="background-color: #66FFFF; height: 39px;"></td>
                <td style="background-color: #66FFFF; height: 39px;"></td>
            </tr>
            <tr>
                <td style="padding: 1px; font-size: medium; background-color: #00FFFF; color: #FFFFFF; font-weight: bold; background-attachment: fixed; width: 141px;">
                    <asp:Button ID="Btback" runat="server" OnClick="Btback_Click" Text="Back" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td style="padding: 1px; font-size: medium; background-color: #00FFFF; color: #FFFFFF; font-weight: bold; background-attachment: fixed; width: 152px;">
                    <asp:Button ID="Btexchange" runat="server" OnClick="Btexchange_Click" Text="Exchange" />
                </td>
                <td colspan="2" style="padding: 1px; font-size: medium; background-color: #00FFFF; color: #FFFFFF; font-weight: bold; background-attachment: fixed;">&nbsp;<asp:Button ID="Btsavem" runat="server" OnClick="Btsavem_Click" Text="Save" />
                </td>
                <td style="background-color: #66FFFF">
                    <asp:Button ID="Bthistorym" runat="server" OnClick="Bthistorym_Click" style="margin-left: 29px" Text="Hsitory" Width="47px" />
                </td>
            </tr>
        </table>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <br />
    </p>
</asp:Content>

