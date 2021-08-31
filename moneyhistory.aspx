<%@ Page Language="C#" AutoEventWireup="true" CodeFile="moneyhistory.aspx.cs" Inherits="moneyhistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 190px;
        }
        .auto-style2 {
            width: 778px;
        }
        .auto-style3 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1" rowspan="3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" PostBackUrl="~/conversion.aspx" Text="Back" />
                </td>
                <td class="auto-style2" rowspan="3">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" CssClass="auto-style3" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" Width="824px">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:BoundField DataField="File_name" HeaderText="File_name" SortExpression="File_name" />
                            <asp:BoundField DataField="Moneyconvert_From" HeaderText="Moneyconvert_From" SortExpression="Moneyconvert_From" />
                            <asp:BoundField DataField="Moneyconvert_To" HeaderText="Moneyconvert_To" SortExpression="Moneyconvert_To" />
                            <asp:BoundField DataField="Entered_amount" HeaderText="Entered_amount" SortExpression="Entered_amount" />
                            <asp:BoundField DataField="converted_amount" HeaderText="converted_amount" SortExpression="converted_amount" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AnanthB2ConnectionString %>" SelectCommand="SELECT * FROM [moneyconvert]"></asp:SqlDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
