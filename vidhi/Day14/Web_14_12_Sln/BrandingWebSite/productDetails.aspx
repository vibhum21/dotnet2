<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="productDetails.aspx.cs" Inherits="productDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False"
         DataKeyNames="ProductId" DataSourceID="SqlProductDS"
         Height="50px" Width="125px" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
        <EditRowStyle BackColor="#999999" />
        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
        <Fields>
            <asp:BoundField DataField="ProductId" HeaderText="ProductId" InsertVisible="False"
                 ReadOnly="True" 
                SortExpression="ProductId" />
            <asp:BoundField DataField="Title" HeaderText="Title" 
                SortExpression="Title" />
            <asp:BoundField DataField="Brand" HeaderText="Brand" 
                SortExpression="Brand" />
            <asp:BoundField DataField="Description" HeaderText="Description"
                 SortExpression="Description" />
            <asp:BoundField DataField="ImageUrl" HeaderText="ImageUrl"
                 SortExpression="ImageUrl" />
            <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice"
                 SortExpression="UnitPrice" />
            <asp:BoundField DataField="CategoryId" HeaderText="CategoryId" 
                SortExpression="CategoryId" />
            <asp:BoundField DataField="Balance" HeaderText="Balance"
                 SortExpression="Balance" />
        </Fields>
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    </asp:DetailsView>
    <asp:SqlDataSource ID="SqlProductDS" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ECommdbConStr %>" 
        SelectCommand="SELECT * FROM [Products] WHERE ([ProductId] = @ProductId)">
        <SelectParameters>

            <asp:QueryStringParameter DefaultValue="2" 
                Name="ProductId"
                 QueryStringField="product" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

