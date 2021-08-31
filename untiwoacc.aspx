<%@ Page Title="" Language="C#" MasterPageFile="~/welcomecc.master" AutoEventWireup="true" CodeFile="untiwoacc.aspx.cs" Inherits="untiwoacc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <table style="width:100%;">
            <tr>
                <td colspan="3" style="height: 45px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ( :&nbsp; UNIT CONVERSIONS : )&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="ddlunit1" runat="server">
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
                </td>
                <td style="width: 265px">
                    <asp:TextBox ID="Txtbxselect1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Txtbxselect1" ErrorMessage="Enter Values"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlunit1" ErrorMessage="Select Type"></asp:RequiredFieldValidator>
                </td>
                <td style="width: 265px">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Mile"></asp:Label>
                </td>
                <td style="width: 265px">
                    <asp:TextBox ID="Txtbxmile1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Yard"></asp:Label>
                </td>
                <td style="width: 265px">
                    <asp:TextBox ID="Txtbxyard1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Kilometer"></asp:Label>
                </td>
                <td style="width: 265px">
                    <asp:TextBox ID="Txtbxkilometer1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="height: 29px">
                    <asp:Label ID="Label4" runat="server" Text="Meter"></asp:Label>
                </td>
                <td style="height: 29px; width: 265px;">
                    <asp:TextBox ID="Txtbxmeter1" runat="server"></asp:TextBox>
                </td>
                <td style="height: 29px"></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Foot"></asp:Label>
                </td>
                <td style="width: 265px">
                    <asp:TextBox ID="Txtbxfoot1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Inch"></asp:Label>
                </td>
                <td style="width: 265px">
                    <asp:TextBox ID="Txtbxinch1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Millimeter"></asp:Label>
                </td>
                <td style="width: 265px">
                    <asp:TextBox ID="Txtbxmilli1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Micrometer</td>
                <td style="width: 265px">
                    <asp:TextBox ID="Txtbxmicro1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Nanometer"></asp:Label>
                </td>
                <td style="width: 265px">
                    <asp:TextBox ID="Txtbxnano1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="width: 265px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="width: 265px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Btback" runat="server" Text="Back" OnClick="Btback_Click" PostBackUrl="~/freeconversions.aspx" />
                </td>
                <td style="width: 265px">
                    <asp:Button ID="Btconvert" runat="server" Text="Convert" OnClick="Btconvert_Click" />
                </td>
                <td>&nbsp;</td>
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
</asp:Content>

