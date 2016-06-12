<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="productCatalog.aspx.cs" Inherits="productCatalog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:SqlDataSource ID="SqlDSCategories" runat="server"
     ConnectionString="<%$ ConnectionStrings:ECommdbConStr %>" 
    SelectCommand="SELECT * FROM [Categories]">

</asp:SqlDataSource>
    <table class="auto-style1">
        <tr>
            <td>
    <asp:DropDownList ID="DropDownList1" 
        runat="server" AutoPostBack="True"
         DataSourceID="SqlDSCategories"
         DataTextField="Title"
         DataValueField="CategoryId">
</asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:ListBox ID="ListBox1" runat="server"
                     AutoPostBack="True"
                     DataSourceID="SqlDSProducts"
                     DataTextField="Title"
                     DataValueField="ProductId"
                     OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
                <asp:SqlDataSource ID="SqlDSProducts" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ECommdbConStr %>"
                     SelectCommand="SELECT * FROM [Products] WHERE ([CategoryId] = @CategoryId)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" 
                            DefaultValue="2" Name="CategoryId" 
                            PropertyName="SelectedValue" 
                            Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

