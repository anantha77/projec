<%@ Page Title="" Language="C#" MasterPageFile="~/welcomecc.master" AutoEventWireup="true" CodeFile="emiconvert.aspx.cs" Inherits="emiconvert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        <table style="width: 100%; height: 238px;">
            <tr>
                <td colspan="4" style="background-color: #FFFFFF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ( &#39; - &#39; )&nbsp; EMI CALCULATOR&nbsp; ( &#39; - &#39; )</td>
            </tr>
            <tr>
                <td style="background-color: #FFFFFF;">
                    <asp:Label ID="Label1" runat="server" Text="Principle"></asp:Label>
                </td>
                <td colspan="2" style="background-color: #FFFFFF;">
                    <asp:TextBox ID="Txtbxprinciple" runat="server" OnTextChanged="Txtbxprinciple_TextChanged"></asp:TextBox>
                </td>
                <td style="background-color: #FFFFFF">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Txtbxprinciple" ErrorMessage="Enter some values"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="background-color: #FFFFFF; height: 26px;">
                    <asp:Label ID="Label2" runat="server" Text="Interest(%)"></asp:Label>
                </td>
                <td colspan="2" style="background-color: #FFFFFF; height: 26px;">
                    <asp:TextBox ID="Txtbxinterest" runat="server" OnTextChanged="Txtbxinterest_TextChanged"></asp:TextBox>
                </td>
                <td style="background-color: #FFFFFF; height: 26px;">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Txtbxinterest" ErrorMessage="Enter Interest"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="background-color: #FFFFFF;">
                    <asp:Label ID="Label3" runat="server" Text="Months"></asp:Label>
                </td>
                <td colspan="2" style="background-color: #FFFFFF;">
                    <asp:TextBox ID="Txtbxmonths" runat="server" OnTextChanged="Txtbxmonths_TextChanged"></asp:TextBox>
                </td>
                <td style="background-color: #FFFFFF">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Txtbxmonths" ErrorMessage="Enter some values"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="background-color: #FFFFFF;">&nbsp;</td>
                <td style="width: 126px; background-color: #FFFFFF;">
                    <asp:Button ID="btncalculate" runat="server" OnClick="btncalculate_Click" Text="Calculate" BackColor="#FFCC66" BorderColor="Lime" BorderWidth="5px" Font-Italic="True" ForeColor="#3366FF" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td style="background-color: #FFFFFF;">&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label7" runat="server" Text="File Name"></asp:Label>
                    &nbsp;</td>
                <td style="background-color: #FFFFFF">
                    <asp:TextBox ID="Txtbxfilename" runat="server" OnTextChanged="Txtbxfilename_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="background-color: #FFFFFF;">
                    <asp:Label ID="Label4" runat="server" Text="TotalCost"></asp:Label>
                </td>
                <td colspan="2" style="background-color: #FFFFFF;">
                    <asp:TextBox ID="Txtbxtotalcost" runat="server" OnTextChanged="Txtbxtotalcost_TextChanged"></asp:TextBox>
                </td>
                <td style="background-color: #FFFFFF;" rowspan="2"></td>
            </tr>
            <tr>
                <td style="background-color: #FFFFFF;">
                    <asp:Label ID="Label5" runat="server" Text="EMI"></asp:Label>
                </td>
                <td colspan="2" style="background-color: #FFFFFF;">
                    <asp:TextBox ID="Txtbxemi" runat="server" OnTextChanged="Txtbxemi_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="background-color: #FFFFFF;">
                    <asp:Label ID="Label6" runat="server" Text="Monthly Install"></asp:Label>
                </td>
                <td colspan="2" style="background-color: #FFFFFF;">
                    <asp:TextBox ID="Txtbxmonthlyinstall" runat="server" OnTextChanged="Txtbxmonthlyinstall_TextChanged"></asp:TextBox>
                </td>
                <td style="background-color: #FFFFFF;">&nbsp;</td>
            </tr>
            <tr>
                <td style="background-color: #FFFFFF;">&nbsp;</td>
                <td colspan="2" style="background-color: #FFFFFF;">&nbsp;</td>
                <td style="background-color: #FFFFFF;">&nbsp;</td>
            </tr>
            <tr>
                <td style="background-color: #FFFFFF;">&nbsp;
                    <asp:Button ID="btnbackemi" runat="server" OnClick="btnbackemi_Click" Text="Back" BackColor="#006666" BorderColor="Aqua" BorderWidth="5px" Font-Italic="True" ForeColor="White" />
                    &nbsp;</td>
                <td style="width: 126px; background-color: #FFFFFF;">&nbsp;&nbsp;
                    <asp:Button ID="btnsaveemi" runat="server" OnClick="btnsaveemi_Click" Text="Save" BackColor="#006666" BorderColor="Aqua" BorderWidth="5px" Font-Bold="True" Font-Italic="True" ForeColor="White" />
                    &nbsp;</td>
                <td style="background-color: #FFFFFF;">&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="bthistoryemi" runat="server" OnClick="bthistoryemi_Click" Text="History" BackColor="#006666" BorderColor="Aqua" BorderWidth="5px" Font-Bold="True" Font-Italic="True" ForeColor="White" />
                    &nbsp;</td>
                <td style="background-color: #FFFFFF;">&nbsp;</td>
            </tr>
            <tr>
                <td style="height: 35px; width: 116px">&nbsp;</td>
                <td colspan="2" style="height: 35px; width: 141px">&nbsp;</td>
                <td style="height: 35px">&nbsp;</td>
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
        &nbsp;</p>
</asp:Content>

