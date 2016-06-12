<%@ Control Language="C#" AutoEventWireup="true"
     CodeFile="NavigationalCtrl.ascx.cs"
     Inherits="NavigationalCtrl" %>
<table class="auto-style1">
    <tr>
        <td>
            <asp:LinkButton ID="LinkButton1" runat="server">Home</asp:LinkButton>
        </td>
        <td>
            <asp:LinkButton ID="LinkButton2" runat="server">Courses</asp:LinkButton>
        </td>
        <td>
            <asp:LinkButton ID="LinkButton3" runat="server">Training Services</asp:LinkButton>
        </td>
        <td>
            <asp:LinkButton ID="LinkButton4" runat="server">Careers</asp:LinkButton>
        </td>
        <td>
            <asp:LinkButton ID="LinkButton5" runat="server">About Us</asp:LinkButton>
        </td>
        <td>
            <asp:LinkButton ID="LinkButton6" PostBackUrl="~/register.aspx" runat="server">Register</asp:LinkButton>
        </td>
    </tr>
</table>

