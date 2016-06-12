<%@ Page Title="" Language="C#"
     MasterPageFile="~/site.master"
     AutoEventWireup="true" CodeFile="login.aspx.cs" 
    Inherits="login"
    Trace="true"
    
     %>

<%@ Register src="ClaimIdentifierControl.ascx" 
    tagname="ClaimIdentifierControl" 
    tagprefix="claimCtrl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" 
     runat="Server">
    <claimCtrl:ClaimIdentifierControl ID="ClaimIdentifierControl1"
         runat="server" />
</asp:Content>

