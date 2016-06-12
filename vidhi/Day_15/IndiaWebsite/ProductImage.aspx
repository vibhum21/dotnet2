<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductImage.aspx.cs" 
    Inherits="ProductImage" %>
<%@ OutputCache Duration="60" VaryByParam="2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                       </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:DataList ID="DataList1" runat="server"
                         DataKeyField="productId"
                         DataSourceID="sqldsProducts">
                        <ItemTemplate>
                            productId:
                            <asp:Label ID="productIdLabel" runat="server" Text='<%# Eval("productId") %>' />
                            <br />
                            categoryId:
                            <asp:Label ID="categoryIdLabel" runat="server" Text='<%# Eval("categoryId") %>' />
                            <br />
                            product:
                            <asp:Label ID="productLabel" runat="server" Text='<%# Eval("product") %>' />
                            <br />
                            price:
                            <asp:Label ID="priceLabel" runat="server" Text='<%# Eval("price") %>' />
                            <br />
                            unitsinstock:
                            <asp:Label ID="unitsinstockLabel" runat="server" Text='<%# Eval("unitsinstock") %>' />
                            <br />
                            producturl:
                            <asp:Label ID="producturlLabel" runat="server" Text='<%# Eval("producturl") %>' />
                            <br />
                             <img  id="im34" width="100" height="150" src='images/<%# Eval("producturl") %>' />
                             lauchdate:
                            <asp:Label ID="lauchdateLabel" runat="server" Text='<%# Eval("lauchdate") %>' />
                            <br />
<br />
                        </ItemTemplate>
                    </asp:DataList>
                    <asp:SqlDataSource ID="sqldsProducts" 
                        runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                        SelectCommand="SELECT * FROM [products]">

                    </asp:SqlDataSource>
                </td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
