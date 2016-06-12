<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlProductsSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [productId], [product], [categoryId] FROM [products]"></asp:SqlDataSource>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="productId" DataSourceID="SqlProductsSource" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="productId" HeaderText="productId" ReadOnly="True" SortExpression="productId" />
                <asp:BoundField DataField="product" HeaderText="product" SortExpression="product" />
                <asp:BoundField DataField="categoryId" HeaderText="categoryId" SortExpression="categoryId" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
    </div>
    </form>
</body>
</html>
