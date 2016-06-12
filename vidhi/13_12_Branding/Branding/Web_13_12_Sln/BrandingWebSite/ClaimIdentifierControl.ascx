<%@ Control Language="C#" AutoEventWireup="true"
     CodeFile="ClaimIdentifierControl.ascx.cs"
     Inherits="ClaimIdentifierControl" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>

<table class="auto-style1">
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="User Name"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="btnSignIn" runat="server" Text="Sign In" OnClick="btnSignIn_Click" />
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="lblStatus" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td>
                                    <asp:LinkButton ID="LinkButton1" runat="server">New User</asp:LinkButton>
                                </td>
                                <td>
                                    <asp:LinkButton ID="LinkButton2" runat="server">Forgot Password</asp:LinkButton>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>

