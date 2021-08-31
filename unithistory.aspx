<%@ Page Language="C#" AutoEventWireup="true" CodeFile="unithistory.aspx.cs" Inherits="unithistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 256px;
        }
        .auto-style2 {
            width: 749px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AnanthB2ConnectionString %>" SelectCommand="SELECT * FROM [unit_convertor]"></asp:SqlDataSource>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                        <asp:BoundField DataField="Selected_conversion" HeaderText="Selected_conversion" SortExpression="Selected_conversion" />
                        <asp:BoundField DataField="Selected_value" HeaderText="Selected_value" SortExpression="Selected_value" />
                        <asp:BoundField DataField="Miles" HeaderText="Miles" SortExpression="Miles" />
                        <asp:BoundField DataField="Yard" HeaderText="Yard" SortExpression="Yard" />
                        <asp:BoundField DataField="Kilometer" HeaderText="Kilometer" SortExpression="Kilometer" />
                        <asp:BoundField DataField="Meter" HeaderText="Meter" SortExpression="Meter" />
                        <asp:BoundField DataField="Foot" HeaderText="Foot" SortExpression="Foot" />
                        <asp:BoundField DataField="Inch" HeaderText="Inch" SortExpression="Inch" />
                        <asp:BoundField DataField="Millimeter" HeaderText="Millimeter" SortExpression="Millimeter" />
                        <asp:BoundField DataField="Micrometer" HeaderText="Micrometer" SortExpression="Micrometer" />
                        <asp:BoundField DataField="Nanometer" HeaderText="Nanometer" SortExpression="Nanometer" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" PostBackUrl="~/conversion.aspx" Text="Back" />
    </form>
</body>
</html>
