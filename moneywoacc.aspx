<%@ Page Title="" Language="C#" MasterPageFile="~/welcomecc.master" AutoEventWireup="true" CodeFile="moneywoacc.aspx.cs" Inherits="moneywoacc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <table style="width: 100%; height: 296px;">
            <tr>
                 <td colspan="3" style="background-color: #66FFFF; font-style: italic; font-weight: bolder; height: 49px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ( :&nbsp; &nbsp;MONEY CONVERSIONS : )</td>
            </tr>
            <tr>
                <td style="background-color: #00FFFF; width: 103px;">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="FromDDbox" ErrorMessage="Select Country 1"></asp:RequiredFieldValidator>
                </td>
                <td style="background-color: #00FFFF" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td style="background-color: #00FFFF; width: 103px;">
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
                <td style="background-color: #00FFFF; width: 173px;">
                    <asp:TextBox ID="FromtextBox" runat="server" OnTextChanged="Fromtextbox_TextChanged"></asp:TextBox>
                </td>
                <td style="background-color: #00FFFF">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FromtextBox" ErrorMessage="Enter Some Values "></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="background-color: #00FFFF; width: 103px;">
                    <asp:DropDownList ID="ToDDbox" runat="server" AutoPostBack="True" OnSelectedIndexChanged="FromDDbox_SelectedIndexChanged">
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
                
                <td style="background-color: #00FFFF">
                    <asp:TextBox ID="toTextBox" runat="server" OnTextChanged="Fromtextbox_TextChanged"></asp:TextBox>
                </td>
                
                <td style="background-color: #00FFFF">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="background-color: #00FFFF; width: 103px;">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ToDDbox" ErrorMessage="Select Country 2"></asp:RequiredFieldValidator>
                </td>
                <td style="background-color: #00FFFF; width: 184px;" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td style="background-color: #00FFFF; width: 103px;">
                    <asp:Button ID="Btbackfree" runat="server" OnClick="Btbackfree_Click" Text="Back" PostBackUrl="~/freeconversions.aspx" />
                </td>
                <td style="background-color: #00FFFF; width: 184px;" colspan="2">
                    <asp:Button ID="Btexchange" runat="server" Text="Exchange" OnClick="Btexchange_Click" />
                </td>
            </tr>
        </table>
        <br />
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
    <p>
    </p>
</asp:Content>

