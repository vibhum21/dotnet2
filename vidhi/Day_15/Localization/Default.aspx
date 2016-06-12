<%@ Page Language="VB"    MasterPageFile="~/site.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" title="Untitled Page" Theme="BasicBlue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyBooksConnectionString %>"
        SelectCommand="SELECT distinct[publisher] FROM [books]"></asp:SqlDataSource>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1"
        DataTextField="publisher" DataValueField="publisher">
    </asp:DropDownList>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete"
        InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetDataByPublisher"
        TypeName="BookTitlesTableAdapters.booksTableAdapter" UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_bookid" Type="String" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="bookid" Type="String" />
            <asp:Parameter Name="title" Type="String" />
            <asp:Parameter Name="author" Type="String" />
            <asp:Parameter Name="subject" Type="String" />
            <asp:Parameter Name="price" Type="String" />
            <asp:Parameter Name="category" Type="String" />
            <asp:Parameter Name="Original_bookid" Type="String" />
        </UpdateParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" DefaultValue="SAMS" Name="publisher"
                PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
        <InsertParameters>
            <asp:Parameter Name="bookid" Type="String" />
            <asp:Parameter Name="title" Type="String" />
            <asp:Parameter Name="author" Type="String" />
            <asp:Parameter Name="subject" Type="String" />
            <asp:Parameter Name="price" Type="String" />
            <asp:Parameter Name="category" Type="String" />
        </InsertParameters>
    </asp:ObjectDataSource>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="bookid"
        DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="bookid" HeaderText="bookid" ReadOnly="True" SortExpression="bookid" />
            <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
            <asp:BoundField DataField="author" HeaderText="author" SortExpression="author" />
            <asp:BoundField DataField="subject" HeaderText="subject" SortExpression="subject" />
            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
            <asp:BoundField DataField="category" HeaderText="category" SortExpression="category" />
        </Columns>
    </asp:GridView>
</asp:Content>

