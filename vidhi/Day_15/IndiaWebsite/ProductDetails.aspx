<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductDetails.aspx.cs" Inherits="ProductDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td> <asp:LinkButton ID="LnkBtnFavourite" runat="server" OnClick="LnkBtnFavourite_Click">Add to my Favourite List</asp:LinkButton>
 </td>
            </tr>
            <tr>
                <td>
                    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="productId" DataSourceID="SqlDataSource1" Height="50px" Width="125px">
                        <Fields>
                            <asp:BoundField DataField="productId" HeaderText="productId" ReadOnly="True" SortExpression="productId" />
                            <asp:BoundField DataField="categoryId" HeaderText="categoryId" SortExpression="categoryId" />
                            <asp:BoundField DataField="product" HeaderText="product" SortExpression="product" />
                            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                            <asp:BoundField DataField="unitsinstock" HeaderText="unitsinstock" SortExpression="unitsinstock" />
                            <asp:BoundField DataField="producturl" HeaderText="producturl" SortExpression="producturl" />
                            <asp:BoundField DataField="lauchdate" HeaderText="lauchdate" SortExpression="lauchdate" />
                        </Fields>
                    </asp:DetailsView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [products] WHERE ([productId] = @productId)">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="productId" QueryStringField="ProductID" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
