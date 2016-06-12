<%@ Page Language="VB" MasterPageFile="~/site.master" 
    AutoEventWireup="false" 
    CodeFile="LocalizationTest.aspx.vb"
    Inherits="LocalizationTest" 
    Culture="auto" UICulture="auto" 
    title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

 <div>
        <table>
            <tr>
                <td><asp:Label ID="Label1" runat="server"
                     Text="<%$ Resources:AppResources, FavoritesText %>">
                    </asp:Label>
               </td>
            </tr>
            <tr>
                <td><asp:Button ID="Button1" runat="server" 
                    Text="<%$ Resources:AppResources, LoginText %>" />
               </td>
            </tr>
            <tr>
                <td><asp:Button ID="Button2" runat="server" 
                    Text="<%$ Resources:AppResources, LogoutText %>" />
                </td>
            </tr>
        </table>
</div>
</asp:Content>

