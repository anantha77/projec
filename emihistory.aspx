<%@ Page Language="C#" AutoEventWireup="true" CodeFile="emihistory.aspx.cs" Inherits="emihistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Files_name" HeaderText="Files_name" SortExpression="Files_name" />
                <asp:BoundField DataField="Principle" HeaderText="Principle" SortExpression="Principle" />
                <asp:BoundField DataField="Interest" HeaderText="Interest" SortExpression="Interest" />
                <asp:BoundField DataField="Months" HeaderText="Months" SortExpression="Months" />
                <asp:BoundField DataField="Total_cost" HeaderText="Total_cost" SortExpression="Total_cost" />
                <asp:BoundField DataField="EMI" HeaderText="EMI" SortExpression="EMI" />
                <asp:BoundField DataField="Monthly_Install" HeaderText="Monthly_Install" SortExpression="Monthly_Install" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AnanthB2ConnectionString %>" SelectCommand="SELECT * FROM [emiconvert]"></asp:SqlDataSource>
    
        <asp:Button ID="Btbackemi" runat="server" OnClick="Btbackemi_Click" Text="Back" />
    
    </div>
    </form>
</body>
</html>
