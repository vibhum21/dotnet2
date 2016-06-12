<%@ Page Language="VB" MasterPageFile="~/AdWorksPage.master" 
    AutoEventWireup="false" CodeFile="accounting.aspx.vb" 
    Inherits="accounting"
     title="Untitled Page" %>

<asp:Content ID="MenuContentPlaceHolder" ContentPlaceHolderID="MenuContentPlaceHolder"
    runat="server">
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/default.aspx">
        Home</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/hr.aspx">
        HR</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/accounting.aspx">
        Accounting</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/legal.aspx">
        Legal</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/sales.aspx">
        Sales</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/training.aspx">
        Training</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/expenses.aspx">
        Expenses</asp:HyperLink>
</asp:Content>
<asp:Content ID="PageContentPlaceHolder" ContentPlaceHolderID="PageContentPlaceHolder"
    runat="server">
    Welcome<br />
    This is the Adventure Works Accouting page.
</asp:Content>
