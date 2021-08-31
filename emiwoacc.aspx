<%@ Page Title="" Language="C#" MasterPageFile="~/welcomecc.master" AutoEventWireup="true" CodeFile="emiwoacc.aspx.cs" Inherits="emiwoacc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
        <table style="width: 100%; height: 49px; font-style: italic;">
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ( &#39; - &#39; )&nbsp; EMI CALCULATOR&nbsp; ( &#39; - &#39; )</td>
            </tr>
        </table>
    </p>
        <table style="width: 100%; height: 238px;">
            <tr>
                <td style="width: 116px">
                    <asp:Label ID="Label1" runat="server" Text="Principle"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="Txtbxprinciple" runat="server" OnTextChanged="Txtbxprinciple_TextChanged"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Txtbxprinciple" ErrorMessage="Enter Some values"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 116px">
                    <asp:Label ID="Label2" runat="server" Text="Interest(%)"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="Txtbxinterest" runat="server" OnTextChanged="Txtbxinterest_TextChanged"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Txtbxinterest" ErrorMessage="Enter Interest percent"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 116px">
                    <asp:Label ID="Label3" runat="server" Text="Months"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="Txtbxmonths" runat="server" OnTextChanged="Txtbxmonths_TextChanged"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Txtbxmonths" ErrorMessage="Enter some Values"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 116px; height: 27px;"></td>
                <td style="width: 141px; height: 27px;">
                    <asp:Button ID="btncalculate" runat="server" OnClick="btncalculate_Click" Text="Calculate" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td style="height: 35px; width: 128px">&nbsp;
                    <asp:Button ID="btnbackemi" runat="server" OnClick="btnbackemi_Click" Text="Back" PostBackUrl="~/freeconversions.aspx" />
                    &nbsp;</td>
                <td style="height: 27px">
                </td>
            </tr>
            <tr>
                <td style="height: 31px; width: 116px">
                    <asp:Label ID="Label4" runat="server" Text="TotalCost"></asp:Label>
                </td>
                <td colspan="2" style="height: 31px; ">
                    <asp:TextBox ID="Txtbxtotalcost" runat="server" OnTextChanged="Txtbxtotalcost_TextChanged" EnableViewState="False"></asp:TextBox>
                </td>
                <td style="height: 31px"></td>
            </tr>
            <tr>
                <td style="height: 35px; width: 116px">
                    <asp:Label ID="Label5" runat="server" Text="EMI"></asp:Label>
                </td>
                <td colspan="2" style="height: 35px; ">
                    <asp:TextBox ID="Txtbxemi" runat="server" OnTextChanged="Txtbxemi_TextChanged"></asp:TextBox>
                </td>
                <td style="height: 35px"></td>
            </tr>
            <tr>
                <td style="height: 35px; width: 116px">
                    <asp:Label ID="Label6" runat="server" Text="Monthly Install"></asp:Label>
                </td>
                <td colspan="2" style="height: 35px; ">
                    <asp:TextBox ID="Txtbxmonthlyinstall" runat="server" OnTextChanged="Txtbxmonthlyinstall_TextChanged"></asp:TextBox>
                </td>
                <td style="height: 35px">&nbsp;</td>
            </tr>
            <tr>
                <td style="height: 35px; width: 116px">
                    &nbsp;</td>
                <td style="height: 35px; width: 141px">
                    &nbsp;</td>
                <td style="height: 35px; width: 128px">
                    &nbsp;</td>
                <td style="height: 35px">&nbsp;</td>
            </tr>
        </table>
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

