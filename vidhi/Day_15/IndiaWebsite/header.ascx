<%@ Control Language="C#" AutoEventWireup="true" 
    CodeFile="header.ascx.cs"
     Inherits="header" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 119px;
    }
</style>

<table class="auto-style1">
    <tr>
        <td>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ForeColor="#FF3300" Text="TFL"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" ForeColor="#FF3300" Text="Transflower Learning Pvt. Ltd."></asp:Label>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:LinkButton ID="LinkButton1" runat="server">Home</asp:LinkButton>
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButton2" runat="server">Training</asp:LinkButton>
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButton3" runat="server">Consulting</asp:LinkButton>
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButton4" runat="server">Mentoring</asp:LinkButton>
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButton5" runat="server">Sales</asp:LinkButton>
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButton6" runat="server">Marketing</asp:LinkButton>
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButton7" runat="server">About Us</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>

